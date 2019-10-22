using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;

namespace VideoPlayControl_UseDemo.RemoteBackplay
{
    public partial class Frm_RemoteBackplay : Form
    {
        public Frm_RemoteBackplay()
        {
            InitializeComponent();
        }

        VideoInfo vInfo = TestDataSource.HikDataSource.GetHikData3();
        private void Frm_RemoteBackplay_Load(object sender, EventArgs e)
        {
            SDKState.HikDVRSDK_Init();
            Init();
        }

        public void Init()
        {
            dtpStart.Value = DateTime.Now.AddSeconds(-30);
            dtpEnd.Value = DateTime.Now;
        }

        private void BtnHikData_Click(object sender, EventArgs e)
        {
            vInfo = TestDataSource.HikDataSource.GetHikData3();
        }

        private void BtnRemotePlayTime_Click(object sender, EventArgs e)
        {
            int intChannel = Convert.ToInt32(txtChannel.Text);
            if (!vInfo.Cameras.ContainsKey(intChannel))
            {
                MessageBox.Show("通道不存在");
                return;
            }
            CameraInfo cInfo = vInfo.Cameras[intChannel];
            VideoRemotePlayByTimePara para = new VideoRemotePlayByTimePara
            {
                CameraInfo = cInfo,
                StartPlayTime = dtpStart.Value,
                EndPlayTime = dtpEnd.Value
            };
            videoRemoteBackplayWindow1.StartRemoteBackplayByTime(para);
        }

        private void BtnRemotePlayTime_Stop_Click(object sender, EventArgs e)
        {
            videoRemoteBackplayWindow1.StopRemoteBackplayByTime();
        }
    }
}
