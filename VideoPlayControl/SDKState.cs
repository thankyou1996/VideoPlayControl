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

        #region 萤石云EzvieSDK 
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
        public static void Ezvie_SDKInit(int intLocStartPort = -1, string strTempFileDicPath = "")
        {
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
        }


        /// <summary>
        /// 萤石云_SDK释放
        /// </summary>
        public static void Ezvie_SDKRelease()
        {
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseStart);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            SDKState.EzvizSDKState = Enum_SDKState.SDK_Release;
            SDKEventCallBack(Enum_VideoType.Ezviz, Enum_SDKStateEventType.SDKReleaseEnd);
        }

        #endregion
        public static void VideoSDKRelease()
        {
            ColundSee_SDKRelease(); //云视通SDK 
        }
    }


}
