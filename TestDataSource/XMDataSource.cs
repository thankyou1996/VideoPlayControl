using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class XMDataSource
    {
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "4af84784c06cc3c5";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 0; i < v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605XM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
