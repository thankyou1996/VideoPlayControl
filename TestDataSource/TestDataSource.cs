using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class TestDataSource
    {


        #region 海康流媒体
        /// <summary>
        /// 海康流媒体  音频转发测试
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetHikData3_Voice()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVRStream;
            v.DVSAddress = "192.168.2.19";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8081;
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
            for (int i = 0; i < 16; i++)
            {
                VideoTalkChannelInfo vt = new VideoTalkChannelInfo();
                vt.VideoTalkChannel = i;
                vt.VideoTalkChannelName = "对讲通道" + (i);
                v.TalkChannel[vt.VideoTalkChannel] = vt;
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
            v.DVSAddress = "192.168.2.165";
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
            //v.DVSAddress = "a20f4a3d676e7726";
            //v.DVSAddress = "8a8a431994cfdc0b";
            v.DVSAddress = "8c41cae33433addb";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "lidun110";
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
        /// <summary>
        /// 雄迈摇头机
        /// </summary>
        /// <returns></returns>
        public static VideoInfo XMDataSource4()
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
            v.Password = "12345";
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
        /// 雄迈摇头机
        /// </summary>
        /// <returns></returns>
        public static VideoInfo XMDataSource5()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "5e8a8247d785f432";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "12345";
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
        /// 雄迈摇头机
        /// </summary>
        /// <returns></returns>
        public static VideoInfo XMDataSource6()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "9526d24526538b46";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "lidun110";
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
        /// 雄迈摇头机
        /// </summary>
        /// <returns></returns>
        public static VideoInfo XMDataSource7()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "9f664f6f7e3e96fb";
            v.DVSChannelNum = 2;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000802";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "lidun110";
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
        /// 公司测试 192.168.2.162
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetYSDVSData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "756217914";
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

        public static VideoInfo GetYSDVSData3()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "190647376";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000503";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "AWGFUS";
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

        public static VideoInfo GetYSDVSData4()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "137239617";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000504";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "PTZMIH";
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

        public static VideoInfo GetYSDVSData5()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C15554236";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000504";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "IEYUXM";
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

        public static VideoInfo GetYSDVSData6()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "657693507";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000504";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "DRQWGA";
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


        public static VideoInfo GetYSDVSData7()
        {

            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C15554374";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000504";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "EXKBGC";
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

        #region 时刻测试数据
        /// <summary>
        /// 121.41.87.203  7707
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetSKDVSData1()
        {
            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.SKVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "61-573539920B39-3036";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "时刻DVR测试";
            v.DVSNumber = "770701";
            v.DVSType = "SK8616";
            v.HostID = "7707";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8616";
                c.DVSNumber = "000501";
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
     

        /// <summary>
        /// SK519V
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetSKDVSData2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "71-00F51F012D0C-2830";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "时刻DVR测试";
            v.DVSNumber = "500101";
            v.DVSType = "SK519V";
            v.HostID = "5001";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8616";
                c.DVSNumber = "000501";
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
        /// <summary>
        /// 0009 192.168.2.19
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetSKDVSData3()
        {
            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.SKVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "61-57356B140B39-3036";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "时刻DVR测试";
            v.DVSNumber = "013801";
            v.DVSType = "SK8616";
            v.HostID = "0138";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            //for (int i = 0; i < 16; i++)
            //{
            //    CameraInfo c = new CameraInfo();
            //    c.CameraName = "摄像头" + (i);
            //    c.Channel = i;
            //    //c.DVSAddress = "E322213C04245";
            //    c.DVSType = "SK8616";
            //    c.DVSNumber = "000501";
            //    v.Cameras[c.Channel] = c;
            //}
            for (int i = 0; i < 16; i++)
            {
                VideoTalkChannelInfo vt = new VideoTalkChannelInfo();
                vt.VideoTalkChannel = i;
                vt.VideoTalkChannelName = "对讲通道" + (i);
                v.TalkChannel[vt.VideoTalkChannel] = vt;
            }
            return v;
        }
        #endregion

        #region 时刻H265程序

        public static VideoInfo GetSKNDVSData1()
        {
            VideoInfo v = new VideoInfo();
            //v.OnlyIntercom = true;
            v.VideoType = Enum_VideoType.SKNVideo;
            v.PTZControlEnable = false;
            v.DVSAddress = "63-5737319F0736-3232";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "时刻DVR测试";
            v.DVSNumber = "013801";
            v.DVSType = "SK8616";
            v.HostID = "0138";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8616";
                c.DVSNumber = v.DVSNumber;
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

        #endregion

        #region 智诺视频设备

        

        #endregion 
    }
}
