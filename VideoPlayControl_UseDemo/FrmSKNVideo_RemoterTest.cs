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
            SDKState.SKNVideoSDK_Init("127.0.0.1", 48624, "xhcs1", "C:\\SHIKE_Video", "C:\\SHIKE_Video");
            v = TestDataSource.TestDataSource.GetSKNDVSData1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime timStart = DateTime.Now.AddMinutes(-10);
            //long lnbStart = CommonMethod.ConvertClass.DateTimeToUnixTimestamp(timStart);
            int lnbStart = 1565744778;
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_is_online();
            intResult = SDK_SKNVideo.SDK_NSK_CLIENT_start_pb_video("63-343854040533-3339", 8, lnbStart, pictureBox1.Handle);
        }

        private void FrmSKNVideo_RemoterTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            SDK_SKNVideo.SDK_NSK_CLIENT_stop_pb_video( pictureBox1.Handle);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            SDK_SKNVideo.SDK_NSK_CLIENT_stop_pb_video(pictureBox1.Handle);

        }
    }
}
