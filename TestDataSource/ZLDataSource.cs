using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class ZLDataSource
    {
        public static VideoInfo GetZLDVSData1()
        {
            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.ZLVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "192.168.2.187";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 8000;
            v.DVSName = "智诺设备";
            v.DVSNumber = "013801";
            v.DVSType = "SK8516ZL";
            v.HostID = "0138";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 1; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8516ZL";
                c.DVSNumber = v.DVSNumber;
                c.VideoInfo = v;
                v.Cameras[c.Channel] = c;
            }
            for (int i = 0; i < 16; i++)
            {
                VideoTalkChannelInfo vt = new VideoTalkChannelInfo();
                vt.VideoTalkChannel = i;
                vt.VideoTalkChannelName = "对讲通道" + (i);
                v.TalkChannel[vt.VideoTalkChannel] = vt;
            }
            return v;
        }
    }
}
