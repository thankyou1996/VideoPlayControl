using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.VideoRemoteBackplay.BasicClass;
using VideoPlayControl.VideoRemoteBackplay.Enum;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public interface IVIdeoRemoteBackplay
    {

        #region 状态

        /// <summary>
        /// 远程回放状态
        /// </summary>
        VideoRemoteBackplayStatus BackplayStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 远程回放状态改变
        /// </summary>
        event VideoRemoteBackplayStatusChangedDelegate VideoRemoteBackplayStatusChangedEvent;
        #endregion

        /// <summary>
        /// 播放控件
        /// </summary>
        PictureBox PicPlayMain
        {
            get;
            set;
        }

        /// <summary>
        ///  播放句柄
        /// </summary>
        IntPtr IntPtrPlayMain
        {
            get;
        }



        /// <summary>
        /// 当前视频信息
        /// </summary>
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }


        /// <summary>
        /// 当前通道信息
        /// </summary>
        CameraInfo CurrentCameraInfo
        {
            get;
            set;
        }

        #region 文件查找相关

        VideoRemoteFileInfo[] FindRemoteFile(VideoRemotePlaySearchPara para);
        #endregion

        #region 时间播放相关




        /// <summary>
        /// 开始远程回放时间段录像
        /// </summary>
        /// <param name="para"></param>
        /// <returns></returns>
        bool StartRemoteBackplayByTime(VideoRemotePlayByTimePara para);


        /// <summary>
        /// 停止远程回放时间段录像
        /// </summary>
        /// <returns></returns>
        bool StopRemoteBackplayByTime();


        #endregion


    }
}
