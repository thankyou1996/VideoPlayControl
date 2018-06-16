using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmEzviz : Form
    {
        public FrmEzviz()
        {
            InitializeComponent();
        }

        private void FrmEzviz_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDKState.Ezviz_SDKInit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                int intResult = SDK_EzvizSDK.GetDevOnlineState("75621791412", 1);
                Console.WriteLine(intResult);
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                Thread.Sleep(30);
            }
        }
    }
}
