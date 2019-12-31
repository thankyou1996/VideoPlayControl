using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class TDWYDataSource
    {
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.TDWY;
            v.DVSAddress = "192.168.2.171";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 3000;
            v.DVSName = "天地伟业硬盘录像机";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605TDWY";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "admin123456";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.VideoInfo = v;
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
