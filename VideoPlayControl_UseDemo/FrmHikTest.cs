using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmHikTest : Form
    {
        public FrmHikTest()
        {
            InitializeComponent();
        }

        private void FrmHikTest_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDKState.HikDVRSDK_Init();
            Init();
        }

        public void Init()
        {
            videoPlayWindow1.Init_VideoInfo(GetHikDVSData());
        }

        public VideoInfo GetHikDVSData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HikDVR;
            v.DVSAddress = "192.168.5.7";
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 5; i <= 8; i++)
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

        private void button1_Click(object sender, EventArgs e)
        {
            videoPlayWindow1.VideoPlay();
        }
    }
}
