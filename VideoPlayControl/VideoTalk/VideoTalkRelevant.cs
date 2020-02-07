using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoTalk
{
    public class VideoTalkRelevant
    {
        public static IVideoTalk GetVideoTalkValue(VideoInfo vInfo)
        {
            IVideoTalk iv = new VideoTalk_Default();

            Enum_VideoType Temp_videoType = Transition.Transition_VideoTypeConvert.GetVideoType(vInfo);
            switch (Temp_videoType)
            {
                case Enum_VideoType.Unrecognized:
                    break;
                case Enum_VideoType.CloundSee:
                    break;
                case Enum_VideoType.IPCWA:
                    break;
                case Enum_VideoType.Ezviz:
                    iv = new VideoTalk_Ezviz();
                    break;
                case Enum_VideoType.SKVideo:
                    iv = new VideoTalk_Shike();
                    break;
                case Enum_VideoType.HuaMaiVideo:
                    break;
                case Enum_VideoType.Axis:
                    break;
                case Enum_VideoType.XMaiVideo:
                    break;
                case Enum_VideoType.BlueSky:
                    break;
                case Enum_VideoType.IMOS:
                    break;
                case Enum_VideoType.SKNVideo:
                    iv = new VideoTalk_SKNVideo();
                    break;
                case Enum_VideoType.HikDVR:
                    iv = new VideoTalk_Hik();
                    break;
                case Enum_VideoType.HikDVRStream:
                    iv = new VideoTalk_HikStream_Client();
                    break;
                case Enum_VideoType.TLiVideo:
                    iv = new VideoTalk_TLi();
                    break;
                case Enum_VideoType.DaHuaVideo:
                    break;
                case Enum_VideoType.ZLVideo:
                    break;
                case Enum_VideoType.ZHSR:
                    iv = new VideoTalk_ZHSR();
                    break;
                default:

                    break;
            }
            return iv;
        }
    }
}
