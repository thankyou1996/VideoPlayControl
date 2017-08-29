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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlayWindow));
            this.picPlayMain = new System.Windows.Forms.PictureBox();
            this.axIPCWAMian = new AxRASPLAYEROCXLib.AxRASPlayerOCX();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIPCWAMian)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayMain
            // 
            this.picPlayMain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picPlayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPlayMain.Location = new System.Drawing.Point(0, 0);
            this.picPlayMain.Name = "picPlayMain";
            this.picPlayMain.Size = new System.Drawing.Size(240, 180);
            this.picPlayMain.TabIndex = 0;
            this.picPlayMain.TabStop = false;
            this.picPlayMain.SizeChanged += new System.EventHandler(this.picPlayMain_SizeChanged);
            // 
            // axIPCWAMian
            // 
            this.axIPCWAMian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axIPCWAMian.Enabled = true;
            this.axIPCWAMian.Location = new System.Drawing.Point(0, 0);
            this.axIPCWAMian.Name = "axIPCWAMian";
            this.axIPCWAMian.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axIPCWAMian.OcxState")));
            this.axIPCWAMian.Size = new System.Drawing.Size(240, 180);
            this.axIPCWAMian.TabIndex = 1;
            // 
            // VideoPlayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picPlayMain);
            this.Controls.Add(this.axIPCWAMian);
            this.Name = "VideoPlayWindow";
            this.Size = new System.Drawing.Size(240, 180);
            this.Load += new System.EventHandler(this.VideoPlayMain_Load);
            this.Move += new System.EventHandler(this.VideoPlayMain_Move);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axIPCWAMian)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPlayMain;
        private AxRASPLAYEROCXLib.AxRASPlayerOCX axIPCWAMian;
    }
}
