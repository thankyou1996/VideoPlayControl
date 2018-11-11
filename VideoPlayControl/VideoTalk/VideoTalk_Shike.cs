using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_Shike : IVideoTalk
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

        private TalkSetting currentTalkSetting = new TalkSetting();

        /// <summary>
        /// 时刻设备对讲设置
        /// </summary>
        public TalkSetting CurrentTalkSetting
        {
            get { return currentTalkSetting; }
            set { currentTalkSetting = value; }
        }

        /// <summary>
        /// 时刻视频设备标签
        /// </summary>
        public object Tag { get ; set ; }

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

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }

        public event StartTalkedDelegate StartTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        public event StopTalkedDelegate StopTalkedEvent;

        /// <summary>
        /// 结束对讲后事件
        /// </summary>
        /// <param name="StopTalkedValue"></param>
        /// <returns></returns>
        public bool StopTalked(object StopTalkedValue)
        {
            bool bolResult = false;
            if (StopTalkedEvent != null)
            {
                StopTalkedEvent(this, StopTalkedValue);
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
            SDK_SKVideoSDK.st_multi_talk talkChannel = new SDK_SKVideoSDK.st_multi_talk();
            talkChannel = SDK_SKVideoSDK.SetMultiTalkChannel(CurrentTalkChannel.VideoTalkChannel, talkChannel);
            if ( CurrentTalkSetting.TalkRecordEnable)
            {
                CurrentTalkSetting.TalkRecordRealSavePath_Local= GetTalkRecordPath_Local(CurrentTalkSetting.TalkRecordPath_Local, CurrentTalkSetting.TalkRecordName_Local);
                string Temp_strValue = Path.GetDirectoryName(CurrentTalkSetting.TalkRecordRealSavePath_Local);
                CommonMethod.Common.CreateFolder(Temp_strValue);
            }
            SDK_SKVideoSDK.p_sdkc_start_multi_talk(CurrentVideoInfo.DVSAddress, ref talkChannel, GetSKTalkModel(talkModel), 1, 15, 10, CurrentTalkSetting.TalkRecordRealSavePath_Local);
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return bolResult;
        }

        /// <summary>
        /// 获取对讲记录保存地址
        /// </summary>
        /// <param name="strPath"></param>
        /// <param name="strName"></param>
        /// <returns></returns>
        public string GetTalkRecordPath_Local(string strPath,string strName)
        {
            string strResult = "";
            if (strName.EndsWith(".G711"))
            {
                strResult = strPath + "\\" + strName;
            }
            else
            {
                strResult = strPath + "\\" + strName + ".G711";
            }
            return strResult;
        }
        /// <summary>
        /// 时刻对讲设备_结束对讲
        /// </summary>
        /// <returns></returns>
        public bool StopTalk()
        {
            bool bolResult = false;
            if (CurrentVideoInfo != null && CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                SDK_SKVideoSDK.p_sdkc_stop_talk(CurrentVideoInfo.DVSAddress);
                StopTalked(null);
                CurrentTalkStatus = Enum_TalkStatus.Null;
            }
            return bolResult;
        }

        public static int GetSKTalkModel(Enum_TalkModel talk)
        {
            //对讲模式,1，全双工，2，喊话，3，监听
            int intResult = 1;
            switch (talk)
            {
                case Enum_TalkModel.Talkback:
                    intResult = 1;
                    break;
                case Enum_TalkModel.Sperak:
                    intResult = 2;
                    break;
                case Enum_TalkModel.Interception:
                    intResult = 3;
                    break;

            }
            return intResult;
        }

    }
}
