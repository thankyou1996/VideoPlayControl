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
    public partial class Frm_VideoPlaybackWindow : Form
    {
        public Frm_VideoPlaybackWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.PlayVideoRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.StopVideoRecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PublicClassCurrency.VideoRecordInfo v = new PublicClassCurrency.VideoRecordInfo();
            v.DVSNumber = "000601";
            v.VideoRecordType = PublicClassCurrency.Enum_VIdeoRecordType.Axis;
            v.VideoRecordFileType = PublicClassCurrency.Enum_VideoRecordFileType.Audio;
            v.RecordPath = @"G:\上班汇总\Working\维护项目\公用项目\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\AxisRecord\000601_20180126134849.bin";
            videoBackplayWindow1.Init_SetVideoRecord(v);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.PauseVideoRecord();
        }

        private void Frm_VideoPlaybackWindow_Load(object sender, EventArgs e)
        {
            PublicClassCurrency.VideoRecordInfo v = new PublicClassCurrency.VideoRecordInfo();
            v.DVSNumber = "000601";
            v.VideoRecordType = PublicClassCurrency.Enum_VIdeoRecordType.Axis;
            v.VideoRecordFileType = PublicClassCurrency.Enum_VideoRecordFileType.Audio;
            v.RecordPath = @"G:\上班汇总\Working\维护项目\公用项目\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\AxisRecord\000601_20180126134849.bin";
            videoBackplayWindow1.Init_SetVideoRecord(v);
        }
    }
}
