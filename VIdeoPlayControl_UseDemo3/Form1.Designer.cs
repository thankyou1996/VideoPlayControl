namespace VIdeoPlayControl_UseDemo3
{
    partial class Form1
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
            this.panelVideoShow = new System.Windows.Forms.Panel();
            this.textPort = new System.Windows.Forms.MaskedTextBox();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPwd = new System.Windows.Forms.TextBox();
            this.btnLogon = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboChanList = new System.Windows.Forms.ComboBox();
            this.btnConn3rd = new System.Windows.Forms.Button();
            this.btnConn2nd = new System.Windows.Forms.Button();
            this.btnDisconn = new System.Windows.Forms.Button();
            this.btnConn1st = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelVideoShow
            // 
            this.panelVideoShow.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelVideoShow.Location = new System.Drawing.Point(12, 88);
            this.panelVideoShow.Name = "panelVideoShow";
            this.panelVideoShow.Size = new System.Drawing.Size(428, 379);
            this.panelVideoShow.TabIndex = 45;
            // 
            // textPort
            // 
            this.textPort.Location = new System.Drawing.Point(262, 12);
            this.textPort.Mask = "99999";
            this.textPort.Name = "textPort";
            this.textPort.PromptChar = ' ';
            this.textPort.Size = new System.Drawing.Size(98, 21);
            this.textPort.SkipLiterals = false;
            this.textPort.TabIndex = 55;
            this.textPort.Text = "3000";
            this.textPort.ValidatingType = typeof(int);
            // 
            // textIP
            // 
            this.textIP.Location = new System.Drawing.Point(65, 12);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(99, 21);
            this.textIP.TabIndex = 54;
            this.textIP.Text = "192.168.2.171";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 53;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 52;
            this.label4.Text = "UserName:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 51;
            this.label1.Text = "ServerPort:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 50;
            this.label2.Text = "ServerIP:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(441, 12);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(99, 21);
            this.textUser.TabIndex = 48;
            this.textUser.Text = "Admin";
            // 
            // textPwd
            // 
            this.textPwd.AcceptsReturn = true;
            this.textPwd.Location = new System.Drawing.Point(638, 12);
            this.textPwd.Name = "textPwd";
            this.textPwd.PasswordChar = '*';
            this.textPwd.Size = new System.Drawing.Size(98, 21);
            this.textPwd.TabIndex = 49;
            this.textPwd.Text = "admin123456";
            // 
            // btnLogon
            // 
            this.btnLogon.Location = new System.Drawing.Point(742, 12);
            this.btnLogon.Name = "btnLogon";
            this.btnLogon.Size = new System.Drawing.Size(75, 23);
            this.btnLogon.TabIndex = 47;
            this.btnLogon.Text = "Logon";
            this.btnLogon.UseVisualStyleBackColor = true;
            this.btnLogon.Click += new System.EventHandler(this.btnLogon_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "ChannelNo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cboChanList
            // 
            this.cboChanList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChanList.FormattingEnabled = true;
            this.cboChanList.Location = new System.Drawing.Point(383, 59);
            this.cboChanList.Name = "cboChanList";
            this.cboChanList.Size = new System.Drawing.Size(58, 20);
            this.cboChanList.TabIndex = 58;
            // 
            // btnConn3rd
            // 
            this.btnConn3rd.Location = new System.Drawing.Point(158, 59);
            this.btnConn3rd.Name = "btnConn3rd";
            this.btnConn3rd.Size = new System.Drawing.Size(75, 23);
            this.btnConn3rd.TabIndex = 61;
            this.btnConn3rd.Text = "3rd Stream";
            this.btnConn3rd.UseVisualStyleBackColor = true;
            // 
            // btnConn2nd
            // 
            this.btnConn2nd.Location = new System.Drawing.Point(84, 59);
            this.btnConn2nd.Name = "btnConn2nd";
            this.btnConn2nd.Size = new System.Drawing.Size(75, 23);
            this.btnConn2nd.TabIndex = 60;
            this.btnConn2nd.Text = "2nd Stream";
            this.btnConn2nd.UseVisualStyleBackColor = true;
            this.btnConn2nd.Click += new System.EventHandler(this.btnConn2nd_Click);
            // 
            // btnDisconn
            // 
            this.btnDisconn.Location = new System.Drawing.Point(236, 59);
            this.btnDisconn.Name = "btnDisconn";
            this.btnDisconn.Size = new System.Drawing.Size(75, 23);
            this.btnDisconn.TabIndex = 57;
            this.btnDisconn.Text = "Disconnect";
            this.btnDisconn.UseVisualStyleBackColor = true;
            // 
            // btnConn1st
            // 
            this.btnConn1st.Location = new System.Drawing.Point(12, 59);
            this.btnConn1st.Name = "btnConn1st";
            this.btnConn1st.Size = new System.Drawing.Size(73, 23);
            this.btnConn1st.TabIndex = 56;
            this.btnConn1st.Text = "1st Stream";
            this.btnConn1st.UseVisualStyleBackColor = true;
            this.btnConn1st.Click += new System.EventHandler(this.btnConn1st_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboChanList);
            this.Controls.Add(this.btnConn3rd);
            this.Controls.Add(this.btnConn2nd);
            this.Controls.Add(this.btnDisconn);
            this.Controls.Add(this.btnConn1st);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.textPwd);
            this.Controls.Add(this.btnLogon);
            this.Controls.Add(this.panelVideoShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelVideoShow;
        private System.Windows.Forms.MaskedTextBox textPort;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPwd;
        private System.Windows.Forms.Button btnLogon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboChanList;
        private System.Windows.Forms.Button btnConn3rd;
        private System.Windows.Forms.Button btnConn2nd;
        private System.Windows.Forms.Button btnDisconn;
        private System.Windows.Forms.Button btnConn1st;
    }
}

