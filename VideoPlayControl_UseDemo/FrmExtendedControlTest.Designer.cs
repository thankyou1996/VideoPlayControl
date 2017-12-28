namespace VideoPlayControl_UseDemo
{
    partial class FrmExtendedControlTest
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
            this.videoPlayGroupControl_ExtendedControl1 = new VideoPlayControl.VideoPlayGroupControl_ExtendedControl();
            this.SuspendLayout();
            // 
            // videoPlayGroupControl_ExtendedControl1
            // 
            this.videoPlayGroupControl_ExtendedControl1.Location = new System.Drawing.Point(89, 143);
            this.videoPlayGroupControl_ExtendedControl1.Name = "videoPlayGroupControl_ExtendedControl1";
            this.videoPlayGroupControl_ExtendedControl1.Size = new System.Drawing.Size(206, 140);
            this.videoPlayGroupControl_ExtendedControl1.TabIndex = 0;
            // 
            // FrmExtendedControlTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 342);
            this.Controls.Add(this.videoPlayGroupControl_ExtendedControl1);
            this.Name = "FrmExtendedControlTest";
            this.Text = "FrmExtendedControlTest";
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoPlayGroupControl_ExtendedControl videoPlayGroupControl_ExtendedControl1;
    }
}