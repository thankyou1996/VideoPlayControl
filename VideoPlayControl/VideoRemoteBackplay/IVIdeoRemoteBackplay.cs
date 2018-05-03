using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public interface IVIdeoRemoteBackplay
    {
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        bool FindVideoFile(int intChannel, DateTime timStart, DateTime timEnd);

    }
}
