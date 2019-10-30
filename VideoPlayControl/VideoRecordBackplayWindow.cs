using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.VideoRecordBackplay;
using PublicClassCurrency;
using VideoPlayControl.VideoRecord;

namespace VideoPlayControl
{
    public partial class VideoRecordBackplayWindow : UserControl
    {
        public event VideoRecodPosChangedDelegate VideoRecodPosChangeEvnet;
        private void VideoRecodPosChange(object obj,float fltPosValue)
        {
            if (VideoRecodPosChangeEvnet != null)
            {
                VideoRecodPosChangeEvnet(this, fltPosValue);
            }
        }
        public IVideoRecordBackplay videoPlay;
        public VideoRecordBackplayWindow()
        {
            InitializeComponent();
        }
        
        public bool SetVideoRecordInfo(VideoRecordInfo v)
        {
            switch (v.VideoType)
            {
                case Enum_VideoType.XMaiVideo:
                    videoPlay = new VideoRecordBackplay_XMAI();
                    break;
                case Enum_VideoType.BlueSky:
                    videoPlay = new VideoRecordBackplay_BlueSky(this.Handle);
                    break;
                case Enum_VideoType.Axis:

                    break;
                case Enum_VideoType.TLiVideo:
                    videoPlay = new VideoRecordBackplay_TLi();
                    break;
            }

            videoPlay.SetVideoRecordInfo(v);
            videoPlay.intptrPlayWnd = this.Handle;
            videoPlay.VideoRecodPosChangeEvnet += VideoRecodPosChange;
            return false;
        }

        
        public bool OpenVideoRecord()
        {
            return videoPlay.OpenVideoRecord();
        }
        public bool PauseVideoRecord()
        {
            return videoPlay.PauseVideoRecord();
        }

        public bool PlayFast()
        {
            return videoPlay.PlayFast();
        }

        public bool PlaySlow()
        {
            return videoPlay.PlaySlow();
        }

        public bool PlayVideoRecord()
        {
            return videoPlay.PlayVideoRecord();
        }


        public bool SetVideoRecordPos(float fltPosValue)
        {
            return videoPlay.SetVideoRecordPos(fltPosValue);
        }

        public bool CloseVideoRecord()
        {
            return videoPlay.CloseVideoRecord();
        }
    }
}
