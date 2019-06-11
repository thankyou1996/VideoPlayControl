using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class CloundSeeDataSource
    {
        /// <summary>
        /// 海康流媒体  音频转发测试
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.CloundSee;
            v.DVSAddress = "X7565992";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 9101;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000101";
            v.DVSType = "SK8605HA";
            v.HostID = "0001";
            v.UserName = "admin";
            v.Password = "123";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 海康流媒体  音频转发测试
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetData2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.CloundSee;
            v.DVSAddress = "X4628722";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 9101;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000201";
            v.DVSType = "SK8605HA";
            v.HostID = "0002";
            v.UserName = "admin";
            v.Password = "123";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }


        public static VideoInfo GetData3()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.CloundSee;
            v.DVSAddress = "SK57778669";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "";
            v.NetworkState = 0;
            for (int i = 1; i < v.DVSChannelNum; i++)
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
        public static VideoInfo GetData4()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.CloundSee;
            v.DVSAddress = "12421SSSVJLQ";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "jingan";
            v.NetworkState = 0;
            for (int i = 1; i < v.DVSChannelNum; i++)
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
