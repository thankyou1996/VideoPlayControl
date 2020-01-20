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
    public class IVideoPlay_Basic : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo 
        {
            get { return CurrentCameraInfo.VideoInfo; }
            set 
            { 
                //统一通过 CameraInfo 获取
            }
        }

        /// <summary>
        /// 当前码流类型
        /// </summary>
        private Enum_VideoStream videoStream = Enum_VideoStream.SubStream;
        public virtual Enum_VideoStream VideoStream 
        {
            get 
            {
                return videoStream;
            }
            set
            {
                SetVideoStream(value);
            }
        }


        public virtual void SetVideoStream(Enum_VideoStream vs)
        {
            videoStream = vs;
        }

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
                if (picPlayMain != null && picPlayMain.IsHandleCreated)
                {
                    intptrPlayMain = picPlayMain.Handle;
                }
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


        #region 音频相关

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
        /// 关闭声音
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            return false;
        }


        /// <summary>
        /// 打开声音
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            return false;
        }
        #endregion


        #region 录像相关

        private bool bolVideoRecordStatus = false;
        /// <summary>
        /// 视频录像状态 true 表示正在录像 false表示未处于录像中
        /// </summary>
        public bool VideoRecordStatus
        {
            get { return bolVideoRecordStatus; }
            set
            {
                if (bolVideoRecordStatus != value)
                {
                    bolVideoRecordStatus = value;
                    VideoRecordStausChanged(null);
                };
            }
        }



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



        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public virtual bool StartVideoRecord(VideoRecordSet vrSet)
        {
            return false;
        }

        /// <summary>
        /// 停止录像
        /// </summary>
        /// <returns></returns>
        public virtual bool StopVideoRecord()
        {
            return false;
        }

        #endregion


        #region 云台相关

        /// <summary>
        /// 联动预置点
        /// </summary>
        /// <param name="intPrestValue"></param>
        /// <returns></returns>
        public virtual bool LinkagePresetPoint(int intPrestValue)
        {
            return false;
        }



        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        /// <returns></returns>
        public virtual bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return false;
        }

        #endregion

        public event VideoStreamChangedDelegate VideoStreamChangedEvent;

        /// <summary>
        /// 码流改变
        /// </summary>
        /// <param name="VideoStreamChangedValue"></param>
        public virtual void VideoStreamChanged(object VideoStreamChangedValue)
        {
            if (VideoStreamChangedEvent != null)
            {
                VideoStreamChangedEvent(this, VideoStreamChangedValue);
            }
        }
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;
        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;
        public event SoundStateChangedDelegate SoundStateChangedEvent;


        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="snapSet"></param>
        /// <returns></returns>
        public virtual bool Snap(VideoSnapSet snapSet)
        {
            return false;
        }

        /// <summary>
        /// 关闭视频
        /// </summary>
        /// <returns></returns>
        public virtual bool VideoClose()
        {
            return false;
        }

        /// <summary>
        /// 播放视频
        /// </summary>
        /// <returns></returns>
        public virtual bool VideoPlay()
        {
            return false;
        }

        /// <summary>
        /// 播放视频
        /// </summary>
        /// <returns></returns>
        public virtual bool VideoPlay(VideoPlaySetting vps)
        {
            CurrentVideoPlaySet = vps;
            VideoPlay();
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            switch (value.evType)
            {
                case Enum_VideoPlayEventType.LoginStart:
                case Enum_VideoPlayEventType.LogonIn:
                case Enum_VideoPlayEventType.ConnSuccess:
                case Enum_VideoPlayEventType.LoginSuccess:
                    this.VideoPlayState = Enum_VideoPlayState.Connecting;
                    break;


                case Enum_VideoPlayEventType.DevLoginException:
                case Enum_VideoPlayEventType.UserAccessError:
                case Enum_VideoPlayEventType.VideoClose:
                    this.VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                    break;

                case Enum_VideoPlayEventType.VideoPlay:
                    this.VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;
                case Enum_VideoPlayEventType.InitEnd:
                    break;
                case Enum_VideoPlayEventType.LoadEnd:
                    break;
                case Enum_VideoPlayEventType.SetVideoInfo:
                    break;
                case Enum_VideoPlayEventType.VideoTypeNotExists:
                    break;
                case Enum_VideoPlayEventType.DeviceNotExist:
                    break;
                case Enum_VideoPlayEventType.VideoPlayException:
                    break;
                case Enum_VideoPlayEventType.RequestConn:
                    break;
                case Enum_VideoPlayEventType.ConnFailed:
                    break;
                case Enum_VideoPlayEventType.RequestVideoTimeout:
                    break;
                case Enum_VideoPlayEventType.ConnNumMax:
                    break;
                case Enum_VideoPlayEventType.DeviceStreamTypeException:
                    break;
                case Enum_VideoPlayEventType.TimtOutVideoClose:
                    break;
                case Enum_VideoPlayEventType.StartVideoRecord:
                    break;
                case Enum_VideoPlayEventType.StopVideoRecord:
                    break;
                case Enum_VideoPlayEventType.StartVideoRecordException:
                    break;
                case Enum_VideoPlayEventType.StopVideoRecordException:
                    break;
                case Enum_VideoPlayEventType.TimtOutVideoRecordClose:
                    break;
                case Enum_VideoPlayEventType.VideoDeviceNotOnline:
                    break;
                case Enum_VideoPlayEventType.NoDeviceAuthority:
                    break;
                case Enum_VideoPlayEventType.Unidentified:
                    break;
                default:
                    break;
            }
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        /// <summary>
        /// 视频播放异步
        /// </summary>
        /// <returns></returns>
        public virtual bool VideoPlayEx()
        {
            return false;
        }
        /// <summary>
        /// 播放窗口尺寸改变
        /// </summary>
        /// <param name="intLeft"></param>
        /// <param name="intRight"></param>
        /// <param name="intTop"></param>
        /// <param name="intBottom"></param>
        public virtual void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {

        }
    }
}
