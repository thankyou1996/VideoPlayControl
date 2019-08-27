namespace SKVideoRemotePlayer
{
    partial class FrmRecordQuery
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTalkRecord = new System.Windows.Forms.DataGridView();
            this.dgvTalkRecord_HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_FileLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_Timelength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_Writeok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_download = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOperat = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalkRecord)).BeginInit();
            this.pnlOperat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTalkRecord
            // 
            this.dgvTalkRecord.AllowUserToAddRows = false;
            this.dgvTalkRecord.AllowUserToDeleteRows = false;
            this.dgvTalkRecord.AllowUserToResizeRows = false;
            this.dgvTalkRecord.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTalkRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalkRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTalkRecord_HostName,
            this.dgvTalkRecord_StartTime,
            this.dgvTalkRecord_EndTime,
            this.dgvTalkRecord_FileLength,
            this.dgvTalkRecord_Timelength,
            this.dgvTalkRecord_Writeok,
            this.dgvTalkRecord_download});
            this.dgvTalkRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTalkRecord.Location = new System.Drawing.Point(0, 121);
            this.dgvTalkRecord.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTalkRecord.MultiSelect = false;
            this.dgvTalkRecord.Name = "dgvTalkRecord";
            this.dgvTalkRecord.ReadOnly = true;
            this.dgvTalkRecord.RowHeadersVisible = false;
            this.dgvTalkRecord.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvTalkRecord.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTalkRecord.RowTemplate.Height = 35;
            this.dgvTalkRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTalkRecord.Size = new System.Drawing.Size(1071, 404);
            this.dgvTalkRecord.TabIndex = 27;
            this.dgvTalkRecord.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTalkRecord_CellDoubleClick);
            this.dgvTalkRecord.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvTalkRecord_CellPainting_1);
            // 
            // dgvTalkRecord_HostName
            // 
            this.dgvTalkRecord_HostName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_HostName.DataPropertyName = "HostName";
            this.dgvTalkRecord_HostName.HeaderText = "文件名称";
            this.dgvTalkRecord_HostName.Name = "dgvTalkRecord_HostName";
            this.dgvTalkRecord_HostName.ReadOnly = true;
            this.dgvTalkRecord_HostName.Width = 97;
            // 
            // dgvTalkRecord_StartTime
            // 
            this.dgvTalkRecord_StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_StartTime.DataPropertyName = "StartTime";
            dataGridViewCellStyle1.Format = "F";
            dataGridViewCellStyle1.NullValue = null;
            this.dgvTalkRecord_StartTime.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTalkRecord_StartTime.HeaderText = "起始时间";
            this.dgvTalkRecord_StartTime.Name = "dgvTalkRecord_StartTime";
            this.dgvTalkRecord_StartTime.ReadOnly = true;
            this.dgvTalkRecord_StartTime.Width = 97;
            // 
            // dgvTalkRecord_EndTime
            // 
            this.dgvTalkRecord_EndTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_EndTime.DataPropertyName = "EndTime";
            dataGridViewCellStyle2.Format = "F";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvTalkRecord_EndTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTalkRecord_EndTime.HeaderText = "结束时间";
            this.dgvTalkRecord_EndTime.Name = "dgvTalkRecord_EndTime";
            this.dgvTalkRecord_EndTime.ReadOnly = true;
            this.dgvTalkRecord_EndTime.Width = 97;
            // 
            // dgvTalkRecord_FileLength
            // 
            this.dgvTalkRecord_FileLength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_FileLength.DataPropertyName = "FileLength";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvTalkRecord_FileLength.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTalkRecord_FileLength.HeaderText = "文件大小";
            this.dgvTalkRecord_FileLength.Name = "dgvTalkRecord_FileLength";
            this.dgvTalkRecord_FileLength.ReadOnly = true;
            this.dgvTalkRecord_FileLength.Width = 97;
            // 
            // dgvTalkRecord_Timelength
            // 
            this.dgvTalkRecord_Timelength.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_Timelength.DataPropertyName = "Timelength";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvTalkRecord_Timelength.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTalkRecord_Timelength.HeaderText = "时间长度";
            this.dgvTalkRecord_Timelength.Name = "dgvTalkRecord_Timelength";
            this.dgvTalkRecord_Timelength.ReadOnly = true;
            this.dgvTalkRecord_Timelength.Width = 97;
            // 
            // dgvTalkRecord_Writeok
            // 
            this.dgvTalkRecord_Writeok.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_Writeok.DataPropertyName = "Writeok";
            this.dgvTalkRecord_Writeok.HeaderText = "写入状态";
            this.dgvTalkRecord_Writeok.Name = "dgvTalkRecord_Writeok";
            this.dgvTalkRecord_Writeok.ReadOnly = true;
            this.dgvTalkRecord_Writeok.Width = 97;
            // 
            // dgvTalkRecord_download
            // 
            this.dgvTalkRecord_download.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_download.DataPropertyName = "download";
            this.dgvTalkRecord_download.HeaderText = "下载状态";
            this.dgvTalkRecord_download.Name = "dgvTalkRecord_download";
            this.dgvTalkRecord_download.ReadOnly = true;
            this.dgvTalkRecord_download.Width = 97;
            // 
            // pnlOperat
            // 
            this.pnlOperat.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOperat.Controls.Add(this.btnQuery);
            this.pnlOperat.Controls.Add(this.cmbChannel);
            this.pnlOperat.Controls.Add(this.dateTimePicker2);
            this.pnlOperat.Controls.Add(this.dateTimePicker1);
            this.pnlOperat.Controls.Add(this.label2);
            this.pnlOperat.Controls.Add(this.label1);
            this.pnlOperat.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperat.Location = new System.Drawing.Point(0, 0);
            this.pnlOperat.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOperat.Name = "pnlOperat";
            this.pnlOperat.Size = new System.Drawing.Size(1071, 121);
            this.pnlOperat.TabIndex = 28;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(370, 60);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 31);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(370, 24);
            this.cmbChannel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(179, 24);
            this.cmbChannel.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(95, 62);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 8, 1, 17, 35, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "结束时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始时间";
            // 
            // toolTip1
            // 
            this.toolTip1.ShowAlways = true;
            // 
            // FrmRecordQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1071, 525);
            this.Controls.Add(this.dgvTalkRecord);
            this.Controls.Add(this.pnlOperat);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmRecordQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "录像文件查询下载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRecordQuery_FormClosing);
            this.Load += new System.EventHandler(this.FrmRecordQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalkRecord)).EndInit();
            this.pnlOperat.ResumeLayout(false);
            this.pnlOperat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTalkRecord;
        private System.Windows.Forms.Panel pnlOperat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_FileLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_Timelength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_Writeok;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_download;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}