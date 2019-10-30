using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoRecord
{
    /// <summary>
    /// 录像文件类型
    /// </summary>
    public enum Enum_VideoRecordFileType
    {

        /// <summary>
        /// 未识别
        /// </summary>
        Unrecognized = 0,

        /// <summary>
        /// 音频文件
        /// </summary>
        Video = 1,

        /// <summary>
        /// 视频文件
        /// </summary>
        Audio = 2,
        /// <summary>
        /// 音视频文件
        /// </summary>
        VideoAndAudio = 3,
    }


    /// <summary>
    /// 录像类型 录像 / 预录像
    /// </summary>
    public enum Enum_VideoRecordType
    {
        /// <summary>
        /// 普通录像
        /// </summary>
        OrdinaryRecord = 0,

        /// <summary>
        /// 报警录像
        /// </summary>
        AlarmRecord = 6,

        /// <summary>
        /// 预录像
        /// </summary>
        PrcRecord = 8,

        /// <summary>
        /// 硬盘录像
        /// </summary>
        DeskRecord = 9,
    }
}
