using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDK_HikClientSDK;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_HikDVR : IVideoPlay
    {


        #region 全局变量
        int _intDVRHwd;
        int intRet;

        public VideoInfo CurrentVideoInfo { get ; set; }
        public CameraInfo CurrentCameraInfo { get ; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get ; set ; }
        public IntPtr intptrPlayMain { get ; set ; }
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
                lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
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

                //NET_DVR_OpenSound(intRet);//140609
                if (intRet != -1)
                {
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
            return bolResult;

        }

        public bool VideoClose()
        {
            NET_DVR_StopRealPlay(intRet);
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

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }
    }
}
