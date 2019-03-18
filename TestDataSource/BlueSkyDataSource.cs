using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class BlueSkyDataSource
    {
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.BlueSky;
            v.DVSAddress = "192.168.16.161";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 3721;
            v.DVSDataPort = 3720;
            v.DVSName = "蓝色星际";
            v.DVSNumber = "009001";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
