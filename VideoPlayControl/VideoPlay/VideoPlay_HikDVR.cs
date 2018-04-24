using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
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
        public Enum_VideoPlayState VideoPlayState { get ; set ; }

        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;
        #endregion
        private void VideoPlayEventCallBack(Enum_VideoPlayEventType eventType)
        {
            if (VideoPlayEventCallBackEvent != null)
            {
                VideoPlayEventCallBackEvent(this, eventType);
            }
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
            if (_intDVRHwd < 0)
            {
                //登陆失败
                bolResult = false;
            }


            NET_DVR_PREVIEWINFO lpPreviewInfo = new NET_DVR_PREVIEWINFO();
            lpPreviewInfo.hPlayWnd = intptrPlayMain;//预览窗口
            lpPreviewInfo.lChannel = CurrentCameraInfo.Channel;
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
            VideoPlayEventCallBack( Enum_VideoPlayEventType.VideoPlay);
            //NET_DVR_OpenSound(intRet);//140609
            if (intRet != -1)
            {
                VideoPlayState = Enum_VideoPlayState.InPlayState;
                if (CurrentVideoPlaySet.VideoRecordEnable)
                {
                    if (string.IsNullOrEmpty(CurrentVideoPlaySet.VideoRecordFilePath) || !CurrentVideoPlaySet.VideoRecordFilePath.ToUpper().EndsWith(".mp4"))
                    {
                        CurrentVideoPlaySet.VideoRecordFilePath = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
                    }
                    if (NET_DVR_SaveRealData(intRet, CurrentVideoPlaySet.VideoRecordFilePath))
                    {
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.StartVideoRecord);
                    }
                    else
                    {
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.StartVideoRecordException);
                    }
                }
            }
            return bolResult;
        }
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {

        }

        public bool VideoClose()
        {
            NET_DVR_StopRealPlay(intRet);
            NET_DVR_Logout(_intDVRHwd);
            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
            return true;
        }
    }
}
