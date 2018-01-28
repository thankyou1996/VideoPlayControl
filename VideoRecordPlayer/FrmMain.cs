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
using VideoPlayControl;

namespace VideoRecordPlayer
{
    public partial class FrmMain : Form
    {
        VideoRecordInfo CurrentVideoRecordInfo;
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(VideoRecordInfo v)
        {
            InitializeComponent();
            CurrentVideoRecordInfo = v;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
            SetVideoRecordInfo(CurrentVideoRecordInfo);
            
        }

        public void Init()
        {
            trackBar.Minimum = videoBackplayWindow1.MinScale;
            trackBar.Maximum = videoBackplayWindow1.MaxScale;
            videoBackplayWindow1.PlayProgressChangedEvent += PlayProgressChanged;
            videoBackplayWindow1.PlayStateChangedEvent += PlayStateChanged;
        }
        #region 事件注册
        public void PlayProgressChanged(object sender, object objPlayProgressChangedValue)
        {
            VideoBackplayWindow v = (VideoBackplayWindow)sender;
            trackBar.Value = v.VideoProgresss;
            //label1.Text = v.VideoProgresss.ToString();
        }

        public void PlayStateChanged(object sender, object objPlayProgressChangedValue)
        {
            VideoBackplayWindow v = (VideoBackplayWindow)sender;
            switch (v.CurrentPlaybackState )
            {
                case Enum_VideoPlaybackState.Null:
                    btnStartPlay.Enabled = false;
                    btnPause.Enabled = false;
                    btnClose.Enabled = false;
                    break;

                case Enum_VideoPlaybackState.Paused:
                    btnStartPlay.Enabled = true;
                    btnPause.Enabled = false;
                    btnClose.Enabled = true;
                    break;

                case Enum_VideoPlaybackState.Stopped:
                    btnStartPlay.Enabled = true;
                    btnPause.Enabled = false;
                    btnClose.Enabled = false;
                    break;

                case Enum_VideoPlaybackState.Playing:
                    btnStartPlay.Enabled = false;
                    btnPause.Enabled = true;
                    btnClose.Enabled = true;
                    break;

            }
        }
        #endregion

        #region 公用方法

        public void SetVideoRecordInfo(VideoRecordInfo vRecordInfo)
        {
            if (CurrentVideoRecordInfo != null)
            {
                if (videoBackplayWindow1.Init_SetVideoRecord(vRecordInfo))
                {
                    videoBackplayWindow1.PlayVideoRecord();
                }
                else
                {
                    MessageBox.Show("未识别类型");
                }
            }

        }
        #endregion

        #region 控件事件
        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.PlayVideoRecord();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.PauseVideoRecord();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            videoBackplayWindow1.StopVideoRecord();
        }

        #endregion

        private void videoBackplayWindow1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void videoBackplayWindow1_DragDrop(object sender, DragEventArgs e)
        {
            string strPath= ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();     //获取文件路径
            VideoRecordInfo v = SK3000VideoRecordConvert.GetVideoRecordInfo_ByFileName(strPath);
            videoBackplayWindow1.Init_SetVideoRecord(v);
            videoBackplayWindow1.PlayVideoRecord();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoBackplayWindow1.StopVideoRecord();
        }


        private void tsmiSelectedFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult d = openFileDialog.ShowDialog();
            if (d == DialogResult.OK)
            {
                string strFilePath = openFileDialog.FileName;
                VideoRecordInfo v = SK3000VideoRecordConvert.GetVideoRecordInfo_ByFileName(strFilePath);
                videoBackplayWindow1.Init_SetVideoRecord(v);
                videoBackplayWindow1.PlayVideoRecord();
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
