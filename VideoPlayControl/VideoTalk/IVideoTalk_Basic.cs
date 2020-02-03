using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class IVideoTalk_Basic:IVideoTalk
    {
        /// <summary>
        /// 当前视频设备信息
        /// </summary>
        public VideoInfo CurrentVideoInfo
        {
            get
            {
                return CurrentTalkChannel.VideoInfo;
            }
            set 
            {
            
            }
        }
        /// <summary>
        /// 当前通道信息
        /// </summary>
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

        private Enum_TalkStatus currentTalkStatus;
        /// <summary>
        /// 对讲状态
        /// </summary>
        public Enum_TalkStatus CurrentTalkStatus
        {
            get
            {
                return currentTalkStatus;
            }
            set
            {
                if (currentTalkStatus != value)
                {
                    currentTalkStatus = value;
                    TalkStausChanged(null);
                }
            }
        }

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

        /// <summary>
        /// 设置对讲
        /// </summary>
        /// <param name="videoInfo"></param>
        /// <param name="talkChannel"></param>
        /// <returns></returns>
        public virtual bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            CurrentTalkChannel = talkChannel;
            return true;
        }

        public virtual bool StartTalking(object StartTalkingValue)
        {
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return false;
        }

        /// <summary>
        /// 开始对讲
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public virtual bool StartTalk(TalkSetting ts)
        {
            CurrentTalkSetting = ts;
            return StartTlak(ts.TalkMode);
        }


        /// <summary>
        ///开始对讲
        /// </summary>
        /// <param name="talkModel"></param>
        /// <returns></returns>
        public virtual bool StartTlak(Enum_TalkModel talkModel)
        {
            return false;
        }

        public virtual bool StopTalk()
        {
            return false;
        }

        public virtual bool StopTalked(object StopTalkedValue)
        {
            if (StopTalkedEvent != null)
            {
                StopTalkedEvent(this, StopTalkedValue);
            }
            return false;
        }

        public virtual bool TalkStausChanged(object TalkStausChangedValue)
        {
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return false;
        }
    }
}
