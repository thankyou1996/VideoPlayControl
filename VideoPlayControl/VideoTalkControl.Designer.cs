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
            this.btnInterception = new System.Windows.Forms.Button();
            this.btnSperak = new System.Windows.Forms.Button();
            this.btnTalkback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInterception
            // 
            this.btnInterception.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInterception.Location = new System.Drawing.Point(0, 48);
            this.btnInterception.Name = "btnInterception";
            this.btnInterception.Size = new System.Drawing.Size(72, 24);
            this.btnInterception.TabIndex = 8;
            this.btnInterception.Text = "开始侦听";
            this.btnInterception.UseVisualStyleBackColor = true;
            this.btnInterception.Click += new System.EventHandler(this.btnInterception_Click);
            // 
            // btnSperak
            // 
            this.btnSperak.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSperak.Location = new System.Drawing.Point(0, 24);
            this.btnSperak.Name = "btnSperak";
            this.btnSperak.Size = new System.Drawing.Size(72, 24);
            this.btnSperak.TabIndex = 7;
            this.btnSperak.Text = "开始喊话";
            this.btnSperak.UseVisualStyleBackColor = true;
            this.btnSperak.Click += new System.EventHandler(this.btnSperak_Click);
            // 
            // btnTalkback
            // 
            this.btnTalkback.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTalkback.Location = new System.Drawing.Point(0, 0);
            this.btnTalkback.Name = "btnTalkback";
            this.btnTalkback.Size = new System.Drawing.Size(72, 24);
            this.btnTalkback.TabIndex = 6;
            this.btnTalkback.Text = "开始对讲";
            this.btnTalkback.UseVisualStyleBackColor = true;
            this.btnTalkback.Click += new System.EventHandler(this.btnTalkback_Click);
            // 
            // VideoTalkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInterception);
            this.Controls.Add(this.btnSperak);
            this.Controls.Add(this.btnTalkback);
            this.Name = "VideoTalkControl";
            this.Size = new System.Drawing.Size(72, 72);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterception;
        private System.Windows.Forms.Button btnSperak;
        private System.Windows.Forms.Button btnTalkback;
    }
}
