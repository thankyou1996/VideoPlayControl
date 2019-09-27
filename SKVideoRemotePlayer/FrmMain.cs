using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoEnvironment;
using VideoPlayControl_RemotePlayback;

namespace SKVideoRemotePlayer
{
    public partial class FrmMain : Form
    {
        int scroll_value = 0;
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(ProgPara para)
        {
            InitializeComponent();
            ProgPara.CurrentProgPara = para;

            VideoEnvironment_SKN.SKNVideoSDK_Init(para.ServerAddress, para.ServerPort, para.UserName, para.XmlCgfFullPath, para.DefaultSaveDir);
            WriteEvent("SDK初始化成功");
            //VideoEnvironment_SKN.DownLoadDoneEvent += VideoEnvironment_SKN_DownLoadDoneEvent;
            SetVideoInfo(para.VideoInfo);
        }

        private void VideoEnvironment_SKN_DownLoadDoneEvent(object sender, object value)
        {
            this.BeginInvoke(new EventHandler(delegate
            {
                CommonMethod.Common.Delay_Millisecond(5000);
                int intChannel = SDK_SKNVideo.GetChannelByFileMapPath(Convert.ToString(value));
                CameraInfo cInfo = ProgPara.CurrentProgPara.VideoInfo.Cameras[intChannel];
                WriteEvent( "["+cInfo.CameraName + "]录像文件映射获取文件");
                string Temp_strPath = ProgPara.CurrentProgPara.DefaultSaveDir + SDK_SKNVideo.GetLocalFileMapPath(cInfo);
                List<RemotePlaybackFileInfo> Temp_lst = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(Temp_strPath, ProgPara.CurrentProgPara.PlaybackTimeStart, ProgPara.CurrentProgPara.PlaybackTimeEnd);
                foreach (Control c in pnlChannel.Controls)
                {
                    ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)c;
                    if (cbInfo.CurrentRemotePlaybackInfo.ChnnelInfo != cInfo)
                    {
                        continue;
                    }
                    cbInfo.CurrentRemotePlaybackInfo.PlaybackFiles = Temp_lst.FindAll(item => item.WriteOK).ToList();
                    //刷新录像信息
                    remoteBackplayControl1.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
                    cbInfo.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
                    CommonMethod.Common.Delay_Millisecond(1500);
                    WriteEvent("[" + cInfo.CameraName + "]刷新录像文件信息");
                }
            }));
            VideoEnvironment_SKN.DownLoadDoneEvent -= VideoEnvironment_SKN_DownLoadDoneEvent;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }


