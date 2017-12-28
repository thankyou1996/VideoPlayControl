namespace VideoPlayControl
{
    partial class VideoPlayGroupControls_Basic_1
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
            this.videoPlayWindow = new VideoPlayControl.VideoPlayWindow();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ssPrompt = new System.Windows.Forms.StatusStrip();
            this.tslblPrompt = new System.Windows.Forms.ToolStripStatusLabel();
            this.videoChannelList = new VideoPlayControl.VideoChannelList();
            this.videoPTZControl = new VideoPlayControl.VideoPTZControl();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRight_Main = new System.Windows.Forms.Panel();
            this.pblRight_Bottom = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pblRight_Bottom_Top = new System.Windows.Forms.Panel();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pblRight_Bottom_Main = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlRight_Top = new System.Windows.Forms.Panel();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain.SuspendLayout();
            this.ssPrompt.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRight_Main.SuspendLayout();
            this.pblRight_Bottom.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pblRight_Bottom_Top.SuspendLayout();
            this.pblRight_Bottom_Main.SuspendLayout();
            this.pnlRight_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayWindow
            // 
            this.videoPlayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow.Location = new System.Drawing.Point(3, 0);
            this.videoPlayWindow.Name = "videoPlayWindow";
            this.videoPlayWindow.Size = new System.Drawing.Size(414, 276);
            this.videoPlayWindow.TabIndex = 1;
            this.videoPlayWindow.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoPlayWindow);
            this.pnlMain.Controls.Add(this.ssPrompt);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(417, 298);
            this.pnlMain.TabIndex = 3;
            // 
            // ssPrompt
            // 
            this.ssPrompt.AutoSize = false;
            this.ssPrompt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPrompt});
            this.ssPrompt.Location = new System.Drawing.Point(3, 276);
            this.ssPrompt.Name = "ssPrompt";
            this.ssPrompt.Size = new System.Drawing.Size(414, 22);
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
            this.videoChannelList.Size = new System.Drawing.Size(159, 151);
            this.videoChannelList.TabIndex = 0;
            // 
            // videoPTZControl
            // 
            this.videoPTZControl.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl.Location = new System.Drawing.Point(6, 16);
            this.videoPTZControl.Name = "videoPTZControl";
            this.videoPTZControl.Size = new System.Drawing.Size(86, 62);
            this.videoPTZControl.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRight_Main);
            this.pnlRight.Controls.Add(this.pblRight_Bottom);
            this.pnlRight.Controls.Add(this.pnlRight_Top);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(420, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(159, 298);
            this.pnlRight.TabIndex = 4;
            // 
            // pnlRight_Main
            // 
            this.pnlRight_Main.Controls.Add(this.videoChannelList);
            this.pnlRight_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight_Main.Location = new System.Drawing.Point(0, 24);
            this.pnlRight_Main.Name = "pnlRight_Main";
            this.pnlRight_Main.Size = new System.Drawing.Size(159, 151);
            this.pnlRight_Main.TabIndex = 5;
            // 
            // pblRight_Bottom
            // 
            this.pblRight_Bottom.Controls.Add(this.tabControl);
            this.pblRight_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblRight_Bottom.Location = new System.Drawing.Point(0, 175);
            this.pblRight_Bottom.Name = "pblRight_Bottom";
            this.pblRight_Bottom.Size = new System.Drawing.Size(159, 123);
            this.pblRight_Bottom.TabIndex = 6;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(153, 114);
            this.tabControl.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pblRight_Bottom_Top);
            this.tabPage1.Controls.Add(this.pblRight_Bottom_Main);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(145, 88);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pblRight_Bottom_Top
            // 
            this.pblRight_Bottom_Top.Controls.Add(this.cmbPreset);
            this.pblRight_Bottom_Top.Controls.Add(this.label1);
            this.pblRight_Bottom_Top.Location = new System.Drawing.Point(6, 6);
            this.pblRight_Bottom_Top.Name = "pblRight_Bottom_Top";
            this.pblRight_Bottom_Top.Size = new System.Drawing.Size(100, 23);
            this.pblRight_Bottom_Top.TabIndex = 7;
            // 
            // cmbPreset
            // 
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(92, 0);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(59, 20);
            this.cmbPreset.TabIndex = 3;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "预置点";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pblRight_Bottom_Main
            // 
            this.pblRight_Bottom_Main.Controls.Add(this.videoPTZControl);
            this.pblRight_Bottom_Main.Location = new System.Drawing.Point(6, 35);
            this.pblRight_Bottom_Main.Name = "pblRight_Bottom_Main";
            this.pblRight_Bottom_Main.Size = new System.Drawing.Size(100, 100);
            this.pblRight_Bottom_Main.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(145, 88);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlRight_Top
            // 
            this.pnlRight_Top.Controls.Add(this.cmbVideoList);
            this.pnlRight_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlRight_Top.Name = "pnlRight_Top";
            this.pnlRight_Top.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRight_Top.Size = new System.Drawing.Size(159, 24);
            this.pnlRight_Top.TabIndex = 5;
            // 
            // cmbVideoList
            // 
            this.cmbVideoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVideoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoList.FormattingEnabled = true;
            this.cmbVideoList.Location = new System.Drawing.Point(3, 3);
            this.cmbVideoList.Name = "cmbVideoList";
            this.cmbVideoList.Size = new System.Drawing.Size(153, 20);
            this.cmbVideoList.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(417, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 298);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // VideoPlayGroupControls_Basic_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Name = "VideoPlayGroupControls_Basic_1";
            this.Size = new System.Drawing.Size(579, 298);
            this.Load += new System.EventHandler(this.VideoPlayGroupControls_Basic_Load);
            this.pnlMain.ResumeLayout(false);
            this.ssPrompt.ResumeLayout(false);
            this.ssPrompt.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight_Main.ResumeLayout(false);
            this.pblRight_Bottom.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pblRight_Bottom_Top.ResumeLayout(false);
            this.pblRight_Bottom_Main.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
