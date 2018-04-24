using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoPlay
{
    public interface IVideoPlay
    {


        /// <summary>
        /// 当前视频视频设备信息
        /// </summary>
        VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 当前摄像头信息
        /// </summary>
        CameraInfo CurrentCameraInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 当前播放设置
        /// </summary>
        VideoPlaySetting CurrentVideoPlaySet
        {
            get;
            set;
        }

        IntPtr intptrPlayMain
        {
            get;
            set;
        }

        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        Enum_VideoPlayState VideoPlayState
        {
            get;
            set;
        }
        event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;

      
        bool VideoPlay();

        bool VideoClose();
    }
}
