namespace VideoPlayControl_UseDemo
{
    partial class FrmHikTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // videoPlayWindow1
            // 
            this.videoPlayWindow1.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow1.Location = new System.Drawing.Point(2, 12);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(354, 260);
            this.videoPlayWindow1.TabIndex = 0;
            this.videoPlayWindow1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            // 
            // FrmHikTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoPlayWindow1);
            this.Name = "FrmHikTest";
            this.Text = "FrmHikTest";
            this.Load += new System.EventHandler(this.FrmHikTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayWindow videoPlayWindow1;
        private System.Windows.Forms.Button button1;
    }
}