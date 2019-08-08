using System;
using System.Collections.Generic;
using System.Text;

namespace VideoCurrencyModule.RemotePlayback
{
    public struct RemoteBackplayFileInfo
    {
        /// <summary>
        /// 文件名
        /// </summary>
        public string FileName
        {
            get;
            set;
        }


        private long iStartTimeStamp;

        /// <summary>
        /// 开始时间戳(毫秒
        /// </summary>
        public long StartTimeStamp
        {
            get { return iStartTimeStamp; }
            set { iStartTimeStamp = value; }
        }


        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime
        {
            get
            {
                return PubMethod.UnixMillisecondsTimestampToDateTime(iStartTimeStamp);
            }
        }

        private long iEndTimeStamp;
        /// <summary>
        /// 结束时间戳(毫秒)
        /// </summary>
        public long EndTimeStamp
        {
            get { return iEndTimeStamp; }
            set { iEndTimeStamp = value; }
        }


        public DateTime EndTime
        {
            get
            {
                return PubMethod.UnixMillisecondsTimestampToDateTime(iEndTimeStamp);
            }
        }








    }
}
