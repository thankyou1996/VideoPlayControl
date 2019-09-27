using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo.ServerTest
{
    public partial class FrmSKServerTest : Form
    {

        private byte bytStatus;
        public FrmSKServerTest()
        {
            InitializeComponent();
        }

        private void FrmSKServerTest_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDK_SKVideoSDK.msg_callback callback = new VideoPlayControl.SDK_SKVideoSDK.msg_callback(SK8604msg_callback);
            GCHandle.Alloc(callback);
            VideoPlayControl.SDK_SKVideoSDK.p_vsdk_reg_msg_callback(callback);
            VideoPlayControl.SDK_SKVideoSDK.p_vsdk_set_av_port(47924);//170609
            VideoPlayControl.SDK_SKVideoSDK.p_vsdk_open(null, 47624, 47724, 47824, "", out bytStatus);//170609
            VideoPlayControl.SDK_SKVideoSDK.p_sdks_add_client("Admin");
            //181229
            VideoPlayControl.SDK_SKVideoSDK.p_vsdk_set_default_html_path(".\\SK8604\talk_proxy\\html\\");
        }
        private void SK8604msg_callback(UInt32 msg_id, UInt32 arg1, UInt32 arg2, IntPtr data1, UInt32 data1_len, IntPtr data2, UInt32 data2_len)
        {

            switch (msg_id)
            {
                case 44:
                    string strRContent = Marshal.PtrToStringAnsi(data2);
                    break;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strGuid = textBox1.Text;
            VideoPlayControl.SDK_SKVideoSDK.p_vsdk_get_gps_info(strGuid);
        }
    }
}
