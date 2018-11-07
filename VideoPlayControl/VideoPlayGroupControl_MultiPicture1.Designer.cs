namespace VideoPlayControl
{
    partial class VideoPlayGroupControl_MultiPicture1
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
            this.tablayMain = new System.Windows.Forms.TableLayoutPanel();
            this.videoPlayWindow4 = new VideoPlayControl.VideoPlayWindow();
            this.videoPlayWindow3 = new VideoPlayControl.VideoPlayWindow();
            this.videoPlayWindow2 = new VideoPlayControl.VideoPlayWindow();
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.tablayMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablayMain
            // 
            this.tablayMain.BackColor = System.Drawing.SystemColors.Control;
            this.tablayMain.ColumnCount = 2;
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablayMain.Controls.Add(this.videoPlayWindow4, 1, 1);
            this.tablayMain.Controls.Add(this.videoPlayWindow3, 0, 1);
            this.tablayMain.Controls.Add(this.videoPlayWindow2, 1, 0);
            this.tablayMain.Controls.Add(this.videoPlayWindow1, 0, 0);
            this.tablayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayMain.Location = new System.Drawing.Point(0, 0);
            this.tablayMain.Name = "tablayMain";
            this.tablayMain.RowCount = 2;
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablayMain.Size = new System.Drawing.Size(742, 553);
            this.tablayMain.TabIndex = 0;
            // 
            // videoPlayWindow4
            // 
            this.videoPlayWindow4.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow4.Location = new System.Drawing.Point(374, 279);
            this.videoPlayWindow4.Name = "videoPlayWindow4";
            this.videoPlayWindow4.Size = new System.Drawing.Size(365, 271);
            this.videoPlayWindow4.TabIndex = 3;
            this.videoPlayWindow4.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // videoPlayWindow3
            // 
            this.videoPlayWindow3.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow3.Location = new System.Drawing.Point(3, 279);
            this.videoPlayWindow3.Name = "videoPlayWindow3";
            this.videoPlayWindow3.Size = new System.Drawing.Size(365, 271);
            this.videoPlayWindow3.TabIndex = 2;
            this.videoPlayWindow3.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // videoPlayWindow2
            // 
            this.videoPlayWindow2.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow2.Location = new System.Drawing.Point(374, 3);
            this.videoPlayWindow2.Name = "videoPlayWindow2";
            this.videoPlayWindow2.Size = new System.Drawing.Size(365, 270);
            this.videoPlayWindow2.TabIndex = 1;
            this.videoPlayWindow2.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // videoPlayWindow1
            // 
            this.videoPlayWindow1.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow1.Location = new System.Drawing.Point(3, 3);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(365, 270);
            this.videoPlayWindow1.TabIndex = 0;
            this.videoPlayWindow1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // VideoPlayGroupControl_MultiPicture1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablayMain);
            this.Name = "VideoPlayGroupControl_MultiPicture1";
            this.Size = new System.Drawing.Size(742, 553);
            this.Load += new System.EventHandler(this.VideoPlayGroupControl_MultiPicture1_Load);
            this.tablayMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablayMain;
        private System.Windows.Forms.ToolTip ttip;
        private VideoPlayWindow videoPlayWindow4;
        private VideoPlayWindow videoPlayWindow3;
        private VideoPlayWindow videoPlayWindow2;
        private VideoPlayWindow videoPlayWindow1;
    }
}
