using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;
using VideoPlayControl.VideoPlay;

namespace VideoPlayControl_UseDemo
{
    public partial class FrmMain : Form
    {
        #region 全局变量
        /// <summary>
        /// 当前窗口行
        /// </summary>
        public int intCurrentRow = 3;
        /// <summary>
        /// 当前窗口列
        /// </summary>
        public int intCurrentCol = 3;
        /// <summary>
        /// 当前窗口数量
        /// </summary>
        public int intCurrentPicNum = 9;

        /// <summary>
        /// 播放窗口List对象
        /// </summary>
        List<VideoPlayWindow> lstVideoPlayWindow = new List<VideoPlayWindow>();


        Dictionary<string, VideoInfo> dicVideoInfos;

        string intCurrentVideoID = "";
        string strVideoRecord = "";
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //VideoPlayControl.ProgParameter.strEzviz__AppID = "5b97c1d157474f96b8d4c75b936a0057";
            //VideoPlayControl.ProgParameter.strEzviz_AppSecret = "4318d0cc4c43ca156052ba688bc9006a";
            SDKState.SDKStateChangeEvent += SDKStateChange;
            //SDKState.CloundSee_SDKInit();
            //SDKState.Ezviz_SDKInit();
            //SDKState.SKVideoSDKInit();
            //SDKState.HuaMai_Init();
            //SDKState.XMSDK_Init();
            SDKState.HikDVRSDK_Init();
            SDKState.BlueSkySDK_Init();

            Init();



            btnBlueSkyTestData_Click(sender, e);

        }

        #region 初始化

        public void Init()
        {

            Init_ControlInit();
            PlayWindowSet(1);
            CommonMethod.LogWrite.strLogFilePath = Application.StartupPath + "\\UserData\\OperAtLog";
        }

