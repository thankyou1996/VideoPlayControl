namespace VideoPlayControl.VideoRemoteBackplay
{
    partial class VideoRemoteBackplayWindow
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
            this.picPlayMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayMain
            // 
            this.picPlayMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.picPlayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlayMain.Location = new System.Drawing.Point(0, 0);
            this.picPlayMain.Name = "picPlayMain";
            this.picPlayMain.Size = new System.Drawing.Size(354, 224);
            this.picPlayMain.TabIndex = 0;
            this.picPlayMain.TabStop = false;
            // 
            // VideoRemoteBackplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPlayMain);
            this.Name = "VideoRemoteBackplayWindow";
            this.Size = new System.Drawing.Size(354, 224);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayMain;
    }
}
