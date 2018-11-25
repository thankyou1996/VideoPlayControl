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
        /// 设备不存在
        /// </summary>
        DeviceNotExist = 14,


   
     


     

        #region 视频预览相关 100~200

        /// <summary>
        /// 视频异常
        /// </summary>
        VideoPlayException = 13,


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
        /// 超出设备最大连接数
        /// </summary>
        ConnNumMax = 16,
        
        /// <summary>
        /// 设备码流类型异常
        /// </summary>
        DeviceStreamTypeException =101,

        /// <summary>
        /// 视频预览超时关闭
        /// </summary>
        TimtOutVideoClose = 102,
        #endregion

        #region 视频录制 200~300

        /// <summary>
        /// 开始视频录制
        /// </summary>
        StartVideoRecord = 17,

        /// <summary>
        /// 停止视频录制
        /// </summary>
        StopVideoRecord = 18,

        /// <summary>
        /// 开始视频录制异常
        /// </summary>
        StartVideoRecordException = 19,

        /// <summary>
        /// 停止视频录制正常
        /// </summary>
        StopVideoRecordException = 20,

        #endregion

        #region 设备登陆相关  300~400

        /// <summary>
        /// 设备登陆
        /// </summary>
        LoginStart = 21,
        /// <summary>
        /// 登陆中
        /// </summary>
        LogonIn =302,
        /// <summary>
        /// 登陆成功
        /// </summary>
        LoginSuccess = 22,
        /// <summary>
        /// 设备登录异常
        /// </summary>
        DevLoginException = 15,
        /// <summary>
        /// 用户信息验证失败
        /// </summary>
        UserAccessError = 12,

        /// <summary>
        /// 视频设备不在线
        /// 不在线属于状态,在这里定位为事件方便记录显示
        /// </summary>
        VideoDeviceNotOnline = 11,

        /// <summary>
        /// 无设备权限
        /// </summary>
        NoDeviceAuthority=301,
        #endregion

        /// <summary>
        /// 未知
        /// </summary>
        Unidentified=99999,
    }
}
