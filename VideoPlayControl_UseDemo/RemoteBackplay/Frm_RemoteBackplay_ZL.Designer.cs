namespace VideoPlayControl_UseDemo.RemoteBackplay
{
    partial class Frm_RemoteBackplay_ZL
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
            this.btnRemotePlayTime_Stop = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.videoRemoteBackplayWindow1 = new VideoPlayControl.VideoRemoteBackplay.VideoRemoteBackplayWindow();
            this.SuspendLayout();
            // 
            // btnVideoPlay
            // 
            this.btnVideoPlay.Location = new System.Drawing.Point(12, 480);
            this.btnVideoPlay.Name = "btnVideoPlay";
            this.btnVideoPlay.Size = new System.Drawing.Size(75, 23);
            this.btnVideoPlay.TabIndex = 16;
            this.btnVideoPlay.Text = "播放";
            this.btnVideoPlay.UseVisualStyleBackColor = true;
            this.btnVideoPlay.Click += new System.EventHandler(this.BtnVideoPlay_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(199, 368);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 21);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.Text = "123456";
            // 
            // txtChannlNum
            // 
            this.txtChannlNum.Location = new System.Drawing.Point(388, 368);
            this.txtChannlNum.Name = "txtChannlNum";
            this.txtChannlNum.Size = new System.Drawing.Size(100, 21);
            this.txtChannlNum.TabIndex = 11;
            this.txtChannlNum.Text = "64";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(72, 403);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(100, 21);
            this.txtChannel.TabIndex = 12;
            this.txtChannel.Text = "1";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(58, 368);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(100, 21);
            this.txtUserName.TabIndex = 13;
            this.txtUserName.Text = "admin";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(199, 336);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 21);
            this.txtPort.TabIndex = 14;
            this.txtPort.Text = "8000";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(58, 336);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 15;
            this.txtIP.Text = "192.168.2.187";
            this.txtIP.TextChanged += new System.EventHandler(this.TxtIP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(164, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "密码";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "设备通道数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "播放通道";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "端口";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "IP";
            // 
            // btnRemotePlayTime_Stop
            // 
            this.btnRemotePlayTime_Stop.Location = new System.Drawing.Point(103, 480);
            this.btnRemotePlayTime_Stop.Name = "btnRemotePlayTime_Stop";
            this.btnRemotePlayTime_Stop.Size = new System.Drawing.Size(89, 23);
            this.btnRemotePlayTime_Stop.TabIndex = 17;
            this.btnRemotePlayTime_Stop.Text = "按照时间结束";
            this.btnRemotePlayTime_Stop.UseVisualStyleBackColor = true;
            this.btnRemotePlayTime_Stop.Click += new System.EventHandler(this.BtnRemotePlayTime_Stop_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "结束时间";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 21;
            this.label8.Text = "开始时间";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(72, 453);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 21);
            this.dtpEnd.TabIndex = 18;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(72, 426);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 21);
            this.dtpStart.TabIndex = 19;
            // 
            // videoRemoteBackplayWindow1
            // 
            this.videoRemoteBackplayWindow1.BackplayStatus = VideoPlayControl.VideoRemoteBackplay.Enum.VideoRemoteBackplayStatus.StandBy;
            this.videoRemoteBackplayWindow1.CurrentCameraInfo = null;
            this.videoRemoteBackplayWindow1.CurrentVideoInfo = null;
            this.videoRemoteBackplayWindow1.Location = new System.Drawing.Point(12, 12);
            this.videoRemoteBackplayWindow1.Name = "videoRemoteBackplayWindow1";
            this.videoRemoteBackplayWindow1.Size = new System.Drawing.Size(585, 318);
            this.videoRemoteBackplayWindow1.TabIndex = 0;
            // 
            // Frm_RemoteBackplay_ZL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnRemotePlayTime_Stop);
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
            this.Controls.Add(this.videoRemoteBackplayWindow1);
            this.Name = "Frm_RemoteBackplay_ZL";
            this.Text = "Frm_RemoteBackplay_ZL";
            this.Load += new System.EventHandler(this.Frm_RemoteBackplay_ZL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoPlayControl.VideoRemoteBackplay.VideoRemoteBackplayWindow videoRemoteBackplayWindow1;
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
        private System.Windows.Forms.Button btnRemotePlayTime_Stop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
    }
}