using PublicClassCurrency;
using SKVideoRecordConvert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoRecordPlayer
{
    public partial class FrmVideoRecordBackplay : Form
    {
        public FrmVideoRecordBackplay()
        {
            InitializeComponent();
        }
        public FrmVideoRecordBackplay(VideoRecordInfo v)
        {
            videoRecordBackplayWindow1.SetVideoRecordInfo(v);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //videoRecordBackplayWindow2.PlayVideoRecord();
        }

        private void FrmVideoRecordBackplay_Load(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.VideoRecodPosChangeEvnet += VideoRecordBackplayWindow1_VideoRecodPosChangeEvnet;
        }

        private void VideoRecordBackplayWindow1_VideoRecodPosChangeEvnet(object value, float fltPosValue)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                trackBar.Value = Convert.ToInt32((fltPosValue) * 1000);
            }));
        }

        private void tsmiSelectedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult d = openFileDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                string strFilePath = openFileDialog.FileName;
                VideoRecordInfo v = SK3000VideoRecordConvert.GetVideoRecordInfo_ByFileName(strFilePath);
                videoRecordBackplayWindow1.SetVideoRecordInfo(v);
                videoRecordBackplayWindow1.OpenVideoRecord();
                videoRecordBackplayWindow1.PlayVideoRecord();
            }
        }

        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.PlayVideoRecord();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.PauseVideoRecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            videoRecordBackplayWindow1.CloseVideoRecord();
        }
    }
}
