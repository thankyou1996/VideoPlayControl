using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using VideoPlayControl.SDKInterface;
using VideoPlayControl_RemotePlayback;

namespace SKVideoRemotePlayer
{
    public partial class FrmMain : Form
    {
        public string strSourceData = Environment.CurrentDirectory;

        DateTime timStart = DateTime.Now;
        DateTime timEnd = DateTime.Now;
        int scroll_value = 0;
        public FrmMain()
        {
            InitializeComponent();
            Test();
        }

        public void Test()
        {
            timStart = DateTime.Now.AddDays(-2);
            timEnd = DateTime.Now;
            //1.SDK初始化
            VideoPlayControl.SDKState.SKNVideoSDK_Init("192.168.2.19", 48624, "xhcs1", strSourceData, strSourceData);
            WriteEvent("SDK初始化成功");
            //2.设置信息
            VideoInfo vInfo = TestDataSource.SKNVideoDatSource.GetSKData1();
            SetVideoInfo(vInfo);
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Init();
        }


        public void Init()
        {
            //1.通道文件信息初始化

            //2.c
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
            RemotePlaybackControl control = (RemotePlaybackControl)sender;
            CameraInfo cInfo = control.CurrentRemotePlaybackInfo.ChnnelInfo;
            long lFlag = VideoCurrencyModule.PubMethod.DateTimeToUnixTimestamp(control.CurrentPositionDateTime);
            SDK_SKNVideo.SDK_NSK_CLIENT_start_pb_video(currentVideoInfo.DVSAddress, cInfo.Channel, lFlag, picPlayer.Handle);
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
                CameraInfo cInfo = cbInfo.CurrentRemotePlaybackInfo.ChnnelInfo;
                WriteEvent("开始获取通道" + cInfo.Channel + "录像文件映射");
                DownloadFileMap(cInfo);
                CommonMethod.Common.Delay_Millisecond(3000);
                WriteEvent("通道" + cInfo.Channel + "录像文件映射获取文件");
                string Temp_strPath = strSourceData + SDK_SKNVideo.GetLocalFileMapPath(cInfo);
                List<RemotePlaybackFileInfo> Temp_lst = PubMehtod.GetRemotePlaybackFileInfo_SKN(Temp_strPath, timStart, timEnd);
                cbInfo.CurrentRemotePlaybackInfo.PlaybackFiles = Temp_lst;
                //刷新录像信息
                remoteBackplayControl1.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);
                cbInfo.SetRemotePlaybackInfo(cbInfo.CurrentRemotePlaybackInfo);

                WriteEvent("通道" + cInfo.Channel + "刷新录像文件信息");
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
                StartTime = timStart,
                EndTime = timEnd,
            };
            return result;
        }



        /// <summary>
        /// 下载文件映射
        /// </summary>
        /// <param name="cInfo"></param>
        public void DownloadFileMap(CameraInfo cInfo)
        {
            //下载录像映射文件
            VideoInfo vInfo = cInfo.VideoInfo;
            string strPath1 = SDK_SKNVideo.GetFileMapPath(cInfo);
            string strPath2 = SDK_SKNVideo.GetLocalFileMapPath(cInfo);
            SDK_SKNVideo.SDK_NSK_CLIENT_get_file(vInfo.DVSAddress, false,strPath1 ,strPath2 );
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
    }
}
