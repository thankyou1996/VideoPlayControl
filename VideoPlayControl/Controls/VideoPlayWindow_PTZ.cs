using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;

namespace VideoPlayControl.Controls
{
    public partial class VideoPlayWindow_PTZ : VideoPlayWindow
    {
        public VideoPlayWindow_PTZ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 控件面板使能
        /// </summary>
        public bool OtherControlEnable
        {
            get;
            private set;
        } = false;

        private void VideoPlayWindow_PTZ_Load(object sender, EventArgs e)
        {
            ptzControl_Basic1.PTZControlEvent += VideoPTZControl1_PTZControlEvent;
            this.Click += VideoPlayWindow_PTZ_Click;
            this.PicMain.Click += PicMain_Click;
        }

        private void PicMain_Click(object sender, EventArgs e)
        {
            SetPTZControl(false);
        }

        private void VideoPlayWindow_PTZ_Click(object sender, EventArgs e)
        {
            SetPTZControl(false);
        }

        private void VideoPTZControl1_PTZControlEvent(Enum_VideoPTZControl PTZControlCmd, bool bolStart)
        {
            VideoPTZControl(PTZControlCmd, bolStart);
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="vInfo"></param>
        public override void Init_VideoInfo(VideoInfo vInfo) 
        {
            base.Init_VideoInfo(vInfo);
            SetPTZControl(false);
        }

        /// <summary>
        /// 设置云台控制 
        /// </summary>
        /// <param name="bolValue">true 打开云台控制  false 关闭云台控制</param>
        public void SetPTZControl(bool bolValue)
        {
            OtherControlEnable = bolValue;
            pnlOtherControl.Visible = bolValue;
        }

        private void picPTZCOntrol_Click(object sender, EventArgs e)
        {
            SetPTZControl(true);
        }

        private void picPTZCOntrol_Click_1(object sender, EventArgs e)
        {
            SetPTZControl(!OtherControlEnable);

        }
    }
}
