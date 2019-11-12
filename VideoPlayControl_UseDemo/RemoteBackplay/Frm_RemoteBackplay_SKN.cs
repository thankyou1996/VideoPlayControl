using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoEnvironment;

namespace VideoPlayControl_UseDemo.RemoteBackplay
{
    public partial class Frm_RemoteBackplay_SKN : Form
    {
        public Frm_RemoteBackplay_SKN()
        {
            InitializeComponent();
        }


        private void Frm_RemoteBackplay_SKN_Load(object sender, EventArgs e)
        {
            VideoEnvironment_SKN.SKNVideoSDK_Init("192.168.2.19", 48624, "SuperAdmin", Environment.CurrentDirectory, Environment.CurrentDirectory);
        }


        private void Button1_Click(object sender, EventArgs e)
        {

            long lFlag = CommonMethod.ConvertClass.DateTimeToUnixTimestamp(DateTime.Now.AddMinutes(-10));
            SDK_SKNVideo.SDK_NSK_CLIENT_start_pb_video("63-00F628C42401-2A2C", 8, Convert.ToInt32(lFlag), pictureBox1.Handle);
        }
    }
}
