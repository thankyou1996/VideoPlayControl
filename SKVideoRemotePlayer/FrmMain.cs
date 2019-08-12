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
            List<RemoteBackplayFileInfo> lstBackplayInfo = new List<RemoteBackplayFileInfo>();
            pnlChannel.Controls.Clear();
            int intCount = 0;
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                //this.channelRemoteBackplayInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                //this.channelRemoteBackplayInfo1.CurrentRemoteBackplayInfo = null;
                //this.channelRemoteBackplayInfo1.Location = new System.Drawing.Point(3, 3);
                //this.channelRemoteBackplayInfo1.Name = "channelRemoteBackplayInfo1";
                //this.channelRemoteBackplayInfo1.Size = new System.Drawing.Size(680, 26);
                //this.channelRemoteBackplayInfo1.TabIndex = 0;

                ChannelRemoteBackplayInfo cbInfo = new ChannelRemoteBackplayInfo();
                cbInfo.CurrentRemoteBackplayInfo = null;
                cbInfo.Location = new System.Drawing.Point(3, 3 + (18 * intCount));
                cbInfo.Name = "channelRemoteBackplayInfo1";
                cbInfo.Size = new System.Drawing.Size(680, 18);
                pnlChannel.Controls.Add(cbInfo);
                cbInfo.Paint += CbInfo_Paint;
                cbInfo.SetRemoteBackplayInfo(GetVideoChannelRemoteBackplayInfo(cInfo, lstBackplayInfo));
                intCount++;
                cbInfo.CheckedChanged += CbInfo_CheckedChanged;
            }
        }

        private void CbInfo_CheckedChanged(object sender, EventArgs e)
        {
            ChannelRemoteBackplayInfo cbInfo = (ChannelRemoteBackplayInfo)sender;
            if (cbInfo.Checked)
            {
                //刷新录像信息
                Console.WriteLine("刷新录像信息");
                remoteBackplayControl1.SetRemoteBackplayInfo(cbInfo.CurrentRemoteBackplayInfo);
            }
        }

        private void CbInfo_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemoteBackplayInfo cbInfo = (ChannelRemoteBackplayInfo)c;
                cbInfo.SetRemoteBackplayInfo(cbInfo.CurrentRemoteBackplayInfo);
            }
        }

        public VideoChannelRemoteBackplayInfo GetVideoChannelRemoteBackplayInfo(CameraInfo cInfo, List<RemoteBackplayFileInfo> lstBackplayInfo)
        {
            VideoChannelRemoteBackplayInfo result = new VideoChannelRemoteBackplayInfo()
            {
                ChnnelInfo = cInfo,
                BackplayFiles = GetVideoInfoBackplayFileInfo(cInfo),
                StartTime = DateTime.Now.AddHours(-12),
                EndTime = DateTime.Now,
            };
            return result;
        }


        public List<RemoteBackplayFileInfo> GetVideoInfoBackplayFileInfo(CameraInfo cInfo)
        {
            List<RemoteBackplayFileInfo> result = new List<RemoteBackplayFileInfo>();

            result.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-12)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
            });
            result.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-11)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
            });
            result.Add(new RemoteBackplayFileInfo
            {
                StartTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-10)),
                EndTimeStamp = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(DateTime.Now.AddHours(-4)),
            });

            result.Add(new RemoteBackplayFileInfo
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
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemoteBackplayInfo cbInfo = (ChannelRemoteBackplayInfo)c;
                cbInfo.SetRemoteBackplayInfo(cbInfo.CurrentRemoteBackplayInfo);
            }
        }

        private void PnlChannel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemoteBackplayInfo cbInfo = (ChannelRemoteBackplayInfo)c;
                cbInfo.SetRemoteBackplayInfo(cbInfo.CurrentRemoteBackplayInfo);
            }
        }
        
        private void PnlChannel_MouseWheel(object sender, MouseEventArgs e)
        {
            foreach (Control c in pnlChannel.Controls)
            {
                ChannelRemoteBackplayInfo cbInfo = (ChannelRemoteBackplayInfo)c;
                cbInfo.SetRemoteBackplayInfo(cbInfo.CurrentRemoteBackplayInfo);
            }
        }
    }
}
