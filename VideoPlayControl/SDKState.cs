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
        /// 初始化SDK_云视通
        /// </summary>
        public static void CloundSee_SDKInit(int intLocStartPort = -1, string strTempFileDicPath = "")
        {
            if (SDKState.CloundSeeSDKState != Enum_SDKState.SDK_Init)
            {
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
            }
        }

        #endregion


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

    }


}
