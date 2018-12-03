using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class DaHuaSource
    {
        public static VideoInfo GetDaHuaData1()
        {

            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.DaHuaVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "192.168.2.188";
            v.DVSChannelNum = 32;
            v.DVSConnectPort = 37777;
            v.DVSName = "大华测试";
            v.DVSNumber = "310001";
            v.DVSType = "SK8532DH";
            v.HostID = "3100";
            v.UserName = "admin";
            v.Password = "admin";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8616";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
