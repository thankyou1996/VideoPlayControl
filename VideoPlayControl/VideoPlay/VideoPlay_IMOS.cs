using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 宇视视频
    /// </summary>
    class VideoPlay_IMOS : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }

        /// <summary>
        /// 当前码流类型
        /// </summary>
        private Enum_VideoStream videoStream = Enum_VideoStream.SubStream;
        /// <summary>
        /// 码流类型
        /// 如果当前处于视频播放状态 修改时会重新进入视频播放
        /// </summary>
        public Enum_VideoStream VideoStream
        {
            get { return videoStream; }
            set
            {
                SetVideoStream(value);
            }
        }
        /// <summary>
        /// 设置码流信息
        /// 如果当前处于视频播放状态 会关闭视频后 重新进入视频播放
        /// </summary>
        /// <param name="vs"></param>
        private void SetVideoStream(Enum_VideoStream vs)
        {
            if (vs != videoStream)
            {
                videoStream = vs;
                if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                {
                    //处于播放中 关闭视频后切换码流后播放
                    VideoClose();
                    VideoPlay();
                }
                VideoStreamChanged(null);
            }
        }

        /// <summary>
        /// 码流改变事件
        /// </summary>
        public event VideoStreamChangedDelegate VideoStreamChangedEvent;
        /// <summary>
        /// 码流改变
        /// </summary>
        /// <param name="VideoStreamChangedValue"></param>
        private void VideoStreamChanged(object VideoStreamChangedValue)
        {
            if (VideoStreamChangedEvent != null)
            {
                VideoStreamChangedEvent(this, VideoStreamChangedValue);
            }
        }
        private PictureBox picPlayMain = null;
        public PictureBox PicPlayMain
        {
            get
            {
                return picPlayMain;
            }

            set
            {
                picPlayMain = value;
                intptrPlayMain = picPlayMain.Handle;
            }
        }
        public IntPtr intptrPlayMain
        {
            get;
            private set;
        }
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;
        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState != value)
                {
                    videoPlayState = value;
                    if (VideoPlayStateChangedEvent != null)
                    {
                        VideoPlayStateChangedEvent(this, null);
                    }
                }
            }
        }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;

        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;

        public bool VideoClose()
        {
            UInt32 ulRet = 0;
            ulRet = SDK_IMOSSDK.IMOS_StopRecord(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            ulRet = SDK_IMOSSDK.IMOS_StopMonitor(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"), 0);
            ulRet = SDK_IMOSSDK.IMOS_StopPlay(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            ulRet = SDK_IMOSSDK.IMOS_FreeChannelCode(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"));
            VideoRecordStatus = false;
            return true;
        }

        public bool VideoPlay()
        {
            SDK_IMOSSDK.IMOS_StartMonitor(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, new byte[] { 0X00, 0X01 }, Encoding.Default.GetBytes("0"), 1, 0);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                SDK_IMOSSDK.IMOS_StartRecord(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"),Encoding.Default.GetBytes(CurrentVideoPlaySet.PreVideoRecordFilePath), 0);
                VideoRecordStatus = true;
            }
            return true;
        }

        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 联动预置点
        /// </summary>
        /// <param name="intPrestValue"></param>
        /// <returns></returns>
        public bool LinkagePresetPoint(int intPrestValue)
        {
            return false;
        }
        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            //throw new NotImplementedException();
        }


        #region 音频相关

        private Enum_VideoPlaySoundState soundState = Enum_VideoPlaySoundState.SoundColse;

        /// <summary>
        /// 音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState
        {
            get { return soundState; }
            set
            {
                if (soundState != value)
                {
                    soundState = value;
                    SoundStateChanged();
                }
            }
        }

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        public event SoundStateChangedDelegate SoundStateChangedEvent;

        /// <summary>
        /// 音频通道状态改变事件
        /// </summary>
        /// <returns></returns>
        private bool SoundStateChanged()
        {
            bool bolResult = false;
            if (this.SoundStateChangedEvent != null)
            {
                bolResult = SoundStateChangedEvent(this, null);
            }
            return bolResult;
        }

        /// <summary>
        /// 打开音频通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            return false;
        }

        /// <summary>
        /// 关闭音频通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            return false;
        }
        #endregion

        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        public event VideoRecordStatusChangedDelegate VideoRecordStausChangedEvent;
        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        /// <param name="VideoRecordStatusChangedValue"></param>
        private void VideoRecordStausChanged(object VideoRecordStatusChangedValue)
        {
            if (VideoRecordStausChangedEvent != null)
            {
                VideoRecordStausChangedEvent(this, VideoRecordStatusChangedValue);
            }
        }

        private bool bolVideoRecordStatus = false;
        /// <summary>
        /// 视频录像状态 true 表示正在录像 false表示未处于录像中
        /// </summary>
        public bool VideoRecordStatus
        {
            get { return bolVideoRecordStatus; }
            private set
            {
                if (bolVideoRecordStatus != value)
                {
                    bolVideoRecordStatus = value;
                    VideoRecordStausChanged(null);
                };
            }
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public bool StartVideoRecord(VideoRecordSet vrSet)
        {
            bool bolResult = true;
            CurrentVideoPlaySet.VideoRecordEnable = vrSet.Enable;
            CurrentVideoPlaySet.VideoRecordFilePath = vrSet.VideoRecordFilePath;
            CurrentVideoPlaySet.VideoRecordFileName = vrSet.VideoRecordFileName;
            CurrentVideoPlaySet.VideoRecordFilePath_Server = vrSet.VideoRecordFilePath_Server;
            CurrentVideoPlaySet.VideoRecordFileName_Server = vrSet.VideoRecordFileName_Server;
            CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond = vrSet.TimeOutVideoRecordCloseSecond;
            //关闭视频
            VideoClose();
            //打开视频
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 关闭录像（不关闭视频）
        /// </summary>
        /// <returns></returns>
        public bool StopVideoRecord()
        {
            bool bolResult = false;
            VideoClose();
            CurrentVideoPlaySet.VideoRecordEnable = false;
            VideoPlay();
            return bolResult;
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="snapSet"></param>
        /// <returns></returns>
        public bool Snap(VideoSnapSet snapSet)
        {
            bool bolResult = false;

            return bolResult;
        }
    }
}
