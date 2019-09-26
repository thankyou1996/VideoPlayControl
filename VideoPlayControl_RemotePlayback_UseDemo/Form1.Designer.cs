namespace VideoPlayControl_RemotePlayback_UseDemo
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.remoteBackplayControl1 = new VideoPlayControl_RemotePlayback.RemotePlaybackControl();
            this.remoteBackplayInfoControl1 = new VideoPlayControl_RemotePlayback.RemotePlaybackProportionControl();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.channelRemoteBackplayInfo1 = new VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(55, 190);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 124);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(1, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 60);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(40, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 35);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(79, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 35);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(118, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 35);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(157, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 35);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(196, 22);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 60);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(483, 218);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(245, 88);
            this.panel7.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "08-09 21:02:01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-42, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "08-09 21:02:01";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Green;
            this.pictureBox2.Location = new System.Drawing.Point(200, 345);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(506, 47);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(382, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.Location = new System.Drawing.Point(448, 355);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 23);
            this.panel9.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 384);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.Value = new System.DateTime(2019, 8, 12, 11, 35, 0, 0);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(12, 475);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker2.TabIndex = 13;
            this.dateTimePicker2.Value = new System.DateTime(2019, 8, 12, 11, 35, 0, 0);
            // 
            // remoteBackplayControl1
            // 
            this.remoteBackplayControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.remoteBackplayControl1.CurrentPositionDateTime = new System.DateTime(((long)(0)));
            this.remoteBackplayControl1.CurrentRemotePlaybackInfo = null;
            this.remoteBackplayControl1.Location = new System.Drawing.Point(55, 91);
            this.remoteBackplayControl1.Name = "remoteBackplayControl1";
            this.remoteBackplayControl1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.remoteBackplayControl1.Size = new System.Drawing.Size(661, 93);
            this.remoteBackplayControl1.TabIndex = 2;
            this.remoteBackplayControl1.Click += new System.EventHandler(this.RemoteBackplayControl1_Click);
            // 
            // remoteBackplayInfoControl1
            // 
            this.remoteBackplayInfoControl1.BackColor = System.Drawing.Color.Red;
            this.remoteBackplayInfoControl1.CurrentRemotePlaybackInfo = null;
            this.remoteBackplayInfoControl1.Location = new System.Drawing.Point(55, 33);
            this.remoteBackplayInfoControl1.MainColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.remoteBackplayInfoControl1.Name = "remoteBackplayInfoControl1";
            this.remoteBackplayInfoControl1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.remoteBackplayInfoControl1.Size = new System.Drawing.Size(661, 52);
            this.remoteBackplayInfoControl1.TabIndex = 0;
            this.remoteBackplayInfoControl1.Click += new System.EventHandler(this.RemoteBackplayInfoControl1_Click);
            this.remoteBackplayInfoControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayInfoControl1_MouseClick);
            // 
            // channelRemoteBackplayInfo1
            // 
            this.channelRemoteBackplayInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.channelRemoteBackplayInfo1.Location = new System.Drawing.Point(191, 398);
            this.channelRemoteBackplayInfo1.Name = "channelRemoteBackplayInfo1";
            this.channelRemoteBackplayInfo1.Size = new System.Drawing.Size(578, 26);
            this.channelRemoteBackplayInfo1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.channelRemoteBackplayInfo1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.remoteBackplayControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remoteBackplayInfoControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VideoPlayControl_RemotePlayback.RemotePlaybackProportionControl remoteBackplayInfoControl1;
        private System.Windows.Forms.Button button1;
        private VideoPlayControl_RemotePlayback.RemotePlaybackControl remoteBackplayControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ToolTip toolTip1;
        private VideoPlayControl_RemotePlayback.ChannelRemotePlaybackInfo channelRemoteBackplayInfo1;
    }
}

