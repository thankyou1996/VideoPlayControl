using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.SDKInterface;

namespace VideoPlayControl.VideoInfoSet
{
    public class VideoInfoSet_SKN : IVideoInfoSet
    {
        public bool SyncOSDInfo_Download(VideoInfo vInfo)
        {
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                string Temp_strValue = CommonMethod.StringEncrypt.Base64Encode(cInfo.CameraName);
                SDK_SKNVideo.SDK_NSK_CLIENT_dev_modify_osd(vInfo.DVSAddress, cInfo.Channel - 1, Temp_strValue);
            }
            return true;
        }

        public bool SyncOSDInfo_Upload(VideoInfo vInfo)
        {
            return false;
        }
    }
}
