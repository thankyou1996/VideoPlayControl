namespace VideoPlayControl_UseDemo
{
    partial class Frm_VideoPlayGroupControls_PTZAndTalk
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
            this.videoPlayGroupControls_PTZAndTalk1 = new VideoPlayControl.VideoPlayGroupControls_PTZAndTalk();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoPlayGroupControls_PTZAndTalk1
            // 
            this.videoPlayGroupControls_PTZAndTalk1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayGroupControls_PTZAndTalk1.Location = new System.Drawing.Point(0, 0);
            this.videoPlayGroupControls_PTZAndTalk1.Name = "videoPlayGroupControls_PTZAndTalk1";
            this.videoPlayGroupControls_PTZAndTalk1.Size = new System.Drawing.Size(626, 482);
            this.videoPlayGroupControls_PTZAndTalk1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_VideoPlayGroupControls_PTZAndTalk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoPlayGroupControls_PTZAndTalk1);
            this.Name = "Frm_VideoPlayGroupControls_PTZAndTalk";
            this.Text = "Frm_VideoPlayGroupControls_PTZAndTalk";
            this.Load += new System.EventHandler(this.Frm_VideoPlayGroupControls_PTZAndTalk_Load);
            this.Move += new System.EventHandler(this.Frm_VideoPlayGroupControls_PTZAndTalk_Move);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControls_PTZAndTalk videoPlayGroupControls_PTZAndTalk1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}