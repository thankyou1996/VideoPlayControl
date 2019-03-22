using PublicClassCurrency;
using SKVideoRecordConvert;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VideoRecordPlayer
{
    public partial class FrmVideoRecordBackplay : Form
    {
        public FrmVideoRecordBackplay()
        {
            InitializeComponent();
            //VideoRecordInfo v = new VideoRecordInfo();
            //v.DVSNumber = "000601";
            //v.VideoRecordType = PublicClassCurrency.Enum_VIdeoRecordType.TLiVideoRecord;
            //v.VideoRecordFileType = PublicClassCurrency.Enum_VideoRecordFileType.VideoAndAudio;
            //v.RecordPath = @"G:\VIdeoRecordTest\000101_02_20190321164059_15.ifv";
            //videoRecordBackplayWindow1.SetVideoRecordInfo(v);
        }
        public FrmVideoRecordBackplay(VideoRecordInfo v)
        {
            InitializeComponent();
            videoRecordBackplayWindow1.SetVideoRecordInfo(v);
            
        }

        private void FrmVideoRecordBackplay_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDKState.BlueSkySDK_Init();

            videoRecordBackplayWindow1.VideoRecodPosChangeEvnet += VideoRecordBackplayWindow1_VideoRecodPosChangeEvnet;
            if (videoRecordBackplayWindow1.videoPlay != null && videoRecordBackplayWindow1.videoPlay.VideoRecordInfo != null)
            {
                videoRecordBackplayWindow1.OpenVideoRecord();
                videoRecordBackplayWindow1.PlayVideoRecord();
            }
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
            videoRecordBackplayWindow1.Refresh();
        }

        private void videoRecordBackplayWindow1_DragDrop(object sender, DragEventArgs e)
        {
            string strPath = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();     //获取文件路径
            VideoRecordInfo v = SK3000VideoRecordConvert.GetVideoRecordInfo_ByFileName(strPath);
            //videoBackplayWindow1.Init_SetVideoRecord(v);
            //videoBackplayWindow1.PlayVideoRecord();
        }

        private void videoRecordBackplayWindow1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            float flotrackBarValue = (float)trackBar.Value / (float)trackBar.Maximum;
            videoRecordBackplayWindow1.SetVideoRecordPos(flotrackBarValue);
        }
    }
}
