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
    public partial class FrmVideoRecordBackplayWindow : Form
    {
        public FrmVideoRecordBackplayWindow()
        {
            InitializeComponent();
        }

        private void FrmVideoRecordBackplayWindow_Load(object sender, EventArgs e)
        {

            PublicClassCurrency.VideoRecordInfo v = new PublicClassCurrency.VideoRecordInfo();
            v.DVSNumber = "000601";
            v.VideoRecordType = PublicClassCurrency.Enum_VIdeoRecordType.TLiVideoRecord;
            v.VideoRecordFileType = PublicClassCurrency.Enum_VideoRecordFileType.VideoAndAudio;
            v.RecordPath = @"G:\VIdeoRecordTest\000101_02_20190321164059_15.ifv";
            videoRecordBackplayWindow1.SetVideoRecordInfo(v);

            if (videoRecordBackplayWindow1.videoPlay != null && videoRecordBackplayWindow1.videoPlay.VideoRecordInfo != null)
            {
                videoRecordBackplayWindow1.OpenVideoRecord();
                //videoRecordBackplayWindow1.PlayVideoRecord();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.PlayVideoRecord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.PauseVideoRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.CloseVideoRecord();
            videoRecordBackplayWindow1.Refresh();
        }
    }
}
