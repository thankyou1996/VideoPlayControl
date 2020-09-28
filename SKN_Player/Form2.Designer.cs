namespace DownloadVideo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnfind = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colguid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clotype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldownload = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnpath = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.remoteBackplayControl1 = new VideoPlayControl_RemotePlayback.RemotePlaybackControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.Font = new System.Drawing.Font("宋体", 11F);
            this.btnlogin.Location = new System.Drawing.Point(407, 45);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 23);
            this.btnlogin.TabIndex = 0;
            this.btnlogin.Text = "登录";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("宋体", 11F);
            this.txtIP.Location = new System.Drawing.Point(82, 10);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(191, 24);
            this.txtIP.TabIndex = 1;
            this.txtIP.Text = "192.168.2.216";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 11F);
            this.txtname.Location = new System.Drawing.Point(339, 10);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 24);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "admin";
            // 
            // txtpw
            // 
            this.txtpw.Font = new System.Drawing.Font("宋体", 11F);
            this.txtpw.Location = new System.Drawing.Point(488, 8);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(100, 24);
            this.txtpw.TabIndex = 3;
            this.txtpw.Text = "sk123456";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F);
            this.label2.Location = new System.Drawing.Point(286, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "用户名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F);
            this.label3.Location = new System.Drawing.Point(449, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "密码";
            // 
            // cmbChannel
            // 
            this.cmbChannel.Font = new System.Drawing.Font("宋体", 11F);
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(292, 46);
            this.cmbChannel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(100, 23);
            this.cmbChannel.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("宋体", 11F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(82, 82);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(191, 24);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("宋体", 9F);
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 11F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(82, 46);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 24);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2019, 8, 1, 17, 35, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "结束时间";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 11F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "起始时间";
            // 
            // btnfind
            // 
            this.btnfind.Font = new System.Drawing.Font("宋体", 11F);
            this.btnfind.Location = new System.Drawing.Point(292, 80);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(100, 23);
            this.btnfind.TabIndex = 13;
            this.btnfind.Text = "查询";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnum,
            this.colguid,
            this.colname,
            this.clotype,
            this.colda,
            this.coldownload});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(1, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(725, 353);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellValueChanged);
            // 
            // colnum
            // 
            this.colnum.HeaderText = "序号";
            this.colnum.Name = "colnum";
            this.colnum.ReadOnly = true;
            this.colnum.Width = 54;
            // 
            // colguid
            // 
            this.colguid.HeaderText = "序列号";
            this.colguid.Name = "colguid";
            this.colguid.ReadOnly = true;
            this.colguid.Width = 66;
            // 
            // colname
            // 
            this.colname.HeaderText = "文件名";
            this.colname.Name = "colname";
            this.colname.ReadOnly = true;
            this.colname.Width = 66;
            // 
            // clotype
            // 
            this.clotype.HeaderText = "类型";
            this.clotype.Name = "clotype";
            this.clotype.ReadOnly = true;
            this.clotype.Width = 54;
            // 
            // colda
            // 
            this.colda.HeaderText = "文件大小";
            this.colda.Name = "colda";
            this.colda.ReadOnly = true;
            this.colda.Width = 78;
            // 
            // coldownload
            // 
            this.coldownload.HeaderText = "下载状态";
            this.coldownload.Name = "coldownload";
            this.coldownload.ReadOnly = true;
            this.coldownload.Width = 78;
            // 
            // btnpath
            // 
            this.btnpath.Font = new System.Drawing.Font("宋体", 11F);
            this.btnpath.Location = new System.Drawing.Point(407, 81);
            this.btnpath.Name = "btnpath";
            this.btnpath.Size = new System.Drawing.Size(100, 23);
            this.btnpath.TabIndex = 15;
            this.btnpath.Text = "保存路径";
            this.btnpath.UseVisualStyleBackColor = true;
            this.btnpath.Click += new System.EventHandler(this.Button1_Click_2);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(570, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_3);
            // 
            // remoteBackplayControl1
            // 
            this.remoteBackplayControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.remoteBackplayControl1.CurrentPositionDateTime = new System.DateTime(((long)(0)));
            this.remoteBackplayControl1.CurrentRemotePlaybackInfo = null;
            this.remoteBackplayControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.remoteBackplayControl1.Location = new System.Drawing.Point(0, 0);
            this.remoteBackplayControl1.Name = "remoteBackplayControl1";
            this.remoteBackplayControl1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.remoteBackplayControl1.Size = new System.Drawing.Size(729, 14);
            this.remoteBackplayControl1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 472);
            this.Controls.Add(this.remoteBackplayControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnpath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.cmbChannel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.btnlogin);
            this.Name = "Form1";
            this.Text = "录像文件下载工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtpw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colguid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clotype;
        private System.Windows.Forms.DataGridViewTextBoxColumn colda;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldownload;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnpath;
        private System.Windows.Forms.Button button1;
        private VideoPlayControl_RemotePlayback.RemotePlaybackControl remoteBackplayControl1;
    }
}

