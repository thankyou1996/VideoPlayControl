using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.SDKInterface;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmSKNVideo_RemoterTest : Form
    {
        public FrmSKNVideo_RemoterTest()
        {
            InitializeComponent();
        }
        public PublicClassCurrency.VideoInfo v;
        private void FrmSKNVideo_RemoterTest_Load(object sender, EventArgs e)
        {
            SDKState.SKNVideoSDK_Init("192.168.2.10", 48624, "xhcs1", "", "C:\\SHIKE_Video");
            v = TestDataSource.TestDataSource.GetSKNDVSData1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime timStart = DateTime.Now.AddMinutes(-5);
            long lnbStart = CommonMethod.ConvertClass.DateTimeToUnixTimestamp(timStart);
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_is_online();
            intResult = SDK_SKNVideo.SDK_NSK_CLIENT_start_pb_video(v.DVSAddress, 8, lnbStart, pictureBox1.Handle);
            string x = "";
        }

        private void FrmSKNVideo_RemoterTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            SDK_SKNVideo.SDK_NSK_CLIENT_stop_pb_video(pictureBox1.Handle);
        }
    }
}
