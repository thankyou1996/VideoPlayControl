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
            this.ttip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tablayMain
            // 
            this.tablayMain.BackColor = System.Drawing.SystemColors.Control;
            this.tablayMain.ColumnCount = 1;
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablayMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablayMain.Location = new System.Drawing.Point(0, 0);
            this.tablayMain.Name = "tablayMain";
            this.tablayMain.RowCount = 1;
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablayMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablayMain.Size = new System.Drawing.Size(742, 553);
            this.tablayMain.TabIndex = 0;
            // 
            // VideoPlayGroupControl_MultiPicture1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablayMain);
            this.Name = "VideoPlayGroupControl_MultiPicture1";
            this.Size = new System.Drawing.Size(742, 553);
            this.Load += new System.EventHandler(this.VideoPlayGroupControl_MultiPicture1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tablayMain;
        private System.Windows.Forms.ToolTip ttip;
    }
}
