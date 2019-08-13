using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using VideoPlayControl_RemotePlayback;

namespace SKVideoRemotePlayer
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pnlChannel.MouseWheel += PnlChannel_MouseWheel;
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
                cbInfo.Name = "channelRemoteBackplayInfo1";
                cbInfo.Size = new System.Drawing.Size(680, 18);
                pnlChannel.Controls.Add(cbInfo);
                cbInfo.Paint += CbInfo_Paint;
                cbInfo.SetRemotePlaybackInfo(GetVideoChannelRemoteBackplayInfo(cInfo, lstBackplayInfo));
                intCount++;
                cbInfo.CheckedChanged += CbInfo_CheckedChanged;
            }
        }

        private void CbInfo_CheckedChanged(object sender, EventArgs e)
        {
            ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)sender;
            if (cbInfo.Checked)
            {
                //刷新录像信息
                Console.WriteLine("刷新录像信息");
                remoteBackplayControl1.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
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
                PlaybackFiles = GetVideoInfoBackplayFileInfo(cInfo),
                StartTime = DateTime.Now.AddHours(-12),
                EndTime = DateTime.Now,
            };
            return result;
        }


        public List<RemotePlaybackFileInfo> GetVideoInfoBackplayFileInfo(CameraInfo cInfo)
        {
            List<RemotePlaybackFileInfo> result = new List<RemotePlaybackFileInfo>();

            result.Add(new RemotePlaybackFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-12)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
            });
            result.Add(new RemotePlaybackFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
            });
            result.Add(new RemotePlaybackFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
            });

            result.Add(new RemotePlaybackFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-1)),
            });
            return result;
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            VideoInfo vInfo = TestDataSource.SKDataSource.GetSKData1();
            SetVideoInfo(vInfo);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RefreshPlaybackInfo();
        }

        private void PnlChannel_Paint(object sender, PaintEventArgs e)
        {
            RefreshPlaybackInfo();
        }
        
        private void PnlChannel_MouseWheel(object sender, MouseEventArgs e)
        {
            RefreshPlaybackInfo();
        }


        public void RefreshPlaybackInfo()
        {
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemotePlaybackInfo cbInfo = (ChannelRemotePlaybackInfo)c;
                cbInfo.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
            }

        }

    }
}
