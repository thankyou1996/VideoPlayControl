using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        private void FrmTest_Load(object sender, EventArgs e)
        {
            videoChannelList1.ButtonChannel_ClickEvent += T;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = new VideoInfo();
            //videoInfo.VideoType = (Enum_VideoType)cmbVideoType.SelectedValue;
            
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSAddress = "1";
            videoInfo.DVSConnectPort = 1;
            videoInfo.UserName = "1";
            videoInfo.Password = "1";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            CameraInfo camerasInfo = new CameraInfo();
            for (int i = 0; i < 16; i++)
            {
                camerasInfo = new CameraInfo();
                //int intChannel = Convert.ToInt32(txtChannel.Text);
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "视频播放11" + i;
                videoInfo.Cameras[i] = camerasInfo;
            }
            videoChannelList1.Init_SetVideoInfo(videoInfo);
        }


        public void T(object sender,CameraInfo cameraInfo)
        {
            videoChannelList1.ButtonListBackColorReset();
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            MessageBox.Show(cameraInfo.CameraName);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            label1.Text = "Leave";
        }

        private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
        {
            label1.Text = "AcceptsTabChanged";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = "TextChanged";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label1.Text = "KeyPress";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            label1.Text = "Enter";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frn_VideoPlayGroupControl_Basic f = new Frn_VideoPlayGroupControl_Basic();
            f.Show();
        }
    }
}
