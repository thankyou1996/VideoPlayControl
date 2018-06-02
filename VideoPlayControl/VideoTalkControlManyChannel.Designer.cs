namespace VideoPlayControl
{
    partial class VideoTalkControlManyChannel
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
            this.cmbVideoChannel = new System.Windows.Forms.ComboBox();
            this.videoTalkControl1 = new VideoPlayControl.VideoTalkControl();
            this.SuspendLayout();
            // 
            // cmbVideoChannel
            // 
            this.cmbVideoChannel.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbVideoChannel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideoChannel.FormattingEnabled = true;
            this.cmbVideoChannel.Location = new System.Drawing.Point(0, 0);
            this.cmbVideoChannel.Name = "cmbVideoChannel";
            this.cmbVideoChannel.Size = new System.Drawing.Size(85, 20);
            this.cmbVideoChannel.TabIndex = 1;
            this.cmbVideoChannel.SelectedValueChanged += new System.EventHandler(this.cmbVideoChannel_SelectedValueChanged);
            // 
            // videoTalkControl1
            // 
            this.videoTalkControl1.CurrentTalkChannel = null;
            this.videoTalkControl1.CurrentTalkStatus = VideoPlayControl.VideoBasicClass.Enum_TalkStatus.Null;
            this.videoTalkControl1.CurrentVideoInfo = null;
            this.videoTalkControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoTalkControl1.Location = new System.Drawing.Point(0, 20);
            this.videoTalkControl1.Name = "videoTalkControl1";
            this.videoTalkControl1.Size = new System.Drawing.Size(85, 73);
            this.videoTalkControl1.TabIndex = 0;
            // 
            // VideoTalkControlManyChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videoTalkControl1);
            this.Controls.Add(this.cmbVideoChannel);
            this.Name = "VideoTalkControlManyChannel";
            this.Size = new System.Drawing.Size(85, 93);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoTalkControl videoTalkControl1;
        private System.Windows.Forms.ComboBox cmbVideoChannel;
    }
}
