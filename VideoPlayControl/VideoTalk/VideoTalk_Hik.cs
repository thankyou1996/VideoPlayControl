using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDK_HikClientSDK;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_Hik:IVideoTalk
    {
        private int _intDVRHwd = -1;//登录DVR的HWND
        private int _intTalkHwd = -1;//对讲的HWND
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

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

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

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }

        fVoiceDataCallBack VoiceCallBack;
        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            StartTalking(null);
            NET_DVR_DEVICEINFO_V30 dev = new NET_DVR_DEVICEINFO_V30();
            _intDVRHwd = NET_DVR_Login_V30(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref dev);
            VoiceCallBack = new fVoiceDataCallBack(MyRealDataCallBack);
            _intTalkHwd = NET_DVR_StartVoiceCom(_intDVRHwd, VoiceCallBack, 0);
            NET_DVR_SetVoiceComClientVolume(_intTalkHwd, 65530);
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return bolResult;
        }
        private void MyRealDataCallBack(int lVoiceComHandle, [MarshalAs(UnmanagedType.LPArray)]  byte[] pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser)
        {
            Console.WriteLine("MyRealDataCallBack：" + dwBufSize);
        }
        public bool StopTalk()
        {
            bool bolResult = false;
            NET_DVR_StopVoiceCom(_intTalkHwd);
            NET_DVR_Logout(_intDVRHwd);
            StopTalked(null);
            CurrentTalkStatus = Enum_TalkStatus.Null;
            return bolResult;
        }

        public bool StopTalked(object StopTalkedValue)
        {
            bool bolResult = false;
            if (StopTalkedEvent != null)
            {
                StopTalkedEvent(this, StopTalkedValue);
            }
            return bolResult;
        }

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }
    }
}
