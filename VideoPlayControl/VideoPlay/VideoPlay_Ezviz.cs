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
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }

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
                Ezviz_GenerateRecord(CurrentVideoPlaySet.VideoRecordFilePath);
                //if (Ezviz_gchVideoRecord != null && Ezviz_gchVideoRecord.IsAllocated)
                //{
                //    Ezviz_gchVideoRecord.Free();
                //}
            }
            else
            {
                lstVideoRecord = new List<byte>();
            }
            intptrSessionID = IntPtr.Zero;
            return bolResult;
        }



        /// <summary>
        /// 萤石生成录像文件
        /// </summary>
        /// <param name="strRecFilePath"></param>
        private void Ezviz_GenerateRecord(string strRecFilePath = "")
        {
            if (lstVideoRecord.Count > 0)
            {
                if (string.IsNullOrEmpty(strRecFilePath))
                {
                    //不存在路径 使用默认路径 
                    //默认路径格式 [当前工作路径/EzvizRecFile/萤石云编号/时间(yyyyMMddHHmmss)_通道号(01).mp4]
                    StringBuilder sbRecDicPath = new StringBuilder();
                    sbRecDicPath.Append(ProgConstants.strEzviz_RecDicPath);    //默认路径
                    sbRecDicPath.Append("\\" + CurrentVideoInfo.DVSAddress);    //萤石云编号
                    if (!Directory.Exists(sbRecDicPath.ToString()))
                    {
                        //文件夹不存在，创建文件夹
                        Directory.CreateDirectory(sbRecDicPath.ToString());
                    }
                    StringBuilder sbRecFilePath = new StringBuilder();
                    sbRecFilePath.Append(sbRecDicPath.ToString());
                    sbRecFilePath.Append("\\" + DateTime.Now.ToString("yyyyMMddHHmmss"));     //时间
                    sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));   //通道号
                    sbRecFilePath.Append(".mp4");
                    strRecFilePath = sbRecFilePath.ToString();
                }
                else if (!strRecFilePath.EndsWith(".mp4"))
                {
                    //后缀名错误或者只指定文件夹
                    if (!Directory.Exists(strRecFilePath.ToString()))
                    {
                        //文件夹不存在，创建文件夹
                        Directory.CreateDirectory(strRecFilePath.ToString());
                    }
                    StringBuilder sbRecFilePath = new StringBuilder();
                    sbRecFilePath.Append(strRecFilePath);
                    //路径格式 [传入的路径/摄像机编号_通道号（BCD 向左补足2位)_时间(yyyyMMddHHmmss)_13(固定码 萤石13).mp4]
                    sbRecFilePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                    sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                    sbRecFilePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                    sbRecFilePath.Append("_" + "13.mp4");                                                   //分类后缀及文件格式
                    strRecFilePath = sbRecFilePath.ToString();
                }
                byte[] Temp_b = lstVideoRecord.ToArray();
                using (FileStream f = File.OpenWrite(strRecFilePath))
                {
                    f.Write(Temp_b, 0, Temp_b.Length);
                }
                lstVideoRecord = new List<byte>();
            }
        }

        public bool VideoPlay()
        {
            CommonMethod.LogWrite.WriteEventLog("EzvizLog", "VidePlay1_" + CurrentVideoInfo.DVSNumber + CurrentVideoInfo.DVSAddress, ProgParameter.ProgLogAddress);
            if (intptrSessionID != IntPtr.Zero)
            {
                //句柄不为空，先进行视频
                VideoClose();
            }
            CommonMethod.LogWrite.WriteEventLog("EzvizLog", "VidePlay2_" + CurrentVideoInfo.DVSNumber + CurrentVideoInfo.DVSAddress, ProgParameter.ProgLogAddress);
            bool bolResult = false;
            SDKState.Ezviz_SDKInit();
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
                Ezviz_DataCallBack = new SDK_EzvizSDK.DataCallBack(Ezviz_DataCallBackEvent);
                Ezviz_gchVideoRecord = GCHandle.Alloc(Ezviz_DataCallBack);
                intResult = SDK_EzvizSDK.OpenSDK_SetDataCallBack(intptrSessionID, Ezviz_DataCallBack, iUser);
            }
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            if (CurrentVideoInfo.DVSAddress.StartsWith("C"))
            {
                intResult = SDK_EzvizSDK.OpenSDK_StartPlayWithStreamType(intptrSessionID, intptrPlayMain, intptrdevSerial, CurrentCameraInfo.Channel, CurrentVideoInfo.Password, 1);
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
                byte[] managedArray = new byte[iLen];
                Marshal.Copy(pData, managedArray, 0, iLen);
                string strUser = Marshal.PtrToStringAnsi(pUser);
                lstVideoRecord.AddRange(managedArray);
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
    }
}
