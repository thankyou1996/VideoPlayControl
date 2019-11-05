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
using VideoPlayControl.VideoEnvironment;

namespace VideoPlayControl_UseDemo.VideoPlay
{
    public partial class Frm_VideoPlay_HikStream : Form
    {
        public Frm_VideoPlay_HikStream()
        {
            InitializeComponent();
        }

        private void Frm_VideoPlay_HikStream_Load(object sender, EventArgs e)
        {
            VideoEnvironment_HikStream.Init("192.168.2.19");
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            VideoInfo vInfo = TestDataSource.HikStreamData.GetVideoInfo();
            videoPlayWindow1.Init_VideoInfo(vInfo, vInfo.Cameras[5]);
            videoPlayWindow1.VideoPlay();
        }

    }
}
