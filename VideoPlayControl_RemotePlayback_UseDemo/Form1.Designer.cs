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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.remoteBackplayControl1 = new VideoPlayControl_RemotePlayback.RemoteBackplayControl();
            this.remoteBackplayInfoControl1 = new VideoPlayControl_RemotePlayback.RemoteBackplayProportionControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 265);
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
            this.pictureBox1.Size = new System.Drawing.Size(119, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // remoteBackplayControl1
            // 
            this.remoteBackplayControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.remoteBackplayControl1.CurrentPositionDateTime = new System.DateTime(((long)(0)));
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
            this.remoteBackplayInfoControl1.Location = new System.Drawing.Point(55, 33);
            this.remoteBackplayInfoControl1.Name = "remoteBackplayInfoControl1";
            this.remoteBackplayInfoControl1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.remoteBackplayInfoControl1.Size = new System.Drawing.Size(661, 52);
            this.remoteBackplayInfoControl1.TabIndex = 0;
            this.remoteBackplayInfoControl1.Click += new System.EventHandler(this.RemoteBackplayInfoControl1_Click);
            this.remoteBackplayInfoControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayInfoControl1_MouseClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(259, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 60);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(298, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 35);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(337, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 35);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(376, 218);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 35);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(415, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 35);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(454, 205);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 60);
            this.panel6.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.remoteBackplayControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remoteBackplayInfoControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl_RemotePlayback.RemoteBackplayProportionControl remoteBackplayInfoControl1;
        private System.Windows.Forms.Button button1;
        private VideoPlayControl_RemotePlayback.RemoteBackplayControl remoteBackplayControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

