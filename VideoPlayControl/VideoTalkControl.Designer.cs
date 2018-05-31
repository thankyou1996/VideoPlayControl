namespace VideoPlayControl
{
    partial class VideoTalkControl
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
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnShot = new System.Windows.Forms.Button();
            this.btnTalk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMonitor
            // 
            this.btnMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitor.Location = new System.Drawing.Point(0, 46);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(72, 23);
            this.btnMonitor.TabIndex = 8;
            this.btnMonitor.Text = "侦听";
            this.btnMonitor.UseVisualStyleBackColor = true;
            // 
            // btnShot
            // 
            this.btnShot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShot.Location = new System.Drawing.Point(0, 23);
            this.btnShot.Name = "btnShot";
            this.btnShot.Size = new System.Drawing.Size(72, 23);
            this.btnShot.TabIndex = 7;
            this.btnShot.Text = "喊话";
            this.btnShot.UseVisualStyleBackColor = true;
            // 
            // btnTalk
            // 
            this.btnTalk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTalk.Location = new System.Drawing.Point(0, 0);
            this.btnTalk.Name = "btnTalk";
            this.btnTalk.Size = new System.Drawing.Size(72, 23);
            this.btnTalk.TabIndex = 6;
            this.btnTalk.Text = "对讲";
            this.btnTalk.UseVisualStyleBackColor = true;
            // 
            // VideoTalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMonitor);
            this.Controls.Add(this.btnShot);
            this.Controls.Add(this.btnTalk);
            this.Name = "VideoTalkControl";
            this.Size = new System.Drawing.Size(72, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnShot;
        private System.Windows.Forms.Button btnTalk;
    }
}
