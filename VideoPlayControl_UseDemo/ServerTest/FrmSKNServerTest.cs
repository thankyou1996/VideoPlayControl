using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.SDKInterface;

namespace VideoPlayControl_UseDemo.ServerTest
{
    public partial class FrmSKNServerTest : Form
    {
        public FrmSKNServerTest()
        {
            InitializeComponent();
        }

        private void FrmSKNServerTest_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            int i8604H = VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_init(48624, null, "");
            SDK_SKNVideo.SDK_NSK_ALL_regeist_msg_callback(new SDK_SKNVideo.CallBack(callback));
        }

        public void callback(int msg_id, string msg_info, int arg1, int arg2, IntPtr data1, int data1_len, IntPtr data2, int data2_len)
        {
            //Console.WriteLine("callback " + msg_id + "  " + msg_info);
            
            switch (msg_info)
            {
                case "Download progress.":

                    break;

                case "Download done.":

                    break;


                case "Device event":
                    string strGuid = Marshal.PtrToStringAnsi(data1);
                    string streventdata = Marshal.PtrToStringAnsi(data2);
                    break;

            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strGUID = txtguid.Text;
            int intResult= VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_get_device_online(strGUID);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "  " + strGUID + "  Online :" + intResult);
        }
    }
}
