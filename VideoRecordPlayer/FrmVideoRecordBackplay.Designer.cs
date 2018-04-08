namespace VideoRecordPlayer
{
    partial class FrmVideoRecordBackplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.videoRecordBackplayWindow1 = new VideoPlayControl.VideoRecordBackplayWindow();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectedFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStartPlay = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.pnlMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoRecordBackplayWindow1);
            this.pnlMain.Controls.Add(this.msMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 460);
            this.pnlMain.TabIndex = 3;
            // 
            // videoRecordBackplayWindow1
            // 
            this.videoRecordBackplayWindow1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.videoRecordBackplayWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoRecordBackplayWindow1.Location = new System.Drawing.Point(0, 25);
            this.videoRecordBackplayWindow1.Name = "videoRecordBackplayWindow1";
            this.videoRecordBackplayWindow1.Size = new System.Drawing.Size(800, 435);
            this.videoRecordBackplayWindow1.TabIndex = 2;
            this.videoRecordBackplayWindow1.DragDrop += new System.Windows.Forms.DragEventHandler(this.videoRecordBackplayWindow1_DragDrop);
            this.videoRecordBackplayWindow1.DragEnter += new System.Windows.Forms.DragEventHandler(this.videoRecordBackplayWindow1_DragEnter);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(800, 25);
            this.msMain.TabIndex = 1;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiSystem
            // 
            this.tsmiSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectedFile,
            this.tsmiClose});
            this.tsmiSystem.Name = "tsmiSystem";
            this.tsmiSystem.Size = new System.Drawing.Size(44, 21);
            this.tsmiSystem.Text = "系统";
            // 
            // tsmiSelectedFile
            // 
            this.tsmiSelectedFile.Name = "tsmiSelectedFile";
            this.tsmiSelectedFile.Size = new System.Drawing.Size(124, 22);
            this.tsmiSelectedFile.Text = "打开文件";
            this.tsmiSelectedFile.Click += new System.EventHandler(this.tsmiSelectedFile_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(124, 22);
            this.tsmiClose.Text = "退出";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnPause);
            this.pnlBottom.Controls.Add(this.btnStartPlay);
            this.pnlBottom.Controls.Add(this.trackBar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 460);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(800, 82);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(160, 45);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(82, 45);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(70, 32);
            this.btnPause.TabIndex = 8;
            this.btnPause.Text = "暂停";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStartPlay
            // 
            this.btnStartPlay.Location = new System.Drawing.Point(4, 45);
            this.btnStartPlay.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartPlay.Name = "btnStartPlay";
            this.btnStartPlay.Size = new System.Drawing.Size(70, 32);
            this.btnStartPlay.TabIndex = 8;
            this.btnStartPlay.Text = "开始";
            this.btnStartPlay.UseVisualStyleBackColor = true;
            this.btnStartPlay.Click += new System.EventHandler(this.btnStartPlay_Click);
            // 
            // trackBar
            // 
            this.trackBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar.LargeChange = 100;
            this.trackBar.Location = new System.Drawing.Point(0, 0);
            this.trackBar.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar.Maximum = 1000;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(800, 45);
            this.trackBar.TabIndex = 7;
            this.trackBar.TickFrequency = 0;
            // 
            // FrmVideoRecordBackplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmVideoRecordBackplay";
            this.Text = "视频回放";
            this.Load += new System.EventHandler(this.FrmVideoRecordBackplay_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStartPlay;
        private System.Windows.Forms.TrackBar trackBar;
        private VideoPlayControl.VideoRecordBackplayWindow videoRecordBackplayWindow1;
    }
}