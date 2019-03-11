namespace VideoPlayControl_UseDemo
{
    partial class Frm_VideoTalkControlManyChannel_Test
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
            VideoPlayControl.VideoBasicClass.TalkSetting talkSetting2 = new VideoPlayControl.VideoBasicClass.TalkSetting();
            this.videoTalkControlManyChannel1 = new VideoPlayControl.VideoTalkControlManyChannel();
            this.SuspendLayout();
            // 
            // videoTalkControlManyChannel1
            // 
            this.videoTalkControlManyChannel1.CurrentTalkChannel = null;
            talkSetting2.TalkRecordEnable = false;
            talkSetting2.TalkRecordName_Local = "";
            talkSetting2.TalkRecordName_Server = "";
            talkSetting2.TalkRecordPath_Local = "";
            talkSetting2.TalkRecordPath_Server = "";
            talkSetting2.TalkRecordRealSavePath_Local = "";
            this.videoTalkControlManyChannel1.CurrentTalkSetting = talkSetting2;
            this.videoTalkControlManyChannel1.CurrentTalkStatus = VideoPlayControl.VideoBasicClass.Enum_TalkStatus.Null;
            this.videoTalkControlManyChannel1.CurrentVideoInfo = null;
            this.videoTalkControlManyChannel1.Location = new System.Drawing.Point(137, 121);
            this.videoTalkControlManyChannel1.Name = "videoTalkControlManyChannel1";
            this.videoTalkControlManyChannel1.Size = new System.Drawing.Size(85, 93);
            this.videoTalkControlManyChannel1.TabIndex = 0;
            this.videoTalkControlManyChannel1.StartTalkingEvent += new VideoPlayControl.StartTalkingDelegate(this.videoTalkControlManyChannel1_StartTalkingEvent);
            this.videoTalkControlManyChannel1.StopTalkedEvent += new VideoPlayControl.StopTalkedDelegate(this.videoTalkControlManyChannel1_StopTalkedEvent);
            // 
            // Frm_VideoTalkControlManyChannel_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.videoTalkControlManyChannel1);
            this.Name = "Frm_VideoTalkControlManyChannel_Test";
            this.Text = "Frm_VideoTalkControlManyChannel_Test";
            this.Load += new System.EventHandler(this.Frm_VideoTalkControlManyChannel_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private VideoPlayControl.VideoTalkControlManyChannel videoTalkControlManyChannel1;
    }
}