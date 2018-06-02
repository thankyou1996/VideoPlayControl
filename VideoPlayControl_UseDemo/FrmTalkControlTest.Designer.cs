namespace VideoPlayControl_UseDemo
{
    partial class FrmTalkControlTest
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
            this.videoTalkControl1 = new VideoPlayControl.VideoTalkControl();
            this.videoTalkControlManyChannel1 = new VideoPlayControl.VideoTalkControlManyChannel();
            this.SuspendLayout();
            // 
            // videoTalkControl1
            // 
            this.videoTalkControl1.CurrentTalkChannel = null;
            this.videoTalkControl1.CurrentTalkStatus = VideoPlayControl.VideoBasicClass.Enum_TalkStatus.Null;
            this.videoTalkControl1.CurrentVideoInfo = null;
            this.videoTalkControl1.Location = new System.Drawing.Point(220, 195);
            this.videoTalkControl1.Name = "videoTalkControl1";
            this.videoTalkControl1.Size = new System.Drawing.Size(72, 72);
            this.videoTalkControl1.TabIndex = 0;
            this.videoTalkControl1.Load += new System.EventHandler(this.videoTalkControl1_Load);
            // 
            // videoTalkControlManyChannel1
            // 
            this.videoTalkControlManyChannel1.Location = new System.Drawing.Point(407, 212);
            this.videoTalkControlManyChannel1.Name = "videoTalkControlManyChannel1";
            this.videoTalkControlManyChannel1.Size = new System.Drawing.Size(85, 93);
            this.videoTalkControlManyChannel1.TabIndex = 1;
            this.videoTalkControlManyChannel1.Load += new System.EventHandler(this.videoTalkControlManyChannel1_Load);
            // 
            // FrmTalkControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoTalkControlManyChannel1);
            this.Controls.Add(this.videoTalkControl1);
            this.Name = "FrmTalkControlTest";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmTalkControlTest_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoTalkControl videoTalkControl1;
        private VideoPlayControl.VideoTalkControlManyChannel videoTalkControlManyChannel1;
    }
}