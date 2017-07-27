namespace VideoPlayControl_UseDemo
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.videoPlayMain1 = new VideoPlayControl.VideoPlayMain();
            this.btnVideoPly = new System.Windows.Forms.Button();
            this.grp_PTZControl = new System.Windows.Forms.GroupBox();
            this.cmbPresetCall = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPTZRight = new System.Windows.Forms.Button();
            this.btnPTZLeft = new System.Windows.Forms.Button();
            this.btnPTZDown = new System.Windows.Forms.Button();
            this.btnPTZUp = new System.Windows.Forms.Button();
            this.grpVideoInfo = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbVideoType = new System.Windows.Forms.ComboBox();
            this.pnlBottom.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.grp_PTZControl.SuspendLayout();
            this.grpVideoInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.grp_PTZControl);
            this.pnlBottom.Controls.Add(this.grpVideoInfo);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 264);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(727, 166);
            this.pnlBottom.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 261);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(727, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.videoPlayMain1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(727, 261);
            this.pnlMain.TabIndex = 2;
            // 
            // videoPlayMain1
            // 
            this.videoPlayMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayMain1.Location = new System.Drawing.Point(0, 0);
            this.videoPlayMain1.Name = "videoPlayMain1";
            this.videoPlayMain1.Size = new System.Drawing.Size(727, 261);
            this.videoPlayMain1.TabIndex = 0;
            // 
            // btnVideoPly
            // 
            this.btnVideoPly.Location = new System.Drawing.Point(3, 140);
            this.btnVideoPly.Name = "btnVideoPly";
            this.btnVideoPly.Size = new System.Drawing.Size(75, 23);
            this.btnVideoPly.TabIndex = 0;
            this.btnVideoPly.Text = "播放";
            this.btnVideoPly.UseVisualStyleBackColor = true;
            this.btnVideoPly.Click += new System.EventHandler(this.btnVideoPly_Click);
            // 
            // grp_PTZControl
            // 
            this.grp_PTZControl.Controls.Add(this.cmbPresetCall);
            this.grp_PTZControl.Controls.Add(this.label1);
            this.grp_PTZControl.Controls.Add(this.btnPTZRight);
            this.grp_PTZControl.Controls.Add(this.btnPTZLeft);
            this.grp_PTZControl.Controls.Add(this.btnPTZDown);
            this.grp_PTZControl.Controls.Add(this.btnPTZUp);
            this.grp_PTZControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.grp_PTZControl.Location = new System.Drawing.Point(454, 0);
            this.grp_PTZControl.Name = "grp_PTZControl";
            this.grp_PTZControl.Size = new System.Drawing.Size(161, 166);
            this.grp_PTZControl.TabIndex = 6;
            this.grp_PTZControl.TabStop = false;
            this.grp_PTZControl.Text = "云台控制";
            // 
            // cmbPresetCall
            // 
            this.cmbPresetCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPresetCall.FormattingEnabled = true;
            this.cmbPresetCall.Location = new System.Drawing.Point(61, 69);
            this.cmbPresetCall.Name = "cmbPresetCall";
            this.cmbPresetCall.Size = new System.Drawing.Size(49, 20);
            this.cmbPresetCall.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "预置点";
            // 
            // btnPTZRight
            // 
            this.btnPTZRight.Location = new System.Drawing.Point(61, 43);
            this.btnPTZRight.Name = "btnPTZRight";
            this.btnPTZRight.Size = new System.Drawing.Size(49, 23);
            this.btnPTZRight.TabIndex = 0;
            this.btnPTZRight.Text = "右";
            this.btnPTZRight.UseVisualStyleBackColor = true;
            // 
            // btnPTZLeft
            // 
            this.btnPTZLeft.Location = new System.Drawing.Point(6, 43);
            this.btnPTZLeft.Name = "btnPTZLeft";
            this.btnPTZLeft.Size = new System.Drawing.Size(49, 23);
            this.btnPTZLeft.TabIndex = 0;
            this.btnPTZLeft.Text = "左";
            this.btnPTZLeft.UseVisualStyleBackColor = true;
            // 
            // btnPTZDown
            // 
            this.btnPTZDown.Location = new System.Drawing.Point(61, 18);
            this.btnPTZDown.Name = "btnPTZDown";
            this.btnPTZDown.Size = new System.Drawing.Size(49, 23);
            this.btnPTZDown.TabIndex = 0;
            this.btnPTZDown.Text = "下";
            this.btnPTZDown.UseVisualStyleBackColor = true;
            // 
            // btnPTZUp
            // 
            this.btnPTZUp.Location = new System.Drawing.Point(6, 18);
            this.btnPTZUp.Name = "btnPTZUp";
            this.btnPTZUp.Size = new System.Drawing.Size(49, 23);
            this.btnPTZUp.TabIndex = 0;
            this.btnPTZUp.Text = "上";
            this.btnPTZUp.UseVisualStyleBackColor = true;
            // 
            // grpVideoInfo
            // 
            this.grpVideoInfo.Controls.Add(this.cmbVideoType);
            this.grpVideoInfo.Controls.Add(this.btnVideoPly);
            this.grpVideoInfo.Controls.Add(this.label5);
            this.grpVideoInfo.Controls.Add(this.label7);
            this.grpVideoInfo.Controls.Add(this.label6);
            this.grpVideoInfo.Controls.Add(this.label4);
            this.grpVideoInfo.Controls.Add(this.txtPassword);
            this.grpVideoInfo.Controls.Add(this.label2);
            this.grpVideoInfo.Controls.Add(this.textBox2);
            this.grpVideoInfo.Controls.Add(this.label3);
            this.grpVideoInfo.Controls.Add(this.textBox1);
            this.grpVideoInfo.Controls.Add(this.txtUserName);
            this.grpVideoInfo.Controls.Add(this.txtChannel);
            this.grpVideoInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpVideoInfo.Location = new System.Drawing.Point(0, 0);
            this.grpVideoInfo.Name = "grpVideoInfo";
            this.grpVideoInfo.Size = new System.Drawing.Size(454, 166);
            this.grpVideoInfo.TabIndex = 5;
            this.grpVideoInfo.TabStop = false;
            this.grpVideoInfo.Text = "主机信息";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "密    码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "用 户 名:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(71, 116);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(144, 21);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "12345";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "通道号:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(71, 91);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(144, 21);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Text = "admin";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(184, 67);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(31, 21);
            this.txtChannel.TabIndex = 1;
            this.txtChannel.Text = "01";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(54, 21);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "设备地址:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "连接端口:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "设备类型:";
            // 
            // cmbVideoType
            // 
            this.cmbVideoType.FormattingEnabled = true;
            this.cmbVideoType.Location = new System.Drawing.Point(71, 20);
            this.cmbVideoType.Name = "cmbVideoType";
            this.cmbVideoType.Size = new System.Drawing.Size(144, 20);
            this.cmbVideoType.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 430);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlBottom);
            this.Name = "FrmMain";
            this.Text = "主窗体";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Move += new System.EventHandler(this.FrmMain_Move);
            this.pnlBottom.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.grp_PTZControl.ResumeLayout(false);
            this.grp_PTZControl.PerformLayout();
            this.grpVideoInfo.ResumeLayout(false);
            this.grpVideoInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlMain;
        private VideoPlayControl.VideoPlayMain videoPlayMain1;
        private System.Windows.Forms.Button btnVideoPly;
        private System.Windows.Forms.GroupBox grp_PTZControl;
        private System.Windows.Forms.ComboBox cmbPresetCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPTZRight;
        private System.Windows.Forms.Button btnPTZLeft;
        private System.Windows.Forms.Button btnPTZDown;
        private System.Windows.Forms.Button btnPTZUp;
        private System.Windows.Forms.GroupBox grpVideoInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtChannel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbVideoType;
        private System.Windows.Forms.Label label7;
    }
}

