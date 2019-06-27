using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoInfoSet
{
    public interface IVideoInfoSet
    {
        /// <summary>
        /// 同步OSD信息_下载
        /// 视频对象信息同步至设备
        /// </summary>
        /// <returns></returns>
        bool SyncOSDInfo_Download(VideoInfo vInfo);

        /// <summary>
        /// 同步OSD信息_上传
        /// 设备OSD信息同步至视频对象信息
        /// </summary>
        /// <returns></returns>
        bool SyncOSDInfo_Upload(VideoInfo vInfo);
    }
}
