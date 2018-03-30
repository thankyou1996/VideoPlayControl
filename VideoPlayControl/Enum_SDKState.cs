using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// SDK状态枚举
    /// </summary>
    public enum Enum_SDKState
    {
        /// <summary>
        /// 释放异常
        /// </summary>
        SDK_ReleaseFail=-3,

        /// <summary>
        /// SDK_初始化异常
        /// </summary>
        SDK_InitFail = -2,

        /// <summary>
        /// SDK_释放
        /// </summary>
        SDK_Release = -1,

        /// <summary>
        /// SDK_空
        /// </summary>
        SDK_Null=0,

        /// <summary>
        /// SDK_初始化
        /// </summary>
        SDK_Init =1

    }
}
