using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;

namespace VideoPlayControl.VideoInfoSet
{
    public class VideoInfoSet_Shike : IVideoInfoSet
    {
        public bool SyncOSDInfo_Download(VideoInfo vInfo)
        {
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                string Temp_strValue = CommonMethod.StringEncrypt.Base64Encode(cInfo.CameraName);
                SDK_SKVideoSDK.p_sdkc_set_dev_cam_osd(vInfo.DVSAddress, cInfo.Channel - 1, Temp_strValue);
            }
            return true;
        }

        public bool SyncOSDInfo_Upload(VideoInfo vInfo)
        {
            return false;
        }
    }
}
