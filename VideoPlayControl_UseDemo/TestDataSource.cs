using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl_UseDemo
{
    public class TestDataSource
    {
        public static VideoInfo TestData_Axis()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Axis;
            v.DVSAddress = "192.168.2.164";
            v.DVSChannelNum = 4;
            v.DVSConnectPort = 81;
            v.DVSName = "安讯士测试";
            v.DVSNumber = "000601";
            v.DVSType = "AXISM3037";
            v.HostID = "0006";
            v.UserName = "root";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "192.168.2.164";
                c.DVSType = "AXISM3037";
                c.DVSNumber = "000601";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
