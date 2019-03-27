using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public interface IVIdeoRemoteBackplay
    {
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        bool FindRemoteFile(VideoRemotePlaySearchPara para);

    }
}
