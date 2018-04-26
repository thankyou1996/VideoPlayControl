using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay
{
    public class Video_HikStream : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CameraInfo CurrentCameraInfo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public VideoPlaySetting CurrentVideoPlaySet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IntPtr intptrPlayMain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Enum_VideoPlayState VideoPlayState { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;

        public bool VideoClose()
        {
            throw new NotImplementedException();
        }

        public bool VideoPlay()
        {
            throw new NotImplementedException();
        }
    }
}