        public void Init_ControlInit()
        {
            dicVideoInfos = new Dictionary<string, VideoInfo>();
            DataRow dr;
            #region 设备类型赋值
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("value");
            dtSource.Columns.Add("display");

            dr = dtSource.NewRow();
            dr["value"] = Convert.ToInt32(Enum_VideoType.Ezviz);
            dr["display"] = Enum_VideoType.Ezviz.ToString();
            dtSource.Rows.Add(dr);


            dr = dtSource.NewRow();
            dr["value"] = Convert.ToInt32(Enum_VideoType.CloundSee);
            dr["display"] = Enum_VideoType.CloundSee.ToString();
            dtSource.Rows.Add(dr);

            dr = dtSource.NewRow();
            dr["value"] = Convert.ToInt32(Enum_VideoType.IPCWA);
            dr["display"] = Enum_VideoType.IPCWA.ToString();
            dtSource.Rows.Add(dr);

            dr = dtSource.NewRow();
            dr["value"] = Convert.ToInt32(Enum_VideoType.SKVideo);
            dr["display"] = Enum_VideoType.SKVideo.ToString();
            dtSource.Rows.Add(dr);


            cmbVideoType.ValueMember = "value";
            cmbVideoType.DisplayMember = "display";
            cmbVideoType.DataSource = dtSource;
            #endregion

            #region 画面数量设置
            DataTable dtCmbPicNumSet = new DataTable();
            dtCmbPicNumSet.Columns.Add("key");
            dtCmbPicNumSet.Columns.Add("display");
            dr = dtCmbPicNumSet.NewRow();
            dr["key"] = 1;
            dr["display"] = "1 画面";
            dtCmbPicNumSet.Rows.Add(dr);

            dr = dtCmbPicNumSet.NewRow();
            dr["key"] = 4;
            dr["display"] = "4 画面";
            dtCmbPicNumSet.Rows.Add(dr);

            dr = dtCmbPicNumSet.NewRow();
            dr["key"] = 9;
            dr["display"] = "9 画面";
            dtCmbPicNumSet.Rows.Add(dr);


            dr = dtCmbPicNumSet.NewRow();
            dr["key"] = 16;
            dr["display"] = "16 画面";
            dtCmbPicNumSet.Rows.Add(dr);

            cmbPlayVideoWindowSet.DataSource = dtCmbPicNumSet;
            cmbPlayVideoWindowSet.ValueMember = "key";
            cmbPlayVideoWindowSet.DisplayMember = "display";
            cmbPlayVideoWindowSet.SelectedValue = 4;
            cmbPlayVideoWindowSet.SelectedIndexChanged += cmbPlayVideoWindowSet_SelectedIndexChanged;
            #endregion

            for (int i = 0; i < 256; i++)
            {
                cmbPreset.Items.Add(i.ToString().PadLeft(2, '0'));
                cmbOperAtPreset.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            cmbPreset.SelectedIndex = 0;
            cmbOperAtPreset.SelectedIndex = 0;
            dgvReocrd.MultiSelect = false;
            videoWindowTest.SDKEventCallBackEvent += SDKEventCallBackEvent;
            videoWindowTest.VideoPlayEventCallBackEvent += VideoPlayEventCallBack;
            videoPTZControl1.PTZControlEvent += PTZControlEvent;

        }


        public void SDKEventCallBack(Enum_VideoType videoType, Enum_SDKEventType etType, string strtTag)
        {
            AddRecord(videoType.ToString() + "[" + strtTag + "]" + etType.ToString(), "SDKEventCallBack");
        }
        #endregion

        #region 控件事件
        public void SDKStateChangedCallBackEvent(object sender, Enum_SDKState sdkState)
        {
            VideoPlayWindow v = (VideoPlayWindow)sender;
            AddRecord(sdkState.ToString(), "SDKState");
        }

        public void SDKEventCallBackEvent(object sender, Enum_SDKEventType evType, string strTag)
        {
            if (!string.IsNullOrEmpty(strTag))
            {
                AddRecord(evType.ToString() + "[" + strTag + "]", "SDKEventCallBack");
            }
            else
            {
                AddRecord(evType.ToString(), "SDKEventCallBack");
            }
        }


        public void VideoPlayEventCallBack(object sender, Enum_VideoPlayEventType eventType)
        {
            try
            {
                VideoPlayWindow v = (VideoPlayWindow)sender;
                AddRecord(v.CurrentVideoInfo.DVSAddress + "_" + eventType.ToString(), "VideoEvent");
            }
            catch (Exception ex)
            {
                //转换异常
                IVideoPlay iv = (IVideoPlay)sender;
                AddRecord(iv.CurrentVideoInfo.DVSAddress + "_" + eventType.ToString(), "VideoEvent");
            }
        }

        /// <summary>
        /// 播放页面选中项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPlayVideoWindowSet_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int Temp_intPicNumber = Convert.ToInt32(cmbPlayVideoWindowSet.SelectedValue.ToString());
                if (intCurrentPicNum == Temp_intPicNumber)
                {
                    return;
                }
                //ReleaseVideo_All(); //释放所有信息
                PlayWindowSet(Temp_intPicNumber);
            }
            catch
            {
                //取值异常不做处理
            }
        }

        private void PTZControlEvent(Enum_VideoPTZControl PTZControlCmd, bool bolStart)
        {
            int intVideoIndex = Convert.ToInt32(cmbPlayWindows.SelectedValue);
            if (intVideoIndex == 0)
            {
                //测试界面
                videoWindowTest.VideoPTZControl(PTZControlCmd, bolStart);
            }
            else
            {
                lstVideoPlayWindow[intVideoIndex - 1].VideoPTZControl(PTZControlCmd, bolStart);
            }

        }



        #endregion

        #region 公用事件

        /// <summary>
        /// 播放窗口设置
        /// </summary>
        public void PlayWindowSet(int intPicNumberSet)
        {
            intCurrentPicNum = intPicNumberSet;
            switch (intCurrentPicNum)
            {
                case 1:
                    intCurrentRow = 1;
                    intCurrentCol = 1;
                    break;
                case 4:
                    intCurrentRow = 2;
                    intCurrentCol = 2;
                    break;
                case 9:
                    intCurrentRow = 3;
                    intCurrentCol = 3;
                    break;
                case 16:
                    intCurrentRow = 4;
                    intCurrentCol = 4;
                    break;
            }
            tlpPlayVIdeoWindows.RowCount = intCurrentRow;
            tlpPlayVIdeoWindows.ColumnCount = intCurrentCol;
            tlpPlayVIdeoWindows.SuspendLayout();
            #region 移除旧控件 信息
            foreach (VideoPlayWindow v in lstVideoPlayWindow)
            {
                v.VideoPlayWindows_Close();
            }
            lstVideoPlayWindow.Clear();

            tlpPlayVIdeoWindows.RowStyles.Clear();
            tlpPlayVIdeoWindows.ColumnStyles.Clear();
            tlpPlayVIdeoWindows.Controls.Clear();
            #endregion

            for (int row = 0; row < intCurrentRow; row++)
            {
                tlpPlayVIdeoWindows.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            for (int col = 0; col < intCurrentCol; col++)
            {
                tlpPlayVIdeoWindows.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }

            int i = 0;
            for (int row = 0; row < intCurrentRow; row++)
            {
                for (int col = 0; col < intCurrentCol; col++)
                {

                    GroupBox grp = new GroupBox();
                    grp.Name = "grp_" + i;
                    grp.Text = "设备名称";
                    grp.Size = new Size(100, 100);
                    grp.Dock = DockStyle.Fill;
                    grp.BackColor = Color.White;
                    grp.Margin = new Padding(0);
                    string strgrpTag = row.ToString() + "_" + col.ToString();
                    grp.Tag = strgrpTag;

                    VideoPlayWindow videoPlayWindow = new VideoPlayWindow();

                    videoPlayWindow.Name = "Video_" + i;
                    videoPlayWindow.Size = new Size(100, 100);
                    videoPlayWindow.Dock = DockStyle.Fill;
                    videoPlayWindow.BackColor = Color.Black;
                    videoPlayWindow.Margin = new Padding(1);
                    grp.Controls.Add(videoPlayWindow);

                    tlpPlayVIdeoWindows.Controls.Add(grp);
                    tlpPlayVIdeoWindows.SetRow(grp, row);
                    tlpPlayVIdeoWindows.SetColumn(grp, col);
                    videoPlayWindow.SDKEventCallBackEvent += SDKEventCallBackEvent;
                    videoPlayWindow.VideoPlayEventCallBackEvent += VideoPlayEventCallBack;
                    lstVideoPlayWindow.Add(videoPlayWindow);
                    i++;
                }
            }
            tlpPlayVIdeoWindows.ResumeLayout();


            DataTable dtOperAtVideo = new DataTable();
            dtOperAtVideo.Columns.Add("value");
            dtOperAtVideo.Columns.Add("display");
            DataRow dr = dtOperAtVideo.NewRow();
            dr["value"] = 0;
            dr["display"] = "测试画面";
            dtOperAtVideo.Rows.Add(dr);
            i = 0;
            for (i = 1; i <= intPicNumberSet; i++)
            {
                dr = dtOperAtVideo.NewRow();
                dr["value"] = i;
                dr["display"] = "主画面" + i;
                dtOperAtVideo.Rows.Add(dr);
            }
            cmbOperAtWindows.ValueMember = "value";
            cmbOperAtWindows.DisplayMember = "display";
            cmbOperAtWindows.DataSource = dtOperAtVideo;
            cmbPlayWindows.ValueMember = "value";
            cmbPlayWindows.DisplayMember = "display";
            cmbPlayWindows.DataSource = dtOperAtVideo;
        }

        /// <summary>
        /// 添加事件记录
        /// </summary>
        public void AddRecord(string strEvnetContent, string strEventTag = "")
        {
            //StringBuilder sbEventDisplay = new StringBuilder();
            //sbEventDisplay.Append(DateTime.Now.ToString("HH:mm:ss")+" | ");
            //string Temp_strEventTag = strEventTag.PadRight(10, ' ');
            //sbEventDisplay.Append(Temp_strEventTag);
            //sbEventDisplay.Append(strEvnetContent);
            CommonMethod.LogWrite.WriteEventLog(strEventTag, strEvnetContent);
            this.BeginInvoke(new EventHandler(delegate
            {
                int index = this.dgvReocrd.Rows.Add();
                this.dgvReocrd.Rows[index].Cells[0].Value = DateTime.Now.ToString("HH:mm:ss:fff");
                this.dgvReocrd.Rows[index].Cells[1].Value = strEventTag;
                this.dgvReocrd.Rows[index].Cells[2].Value = strEvnetContent;

                dgvReocrd.Rows[dgvReocrd.RowCount - 1].Selected = true;
                dgvReocrd.FirstDisplayedScrollingRowIndex = dgvReocrd.RowCount - 1;

            }));

        }


        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo);
            videoPlayWindow.VideoPlay();
        }

        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo, videoPlaySet);
            videoPlayWindow.VideoPlay();
        }
        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo, CameraInfo camerInfo, VideoPlaySetting videoPlaySet)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo, camerInfo, videoPlaySet);
            videoPlayWindow.VideoPlay();
        }

        public string GetVideoTapeDicPath()
        {
            StringBuilder sbRecDicPath = new StringBuilder();
            //sbRecDicPath.Append(ProgConstants.strCurrentSDK_RecDicPath);  //默认路径
            //sbRecDicPath.Append("\\" + txtCouldID.Text.Trim());           //云视通号码
            if (!Directory.Exists(sbRecDicPath.ToString()))
            {
                //文件夹不存在，创建文件夹
                Directory.CreateDirectory(sbRecDicPath.ToString());
            }
            StringBuilder sbRecFilePath = new StringBuilder();
            sbRecFilePath.Append(sbRecDicPath.ToString());
            sbRecFilePath.Append("\\" + DateTime.Now.ToString("yyyyMMddHHmmss"));     //时间
            sbRecFilePath.Append("_" + txtChannel.Text.Trim());                     //通道号
            sbRecFilePath.Append(".mp4");
            return sbRecFilePath.ToString();
        }


        public void VideoListRefresh()
        {
            cmbVideoList.Items.Clear();
            foreach (KeyValuePair<string, VideoInfo> kv in dicVideoInfos)
            {
                cmbVideoList.Items.Add(kv.Key);
            }
        }

        #endregion

        private void btnVideoPly_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Move(object sender, EventArgs e)
        {
            videoWindowTest.VideoPlayWindows_Move();
            //videoPlayMain2.VideoPlayWindows_Move();
        }

        private void btnVideoPlayClose_Click(object sender, EventArgs e)
        {
            int intVideoIndex = Convert.ToInt32(cmbOperAtWindows.SelectedValue);
            if (intVideoIndex == 0)
            {
                videoWindowTest.VideoClose();
            }
            else
            {
                lstVideoPlayWindow[intVideoIndex - 1].VideoClose();
            }
        }






        public void TEST()
        {
            VideoInfo videoInfo = new VideoInfo();
            //videoInfo.VideoType = (Enum_VideoType)cmbVideoType.SelectedValue;
            int intVideoType = Convert.ToInt32(cmbVideoType.SelectedValue);
            switch (intVideoType)
            {
                case 1:
                    videoInfo.VideoType = Enum_VideoType.CloundSee;
                    break;
            }

            videoInfo.DVSAddress = cmbDVSAddress.Text;
            videoInfo.DVSConnectPort = Convert.ToInt32(txtContactPort.Text);
            videoInfo.UserName = txtUserName.Text;
            videoInfo.Password = txtPassword.Text;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            CameraInfo camerasInfo = new CameraInfo();
            int intChannel = Convert.ToInt32(txtChannel.Text);
            camerasInfo.Channel = intChannel;
            camerasInfo.CameraName = "通道" + intChannel;
            videoInfo.Cameras[intChannel] = camerasInfo;

            VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            videoPlaySet.VideoRecordEnable = chkVideoRecordEnable.Checked;
            videoPlaySet.VideoMonitorEnable = chkMonitorEnable.Checked;
            videoPlaySet.PerVideoRecord = chkProVideoRecord.Checked;
            int intVideoIndex = Convert.ToInt32(cmbOperAtWindows.SelectedValue);
            if (chkPresetEanble.Checked)
            {
                videoPlaySet.PreSetPosi = Convert.ToInt32(cmbPreset.Text);
            }
            if (intVideoIndex == 0)
            {
                PlayVideo(videoWindowTest, videoInfo, videoPlaySet);
            }
            else
            {
                PlayVideo(lstVideoPlayWindow[intVideoIndex - 1], videoInfo, videoPlaySet);
            }
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = new VideoInfo();
            //videoInfo.VideoType = (Enum_VideoType)cmbVideoType.SelectedValue;
            //int intVideoType = Convert.ToInt32(cmbVideoType.SelectedValue);
            //switch (intVideoType)
            //{
            //    case 1:
            //        videoInfo.VideoType = Enum_VideoType.CloundSee;
            //        break;
            //}
            videoInfo.VideoType = (Enum_VideoType)Convert.ToInt32(cmbVideoType.SelectedValue);
            videoInfo.DVSNumber = txtVideoID.Text.ToString();
            videoInfo.DVSAddress = cmbDVSAddress.Text;
            videoInfo.DVSConnectPort = Convert.ToInt32(txtContactPort.Text);
            videoInfo.UserName = txtUserName.Text;
            videoInfo.Password = txtPassword.Text;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            int intChannelNum = Convert.ToInt32(txtChannel.Text);
            videoInfo.DVSChannelNum = intChannelNum;
            CameraInfo camerasInfo = new CameraInfo();
            for (int i = 0; i < intChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            if (!dicVideoInfos.ContainsKey(videoInfo.DVSNumber))
            {
                //不存在 列表不刷新
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
                VideoListRefresh();
            }
            else
            {
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            }
        }

        private void cmbVideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            intCurrentVideoID = cmbVideoList.Text;
            if (string.IsNullOrEmpty(intCurrentVideoID) || !dicVideoInfos.ContainsKey(intCurrentVideoID))
            {
                ReSetVideoInfo();
                videoChannelList.Init_SetVideoInfo(null);
                return;
            }
            SetVideoInfo(intCurrentVideoID);
            //txtcu
        }

        public void SetVideoInfo(string strVideoID)
        {
            if (dicVideoInfos.ContainsKey(strVideoID))
            {
                txtCurrentDVSType.Text = dicVideoInfos[strVideoID].VideoType.ToString();
                txtCurrentDVSAddress.Text = dicVideoInfos[strVideoID].DVSAddress;
                txtCurrentDVSPort.Text = dicVideoInfos[strVideoID].DVSConnectPort.ToString();
                txtCurrentUserName.Text = dicVideoInfos[strVideoID].UserName;
                txtCurrentDVSPwd.Text = dicVideoInfos[strVideoID].Password;
                txtCurrentChannelNum.Text = dicVideoInfos[strVideoID].DVSChannelNum.ToString();
                videoChannelList.Init_SetVideoInfo(dicVideoInfos[strVideoID]);
            }
        }
        public void ReSetVideoInfo()
        {
            txtCurrentDVSType.Text = "";
            txtCurrentDVSAddress.Text = "";
            txtCurrentDVSPort.Text = "";
            txtCurrentUserName.Text = "";
            txtCurrentDVSPwd.Text = "";
            txtCurrentChannelNum.Text = "";
        }


        public void VideoChannelListButton_Click(object sender, Button btnChannel)
        {
            CameraInfo cameraInfo = (CameraInfo)btnChannel.Tag;
            videoChannelList.ButtonListBackColorReset();
            //Button btn = (Button)sender;
            btnChannel.BackColor = Color.Red;
            VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            int intVideoIndex = Convert.ToInt32(cmbPlayWindows.SelectedValue);
            //播放
            if (chkPresetEanble.Checked)
            {
                videoPlaySet.PreSetPosi = Convert.ToInt32(cmbPreset.Text);
            }
            videoPlaySet.VideoMonitorEnable = chkMonitorEnable.Checked;
            videoPlaySet.VideoRecordEnable = chkVideoRecordEnable.Checked;
            videoPlaySet.PerVideoRecord = chkProVideoRecord.Checked;
            videoPlaySet.VideoRecordFilePath = txtVideoRecord.Text;
            videoPlaySet.AutoReconn = false;
            if (dicVideoInfos[intCurrentVideoID].VideoType == Enum_VideoType.SKVideo)
            {
                string strTimeValue = DateTime.Now.ToString("yyyyMMddHHmmss");
                StringBuilder sbVideoRecordPath = new StringBuilder();
                sbVideoRecordPath.Append(dicVideoInfos[intCurrentVideoID].DVSNumber.Substring(0, 4) + "\\");
                sbVideoRecordPath.Append(strTimeValue + "\\");
                sbVideoRecordPath.Append(intCurrentVideoID + "_");
                sbVideoRecordPath.Append(cameraInfo.Channel.ToString().PadLeft(2, '0') + "_");
                sbVideoRecordPath.Append(strTimeValue + "_81.H264");
                videoPlaySet.VideoRecordFilePath = sbVideoRecordPath.ToString();

                StringBuilder sbPreVideoRecordPath = new StringBuilder();
                sbPreVideoRecordPath.Append("http://121.41.87.203:8008/SK_VideoRecord/");
                sbPreVideoRecordPath.Append(dicVideoInfos[intCurrentVideoID].DVSNumber.Substring(0, 4) + "\\");
                sbPreVideoRecordPath.Append(strTimeValue + "\\");
                videoPlaySet.PreVideoRecordFilePath = sbPreVideoRecordPath.ToString();
            }
            if (intVideoIndex == 0)
            {
                if (videoWindowTest.VideoPlayState == Enum_VideoPlayState.InPlayState)
                {
                    //处于播放状态
                    videoWindowTest.VideoClose();
                }
                //测试界面
                PlayVideo(videoWindowTest, dicVideoInfos[intCurrentVideoID], cameraInfo, videoPlaySet);
            }
            else
            {
                if (lstVideoPlayWindow[intVideoIndex - 1].VideoPlayState == Enum_VideoPlayState.InPlayState)
                {
                    //处于播放状态
                    lstVideoPlayWindow[intVideoIndex - 1].VideoClose();
                }
                PlayVideo(lstVideoPlayWindow[intVideoIndex - 1], dicVideoInfos[intCurrentVideoID], cameraInfo, videoPlaySet);
            }
        }

        private void cmbOperAtPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            int intVideoIndex = Convert.ToInt32(cmbOperAtWindows.SelectedValue);
            int intPresetPosi = int.Parse(cmbOperAtPreset.Text.ToString());
            //播放
            if (intVideoIndex == 0)
            {
                //测试界面
                videoWindowTest.SetPresetPosi(intPresetPosi);
            }
            else
            {
                lstVideoPlayWindow[intVideoIndex - 1].SetPresetPosi(intPresetPosi);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            lstVideoPlayWindow[0].Init_VideoInfo(GetVideoInfo());
            lstVideoPlayWindow[0].VideoPlay();
        }

        private void btnTestClose_Click(object sender, EventArgs e)
        {
            videoWindowTest.VideoClose();
            //lstVideoPlayWindow[0].VideoClose();
            //videoWindowTest.VideoClose();
            //SDKState.Ezviz_SDKRelease();
        }

        private void btnWindowPlay_Click(object sender, EventArgs e)
        {
            SDKState.Ezviz_SDKInit();
            SDK_EzvizSDK.GetAccessToken();
            Frm_VideoPlayWindows frmVideoWindows = new Frm_VideoPlayWindows(GetVideoInfo());
            frmVideoWindows.Show();
        }


        public VideoInfo GetVideoInfo()
        {
            VideoInfo videoInfo = new VideoInfo();
            videoInfo.VideoType = (Enum_VideoType)Convert.ToInt32(cmbVideoType.SelectedValue);
            videoInfo.DVSAddress = cmbDVSAddress.Text;
            videoInfo.DVSConnectPort = Convert.ToInt32(txtContactPort.Text);
            videoInfo.UserName = txtUserName.Text;
            videoInfo.Password = txtPassword.Text;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            CameraInfo camerasInfo = new CameraInfo();
            for (int i = 1; i < 2; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "通道" + i;
                if (cmbDVSAddress.Text == "721283866")
                {
                    camerasInfo.CameraUniqueCode = "be74ee024b654e078ff5e7014af00e4f";
                }
                else if (cmbDVSAddress.Text == "720274352")
                {
                    camerasInfo.CameraUniqueCode = "864eb2adf3964fe38b85661f32145526";
                }
                videoInfo.Cameras[i] = camerasInfo;
            }
            return videoInfo;
        }



        int intTempCount = 0;

        
        int Temp_i = 1;
        int Temp_ii = 0;
        bool bolTestMode = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (Temp_i >= 5)
            {
                Temp_i = 1;
            }
            VideoChannelListButton_Click(videoChannelList.lstbtns[Temp_i], (videoChannelList.lstbtns[Temp_i]));
            Temp_i++;
            Temp_ii++;
            label17.Text = Temp_ii.ToString();
            if (bolTestMode)
            {
                timer1.Enabled = true;
            }

            //SDKState.ColundSee_SDKRelease();
            //SDKState.CloundSee_SDKInit();
        }

        private void btnStopTest_Click(object sender, EventArgs e)
        {
            bolTestMode = false;
            timer1.Enabled = false;
        }


        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SDKState.Huamai_Release();
        }
        #region 测试数据相关
        private void btnEzvizTestData_Click(object sender, EventArgs e)
        {
            Ezviz_TestData();
            cmbVideoList.SelectedIndex = 0;
            //bolTestMode = true;
            //timer1.Enabled = true;
        }

        private void btnSKTestData_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = SKVideo_TestData();
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }
        private void btnHuaMaiTestData_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = HuaMaiVideo_TestData();
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }
        private void btnXMTestData1_Click(object sender, EventArgs e)
        {
            VideoInfo v = TestDataSource.TestDataSource.XMDataSource2();
            dicVideoInfos[v.DVSNumber] = v;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }
        private void btnHikTestData1_Click(object sender, EventArgs e)
        {
            VideoInfo v = TestDataSource.TestDataSource.GetHikDVSData1();
            dicVideoInfos[v.DVSNumber] = v;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }
        public void Ezviz_TestData()
        {
            //"cameraId":"7e1c18bad66544408b38d1711552e320","cameraName":"视频1@DVR(756217914)",
            //"cameraNo":1,"defence":0,"deviceId":"649b48f4d02d42df8486a17be911d49e756217914",
            //"deviceName":"测试1_DVR_756217914","deviceSerial":"756217914","isEncrypt":0,"isShared":"0",
            //"picUrl":"https://i.ys7.com/assets/imgs/public/homeDevice.jpeg","status":1,"videoLevel":0},
            VideoInfo videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.Ezviz;

            videoInfo.DVSNumber = "萤石云测试1";
            videoInfo.DVSAddress = "756217914";
            videoInfo.DVSConnectPort = 0;
            videoInfo.UserName = "";
            videoInfo.Password = "";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            int intChannelNum = 9;
            videoInfo.DVSChannelNum = intChannelNum;
            CameraInfo camerasInfo = new CameraInfo();
            for (int i = 0; i < intChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                switch (i)
                {
                    case 0:
                        camerasInfo.CameraUniqueCode = "7e1c18bad66544408b38d1711552e320";
                        break;

                    case 1:
                        camerasInfo.CameraUniqueCode = "d6ee65642d2e4a1a8af5ea6abf5dcae2";
                        break;

                    case 2:
                        camerasInfo.CameraUniqueCode = "ba749979770548dd87587bed55788224";
                        break;

                    case 3:
                        camerasInfo.CameraUniqueCode = "f148f52961f740d68c64977c19fcd3fb";
                        break;

                    case 4:
                        camerasInfo.CameraUniqueCode = "33af536cb403408f86d4c7f4e5b47690";
                        break;

                    case 5:
                        camerasInfo.CameraUniqueCode = "d38b8d7b885a4e9bade97a738dfbc87f";
                        break;

                    case 6:
                        camerasInfo.CameraUniqueCode = "5eb2a6ef219248959ba28a5f23a4ae69";
                        break;

                    case 7:
                        camerasInfo.CameraUniqueCode = "6fb4d4f576214eccadc6003b09d614d2";
                        break;

                    case 8:
                        camerasInfo.CameraUniqueCode = "c78025dc89af4b43a44b0572855e6e3d";
                        break;
                }
                videoInfo.Cameras[i] = camerasInfo;
            }
            if (!dicVideoInfos.ContainsKey(videoInfo.DVSNumber))
            {
                //不存在 列表不刷新
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
                VideoListRefresh();
            }
            else
            {
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            }

        }

        public void Ezviz_TestData1()
        {
            //"cameraId":"7e1c18bad66544408b38d1711552e320","cameraName":"视频1@DVR(756217914)",
            //"cameraNo":1,"defence":0,"deviceId":"649b48f4d02d42df8486a17be911d49e756217914",
            //"deviceName":"测试1_DVR_756217914","deviceSerial":"756217914","isEncrypt":0,"isShared":"0",
            //"picUrl":"https://i.ys7.com/assets/imgs/public/homeDevice.jpeg","status":1,"videoLevel":0},
            VideoInfo videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.Ezviz;

            videoInfo.DVSNumber = "萤石云测试1";
            videoInfo.DVSAddress = "797085722";
            videoInfo.DVSConnectPort = 0;
            videoInfo.UserName = "";
            videoInfo.Password = "CHZUVE1";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            int intChannelNum = 9;
            videoInfo.DVSChannelNum = intChannelNum;
            CameraInfo camerasInfo = new CameraInfo();
            for (int i = 0; i < intChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                switch (i)
                {
                    case 0:
                        camerasInfo.CameraUniqueCode = "7e1c18bad66544408b38d1711552e320";
                        break;

                    case 1:
                        camerasInfo.CameraUniqueCode = "d6ee65642d2e4a1a8af5ea6abf5dcae2";
                        break;

                    case 2:
                        camerasInfo.CameraUniqueCode = "ba749979770548dd87587bed55788224";
                        break;

                    case 3:
                        camerasInfo.CameraUniqueCode = "f148f52961f740d68c64977c19fcd3fb";
                        break;

                    case 4:
                        camerasInfo.CameraUniqueCode = "33af536cb403408f86d4c7f4e5b47690";
                        break;

                    case 5:
                        camerasInfo.CameraUniqueCode = "d38b8d7b885a4e9bade97a738dfbc87f";
                        break;

                    case 6:
                        camerasInfo.CameraUniqueCode = "5eb2a6ef219248959ba28a5f23a4ae69";
                        break;

                    case 7:
                        camerasInfo.CameraUniqueCode = "6fb4d4f576214eccadc6003b09d614d2";
                        break;

                    case 8:
                        camerasInfo.CameraUniqueCode = "c78025dc89af4b43a44b0572855e6e3d";
                        break;
                }
                videoInfo.Cameras[i] = camerasInfo;
            }
            if (!dicVideoInfos.ContainsKey(videoInfo.DVSNumber))
            {
                //不存在 列表不刷新
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
                VideoListRefresh();
            }
            else
            {
                dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            }

        }

        public VideoInfo SKVideo_TestData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "61-573539920B39-3036";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8604双网口测试";
            v.DVSNumber = "770701";
            v.DVSType = "SK8616";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            for (int i = 8; i < 16; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "61-573551920B39-3036";
                c.DVSType = "SK8616";
                c.DVSNumber = "999401";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public VideoInfo SKVideo_TestData1()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.SKVideo;
            v.DVSAddress = "72-00F51F010E10-2B25";
            v.DVSChannelNum = 16;
            v.DVSConnectPort = 81;
            v.DVSName = "8519云台控制";
            v.DVSNumber = "770701";
            v.DVSType = "SK8519V";
            v.HostID = "9994";
            v.Password = "sk123456";
            v.UserName = "admin";
            v.NetworkState = 0;
            for (int i = 0; i < 1; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = v.DVSAddress;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            for (int i = 8; i < 12; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = v.DVSAddress;
                c.DVSType = v.DVSType;
                c.DVSNumber = v.DVSNumber;
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        public VideoInfo HuaMaiVideo_TestData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.HuaMaiVideo;
            v.DVSAddress = "2B9B617805185";
            v.DVSChannelNum = 4;
            v.DVSConnectPort = 81;
            v.DVSName = "华迈云测试";
            v.DVSNumber = "000501";
            v.DVSType = "SK8605HM";
            v.HostID = "0005";
            v.UserName = "admin";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }

        public VideoInfo Axis_TestData()
        {
            VideoInfo v = new VideoInfo();
            v.VideoType = Enum_VideoType.Axis;
            v.DVSAddress = "192.168.2.164";
            v.DVSChannelNum = 4;
            v.DVSConnectPort = 81;
            v.DVSName = "安讯士测试";
            v.DVSNumber = "000601";
            v.DVSType = "AXISM3037";
            v.HostID = "0006";
            v.UserName = "root";
            v.Password = "sk123456";
            v.NetworkState = 0;
            for (int i = 0; i < 4; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i + 1);
                c.Channel = i;
                c.DVSAddress = "192.168.2.164";
                c.DVSType = "AXISM3037";
                c.DVSNumber = "000601";
                v.Cameras[c.Channel] = c;
            }
            return v;
        }
        #endregion

        #region SDK状态相关事件


        public void SDKStateChange(Enum_VideoType sdkType, Enum_SDKState sdkState)
        {
            AddRecord(sdkType.ToString() + "[" + sdkState.ToString() + "]", "SDKState");
            switch (sdkType)
            {
                case Enum_VideoType.CloundSee:
                    grpCloundSeeSDKState.Text = "云视通SDK状态:" + sdkState.ToString();
                    break;
                case Enum_VideoType.Ezviz:
                    grpEzvizSDKState.Text = "萤石云SDK状态:" + sdkState.ToString();
                    break;
                case Enum_VideoType.SKVideo:
                    grpSKSDKStatus.Text = "时刻SDK状态:" + sdkState.ToString();
                    break;
                case Enum_VideoType.HuaMaiVideo:
                    grpHuaMaiSDKStatus.Text = "华迈SDK状态:" + sdkState.ToString();
                    break;
            }
        }

        private void btnCloundSeeSDKInit_Click(object sender, EventArgs e)
        {
            SDKState.CloundSee_SDKInit();
        }

        private void btnCloundSeeSDKRelease_Click(object sender, EventArgs e)
        {
            SDKState.ColundSee_SDKRelease();
        }


        /// <summary>
        /// 萤石云SDK初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEzvizSDKInit_Click(object sender, EventArgs e)
        {
            SDKState.Ezviz_SDKInit();
            SDK_EzvizSDK.GetAccessToken();
        }

        /// <summary>
        /// 萤石云SDK释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEzvizSDKRelease_Click(object sender, EventArgs e)
        {
            SDKState.Ezviz_SDKRelease();
        }

        private void btnSKSDKInit_Click(object sender, EventArgs e)
        {

        }

        private void btnSKSDKUninit_Click(object sender, EventArgs e)
        {

        }

        private void btnGetSKSDKStatus_Click(object sender, EventArgs e)
        {
            string strResult = SDKState.GetSKSDKClientOlineStatus() == 1 ? "在线" : "离线";
            MessageBox.Show(strResult);
        }

        private void btnHuaMaiSDKInit_Click(object sender, EventArgs e)
        {
            SDKState.HuaMai_Init();
        }

        private void btnHuaMaiSDKRelease_Click(object sender, EventArgs e)
        {
            SDKState.Huamai_Release();
        }


        #endregion

        private void btnSKTestData1_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = SKVideo_TestData1();
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }

        private void btnAxisTestData_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = Axis_TestData();
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
            StringBuilder sbAxisVideoRecord = new StringBuilder();
            sbAxisVideoRecord.Append(Application.StartupPath);
            sbAxisVideoRecord.Append("\\AxisRecord");
            sbAxisVideoRecord.Append("\\" + videoInfo.DVSNumber + "_00_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_06.bin");
            txtVideoRecord.Text = sbAxisVideoRecord.ToString();
        }

        private void btnBlueSkyTestData_Click(object sender, EventArgs e)
        {
            VideoInfo v = TestDataSource.TestDataSource.BuleSkyDataSource();
            dicVideoInfos[v.DVSNumber] = v;
            VideoListRefresh();
            cmbVideoList.SelectedIndex = 0;
        }

        int intBtnClick = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            VideoChannelListButton_Click(videoChannelList.lstbtns[Temp_i], (videoChannelList.lstbtns[intBtnClick]));

            if (intBtnClick == 1)
            {
                intBtnClick = 2;
            }
            else
            {
                intBtnClick = 1;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (timer2.Enabled)
            {
                timer2.Enabled = false;
            }
            else
            {
                timer2.Enabled = true;

            }
        }
    }
}
