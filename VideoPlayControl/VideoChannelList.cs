using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频通道列表
    /// </summary>
    public partial class VideoChannelList : UserControl
    {
        #region 全局变量
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 按钮列表
        /// </summary>
        List<Button> lstbtns;

        /// <summary>
        /// 初始按钮位置 X
        /// </summary>
        int intbtnStartX = 1;

        /// <summary>
        /// 初始按钮位置 Y
        /// </summary>
        int intbtnStartY = 1;

        /// <summary>
        /// 默认按钮宽度 60
        /// </summary>
        int intbtnWidth = 60;

        /// <summary>
        /// 默认按钮高度 30
        /// </summary>
        int intbtnHeight = 30;
        #endregion


        /// <summary>
        /// 视频通道列表名称
        /// </summary>
        public VideoChannelList()
        {
            InitializeComponent();
        }

        private void VideoChannelList_Load(object sender, EventArgs e)
        {
            Init();
        }

        /// <summary>
        /// 设置视频信息
        /// </summary>
        /// <param name="videoInfo"></param>
        public void Init_SetVideoInfo(VideoInfo videoInfo)
        {
            CurrentVideoInfo = videoInfo;
            SetVideoInfoCameraInfo();
        }

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            Init_SetButtonPara();
            Init_ControlInit();

        }

        /// <summary>
        /// 初始化设置按钮
        /// </summary>
        public void Init_SetButtonPara()
        {
            intbtnWidth = (this.pnlMain.Width - 1) / 2;
        }

        /// <summary>
        /// 初始化_控件初始化
        /// </summary>
        public void Init_ControlInit()
        {
            lstbtns = new List<Button>();

        }
        #endregion


        /// <summary>
        /// 设置摄像头信息按钮
        /// </summary>
        public void SetVideoInfoCameraInfo()
        {
            int intCol = 0;
            int intRow = 0;
            for (int i = lstbtns.Count - 1; i >= 0; i--)
            {
                lstbtns[i].Dispose();
            }
            lstbtns.Clear();
            foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
            {
                //1(x:2 y:27)  2(x:66 y=27)
                //3(x:2,y:63)  4(x:66 y=63)
                Button btn = new Button();
                btn.Name = "btn" + kv.Value.Channel.ToString();
                btn.Location = new System.Drawing.Point(intbtnStartX + (intbtnWidth * intCol), intbtnStartY + (intbtnHeight * intRow));
                btn.Size = new System.Drawing.Size(intbtnWidth, intbtnHeight);
                btn.Text = "通道" + kv.Value.Channel.ToString();
                btn.BackColor = Control.DefaultBackColor;
                pnlMain.Controls.Add(btn);
                btn.Tag = kv.Value;
                btn.Click += btnCameraInfo_Click;
                lstbtns.Add(btn);

                intCol++;
                if (intCol >= 2)
                {
                    intCol = 0;
                    intRow++;
                }
            }
        }
        
        private void btnCameraInfo_Click(object sender, EventArgs e)
        {
            foreach (Button b in lstbtns)
            {
                b.BackColor = Control.DefaultBackColor;
            }
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
            //CurrentCameraInfo = (CameraInfo)btn.Tag;
            //VideoPlaySetting videoPlaySet = new VideoPlaySetting();
            //videoPlaySet.VideoMonitorEnable = true;
            //if (videoPlayWindow.CurrentVideoInfo != null)
            //{
            //    videoPlayWindow.VideoClose();
            //}
            //videoPlayWindow.Init_VideoInfo(CurrentVideoInfos[strCurrentVideoID], CurrentCameraInfo, videoPlaySet);
            //videoPlayWindow.VideoPlay();
        }

    }
}
