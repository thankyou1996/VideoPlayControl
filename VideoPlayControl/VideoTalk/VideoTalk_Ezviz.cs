using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    /// <summary>
    /// 萤石
    /// </summary>
    public class VideoTalk_Ezviz : IVideoTalk_Basic
    {

        SDK_EzvizSDK.MsgHandler callBack;
        IntPtr iUser = IntPtr.Zero;
        IntPtr intptrSessionID = IntPtr.Zero;
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
            int intResult = 0;
            int intLenght = 0;
            int intTalkChannel = CurrentTalkChannel.VideoTalkChannel - 1;
            callBack = new SDK_EzvizSDK.MsgHandler(Ezviz_MsgCallback);
            string strUser = CurrentVideoInfo.DVSAddress + "_" + CurrentTalkChannel.VideoTalkChannel;
            iUser = Marshal.StringToHGlobalAnsi(strUser);
            intResult = SDK_EzvizSDK.OpenSDK_AllocSessionEx(callBack, iUser, out intptrSessionID, out intLenght);
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            SDK_EzvizSDK.OpenSDK_StartVoiceTalkEx(intptrSessionID, intptrdevSerial, CurrentTalkChannel.VideoTalkChannel);
            CurrentTalkStatus = (Enum_TalkStatus)(int)talkModel;
            return false;
        }

        /// <summary>
        /// 消息事件回调
        /// </summary>
        /// <param name="intptrSessionId"></param>
        /// <param name="iMsgType"></param>
        /// <param name="iErrorCode"></param>
        /// <param name="pMessageInfo"></param>
        /// <param name="pUser"></param>
        public void Ezviz_MsgCallback(IntPtr intptrSessionId, SDK_EzvizSDK.EzvizMeesageType iMsgType, uint iErrorCode, string pMessageInfo, IntPtr pUser)
        {

        }

        /// <summary>
        /// 结束对讲
        /// </summary>
        /// <returns></returns>
        public override bool StopTalk()
        {
            SDK_EzvizSDK.OpenSDK_StopVoiceTalk(intptrSessionID);
            StopTalked(null);
            CurrentTalkStatus = Enum_TalkStatus.Null;
            return false;
        }
    }
}
