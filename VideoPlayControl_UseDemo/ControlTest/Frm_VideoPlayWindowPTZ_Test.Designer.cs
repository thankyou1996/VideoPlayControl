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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_VideoPlayWindowPTZ_Test));
            this.videoPlayWindow_PTZ1 = new VideoPlayControl.Controls.VideoPlayWindow_PTZ();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picRight = new System.Windows.Forms.PictureBox();
            this.picRightDown = new System.Windows.Forms.PictureBox();
            this.picDown = new System.Windows.Forms.PictureBox();
            this.picLeftDown = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picRightUp = new System.Windows.Forms.PictureBox();
            this.picUp = new System.Windows.Forms.PictureBox();
            this.picLeftUp = new System.Windows.Forms.PictureBox();
            this.picCradle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCradle)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 194);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "right";
            // 
            // picRight
            // 
            this.picRight.Image = ((System.Drawing.Image)(resources.GetObject("picRight.Image")));
            this.picRight.Location = new System.Drawing.Point(527, 231);
            this.picRight.Name = "picRight";
            this.picRight.Size = new System.Drawing.Size(12, 12);
            this.picRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRight.TabIndex = 32;
            this.picRight.TabStop = false;
            this.picRight.Tag = "right";
            // 
            // picRightDown
            // 
            this.picRightDown.Image = ((System.Drawing.Image)(resources.GetObject("picRightDown.Image")));
            this.picRightDown.Location = new System.Drawing.Point(519, 249);
            this.picRightDown.Name = "picRightDown";
            this.picRightDown.Size = new System.Drawing.Size(12, 12);
            this.picRightDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRightDown.TabIndex = 35;
            this.picRightDown.TabStop = false;
            this.picRightDown.Tag = "rightdown";
            // 
            // picDown
            // 
            this.picDown.Image = ((System.Drawing.Image)(resources.GetObject("picDown.Image")));
            this.picDown.Location = new System.Drawing.Point(502, 258);
            this.picDown.Name = "picDown";
            this.picDown.Size = new System.Drawing.Size(12, 12);
            this.picDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDown.TabIndex = 34;
            this.picDown.TabStop = false;
            this.picDown.Tag = "down";
            // 
            // picLeftDown
            // 
            this.picLeftDown.Image = ((System.Drawing.Image)(resources.GetObject("picLeftDown.Image")));
            this.picLeftDown.Location = new System.Drawing.Point(485, 249);
            this.picLeftDown.Name = "picLeftDown";
            this.picLeftDown.Size = new System.Drawing.Size(12, 12);
            this.picLeftDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLeftDown.TabIndex = 33;
            this.picLeftDown.TabStop = false;
            this.picLeftDown.Tag = "leftdown";
            // 
            // picLeft
            // 
            this.picLeft.Image = ((System.Drawing.Image)(resources.GetObject("picLeft.Image")));
            this.picLeft.Location = new System.Drawing.Point(479, 232);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(12, 12);
            this.picLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLeft.TabIndex = 31;
            this.picLeft.TabStop = false;
            this.picLeft.Tag = "left";
            // 
            // picRightUp
            // 
            this.picRightUp.Image = ((System.Drawing.Image)(resources.GetObject("picRightUp.Image")));
            this.picRightUp.Location = new System.Drawing.Point(520, 215);
            this.picRightUp.Name = "picRightUp";
            this.picRightUp.Size = new System.Drawing.Size(12, 12);
            this.picRightUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRightUp.TabIndex = 30;
            this.picRightUp.TabStop = false;
            this.picRightUp.Tag = "rightup";
            // 
            // picUp
            // 
            this.picUp.Image = ((System.Drawing.Image)(resources.GetObject("picUp.Image")));
            this.picUp.InitialImage = null;
            this.picUp.Location = new System.Drawing.Point(503, 207);
            this.picUp.Name = "picUp";
            this.picUp.Size = new System.Drawing.Size(12, 12);
            this.picUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUp.TabIndex = 29;
            this.picUp.TabStop = false;
            this.picUp.Tag = "up";
            // 
            // picLeftUp
            // 
            this.picLeftUp.Image = ((System.Drawing.Image)(resources.GetObject("picLeftUp.Image")));
            this.picLeftUp.Location = new System.Drawing.Point(485, 213);
            this.picLeftUp.Name = "picLeftUp";
            this.picLeftUp.Size = new System.Drawing.Size(12, 12);
            this.picLeftUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLeftUp.TabIndex = 28;
            this.picLeftUp.TabStop = false;
            this.picLeftUp.Tag = "leftup";
            // 
            // picCradle
            // 
            this.picCradle.Image = ((System.Drawing.Image)(resources.GetObject("picCradle.Image")));
            this.picCradle.Location = new System.Drawing.Point(570, 289);
            this.picCradle.Name = "picCradle";
            this.picCradle.Size = new System.Drawing.Size(16, 16);
            this.picCradle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCradle.TabIndex = 99;
            this.picCradle.TabStop = false;
            // 
            // Frm_VideoPlayWindowPTZ_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCradle);
            this.Controls.Add(this.picRight);
            this.Controls.Add(this.picRightDown);
            this.Controls.Add(this.picDown);
            this.Controls.Add(this.picLeftDown);
            this.Controls.Add(this.picLeft);
            this.Controls.Add(this.picRightUp);
            this.Controls.Add(this.picUp);
            this.Controls.Add(this.picLeftUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.videoPlayWindow_PTZ1);
            this.Name = "Frm_VideoPlayWindowPTZ_Test";
            this.Text = "Frm_VideoPlayWindowPTZ_Test";
            this.Load += new System.EventHandler(this.Frm_VideoPlayWindowPTZ_Test_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCradle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoPlayControl.Controls.VideoPlayWindow_PTZ videoPlayWindow_PTZ1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picRight;
        private System.Windows.Forms.PictureBox picRightDown;
        private System.Windows.Forms.PictureBox picDown;
        private System.Windows.Forms.PictureBox picLeftDown;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picRightUp;
        private System.Windows.Forms.PictureBox picUp;
        private System.Windows.Forms.PictureBox picLeftUp;
        private System.Windows.Forms.PictureBox picCradle;
    }
}