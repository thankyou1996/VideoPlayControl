using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_DaHua : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
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

        private int intLoginID = 0;
        private int intPlayID = 0;
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }
        public bool VideoClose()
        {
            bool bolResult = false;
            SDK_DaHua.CLIENT_StopSaveRealData(intPlayID);
            SDK_DaHua.CLIENT_StopRealPlay(intPlayID);
            SDK_DaHua.CLIENT_Logout(intLoginID);
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            return bolResult;
        }

        /// <summary>
        /// 大华视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            SDK_DaHua.NET_DEVICEINFO deviceInfo = new SDK_DaHua.NET_DEVICEINFO();
            int intError;
            intLoginID = SDK_DaHua.CLIENT_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out deviceInfo, out intError);
            if (intLoginID != 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });
                intPlayID = SDK_DaHua.CLIENT_RealPlay(intLoginID, CurrentCameraInfo.Channel - 1, intptrPlayMain);
                if (intPlayID != 0)
                {
                    if (CurrentVideoPlaySet.VideoRecordEnable)
                    {
                        string Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, CurrentVideoPlaySet.VideoRecordFileName);
                        SDK_DaHua.CLIENT_SaveRealData(intPlayID, Temp_strVideoRecord);
                    }
                    
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                }
                else
                {
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException });
                }
                
            }
            else
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
            }
            SDK_DaHua.CLIENT_OpenSound(intPlayID);
            //todo：录像
            return bolResult;
        }


        public string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            string strResult = strSavePath + strSaveName;
            if (!strResult.EndsWith(".dav"))
            {
                strResult = strSavePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            return strResult;
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return false;
        }

        public void VideoSizeChange(int intPosX, int intPosY, int intWidth, int intHeight)
        {

        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }
    }
}
