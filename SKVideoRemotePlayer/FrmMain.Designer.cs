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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlChannel = new System.Windows.Forms.Panel();
            this.pnlOperat = new System.Windows.Forms.Panel();
            this.remoteBackplayControl1 = new VideoPlayControl_RemotePlayback.RemotePlaybackControl();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.channelRemoteBackplayInfo1 = new VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo();
            this.channelRemoteBackplayInfo2 = new VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pnlMain.SuspendLayout();
            this.pnlMain_Player.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlChannel.SuspendLayout();
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
            this.pnlMain_Player.Controls.Add(this.button2);
            this.pnlMain_Player.Controls.Add(this.button1);
            this.pnlMain_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain_Player.Location = new System.Drawing.Point(0, 0);
            this.pnlMain_Player.Name = "pnlMain_Player";
            this.pnlMain_Player.Size = new System.Drawing.Size(738, 359);
            this.pnlMain_Player.TabIndex = 0;
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
            this.pnlChannel.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlChannel_Paint);
            // 
            // pnlOperat
            // 
            this.pnlOperat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.pnlOperat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperat.Location = new System.Drawing.Point(0, 84);
            this.pnlOperat.Name = "pnlOperat";
            this.pnlOperat.Size = new System.Drawing.Size(738, 33);
            this.pnlOperat.TabIndex = 1;
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
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.listView1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlLeft.Location = new System.Drawing.Point(738, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(253, 585);
            this.pnlLeft.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // channelRemoteBackplayInfo1
            // 
            this.channelRemoteBackplayInfo1.CurrentRemotePlaybackInfo = null;
            this.channelRemoteBackplayInfo1.Location = new System.Drawing.Point(3, 4);
            this.channelRemoteBackplayInfo1.Name = "channelRemoteBackplayInfo1";
            this.channelRemoteBackplayInfo1.Size = new System.Drawing.Size(678, 20);
            this.channelRemoteBackplayInfo1.TabIndex = 0;
            // 
            // channelRemoteBackplayInfo2
            // 
            this.channelRemoteBackplayInfo2.CurrentRemotePlaybackInfo = null;
            this.channelRemoteBackplayInfo2.Location = new System.Drawing.Point(3, 30);
            this.channelRemoteBackplayInfo2.Name = "channelRemoteBackplayInfo2";
            this.channelRemoteBackplayInfo2.Size = new System.Drawing.Size(678, 20);
            this.channelRemoteBackplayInfo2.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(253, 585);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 585);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain_Player.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlChannel.ResumeLayout(false);
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
        private System.Windows.Forms.ListView listView1;
    }
}

