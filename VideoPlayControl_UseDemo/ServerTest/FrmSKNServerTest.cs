using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string strGUID = txtguid.Text;
            int intResult= VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_get_devcie_online(strGUID);
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss") + "  " + strGUID + "  Online :" + intResult);
        }
    }
}
