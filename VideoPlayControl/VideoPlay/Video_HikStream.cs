using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public class Video_HikStream : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CameraInfo CurrentCameraInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public VideoPlaySetting CurrentVideoPlaySet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IntPtr intptrPlayMain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public int VideoplayWindowWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VideoplayWindowHeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

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
        public bool VideoClose()
        {
            throw new NotImplementedException();
        }

        public bool VideoPlay()
        {
            throw new NotImplementedException();
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
