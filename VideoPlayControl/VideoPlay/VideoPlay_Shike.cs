using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_Shike : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CameraInfo CurrentCameraInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public VideoPlaySetting CurrentVideoPlaySet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IntPtr intptrPlayMain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enum_VideoPlayState VideoPlayState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VideoplayWindowWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int VideoplayWindowHeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;

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
            throw new NotImplementedException();
        }

        public bool VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            throw new NotImplementedException();
        }
    }
}
