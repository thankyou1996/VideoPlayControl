namespace VideoPlayControl_UseDemo
{
    partial class Frn_VideoPlayGroupControl_Basic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.videoPlayGroupControls_Basic1 = new VideoPlayControl.VideoPlayGroupControls_Basic();
            this.SuspendLayout();
            // 
            // videoPlayGroupControls_Basic1
            // 
            this.videoPlayGroupControls_Basic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayGroupControls_Basic1.Location = new System.Drawing.Point(0, 0);
            this.videoPlayGroupControls_Basic1.Name = "videoPlayGroupControls_Basic1";
            this.videoPlayGroupControls_Basic1.Size = new System.Drawing.Size(840, 472);
            this.videoPlayGroupControls_Basic1.TabIndex = 0;
            // 
            // Frn_VideoPlayGroupControl_Basic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 472);
            this.Controls.Add(this.videoPlayGroupControls_Basic1);
            this.Name = "Frn_VideoPlayGroupControl_Basic";
            this.Text = "视频播放控件组_基本";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frn_VideoPlayGroupControl_Basic_FormClosing);
            this.Load += new System.EventHandler(this.Frn_VideoPlayGroupControl_Basic_Load);
            this.Move += new System.EventHandler(this.Frn_VideoPlayGroupControl_Basic_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControls_Basic videoPlayGroupControls_Basic1;
    }
}