namespace VideoPlayControl_UseDemo
{
    partial class Frm_MulitPicturte
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
            this.txtWindowNum = new System.Windows.Forms.TextBox();
            this.btnSetWinNum = new System.Windows.Forms.Button();
            this.btnSetVideoPlayInfo = new System.Windows.Forms.Button();
            this.txtPlayWindowIndex = new System.Windows.Forms.TextBox();
            this.btnCloundSeeData = new System.Windows.Forms.Button();
            this.btnEzvizData = new System.Windows.Forms.Button();
            this.btnSKData = new System.Windows.Forms.Button();
            this.btnHuaMaiData = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMulitPlay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTestDataChannel = new System.Windows.Forms.TextBox();
            this.videoPlayGroupControl_MultiPicture11 = new VideoPlayControl.VideoPlayGroupControl_MultiPicture1();
            this.pnlTop.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWindowNum
            // 
            this.txtWindowNum.Location = new System.Drawing.Point(3, 3);
            this.txtWindowNum.Name = "txtWindowNum";
            this.txtWindowNum.Size = new System.Drawing.Size(30, 21);
            this.txtWindowNum.TabIndex = 1;
            this.txtWindowNum.Text = "9";
            // 
            // btnSetWinNum
            // 
            this.btnSetWinNum.Location = new System.Drawing.Point(39, 1);
            this.btnSetWinNum.Name = "btnSetWinNum";
            this.btnSetWinNum.Size = new System.Drawing.Size(75, 23);
            this.btnSetWinNum.TabIndex = 2;
            this.btnSetWinNum.Text = "画面数量";
            this.btnSetWinNum.UseVisualStyleBackColor = true;
            this.btnSetWinNum.Click += new System.EventHandler(this.btnSetWinNum_Click);
            // 
            // btnSetVideoPlayInfo
            // 
            this.btnSetVideoPlayInfo.Location = new System.Drawing.Point(156, 1);
            this.btnSetVideoPlayInfo.Name = "btnSetVideoPlayInfo";
            this.btnSetVideoPlayInfo.Size = new System.Drawing.Size(57, 23);
            this.btnSetVideoPlayInfo.TabIndex = 3;
            this.btnSetVideoPlayInfo.Text = "播放";
            this.btnSetVideoPlayInfo.UseVisualStyleBackColor = true;
            this.btnSetVideoPlayInfo.Click += new System.EventHandler(this.btnSetVideoPlayInfo_Click);
            // 
            // txtPlayWindowIndex
            // 
            this.txtPlayWindowIndex.Location = new System.Drawing.Point(120, 3);
            this.txtPlayWindowIndex.Name = "txtPlayWindowIndex";
            this.txtPlayWindowIndex.Size = new System.Drawing.Size(30, 21);
            this.txtPlayWindowIndex.TabIndex = 1;
            this.txtPlayWindowIndex.Text = "0";
            // 
            // btnCloundSeeData
            // 
            this.btnCloundSeeData.Location = new System.Drawing.Point(8, 41);
            this.btnCloundSeeData.Name = "btnCloundSeeData";
            this.btnCloundSeeData.Size = new System.Drawing.Size(75, 23);
            this.btnCloundSeeData.TabIndex = 4;
            this.btnCloundSeeData.Text = "云视通数据";
            this.btnCloundSeeData.UseVisualStyleBackColor = true;
            this.btnCloundSeeData.Click += new System.EventHandler(this.btnCloundSeeData_Click);
            // 
            // btnEzvizData
            // 
            this.btnEzvizData.Location = new System.Drawing.Point(89, 41);
            this.btnEzvizData.Name = "btnEzvizData";
            this.btnEzvizData.Size = new System.Drawing.Size(63, 23);
            this.btnEzvizData.TabIndex = 4;
            this.btnEzvizData.Text = "萤石数据";
            this.btnEzvizData.UseVisualStyleBackColor = true;
            this.btnEzvizData.Click += new System.EventHandler(this.btnEzvizData_Click);
            // 
            // btnSKData
            // 
            this.btnSKData.Location = new System.Drawing.Point(8, 70);
            this.btnSKData.Name = "btnSKData";
            this.btnSKData.Size = new System.Drawing.Size(75, 23);
            this.btnSKData.TabIndex = 4;
            this.btnSKData.Text = "时刻数据";
            this.btnSKData.UseVisualStyleBackColor = true;
            this.btnSKData.Click += new System.EventHandler(this.btnSKData_Click);
            // 
            // btnHuaMaiData
            // 
            this.btnHuaMaiData.Location = new System.Drawing.Point(89, 70);
            this.btnHuaMaiData.Name = "btnHuaMaiData";
            this.btnHuaMaiData.Size = new System.Drawing.Size(63, 23);
            this.btnHuaMaiData.TabIndex = 4;
            this.btnHuaMaiData.Text = "华迈数据";
            this.btnHuaMaiData.UseVisualStyleBackColor = true;
            this.btnHuaMaiData.Click += new System.EventHandler(this.btnHuaMaiData_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMulitPlay);
            this.pnlTop.Controls.Add(this.groupBox1);
            this.pnlTop.Controls.Add(this.txtWindowNum);
            this.pnlTop.Controls.Add(this.txtPlayWindowIndex);
            this.pnlTop.Controls.Add(this.btnSetWinNum);
            this.pnlTop.Controls.Add(this.btnSetVideoPlayInfo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(779, 138);
            this.pnlTop.TabIndex = 5;
            // 
            // btnMulitPlay
            // 
            this.btnMulitPlay.Location = new System.Drawing.Point(12, 36);
            this.btnMulitPlay.Name = "btnMulitPlay";
            this.btnMulitPlay.Size = new System.Drawing.Size(75, 23);
            this.btnMulitPlay.TabIndex = 8;
            this.btnMulitPlay.Text = "多路播放";
            this.btnMulitPlay.UseVisualStyleBackColor = true;
            this.btnMulitPlay.Click += new System.EventHandler(this.btnMulitPlay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCloundSeeData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnEzvizData);
            this.groupBox1.Controls.Add(this.txtTestDataChannel);
            this.groupBox1.Controls.Add(this.btnSKData);
            this.groupBox1.Controls.Add(this.btnHuaMaiData);
            this.groupBox1.Location = new System.Drawing.Point(354, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 99);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "测试数据";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "通道号";
            // 
            // txtTestDataChannel
            // 
            this.txtTestDataChannel.Location = new System.Drawing.Point(53, 14);
            this.txtTestDataChannel.Name = "txtTestDataChannel";
            this.txtTestDataChannel.Size = new System.Drawing.Size(41, 21);
            this.txtTestDataChannel.TabIndex = 5;
            this.txtTestDataChannel.Text = "0";
            // 
            // videoPlayGroupControl_MultiPicture11
            // 
            this.videoPlayGroupControl_MultiPicture11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.videoPlayGroupControl_MultiPicture11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPlayGroupControl_MultiPicture11.Location = new System.Drawing.Point(0, 138);
            this.videoPlayGroupControl_MultiPicture11.Name = "videoPlayGroupControl_MultiPicture11";
            this.videoPlayGroupControl_MultiPicture11.Size = new System.Drawing.Size(779, 455);
            this.videoPlayGroupControl_MultiPicture11.TabIndex = 0;
            this.videoPlayGroupControl_MultiPicture11.Load += new System.EventHandler(this.videoPlayGroupControl_MultiPicture11_Load);
            // 
            // Frm_MulitPicturte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 593);
            this.Controls.Add(this.videoPlayGroupControl_MultiPicture11);
            this.Controls.Add(this.pnlTop);
            this.Name = "Frm_MulitPicturte";
            this.Text = "Frm_MulitPicturte";
            this.Load += new System.EventHandler(this.Frm_MulitPicturte_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControl_MultiPicture1 videoPlayGroupControl_MultiPicture11;
        private System.Windows.Forms.TextBox txtWindowNum;
        private System.Windows.Forms.Button btnSetWinNum;
        private System.Windows.Forms.Button btnSetVideoPlayInfo;
        private System.Windows.Forms.TextBox txtPlayWindowIndex;
        private System.Windows.Forms.Button btnCloundSeeData;
        private System.Windows.Forms.Button btnEzvizData;
        private System.Windows.Forms.Button btnSKData;
        private System.Windows.Forms.Button btnHuaMaiData;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTestDataChannel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMulitPlay;
    }
}