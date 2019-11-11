using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo.VideoPlay
{
    public partial class Frm_VideoPlay_SKN : Form
    {
        public Frm_VideoPlay_SKN()
        {
            InitializeComponent();
        }

        private void BtnVideoPlay_Click(object sender, EventArgs e)
        {
            string strIP = txtIP.Text;
            int intPort = Convert.ToInt32(txtPort.Text);
            string strUserName = txtUserName.Text;
            string strPassword = txtPassword.Text;
            int intChannelCount = Convert.ToInt32(txtChannlNum.Text);
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKNVideo;
            v.DVSAddress = strIP;
            v.DVSChannelNum = 8;
            v.DVSConnectPort = 8000;
            v.DVSName = "海康DVR测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HA";
            v.HostID = "0005";
            v.UserName = strUserName;
            v.Password = strPassword;
            v.NetworkState = 0;
            for (int i = 1; i <= intChannelCount; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            int intChannel = Convert.ToInt32(txtChannel.Text);
            if (!v.Cameras.ContainsKey(intChannel))
            {
                MessageBox.Show("通道号不存在");
                return;
            }
            CameraInfo cInfo = v.Cameras[intChannel];
            videoPlayWindow1.Init_VideoInfo(v, cInfo);
            videoPlayWindow1.VideoPlay();
        }
    }
}
