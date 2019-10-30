using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Text;
using VideoPlayControl.VideoRecord;

namespace VideoPlayControl.VideoRecordBackplay
{
    /// <summary>
    /// 视频播放位置改变
    /// </summary>
    /// <param name="value"></param>
    /// <param name="fltPosValue"></param>
    public delegate void VideoRecodPosChangedDelegate(object value, float fltPosValue);
    public  interface IVideoRecordBackplay
    {
        /// <summary>
        /// 视频回放位置
        /// </summary>
        float VideoRecordPos
        {
            get;
            set;
        }

        /// <summary>
        /// 播放位置改变事件
        /// </summary>
        event VideoRecodPosChangedDelegate VideoRecodPosChangeEvnet;

        /// <summary>
        /// 视频文件信息
        /// </summary>
        VideoRecordInfo VideoRecordInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 播放窗口句柄
        /// </summary>
        IntPtr intptrPlayWnd
        {
            get;
            set;
        }

        
        /// <summary>
        /// 设置播放信息
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        bool SetVideoRecordInfo(VideoRecordInfo v);

        bool OpenVideoRecord();

        /// <summary>
        /// 播放
        /// </summary>
        /// <returns></returns>
        bool PlayVideoRecord();

        /// <summary>
        /// 关闭
        /// </summary>
        /// <returns></returns>
        bool CloseVideoRecord();

        /// <summary>
        /// 暂停
        /// </summary>
        /// <returns></returns>
        bool PauseVideoRecord();

        /// <summary>
        /// 设置播放位置信息
        /// </summary>
        /// <returns></returns>
        bool SetVideoRecordPos(float fltPosValue);

        /// <summary>
        /// 加快播放
        /// </summary>
        /// <returns></returns>
        bool PlayFast();

        /// <summary>
        /// 降低播放
        /// </summary>
        /// <returns></returns>
        bool PlaySlow();

    }
}
