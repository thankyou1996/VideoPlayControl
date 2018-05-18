using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class TestDataSource
    {

        #region 海康数据源
        public static VideoInfo GetHikDVSData1()
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
            v.DVSAddress = "708f8de8e087b0d3";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "";
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
        public static VideoInfo XMDataSource2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "4bba3f71cdd143cb";
            v.DVSChannelNum = 2;
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
        /// <summary>
        /// 雄迈_陈少华客户
        /// </summary>
        /// <returns></returns>
        public static VideoInfo XMDataSource3()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "3584c5fe8ea2e372";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "";
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
        #region 蓝色星际数据源
        public static VideoInfo BuleSkyDataSource()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.BlueSky;
            v.DVSAddress = "192.168.18.254";
            v.DVSChannelNum = 65;
            v.DVSConnectPort = 3721;
            v.DVSDataPort = 3720;
            v.DVSName = "蓝色星际DVR";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 0; i < v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "通道" + i;
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605XM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        #endregion

        #region 萤石数据源
        /// <summary>
        /// 博罗0140
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetYSDVSData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "836324640";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "ABCDEF";
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
        /// 博罗0025
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetYSDVSData2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "819953892";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000502";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "ABCDEF";
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

        #endregion

        #region 云视通
        /// <summary>
        /// 博罗0140
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetCloundSeeDVSData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.CloundSee;
            v.DVSAddress = "X5014851";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "云视通DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "";
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
        #endregion
    }
}
