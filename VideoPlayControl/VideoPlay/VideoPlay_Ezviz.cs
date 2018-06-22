using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_Ezviz : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        public Enum_VideoPlayState VideoPlayState { get; set; }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }
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
