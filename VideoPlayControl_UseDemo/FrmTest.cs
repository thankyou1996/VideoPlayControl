using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
