using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// SDK状态
    /// </summary>
    public static class SDKState
    {
        #region 委托事件

        #region SDK状态改变
        /// <summary>
        /// SDK状态变化回调 委托
        /// </summary>
        /// <param name="sdkType"></param>
        /// <param name="sdkState"></param>
        public delegate void SDKStateChangeDelegate(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKState sdkState);

        /// <summary>
        /// SDK状态变化回调 事件
        /// </summary>
        public static event SDKStateChangeDelegate SDKStateChangeEvent;

        /// <summary>
        /// SDK状态变化
        /// </summary>
        private static void SDKStateChange(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKState sdkState)
        {
            if (SDKStateChangeEvent != null)
            {
                SDKStateChangeEvent(sdkType, sdkState);
            }
        }

        #endregion

        #region SDK状态改变事件

        /// <summary>
        /// SDK事件回调 委托
        /// </summary>
        /// <param name="sdkType"></param>
        /// <param name="sdkState"></param>
        public delegate void SDKEventStateDelegate(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKStateEventType sdkState);

        /// <summary>
        /// SDK事件回调 事件
        /// </summary>
        public static event SDKEventStateDelegate SDKEventStateEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        private static void SDKEventCallBack(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKStateEventType sdkStateEvent)
        {
            if (SDKEventStateEvent != null)
            {
                SDKEventStateEvent(sdkType, sdkStateEvent);
            }
        }

        #endregion

        #region SDK事件回调
        /// <summary>
        /// SDK事件回调委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="etType"></param>
        public delegate void SDKEventCallBackDelegate(Enum_VideoType videoType, Enum_SDKEventType etType, string strtTag);

        /// <summary>
        /// SDK事件回调事件
        /// </summary>
        public static event SDKEventCallBackDelegate SDKEventCallBackEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private static void SDKEventCallBack(Enum_VideoType videoType, Enum_SDKEventType etType, string strTag = "")
        {
            if (SDKEventCallBackEvent != null)
            {
                SDKEventCallBackEvent(videoType,etType, strTag);
            }
        }
        #endregion

        #endregion


        #region 云视通SDK 
        /// <summary>
        /// 云视通SDK状态
        /// </summary>
        private static Enum_SDKState s_CloundSeeSDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 云视通SDK状态
        /// </summary>
        public static Enum_SDKState CloundSeeSDKState
        {
            get { return s_CloundSeeSDKState; }
            set
            {
                s_CloundSeeSDKState = value;
                SDKStateChange(PublicClassCurrency.Enum_VideoType.CloundSee, s_CloundSeeSDKState);
            }
        }

        
        /// <summary>
        /// 云视通_初始化SDK
        /// </summary>
        public static void CloundSee_SDKInit(int intLocStartPort = -1, string strTempFileDicPath = "")
        {
            if (SDKState.CloundSeeSDKState != Enum_SDKState.SDK_Init)
            {
                SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKInitStart);
                // 不属于初始化状态
                ProgParameter.intCloundSee_intLocStartPort = intLocStartPort;
                if (string.IsNullOrEmpty(strTempFileDicPath.Trim()))
                {
                    ProgParameter.strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
                }
                else
                {
                    ProgParameter.strCloundSee_TempDicPath = strTempFileDicPath;
                }

                //初始化
                if (SDK_JCSDK.JCSDK_InitSDK(ProgParameter.intCloundSee_intLocStartPort, ProgParameter.strCloundSee_TempDicPath))
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_Init;
                }
                else
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_InitFail;
                    return;
                }
                SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKInitEnd);
            }
        }

        /// <summary>
        /// 云视通_SDK释放
        /// </summary>
        public static void ColundSee_SDKRelease()
        {
            SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_JCSDK.JCSDK_ReleaseSDK();
            SDKState.CloundSeeSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.CloundSee, Enum_SDKStateEventType.SDKReleaseEnd);

        }

        #endregion

        #region  普顺达 IPCWA
        /// <summary>
        /// 普顺达SDK 
        /// </summary>
        private static Enum_SDKState s_IPCWASDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 普顺达SDK
        /// </summary>
        public static Enum_SDKState IPCWASDKState
        {
            get { return s_IPCWASDKState; }
            set
            {
                s_IPCWASDKState = value;
                SDKStateChange(PublicClassCurrency.Enum_VideoType.IPCWA, s_IPCWASDKState);
            }
        }
        #endregion

        #region 萤石云EzvizSDK 
        /// <summary>
        /// 萤石云SDK状态
        /// </summary>
        private static Enum_SDKState s_EzvizSDKState = Enum_SDKState.SDK_Null;
        /// <summary>
        /// 萤石云SDK状态
        /// </summary>
        public static Enum_SDKState EzvizSDKState
        {
            get { return s_EzvizSDKState; }
            set
            {
                s_EzvizSDKState = value;
                SDKStateChange(Enum_VideoType.Ezviz, s_EzvizSDKState);
            }
        }


        /// <summary>
        /// 萤石云_初始化SDK
        /// </summary>
        public static void Ezviz_SDKInit_Old()
        {
            if (EzvizSDKState != Enum_SDKState.SDK_Init)
            {
                if (SDK_EzvizSDK_Old.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID) == 0)
                {
                    EzvizSDKState = Enum_SDKState.SDK_Init;
                    
                }
                else
                {
                    EzvizSDKState = Enum_SDKState.SDK_InitFail;
                }
            }
        }


        /// <summary>
        /// 萤石云_SDK释放
        /// </summary>
        public static void Ezviz_SDKRelease_Old()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_EzvizSDK_Old.OpenSDK_FiniLib();
            SDKState.EzvizSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
        }


        /// <summary>
        /// 萤石云_初始化SDK
        /// 初始化完成后需要获取Token
        /// </summary>
        public static Enum_SDKState Ezviz_SDKInit()
        {
            //int intResult=
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitStart);
            if (EzvizSDKState != Enum_SDKState.SDK_Init)
            {
                if (SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID) == 0)
                {
                    EzvizSDKState = Enum_SDKState.SDK_Init;
                }
                else
                {
                    EzvizSDKState = Enum_SDKState.SDK_InitFail;
                }
            }
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKInitEnd);
            return EzvizSDKState;
        }
        
        /// <summary>
        /// 萤石云_SDK释放
        /// </summary>
        public static Enum_SDKState Ezviz_SDKRelease()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            EzvizSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
            return EzvizSDKState;


        }


        /// <summary>
        /// 消息事件回调
        /// </summary>
        /// <param name="intptrSessionId"></param>
        /// <param name="iMsgType"></param>
        /// <param name="iErrorCode"></param>
        /// <param name="pMessageInfo"></param>
        /// <param name="pUser"></param>
        public static void Ezviz_MsgCallback(IntPtr intptrSessionId, EzvizMeesageType iMsgType, uint iErrorCode, string pMessageInfo, string pUser)
        {
            string strTag = "";
            Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
            switch (iMsgType)
            {
                case EzvizMeesageType.INS_PLAY_EXCEPTION:

                    break;

                case EzvizMeesageType.INS_PLAY_RECONNECT:
                    //VideoPlayState = Enum_VideoPlayState.InPlayState;

                    break;

                case EzvizMeesageType.INS_PLAY_RECONNECT_EXCEPTION:

                    break;

                case EzvizMeesageType.INS_PLAY_START:
                    //VideoPlayState = Enum_VideoPlayState.InPlayState;
                    //CurrentVideoInfo.NetworkState = 1;          //置为在线
                    //VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay);
                    break;

                case EzvizMeesageType.INS_PLAY_STOP:
                    //VideoPlayState = Enum_VideoPlayState.NotInPlayState;

                    break;

                case EzvizMeesageType.INS_PLAY_ARCHIVE_END:
                    //VideoPlayState = Enum_VideoPlayState.NotInPlayState;

                    break;

                case EzvizMeesageType.INS_VOICETALK_START:

                    break;

                case EzvizMeesageType.INS_VOICETALK_STOP:

                    break;

                case EzvizMeesageType.INS_VOICETALK_EXCEPTION:

                    break;

                case EzvizMeesageType.INS_PTZ_EXCEPTION:

                    break;

                case EzvizMeesageType.INS_RECORD_FILE:

                    break;

                case EzvizMeesageType.INS_RECORD_SEARCH_END:

                    break;

                case EzvizMeesageType.INS_RECORD_SEARCH_FAILED:

                    break;

                case EzvizMeesageType.INS_DEFENSE_SUCCESS:

                    break;

                case EzvizMeesageType.INS_DEFENSE_FAILED:

                    break;

                case EzvizMeesageType.INS_PLAY_ARCHIVE_EXCEPTION:

                    break;

                case EzvizMeesageType.INS_PTZCTRL_SUCCESS:

                    break;

                case EzvizMeesageType.INS_PTZCTRL_FAILED:

                    break;
            }
            if (videoEvType == Enum_SDKEventType.Unrecognized)
            {
                strTag = strTag = iMsgType.ToString();
            }
            SDKEventCallBack(Enum_VideoType.Ezviz, videoEvType, strTag);
        }

        #endregion


        
        public static void VideoSDKRelease()
        {
            ColundSee_SDKRelease(); //云视通SDK 
            Ezviz_SDKRelease();     //萤石云SDK 
        }
    }


}
