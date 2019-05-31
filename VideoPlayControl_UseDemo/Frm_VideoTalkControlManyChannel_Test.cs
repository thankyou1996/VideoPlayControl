using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_VideoTalkControlManyChannel_Test : Form
    {
        public Frm_VideoTalkControlManyChannel_Test()
        {
            InitializeComponent();
        }

        private bool videoTalkControlManyChannel1_StopTalkedEvent(object sender, object StopTalkValue)
        {
            Console.WriteLine("StopTalked");
            return true;
        }

        private bool videoTalkControlManyChannel1_StartTalkingEvent(object sender, object StartTalkBeginValue)
        {
            Console.WriteLine("StartTalk");
            return true;
        }

        private void Frm_VideoTalkControlManyChannel_Test_Load(object sender, EventArgs e)
        {
            VideoInfo v = TestDataSource.SKDataSource.GetSKData2();
            Dictionary<string, VideoInfo> vvv = new Dictionary<string, VideoInfo>();
            vvv[v.DVSNumber] = v;
            videoTalkControlManyChannel1.SetVideoInfo(vvv);
        }
    }
}
