using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 萤石
    /// </summary>
    public class VideoPlay_Ezviz : IVideoPlay
    {
        public VideoPlay_Ezviz(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_Ezviz(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }

        /// <summary>
        /// 当前码流类型
        /// </summary>
        private Enum_VideoStream videoStream = Enum_VideoStream.SubStream;
        /// <summary>
        /// 码流类型
        /// 如果当前处于视频播放状态 修改时会重新进入视频播放
        /// </summary>
        public Enum_VideoStream VideoStream
        {
            get { return videoStream; }
            set
            {
                SetVideoStream(value);
            }
        }
        /// <summary>
        /// 设置码流信息
        /// 如果当前处于视频播放状态 会关闭视频后 重新进入视频播放
        /// </summary>
        /// <param name="vs"></param>
        private void SetVideoStream(Enum_VideoStream vs)
        {
            if (vs != videoStream)
            {
                videoStream = vs;
                if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                {
                    //处于播放中 关闭视频后切换码流后播放
                    VideoClose();
                    VideoPlay();
                }
                VideoStreamChanged(null);
            }
        }

        /// <summary>
        /// 码流改变事件
        /// </summary>
        public event VideoStreamChangedDelegate VideoStreamChangedEvent;
        /// <summary>
        /// 码流改变
        /// </summary>
        /// <param name="VideoStreamChangedValue"></param>
        private void VideoStreamChanged(object VideoStreamChangedValue)
        {
            if (VideoStreamChangedEvent != null)
            {
                VideoStreamChangedEvent(this, VideoStreamChangedValue);
            }
        }

        private PictureBox picPlayMain = null;
        public PictureBox PicPlayMain
        {
            get
            {
                return picPlayMain;
            }

            set
            {
                picPlayMain = value;
                intptrPlayMain = picPlayMain.Handle;
            }
        }
        public IntPtr intptrPlayMain
        {
            get;
            private set;
        }
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;
        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState != value)
                {
                    videoPlayState = value;
                    if (VideoPlayStateChangedEvent != null)
                    {
                        VideoPlayStateChangedEvent(this, null);
                    }
                }
            }
        }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;

        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        #region 全局变量 

        IntPtr intptrSessionID = IntPtr.Zero;
        SDK_EzvizSDK.MsgHandler callBack;
        SDK_EzvizSDK.DataCallBack Ezviz_DataCallBack;
        GCHandle Ezviz_gchMsgBack;
        GCHandle Ezviz_gchVideoRecord;
        IntPtr iUser = IntPtr.Zero;
        string strUser = "";
        List<byte> lstVideoRecord = new List<byte>();
        /// <summary>
        /// 录像数据写入文件 128K
        /// </summary>
        int intVideoRecordWriteFlag = 128 * 1024;
        /// <summary>
        /// 录像文件最大限制 64M （高清约4~5分钟）
        /// </summary>
        //int intVideoRecordMaxValue = 128 * 1024 * 1024;
        int intVideoRecordMaxValue = 32 * 1024 * 1024;
        /// <summary>
        /// 录像地址
        /// </summary>
        string strRealSavePath = "";
        #endregion

        public bool VideoClose()
        {
            CommonMethod.LogWrite.WriteEventLog("EzvizLog", "VideClose", ProgParameter.ProgLogAddress);
            bool bolResult = false;
            SDK_EzvizSDK.OpenSDK_StopRealPlayEx(intptrSessionID);
            SDK_EzvizSDK.OpenSDK_FreeSession(intptrSessionID.ToString());

            //if (Ezviz_gchMsgBack != null && Ezviz_gchMsgBack.IsAllocated)
            //{
            //    Ezviz_gchMsgBack.Free();
            //}
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                byte[] bytsSource = lstVideoRecord.ToArray();
                lstVideoRecord.Clear();
                Ezviz_GenerateRecord(bytsSource, strRealSavePath);
                //if (Ezviz_gchVideoRecord != null && Ezviz_gchVideoRecord.IsAllocated)
                //{
                //    Ezviz_gchVideoRecord.Free();
                //}
            }
            else
            {
                lstVideoRecord = new List<byte>();
            }
            VideoRecordStatus = false;
            intptrSessionID = IntPtr.Zero;
            strRealSavePath = "";
            if (ProgParameter.Ezviz_VideoPlayEnvironmentReset)
            {
                SDKState.Ezviz_SDKRelease();
            }
            return bolResult;
        }


        /// <summary>
        /// 萤石生成录像文件
        /// </summary>
        /// <param name="bytsSource"></param>
        /// <param name="strRecFilePath"></param>
        /// <returns></returns>
        public bool Ezviz_GenerateRecord(byte[] bytsSource, string strRecFilePath)
        {
            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss:fff") + "_开始写入文件_" + lstVideoRecord.Count);
            if (string.IsNullOrEmpty(strRecFilePath) || bytsSource.Length == 0)
            {
                return false;
            }
            bool bolResult = false;
            using (FileStream f =new FileStream(strRecFilePath,FileMode.Append))
            {
                f.Write(bytsSource, 0, bytsSource.Length);
                if (f.Length > intVideoRecordMaxValue)
                {
                    //超过最大限制，关闭视频
                    strRealSavePath = "";   //文件地址置置为默认值，在VideoClose 中则不会调用 Ezviz_GenerateRecord。
                    VideoClose();
                }
            }
            //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss:fff") + "_完成写入文件_" + lstVideoRecord.Count);
            return bolResult;
        }



        private string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            StringBuilder sbSavePath = new StringBuilder();
            if (string.IsNullOrEmpty(strSavePath))
            {
                sbSavePath.Append(strSavePath);
                sbSavePath.Append(ProgConstants.strEzviz_RecDicPath);    //默认路径
                sbSavePath.Append("\\" + CurrentVideoInfo.DVSAddress);    //萤石云编号
                if (!Directory.Exists(sbSavePath.ToString()))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(sbSavePath.ToString());
                }
            }
            else
            {
                sbSavePath.Append(strSavePath);
            }

            if (string.IsNullOrEmpty(strSaveName) || !strSaveName.EndsWith(".mp4"))
            {
                sbSavePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                sbSavePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                sbSavePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                sbSavePath.Append("_" + "13.mp4");                                                   //分类后缀及文件格式
            }
            else
            {
                sbSavePath.Append("\\" + strSaveName);
            };
            return sbSavePath.ToString();
        }



        public bool VideoPlay()
        {
            strRealSavePath = "";
            CommonMethod.LogWrite.WriteEventLog("EzvizLog", "VidePlay1_" + CurrentVideoInfo.DVSNumber + CurrentVideoInfo.DVSAddress, ProgParameter.ProgLogAddress);
            if (intptrSessionID != IntPtr.Zero)
            {
                //句柄不为空，先进行视频
                VideoClose();
            }
            CommonMethod.LogWrite.WriteEventLog("EzvizLog", "VidePlay2_" + CurrentVideoInfo.DVSNumber + CurrentVideoInfo.DVSAddress, ProgParameter.ProgLogAddress);
            bool bolResult = false;
            if (ProgParameter.Ezviz_VideoPlayEnvironmentReset)
            {
                SDKState.Ezviz_SDKInit();
            }
            Ezviz_VideoPlay();          //萤石云设备
            return bolResult;
        }

        private bool Ezviz_VideoPlay()
        {

            bool bolResult = false;
            int intLenght = 0;
            int intResult = 0;
            //CurrentVideoInfo.NetworkState = SDK_EzvizSDK.GetDevOnlineState(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel);
            int Temp_intResult = SDK_EzvizSDK.GetDevOnlineState(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel);
            if (Temp_intResult == -2)
            {
                //设备无权限
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.NoDeviceAuthority });
                return bolResult;
            }
            CurrentVideoInfo.NetworkState = Temp_intResult;
            if (Temp_intResult == 0)
            {
                //设备离线
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoDeviceNotOnline });
                return bolResult;
            }
            //状态未明进行连接
            callBack = new SDK_EzvizSDK.MsgHandler(Ezviz_MsgCallback);
            Ezviz_gchMsgBack = GCHandle.Alloc(callBack);
            strUser = CurrentVideoInfo.DVSAddress + "_" + CurrentCameraInfo.Channel;
            iUser = Marshal.StringToHGlobalAnsi(strUser);
            VideoPlayState = Enum_VideoPlayState.Connecting;
            intResult = SDK_EzvizSDK.OpenSDK_AllocSessionEx(callBack, iUser, out intptrSessionID, out intLenght);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //录像启用
                strRealSavePath = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, CurrentVideoPlaySet.VideoRecordFileName);
                if (!Directory.Exists(CurrentVideoPlaySet.VideoRecordFilePath))
                {
                    Directory.CreateDirectory(CurrentVideoPlaySet.VideoRecordFilePath);
                }
                Ezviz_DataCallBack = new SDK_EzvizSDK.DataCallBack(Ezviz_DataCallBackEvent);
                Ezviz_gchVideoRecord = GCHandle.Alloc(Ezviz_DataCallBack);
                intResult = SDK_EzvizSDK.OpenSDK_SetDataCallBack(intptrSessionID, Ezviz_DataCallBack, iUser);
                VideoRecordStatus = true;
            }
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            if (CurrentVideoInfo.DVSAddress.StartsWith("C"))
            {
                intResult = SDK_EzvizSDK.OpenSDK_StartPlayWithStreamType(intptrSessionID, intptrPlayMain, intptrdevSerial, CurrentCameraInfo.Channel, CurrentVideoInfo.Password, -1);
            }
            else
            {
                intResult = SDK_EzvizSDK.OpenSDK_StartRealPlayEx(intptrSessionID, intptrPlayMain, intptrdevSerial, CurrentCameraInfo.Channel, CurrentVideoInfo.Password);
            }
            if (intResult == 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnSuccess });
            }
            else
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnFailed });
            }
            return bolResult;
        }

        /// <summary>
        /// 消息事件回调
        /// </summary>
        /// <param name="intptrSessionId"></param>
        /// <param name="iMsgType"></param>
        /// <param name="iErrorCode"></param>
        /// <param name="pMessageInfo"></param>
        /// <param name="pUser"></param>
        public void Ezviz_MsgCallback(IntPtr intptrSessionId, SDK_EzvizSDK.EzvizMeesageType iMsgType, uint iErrorCode, string pMessageInfo, IntPtr pUser)
        {
            string Temp_strUserName = Marshal.PtrToStringAnsi(pUser);
            if (Temp_strUserName == strUser)
            {
                string strTag = "";
                Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
                switch (iMsgType)
                {
                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_EXCEPTION:
                        switch (iErrorCode)
                        {
                            case 2012:
                                //密码错误 ，自己测试验证，非官方确认
                                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.UserAccessError });
                                break;
                            case 2651:
                                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DeviceStreamTypeException });
                                break;
                            case 2604:
                                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoDeviceNotOnline });
                                break;
                            default:
                                VideoPlayCallback(new VideoPlayCallbackValue { evType = (Enum_VideoPlayEventType)iErrorCode });
                                break;
                        }
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_RECONNECT:
                        VideoPlayState = Enum_VideoPlayState.Connecting;

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_RECONNECT_EXCEPTION:
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnFailed });
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_START:
                        CurrentVideoInfo.NetworkState = 1;          //置为在线
                        VideoPlayState = Enum_VideoPlayState.InPlayState;
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_STOP:

                        VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_ARCHIVE_END:
                        //VideoPlayState = Enum_VideoPlayState.NotInPlayState;

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_START:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_STOP:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZ_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_FILE:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_SEARCH_END:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_SEARCH_FAILED:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_DEFENSE_SUCCESS:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_DEFENSE_FAILED:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_ARCHIVE_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZCTRL_SUCCESS:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZCTRL_FAILED:

                        break;
                }
                if (videoEvType == Enum_SDKEventType.Unrecognized)
                {
                    strTag = strTag = iMsgType.ToString();
                }
                //SDKEventCallBack(videoEvType, strTag);
            }
        }

        /// <summary>
        /// 萤石数据回调
        /// </summary>
        /// <param name="enType"></param>
        /// <param name="pData"></param>
        /// <param name="iLen"></param>
        /// <param name="pUser"></param>
        public void Ezviz_DataCallBackEvent(SDK_EzvizSDK.DataType enType, IntPtr pData, int iLen, IntPtr pUser)
        {
            if (CurrentVideoPlaySet.VideoRecordEnable)  //预防未其余窗口启用录像导致数据异常
            {
                //Console.WriteLine(DateTime.Now.ToString("HH:mm:ss:fff") + "_收到回调数据_" + iLen);
                byte[] managedArray = new byte[iLen];
                Marshal.Copy(pData, managedArray, 0, iLen);
                string strUser = Marshal.PtrToStringAnsi(pUser);
                lstVideoRecord.AddRange(managedArray);

                if (lstVideoRecord.Count > intVideoRecordWriteFlag)
                {
                    byte[] bytsSource = lstVideoRecord.ToArray();
                    lstVideoRecord.Clear();
                    Ezviz_GenerateRecord(bytsSource, strRealSavePath);
                }
            }
        }


        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            bool bolResult = false;
            SDK_EzvizSDK.PTZAction ptzAction = bolStart ? SDK_EzvizSDK.PTZAction.START : SDK_EzvizSDK.PTZAction.STOP;
            SDK_EzvizSDK.PTZCommand ptzCommand = SDK_EzvizSDK.PTZCommand.AUTO;
            switch (PTZControl)
            {
                case Enum_VideoPTZControl.PTZControl_Up:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UP;
                    break;
                case Enum_VideoPTZControl.PTZControl_Down:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWN;
                    break;
                case Enum_VideoPTZControl.PTZControl_Left:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.LEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_Right:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.RIGHT;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftUp:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UPLEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftDown:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWNLEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightUp:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UPRIGHT;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightDown:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWNRIGHT;
                    break;
            }
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            SDK_EzvizSDK.OpenSDK_PTZCtrlEx(intptrSessionID, intptrdevSerial, CurrentCameraInfo.Channel, ptzCommand, ptzAction, 3);
            return bolResult;
        }
        /// <summary>
        /// 联动预置点
        /// </summary>
        /// <param name="intPrestValue"></param>
        /// <returns></returns>
        public bool LinkagePresetPoint(int intPrestValue)
        {
            return false;
        }
        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {

        }

        public bool VideoPlayEx()
        {
            bool bolResult = false;
            ThreadStart thrAnsyPlay = delegate//160418
            {
                Ezviz_VideoPlay();          //萤石云设备
            };
            new Thread(thrAnsyPlay).Start();
            return bolResult;
        }

        #region 音频相关
        private Enum_VideoPlaySoundState soundState = Enum_VideoPlaySoundState.SoundColse;

        /// <summary>
        /// 音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState
        {
            get { return soundState; }
            set
            {
                if (soundState != value)
                {
                    soundState = value;
                    SoundStateChanged();
                }
            }
        }

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        public event SoundStateChangedDelegate SoundStateChangedEvent;

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        /// <returns></returns>
        private bool SoundStateChanged()
        {
            bool bolResult = false;
            if (this.SoundStateChangedEvent != null)
            {
                bolResult = SoundStateChangedEvent(this, null);
            }
            return bolResult;
        }

        /// <summary>
        /// 打开音频通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            if (SDK_EzvizSDK.OpenSDK_OpenSound(intptrSessionID) == 0)
            {
                SoundState = Enum_VideoPlaySoundState.SoundOpen;
                bolResult = true;
            }
            return bolResult;
        }

        /// <summary>
        /// 关闭音频通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            if (SDK_EzvizSDK.OpenSDK_CloseSound(intptrSessionID) == 0)
            {
                SoundState = Enum_VideoPlaySoundState.SoundColse;
                bolResult = true;
            }
            return bolResult;
        }
        #endregion

        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        public event VideoRecordStatusChangedDelegate VideoRecordStausChangedEvent;
        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        /// <param name="VideoRecordStatusChangedValue"></param>
        private void VideoRecordStausChanged(object VideoRecordStatusChangedValue)
        {
            if (VideoRecordStausChangedEvent != null)
            {
                VideoRecordStausChangedEvent(this, VideoRecordStatusChangedValue);
            }
        }

        private bool bolVideoRecordStatus = false;
        /// <summary>
        /// 视频录像状态 true 表示正在录像 false表示未处于录像中
        /// </summary>
        public bool VideoRecordStatus
        {
            get { return bolVideoRecordStatus; }
            private set
            {
                if (bolVideoRecordStatus != value)
                {
                    bolVideoRecordStatus = value;
                    VideoRecordStausChanged(null);
                };
            }
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public bool StartVideoRecord(VideoRecordSet vrSet)
        {
            bool bolResult = true;
            CurrentVideoPlaySet.VideoRecordEnable = vrSet.Enable;
            CurrentVideoPlaySet.VideoRecordFilePath = vrSet.VideoRecordFilePath;
            CurrentVideoPlaySet.VideoRecordFileName = vrSet.VideoRecordFileName;
            CurrentVideoPlaySet.VideoRecordFilePath_Server = vrSet.VideoRecordFilePath_Server;
            CurrentVideoPlaySet.VideoRecordFileName_Server = vrSet.VideoRecordFileName_Server;
            CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond = vrSet.TimeOutVideoRecordCloseSecond;
            //关闭视频
            VideoClose();
            //打开视频
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 关闭录像（不关闭视频）
        /// </summary>
        /// <returns></returns>
        public bool StopVideoRecord()
        {
            bool bolResult = false;
            VideoClose();
            CurrentVideoPlaySet.VideoRecordEnable = false;
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="snapSet"></param>
        /// <returns></returns>
        public bool Snap(VideoSnapSet snapSet)
        {
            bool bolResult = false;

            return bolResult;
        }
    }
}
