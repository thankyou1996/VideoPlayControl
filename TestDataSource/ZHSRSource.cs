using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class ZHSRSource
    {
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.ZHSR;
            v.DVSAddress = "{615B8909-0EF7-45F8-B46D-08387E29139E}";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 80;
            v.DVSName = "珠海三润硬盘录像机";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605ZHSR";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "admin123456";
            v.NetworkState = 0;
            for (int i = 1; i <= 1; i++)
            {
                CameraInfo c = new CameraInfo();
                c.VideoInfo = v;
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }

            v.TalkChannel = new Dictionary<int, VideoTalkChannelInfo>();
            for (int i = 1; i < 2; i++)
            {
                VideoTalkChannelInfo t = new VideoTalkChannelInfo
                {
                    VideoInfo = v,
                    VideoTalkChannel = i,
                    VideoTalkChannelID = i,
                    VideoTalkChannelName = "对讲通道" + i,
                };
                v.TalkChannel[i] = t;
            }
            return v;
        }
    }
}
