using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    /// <summary>
    /// 视频抓图设置
    /// </summary>
    public struct VideoSnapSet
    {
        /// <summary>
        /// 抓图保存路径_本地 不包含文件文件名称
        /// </summary>
        public string SnapFilePath_Local
        {
            get;
            set;
        }
        /// <summary>
        /// 抓图保存名称_本地
        /// </summary>
        public string SnapFielName_Local
        {
            get;
            set;
        }

        /// <summary>
        /// 抓图保存路径_服务器 （通常为相对路径，因为无法知道服务器盘符分区等信息）
        /// </summary>
        public string SnapFilePath_Server
        {
            get;
            set;
        }

        /// <summary>
        /// 抓图保存名称_服务器
        /// </summary>
        public string SnapFileName_Server
        {
            get;
            set;
        }

    }
}
