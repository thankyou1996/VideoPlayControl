using System;
using System.Collections.Generic;
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
        public VideoTalkChannelInfo CurrentTalkChannel { get; set ; }


        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            SDK_SKVideoSDK.st_multi_talk talkChannel = new SDK_SKVideoSDK.st_multi_talk();
            
            //SDK_SKVideoSDK.p_sdkc_start_multi_talk(CurrentVideoInfo.DVSAddress, ref talkChannel, intTalkMode, 1, 15, 10, "");
            //TlakStatus = intTalkMode;
            return bolResult;
        }


        public bool StopTalk()
        {
            bool bolResult = false;
            
            return bolResult;
        }
    }
}
