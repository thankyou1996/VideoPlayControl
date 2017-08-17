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

        public delegate void SDKEventStateChangeDelegate(PublicClassCurrency.Enum_VideoType sdkType, Enum_SDKState sdkState);

        public static event SDKEventStateChangeDelegate SDKEventStateChangeEvent;

        private static void SDKEventStateChange()
        {

        }

        private static Enum_SDKState s_CloundSeeSDKState = Enum_SDKState.SDK_Null;
        public static  Enum_SDKState CloundSeeSDKState
        {
            get { return s_CloundSeeSDKState; }
            set
            {
                s_CloundSeeSDKState = value;

            }
        }
        

    }


}
