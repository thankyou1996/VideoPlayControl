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
            return true;
        }

        public bool VideoPlay()
        {
            SDK_IMOSSDK.IMOS_StartMonitor(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, new byte[] { 0X00, 0X01 }, Encoding.Default.GetBytes("0"), 1, 0);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                SDK_IMOSSDK.IMOS_StartRecord(ref SDKState.IMOSLoginInfo.stUserLoginIDInfo, Encoding.Default.GetBytes("0"),Encoding.Default.GetBytes(CurrentVideoPlaySet.PreVideoRecordFilePath), 0);
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
        /// 视频播放中是否可以录像  
        /// （临时变量，true 表示StartVideoRecord有实现 false 表示没有具体实现 用于界面控制 ）
        /// </summary>
        public bool VideoPlayingRecordEnable
        {
            get { return true; }
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
    }
}
