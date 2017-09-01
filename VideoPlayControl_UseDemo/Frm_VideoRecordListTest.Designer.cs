namespace VideoPlayControl_UseDemo
{
    partial class Frm_VideoRecordListTest
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
            this.videoRecordList1 = new VideoPlayControl.VideoRecordList();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // videoRecordList1
            // 
            this.videoRecordList1.AutoScroll = true;
            this.videoRecordList1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.videoRecordList1.Dock = System.Windows.Forms.DockStyle.Top;
            this.videoRecordList1.Location = new System.Drawing.Point(0, 0);
            this.videoRecordList1.Name = "videoRecordList1";
            this.videoRecordList1.Size = new System.Drawing.Size(374, 232);
            this.videoRecordList1.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(0, 233);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "加载";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Frm_VideoRecordListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 259);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.videoRecordList1);
            this.Name = "Frm_VideoRecordListTest";
            this.Text = "视频回放记录控件测试";
            this.ResumeLayout(false);

        }

        #endregion
        private VideoPlayControl.VideoRecordList videoRecordList1;
        private System.Windows.Forms.Button btnLoad;
    }
}