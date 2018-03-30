using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
