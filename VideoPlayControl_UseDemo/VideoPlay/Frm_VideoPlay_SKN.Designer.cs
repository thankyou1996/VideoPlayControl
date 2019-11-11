namespace VideoPlayControl_UseDemo.VideoPlay
{
    partial class Frm_VideoPlay_SKN
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
            this.btnVideoPlay = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtChannlNum = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.videoPlayWindow1 = new VideoPlayControl.VideoPlayWindow();
            this.SuspendLayout();
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(12, 396);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(75, 23);
            this.btnVideoPlay.TabIndex = 17;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.BtnVideoPlay_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 319);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.Text = "sk123456";
            // 
            // txtChannlNum
            // 
            this.txtChannlNum.Location = new System.Drawing.Point(387, 319);
            this.txtChannlNum.Name = "txtChannlNum";
            this.txtChannlNum.Size = new System.Drawing.Size(100, 21);
            this.txtChannlNum.TabIndex = 12;
            this.txtChannlNum.Text = "64";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(71, 354);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 21);
            this.txtChannel.TabIndex = 13;
            this.txtChannel.Text = "1";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(57, 319);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 14;
            this.txtUserName.Text = "admin";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(198, 287);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 15;
            this.txtPort.Text = "8000";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(57, 287);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 16;
            this.txtIP.Text = "192.168.2.186";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "设备通道数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "播放通道";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "IP";
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
            this.videoPlayWindow1.Location = new System.Drawing.Point(12, 12);
            this.videoPlayWindow1.Name = "videoPlayWindow1";
            this.videoPlayWindow1.Size = new System.Drawing.Size(511, 259);
            this.videoPlayWindow1.TabIndex = 4;
            this.videoPlayWindow1.VideoPlayState = VideoPlayControl.Enum_VideoPlayState.VideoInfoNull;
            this.videoPlayWindow1.VideoplayWindowHeight = 0;
            this.videoPlayWindow1.VideoplayWindowWidth = 0;
            this.videoPlayWindow1.VideoStream = VideoPlayControl.Enum.Enum_VideoStream.SubStream;
            // 
            // Frm_VideoPlay_SKN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 450);
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
            this.Name = "Frm_VideoPlay_SKN";
            this.Text = "Frm_VideoPlay_SKN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVideoPlay;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtChannlNum;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private VideoPlayControl.VideoPlayWindow videoPlayWindow1;
    }
}