using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放设置
    /// </summary>
    public class VideoPlaySetting
    {
        /// <summary>
        /// 视频录像使能
        /// </summary>
        private bool bolVideoRecordEnable = false;
        /// <summary>
        /// 视频录像使能
        /// </summary>
        public bool VideoRecordEnable
        {
            get { return bolVideoRecordEnable; }
            set { bolVideoRecordEnable = value; }
        }

        /// <summary>
        /// 音频使能
        /// </summary>
        private bool bolVideoMonitorEnable = false;
        /// <summary>
        /// 音频使能
        /// </summary>
        public bool VideoMonitorEnable
        {
            get { return bolVideoMonitorEnable; }
            set { bolVideoMonitorEnable = value; }
        }



        /// <summary>
        /// 预置点设置 -1 代表不设置预置点
        /// 注意：部分主机不包含预制点功能
        /// </summary> 
        private int intPreSetPosi = -1;

        /// <summary>
        /// 预制点设置 -1 代表不设置预置点
        /// 注意：部分主机不包含预制点功能
        /// </summary>
        public int PreSetPosi
        {
            get { return intPreSetPosi; }
            set { intPreSetPosi = value; }
        }
    }
}
