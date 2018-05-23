using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoBasicClass
{
    public class RemoteVideoRecordInfo
    {
        private string strVideoGUID = "";

        /// <summary>
        /// 视频设备唯一码
        /// </summary>
        public string VideoGUID
        {
            get { return strVideoGUID; }
            set { strVideoGUID = value; }
        }

        /// <summary>
        ///视频地址
        /// </summary>
        private string strVideoAddress;

        /// <summary>
        /// 视频设备地址
        /// </summary>
        public string VideoAddress
        {
            get { return strVideoAddress; }
            set { strVideoAddress = value; }
        }
        /// <summary>
        /// 通道
        /// </summary>
        private int intChannel = 0;
        /// <summary>
        /// 通道
        /// </summary>
        public int Channel
        {
            get { return intChannel; }
            set { intChannel = value; }
        }

        /// <summary>
        /// 远程录像文件名称
        /// </summary>
        private string strRemoteVideoRecordName;

        /// <summary>
        /// 远程录像文件名称
        /// </summary>
        public string RemoteVidoRecordName
        {
            get { return strRemoteVideoRecordName; }
            set { strRemoteVideoRecordName = value; }
        }

        /// <summary>
        /// 远程录像文件大小
        /// </summary>
        private int intRemoteVideoRecordSize = 0;
        /// <summary>
        /// 远程录像文件大小
        /// </summary>
        public int RemoteVideoRecordSize
        {
            get { return intRemoteVideoRecordSize; }
            set { intRemoteVideoRecordSize = value; }
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
        /// 停止事件
        /// </summary>
        private DateTime timEndTime;

        /// <summary>
        /// 停止时间
        /// </summary>
        public DateTime EndTime
        {
            get { return timEndTime; }
            set { timEndTime = value; }
        }

        /// <summary>
        /// 下载状态
        /// </summary>
        private int intDownLoadStatus = 0;

        /// <summary>
        /// 下载状态
        /// </summary>
        public int DownLoadStatus
        {
            get { return intDownLoadStatus; }
            set { intDownLoadStatus = value; }
        }

    }
}
