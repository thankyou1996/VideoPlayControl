using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoRemoteBackplay.Enum
{
    public enum VideoRemoteBackplayStatus
    {
        /// <summary>
        /// 待机状态
        /// </summary>
        StandBy=1,


        #region 文件回放相关枚举

        #endregion


        #region 时间回放相关枚举

        /// <summary>
        ///  时间回放开始开始前
        /// </summary>
        RemoteBackplayByTimeStarting=200,
        /// <summary>
        /// 时间回放开始后
        /// </summary>
        RemoteBackplayByTimeStarted,

        /// <summary>
        /// 时间回放结束前
        /// </summary>
        RemoteBackplayByTimeStoping,
        /// <summary>
        /// 时间回放结束后
        /// </summary>
        RemoteBackplayByTimeStoped,



        #endregion


    }
}
