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

        private TalkSetting currentTalkSetting = new TalkSetting();

        /// <summary>
        /// 时刻设备对讲设置
        /// </summary>
        public TalkSetting CurrentTalkSetting
        {
            get { return currentTalkSetting; }
            set { currentTalkSetting = value; }
        }

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
