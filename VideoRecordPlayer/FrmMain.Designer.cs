namespace VideoRecordPlayer
{
    partial class FrmMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectedFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStartPlay = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.videoBackplayWindow1 = new VideoPlayControl.VideoBackplayWindow();
            this.pnlMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoBackplayWindow1);
            this.pnlMain.Controls.Add(this.msMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(838, 531);
            this.pnlMain.TabIndex = 1;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSystem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(838, 25);
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
            this.tsmiSelectedFile.Size = new System.Drawing.Size(152, 22);
            this.tsmiSelectedFile.Text = "打开文件";
            this.tsmiSelectedFile.Click += new System.EventHandler(this.tsmiSelectedFile_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(152, 22);
            this.tsmiClose.Text = "退出";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.btnClose);
            this.pnlBottom.Controls.Add(this.btnPause);
            this.pnlBottom.Controls.Add(this.btnStartPlay);
            this.pnlBottom.Controls.Add(this.trackBar);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 531);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(838, 82);
            this.pnlBottom.TabIndex = 2;
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
            this.trackBar.Size = new System.Drawing.Size(838, 45);
            this.trackBar.TabIndex = 7;
            this.trackBar.TickFrequency = 0;
            // 
            // videoBackplayWindow1
            // 
            this.videoBackplayWindow1.AllowDrop = true;
            this.videoBackplayWindow1.CurrentPlaybackState = VideoPlayControl.Enum_VideoPlaybackState.Null;
            this.videoBackplayWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoBackplayWindow1.Location = new System.Drawing.Point(0, 25);
            this.videoBackplayWindow1.Margin = new System.Windows.Forms.Padding(4);
            this.videoBackplayWindow1.Name = "videoBackplayWindow1";
            this.videoBackplayWindow1.Size = new System.Drawing.Size(838, 506);
            this.videoBackplayWindow1.TabIndex = 0;
            this.videoBackplayWindow1.VideoProgresss = 0;
            this.videoBackplayWindow1.DragDrop += new System.Windows.Forms.DragEventHandler(this.videoBackplayWindow1_DragDrop);
            this.videoBackplayWindow1.DragEnter += new System.Windows.Forms.DragEventHandler(this.videoBackplayWindow1_DragEnter);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 613);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlBottom);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "视频录像回放";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
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

        private VideoPlayControl.VideoBackplayWindow videoBackplayWindow1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnStartPlay;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSystem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectedFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
    }
}

