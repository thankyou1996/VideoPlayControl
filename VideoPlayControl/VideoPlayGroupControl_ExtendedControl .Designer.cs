namespace VideoPlayControl
{
    partial class VideoPlayGroupControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabExtended = new System.Windows.Forms.TabControl();
            this.tabPTZCobtrol = new System.Windows.Forms.TabPage();
            this.pblRight_Bottom = new System.Windows.Forms.Panel();
            this.pblRight_Bottom_Main = new System.Windows.Forms.Panel();
            this.videoPTZControl = new VideoPlayControl.VideoPTZControl();
            this.pblRight_Bottom_Top = new System.Windows.Forms.Panel();
            this.cmbPreset = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabIntercom = new System.Windows.Forms.TabPage();
            this.tabSpecial = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabExtended.SuspendLayout();
            this.tabPTZCobtrol.SuspendLayout();
            this.pblRight_Bottom.SuspendLayout();
            this.pblRight_Bottom_Main.SuspendLayout();
            this.pblRight_Bottom_Top.SuspendLayout();
            this.tabSpecial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabExtended
            // 
            this.tabExtended.Controls.Add(this.tabPTZCobtrol);
            this.tabExtended.Controls.Add(this.tabIntercom);
            this.tabExtended.Controls.Add(this.tabSpecial);
            this.tabExtended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabExtended.Location = new System.Drawing.Point(0, 0);
            this.tabExtended.Name = "tabExtended";
            this.tabExtended.SelectedIndex = 0;
            this.tabExtended.Size = new System.Drawing.Size(250, 250);
            this.tabExtended.TabIndex = 0;
            // 
            // tabPTZCobtrol
            // 
            this.tabPTZCobtrol.Controls.Add(this.pblRight_Bottom);
            this.tabPTZCobtrol.Location = new System.Drawing.Point(4, 22);
            this.tabPTZCobtrol.Name = "tabPTZCobtrol";
            this.tabPTZCobtrol.Padding = new System.Windows.Forms.Padding(3);
            this.tabPTZCobtrol.Size = new System.Drawing.Size(242, 224);
            this.tabPTZCobtrol.TabIndex = 0;
            this.tabPTZCobtrol.Text = "云台控制";
            this.tabPTZCobtrol.UseVisualStyleBackColor = true;
            // 
            // pblRight_Bottom
            // 
            this.pblRight_Bottom.Controls.Add(this.pblRight_Bottom_Main);
            this.pblRight_Bottom.Controls.Add(this.pblRight_Bottom_Top);
            this.pblRight_Bottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblRight_Bottom.Location = new System.Drawing.Point(3, 3);
            this.pblRight_Bottom.Name = "pblRight_Bottom";
            this.pblRight_Bottom.Size = new System.Drawing.Size(236, 218);
            this.pblRight_Bottom.TabIndex = 7;
            // 
            // pblRight_Bottom_Main
            // 
            this.pblRight_Bottom_Main.Controls.Add(this.videoPTZControl);
            this.pblRight_Bottom_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pblRight_Bottom_Main.Location = new System.Drawing.Point(0, 23);
            this.pblRight_Bottom_Main.Name = "pblRight_Bottom_Main";
            this.pblRight_Bottom_Main.Size = new System.Drawing.Size(236, 195);
            this.pblRight_Bottom_Main.TabIndex = 7;
            // 
            // videoPTZControl
            // 
            this.videoPTZControl.BackColor = System.Drawing.Color.Transparent;
            this.videoPTZControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoPTZControl.Location = new System.Drawing.Point(0, 0);
            this.videoPTZControl.Name = "videoPTZControl";
            this.videoPTZControl.Size = new System.Drawing.Size(236, 195);
            this.videoPTZControl.TabIndex = 2;
            // 
            // pblRight_Bottom_Top
            // 
            this.pblRight_Bottom_Top.Controls.Add(this.cmbPreset);
            this.pblRight_Bottom_Top.Controls.Add(this.label1);
            this.pblRight_Bottom_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblRight_Bottom_Top.Location = new System.Drawing.Point(0, 0);
            this.pblRight_Bottom_Top.Name = "pblRight_Bottom_Top";
            this.pblRight_Bottom_Top.Size = new System.Drawing.Size(236, 23);
            this.pblRight_Bottom_Top.TabIndex = 7;
            // 
            // cmbPreset
            // 
            this.cmbPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPreset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPreset.FormattingEnabled = true;
            this.cmbPreset.Location = new System.Drawing.Point(41, 0);
            this.cmbPreset.Name = "cmbPreset";
            this.cmbPreset.Size = new System.Drawing.Size(195, 20);
            this.cmbPreset.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "预置点";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabIntercom
            // 
            this.tabIntercom.Location = new System.Drawing.Point(4, 22);
            this.tabIntercom.Name = "tabIntercom";
            this.tabIntercom.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntercom.Size = new System.Drawing.Size(242, 224);
            this.tabIntercom.TabIndex = 1;
            this.tabIntercom.Text = "对讲面板";
            this.tabIntercom.UseVisualStyleBackColor = true;
            // 
            // tabSpecial
            // 
            this.tabSpecial.Controls.Add(this.button1);
            this.tabSpecial.Location = new System.Drawing.Point(4, 22);
            this.tabSpecial.Name = "tabSpecial";
            this.tabSpecial.Size = new System.Drawing.Size(242, 224);
            this.tabSpecial.TabIndex = 2;
            this.tabSpecial.Text = "特殊设置";
            this.tabSpecial.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VideoPlayGroupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabExtended);
            this.Name = "VideoPlayGroupControl";
            this.Size = new System.Drawing.Size(250, 250);
            this.tabExtended.ResumeLayout(false);
            this.tabPTZCobtrol.ResumeLayout(false);
            this.pblRight_Bottom.ResumeLayout(false);
            this.pblRight_Bottom_Main.ResumeLayout(false);
            this.pblRight_Bottom_Top.ResumeLayout(false);
            this.tabSpecial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabExtended;
        private System.Windows.Forms.TabPage tabPTZCobtrol;
        private System.Windows.Forms.TabPage tabIntercom;
        private System.Windows.Forms.Panel pblRight_Bottom;
        private System.Windows.Forms.Panel pblRight_Bottom_Main;
        private VideoPTZControl videoPTZControl;
        private System.Windows.Forms.Panel pblRight_Bottom_Top;
        private System.Windows.Forms.ComboBox cmbPreset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabSpecial;
        private System.Windows.Forms.Button button1;
    }
}
