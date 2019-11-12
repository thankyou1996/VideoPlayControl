namespace VideoPlayControl_UseDemo.RemoteBackplay
{
    partial class Frm_RemoteBackplay
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
            this.btnRemotePlayTime_Start = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHikData = new System.Windows.Forms.Button();
            this.btnRemotePlayTime_Stop = new System.Windows.Forms.Button();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.lblChannel = new System.Windows.Forms.Label();
            this.btnZLData = new System.Windows.Forms.Button();
            this.videoRemoteBackplayWindow1 = new VideoPlayControl.VideoRemoteBackplay.VideoRemoteBackplayWindow();
            this.SuspendLayout();
            // 
            // btnRemotePlayTime_Start
            // 
            this.btnRemotePlayTime_Start.Location = new System.Drawing.Point(96, 658);
            this.btnRemotePlayTime_Start.Name = "btnRemotePlayTime_Start";
            this.btnRemotePlayTime_Start.Size = new System.Drawing.Size(89, 23);
            this.btnRemotePlayTime_Start.TabIndex = 1;
            this.btnRemotePlayTime_Start.Text = "按照时间播放";
            this.btnRemotePlayTime_Start.UseVisualStyleBackColor = true;
            this.btnRemotePlayTime_Start.Click += new System.EventHandler(this.BtnRemotePlayTime_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(96, 604);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 21);
            this.dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(96, 631);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 21);
            this.dtpEnd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 637);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结束时间";
            // 
            // btnHikData
            // 
            this.btnHikData.Location = new System.Drawing.Point(26, 531);
            this.btnHikData.Name = "btnHikData";
            this.btnHikData.Size = new System.Drawing.Size(75, 23);
            this.btnHikData.TabIndex = 5;
            this.btnHikData.Text = "海康数据";
            this.btnHikData.UseVisualStyleBackColor = true;
            this.btnHikData.Click += new System.EventHandler(this.BtnHikData_Click);
            // 
            // btnRemotePlayTime_Stop
            // 
            this.btnRemotePlayTime_Stop.Location = new System.Drawing.Point(207, 658);
            this.btnRemotePlayTime_Stop.Name = "btnRemotePlayTime_Stop";
            this.btnRemotePlayTime_Stop.Size = new System.Drawing.Size(89, 23);
            this.btnRemotePlayTime_Stop.TabIndex = 1;
            this.btnRemotePlayTime_Stop.Text = "按照时间结束";
            this.btnRemotePlayTime_Stop.UseVisualStyleBackColor = true;
            this.btnRemotePlayTime_Stop.Click += new System.EventHandler(this.BtnRemotePlayTime_Stop_Click);
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(96, 577);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(52, 21);
            this.txtChannel.TabIndex = 6;
            this.txtChannel.Text = "1";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(37, 580);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(29, 12);
            this.lblChannel.TabIndex = 7;
            this.lblChannel.Text = "通道";
            // 
            // btnZLData
            // 
            this.btnZLData.Location = new System.Drawing.Point(123, 531);
            this.btnZLData.Name = "btnZLData";
            this.btnZLData.Size = new System.Drawing.Size(75, 23);
            this.btnZLData.TabIndex = 8;
            this.btnZLData.Text = "智诺数据";
            this.btnZLData.UseVisualStyleBackColor = true;
            this.btnZLData.Click += new System.EventHandler(this.BtnZLData_Click);
            // 
            // videoRemoteBackplayWindow1
            // 
            this.videoRemoteBackplayWindow1.BackplayStatus = VideoPlayControl.VideoRemoteBackplay.Enum.VideoRemoteBackplayStatus.StandBy;
            this.videoRemoteBackplayWindow1.CurrentCameraInfo = null;
            this.videoRemoteBackplayWindow1.CurrentVideoInfo = null;
            this.videoRemoteBackplayWindow1.Location = new System.Drawing.Point(12, 12);
            this.videoRemoteBackplayWindow1.Name = "videoRemoteBackplayWindow1";
            this.videoRemoteBackplayWindow1.Size = new System.Drawing.Size(857, 513);
            this.videoRemoteBackplayWindow1.TabIndex = 4;
            // 
            // Frm_RemoteBackplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 722);
            this.Controls.Add(this.btnZLData);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.btnHikData);
            this.Controls.Add(this.videoRemoteBackplayWindow1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnRemotePlayTime_Stop);
            this.Controls.Add(this.btnRemotePlayTime_Start);
            this.Name = "Frm_RemoteBackplay";
            this.Text = "Frm_RemoteBackplay";
            this.Load += new System.EventHandler(this.Frm_RemoteBackplay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemotePlayTime_Start;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private VideoPlayControl.VideoRemoteBackplay.VideoRemoteBackplayWindow videoRemoteBackplayWindow1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHikData;
        private System.Windows.Forms.Button btnRemotePlayTime_Stop;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.Button btnZLData;
    }
}