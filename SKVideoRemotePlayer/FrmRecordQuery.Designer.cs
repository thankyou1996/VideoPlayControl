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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTalkRecord = new System.Windows.Forms.DataGridView();
            this.dgvTalkRecord_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_HostID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_HostName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_RequestType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_RequestTypeDescibe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_FileLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_FileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_FileType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTalkRecord_Downloaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlOperat = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
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
            this.dgvTalkRecord_ID,
            this.dgvTalkRecord_HostID,
            this.dgvTalkRecord_HostName,
            this.dgvTalkRecord_StartTime,
            this.dgvTalkRecord_RequestType,
            this.dgvTalkRecord_RequestTypeDescibe,
            this.dgvTalkRecord_FileLength,
            this.dgvTalkRecord_FileName,
            this.dgvTalkRecord_FileType,
            this.dgvTalkRecord_Downloaded});
            this.dgvTalkRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTalkRecord.Location = new System.Drawing.Point(0, 121);
            this.dgvTalkRecord.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTalkRecord.Name = "dgvTalkRecord";
            this.dgvTalkRecord.ReadOnly = true;
            this.dgvTalkRecord.RowHeadersVisible = false;
            this.dgvTalkRecord.RowHeadersWidth = 50;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvTalkRecord.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTalkRecord.RowTemplate.Height = 35;
            this.dgvTalkRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTalkRecord.Size = new System.Drawing.Size(857, 404);
            this.dgvTalkRecord.TabIndex = 27;
            // 
            // dgvTalkRecord_ID
            // 
            this.dgvTalkRecord_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_ID.DataPropertyName = "ID";
            this.dgvTalkRecord_ID.HeaderText = "ID";
            this.dgvTalkRecord_ID.Name = "dgvTalkRecord_ID";
            this.dgvTalkRecord_ID.ReadOnly = true;
            this.dgvTalkRecord_ID.Width = 49;
            // 
            // dgvTalkRecord_HostID
            // 
            this.dgvTalkRecord_HostID.DataPropertyName = "HostID";
            this.dgvTalkRecord_HostID.HeaderText = "主机编号";
            this.dgvTalkRecord_HostID.Name = "dgvTalkRecord_HostID";
            this.dgvTalkRecord_HostID.ReadOnly = true;
            // 
            // dgvTalkRecord_HostName
            // 
            this.dgvTalkRecord_HostName.DataPropertyName = "HostName";
            this.dgvTalkRecord_HostName.HeaderText = "主机名称";
            this.dgvTalkRecord_HostName.Name = "dgvTalkRecord_HostName";
            this.dgvTalkRecord_HostName.ReadOnly = true;
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
            // dgvTalkRecord_RequestType
            // 
            this.dgvTalkRecord_RequestType.DataPropertyName = "RequestType";
            this.dgvTalkRecord_RequestType.HeaderText = "请求类型";
            this.dgvTalkRecord_RequestType.Name = "dgvTalkRecord_RequestType";
            this.dgvTalkRecord_RequestType.ReadOnly = true;
            this.dgvTalkRecord_RequestType.Visible = false;
            // 
            // dgvTalkRecord_RequestTypeDescibe
            // 
            this.dgvTalkRecord_RequestTypeDescibe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvTalkRecord_RequestTypeDescibe.DataPropertyName = "RequestTypeDescibe";
            this.dgvTalkRecord_RequestTypeDescibe.HeaderText = "请求类型";
            this.dgvTalkRecord_RequestTypeDescibe.Name = "dgvTalkRecord_RequestTypeDescibe";
            this.dgvTalkRecord_RequestTypeDescibe.ReadOnly = true;
            this.dgvTalkRecord_RequestTypeDescibe.Width = 97;
            // 
            // dgvTalkRecord_FileLength
            // 
            this.dgvTalkRecord_FileLength.DataPropertyName = "FileLength";
            this.dgvTalkRecord_FileLength.HeaderText = "文件大小";
            this.dgvTalkRecord_FileLength.Name = "dgvTalkRecord_FileLength";
            this.dgvTalkRecord_FileLength.ReadOnly = true;
            // 
            // dgvTalkRecord_FileName
            // 
            this.dgvTalkRecord_FileName.DataPropertyName = "FileName";
            this.dgvTalkRecord_FileName.HeaderText = "文件名称";
            this.dgvTalkRecord_FileName.Name = "dgvTalkRecord_FileName";
            this.dgvTalkRecord_FileName.ReadOnly = true;
            // 
            // dgvTalkRecord_FileType
            // 
            this.dgvTalkRecord_FileType.DataPropertyName = "FileType";
            this.dgvTalkRecord_FileType.HeaderText = "文件类型";
            this.dgvTalkRecord_FileType.Name = "dgvTalkRecord_FileType";
            this.dgvTalkRecord_FileType.ReadOnly = true;
            // 
            // dgvTalkRecord_Downloaded
            // 
            this.dgvTalkRecord_Downloaded.DataPropertyName = "Downloaded";
            this.dgvTalkRecord_Downloaded.HeaderText = "状态";
            this.dgvTalkRecord_Downloaded.Name = "dgvTalkRecord_Downloaded";
            this.dgvTalkRecord_Downloaded.ReadOnly = true;
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
            this.pnlOperat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlOperat.Name = "pnlOperat";
            this.pnlOperat.Size = new System.Drawing.Size(857, 121);
            this.pnlOperat.TabIndex = 28;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 22);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker1.TabIndex = 1;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(95, 62);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(255, 26);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Location = new System.Drawing.Point(370, 24);
            this.cmbChannel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(179, 24);
            this.cmbChannel.TabIndex = 2;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(370, 60);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 31);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // FrmRecordQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(857, 525);
            this.Controls.Add(this.dgvTalkRecord);
            this.Controls.Add(this.pnlOperat);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmRecordQuery";
            this.Text = "录像文件查询下载";
            this.Load += new System.EventHandler(this.FrmRecordQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalkRecord)).EndInit();
            this.pnlOperat.ResumeLayout(false);
            this.pnlOperat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTalkRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_HostID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_HostName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_RequestType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_RequestTypeDescibe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_FileLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_FileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_FileType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTalkRecord_Downloaded;
        private System.Windows.Forms.Panel pnlOperat;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cmbChannel;
    }
}