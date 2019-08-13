namespace SKVideoRemotePlayer
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain_Player = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChannel = new System.Windows.Forms.Panel();
            this.channelRemoteBackplayInfo2 = new VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo();
            this.channelRemoteBackplayInfo1 = new VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo();
            this.pnlOperat = new System.Windows.Forms.Panel();
            this.btnQueryRecord = new System.Windows.Forms.Button();
            this.remoteBackplayControl1 = new VideoPlayControl_RemotePlayback.RemotePlaybackControl();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lvEvent = new System.Windows.Forms.ListView();
            this.EventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EventContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlMain.SuspendLayout();
            this.pnlMain_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlChannel.SuspendLayout();
            this.pnlOperat.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlMain_Player);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(738, 585);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlMain_Player
            // 
            this.pnlMain_Player.Controls.Add(this.picPlayer);
            this.pnlMain_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain_Player.Location = new System.Drawing.Point(0, 0);
            this.pnlMain_Player.Name = "pnlMain_Player";
            this.pnlMain_Player.Size = new System.Drawing.Size(738, 359);
            this.pnlMain_Player.TabIndex = 0;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Black;
            this.picPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlayer.Location = new System.Drawing.Point(0, 0);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(738, 359);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlChannel);
            this.panel1.Controls.Add(this.pnlOperat);
            this.panel1.Controls.Add(this.remoteBackplayControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 359);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 226);
            this.panel1.TabIndex = 1;
            // 
            // pnlChannel
            // 
            this.pnlChannel.AutoScroll = true;
            this.pnlChannel.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.pnlChannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.pnlChannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlChannel.Controls.Add(this.channelRemoteBackplayInfo2);
            this.pnlChannel.Controls.Add(this.channelRemoteBackplayInfo1);
            this.pnlChannel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChannel.Location = new System.Drawing.Point(0, 117);
            this.pnlChannel.Margin = new System.Windows.Forms.Padding(20, 3, 3, 10);
            this.pnlChannel.Name = "pnlChannel";
            this.pnlChannel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.pnlChannel.Size = new System.Drawing.Size(738, 109);
            this.pnlChannel.TabIndex = 2;
            // 
            // channelRemoteBackplayInfo2
            // 
            this.channelRemoteBackplayInfo2.Checked = false;
            this.channelRemoteBackplayInfo2.CurrentRemotePlaybackInfo = null;
            this.channelRemoteBackplayInfo2.Location = new System.Drawing.Point(3, 30);
            this.channelRemoteBackplayInfo2.Name = "channelRemoteBackplayInfo2";
            this.channelRemoteBackplayInfo2.Size = new System.Drawing.Size(678, 20);
            this.channelRemoteBackplayInfo2.TabIndex = 0;
            // 
            // channelRemoteBackplayInfo1
            // 
            this.channelRemoteBackplayInfo1.Checked = false;
            this.channelRemoteBackplayInfo1.CurrentRemotePlaybackInfo = null;
            this.channelRemoteBackplayInfo1.Location = new System.Drawing.Point(3, 4);
            this.channelRemoteBackplayInfo1.Name = "channelRemoteBackplayInfo1";
            this.channelRemoteBackplayInfo1.Size = new System.Drawing.Size(678, 20);
            this.channelRemoteBackplayInfo1.TabIndex = 0;
            // 
            // pnlOperat
            // 
            this.pnlOperat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.pnlOperat.Controls.Add(this.btnQueryRecord);
            this.pnlOperat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperat.Location = new System.Drawing.Point(0, 84);
            this.pnlOperat.Name = "pnlOperat";
            this.pnlOperat.Size = new System.Drawing.Size(738, 33);
            this.pnlOperat.TabIndex = 1;
            // 
            // btnQueryRecord
            // 
            this.btnQueryRecord.Location = new System.Drawing.Point(633, 6);
            this.btnQueryRecord.Name = "btnQueryRecord";
            this.btnQueryRecord.Size = new System.Drawing.Size(99, 23);
            this.btnQueryRecord.TabIndex = 0;
            this.btnQueryRecord.Text = "录像文件下载";
            this.btnQueryRecord.UseVisualStyleBackColor = true;
            this.btnQueryRecord.Click += new System.EventHandler(this.BtnQueryRecord_Click);
            // 
            // remoteBackplayControl1
            // 
            this.remoteBackplayControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.remoteBackplayControl1.CurrentPositionDateTime = new System.DateTime(((long)(0)));
            this.remoteBackplayControl1.CurrentRemotePlaybackInfo = null;
            this.remoteBackplayControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.remoteBackplayControl1.Location = new System.Drawing.Point(0, 0);
            this.remoteBackplayControl1.Name = "remoteBackplayControl1";
            this.remoteBackplayControl1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.remoteBackplayControl1.Size = new System.Drawing.Size(738, 84);
            this.remoteBackplayControl1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 523);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.button1);
            this.pnlLeft.Controls.Add(this.button2);
            this.pnlLeft.Controls.Add(this.lvEvent);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(738, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(253, 585);
            this.pnlLeft.TabIndex = 1;
            // 
            // lvEvent
            // 
            this.lvEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EventTime,
            this.EventContent});
            this.lvEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEvent.HideSelection = false;
            this.lvEvent.Location = new System.Drawing.Point(0, 0);
            this.lvEvent.Name = "lvEvent";
            this.lvEvent.Size = new System.Drawing.Size(253, 585);
            this.lvEvent.TabIndex = 0;
            this.lvEvent.UseCompatibleStateImageBehavior = false;
            this.lvEvent.View = System.Windows.Forms.View.Details;
            // 
            // EventTime
            // 
            this.EventTime.Text = "时间";
            this.EventTime.Width = 90;
            // 
            // EventContent
            // 
            this.EventContent.Text = "事件";
            this.EventContent.Width = 150;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 585);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain_Player.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlChannel.ResumeLayout(false);
            this.pnlOperat.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlMain_Player;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel panel1;
        private VideoPlayControl_RemotePlayback.RemotePlaybackControl remoteBackplayControl1;
        private System.Windows.Forms.Panel pnlChannel;
        private System.Windows.Forms.Panel pnlOperat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo channelRemoteBackplayInfo2;
        private VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo channelRemoteBackplayInfo1;
        private System.Windows.Forms.ListView lvEvent;
        private System.Windows.Forms.Button btnQueryRecord;
        private System.Windows.Forms.ColumnHeader EventTime;
        private System.Windows.Forms.ColumnHeader EventContent;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}

