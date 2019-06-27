using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoInfoSet
{
    public class VideoInfoSet_Default : IVideoInfoSet
    {
        public bool SyncOSDInfo_Download(VideoInfo vInfo)
        {
            return false;
        }

        public bool SyncOSDInfo_Upload(VideoInfo vInfo)
        {
            return false;
        }
    }
}
