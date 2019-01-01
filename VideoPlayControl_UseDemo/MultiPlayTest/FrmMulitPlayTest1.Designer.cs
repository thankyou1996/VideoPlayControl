namespace VideoPlayControl_UseDemo.MultiPlayTest
{
    partial class FrmMulitPlayTest1
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
            this.videoPlayGroupControl_MultiPicture11 = new VideoPlayControl.VideoPlayGroupControl_MultiPicture1();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoPlayGroupControl_MultiPicture11
            // 
            this.videoPlayGroupControl_MultiPicture11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayGroupControl_MultiPicture11.Location = new System.Drawing.Point(0, 0);
            this.videoPlayGroupControl_MultiPicture11.Name = "videoPlayGroupControl_MultiPicture11";
            this.videoPlayGroupControl_MultiPicture11.Size = new System.Drawing.Size(800, 450);
            this.videoPlayGroupControl_MultiPicture11.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMulitPlayTest1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoPlayGroupControl_MultiPicture11);
            this.Name = "FrmMulitPlayTest1";
            this.Text = "FrmMulitPlayTest1";
            this.Load += new System.EventHandler(this.FrmMulitPlayTest1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControl_MultiPicture1 videoPlayGroupControl_MultiPicture11;
        private System.Windows.Forms.Button button1;
    }
}