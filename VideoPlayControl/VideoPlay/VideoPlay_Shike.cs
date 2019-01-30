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
        /// 时刻设备视频关闭
        /// </summary>
        /// <returns></returns>
        public bool VideoClose()
        {
            bool bolResult = false;
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
                strRecordPath = GetServerSavePath(CurrentVideoPlaySet.VideoRecordFilePath_Server, CurrentVideoPlaySet.VideoRecordFileName_Server);
                intVideoRecordEnable = 1;
            }
            SDK_SKVideoSDK.p_sdkc_start_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel - 1, intptrPlayMain, intVideoRecordEnable, 15, 5, strRecordPath);
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
    }
}
