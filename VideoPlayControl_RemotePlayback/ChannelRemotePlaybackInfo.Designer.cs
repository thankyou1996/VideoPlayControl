namespace VideoPlayControl_RemotePlayback
{
    partial class ChannelRemotePlaybackInfo
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
            this.chkChannel = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proportionInfo = new VideoPlayControl_RemotePlayback.RemotePlaybackProportionControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkChannel
            // 
            this.chkChannel.AutoSize = true;
            this.chkChannel.ForeColor = System.Drawing.Color.White;
            this.chkChannel.Location = new System.Drawing.Point(3, 2);
            this.chkChannel.Name = "chkChannel";
            this.chkChannel.Size = new System.Drawing.Size(54, 16);
            this.chkChannel.TabIndex = 2;
            this.chkChannel.Text = "通道1";
            this.chkChannel.UseVisualStyleBackColor = true;
            this.chkChannel.CheckedChanged += new System.EventHandler(this.ChkChannel_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkChannel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 20);
            this.panel1.TabIndex = 3;
            // 
            // proportionInfo
            // 
            this.proportionInfo.BackColor = System.Drawing.Color.Transparent;
            this.proportionInfo.CurrentRemotePlaybackInfo = null;
            this.proportionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proportionInfo.Location = new System.Drawing.Point(94, 0);
            this.proportionInfo.MainColor = System.Drawing.Color.White;
            this.proportionInfo.Name = "proportionInfo";
            this.proportionInfo.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.proportionInfo.Size = new System.Drawing.Size(662, 20);
            this.proportionInfo.TabIndex = 1;
            // 
            // ChannelRemotePlaybackInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.proportionInfo);
            this.Controls.Add(this.panel1);
            this.Name = "ChannelRemotePlaybackInfo";
            this.Size = new System.Drawing.Size(756, 20);
            this.Load += new System.EventHandler(this.ChannelRemoteBackplayInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RemotePlaybackProportionControl proportionInfo;
        private System.Windows.Forms.CheckBox chkChannel;
        private System.Windows.Forms.Panel panel1;
    }
}
