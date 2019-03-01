namespace VideoPlayControl
{
    partial class VideoPlayGroupControls_PTZAndTalk
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            VideoPlayControl.VideoPlaySetting videoPlaySetting1 = new VideoPlayControl.VideoPlaySetting();
            this.videoPlayWindow = new VideoPlayControl.VideoPlayWindow();
            this.cmsVideoWindow = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_CloundSeeSetWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_VideoRecord = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ssPrompt = new System.Windows.Forms.StatusStrip();
            this.tslblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.pblRight_Bottom_Top = new System.Windows.Forms.Panel();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pblRight_Bottom_Main = new System.Windows.Forms.Panel();
            this.videoPTZControl = new VideoPlayControl.VideoPTZControl();
            this.videoChannelList = new VideoPlayControl.VideoChannelList();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRight_Main = new System.Windows.Forms.Panel();
            this.pblRight_Bottom = new System.Windows.Forms.Panel();
            this.tabToolbar = new System.Windows.Forms.TabControl();
            this.pageTalk = new System.Windows.Forms.TabPage();
            this.videoTalkControlManyChannel1 = new VideoPlayControl.VideoTalkControlManyChannel();
            this.pagePTZControl = new System.Windows.Forms.TabPage();
            this.pnlRight_Top = new System.Windows.Forms.Panel();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.cmsVideoWindow.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.ssPrompt.SuspendLayout();
            this.pblRight_Bottom_Top.SuspendLayout();
            this.pblRight_Bottom_Main.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRight_Main.SuspendLayout();
            this.pblRight_Bottom.SuspendLayout();
            this.tabToolbar.SuspendLayout();
            this.pageTalk.SuspendLayout();
            this.pagePTZControl.SuspendLayout();
            this.pnlRight_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayWindow
            // 
            this.videoPlayWindow.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow.ContextMenuStrip = this.cmsVideoWindow;
            this.videoPlayWindow.CurrentCameraInfo = null;
            this.videoPlayWindow.CurrentVideoInfo = null;
            videoPlaySetting1.AnsyPlay = false;
            videoPlaySetting1.AutoReconn = true;
            videoPlaySetting1.ConnType = VideoPlayControl.Enum.Enum_VideoConnType.Auto;
            videoPlaySetting1.FirstInForcePreSetPosi = false;
            videoPlaySetting1.PerVideoRecord = false;
            videoPlaySetting1.PreSetPosi = -1;
            videoPlaySetting1.PreVideoRecordFilePath = "";
            videoPlaySetting1.PTZSpeed = 4;
            videoPlaySetting1.TimeOutVideoCloseSecond = 180;
            videoPlaySetting1.TimeOutVideoRecordCloseSecond = 180;
            videoPlaySetting1.VideoMonitorEnable = false;
            videoPlaySetting1.VideoPlayTimeLimit = 0;
            videoPlaySetting1.VideoRecordEnable = false;
            videoPlaySetting1.VideoRecordFileName = "";
            videoPlaySetting1.VideoRecordFileName_Server = "";
            videoPlaySetting1.VideoRecordFilePath = "";
            videoPlaySetting1.VideoRecordFilePath_Server = "";
            this.videoPlayWindow.CurrentVideoPlaySet = videoPlaySetting1;
            this.videoPlayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow.Location = new System.Drawing.Point(3, 0);
            this.videoPlayWindow.Name = "videoPlayWindow";
            this.videoPlayWindow.Size = new System.Drawing.Size(367, 276);
            this.videoPlayWindow.TabIndex = 1;
            this.videoPlayWindow.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            this.videoPlayWindow.VideoplayWindowHeight = 0;
            this.videoPlayWindow.VideoplayWindowWidth = 0;
            // 
            // cmsVideoWindow
            // 
            this.cmsVideoWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_CloundSeeSetWindows,
            this.tsmi_VideoRecord});
            this.cmsVideoWindow.Name = "cmsVideoWindow";
            this.cmsVideoWindow.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmi_CloundSeeSetWindows
            // 
            this.tsmi_CloundSeeSetWindows.Name = "tsmi_CloundSeeSetWindows";
            this.tsmi_CloundSeeSetWindows.Size = new System.Drawing.Size(180, 22);
            this.tsmi_CloundSeeSetWindows.Text = "远程设置";
            this.tsmi_CloundSeeSetWindows.Visible = false;
            this.tsmi_CloundSeeSetWindows.Click += new System.EventHandler(this.tsmi_CloundSeeSetWindows_Click);
            // 
            // tsmi_VideoRecord
            // 
            this.tsmi_VideoRecord.Name = "tsmi_VideoRecord";
            this.tsmi_VideoRecord.Size = new System.Drawing.Size(180, 22);
            this.tsmi_VideoRecord.Text = "开始录像";
            this.tsmi_VideoRecord.Visible = false;
            this.tsmi_VideoRecord.Click += new System.EventHandler(this.tsmi_VideoRecord_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoPlayWindow);
            this.pnlMain.Controls.Add(this.ssPrompt);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(370, 298);
            this.pnlMain.TabIndex = 3;
            // 
            // ssPrompt
            // 
            this.ssPrompt.AutoSize = false;
            this.ssPrompt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPrompt});
            this.ssPrompt.Location = new System.Drawing.Point(3, 276);
            this.ssPrompt.Name = "ssPrompt";
            this.ssPrompt.Size = new System.Drawing.Size(367, 22);
            this.ssPrompt.SizingGrip = false;
            this.ssPrompt.TabIndex = 4;
            // 
            // tslblPrompt
            // 
            this.tslblPrompt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslblPrompt.Name = "tslblPrompt";
            this.tslblPrompt.Size = new System.Drawing.Size(32, 17);
            this.tslblPrompt.Text = "提示";
            // 
            // pblRight_Bottom_Top
            // 
            this.pblRight_Bottom_Top.Controls.Add(this.cmbPreset);
            this.pblRight_Bottom_Top.Controls.Add(this.label1);
            this.pblRight_Bottom_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblRight_Bottom_Top.Location = new System.Drawing.Point(3, 3);
            this.pblRight_Bottom_Top.Name = "pblRight_Bottom_Top";
            this.pblRight_Bottom_Top.Size = new System.Drawing.Size(102, 23);
            this.pblRight_Bottom_Top.TabIndex = 7;
            // 
            // cmbPreset
            // 
            this.cmbPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(41, 0);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(61, 20);
            this.cmbPreset.TabIndex = 3;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "预置点";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pblRight_Bottom_Main
            // 
            this.pblRight_Bottom_Main.Controls.Add(this.videoPTZControl);
            this.pblRight_Bottom_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblRight_Bottom_Main.Location = new System.Drawing.Point(3, 26);
            this.pblRight_Bottom_Main.Name = "pblRight_Bottom_Main";
            this.pblRight_Bottom_Main.Size = new System.Drawing.Size(102, 76);
            this.pblRight_Bottom_Main.TabIndex = 7;
            // 
            // videoPTZControl
            // 
            this.videoPTZControl.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPTZControl.Location = new System.Drawing.Point(0, 0);
            this.videoPTZControl.Name = "videoPTZControl";
            this.videoPTZControl.Size = new System.Drawing.Size(102, 76);
            this.videoPTZControl.TabIndex = 2;
            // 
            // videoChannelList
            // 
            this.videoChannelList.AutoSetChannelButtonSize = false;
            this.videoChannelList.ChannelButtonColumn = 2;
            this.videoChannelList.ChannelButtonHeight = 30;
            this.videoChannelList.ChannelButtonWidth = 60;
            this.videoChannelList.ClrBackColor = System.Drawing.SystemColors.ControlDark;
            this.videoChannelList.ClrChannelButtonDefaultColor = System.Drawing.SystemColors.Control;
            this.videoChannelList.ClrChannelButtonSelectedColor = System.Drawing.Color.Red;
            this.videoChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoChannelList.Location = new System.Drawing.Point(0, 0);
            this.videoChannelList.Name = "videoChannelList";
            this.videoChannelList.Size = new System.Drawing.Size(116, 143);
            this.videoChannelList.TabIndex = 0;
            this.videoChannelList.ButtonChannel_ClickEvent += new VideoPlayControl.VideoChannelList.ButtonChannel_ClickDelegate(this.VideoChannelListButton_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRight_Main);
            this.pnlRight.Controls.Add(this.pblRight_Bottom);
            this.pnlRight.Controls.Add(this.pnlRight_Top);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(373, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(116, 298);
            this.pnlRight.TabIndex = 4;
            // 
            // pnlRight_Main
            // 
            this.pnlRight_Main.Controls.Add(this.videoChannelList);
            this.pnlRight_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight_Main.Location = new System.Drawing.Point(0, 24);
            this.pnlRight_Main.Name = "pnlRight_Main";
            this.pnlRight_Main.Size = new System.Drawing.Size(116, 143);
            this.pnlRight_Main.TabIndex = 5;
            // 
            // pblRight_Bottom
            // 
            this.pblRight_Bottom.Controls.Add(this.tabToolbar);
            this.pblRight_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblRight_Bottom.Location = new System.Drawing.Point(0, 167);
            this.pblRight_Bottom.Name = "pblRight_Bottom";
            this.pblRight_Bottom.Size = new System.Drawing.Size(116, 131);
            this.pblRight_Bottom.TabIndex = 6;
            // 
            // tabToolbar
            // 
            this.tabToolbar.Controls.Add(this.pageTalk);
            this.tabToolbar.Controls.Add(this.pagePTZControl);
            this.tabToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabToolbar.Location = new System.Drawing.Point(0, 0);
            this.tabToolbar.Name = "tabToolbar";
            this.tabToolbar.SelectedIndex = 0;
            this.tabToolbar.Size = new System.Drawing.Size(116, 131);
            this.tabToolbar.TabIndex = 0;
            // 
            // pageTalk
            // 
            this.pageTalk.Controls.Add(this.videoTalkControlManyChannel1);
            this.pageTalk.Location = new System.Drawing.Point(4, 22);
            this.pageTalk.Name = "pageTalk";
            this.pageTalk.Padding = new System.Windows.Forms.Padding(3);
            this.pageTalk.Size = new System.Drawing.Size(108, 105);
            this.pageTalk.TabIndex = 1;
            this.pageTalk.Text = "对讲";
            this.pageTalk.UseVisualStyleBackColor = true;
            // 
            // videoTalkControlManyChannel1
            // 
            this.videoTalkControlManyChannel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoTalkControlManyChannel1.Location = new System.Drawing.Point(3, 3);
            this.videoTalkControlManyChannel1.Name = "videoTalkControlManyChannel1";
            this.videoTalkControlManyChannel1.Size = new System.Drawing.Size(102, 99);
            this.videoTalkControlManyChannel1.TabIndex = 0;
            // 
            // pagePTZControl
            // 
            this.pagePTZControl.Controls.Add(this.pblRight_Bottom_Main);
            this.pagePTZControl.Controls.Add(this.pblRight_Bottom_Top);
            this.pagePTZControl.Location = new System.Drawing.Point(4, 22);
            this.pagePTZControl.Name = "pagePTZControl";
            this.pagePTZControl.Padding = new System.Windows.Forms.Padding(3);
            this.pagePTZControl.Size = new System.Drawing.Size(108, 105);
            this.pagePTZControl.TabIndex = 0;
            this.pagePTZControl.Text = "云台";
            this.pagePTZControl.UseVisualStyleBackColor = true;
            // 
            // pnlRight_Top
            // 
            this.pnlRight_Top.Controls.Add(this.cmbVideoList);
            this.pnlRight_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlRight_Top.Name = "pnlRight_Top";
            this.pnlRight_Top.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRight_Top.Size = new System.Drawing.Size(116, 24);
            this.pnlRight_Top.TabIndex = 5;
            // 
            // cmbVideoList
            // 
            this.cmbVideoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVideoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoList.FormattingEnabled = true;
            this.cmbVideoList.Location = new System.Drawing.Point(3, 3);
            this.cmbVideoList.Name = "cmbVideoList";
            this.cmbVideoList.Size = new System.Drawing.Size(110, 20);
            this.cmbVideoList.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(370, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 298);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // VideoPlayGroupControls_PTZAndTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Name = "VideoPlayGroupControls_PTZAndTalk";
            this.Size = new System.Drawing.Size(489, 298);
            this.Load += new System.EventHandler(this.VideoPlayGroupControls_Basic_Load);
            this.cmsVideoWindow.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ssPrompt.ResumeLayout(false);
            this.ssPrompt.PerformLayout();
            this.pblRight_Bottom_Top.ResumeLayout(false);
            this.pblRight_Bottom_Main.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight_Main.ResumeLayout(false);
            this.pblRight_Bottom.ResumeLayout(false);
            this.tabToolbar.ResumeLayout(false);
            this.pageTalk.ResumeLayout(false);
            this.pagePTZControl.ResumeLayout(false);
            this.pnlRight_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private VideoPlayWindow videoPlayWindow;
        private System.Windows.Forms.Panel pnlMain;
        private VideoChannelList videoChannelList;
        private VideoPTZControl videoPTZControl;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.ComboBox cmbVideoList;
        private System.Windows.Forms.Panel pnlRight_Top;
        private System.Windows.Forms.Panel pblRight_Bottom;
        private System.Windows.Forms.Panel pblRight_Bottom_Main;
        private System.Windows.Forms.Panel pblRight_Bottom_Top;
        private System.Windows.Forms.Panel pnlRight_Main;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip ssPrompt;
        private System.Windows.Forms.ToolStripStatusLabel tslblPrompt;
        private System.Windows.Forms.ContextMenuStrip cmsVideoWindow;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CloundSeeSetWindows;
        private System.Windows.Forms.TabControl tabToolbar;
        private System.Windows.Forms.TabPage pagePTZControl;
        private System.Windows.Forms.TabPage pageTalk;
        private VideoTalkControlManyChannel videoTalkControlManyChannel1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_VideoRecord;
    }
}
