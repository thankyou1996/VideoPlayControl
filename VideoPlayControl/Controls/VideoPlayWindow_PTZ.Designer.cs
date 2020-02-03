namespace VideoPlayControl.Controls
{
    partial class VideoPlayWindow_PTZ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayWindow_PTZ));
            this.videoPTZControl1 = new VideoPlayControl.VideoPTZControl();
            this.picPTZCOntrol = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPTZCOntrol)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPTZControl1
            // 
            this.videoPTZControl1.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl1.Location = new System.Drawing.Point(168, 84);
            this.videoPTZControl1.Margin = new System.Windows.Forms.Padding(0);
            this.videoPTZControl1.Name = "videoPTZControl1";
            this.videoPTZControl1.Size = new System.Drawing.Size(72, 96);
            this.videoPTZControl1.TabIndex = 21;
            this.videoPTZControl1.Visible = false;
            // 
            // picPTZCOntrol
            // 
            this.picPTZCOntrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picPTZCOntrol.BackColor = System.Drawing.SystemColors.Control;
            this.picPTZCOntrol.Image = ((System.Drawing.Image)(resources.GetObject("picPTZCOntrol.Image")));
            this.picPTZCOntrol.Location = new System.Drawing.Point(220, 160);
            this.picPTZCOntrol.Margin = new System.Windows.Forms.Padding(0);
            this.picPTZCOntrol.Name = "picPTZCOntrol";
            this.picPTZCOntrol.Size = new System.Drawing.Size(20, 20);
            this.picPTZCOntrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPTZCOntrol.TabIndex = 22;
            this.picPTZCOntrol.TabStop = false;
            this.picPTZCOntrol.Visible = false;
            this.picPTZCOntrol.Click += new System.EventHandler(this.picPTZCOntrol_Click);
            // 
            // VideoPlayWindow_PTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPTZCOntrol);
            this.Controls.Add(this.videoPTZControl1);
            this.Name = "VideoPlayWindow_PTZ";
            this.Load += new System.EventHandler(this.VideoPlayWindow_PTZ_Load);
            this.Controls.SetChildIndex(this.videoPTZControl1, 0);
            this.Controls.SetChildIndex(this.picPTZCOntrol, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPTZCOntrol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPTZControl videoPTZControl1;
        private System.Windows.Forms.PictureBox picPTZCOntrol;
    }
}
