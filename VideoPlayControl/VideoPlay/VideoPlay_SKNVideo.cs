using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 时刻H265
    /// </summary>
    public class VideoPlay_SKNVideo : IVideoPlay
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
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }


        /// <summary>
        /// 视频关闭
        /// </summary>
        /// <returns></returns>
        public bool VideoClose()
        {
            bool bolResult = false;
            SDK_SKNVideo.SDK_NSK_CLIENT_close_rt_video(intptrPlayMain);
            VideoRecordStatus = false;
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }
        /// <summary>
        /// 视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            string Temp_strVideoRecord = null;
            string Temp_strServerVideoRecord = null;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //启用录像
                Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, "");
                Temp_strServerVideoRecord = GetServerSavePath(CurrentVideoPlaySet.VideoRecordFilePath_Server, CurrentVideoPlaySet.VideoRecordFileName_Server);
                VideoRecordStatus = true;
            }

            SDK_SKNVideo.SDK_NSK_CLIENT_open_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, 1, intptrPlayMain, Temp_strVideoRecord, Temp_strServerVideoRecord);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return bolResult;
        }

        /// <summary>
        /// 获取服务器保存地址
        /// </summary>
        /// <returns></returns>
        private string GetServerSavePath(string strSavePath, string strSaveName)
        {
            if (!strSaveName.EndsWith(".h264"))
            {
                if (string.IsNullOrEmpty(strSaveName))
                {
                    strSaveName = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
                }
                else
                {
                    strSaveName = strSaveName + ".h264";
                }
            }
            if (strSavePath.Length > 2 && !strSaveName.EndsWith("\\"))
            {
                strSavePath = strSavePath + "\\";
            }
            string strResult = strSavePath + strSaveName;
            if (!strResult.StartsWith("\\"))
            {
                strResult = "\\" + strResult;
            }
            return strResult;
        }

        /// <summary>
        /// 获取客户端保存地址 (完整路径)
        /// </summary>
        /// <param name="strSavePath"></param>
        /// <param name="strSaveName"></param>
        /// <returns></returns>
        private string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            if (string.IsNullOrEmpty(strSaveName) || strSaveName.ToLower().EndsWith(".h264"))
            {
                strSaveName = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            string strResult = strSavePath + "\\" + strSaveName;
            return strResult;
        }

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return false;
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
            //return false;
        }

        public bool VideoPlayEx()
        {
            //throw new NotImplementedException();
            return false;
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
    }
}
