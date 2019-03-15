using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestDataSource
{
    public class XMDataSource
    {
        public static VideoInfo GetData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "4af84784c06cc3c5";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "雄迈";
            v.DVSNumber = "000801";
            v.DVSType = "SK8605XM";
            v.HostID = "0008";
            v.UserName = "admin";
            v.Password = "123456";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
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

        public static VideoInfo GetData2()
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
        public static VideoInfo GetData3()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "23f2cfd89cca7fed";
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
        
        #region 陈少华设备测试

        public static VideoInfo GetData_CXH_403101()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "272fc93dacc12b9a";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "403101	正定佳悦超市";
            v.DVSNumber = "403101";
            v.DVSType = "SK8605XM";
            v.HostID = "4031";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_400001()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "9526d24526538b46";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400001 大瓷坊一楼";
            v.DVSNumber = "400001";
            v.DVSType = "SK8605XM";
            v.HostID = "4000";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_400101()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "0f8016c0fc483d83";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400101 大瓷坊2楼";
            v.DVSNumber = "400101";
            v.DVSType = "SK8605XM";
            v.HostID = "4001";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_400401()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "c2f14066d890305b";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400401 小佳超市";
            v.DVSNumber = "400401";
            v.DVSType = "SK8605XM";
            v.HostID = "4004";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_400601()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "4f1968cd182cf9ec";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400601 乐买超市";
            v.DVSNumber = "400601";
            v.DVSType = "SK8605XM";
            v.HostID = "4006";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }


        public static VideoInfo GetData_CXH_400701()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "86902de43e865b88";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400701	正医堂药房";
            v.DVSNumber = "400701";
            v.DVSType = "SK8605XM";
            v.HostID = "4007";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_400801()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "c68ac85966b61dcf";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "400801	（秀玉商城）";
            v.DVSNumber = "400801";
            v.DVSType = "SK8605XM";
            v.HostID = "4008";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_401001()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "43bd4eb32241826f";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "401001	正医堂药房";
            v.DVSNumber = "401001";
            v.DVSType = "SK8605XM";
            v.HostID = "4010";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_401201()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "fec7f47af262953e";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "401201	汇聚连锁超市";
            v.DVSNumber = "401201";
            v.DVSType = "SK8605XM";
            v.HostID = "4012";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_401601()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "1109c48ff8d61456";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "401601	际伦烟酒";
            v.DVSNumber = "401601";
            v.DVSType = "SK8605XM";
            v.HostID = "4016";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_401701()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "9f664f6f7e3e96fb";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "401701	正医堂总部";
            v.DVSNumber = "400701";
            v.DVSType = "SK8605XM";
            v.HostID = "4017";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_401901()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "486fbc7d729cb680";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "401901	嘟嘟壹度店";
            v.DVSNumber = "401901";
            v.DVSType = "SK8605XM";
            v.HostID = "4019";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_402001()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "0ea52553b40b300e";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402001	小松鼠壁挂炉";
            v.DVSNumber = "402001";
            v.DVSType = "SK8605XM";
            v.HostID = "4020";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_402201()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "42116fe321e7f6c5";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402201	培蒙";
            v.DVSNumber = "402201";
            v.DVSType = "SK8605XM";
            v.HostID = "4022";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_402301()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "a239a07716428439";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402301	吴兴台铃电动车";
            v.DVSNumber = "402301";
            v.DVSType = "SK8605XM";
            v.HostID = "4023";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_402501()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "34da31674ad3981c";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402501	梦之蓝";
            v.DVSNumber = "402501";
            v.DVSType = "SK8605XM";
            v.HostID = "4025";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_402801()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "304e5152407d81f0";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402801	天隆综合商店";
            v.DVSNumber = "402801";
            v.DVSType = "SK8605XM";
            v.HostID = "4028";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_402901()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "52e93a5da6072bc1";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "402901	石家庄市金满地农业生产资料有限公司";
            v.DVSNumber = "402501";
            v.DVSType = "SK8605XM";
            v.HostID = "4029";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_403301()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "794e08554d0d81da";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "403301	攀宇烟酒";
            v.DVSNumber = "403301";
            v.DVSType = "SK8605XM";
            v.HostID = "4033";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_403801()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "d74e53d67cdcd01e";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "403801	康宽车业";
            v.DVSNumber = "403801";
            v.DVSType = "SK8605XM";
            v.HostID = "4038";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_404001()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "cb9f499d2721187b";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "404001	绿环超市";
            v.DVSNumber = "404001";
            v.DVSType = "SK8605XM";
            v.HostID = "4040";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_404201()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "8c41cae33433addb";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "404201	尚秀街区";
            v.DVSNumber = "404201";
            v.DVSType = "SK8605XM";
            v.HostID = "4042";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_404301()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "13a473f813f848e0";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "404301	立盟烟酒商行";
            v.DVSNumber = "404301";
            v.DVSType = "SK8605XM";
            v.HostID = "4043";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public static VideoInfo GetData_CXH_404401()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "eafd5e0988bc2486";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "404401	鑫兴超市";
            v.DVSNumber = "404401";
            v.DVSType = "SK8605XM";
            v.HostID = "4044";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public static VideoInfo GetData_CXH_404501()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.XMaiVideo;
            v.DVSAddress = "80771b5acfe2e5fd";
            v.DVSChannelNum = 1;
            v.DVSConnectPort = 34567;
            v.DVSName = "404501	众诚烟酒";
            v.DVSNumber = "404501";
            v.DVSType = "SK8605XM";
            v.HostID = "4045";
            v.UserName = "admin";
            v.Password = "lidun110";
            v.NetworkState = 0;
            for (int i = 1; i <= v.DVSChannelNum; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        #endregion
    }
}
