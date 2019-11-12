namespace VideoPlayControl_UseDemo.VideoPlay
{
    partial class Frm_VideoPlay_Hik
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
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChannlNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // videoPlayWindow1
            // 
            this.videoPlayWindow1.BackColor = System.Drawing.SystemColors.Control;
            this.videoPlayWindow1.CurrentCameraInfo = null;
            this.videoPlayWindow1.CurrentVideoInfo = null;
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
            this.videoPlayWindow1.CurrentVideoPlaySet = videoPlaySetting1;
            this.videoPlayWindow1.Location = new System.Drawing.Point(12, 12);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(511, 259);
            this.videoPlayWindow1.TabIndex = 0;
            this.videoPlayWindow1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            this.videoPlayWindow1.VideoplayWindowHeight = 0;
            this.videoPlayWindow1.VideoplayWindowWidth = 0;
            this.videoPlayWindow1.VideoStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(57, 287);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "192.168.2.186";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(198, 287);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "8000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "用户名";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(57, 319);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 2;
            this.txtUserName.Text = "admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "密码";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "sk123456";
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(12, 396);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(75, 23);
            this.btnVideoPlay.TabIndex = 3;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.BtnVideoPlay_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "播放通道";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(71, 354);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 21);
            this.txtChannel.TabIndex = 2;
            this.txtChannel.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "设备通道数";
            // 
            // txtChannlNum
            // 
            this.txtChannlNum.Location = new System.Drawing.Point(387, 319);
            this.txtChannlNum.Name = "txtChannlNum";
            this.txtChannlNum.Size = new System.Drawing.Size(100, 21);
            this.txtChannlNum.TabIndex = 2;
            this.txtChannlNum.Text = "64";
            // 
            // Frm_VideoPlay_Hik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 465);
            this.Controls.Add(this.btnVideoPlay);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtChannlNum);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.videoPlayWindow1);
            this.Name = "Frm_VideoPlay_Hik";
            this.Text = "Frm_VideoPlay_Hik";
            this.Load += new System.EventHandler(this.Frm_VideoPlay_Hik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoPlayControl.VideoPlayWindow videoPlayWindow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChannlNum;
    }
}