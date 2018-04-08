using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class TestDataSource
    {

        #region 海康数据源
        public static VideoInfo HikDataSource()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVR;
            v.DVSAddress = "192.168.5.162";
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
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        #endregion


        #region 雄迈数据源
        public static VideoInfo XMDataSource()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "192.168.2.165";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 0; i < v.DVSChannelNum; i++)
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

        public static VideoInfo XMDataSource1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "93c4de073e976f89";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 0; i < v.DVSChannelNum; i++)
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

        #endregion
        #region TestData_Axis

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
        #endregion
    }
}
