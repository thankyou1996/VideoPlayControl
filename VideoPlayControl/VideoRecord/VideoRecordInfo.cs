using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoRecord
{
    /// <summary>
    /// 视频录像记录信息
    /// </summary>
    public class VideoRecordInfo
    {

        /// <summary>
        /// 视频类型
        /// </summary>
        public Enum_VideoType VideoType = Enum_VideoType.Unrecognized;


        /// <summary>
        ///  录像类型
        /// </summary>
        public Enum_VideoRecordType VideoRecordType = Enum_VideoRecordType.OrdinaryRecord;


        /// <summary>
        /// 视频设备类型
        /// </summary>
        public Enum_VideoRecordFileType VideoRecordFileType = Enum_VideoRecordFileType.Unrecognized;

        /// <summary>
        /// 视频设备编号
        /// </summary>
        private string strDVSNumber = "";

        /// <summary>
        /// 视频设备编号
        /// </summary>
        public string DVSNumber
        {
            get { return strDVSNumber; }
            set { strDVSNumber = value; }
        }

        /// <summary>
        /// 通道号
        /// </summary>
        private int intChannel = 0;

        /// <summary>
        /// 通道号
        /// </summary>
        public int Channel
        {
            get { return intChannel; }
            set { intChannel = value; }
        }

        /// <summary>
        /// 视频文件地址
        /// </summary>
        private string strRecordPath = "";

        /// <summary>
        /// 视频文件地址
        /// </summary>
        public string RecordPath
        {
            get { return strRecordPath; }
            set { strRecordPath = value; }
        }

        /// <summary>
        /// 起始时间
        /// </summary>
        private DateTime timStartTime;

        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime StartTime
        {
            get { return timStartTime; }
            set { timStartTime = value; }
        }

        /// <summary>
        /// 终止时间
        /// </summary>
        private DateTime timEndTime;
        /// <summary>
        /// 终止时间
        /// </summary>
        public DateTime EndTime
        {
            get { return timEndTime; }
            set { timEndTime = value; }
        }


        /// <summary>
        /// 文件大小 byte
        /// </summary>
        private int intFileSize;

        /// <summary>
        /// 文件大小 byte
        /// </summary>
        public int FileSize
        {
            get { return intFileSize; }
            set { intFileSize = value; }
        }

    }
}
