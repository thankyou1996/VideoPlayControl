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
            this.picPTZCOntrol = new System.Windows.Forms.PictureBox();
            this.pnlOtherControl = new System.Windows.Forms.Panel();
            this.ptzControl_Basic1 = new VideoPlayControl.Controls.PTZ.PTZControl_Basic();
            ((System.ComponentModel.ISupportInitialize)(this.picPTZCOntrol)).BeginInit();
            this.pnlOtherControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPTZCOntrol
            // 
            this.picPTZCOntrol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picPTZCOntrol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picPTZCOntrol.Image = ((System.Drawing.Image)(resources.GetObject("picPTZCOntrol.Image")));
            this.picPTZCOntrol.Location = new System.Drawing.Point(224, 164);
            this.picPTZCOntrol.Name = "picPTZCOntrol";
            this.picPTZCOntrol.Size = new System.Drawing.Size(16, 16);
            this.picPTZCOntrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPTZCOntrol.TabIndex = 99;
            this.picPTZCOntrol.TabStop = false;
            this.picPTZCOntrol.Click += new System.EventHandler(this.picPTZCOntrol_Click_1);
            // 
            // pnlOtherControl
            // 
            this.pnlOtherControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlOtherControl.Controls.Add(this.ptzControl_Basic1);
            this.pnlOtherControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOtherControl.Location = new System.Drawing.Point(156, 0);
            this.pnlOtherControl.Name = "pnlOtherControl";
            this.pnlOtherControl.Size = new System.Drawing.Size(84, 180);
            this.pnlOtherControl.TabIndex = 100;
            this.pnlOtherControl.Visible = false;
            // 
            // ptzControl_Basic1
            // 
            this.ptzControl_Basic1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptzControl_Basic1.Location = new System.Drawing.Point(-1, 57);
            this.ptzControl_Basic1.Name = "ptzControl_Basic1";
            this.ptzControl_Basic1.Size = new System.Drawing.Size(88, 104);
            this.ptzControl_Basic1.TabIndex = 0;
            // 
            // VideoPlayWindow_PTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPTZCOntrol);
            this.Controls.Add(this.pnlOtherControl);
            this.Name = "VideoPlayWindow_PTZ";
            this.Load += new System.EventHandler(this.VideoPlayWindow_PTZ_Load);
            this.Controls.SetChildIndex(this.pnlOtherControl, 0);
            this.Controls.SetChildIndex(this.picPTZCOntrol, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPTZCOntrol)).EndInit();
            this.pnlOtherControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPTZCOntrol;
        private System.Windows.Forms.Panel pnlOtherControl;
        private PTZ.PTZControl_Basic ptzControl_Basic1;
    }
}
