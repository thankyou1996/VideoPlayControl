namespace VideoPlayControl_RemotePlayback
{
    partial class RemoteBackplayControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.remoteBackplayProportionControl1 = new VideoPlayControl_RemotePlayback.RemoteBackplayProportionControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(249, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 79);
            this.panel1.TabIndex = 0;
            // 
            // remoteBackplayProportionControl1
            // 
            this.remoteBackplayProportionControl1.BackColor = System.Drawing.Color.Red;
            this.remoteBackplayProportionControl1.Location = new System.Drawing.Point(0, 6);
            this.remoteBackplayProportionControl1.Name = "remoteBackplayProportionControl1";
            this.remoteBackplayProportionControl1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.remoteBackplayProportionControl1.Size = new System.Drawing.Size(500, 70);
            this.remoteBackplayProportionControl1.TabIndex = 1;
            this.remoteBackplayProportionControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseDown);
            this.remoteBackplayProportionControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseMove);
            this.remoteBackplayProportionControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoteBackplayProportionControl1_MouseUp);
            // 
            // RemoteBackplayControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.remoteBackplayProportionControl1);
            this.Name = "RemoteBackplayControl";
            this.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.Size = new System.Drawing.Size(500, 84);
            this.Load += new System.EventHandler(this.RemoteBackplayControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private RemoteBackplayProportionControl remoteBackplayProportionControl1;
    }
}
