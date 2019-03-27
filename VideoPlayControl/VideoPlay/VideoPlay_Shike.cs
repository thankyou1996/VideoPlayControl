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
    /// 时刻
    /// </summary>
    public class VideoPlay_Shike : IVideoPlay
    {
        public VideoPlay_Shike(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_Shike(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }
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
        /// 时刻设备视频关闭
        /// </summary>
        /// <returns></returns>
        public bool VideoClose()
        {
            bool bolResult = false;
            if (VideoRecordStatus)
            {
                VideoRecordStatus = false;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StopVideoRecord });
            }
            SDK_SKVideoSDK.p_sdkc_stop_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, intptrPlayMain);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            return bolResult;
        }

        /// <summary>
        /// 时刻设备视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            string strRecordPath = "";
            int intVideoRecordEnable = 0;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.StartVideoRecord });
                strRecordPath = GetServerSavePath(CurrentVideoPlaySet.VideoRecordFilePath_Server, CurrentVideoPlaySet.VideoRecordFileName_Server);
                intVideoRecordEnable = 1;
                VideoRecordStatus = true;
            }
            int Temp_intStreamValue = GetVideoStreamValue(VideoStream);
            SDK_SKVideoSDK.p_sdkc_start_rt_video_ex(
                CurrentVideoInfo.DVSAddress,
                CurrentCameraInfo.Channel - 1,
                intptrPlayMain, 
                intVideoRecordEnable, 
                30, 
                5, 
                Temp_intStreamValue, 
                strRecordPath);

            if (CurrentVideoPlaySet.PerVideoRecord)
            {
                SDK_SKVideoSDK.p_sdkc_get_revideo_data(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, CurrentVideoPlaySet.PreVideoRecordFilePath);
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return bolResult;
        }


        private string GetServerSavePath(string strSavePath, string strSaveName)
        {
            if (!strSaveName.ToLower().EndsWith(".h264"))
            {
                if (string.IsNullOrEmpty(strSaveName))
                {
                    strSaveName = VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel - 1, CurrentVideoInfo.VideoType);
                }
                else
                {
                    strSaveName = strSaveName + ".H264";
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
        /// 时刻设备_云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        /// <returns></returns>
        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            bool bolResult = false;
            if (bolStart)
            {
                int Temp_iXSpeed = 0;
                int Temp_iYSpeed = 0;
                int Temp_iZSpeed = 0;
                switch (PTZControl)
                {
                    case Enum_VideoPTZControl.PTZControl_Up:
                        Temp_iXSpeed = 0;
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Down:
                        Temp_iXSpeed = 0;
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Left:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = 0;
                        break;
                    case Enum_VideoPTZControl.PTZControl_Right:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = 0;
                        break;
                    case Enum_VideoPTZControl.PTZControl_LeftUp:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_LeftDown:
                        Temp_iXSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_RightUp:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = CurrentVideoPlaySet.PTZSpeed;
                        break;
                    case Enum_VideoPTZControl.PTZControl_RightDown:
                        Temp_iXSpeed = CurrentVideoPlaySet.PTZSpeed;
                        Temp_iYSpeed = -CurrentVideoPlaySet.PTZSpeed;
                        break;
                }
                SDK_SKVideoSDK.p_sdkc_onvif_ptz_continue_move(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, Temp_iXSpeed, Temp_iYSpeed, Temp_iZSpeed);
            }
            else
            {
                SDK_SKVideoSDK.p_sdkc_onvif_ptz_stop(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1);
            }

            return bolResult;
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
            //bool bolResult=
            //throw new NotImplementedException();
        }

        public bool VideoPlayEx()
        {
            throw new NotImplementedException();
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
            if (VideoRecordStatus)
            {
                VideoClose();
                CurrentVideoPlaySet.VideoRecordEnable = false;
                VideoPlay();
            }
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

        #region 静态方法

        public static int GetVideoStreamValue(Enum_VideoStream vs )
        {
            int intValue = 0;
            switch (vs)
            {
                case Enum_VideoStream.MainStream:
                    intValue = 1;
                    break;
                case Enum_VideoStream.SubStream:
                    intValue = 0;
                    break;
            }
            return intValue;
        }
        #endregion
    }
}
