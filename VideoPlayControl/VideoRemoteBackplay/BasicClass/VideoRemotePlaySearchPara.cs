using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    public class VideoRemotePlaySearchPara
    {
        int intChannel = 1;

        /// <summary>
        /// 通道号
        /// </summary>
        public int Channel
        {
            get { return intChannel; }
            set { intChannel = value; }
        }

        /// <summary>
        /// 开始查询时间
        /// </summary>
        public DateTime StartTime
        {
            get;
            set;
        }
        /// <summary>
        /// 结束查询时间
        /// </summary>
        public DateTime EndTime
        {
            get;
            set;
        }
    }
}
