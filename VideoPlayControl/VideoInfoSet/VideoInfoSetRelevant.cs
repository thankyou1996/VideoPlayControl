using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VideoPlayControl.Transition;

namespace VideoPlayControl.VideoInfoSet
{
    public class VideoInfoSetRelevant
    {
        /// <summary>
        /// 同步OSD信息_下载
        /// 视频对象信息同步至设备
        /// </summary>
        /// <param name="vInfo"></param>
        /// <returns></returns>
        public static bool  SyncOSDInfo_Download(VideoInfo vInfo)
        {
            IVideoInfoSet set = GetVideoInfoSetObject(vInfo);
            return set.SyncOSDInfo_Download(vInfo);
        }

        /// <summary>
        /// 同步OSD信息_上传
        /// 设备OSD信息同步至视频对象信息
        /// </summary>
        /// <param name="vInfo"></param>
        /// <returns></returns>
        public static bool SyncOSDInfo_Upload(VideoInfo vInfo)
        {
            IVideoInfoSet set = GetVideoInfoSetObject(vInfo);
            return set.SyncOSDInfo_Upload(vInfo);
        }

        public static IVideoInfoSet GetVideoInfoSetObject(VideoInfo vInfo)
        {
            IVideoInfoSet videoInfoSet = new VideoInfoSet_Default();
            Enum_VideoType enum_VideoType = Transition_VideoTypeConvert.GetVideoType(vInfo);
            switch (enum_VideoType)
            {
                case Enum_VideoType.SKVideo:
                    videoInfoSet = new VideoInfoSet_Shike();
                    break;
            }
            return videoInfoSet;
        }

    }
}
