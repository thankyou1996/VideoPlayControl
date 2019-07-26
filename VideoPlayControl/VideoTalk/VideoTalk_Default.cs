using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_Default : IVideoTalk
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public VideoTalkChannelInfo CurrentTalkChannel { get; set; }
        public TalkSetting CurrentTalkSetting { get; set; }
        public object Tag { get; set; }
        public Enum_TalkStatus CurrentTalkStatus { get; set; }

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            throw new NotImplementedException();
        }

        public bool StartTalking(object StartTalkingValue)
        {
            throw new NotImplementedException();
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            throw new NotImplementedException();
        }

        public bool StopTalk()
        {
            throw new NotImplementedException();
        }

        public bool StopTalked(object StopTalkedValue)
        {
            throw new NotImplementedException();
        }

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            throw new NotImplementedException();
        }
    }
}
