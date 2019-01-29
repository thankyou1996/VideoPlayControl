namespace VideoPlayControl
{
    partial class VideoPlayWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayWindow));
            this.picPlayMain = new System.Windows.Forms.PictureBox();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.lstimgSoundState = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayMain
            // 
            this.picPlayMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.picPlayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlayMain.Location = new System.Drawing.Point(0, 0);
            this.picPlayMain.Name = "picPlayMain";
            this.picPlayMain.Size = new System.Drawing.Size(240, 180);
            this.picPlayMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayMain.TabIndex = 0;
            this.picPlayMain.TabStop = false;
            this.picPlayMain.SizeChanged += new System.EventHandler(this.picPlayMain_SizeChanged);
            // 
            // picSound
            // 
            this.picSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.picSound.BackColor = System.Drawing.SystemColors.Control;
            this.picSound.Image = ((System.Drawing.Image)(resources.GetObject("picSound.Image")));
            this.picSound.Location = new System.Drawing.Point(0, 160);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(20, 20);
            this.picSound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSound.TabIndex = 20;
            this.picSound.TabStop = false;
            this.picSound.Click += new System.EventHandler(this.picSound_Click);
            // 
            // lstimgSoundState
            // 
            this.lstimgSoundState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstimgSoundState.ImageStream")));
            this.lstimgSoundState.TransparentColor = System.Drawing.Color.Transparent;
            this.lstimgSoundState.Images.SetKeyName(0, "Sound_Off");
            this.lstimgSoundState.Images.SetKeyName(1, "Sound_On");
            // 
            // VideoPlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.picSound);
            this.Controls.Add(this.picPlayMain);
            this.Name = "VideoPlayWindow";
            this.Size = new System.Drawing.Size(240, 180);
            this.Load += new System.EventHandler(this.VideoPlayMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayMain;
        private System.Windows.Forms.PictureBox picSound;
        private System.Windows.Forms.ImageList lstimgSoundState;
    }
}
