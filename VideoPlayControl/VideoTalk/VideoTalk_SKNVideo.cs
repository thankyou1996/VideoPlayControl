using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_SKNVideo:IVideoTalk
    {
        public VideoInfo CurrentVideoInfo
        { get; set; }
        public VideoTalkChannelInfo CurrentTalkChannel { get; set; }
        private Enum_TalkStatus currentTalkStatus;
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

        public TalkSetting CurrentTalkSetting { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object Tag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event TalkStausChangedDelegate TalkStausChangedEvent;

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

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
            if (CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                StopTalk();
            }
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            StartTalking(null);
            int intChannel = CurrentTalkChannel.VideoTalkChannel - 1;
            int intResult = SDK_SKNVideo.SDK_NSK_CLIENT_start_talk(CurrentVideoInfo.DVSAddress, GetTalkValuebyTalkChannel(intChannel), GetSKTalkModel(talkModel), "\\TEST\\test.g711", "\\TEST\\test.g711");
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return bolResult;
        }

        private int GetTalkValuebyTalkChannel(int intTalkChannel)
        {
            int intValue = 0;
            intValue = (1 << intTalkChannel);
            return intValue;
        }


        public bool StopTalk()
        {
            bool bolResult = false;
            SDK_SKNVideo.SDK_NSK_CLIENT_close_talk(CurrentVideoInfo.DVSAddress);
            if (CurrentVideoInfo != null && CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                CurrentTalkStatus = Enum_TalkStatus.Null;
            }
            return bolResult;
        }

        public static int GetSKTalkModel(Enum_TalkModel talk)
        {
            //对讲模式,3，全双工，2，喊话，1，监听
            int intResult = 1;
            switch (talk)
            {
                case Enum_TalkModel.Talkback:
                    intResult = 3;
                    break;
                case Enum_TalkModel.Sperak:
                    intResult = 2;
                    break;
                case Enum_TalkModel.Interception:
                    intResult = 1;
                    break;

            }
            return intResult;
        }

        public bool StopTalked(object StopTalkedValue)
        {
            throw new NotImplementedException();
        }
    }
}
