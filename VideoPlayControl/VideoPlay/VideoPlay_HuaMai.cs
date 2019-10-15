using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    public class VideoPlay_HuaMai : IVideoPlay
    {
        public VideoPlay_HuaMai(VideoInfo vInfo) : this(vInfo, vInfo.Cameras.First().Value)
        {

        }
        public VideoPlay_HuaMai(VideoInfo vInfo, CameraInfo cInfo)
        {
            CurrentVideoInfo = vInfo;
            CurrentCameraInfo = cInfo;
        }
        IntPtr iNode = IntPtr.Zero;
        IntPtr iDev = IntPtr.Zero;
        IntPtr iPort = IntPtr.Zero;
        IntPtr iOpenVideo = IntPtr.Zero;
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
            }
        }
        delegate IntPtr GetPicPlayMainHandleDelegate(PictureBox pic);
        public IntPtr GetPicPlayMainHandle(PictureBox pic)
        {
            if (pic.InvokeRequired)
            {
                GetPicPlayMainHandleDelegate delegate1 = new GetPicPlayMainHandleDelegate(GetPicPlayMainHandle);
                return (IntPtr)pic.Invoke(delegate1, new object[] { pic });
            }
            else
            {
                return pic.Handle;
            }
        }

        public IntPtr intptrPlayMain
        {
            get
            {
                if (PicPlayMain.IsHandleCreated)
                {
                    return GetPicPlayMainHandle(PicPlayMain);
                }
                return IntPtr.Zero;
            }
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
        public bool VideoClose()
        {
            SDK_HuaMai.hm_video_display_close_port(iPort);
            iPort = IntPtr.Zero;
            SDK_HuaMai.hm_pu_stop_video(iOpenVideo);
            SDK_HuaMai.hm_pu_close_video(iOpenVideo);
            iOpenVideo = IntPtr.Zero;
            SDK_HuaMai.hm_pu_logout(iDev);
            iDev = IntPtr.Zero;
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            return true;
        }

        public bool VideoPlay()
        {
            UInt32 iResult = 0;
            iResult = SDK_HuaMai.hm_server_find_device_by_sn(ProgParameter.HuaMai_iTree, CurrentVideoInfo.DVSAddress, ref iNode);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success
                || iNode == IntPtr.Zero)
            {
                //查询不到设备
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DeviceNotExist });
                return false;
            }

            SDK_HuaMai._CONNECT_INFO config = new SDK_HuaMai._CONNECT_INFO();
            config.ct = SDK_HuaMai.CLIENT_TYPE.CT_PC;
            config.cp = SDK_HuaMai.CONNECT_PRI.CPI_DEF;
            config.cm = SDK_HuaMai.CONNECT_MODE.CM_DEF;
            iResult = SDK_HuaMai.hm_pu_login_ex(iNode, ref config, ref iDev);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                //登录设备失败
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
                return false;
            }

            SDK_HuaMai._OPEN_VIDEO_PARAM para = new SDK_HuaMai._OPEN_VIDEO_PARAM();
            para.channel = Convert.ToUInt32(CurrentCameraInfo.Channel) - 1;
            para.cs_type = SDK_HuaMai.CODE_STREAM.HMS_CS_MAJOR;
            IntPtr iUserData = Marshal.StringToHGlobalAnsi("123");
            para.data = iUserData;
            para.vs_type = SDK_HuaMai.VIDEO_STREAM.HMS_VS_REAL;
            para.cb_data = new SDK_HuaMai.cb_pu_data(HuaMaiVideo_OnRecvRealTimeVideo);
            para.iWnd = picPlayMain.Handle;
            iResult = SDK_HuaMai.hm_pu_open_video(iDev, ref para, ref iOpenVideo);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                //打开视频失败
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnFailed });
                return false;
            }

            SDK_HuaMai.OPEN_VIDEO_RES videoRes = new SDK_HuaMai.OPEN_VIDEO_RES();
            iResult = SDK_HuaMai.hm_pu_start_video(iOpenVideo, ref videoRes);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                //开始播放视频异常
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException });
                return false;
            }
            SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //IntPtr iWnd = pictureBox1.Handle;
            iPort = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_video_display_open_port(this.intptrPlayMain, ref disp_op, ref iPort);
            iResult = SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
            return true;
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


        #region 回调函数
        private void HuaMaiVideo_OnRecvRealTimeVideo(IntPtr iUser, IntPtr iFrmae, UInt32 err)
        {
            if (err != Convert.ToUInt32(0))
            {
                return;
            }
            if (iPort == IntPtr.Zero)
            {
                return;
            }
            var result = Marshal.PtrToStructure(iFrmae, typeof(SDK_HuaMai._FRAME_DATA));
            SDK_HuaMai._FRAME_DATA Data = (SDK_HuaMai._FRAME_DATA)result;
            SDK_HuaMai._RAW_FRAME_TYPE Type = (SDK_HuaMai._RAW_FRAME_TYPE)Data.frame_info.frame_type;
            switch (Type)
            {
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_P:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_I:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_H265_P:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_H265_I:
                    SDK_HuaMai.hm_video_display_input_data(iPort, Data.frame_stream, Data.frame_len, true);
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;
                default:
                    //不做操作
                    break;
            }
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