        public void Init()
        {
            remoteBackplayControl1.PositionDateTimeChangedEvent += RemoteBackplayControl1_PositionDateTimeChangedEvent;
            pnlChannel.MouseWheel += PnlChannel_MouseWheel;
            scroll_value = this.pnlChannel.VerticalScroll.Value;
        }
        private void PnlChannel_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.pnlChannel.AutoScrollPosition = new Point(0, scroll_value - 20);
            }
            else
            {
                this.pnlChannel.AutoScrollPosition = new Point(0, scroll_value + 20);
            }
            scroll_value = this.pnlChannel.VerticalScroll.Value;
            RefreshPlaybackInfo();
        }

        private void RemoteBackplayControl1_PositionDateTimeChangedEvent(object sender, object PositionDateTimeChangedDelegateValue)
        {
            SDK_SKNVideo.SDK_NSK_CLIENT_stop_pb_video(picPlayer.Handle);
            RemotePlaybackControl control = (RemotePlaybackControl)sender;
            CameraInfo cInfo = control.CurrentRemotePlaybackInfo.ChnnelInfo;
            long lFlag = CommonMethod.ConvertClass.DateTimeToUnixTimestamp(control.CurrentPositionDateTime);

            WriteEvent(control.CurrentPositionDateTime.ToString("MM-dd HH:mm:ss"));
            SDK_SKNVideo.SDK_NSK_CLIENT_start_pb_video(currentVideoInfo.DVSAddress, (cInfo.Channel - 1), Convert.ToInt32(lFlag), picPlayer.Handle);
        }

        public VideoInfo currentVideoInfo = null;

        public VideoInfo CurrnetVideoInfo
        {
            get { return currentVideoInfo; }
            set
            {
                SetVideoInfo(value);
            }
        }

        /// <summary>
        /// 视频设备
        /// </summary>
        public void SetVideoInfo(VideoInfo value)
        {
            currentVideoInfo = value;
            SetVideoInfo_Control(value);
        }

        public void SetVideoInfo_Control(VideoInfo vInfo)
        {
            List<RemotePlaybackFileInfo> lstBackplayInfo = new List<RemotePlaybackFileInfo>();
            pnlChannel.Controls.Clear();
            int intCount = 0;
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                ChannelRemotePlaybackInfo cbInfo = new ChannelRemotePlaybackInfo();
                cbInfo.CurrentRemotePlaybackInfo = null;
                cbInfo.Location = new System.Drawing.Point(3, 3 + (18 * intCount));
                cbInfo.Name = "channelRemoteBackplayInfo_" + cInfo.Channel;
                cbInfo.Size = new System.Drawing.Size(700, 18);
                pnlChannel.Controls.Add(cbInfo);
                cbInfo.Paint += CbInfo_Paint;
                cbInfo.SetRemotePlaybackInfo(GetVideoChannelRemoteBackplayInfo(cInfo, lstBackplayInfo));
                intCount++;
                cbInfo.CheckedChanged += CbInfo_CheckedChanged;
                cbInfo.SetToolTip(toolTip1, cInfo.CameraName);
                
            }
        }

        private void CbInfo_CheckedChanged(object sender, EventArgs e)
        {
            ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)sender;
            if (cbInfo.Checked)
            {
                VideoEnvironment_SKN.DownLoadDoneEvent += VideoEnvironment_SKN_DownLoadDoneEvent;
                CameraInfo cInfo = cbInfo.CurrentRemotePlaybackInfo.ChnnelInfo;
                WriteEvent("开始获取[" + cInfo.CameraName + "]录像文件映射");
                PubMethod.DownloadFileMap(cInfo);
            }
        }

        private void CbInfo_Paint(object sender, PaintEventArgs e)
        {
            RefreshPlaybackInfo();
        }

        public VideoChannelRemotePlaybackInfo GetVideoChannelRemoteBackplayInfo(CameraInfo cInfo, List<RemotePlaybackFileInfo> lstBackplayInfo)
        {
            VideoChannelRemotePlaybackInfo result = new VideoChannelRemotePlaybackInfo()
            {
                ChnnelInfo = cInfo,
                PlaybackFiles = new List<RemotePlaybackFileInfo>(),
                StartTime = ProgPara.CurrentProgPara.PlaybackTimeStart,
                EndTime = ProgPara.CurrentProgPara.PlaybackTimeEnd,
            };
            return result;
        }







        public void RefreshPlaybackInfo()
        {
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)c;
                cbInfo.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
            }

        }

        public void WriteEvent(string strContent)
        {
            ListViewItem item = new ListViewItem();
            item.Text = System.DateTime.Now.ToString("HH:mm:ss");
            item.SubItems.Add(strContent);
            this.lvEvent.Items.Insert(0, item);
        }

        private void BtnQueryRecord_Click(object sender, EventArgs e)
        {
            FrmRecordQuery frmRecordQuery = new FrmRecordQuery();
            frmRecordQuery.Show();
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            int intCount = 0;
            while (SDK_SKNVideo.SDK_NSK_CLIENT_is_online() == 0 && intCount < 10)
            {
                CommonMethod.Common.Delay_Millisecond(1000);
                intCount++;
            }
            if (intCount < 10)
            {
                WriteEvent("登陆服务器成功");
            }
            else
            {
                WriteEvent("登陆服务器失败");
            }
            
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)c;
                if (cbInfo.CurrentRemotePlaybackInfo.ChnnelInfo.Channel == ProgPara.CurrentProgPara.Channel)
                {
                    cbInfo.Checked = true;
                }
            }
            remoteBackplayControl1.SetCurrentPositionDateTime(ProgPara.CurrentProgPara.PlaybackTime);
        }
    }
}
