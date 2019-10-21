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
    /// 大华
    /// </summary>
    public class VideoPlay_DaHua : IVideoPlay
    {
        public VideoPlay_DaHua(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_DaHua(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }
        public VideoPlay_DaHua()
        {
            SDK_DaHua.DHCloseSoundEvent += SDK_DaHua_DHCloseSoundEvent;
        }

        /// <summary>
        /// 大华设备关闭对讲通道事件注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="objHikCloseSoundValue"></param>
        private void SDK_DaHua_DHCloseSoundEvent(object sender, object objHikCloseSoundValue)
        {
            SoundState = Enum_VideoPlaySoundState.SoundColse;
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


        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;
        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;

        private int intLoginID = 0;
        private int intPlayID = 0;
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }
        public bool VideoClose()
        {
            bool bolResult = false;
            if (SoundState == Enum_VideoPlaySoundState.SoundOpen)
            {
                //关闭音频
                CloseSound();
            }
            SDK_DaHua.CLIENT_StopSaveRealData(intPlayID);
            VideoRecordStatus = false;
            SDK_DaHua.CLIENT_StopRealPlay(intPlayID);
            SDK_DaHua.CLIENT_Logout(intLoginID);
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            SDKState.DHVideoSDK_Release();
            return bolResult;
        }

        /// <summary>
        /// 大华视频播放
        /// </summary>
        /// <returns></returns>
        public bool VideoPlay()
        {
            bool bolResult = false;
            if (SDKState.DHVideoSDKState != Enum_SDKState.SDK_Init)
            {
                SDKState.DHVideoSDK_Init();
            }
            SDK_DaHua.NET_DEVICEINFO deviceInfo = new SDK_DaHua.NET_DEVICEINFO();
            int intError;
            intLoginID = SDK_DaHua.CLIENT_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out deviceInfo, out intError);
            if (intLoginID != 0)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });
                if (CurrentVideoPlaySet.PlayStream == Enum_VideoStream.MainStream)
                {
                    intPlayID = SDK_DaHua.CLIENT_RealPlayEx(intLoginID, CurrentCameraInfo.Channel - 1, intptrPlayMain, SDK_DaHua.REALPLAY_TYPE.DH_RType_RealPlay);
                    videoStream = Enum_VideoStream.MainStream;
                }
                else
                {
                    intPlayID = SDK_DaHua.CLIENT_RealPlayEx(intLoginID, CurrentCameraInfo.Channel - 1, intptrPlayMain, SDK_DaHua.REALPLAY_TYPE.DH_RType_RealPlay_1);
                    videoStream = Enum_VideoStream.SubStream;
                }
                
                if (intPlayID != 0)
                {
                    if (CurrentVideoPlaySet.VideoMonitorEnable)
                    {
                        OpenSound();
                    }
                    if (CurrentVideoPlaySet.VideoRecordEnable)
                    {
                        string Temp_strVideoRecord = GetLocalSavePath(CurrentVideoPlaySet.VideoRecordFilePath, CurrentVideoPlaySet.VideoRecordFileName);
                        SDK_DaHua.CLIENT_SaveRealData(intPlayID, Temp_strVideoRecord);
                        VideoRecordStatus = true;
                    }
                    
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                }
                else
                {
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException });
                }
                
            }
            else
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
            }
            return bolResult;
        }

        /// <summary>
        /// 获取本地录像文件存储地址
        /// </summary>
        /// <param name="strSavePath"></param>
        /// <param name="strSaveName"></param>
        /// <returns></returns>
        public string GetLocalSavePath(string strSavePath, string strSaveName)
        {
            string strResult = strSavePath + strSaveName;
            if (!strResult.EndsWith(".dav"))
            {
                strResult = strSavePath + "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
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
        public void VideoSizeChange(int intPosX, int intPosY, int intWidth, int intHeight)
        {

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
        /// 打开音频通道_独占
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            //手动关闭，确认只有一个通道有声音
            SDK_DaHua.DHCloseSound(this, null);
            if (SDK_DaHua.CLIENT_OpenSound(intPlayID))
            {
                SoundState = Enum_VideoPlaySoundState.SoundOpen;
                bolResult = true;
            }
            return bolResult;
        }

        /// <summary>
        /// 关闭音频通道_独占
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            SDK_DaHua.DHCloseSound(this, null);
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
