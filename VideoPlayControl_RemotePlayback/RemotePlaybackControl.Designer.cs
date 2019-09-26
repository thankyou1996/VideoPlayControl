namespace VideoPlayControl_RemotePlayback
{
    partial class RemotePlaybackControl
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
            this.pnlFlag = new System.Windows.Forms.Panel();
            this.proportionInfo = new VideoPlayControl_RemotePlayback.RemotePlaybackProportionControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // pnlFlag
            // 
            this.pnlFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlFlag.BackColor = System.Drawing.Color.Red;
            this.pnlFlag.Location = new System.Drawing.Point(249, 6);
            this.pnlFlag.Name = "pnlFlag";
            this.pnlFlag.Size = new System.Drawing.Size(2, 79);
            this.pnlFlag.TabIndex = 0;
            // 
            // proportionInfo
            // 
            this.proportionInfo.BackColor = System.Drawing.Color.Red;
            this.proportionInfo.CurrentRemotePlaybackInfo = null;
            this.proportionInfo.Location = new System.Drawing.Point(0, 6);
            this.proportionInfo.Name = "proportionInfo";
            this.proportionInfo.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.proportionInfo.Size = new System.Drawing.Size(500, 70);
            this.proportionInfo.TabIndex = 1;
            this.proportionInfo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProportionInfo_MouseDoubleClick);
            this.proportionInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseDown);
            this.proportionInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseMove);
            this.proportionInfo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseUp);
            // 
            // RemoteBackplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.pnlFlag);
            this.Controls.Add(this.proportionInfo);
            this.Name = "RemoteBackplayControl";
            this.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.Size = new System.Drawing.Size(500, 84);
            this.Load += new System.EventHandler(this.RemoteBackplayControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFlag;
        private RemotePlaybackProportionControl proportionInfo;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
