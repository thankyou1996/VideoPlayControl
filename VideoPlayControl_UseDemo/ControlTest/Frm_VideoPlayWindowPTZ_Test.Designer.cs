namespace VideoPlayControl_UseDemo.ControlTest
{
    partial class Frm_VideoPlayWindowPTZ_Test
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
            VideoPlayControl.VideoPlaySetting videoPlaySetting1 = new VideoPlayControl.VideoPlaySetting();
            this.videoPlayWindow_PTZ1 = new VideoPlayControl.Controls.VideoPlayWindow_PTZ();
            this.SuspendLayout();
            // 
            // videoPlayWindow_PTZ1
            // 
            this.videoPlayWindow_PTZ1.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow_PTZ1.CurrentCameraInfo = null;
            this.videoPlayWindow_PTZ1.CurrentVideoInfo = null;
            videoPlaySetting1.AnsyPlay = false;
            videoPlaySetting1.AutoReconn = true;
            videoPlaySetting1.ConnType = VideoPlayControl.Enum.Enum_VideoConnType.Auto;
            videoPlaySetting1.FirstInForcePreSetPosi = false;
            videoPlaySetting1.PerVideoRecord = false;
            videoPlaySetting1.PlayStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            videoPlaySetting1.PreSetPosi = -1;
            videoPlaySetting1.PreVideoRecordFilePath = "";
            videoPlaySetting1.PTZSpeed = 100;
            videoPlaySetting1.TimeOutVideoCloseSecond = 180;
            videoPlaySetting1.TimeOutVideoRecordCloseSecond = 180;
            videoPlaySetting1.VideoMonitorEnable = false;
            videoPlaySetting1.VideoPlayTimeLimit = 0;
            videoPlaySetting1.VideoRecordEnable = false;
            videoPlaySetting1.VideoRecordFileName = "";
            videoPlaySetting1.VideoRecordFileName_Server = "";
            videoPlaySetting1.VideoRecordFilePath = "";
            videoPlaySetting1.VideoRecordFilePath_Server = "";
            videoPlaySetting1.VideoTalkEnable = false;
            this.videoPlayWindow_PTZ1.CurrentVideoPlaySet = videoPlaySetting1;
            this.videoPlayWindow_PTZ1.Location = new System.Drawing.Point(97, 90);
            this.videoPlayWindow_PTZ1.Name = "videoPlayWindow_PTZ1";
            this.videoPlayWindow_PTZ1.Size = new System.Drawing.Size(240, 180);
            this.videoPlayWindow_PTZ1.TabIndex = 0;
            this.videoPlayWindow_PTZ1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            this.videoPlayWindow_PTZ1.VideoplayWindowHeight = 0;
            this.videoPlayWindow_PTZ1.VideoplayWindowWidth = 0;
            this.videoPlayWindow_PTZ1.VideoStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            // 
            // Frm_VideoPlayWindowPTZ_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoPlayWindow_PTZ1);
            this.Name = "Frm_VideoPlayWindowPTZ_Test";
            this.Text = "Frm_VideoPlayWindowPTZ_Test";
            this.Load += new System.EventHandler(this.Frm_VideoPlayWindowPTZ_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.Controls.VideoPlayWindow_PTZ videoPlayWindow_PTZ1;
    }
}