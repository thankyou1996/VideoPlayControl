namespace VideoPlayControl_UseDemo
{
    partial class FrmVideoInfoList
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
            this.videoPlayGroupControls_VideoInfoList11 = new VideoPlayControl.VideoPlayGroupControls_VideoInfoList1();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoPlayGroupControls_VideoInfoList11
            // 
            this.videoPlayGroupControls_VideoInfoList11.Location = new System.Drawing.Point(69, 56);
            this.videoPlayGroupControls_VideoInfoList11.Name = "videoPlayGroupControls_VideoInfoList11";
            this.videoPlayGroupControls_VideoInfoList11.Size = new System.Drawing.Size(543, 311);
            this.videoPlayGroupControls_VideoInfoList11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmVideoInfoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoPlayGroupControls_VideoInfoList11);
            this.Name = "FrmVideoInfoList";
            this.Text = "FrmVideoInfoList";
            this.Load += new System.EventHandler(this.FrmVideoInfoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControls_VideoInfoList1 videoPlayGroupControls_VideoInfoList11;
        private System.Windows.Forms.Button button1;
    }
}