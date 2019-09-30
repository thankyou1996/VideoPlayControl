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
using VideoPlayControl.VideoEnvironment;

namespace VideoPlayControl_UseDemo.ServerTest
{
    public partial class FrmSKNServerTest : Form
    {
        public FrmSKNServerTest()
        {
            InitializeComponent();
        }
        static SDK_SKNVideo.CallBack call;
        private void FrmSKNServerTest_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            int i8604H = VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_init(48624, null, "");
            call = new SDK_SKNVideo.CallBack(callback);
            SDK_SKNVideo.SDK_NSK_ALL_regeist_msg_callback(call);

            //VideoEnvironment_SKN.SKNVideoSDK_Init("127.0.0.1", 48624, "Admin", Environment.CurrentDirectory, Environment.CurrentDirectory);

        }

        public void callback(int msg_id, string msg_info, int arg1, int arg2, IntPtr data1, int data1_len, IntPtr data2, int data2_len)
        {
            switch (msg_id)
            {
                case 12:
                    string strUGID = Marshal.PtrToStringAnsi(data1);
                    string strZoneNo = GetZoneNoByeventcode_SK8604H(arg2);
                    break;
            }
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

        public string GetZoneNoByeventcode_SK8604H(int inteventcode)
        {
            string strZoneNo = "";
            switch (inteventcode)
            {
                case 1://报警事件
                    strZoneNo = "S1";
                    break;
                case 13://面板被拆
                    strZoneNo = "02";
                    break;
                case 14://面板被拆恢复
                    strZoneNo = "52";
                    break;
                case 24:    //防区1报警 
                    strZoneNo = "01";
                    break;
            }
            return strZoneNo;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            string strGUID = txtguid.Text;
            int intResult= VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_get_device_online(strGUID);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "  " + strGUID + "  Online :" + intResult);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SDK_SKNVideo.SDK_NSK_CLIENT_dev_delay_alarm("63-00F628C55D02-1812", 5, 60);
        }
    }
}
