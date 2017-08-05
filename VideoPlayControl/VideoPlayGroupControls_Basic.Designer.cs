﻿namespace VideoPlayControl
{
    partial class VideoPlayGroupControls_Basic
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
            this.pblRight_Bottom_Main = new System.Windows.Forms.Panel();
            this.pblRight_Bottom_Top = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.pnlRight_Top = new System.Windows.Forms.Panel();
            this.cmbVideoList = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain.SuspendLayout();
            this.ssPrompt.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlRight_Main.SuspendLayout();
            this.pblRight_Bottom.SuspendLayout();
            this.pblRight_Bottom_Main.SuspendLayout();
            this.pblRight_Bottom_Top.SuspendLayout();
            this.pnlRight_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoPlayWindow
            // 
            this.videoPlayWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow.Location = new System.Drawing.Point(3, 0);
            this.videoPlayWindow.Name = "videoPlayWindow";
            this.videoPlayWindow.Size = new System.Drawing.Size(368, 298);
            this.videoPlayWindow.TabIndex = 1;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.ssPrompt);
            this.pnlMain.Controls.Add(this.videoPlayWindow);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlMain.Size = new System.Drawing.Size(371, 298);
            this.pnlMain.TabIndex = 3;
            // 
            // ssPrompt
            // 
            this.ssPrompt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblPrompt});
            this.ssPrompt.Location = new System.Drawing.Point(3, 276);
            this.ssPrompt.Name = "ssPrompt";
            this.ssPrompt.Size = new System.Drawing.Size(368, 22);
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
            this.videoChannelList.Size = new System.Drawing.Size(126, 124);
            this.videoChannelList.TabIndex = 0;
            // 
            // videoPTZControl
            // 
            this.videoPTZControl.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPTZControl.Location = new System.Drawing.Point(8, 8);
            this.videoPTZControl.Name = "videoPTZControl";
            this.videoPTZControl.Size = new System.Drawing.Size(110, 103);
            this.videoPTZControl.TabIndex = 2;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.pnlRight_Main);
            this.pnlRight.Controls.Add(this.pblRight_Bottom);
            this.pnlRight.Controls.Add(this.pnlRight_Top);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(374, 0);
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
            this.pnlRight_Main.Size = new System.Drawing.Size(126, 124);
            this.pnlRight_Main.TabIndex = 5;
            // 
            // pblRight_Bottom
            // 
            this.pblRight_Bottom.Controls.Add(this.pblRight_Bottom_Main);
            this.pblRight_Bottom.Controls.Add(this.pblRight_Bottom_Top);
            this.pblRight_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pblRight_Bottom.Location = new System.Drawing.Point(0, 148);
            this.pblRight_Bottom.Name = "pblRight_Bottom";
            this.pblRight_Bottom.Size = new System.Drawing.Size(126, 150);
            this.pblRight_Bottom.TabIndex = 6;
            // 
            // pblRight_Bottom_Main
            // 
            this.pblRight_Bottom_Main.Controls.Add(this.videoPTZControl);
            this.pblRight_Bottom_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblRight_Bottom_Main.Location = new System.Drawing.Point(0, 31);
            this.pblRight_Bottom_Main.Name = "pblRight_Bottom_Main";
            this.pblRight_Bottom_Main.Padding = new System.Windows.Forms.Padding(8);
            this.pblRight_Bottom_Main.Size = new System.Drawing.Size(126, 119);
            this.pblRight_Bottom_Main.TabIndex = 7;
            // 
            // pblRight_Bottom_Top
            // 
            this.pblRight_Bottom_Top.Controls.Add(this.label1);
            this.pblRight_Bottom_Top.Controls.Add(this.cmbPreset);
            this.pblRight_Bottom_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblRight_Bottom_Top.Location = new System.Drawing.Point(0, 0);
            this.pblRight_Bottom_Top.Name = "pblRight_Bottom_Top";
            this.pblRight_Bottom_Top.Size = new System.Drawing.Size(126, 31);
            this.pblRight_Bottom_Top.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "预置点";
            // 
            // cmbPreset
            // 
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(50, 7);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(73, 20);
            this.cmbPreset.TabIndex = 3;
            this.cmbPreset.SelectedIndexChanged += new System.EventHandler(this.cmbPreset_SelectedIndexChanged);
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
            this.splitter1.Location = new System.Drawing.Point(371, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 298);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // VideoPlayGroupControls_Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlRight);
            this.Name = "VideoPlayGroupControls_Basic";
            this.Size = new System.Drawing.Size(500, 298);
            this.Load += new System.EventHandler(this.VideoPlayGroupControls_Basic_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ssPrompt.ResumeLayout(false);
            this.ssPrompt.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight_Main.ResumeLayout(false);
            this.pblRight_Bottom.ResumeLayout(false);
            this.pblRight_Bottom_Main.ResumeLayout(false);
            this.pblRight_Bottom_Top.ResumeLayout(false);
            this.pblRight_Bottom_Top.PerformLayout();
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
    }
}