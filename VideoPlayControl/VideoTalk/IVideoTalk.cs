using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public interface IVideoTalk
    {
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        VideoTalkChannelInfo CurrentTalkChannel
        {
            get;
            set;
        }
        Enum_TalkStatus CurrentTalkStatus
        {
            get;
            set;
        }
        event TalkStausChangedDelegate TalkStausChangedEvent;

        bool TalkStausChanged(object TalkStausChangedValue);

        event StartTalkingDelegate StartTalkingEvent;

        bool StartTalking(object StartTalkingValue);


        bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel);

        bool StartTlak(Enum_TalkModel talkModel);

        bool StopTalk();

    }
}
