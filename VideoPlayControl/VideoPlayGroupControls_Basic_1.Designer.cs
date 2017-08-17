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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlRight_Main = new System.Windows.Forms.Panel();
            this.pblRight_Bottom = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pblRight_Bottom_PTZControl = new System.Windows.Forms.Panel();
            this.pblRight_Bottom_Main = new System.Windows.Forms.Panel();
            this.videoPTZControl1 = new VideoPlayControl.VideoPTZControl();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlRight_Top = new System.Windows.Forms.Panel();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain.SuspendLayout();
            this.ssPrompt.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRight_Main.SuspendLayout();
            this.pblRight_Bottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.pblRight_Bottom_PTZControl.SuspendLayout();
            this.pblRight_Bottom_Main.SuspendLayout();
            this.pnlRight_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayWindow
            // 
            this.videoPlayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow.Location = new System.Drawing.Point(3, 0);
            this.videoPlayWindow.Name = "videoPlayWindow";
            this.videoPlayWindow.Size = new System.Drawing.Size(541, 276);
            this.videoPlayWindow.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoPlayWindow);
            this.pnlMain.Controls.Add(this.ssPrompt);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(544, 298);
            this.pnlMain.TabIndex = 3;
            // 
            // ssPrompt
            // 
            this.ssPrompt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPrompt});
            this.ssPrompt.Location = new System.Drawing.Point(3, 276);
            this.ssPrompt.Name = "ssPrompt";
            this.ssPrompt.Size = new System.Drawing.Size(541, 22);
            this.ssPrompt.TabIndex = 4;
            this.ssPrompt.Text = "statusStrip1";
            // 
            // tslblPrompt
            // 
            this.tslblPrompt.Name = "tslblPrompt";
            this.tslblPrompt.Size = new System.Drawing.Size(32, 17);
            this.tslblPrompt.Text = "提示";
            // 
            // videoChannelList
            // 
            this.videoChannelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoChannelList.Location = new System.Drawing.Point(0, 0);
            this.videoChannelList.Name = "videoChannelList";
            this.videoChannelList.Size = new System.Drawing.Size(126, 112);
            this.videoChannelList.TabIndex = 0;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRight_Main);
            this.pnlRight.Controls.Add(this.pblRight_Bottom);
            this.pnlRight.Controls.Add(this.pnlRight_Top);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(547, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(126, 298);
            this.pnlRight.TabIndex = 4;
            // 
            // pnlRight_Main
            // 
            this.pnlRight_Main.Controls.Add(this.videoChannelList);
            this.pnlRight_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight_Main.Location = new System.Drawing.Point(0, 24);
            this.pnlRight_Main.Name = "pnlRight_Main";
            this.pnlRight_Main.Size = new System.Drawing.Size(126, 112);
            this.pnlRight_Main.TabIndex = 5;
            // 
            // pblRight_Bottom
            // 
            this.pblRight_Bottom.Controls.Add(this.tabControl1);
            this.pblRight_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblRight_Bottom.Location = new System.Drawing.Point(0, 136);
            this.pblRight_Bottom.Name = "pblRight_Bottom";
            this.pblRight_Bottom.Size = new System.Drawing.Size(126, 162);
            this.pblRight_Bottom.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(126, 162);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(118, 136);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pblRight_Bottom_PTZControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(118, 136);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "云台控制";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pblRight_Bottom_PTZControl
            // 
            this.pblRight_Bottom_PTZControl.Controls.Add(this.pblRight_Bottom_Main);
            this.pblRight_Bottom_PTZControl.Controls.Add(this.cmbPreset);
            this.pblRight_Bottom_PTZControl.Controls.Add(this.label1);
            this.pblRight_Bottom_PTZControl.Location = new System.Drawing.Point(0, 6);
            this.pblRight_Bottom_PTZControl.Name = "pblRight_Bottom_PTZControl";
            this.pblRight_Bottom_PTZControl.Size = new System.Drawing.Size(112, 135);
            this.pblRight_Bottom_PTZControl.TabIndex = 7;
            // 
            // pblRight_Bottom_Main
            // 
            this.pblRight_Bottom_Main.Controls.Add(this.videoPTZControl1);
            this.pblRight_Bottom_Main.Location = new System.Drawing.Point(5, 26);
            this.pblRight_Bottom_Main.Name = "pblRight_Bottom_Main";
            this.pblRight_Bottom_Main.Size = new System.Drawing.Size(100, 100);
            this.pblRight_Bottom_Main.TabIndex = 7;
            // 
            // videoPTZControl1
            // 
            this.videoPTZControl1.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPTZControl1.Location = new System.Drawing.Point(0, 0);
            this.videoPTZControl1.Name = "videoPTZControl1";
            this.videoPTZControl1.Size = new System.Drawing.Size(100, 100);
            this.videoPTZControl1.TabIndex = 0;
            // 
            // cmbPreset
            // 
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(50, 0);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(56, 20);
            this.cmbPreset.TabIndex = 3;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "预置点";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(118, 136);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "对讲面板";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlRight_Top
            // 
            this.pnlRight_Top.Controls.Add(this.cmbVideoList);
            this.pnlRight_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlRight_Top.Location = new System.Drawing.Point(0, 0);
            this.pnlRight_Top.Name = "pnlRight_Top";
            this.pnlRight_Top.Padding = new System.Windows.Forms.Padding(3);
            this.pnlRight_Top.Size = new System.Drawing.Size(126, 24);
            this.pnlRight_Top.TabIndex = 5;
            // 
            // cmbVideoList
            // 
            this.cmbVideoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVideoList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoList.FormattingEnabled = true;
            this.cmbVideoList.Location = new System.Drawing.Point(3, 3);
            this.cmbVideoList.Name = "cmbVideoList";
            this.cmbVideoList.Size = new System.Drawing.Size(120, 20);
            this.cmbVideoList.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(544, 0);
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
            this.Size = new System.Drawing.Size(673, 298);
            this.Load += new System.EventHandler(this.VideoPlayGroupControls_Basic_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ssPrompt.ResumeLayout(false);
            this.ssPrompt.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight_Main.ResumeLayout(false);
            this.pblRight_Bottom.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.pblRight_Bottom_PTZControl.ResumeLayout(false);
            this.pblRight_Bottom_PTZControl.PerformLayout();
            this.pblRight_Bottom_Main.ResumeLayout(false);
            this.pnlRight_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private VideoPlayWindow videoPlayWindow;
        private System.Windows.Forms.Panel pnlMain;
        private VideoChannelList videoChannelList;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.ComboBox cmbVideoList;
        private System.Windows.Forms.Panel pnlRight_Top;
        private System.Windows.Forms.Panel pblRight_Bottom;
        private System.Windows.Forms.Panel pnlRight_Main;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.StatusStrip ssPrompt;
        private System.Windows.Forms.ToolStripStatusLabel tslblPrompt;
        private System.Windows.Forms.Panel pblRight_Bottom_PTZControl;
        private System.Windows.Forms.Panel pblRight_Bottom_Main;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private VideoPTZControl videoPTZControl1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
