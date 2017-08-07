using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放事件类型枚举
    /// </summary>
    public enum Enum_VideoPlayEventType
    {

        /// <summary>
        /// 控件初始化完成
        /// </summary>
        InitEnd,

        /// <summary>
        /// 控件加载完成
        /// </summary>
        LoadEnd,

        /// <summary>
        /// 设置视频播放信息
        /// </summary>
        SetVideoInfo,

        /// <summary>
        /// 视频类型不存在
        /// </summary>
        VideoTypeNotExists,

        /// <summary>
        /// 关闭视频信息
        /// </summary>
        VideoClose,

        /// <summary>
        /// 请求视频信息
        /// </summary>
        RequestVideo,

        /// <summary>
        /// 正在播放视频
        /// </summary>
        VideoPlay,

        /// <summary>
        /// 请求视频信息超时
        /// </summary>
        RequestVideoTimeout

        
    }
}
