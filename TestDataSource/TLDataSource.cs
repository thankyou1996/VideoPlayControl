using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class TLDataSource
    {

        public static VideoInfo GetData1()
        {

            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.TLiVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "0080670";
            v.DVSChannelNum = 32;
            v.DVSConnectPort = 37777;
            v.DVSName = "通立设备";
            v.DVSNumber = "000101";
            v.DVSType = "SK8532TLi";
            v.HostID = "0001";
            v.UserName = "admin";
            v.Password = "admin";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.HostID;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
