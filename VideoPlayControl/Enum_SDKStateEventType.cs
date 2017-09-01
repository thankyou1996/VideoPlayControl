using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// SDK状态事件回调类型
    /// </summary>
    public enum Enum_SDKStateEventType
    {
        /// <summary>
        /// SDK初始化开始
        /// </summary>
        SDKInitStart=1,

        /// <summary>
        /// SDK初始化结束
        /// </summary>
        SDKInitEnd=2,

        /// <summary>
        /// SDK释放开始
        /// </summary>
        SDKReleaseStart=3,

        /// <summary>
        /// SDK释放结束
        /// </summary>
        SDKReleaseEnd=4
    }
}
