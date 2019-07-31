using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class HikDataSource
    {
        public static VideoInfo GetHikData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVR;
            v.DVSAddress = "192.168.2.162";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 获取海康数据  天龙
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetHikData2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVR;
            v.DVSAddress = "192.168.2.13";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "tl123456";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 获取海康数据  对讲
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetHikData_Talk()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVR;
            v.DVSAddress = "192.168.2.13";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sd12345+";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            v.TalkChannel = new Dictionary<int, VideoTalkChannelInfo>();
            for (int i = 1; i < 2; i++)
            {
                VideoTalkChannelInfo t = new VideoTalkChannelInfo
                {
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
