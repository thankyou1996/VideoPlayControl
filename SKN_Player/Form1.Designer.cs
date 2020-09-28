namespace SKN_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.closeBox = new System.Windows.Forms.Label();
            this.maxBox = new System.Windows.Forms.Label();
            this.miniBox = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快进ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButtom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "                   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "VSDK 播放器";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.checkBox2);
            this.panelTop.Controls.Add(this.checkBox1);
            this.panelTop.Controls.Add(this.closeBox);
            this.panelTop.Controls.Add(this.maxBox);
            this.panelTop.Controls.Add(this.miniBox);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.menuStrip1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(662, 63);
            this.panelTop.TabIndex = 4;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("宋体", 10.8F);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(272, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 19);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "硬件渲染";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("宋体", 10.8F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(180, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 19);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "硬件解码";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // closeBox
            // 
            this.closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBox.BackColor = System.Drawing.Color.Transparent;
            this.closeBox.Image = ((System.Drawing.Image)(resources.GetObject("closeBox.Image")));
            this.closeBox.Location = new System.Drawing.Point(633, 15);
            this.closeBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(29, 16);
            this.closeBox.TabIndex = 8;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // maxBox
            // 
            this.maxBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxBox.BackColor = System.Drawing.Color.Transparent;
            this.maxBox.Image = ((System.Drawing.Image)(resources.GetObject("maxBox.Image")));
            this.maxBox.Location = new System.Drawing.Point(602, 15);
            this.maxBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(29, 16);
            this.maxBox.TabIndex = 7;
            this.maxBox.Click += new System.EventHandler(this.maxBox_Click);
            // 
            // miniBox
            // 
            this.miniBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.miniBox.BackColor = System.Drawing.Color.Transparent;
            this.miniBox.Image = ((System.Drawing.Image)(resources.GetObject("miniBox.Image")));
            this.miniBox.Location = new System.Drawing.Point(571, 14);
            this.miniBox.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.miniBox.Name = "miniBox";
            this.miniBox.Size = new System.Drawing.Size(29, 16);
            this.miniBox.TabIndex = 5;
            this.miniBox.Click += new System.EventHandler(this.miniBox_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.播放ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(116, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开文件ToolStripMenuItem,
            this.关闭文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开文件ToolStripMenuItem
            // 
            this.打开文件ToolStripMenuItem.Name = "打开文件ToolStripMenuItem";
            this.打开文件ToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.打开文件ToolStripMenuItem.Text = "打开文件";
            this.打开文件ToolStripMenuItem.Click += new System.EventHandler(this.打开文件ToolStripMenuItem_Click_1);
            // 
            // 关闭文件ToolStripMenuItem
            // 
            this.关闭文件ToolStripMenuItem.Name = "关闭文件ToolStripMenuItem";
            this.关闭文件ToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.关闭文件ToolStripMenuItem.Text = "关闭文件";
            this.关闭文件ToolStripMenuItem.Click += new System.EventHandler(this.关闭文件ToolStripMenuItem_Click);
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.快进ToolStripMenuItem,
            this.播放ToolStripMenuItem1});
            this.播放ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.播放ToolStripMenuItem.Text = "播放";
            // 
            // 快进ToolStripMenuItem
            // 
            this.快进ToolStripMenuItem.Name = "快进ToolStripMenuItem";
            this.快进ToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.快进ToolStripMenuItem.Text = "快进";
            // 
            // 播放ToolStripMenuItem1
            // 
            this.播放ToolStripMenuItem1.Name = "播放ToolStripMenuItem1";
            this.播放ToolStripMenuItem1.Size = new System.Drawing.Size(112, 24);
            this.播放ToolStripMenuItem1.Text = "暂停";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 556);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.Transparent;
            this.panelButtom.Controls.Add(this.trackBar1);
            this.panelButtom.Controls.Add(this.label4);
            this.panelButtom.Controls.Add(this.label3);
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 485);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(662, 134);
            this.panelButtom.TabIndex = 6;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(662, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.track_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "0/0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(287, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 78);
            this.label3.TabIndex = 0;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 619);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "播放器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButtom.ResumeLayout(false);
            this.panelButtom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Label closeBox;
        private System.Windows.Forms.Label maxBox;
        private System.Windows.Forms.Label miniBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStripMenuItem 快进ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

