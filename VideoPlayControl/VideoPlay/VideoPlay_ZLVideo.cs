using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 智诺视频设备
    /// </summary>
    public class VideoPlay_ZLVideo : IVideoPlay
    {
        public VideoPlay_ZLVideo()
        {
            SDK_ZLNetSDK.ZLCloseSoundEvent += SDK_ZLNetSDK_ZLCloseSoundEvent;
        }

        /// <summary>
        /// 海康设备关闭对讲通道事件注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="objHikCloseSoundValue"></param>
        private void SDK_ZLNetSDK_ZLCloseSoundEvent(object sender, object objHikCloseSoundValue)
        {
            SoundState = Enum_VideoPlaySoundState.SoundColse;
        }

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

        private int m_nDeviceID = 0;
        private int m_nPlayHandle = 0;
        /// <summary>
        /// 智诺视频关闭
        /// </summary>
        /// <returns></returns>
        public bool VideoClose()
        {
            bool bolResult = false;
            if (m_nPlayHandle != 0)
            {
                if (SoundState == Enum_VideoPlaySoundState.SoundOpen)
                {
                    //关闭音频
                    CloseSound();
                }
                SDK_ZLNetSDK.ZLNET_StopSaveRealData(m_nPlayHandle);
                VideoRecordStatus = false;
                SDK_ZLNetSDK.ZLNET_StopRealPlayEx(m_nPlayHandle);
            }
            if (m_nDeviceID != 0)
            {
                SDK_ZLNetSDK.ZLNET_Logout(m_nDeviceID);
            }
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            return bolResult;
        }

        /// <summary>
        /// 智诺视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            int err = 0;
            SDK_ZLNetSDK.ZLNET_DEVICEINFO zlDevice = new SDK_ZLNetSDK.ZLNET_DEVICEINFO();
            m_nDeviceID = SDK_ZLNetSDK.ZLNET_LoginEx(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, 0, (IntPtr)0, ref zlDevice, ref err);
            if (m_nDeviceID > 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });
                m_nPlayHandle = SDK_ZLNetSDK.ZLNET_RealPlayEx(m_nDeviceID, CurrentCameraInfo.Channel - 1, intptrPlayMain);
                if (CurrentVideoPlaySet.VideoMonitorEnable)
                {
                    OpenSound();
                }
                if (CurrentVideoPlaySet.VideoRecordEnable)  //录像使能
                {
                    string Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, CurrentVideoPlaySet.VideoRecordFileName);
                    SDK_ZLNetSDK.ZLNET_SaveRealData(m_nPlayHandle, Temp_strVideoRecord);
                    VideoRecordStatus = true;
                }
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                VideoPlayState = Enum_VideoPlayState.InPlayState;
            }
            else
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
            }
            return bolResult;
        }

        public string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            string strResult = strSavePath + strSaveName;
            if (!strSaveName.EndsWith(".dav"))
            {
                strResult = strSavePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            return strResult;
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
        /// 打开音频通道_独占
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            //实际测试，打开声音通道程序并不会关闭之前的声音通道，手动关闭，确认仅有一个通在播放
            SDK_ZLNetSDK.ZLCloseSound(this, null);  
            if (SDK_ZLNetSDK.ZLNET_OpenSound(m_nPlayHandle))
            {
                SoundState = Enum_VideoPlaySoundState.SoundOpen;
                bolResult = true;
            }
            return bolResult;
        }
        /// <summary>
        /// 打开音频通道_独占
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            SDK_ZLNetSDK.ZLCloseSound(this, null);
            return bolResult;
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
