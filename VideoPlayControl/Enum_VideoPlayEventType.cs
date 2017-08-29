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
        InitEnd = 1,

        /// <summary>
        /// 控件加载完成
        /// </summary>
        LoadEnd = 2,

        /// <summary>
        /// 设置视频播放信息
        /// </summary>
        SetVideoInfo = 3,

        /// <summary>
        /// 视频类型不存在
        /// </summary>
        VideoTypeNotExists = 4,

        /// <summary>
        /// 关闭视频信息
        /// </summary>
        VideoClose = 5,

        /// <summary>
        /// 请求视频连接
        /// </summary>
        RequestConn = 6,

        /// <summary>
        /// 连接成功
        /// </summary>
        ConnSuccess = 7,

        /// <summary>
        /// 连接失败
        /// </summary>
        ConnFailed = 8,

        /// <summary>
        /// 正在播放视频
        /// </summary>
        VideoPlay = 9,

        /// <summary>
        /// 请求视频信息超时
        /// </summary>
        RequestVideoTimeout = 10,

        /// <summary>
        /// 视频设备不在线
        /// 不在线属于状态,在这里定位为事件方便记录显示
        /// </summary>
        VideoDeviceNotOnline = 11,

        /// <summary>
        /// 用户信息验证失败
        /// </summary>
        UserAccessError = 12
    }
}
