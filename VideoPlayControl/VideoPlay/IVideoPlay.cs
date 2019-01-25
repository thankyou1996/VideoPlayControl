using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 视频播放接口抽象
    /// </summary>
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

        PictureBox PicPlayMain
        {
            get;
            set;
        }

        IntPtr intptrPlayMain
        {
            get;
        }

        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        Enum_VideoPlayState VideoPlayState
        {
            get;
            set;
        }

        /// <summary>
        /// 当前音频通道状态
        /// </summary>
        Enum_VideoPlaySoundState SoundState
        {
            get;
            //set;
        }

        /// <summary>
        /// 视频播放窗口宽度
        /// </summary>
        int VideoplayWindowWidth
        {
            get;
            set;
        }

        /// <summary>
        /// 视频播放窗口高度
        /// </summary>
        int VideoplayWindowHeight
        {
            get;
            set;
        }
        #region 事件

        /// <summary>
        /// 视频播放事件
        /// </summary>
        event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        /// <summary>
        /// 视频状态改变事件
        /// </summary>
        event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;
        #endregion


        bool VideoPlayCallback(VideoPlayCallbackValue value);

        /// <summary>
        /// 视频播放
        /// </summary>
        /// <returns></returns>
        bool VideoPlay();

        /// <summary>
        /// 视频播放异步
        /// </summary>
        /// <returns></returns>
        bool VideoPlayEx();

        bool VideoClose();


        bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart);
        void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom);

        #region 音频相关接口/事件

        /// <summary>
        /// 音频状态改变事件
        /// </summary>
        event SoundStateChangedDelegate SoundStateChangedEvent;

        /// <summary>
        /// 打开现场声音
        /// 不同于对讲 仅开启声音监听
        /// </summary>
        bool OpenSound();


        /// <summary>
        /// 关闭现场声音
        /// 不同于对讲 仅开启声音监听
        /// </summary>
        bool CloseSound();

        #endregion
    }
}
