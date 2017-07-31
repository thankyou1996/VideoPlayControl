using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        #endregion

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
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
            DataRow dr;
            #region 设备类型赋值
            DataTable dtSource = new DataTable();
            dtSource.Columns.Add("value");
            dtSource.Columns.Add("display");
            dr = dtSource.NewRow();
            dr["value"] = "1";
            dr["display"] = "云视通";
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

            for (int i = 1; i < 256; i++)
            {
                cmbPreset.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            cmbPreset.SelectedIndex = 0;
            dgvReocrd.MultiSelect = false;
            videoWindowTest.SDKEventCallBackEvent += SDKEventCallBackEvent;
            videoWindowTest.SDKStateChangedCallBackEvent += SDKStateChangedCallBackEvent;
            videoWindowTest.VideoPlayEventCallBackEvent += VideoPlayEventCallBack;
            videoPTZControl1.PTZControlEvent += PTZControlEvent;
        }

        #endregion

        #region 控件事件
        public void SDKEventCallBackEvent(object sender, Enum_SDKEventType evType, string strTag)
        {
            VideoPlayWindow v = (VideoPlayWindow)sender;
            AddRecord(strTag + "_" + evType.ToString(), v.Name + "_SDK回调事件");
        }

        public void SDKStateChangedCallBackEvent(object sender, Enum_VideoType videoType, Enum_SDKState sdkState)
        {
            VideoPlayWindow v = (VideoPlayWindow)sender;
            AddRecord(videoType.ToString() + "_" + sdkState.ToString(), v.Name + "_SDK状态");
        }

        public void VideoPlayEventCallBack(object sender, Enum_VideoPlayEventType eventType,string strTag)
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
            videoWindowTest.VideoPTZControl(PTZControlCmd, bolStart);
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
                    videoPlayWindow.SDKStateChangedCallBackEvent += SDKStateChangedCallBackEvent;
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
            cmbOperAtVideo.ValueMember = "value";
            cmbOperAtVideo.DisplayMember = "display";
            cmbOperAtVideo.DataSource = dtOperAtVideo;
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
            videoPlayWindow.CloundSee_SDKInit();
            videoPlayWindow.Init_VideoInfo(videoInfo);
            videoPlayWindow.VideoPlay();
        }

        public void PlayVideo(VideoPlayWindow videoPlayWindow, VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
            videoPlayWindow.CloundSee_SDKInit();
            videoPlayWindow.Init_VideoInfo(videoInfo, videoPlaySet);
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

        #endregion
        
        private void btnVideoPly_Click(object sender, EventArgs e)
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
            camerasInfo.CameraName = "通道"+ intChannel;
            videoInfo.Cameras[intChannel] = camerasInfo;

            VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            videoPlaySet.VideoRecordEnable = chkVideoRecordEnable.Checked;
            videoPlaySet.VideoMonitorEnable = chkMonitorEnable.Checked;
            int intVideoIndex = Convert.ToInt32(cmbOperAtVideo.SelectedValue);
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
        
        private void FrmMain_Move(object sender, EventArgs e)
        {
            videoWindowTest.VideoPlayWindows_Move();
            //videoPlayMain2.VideoPlayWindows_Move();
        }

        private void btnVideoPlayClose_Click(object sender, EventArgs e)
        {
            int intVideoIndex = Convert.ToInt32(cmbOperAtVideo.SelectedValue);
            if (intVideoIndex == 0)
            {
                videoWindowTest.VideoClose();
            }
            else
            {
                lstVideoPlayWindow[intVideoIndex - 1].VideoClose();
            }
        }

        private void videoPTZControl1_Load(object sender, EventArgs e)
        {
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int intPresetCall = Convert.ToInt32(cmbPreset.Text);
            //int intLocalChannel = Convert.ToInt32(txtChannel.Text.Trim());
            //JCSDK.JCSDK_PresetCall(intLocalChannel, intPresetCall);
            videoWindowTest.CloundSee_SetPresetPosi(intPresetCall);
        }
    }
}
