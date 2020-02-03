using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;
using static VideoPlayControl.SDKInterface.SDK_TDWYSDK;

namespace VideoPlayControl.VideoEnvironment
{
    /// <summary>
    /// 天地伟业
    /// </summary>
    public class VideoEnvironment_TDWY 
    {
        private static MAIN_NOTIFY_V4 MainNotify_V4 = null;

        private static ALARM_NOTIFY_V4 AlarmNotify_V4 = null;
        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init()
        {
            SDK_TDWYSDK.NetClient_Startup_V4(0, 0, 0);
            MainNotify_V4 = MyMAIN_NOTIFY_V4;
            SDK_TDWYSDK.NetClient_SetNotifyFunction_V4(MainNotify_V4, null, null, null, null);
        }

        /// <summary>
        /// 主回调
        /// </summary>
        /// <param name="_ulLogonID"></param>
        /// <param name="_iWparam"></param>
        /// <param name="_iLParam"></param>
        /// <param name="_iUser"></param>
        private static void MyMAIN_NOTIFY_V4(Int32 _ulLogonID, Int32 _iWparam, IntPtr _iLParam, IntPtr _iUser)
        {
            MAIN_NOTIFY(_ulLogonID, _iWparam, _iLParam, _iUser);
        }



        public static event MAIN_NOTIFY_V4 MAIN_NOTIFYEvent;
        private static void MAIN_NOTIFY(Int32 _ulLogonID, Int32 _iWparam, IntPtr _iLParam, IntPtr _iUser)
        {
            if (MAIN_NOTIFYEvent != null)
            {
                MAIN_NOTIFYEvent(_ulLogonID, _iWparam, _iLParam, _iUser);
            }
        }


        private static void MyAlarm_NOTIFY_V4(Int32 _ulLogonID, Int32 _iChan, Int32 _iAlarmState, Int32 _iAlarmType, Int32 _iUser)
        {
        }

        /// <summary>
        /// 释放
        /// </summary>
        public void Release()
        {
            //SDK_TDWYSDK.NetClient_Cleanup();
        }


    }
}
