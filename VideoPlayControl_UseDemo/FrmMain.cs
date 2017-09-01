using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;

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


        Dictionary<string, VideoInfo> dicVideoInfos ;

        string intCurrentVideoID = "";

        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            SDKState.SDKStateChangeEvent += SDKStateChange;
            SDKState.CloundSee_SDKInit();
            Init();
        }

        #region 初始化

        public void Init()
        {
            
            Init_ControlInit();
            PlayWindowSet(4);
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
            dr["value"] = Convert.ToInt32(Enum_VideoType.CloundSee);
            dr["display"] = Enum_VideoType.CloundSee.ToString();
            dtSource.Rows.Add(dr);

            dr = dtSource.NewRow();
            dr["value"] = Convert.ToInt32(Enum_VideoType.IPCWA);
            dr["display"] =  Enum_VideoType.IPCWA.ToString();
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
            videoChannelList.ButtonChannel_ClickEvent += VideoChannelListButton_Click;
            
        }

        public void SDKStateChange(Enum_VideoType sdkType, Enum_SDKState sdkState)
        {
            AddRecord(sdkType.ToString() + "[" + sdkState.ToString() + "]", "SDKState");
            switch (sdkType)
            {
                case Enum_VideoType.CloundSee:
                    grpCloundSeeSDKState.Text = "云视通SDK状态:" + sdkState.ToString();
                    break;
            }
        }
        #endregion

        #region 控件事件
        public void SDKStateChangedCallBackEvent(object sender, Enum_SDKState sdkState)
        {
            VideoPlayWindow v = (VideoPlayWindow)sender;
            AddRecord(sdkState.ToString(), "SDKState");
        }

        public void SDKEventCallBackEvent(object sender, Enum_SDKEventType evType,string strTag)
        {
            VideoPlayWindow v = (VideoPlayWindow)sender;
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
            VideoPlayWindow v = (VideoPlayWindow)sender;
            AddRecord(v.CurrentVideoInfo.DVSAddress + "_" + eventType.ToString(), "VideoEvent");
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

        private void PTZControlEvent(Enum_VideoPTZControl PTZControlCmd,bool bolStart)
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

        #region 按钮事件
        private void btnCloundSeeSDKInit_Click(object sender, EventArgs e)
        {
            SDKState.CloundSee_SDKInit();
        }

        private void btnCloundSeeSDKRelease_Click(object sender, EventArgs e)
        {
            SDKState.ColundSee_SDKRelease();
        }
        #endregion

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


        public void PlayVideo(VideoPlayWindow videoPlayWindow ,VideoInfo videoInfo)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo);
            videoPlayWindow.VideoPlay();
        }

        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo, videoPlaySet);
            videoPlayWindow.VideoPlay();
        }
        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo,CameraInfo camerInfo, VideoPlaySetting videoPlaySet)
        {
            videoPlayWindow.Init_VideoInfo(videoInfo, camerInfo,videoPlaySet);
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
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            VideoInfo videoInfo = new VideoInfo();
            //int intVideoType = Convert.ToInt32(cmbVideoType.SelectedValue);
            //switch (intVideoType)
            //{
            //    case 1:
            //        videoInfo.VideoType = Enum_VideoType.CloundSee;
            //        break;
            //}
            //Enum_VideoType ee = (Enum_VideoType)Convert.ToInt32(cmbVideoType.SelectedValue);
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
                videoInfo.Cameras[i] = camerasInfo;
            }
            videoWindowTest.Init_VideoInfo(videoInfo);
            videoWindowTest.VideoPlay();
            //videoChannelList.Init_SetVideoInfo(videoInfo);
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


        public void VideoChannelListButton_Click(object sender, CameraInfo cameraInfo)
        {
            videoChannelList.ButtonListBackColorReset();
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            int intVideoIndex = Convert.ToInt32(cmbPlayWindows.SelectedValue);
            //播放
            if (chkPresetEanble.Checked)
            {
                videoPlaySet.PreSetPosi = Convert.ToInt32(cmbPreset.Text);
            }
            videoPlaySet.VideoMonitorEnable = chkMonitorEnable.Checked;
            videoPlaySet.VideoRecordEnable = chkVideoRecordEnable.Checked;
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

        private void btnTestClose_Click(object sender, EventArgs e)
        {
            videoWindowTest.VideoClose();
        }

        private void btnWindowPlay_Click(object sender, EventArgs e)
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
                videoInfo.Cameras[i] = camerasInfo;
            }
            Frm_VideoPlayWindows frmVideoWindows = new Frm_VideoPlayWindows(videoInfo);
            frmVideoWindows.Show();
            //videoChannelList.Init_SetVideoInfo(videoInfo);
        }
    }
}
