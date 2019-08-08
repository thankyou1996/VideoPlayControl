using System;
using System.Collections.Generic;
using System.Text;

namespace VideoCurrencyModule.RemotePlayback
{
    public struct VideoChannelRemoteBackplayInfo
    {
        /// <summary>
        /// 通道信息
        /// </summary>
        public PublicClassCurrency.CameraInfo ChnnelInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime EndTime
        {
            get;
            set;
        }
        /// <summary>
        /// 回放文件信息
        /// </summary>

        public List<RemoteBackplayFileInfo> BackplayFiles
        {
            get;
            set;
        }
    }
}
