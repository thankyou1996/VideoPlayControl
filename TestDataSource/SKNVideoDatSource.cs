using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class SKNVideoDatSource
    {
        public static VideoInfo GetSKData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKNVideo;
            v.DVSAddress = "63-343854040533-3339";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "009001";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 9; i <= 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                c.VideoInfo = v;
                v.Cameras[c.Channel] = c;
            }
            v.TalkChannel = new Dictionary<int, VideoTalkChannelInfo>();
            for (int i = 0; i < 16; i++)
            {
                VideoTalkChannelInfo t = new VideoTalkChannelInfo
                {
                    VideoTalkChannel = i,
                    VideoTalkChannelID = i,
                    VideoTalkChannelName = "对讲通道" + i,
                    VideoTalkChannelTagInfo = "123",
                };
                v.TalkChannel[i] = t;
            }

            return v;
        }
    }
}
