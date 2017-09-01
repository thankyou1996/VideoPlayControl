namespace VideoPlayControl_UseDemo
{
    partial class Frm_VideoPlayWindows
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
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.SuspendLayout();
            // 
            // videoPlayWindow1
            // 
            this.videoPlayWindow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayWindow1.Location = new System.Drawing.Point(0, 0);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(487, 290);
            this.videoPlayWindow1.TabIndex = 0;
            this.videoPlayWindow1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.videoPlayWindow1_MouseDoubleClick);
            // 
            // Frm_VideoPlayWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 290);
            this.Controls.Add(this.videoPlayWindow1);
            this.Name = "Frm_VideoPlayWindows";
            this.Text = "Frm_VideoPlayWindows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_VideoPlayWindows_FormClosing);
            this.Load += new System.EventHandler(this.Frm_VideoPlayWindows_Load);
            this.Move += new System.EventHandler(this.Frm_VideoPlayWindows_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayWindow videoPlayWindow1;
    }
}