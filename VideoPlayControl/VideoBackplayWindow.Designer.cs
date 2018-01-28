namespace VideoPlayControl
{
    partial class VideoBackplayWindow
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
            this.picPlaybackMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaybackMain)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlaybackMain
            // 
            this.picPlaybackMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPlaybackMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlaybackMain.Location = new System.Drawing.Point(0, 0);
            this.picPlaybackMain.Name = "picPlaybackMain";
            this.picPlaybackMain.Size = new System.Drawing.Size(315, 250);
            this.picPlaybackMain.TabIndex = 0;
            this.picPlaybackMain.TabStop = false;
            this.picPlaybackMain.SizeChanged += new System.EventHandler(this.picPlaybackMain_SizeChanged);
            // 
            // VideoBackplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPlaybackMain);
            this.Name = "VideoBackplayWindow";
            this.Size = new System.Drawing.Size(315, 250);
            this.Load += new System.EventHandler(this.VideoBackplayWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlaybackMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlaybackMain;
    }
}
