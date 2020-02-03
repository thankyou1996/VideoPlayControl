using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoEnvironment;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalk_ZHSR:IVideoTalk_Basic
    {

        /// <summary>
        /// 呼叫会话号
        /// </summary>
        public string Tsk_Guid { get; set; }

        /// <summary>
        /// 开始对讲
        /// </summary>
        /// <param name="talkModel"></param>
        /// <returns></returns>
        public override bool StartTlak(Enum_TalkModel talkModel)
        {

            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            StartTalking(null);
            if (CurrentTalkSetting.ExecuteTalk)
            {
                VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event -= VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
                VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event += VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
                int intTalkChannel = CurrentTalkChannel.VideoTalkChannel - 1;
                SDK_ZHSRSDK.win_sta_usr_call_req(VideoEnvironment.VideoEnvironment_ZHSR.Session, CurrentVideoInfo.DVSAddress, intTalkChannel, 0, 2, 1, 0);
            }
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return false;
        }

        private void VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event(string messageID, Dictionary<string, string> data)
        {
            if (messageID == "tk_tsk_status")
            {
                Tsk_Guid = data["tsk_guid"];
            }
        }

        /// <summary>
        /// 结束对讲
        /// </summary>
        /// <returns></returns>
        public override bool StopTalk()
        {
            if (CurrentTalkSetting.ExecuteTalk)
            {
                VideoEnvironment_ZHSR.ZHSR_Main_Callback_Event -= VideoEnvironment_ZHSR_ZHSR_Main_Callback_Event;
                SDK_ZHSRSDK.win_sta_stop_task(VideoEnvironment_ZHSR.Session, Tsk_Guid);
            }
            StopTalked(null);
            CurrentTalkStatus = Enum_TalkStatus.Null;
            return false;
        }
    }
}
