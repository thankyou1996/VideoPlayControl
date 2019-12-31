using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 珠海三润
    /// </summary>
    public class VideoPlay_ZHSR : IVideoPlay_Basic
    {
        public VideoPlay_ZHSR(CameraInfo cInfo)
        {
            this.CurrentCameraInfo = cInfo;
            this.CurrentVideoInfo = cInfo.VideoInfo;
        }

    }
}
