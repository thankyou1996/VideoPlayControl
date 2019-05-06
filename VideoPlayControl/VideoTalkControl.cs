using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.VideoTalk;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl
{
    public partial class VideoTalkControl : UserControl,IVideoTalk
    {
        IVideoTalk videoTalk = new VideoTalk_Shike();

        

        public VideoTalkControl()
        {
            InitializeComponent();
        }

        public VideoInfo CurrentVideoInfo
        {
            get
            {
                return  videoTalk.CurrentVideoInfo;
            }
            set { videoTalk.CurrentVideoInfo = value; }
        }
        public VideoTalkChannelInfo CurrentTalkChannel
        {
            get { return videoTalk.CurrentTalkChannel; }
            set { videoTalk.CurrentTalkChannel = value; }
        }
        public Enum_TalkStatus CurrentTalkStatus
        {
            get { return videoTalk.CurrentTalkStatus; }
            set { videoTalk.CurrentTalkStatus = value; }
        }

        public TalkSetting CurrentTalkSetting
        {
            get { return videoTalk.CurrentTalkSetting; }
            set { videoTalk.CurrentTalkSetting = value; }
        }

        public event TalkStausChangedDelegate TalkStausChangedEvent
        {
            add { videoTalk.TalkStausChangedEvent += value; }
            remove { videoTalk.TalkStausChangedEvent -= value; }
        }

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;

            return bolResult;
        }

        private StartTalkingDelegate startTalkingEvent;

      

        public event StartTalkingDelegate StartTalkingEvent
        {
            add
            {
                videoTalk.StartTalkingEvent += value;
                startTalkingEvent += value;
            }
            remove
            {
                videoTalk.StartTalkingEvent -= value;
                startTalkingEvent -= value;
            }
        }

        private StartTalkedDelegate startTalkedEvent;
        public event StartTalkedDelegate StartTalkedEvent
        {
            add
            {
                videoTalk.StartTalkedEvent += value;
                startTalkedEvent += value;

            }
            remove
            {
                videoTalk.StartTalkedEvent -= value;
                startTalkedEvent -= value;
            }
        }
        private StopTalkedDelegate stopTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent
        {
            add
            {
                videoTalk.StopTalkedEvent += value;
                stopTalkedEvent += value;

            }
            remove
            {
                videoTalk.StopTalkedEvent -= value;
                stopTalkedEvent -= value;
            }
        }

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;

            return bolResult;
        }

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            Enum_VideoType Temp_videoType = videoInfo.VideoType;
            if (ProgParameter.TransitionEnable && Temp_videoType == Enum_VideoType.Unrecognized)
            {
                Temp_videoType= Transition.Transition_VideoTypeConvert.GetVideoType(videoInfo);
            }
            if (videoTalk.CurrentVideoInfo == null || videoTalk.CurrentVideoInfo.VideoType != videoInfo.VideoType)
            {
                videoTalk = VideoTalkRelevant.GetVideoTalkValue(videoInfo);
                videoTalk.TalkStausChangedEvent += VideoTalk_TalkStausChangedEvent;
                videoTalk.StartTalkingEvent += startTalkingEvent;
                videoTalk.StartTalkedEvent += startTalkedEvent;
                videoTalk.StopTalkedEvent += stopTalkedEvent;
            }
            videoTalk.SetVideoTalkInfo(videoInfo, talkChannel);
            return bolResult;
        }


        private bool VideoTalk_TalkStausChangedEvent(object sender, object TalkStausChangedValue)
        {
            bool bolResult = false;
            IVideoTalk iv = (IVideoTalk)sender;
            switch (iv.CurrentTalkStatus)
            {
                case Enum_TalkStatus.Null:
                    btnTalkback.Enabled = true;
                    btnSperak.Enabled = true;
                    btnInterception.Enabled = true;
                    btnTalkback.Text = "对讲";
                    btnSperak.Text = "喊话";
                    btnInterception.Text = "侦听";
                    break;

                case Enum_TalkStatus.Interceptioning:
                    btnTalkback.Enabled = false;
                    btnSperak.Enabled = false;
                    btnInterception.Enabled = true;
                    btnTalkback.Text = "对讲";
                    btnSperak.Text = "喊话";
                    btnInterception.Text = "取消";

                    break;

                case Enum_TalkStatus.Speraking:
                    btnTalkback.Enabled = false;
                    btnSperak.Enabled = true;
                    btnInterception.Enabled = false;
                    btnTalkback.Text = "对讲";
                    btnSperak.Text = "取消";
                    btnInterception.Text = "侦听";
                    break;
                case Enum_TalkStatus.Talkbacking:
                    btnTalkback.Enabled = true;
                    btnSperak.Enabled = false;
                    btnInterception.Enabled = false;
                    btnTalkback.Text = "取消";
                    btnSperak.Text = "喊话";
                    btnInterception.Text = "侦听";
                    break;
            }
            return bolResult;
            
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            videoTalk.StartTlak(talkModel);
            return bolResult;
        }


        public bool StopTalk()
        {
            bool bolResult = false;
            videoTalk.StopTalk();
            return bolResult;
        }



        private void btnTalkback_Click(object sender, EventArgs e)
        {
            if (CurrentTalkStatus == Enum_TalkStatus.Null)
            {
                StartTlak(Enum_TalkModel.Talkback);
            }
            else
            {
                StopTalk();
            }
        }

        private void btnInterception_Click(object sender, EventArgs e)
        {
            if (CurrentTalkStatus == Enum_TalkStatus.Null)
            {
                StartTlak(Enum_TalkModel.Interception);
            }
            else
            {
                StopTalk();
            }
        }

        private void btnSperak_Click(object sender, EventArgs e)
        {
            if (CurrentTalkStatus == Enum_TalkStatus.Null)
            {
                StartTlak(Enum_TalkModel.Sperak);
            }
            else
            {
                StopTalk();
            }
        }

        public bool StopTalked(object StopTalkedValue)
        {
            throw new NotImplementedException();
        }
    }
}
