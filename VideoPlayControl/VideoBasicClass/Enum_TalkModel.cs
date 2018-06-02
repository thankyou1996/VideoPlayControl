using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    public enum Enum_TalkModel
    {
        /// <summary>
        /// 侦听
        /// </summary>
        Interception=1,
        /// <summary>
        /// 喊话
        /// </summary>
        Sperak=2,

        /// <summary>
        /// 对讲
        /// </summary>
        Talkback=3,
    }

    public enum Enum_TalkStatus
    {
        /// <summary>
        /// 未出于任何状态
        /// </summary>
        Null=0,
        /// <summary>
        /// 侦听中
        /// </summary>
        Interceptioning = 1,
        /// <summary>
        /// 喊话中
        /// </summary>
        Speraking = 2,

        /// <summary>
        /// 对讲中
        /// </summary>
        Talkbacking = 3,
    }
}
