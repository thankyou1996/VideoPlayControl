using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoEnvironment
{
    public class VideoEnvironment_HikStream 
    {
        public static Enum_SDKState State = Enum_SDKState.SDK_Null;
        public static void Init(string strServiceAddress)
        {
            ProgParameter.strHikStreamIP = strServiceAddress;
            SDKInterface.SDK_HikStream.InitStreamClientLib();//视频功能初始化
            SDK_TalkManagerSDK.Init_Client();       //对讲功能初始化
            State = Enum_SDKState.SDK_Init;
        }

        public static void Release()
        {
            SDKInterface.SDK_HikStream.FiniStreamClientLib();
            State = Enum_SDKState.SDK_Release;
        }
    }
}
