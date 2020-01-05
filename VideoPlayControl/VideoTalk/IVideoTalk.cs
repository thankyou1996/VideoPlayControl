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

        /// <summary>
        /// 对讲设置
        /// </summary>
        TalkSetting CurrentTalkSetting
        {
            get;
            set;
        }

        /// <summary>
        /// 标签
        /// </summary>
        object Tag
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

        /// <summary>
        /// 开始对讲后事件
        /// </summary>
        event StartTalkedDelegate StartTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        event StopTalkedDelegate StopTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        /// <param name="StopTalkedValue"></param>
        /// <returns></returns>
        bool StopTalked(object StopTalkedValue);

        bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel);

        bool StartTlak(Enum_TalkModel talkModel);

        /// <summary>
        /// 开始对讲
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        bool StartTalk(TalkSetting ts);

        bool StopTalk();
    }
}
