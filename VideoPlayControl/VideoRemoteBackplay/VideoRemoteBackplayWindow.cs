using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.VideoRemoteBackplay.Enum;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public partial class VideoRemoteBackplayWindow : UserControl,IVIdeoRemoteBackplay
    {
        IVIdeoRemoteBackplay iVideoRemoteBackplay = new VideoRemoteBackplay_Default();
        public VideoRemoteBackplayWindow()
        {
            InitializeComponent();
        }

        public VideoRemoteBackplayStatus BackplayStatus { get => iVideoRemoteBackplay.BackplayStatus; set => iVideoRemoteBackplay.BackplayStatus = value; }
        public PictureBox PicPlayMain { get => this.picPlayMain; set => this.picPlayMain = value; }

        public IntPtr IntPtrPlayMain => iVideoRemoteBackplay.IntPtrPlayMain;

        public VideoInfo CurrentVideoInfo { get => iVideoRemoteBackplay.CurrentVideoInfo; set => iVideoRemoteBackplay.CurrentVideoInfo = value; }
        public CameraInfo CurrentCameraInfo { get => iVideoRemoteBackplay.CurrentCameraInfo; set => iVideoRemoteBackplay.CurrentCameraInfo = value; }


        private event VideoRemoteBackplayStatusChangedDelegate videoRemoteBackplayStatusChangedEvent;
        public event VideoRemoteBackplayStatusChangedDelegate VideoRemoteBackplayStatusChangedEvent
        {
            add
            {
                videoRemoteBackplayStatusChangedEvent += value;
                iVideoRemoteBackplay.VideoRemoteBackplayStatusChangedEvent += value;
            }

            remove
            {
                videoRemoteBackplayStatusChangedEvent -= value;
                iVideoRemoteBackplay.VideoRemoteBackplayStatusChangedEvent -= value;
            }
        }

        public VideoRemoteFileInfo[] FindRemoteFile(VideoRemotePlaySearchPara para)
        {
            return iVideoRemoteBackplay.FindRemoteFile(para);
        }

        public bool StartRemoteBackplayByTime(VideoRemotePlayByTimePara para)
        {
            VideoInfo vInfo = para.CameraInfo.VideoInfo;

            if (iVideoRemoteBackplay == null || iVideoRemoteBackplay.CurrentVideoInfo == null)
            {
                InitVideoRemoteBackplay(vInfo);
            }
            else if (vInfo.VideoType != iVideoRemoteBackplay.CurrentVideoInfo.VideoType)
            {
                InitVideoRemoteBackplay(vInfo);
            }
            iVideoRemoteBackplay.PicPlayMain = this.picPlayMain;
            return iVideoRemoteBackplay.StartRemoteBackplayByTime(para);
        }


        private void InitVideoRemoteBackplay(VideoInfo vInfo)
        {
            switch (vInfo.VideoType)
            {
                case Enum_VideoType.SKVideo:
                    iVideoRemoteBackplay = new VideoRemoteBackplay_SK();
                    break;
                case Enum_VideoType.HikDVR:
                    iVideoRemoteBackplay = new VideoRemoteBackplay_Hik();
                    break;
                case Enum_VideoType.TLiVideo:
                    iVideoRemoteBackplay = new VideoRemoteBackplay_TLi();
                    break;
                default:
                    iVideoRemoteBackplay = new VideoRemoteBackplay_Default();
                    break;
            }
        }

        public bool StopRemoteBackplayByTime()
        {
            return iVideoRemoteBackplay.StopRemoteBackplayByTime();
        }
    }
}
