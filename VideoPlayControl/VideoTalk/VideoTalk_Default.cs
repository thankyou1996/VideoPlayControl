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

        private TalkSetting currentTalkSetting = new TalkSetting();

        /// <summary>
        /// 时刻设备对讲设置
        /// </summary>
        public TalkSetting CurrentTalkSetting
        {
            get { return currentTalkSetting; }
            set { currentTalkSetting = value; }
        }

        public object Tag { get; set; }
        public Enum_TalkStatus CurrentTalkStatus { get; set; }

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            return false;
        }

        public bool StartTalking(object StartTalkingValue)
        {
            return false;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            return false;
        }

        public bool StopTalk()
        {
            return false;
        }

        public bool StopTalked(object StopTalkedValue)
        {
            return false;
        }

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            return false;
        }
    }
}
