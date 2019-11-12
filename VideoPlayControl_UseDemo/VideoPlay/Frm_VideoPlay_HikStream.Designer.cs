namespace VideoPlayControl_UseDemo.VideoPlay
{
    partial class Frm_VideoPlay_HikStream
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
            VideoPlayControl.VideoPlaySetting videoPlaySetting2 = new VideoPlayControl.VideoPlaySetting();
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoPlayWindow1
            // 
            this.videoPlayWindow1.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow1.CurrentCameraInfo = null;
            this.videoPlayWindow1.CurrentVideoInfo = null;
            videoPlaySetting2.AnsyPlay = false;
            videoPlaySetting2.AutoReconn = true;
            videoPlaySetting2.ConnType = VideoPlayControl.Enum.Enum_VideoConnType.Auto;
            videoPlaySetting2.FirstInForcePreSetPosi = false;
            videoPlaySetting2.PerVideoRecord = false;
            videoPlaySetting2.PlayStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            videoPlaySetting2.PreSetPosi = -1;
            videoPlaySetting2.PreVideoRecordFilePath = "";
            videoPlaySetting2.PTZSpeed = 100;
            videoPlaySetting2.TimeOutVideoCloseSecond = 180;
            videoPlaySetting2.TimeOutVideoRecordCloseSecond = 180;
            videoPlaySetting2.VideoMonitorEnable = false;
            videoPlaySetting2.VideoPlayTimeLimit = 0;
            videoPlaySetting2.VideoRecordEnable = false;
            videoPlaySetting2.VideoRecordFileName = "";
            videoPlaySetting2.VideoRecordFileName_Server = "";
            videoPlaySetting2.VideoRecordFilePath = "";
            videoPlaySetting2.VideoRecordFilePath_Server = "";
            this.videoPlayWindow1.CurrentVideoPlaySet = videoPlaySetting2;
            this.videoPlayWindow1.Location = new System.Drawing.Point(23, 27);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(511, 259);
            this.videoPlayWindow1.TabIndex = 1;
            this.videoPlayWindow1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            this.videoPlayWindow1.VideoplayWindowHeight = 0;
            this.videoPlayWindow1.VideoplayWindowWidth = 0;
            this.videoPlayWindow1.VideoStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = " 播放";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Frm_VideoPlay_HikStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.videoPlayWindow1);
            this.Name = "Frm_VideoPlay_HikStream";
            this.Text = "Frm_VideoPlay_HikStream";
            this.Load += new System.EventHandler(this.Frm_VideoPlay_HikStream_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayWindow videoPlayWindow1;
        private System.Windows.Forms.Button button1;
    }
}