using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDK_HikClientSDK;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 海康
    /// </summary>
    public class VideoPlay_HikDVR : IVideoPlay
    {
        public VideoPlay_HikDVR(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_HikDVR(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        public VideoPlay_HikDVR()
        {
            HikColoseCoundEvent += VideoPlayWindow_HikColoseCoundEvent;
        }

        /// <summary>
        /// 海康设备关闭对讲通道事件注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="objHikCloseSoundValue"></param>
        private void VideoPlayWindow_HikColoseCoundEvent(object sender, object objHikCloseSoundValue)
        {
            SoundState = Enum_VideoPlaySoundState.SoundColse;
        }
        #region 全局变量
        int _intDVRHwd;
        int intRet;

        public VideoInfo CurrentVideoInfo { get ; set; }
        public CameraInfo CurrentCameraInfo { get ; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get ; set ; }

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
            }
        }
        delegate IntPtr GetPicPlayMainHandleDelegate(PictureBox pic);
        public IntPtr GetPicPlayMainHandle(PictureBox pic)
        {
            if (pic.InvokeRequired)
            {
                GetPicPlayMainHandleDelegate delegate1 = new GetPicPlayMainHandleDelegate(GetPicPlayMainHandle);
                return (IntPtr)pic.Invoke(delegate1, new object[] { pic });
            }
            else
            {
                return pic.Handle;
            }
        }

        public IntPtr intptrPlayMain
        {
            get
            {
                if (PicPlayMain.IsHandleCreated)
                {
                    return GetPicPlayMainHandle(PicPlayMain);
                }
                return IntPtr.Zero;
            }
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
        #endregion
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

        public bool VideoPlay()
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                VideoClose();
            }
            bool bolResult = false;
            NET_DVR_DEVICEINFO_V30 dev = new NET_DVR_DEVICEINFO_V30();
            _intDVRHwd = NET_DVR_Login_V30(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref dev);
            if (_intDVRHwd >= 0)
            {
                dwAChanTotalNum = (uint)dev.byChanNum;
                if (dev.byIPChanNum > 0)
                {
                    InfoIPChannel();
                }
                else
                {
                    for (iip = 0; iip < dwAChanTotalNum; iip++)
                    {
                        iChannelNum[iip] = iip + (int)dev.byStartChan;
                    }
                }

                NET_DVR_PREVIEWINFO lpPreviewInfo = new NET_DVR_PREVIEWINFO();
                lpPreviewInfo.hPlayWnd = intptrPlayMain;//预览窗口
                if (dev.byIPChanNum == 0)
                {
                    lpPreviewInfo.lChannel = CurrentCameraInfo.Channel;
                    //SaveNetLog("播放通道" + channel.ToString());
                }
                else
                {
                    lpPreviewInfo.lChannel = iChannelNum[CurrentCameraInfo.Channel - 1];
                }
                lpPreviewInfo.dwStreamType = 1;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
                lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
                lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流


                //NET_DVR_CLIENTINFO cli = new NET_DVR_CLIENTINFO();
                //cli.lLinkMode = 0;// 设置连接方式  /*  最高位(31)为 0 表示主码流，为 1 表示子码流，0－30 位表示码流连接方式：0：TCP方式,1：UDP 方式,2：多播方式,3 - RTP方式，4—音视频分开 */ 
                //cli.lChannel = channel + 32;
                //cli.hPlayWnd = playHandle;

                // 开始播放视频
                //Thread.Sleep(50);


                
                IntPtr pUser = new IntPtr();
                REALDATACALLBACK RealData = new REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数

                //intRet = NET_DVR_RealPlay_V30(_intDVRHwd, ref cli, null, pUser, 1);//130814
                intRet = NET_DVR_RealPlay_V40(_intDVRHwd, ref lpPreviewInfo, null, pUser);//140521

                
                if (intRet != -1)
                {
                    if (CurrentVideoPlaySet.VideoMonitorEnable)
                    {
                        OpenSound();
                    }
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    if (CurrentVideoPlaySet.VideoRecordEnable)
                    {
                        StartVideoRecord(CurrentVideoPlaySet.VideoRecordFilePath);
                    }
                }
                else
                {
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException });
                }
            }
            else
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
                //登陆失败
                bolResult = false;
            }


            
            return bolResult;
        }

        private int[] iChannelNum = new int[96];
        private uint dwAChanTotalNum = 0;
        private Int32 iip = 0;
        public void InfoIPChannel()
        {

            NET_DVR_IPPARACFG_V40 m_struIpParaCfgV40 = new NET_DVR_IPPARACFG_V40();
            NET_DVR_DEVICEINFO_V30 DeviceInfo = new NET_DVR_DEVICEINFO_V30();
            NET_DVR_STREAM_MODE m_struStreamMode = new NET_DVR_STREAM_MODE();
            NET_DVR_IPCHANINFO m_struChanInfo = new NET_DVR_IPCHANINFO();

            NET_DVR_IPCHANINFO_V40 m_struChanInfoV40 = new NET_DVR_IPCHANINFO_V40();

            uint dwSize = (uint)Marshal.SizeOf(m_struIpParaCfgV40);

            IntPtr ptrIpParaCfgV40 = Marshal.AllocHGlobal((Int32)dwSize);
            Marshal.StructureToPtr(m_struIpParaCfgV40, ptrIpParaCfgV40, false);

            uint dwReturn = 0;
            if (!NET_DVR_GetDVRConfig(_intDVRHwd, NET_DVR_GET_IPPARACFG_V40, 0, ptrIpParaCfgV40, dwSize, ref dwReturn))
            {
            }
            else
            {
                m_struIpParaCfgV40 = (NET_DVR_IPPARACFG_V40)Marshal.PtrToStructure(ptrIpParaCfgV40, typeof(NET_DVR_IPPARACFG_V40));

                for (iip = 0; iip < dwAChanTotalNum; iip++)
                {
                    iChannelNum[iip] = iip + (int)DeviceInfo.byStartChan + 1;
                    //iChannelNum[iip] = iip + (int)DeviceInfo.byStartChan;   
                }

                byte byStreamType;
                for (iip = 0; iip < m_struIpParaCfgV40.dwDChanNum; iip++)
                {
                    iChannelNum[iip + dwAChanTotalNum] = iip + (int)m_struIpParaCfgV40.dwStartDChan;
                    byStreamType = m_struIpParaCfgV40.struStreamMode[iip].byGetStreamType;
                    switch (byStreamType)
                    {
                        //目前NVR仅支持0- 直接从设备取流一种方式 NVR supports only one mode: 0- get stream from device directly
                        case 0:
                            dwSize = (uint)Marshal.SizeOf(m_struStreamMode);
                            IntPtr ptrChanInfo = Marshal.AllocHGlobal((Int32)dwSize);
                            Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[iip].uGetStream, ptrChanInfo, false);
                            m_struChanInfo = (NET_DVR_IPCHANINFO)Marshal.PtrToStructure(ptrChanInfo, typeof(NET_DVR_IPCHANINFO));
                            Marshal.FreeHGlobal(ptrChanInfo);
                            break;
                        case 6:
                            IntPtr ptrChanInfoV40 = Marshal.AllocHGlobal((Int32)dwSize);
                            Marshal.StructureToPtr(m_struIpParaCfgV40.struStreamMode[iip].uGetStream, ptrChanInfoV40, false);
                            m_struChanInfoV40 = (NET_DVR_IPCHANINFO_V40)Marshal.PtrToStructure(ptrChanInfoV40, typeof(NET_DVR_IPCHANINFO_V40));

                            //列出IP通道 List the IP channel 
                            //iIPDevID[i] = m_struChanInfoV40.wIPID - iGroupNo * 64 - 1;

                            Marshal.FreeHGlobal(ptrChanInfoV40);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {

        }

        private bool StartVideoRecord(string strRecFilePath)
        {
            bool bolResult = false;
            StringBuilder sbRecFilePath = new StringBuilder();
            if (string.IsNullOrEmpty(strRecFilePath))
            {
                //不存在路径 使用默认路径 
                strRecFilePath = ProgConstants.strHikVideo_RecDicPath + "\\" + CurrentVideoInfo.DVSAddress;    //默认路径
                if (!Directory.Exists(strRecFilePath))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(strRecFilePath);
                }
            }
            if (!strRecFilePath.EndsWith(".mp4"))
            {
                //后缀错误，使用默认文件生成
                //默认路径格式 [当前工作路径/HikVideoRecFile/DVSAddress/DNSNum_Channnel_起始时间（yyyyMMddHHmmss）_主机类型区分.后缀]
                strRecFilePath += "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            if (NET_DVR_SaveRealData(intRet, strRecFilePath))
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StartVideoRecord });
                bolResult = true;
            }
            else
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StartVideoRecordException });
                bolResult = false;
            }
            VideoRecordStatus = true;
            return bolResult;

        }

        public bool VideoClose()
        {
            if (SoundState == Enum_VideoPlaySoundState.SoundOpen)
            {
                //关闭音频
                CloseSound();
            }
            NET_DVR_StopRealPlay(intRet);
            VideoRecordStatus = false;
            NET_DVR_Logout(_intDVRHwd);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return true;
        }

        public void VideoSizeChange(int intPosX, int intPosY, int intWidth, int intHeight)
        {

        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return false;
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
        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
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
        /// 打开声音通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            //手动关闭,确认只有一个声音在播放
            HikCloseSound(this, null);
            if (NET_DVR_OpenSound(intRet))
            {
                SoundState = Enum_VideoPlaySoundState.SoundOpen;
                bolResult = true;
            }
            return bolResult;
        }

        /// <summary>
        /// 关闭声音通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            //统一通过  HikColoseCoundEvent 置为音频关闭状态
            HikCloseSound(this, null);
            SoundState = Enum_VideoPlaySoundState.SoundColse;
            bolResult = true;
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
