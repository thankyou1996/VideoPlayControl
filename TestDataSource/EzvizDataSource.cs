using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class EzvizDataSource
    {
        public static VideoInfo GetEzvizInfo()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "756217914";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "199601";
            v.DVSType = "SK8605HA";
            v.HostID = "1996";
            v.UserName = "";
            v.Password = "NSUBLM";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetEzvizInfo1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "164080178";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
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
        public static VideoInfo GetEzvizInfo2()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C54376454";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
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

        public static VideoInfo GetEzvizInfo3()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C63053943";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
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
        /// <summary>
        /// 陈少华 101701
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo4()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C58490395";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "WBMORG";
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

        public static VideoInfo GetEzvizInfo5()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C67457448";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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
        public static VideoInfo GetEzvizInfo6()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C39701749";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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
        public static VideoInfo GetEzvizInfo7()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "658282296";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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

        public static VideoInfo GetEzvizInfo8()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "108667790";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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



        public static VideoInfo GetEzvizInfo9()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C05285681";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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
        

         public static VideoInfo GetEzvizInfo10()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "131303135";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "NSUBLM";
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
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo11()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C18460035";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "NSUBLM";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo12()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "756217914";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo13()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C11309004";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
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
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo14()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "481782674";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试"; 
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "";
            v.Password = "";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo15()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "C90830543";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static VideoInfo GetEzvizInfo16()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "736125738";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }


        public static VideoInfo GetData17()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "535363290";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }


        public static VideoInfo GetData18()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Ezviz;
            v.DVSAddress = "136495764";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000601";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "Admin";
            v.Password = "RSAEIM";
            v.NetworkState = 0;
            for (int i = 1; i <= 8; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HA";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
    }
}
