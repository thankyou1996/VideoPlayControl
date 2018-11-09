using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_HikStream_Client : IVideoTalk
    {
        public VideoInfo CurrentVideoInfo { get ; set ; }
        public VideoTalkChannelInfo CurrentTalkChannel { get ; set ; }
        public Enum_TalkStatus CurrentTalkStatus { get ; set ; }
        public TalkSetting CurrentTalkSetting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Tag { get ; set ; }

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }
        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }


        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            if (SDK_TalkManagerSDK.StartTalk(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, 8082))
            {
                CurrentTalkStatus = Enum_TalkStatus.Talkbacking;
            }
            else
            {
                CurrentTalkStatus = Enum_TalkStatus.Null ;
            }
            return bolResult;
        }

        public bool StopTalk()
        {
            bool bolResult = false;
            SDK_TalkManagerSDK.StopTalk();
            return bolResult;
        }

        public bool StopTalked(object StopTalkedValue)
        {
            throw new NotImplementedException();
        }
    }
}
