using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_SKNVideo:IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        public Enum_VideoPlayState VideoPlayState { get; set; }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }

        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;
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
            SDK_SKNVideo.SDK_NSK_CLIENT_close_rt_video(intptrPlayMain);
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }

        public bool VideoPlay()
        {
            bool bolResult = false;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            string Temp_strVideoRecord = null;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //启用录像
                if (!CurrentVideoPlaySet.VideoRecordFilePath.EndsWith(".h264"))
                {

                    CurrentVideoPlaySet.VideoRecordFilePath = CurrentVideoPlaySet.VideoRecordFilePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
                }
                Temp_strVideoRecord = CurrentVideoPlaySet.VideoRecordFilePath;
            }
           
            SDK_SKNVideo.SDK_NSK_CLIENT_open_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel, 2, intptrPlayMain, Temp_strVideoRecord, "");
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return bolResult;
            //throw new NotImplementedException();
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            throw new NotImplementedException();
        }

        public bool VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            throw new NotImplementedException();
        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }
    }
}
