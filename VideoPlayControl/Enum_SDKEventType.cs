using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// SDK事件类型枚举
    /// </summary>
    public enum Enum_SDKEventType
    {
        /// <summary>
        /// 未识别事件类型
        /// </summary>
        Unrecognized,

        /// <summary>
        /// 连接成功
        /// </summary>
        ConnectOK,

        /// <summary>
        /// 连接超时
        /// </summary>
        ConnectTimeOut,

        /// <summary>
        /// 连接正常断开
        /// </summary>
        DisconnectOK,

        /// <summary>
        /// 连接异常断开
        /// </summary>
        ConnectAbnormally,

        /// <summary>
        /// 用户验证失败
        /// </summary>
        UserAccessError

    }
}
