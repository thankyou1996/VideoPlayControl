using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoRemoteBackplay;

namespace VideoPlayControl
{
    class Class1
    {
        IVIdeoRemoteBackplay iv = new VideoRemoteBackplay_TLi();

        public fileInfo[]  test(PublicClassCurrency.VideoInfo v )
        {
            //PublicClassCurrency.VideoInfo v = new PublicClassCurrency.VideoInfo { VideoType = PublicClassCurrency.Enum_VideoType.SKVideo };
            switch (v.VideoType)
            {
                case PublicClassCurrency.Enum_VideoType.SKVideo:
                    iv = new VideoRemoteBackplay_SK();
                    break;
                case PublicClassCurrency.Enum_VideoType.TLiVideo:
                    iv = new VideoRemoteBackplay_TLi();
                    break;
            }
            fileInfo[] result= iv.FindRemoteFile(new VideoBasicClass.VideoRemotePlaySearchPara { });


            VideoRemoteBackplay_TLi.FindRemoteFile1(new PublicClassCurrency.VideoInfo { }, new VideoBasicClass.VideoRemotePlaySearchPara { });
            return result;
        }
    }
}
