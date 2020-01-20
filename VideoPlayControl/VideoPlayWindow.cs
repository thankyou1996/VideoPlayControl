using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;
using VideoPlayControl.VideoPlay;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.Enum;
using System.Linq;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放窗口
    /// </summary>
    public partial class VideoPlayWindow : UserControl, IVideoPlay
    {
        #region 常量 
        /// <summary>
        /// 声音打开
        /// </summary>
        private const string c_strSoundOn = "Sound_On";
        /// <summary>
        /// 声音关闭 
        /// </summary>
        private const string c_strSoundOff = "Sound_Off";

        #endregion

        #region 全局变量
        System.Threading.Timer timTimeOutVideoClose;
        System.Threading.Timer timTimeOutVideoRecordClose;
        /// <summary>
        /// 当前视频视频设备信息
        /// </summary>
        public VideoInfo CurrentVideoInfo
        {
            get;
            set;
        }

        /// <summary>
        /// 当前摄像头信息
        /// </summary>
        public CameraInfo CurrentCameraInfo { get; set; }

        IVideoPlay iv;
        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;

        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState == value)
                {
                    return;
                }
                videoPlayState = value;
                switch (videoPlayState)
                {
                    case Enum_VideoPlayState.InPlayState:
                        //触发事件
                        TimeOutTimerDispose();  //视频定时器资源，避免重复触发
                        CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond = CurrentVideoInfo.VideoRecordTimeConstraintSecond;
                        CurrentVideoPlaySet.TimeOutVideoCloseSecond = CurrentVideoInfo.VideoPlayTimeConstraintSecond;
                        //启动视频播放事件定时器
                        if (CurrentVideoPlaySet.VideoRecordEnable && CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond > 0)
                        {
                            timTimeOutVideoRecordClose = new System.Threading.Timer(new TimerCallback(timTimeOutVideoRecordClose_Event), null, CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond * 1000, Timeout.Infinite);
                        }
                        else if (CurrentVideoPlaySet.TimeOutVideoCloseSecond > 0)
                        {
                            timTimeOutVideoClose = new System.Threading.Timer(new TimerCallback(timTimtOutVideoClose_Event), null, CurrentVideoPlaySet.TimeOutVideoCloseSecond * 1000, Timeout.Infinite);
                        }
                        break;
                }
            }
        }

        #region 视频超时关闭相关设置 （分为两种 1.视频浏览超时设置  2.录像超时设置）
        /************************************************** 
        1.分为浏览现场视频超时和录像超时
        2.视频录像超时同样是关闭视频浏览 
        3.两种设置均存在的情况以 录像超时为准
        **************************************************/


        /// <summary>
        /// 视频播放超时关闭事件
        /// </summary>
        /// <param name="sender"></param>
        private void timTimtOutVideoClose_Event(object sender)
        {
            if (!IsHandleCreated)
            {
                VideoClose();
                return;
            }
            this.BeginInvoke(new EventHandler(delegate
            {
                VideoClose();
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.TimtOutVideoClose, EventContent = "超出视频录像设置时间，关闭视频" });
            }));
        }

        /// <summary>
        /// 视频播放录像超时关闭事件
        /// </summary>
        /// <param name="objTimeOutVideoRecordValue"></param>
        public void timTimeOutVideoRecordClose_Event(object objTimeOutVideoRecordValue)
        {
            if (!IsHandleCreated)
            {
                VideoClose();
                return;
            }
            this.BeginInvoke(new EventHandler(delegate
            {
                VideoClose();
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.TimtOutVideoRecordClose, EventContent = "超出视频录像设置时间，关闭视频" });
            }));
        }

        /// <summary>
        /// 播放/录像 播放超时控件释放
        /// </summary>
        /// <returns></returns>
        public bool TimeOutTimerDispose()
        {
            bool bolResult = false;
            //关闭视频，同时关闭超时关闭计时器
            if (timTimeOutVideoClose != null)
            {
                timTimeOutVideoClose.Dispose();
                timTimeOutVideoClose = null;
            }
            if (timTimeOutVideoRecordClose != null)
            {
                timTimeOutVideoRecordClose.Dispose();
                timTimeOutVideoRecordClose = null;
            }
            return bolResult;
        }

        #endregion




        private VideoPlaySetting currentVideoPlaySet = new VideoPlaySetting();

        /// <summary>
        /// 当前播放设置
        /// </summary>
        public VideoPlaySetting CurrentVideoPlaySet
        {
            get
            {
                if (iv != null)
                {
                    return iv.CurrentVideoPlaySet;
                }
                return currentVideoPlaySet;
            }
            set
            {
                currentVideoPlaySet = value;
                if (iv != null)
                {
                    iv.CurrentVideoPlaySet = currentVideoPlaySet;
                }
            }
        }

        /// <summary>
        /// 当前连接次数
        /// </summary>
        public int intConnCount;
        #endregion
        /// <summary>
        /// 播放的控件
        /// </summary>

        public PictureBox PicMain
        {
            get { return picPlayMain; }
            set { picPlayMain = value; }
        }

        public VideoPlayWindow()
        {
            InitializeComponent();
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.InitEnd });
        }

        #region 视频播放回调事件
        /// <summary>
        /// 视频播放回调事件
        /// </summary>
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;
        public event VideoPlayStateChangedDelegate VideoPlayStateChangedEvent;
        public event SoundStateChangedDelegate SoundStateChangedEvent;

        /// <summary>
        /// 视频播放回调事件
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool VideoPlayCallback(VideoPlayCallbackValue value)
        {
            bool bolResult = false;
            switch (value.evType)      //部分特殊处理
            {
                case Enum_VideoPlayEventType.RequestVideoTimeout:
                    if (CurrentVideoPlaySet.AutoReconn)
                    {
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            VideoClose();
                            VideoPlay();
                        }));
                    }
                    break;
            }
            if (VideoPlayCallbackEvent != null)
            {
                return VideoPlayCallbackEvent(this, value);
            }
            return bolResult;
        }

        #endregion


        ///// <summary>
        ///// 当前码流类型
        ///// </summary>
        //private Enum_VideoStream videoStream = Enum_VideoStream.SubStream;
        /// <summary>
        /// 当前码流类型
        /// </summary>
        public Enum_VideoStream VideoStream
        {
            get
            {
                if (iv == null)
                {
                    return Enum_VideoStream.SubStream;
                }
                return iv.VideoStream;
            }
            set
            {
                if (iv != null)
                {
                    iv.VideoStream = value;
                }
            }
        }

        /// <summary>
        /// 码流改变事件
        /// </summary>
        private event VideoStreamChangedDelegate videoStreamChangedEvent;
        /// <summary>
        /// 码流改变事件
        /// </summary>
        public event VideoStreamChangedDelegate VideoStreamChangedEvent
        {
            add
            {
                videoStreamChangedEvent += value;
                if (iv != null)
                {
                    iv.VideoStreamChangedEvent += value;
                }


            }
            remove
            {
                videoStreamChangedEvent -= value;
                if (iv != null)
                {
                    iv.VideoStreamChangedEvent -= value;
                }

            }
        }


        private void VideoPlayMain_Load(object sender, EventArgs e)
        {
            intptrPlayMain = picPlayMain.Handle;
            this.Disposed += VideoPlayWindow_Disposed;
            if (this.ParentForm != null)
            {
                this.ParentForm.Move += ParentForm_Move;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoadEnd });
        }

        private void ParentForm_Move(object sender, EventArgs e)
        {
            if (CurrentVideoInfo != null)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.IPCWA:
                        if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                        {
                            //axRASPlayerOCX1.();
                        }
                        break;
                    default:
                        iv.VideoSizeChange(0, picPlayMain.Width, 0, picPlayMain.Bottom);
                        break;
                }
            }
        }

        private void VideoPlayWindow_Disposed(object sender, EventArgs e)
        {
            VideoClose();
        }

        #region  视频设备基本信息赋值

        public virtual void Init_VideoInfo(VideoInfo videoInfo)
        {

            Init_VideoInfo(videoInfo, videoInfo.Cameras.First().Value);
        }

        public virtual void Init_VideoInfo(VideoInfo videoInfo, int intChannel)
        {
            Init_VideoInfo(videoInfo, videoInfo.Cameras[intChannel]);
        }
        public virtual void Init_VideoInfo(VideoInfo vInfo, CameraInfo cInfo)
        {
            Init_VideoInfo(vInfo, cInfo, currentVideoPlaySet);
        }

        public virtual void Init_VideoInfo(VideoInfo vInfo, VideoPlaySetting videoPlaySet)
        {
            Init_VideoInfo(vInfo, vInfo.Cameras.First().Value, videoPlaySet);
        }

        public virtual void Init_VideoInfo(VideoInfo videoInfo, CameraInfo cameraInfo, VideoPlaySetting videoPlaySet)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState 
                || VideoPlayState==Enum_VideoPlayState.Connecting)
            {
                VideoClose();
            }
            CurrentVideoInfo = videoInfo;
            intConnCount = 0;
            CurrentCameraInfo = cameraInfo;
            CurrentVideoPlaySet = videoPlaySet;
            if (VideoPlayState == Enum_VideoPlayState.VideoInfoNull)
            {
                VideoPlayState = Enum_VideoPlayState.VideoInfoInit;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.SetVideoInfo });
            InterfaceInit();
        }
        

        private void InterfaceInit()
        {
            if (iv != null && iv.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                iv.VideoClose();
            }
            Enum_VideoType Temp_videoType = CurrentVideoInfo.VideoType;
            if (ProgParameter.TransitionEnable && Temp_videoType == Enum_VideoType.Unrecognized)
            {
                Temp_videoType = Transition.Transition_VideoTypeConvert.GetVideoType(CurrentVideoInfo);
            }
            if (iv == null)
            {
                IVideoPlayInit(Temp_videoType, CurrentVideoInfo, CurrentCameraInfo);
            }
            else
            {
                iv.VideoPlayCallbackEvent -= VideoPlayCallbackEvent;
                iv.VideoRecordStausChangedEvent -= videoRecordStausChangedEvent;
                iv.VideoStreamChangedEvent -= videoStreamChangedEvent;
                if (iv.CurrentVideoInfo.VideoType != Temp_videoType)
                {
                    iv = null;
                    IVideoPlayInit(Temp_videoType, CurrentVideoInfo, CurrentCameraInfo);
                }
            }
            if (iv != null)
            {
                iv.PicPlayMain = this.picPlayMain;
                iv.CurrentVideoInfo = CurrentVideoInfo;
                iv.CurrentCameraInfo = CurrentCameraInfo;
                iv.CurrentVideoPlaySet = currentVideoPlaySet;
                iv.VideoplayWindowWidth = picPlayMain.Width;
                iv.VideoplayWindowHeight = picPlayMain.Height;
                iv.VideoPlayCallbackEvent -= VideoPlayCallbackEvent;
                iv.VideoPlayCallbackEvent += VideoPlayCallbackEvent;
                iv.VideoPlayCallbackEvent += Iv_VideoPlayCallbackEvent;
                iv.VideoPlayStateChangedEvent -= Iv_VideoPlayStateChangedEvent;
                iv.VideoPlayStateChangedEvent += Iv_VideoPlayStateChangedEvent;
                iv.SoundStateChangedEvent += Iv_SoundStateChangedEvent;
                iv.VideoRecordStausChangedEvent += videoRecordStausChangedEvent;
                iv.VideoStreamChangedEvent += videoStreamChangedEvent;
            }
        }

        public void IVideoPlayInit(Enum_VideoType videoType,VideoInfo vInfo,CameraInfo cInfo)
        {
            switch (videoType)
            {
                case Enum_VideoType.HikDVR:
                    if (vInfo.VideoConnectType == 3)    //流媒体模式
                    {
                        iv = new VideoPlay_HikStream(vInfo, cInfo);
                    }
                    else
                    {
                        iv = new VideoPlay_HikDVR(vInfo, cInfo);
                    }
                    break;
                case Enum_VideoType.HikDVRStream:

                    if (vInfo.VideoConnectType == 2)    //直连模式
                    {
                        iv = new VideoPlay_HikDVR(vInfo, cInfo);
                    }
                    else
                    {
                        iv = new VideoPlay_HikStream(vInfo, cInfo);
                    }
                    break;
                case Enum_VideoType.BlueSky:
                    iv = new VideoPlay_BuleSky(this.Handle, vInfo, cInfo);
                    break;
                case Enum_VideoType.Axis:
                    iv = new VideoPlay_AXIS(vInfo, cInfo);
                    break;
                case Enum_VideoType.XMaiVideo:
                    iv = new VideoPlay_XMai(vInfo, cInfo);
                    break;
                case Enum_VideoType.Ezviz:
                    iv = new VideoPlay_Ezviz(vInfo, cInfo);
                    break;
                case Enum_VideoType.SKNVideo:
                    iv = new VideoPlay_SKNVideo(vInfo, cInfo);
                    break;
                case Enum_VideoType.ZLVideo:
                    iv = new VideoPlay_ZLVideo(vInfo, cInfo);
                    break;
                case Enum_VideoType.SKVideo:
                    iv = new VideoPlay_Shike(vInfo, cInfo);
                    break;
                case Enum_VideoType.DaHuaVideo:
                    iv = new VideoPlay_DaHua(vInfo, cInfo);
                    break;
                case Enum_VideoType.CloundSee:
                    iv = new VideoPlay_CloundSee(vInfo, cInfo);
                    break;
                case Enum_VideoType.HuaMaiVideo:
                    iv = new VideoPlay_HuaMai(vInfo, cInfo);
                    break;
                case Enum_VideoType.TLiVideo:
                    iv = new VideoPlay_TLi(vInfo, cInfo);
                    break;
                case Enum_VideoType.ZHSR:
                    iv = new VideoPlay_ZHSR(cInfo);
                    break;
                case Enum_VideoType.TDWY:
                    iv = new VideoPlay_TDWY(cInfo);
                    break;
                default:
                    iv = null;
                    break;

            }
        }

        /// <summary>
        /// 音频状态改变相关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="SoundStateChangedValue"></param>
        /// <returns></returns>
        private bool Iv_SoundStateChangedEvent(object sender, object SoundStateChangedValue)
        {
            IVideoPlay iv = (IVideoPlay)sender;
            if (this.IsDisposed)
            {
                iv.SoundStateChangedEvent -= Iv_SoundStateChangedEvent;
                return false;
            }
            if (iv.SoundState == Enum_VideoPlaySoundState.SoundOpen)
            {
                picSound.Image = lstimgSoundState.Images[c_strSoundOn];
            }
            else
            {
                picSound.Image = lstimgSoundState.Images[c_strSoundOff];
            }
            return true;
        }

        private bool Iv_VideoPlayCallbackEvent(object sender, VideoPlayCallbackValue evValue)
        {
            bool bolResult = false;
            return bolResult;
        }

        private bool Iv_VideoPlayStateChangedEvent(object sender, object VideoPlayStateChangedValue)
        {
            bool bolResult = false;
            IVideoPlay iv = (IVideoPlay)sender;
            this.VideoPlayState = iv.VideoPlayState;
            return bolResult;
        }
        #endregion


        #region IPCWA 普顺达
        /// <summary>
        /// 视频播放
        /// </summary>
        private void IPCWA_VideoPlay()
        {

            //axRASPlayerOCX1.DeviceUID = CurrentVideoInfo.DVSAddress;
            //axRASPlayerOCX1.ViewPWD = CurrentVideoInfo.Password;
            //if (axRASPlayerOCX1.Start() >= 0)
            //{
            //    axRASPlayerOCX1.SetVideoQuality(5);
            //    VideoPlayState = Enum_VideoPlayState.InPlayState;
            //    if (!Directory.Exists(ProgConstants.strIPCWA_RecDicPath))
            //    {
            //        Directory.CreateDirectory(ProgConstants.strIPCWA_RecDicPath);
            //    }
            //    VideoPlayState = Enum_VideoPlayState.InPlayState;
            //    if (CurrentVideoPlaySet.VideoRecordEnable)
            //    {
            //        //录像
            //        IPCWA_VideoRecord(CurrentVideoPlaySet.VideoRecordFilePath);
            //    }
            //}
            //else
            //{
            //    VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            //    VideoPlayEventCallBack(Enum_VideoPlayEventType.RequestVideoTimeout);
            //}
        }

        private void IPCWA_VideoRecord(string strRecFilePath)
        {
            if (string.IsNullOrEmpty(strRecFilePath))
            {
                //不存在路径 使用默认路径 
                //默认路径格式 [当前工作路径/CloundSeeRecFile/云视通号码/时间(yyyyMMddHHmmss)_通道号(01).mp4]
                StringBuilder sbRecDicPath = new StringBuilder();
                sbRecDicPath.Append(ProgConstants.strIPCWA_RecDicPath);    //默认路径
                sbRecDicPath.Append("\\" + CurrentVideoInfo.DVSAddress);    //云视通号码
                if (!Directory.Exists(sbRecDicPath.ToString()))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(sbRecDicPath.ToString());
                }
                StringBuilder sbRecFilePath = new StringBuilder();
                sbRecFilePath.Append(sbRecDicPath.ToString());
                sbRecFilePath.Append("\\" + DateTime.Now.ToString("yyyyMMddHHmmss"));     //时间
                sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));   //通道号
                sbRecFilePath.Append(".avi");
                strRecFilePath = sbRecFilePath.ToString();
            }
            else if (!strRecFilePath.EndsWith(".avi"))
            {
                //后缀名错误或者只指定文件夹
                if (!Directory.Exists(strRecFilePath.ToString()))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(strRecFilePath.ToString());
                }
                StringBuilder sbRecFilePath = new StringBuilder();
                sbRecFilePath.Append(strRecFilePath);
                sbRecFilePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                sbRecFilePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                sbRecFilePath.Append("_" + "71.avi");                                                   //分类后缀及文件格式

                strRecFilePath = sbRecFilePath.ToString();
            }
            //axRASPlayerOCX1.RecFilePath = strRecFilePath;
            //axRASPlayerOCX1.Record();
        }

        /// <summary>
        /// 视频关闭
        /// </summary>
        private void IPCWA_VideoClose()
        {
            //axRASPlayerOCX1.Stop();
            //VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            ////axIPCWAMian.
            ////axIPCWAMian.Dispose();
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        private void IPCWA_PTZControl(Enum_VideoPTZControl PTZControl)
        {
            //switch (PTZControl)
            //{
            //    case Enum_VideoPTZControl.PTZControl_Up:
            //        axRASPlayerOCX1.PtzControl(1);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_Down:
            //        axRASPlayerOCX1.PtzControl(2);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_Left:
            //        axRASPlayerOCX1.PtzControl(3);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_Right:
            //        axRASPlayerOCX1.PtzControl(6);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_LeftUp:
            //        axRASPlayerOCX1.PtzControl(4);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_LeftDown:
            //        axRASPlayerOCX1.PtzControl(5);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_RightUp:
            //        axRASPlayerOCX1.PtzControl(7);
            //        break;
            //    case Enum_VideoPTZControl.PTZControl_RightDown:
            //        axRASPlayerOCX1.PtzControl(8);
            //        break;
            //}
        }

        #endregion
        

        #region 基本事件

        /// <summary>
        /// 视频播放
        /// </summary>
        public bool VideoPlay()
        {

            if (VideoPlayState == Enum_VideoPlayState.InPlayState || VideoPlayState == Enum_VideoPlayState.Connecting)
            {
                //处于播放状态，释放
                VideoClose();
            }
            intConnCount++;
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.IPCWA:      //普顺达设备（SK835）
                    IPCWA_VideoPlay();
                    break;
                default:
                    if (iv != null)
                    {
                        iv.VideoPlay();
                    }
                    break;
            }
            return false;
        }


        /// <summary>
        /// 视频播放
        /// </summary>
        public bool VideoPlay(VideoPlaySetting vps)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState || VideoPlayState == Enum_VideoPlayState.Connecting)
            {
                //处于播放状态，释放
                VideoClose();
            }
            intConnCount++;
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.IPCWA:      //普顺达设备（SK835）
                    IPCWA_VideoPlay();
                    break;
                default:
                    if (iv != null)
                    {
                        iv.VideoPlay(vps);
                    }
                    break;
            }
            return false;
        }

        /// <summary>
        /// 设置预置点
        /// </summary>
        /// <param name="intPresetPosi"></param>
        public void SetPresetPosi(int intPresetPosi)
        {
            LinkagePresetPoint(intPresetPosi);
        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        public bool VideoClose()
        {
            if (VideoPlayState != Enum_VideoPlayState.VideoInfoNull
                || (iv != null && iv.VideoPlayState != Enum_VideoPlayState.VideoInfoNull))
            //if(iv != null && iv.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.IPCWA:
                        IPCWA_VideoClose();
                        break;
                    default:
                        if (iv != null)
                        {
                            iv.VideoClose();
                        }
                        break;
                }
            }
            TimeOutTimerDispose();
            picPlayMain.Refresh();
            return false;
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            if (VideoPlayState != Enum_VideoPlayState.VideoInfoNull)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.IPCWA:
                        IPCWA_PTZControl(PTZControl);
                        break;
                    default:
                        if (iv != null)
                        {
                            iv.VideoPTZControl(PTZControl, bolStart);
                        }
                        break;
                }
            }
            return false;
        }

        public void Dispose()
        {
            //axRASPlayerOCX1.Dispose();
        }

        #endregion

        #region 控件事件

        private void picPlayMain_SizeChanged(object sender, EventArgs e)
        {
            if (iv != null)
            {
                iv.VideoSizeChange(0, picPlayMain.Width, 0, picPlayMain.Bottom);
            }
        }
        #endregion


        #region 音频设置
        /// <summary>
        /// 当前音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState
        {
            get
            {
                if (iv != null)
                {
                    return iv.SoundState;
                }
                return Enum_VideoPlaySoundState.SoundColse;
            }
        }
        
        public PictureBox PicPlayMain
        {
            get { return this.picPlayMain; }
            set { }
        }

        public IntPtr intptrPlayMain
        {
            get;
            private set;
        }

        private int intVideoplayWindowWidth;
        public int VideoplayWindowWidth { get { return intVideoplayWindowWidth; } set { intVideoplayWindowWidth = value; } }

        private int intVideoplayWindowHeight;
        public int VideoplayWindowHeight { get { return intVideoplayWindowHeight; } set { intVideoplayWindowHeight = value; } }

        /// <summary>
        /// 打开声音通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            if (iv!=null)
            {
                bolResult = iv.OpenSound();
            }
            return bolResult;
        }

        /// <summary>
        /// 关闭声音通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            if (iv != null)
            {
                bolResult = iv.CloseSound();
            }
            return bolResult;
        }

        #endregion

        private void picSound_Click(object sender, EventArgs e)
        {
            if (SoundState == Enum_VideoPlaySoundState.SoundColse)
            {
                OpenSound();
            }
            else
            {
                CloseSound();
            }
        }


        public bool VideoPlayEx()
        {
            return true;
        }


        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            
        }
        /// <summary>
        /// 联动预置点
        /// </summary>
        /// <param name="intPrestValue"></param>
        /// <returns></returns>
        public bool LinkagePresetPoint(int intPrestValue)
        {
            bool bolResult = false;
            if (iv != null)
            {
                bolResult = iv.LinkagePresetPoint(intPrestValue);
            }
            return bolResult;
        }

        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        private event VideoRecordStatusChangedDelegate videoRecordStausChangedEvent;

        /// <summary>
        /// 录像状态改变事件
        /// </summary>
        public event VideoRecordStatusChangedDelegate VideoRecordStausChangedEvent
        {
            add
            {
                videoRecordStausChangedEvent += value;
                if (iv != null)
                {
                    iv.VideoRecordStausChangedEvent += value;
                }
                

            }
            remove
            {
                videoRecordStausChangedEvent += value;
                if (iv != null)
                {
                    iv.VideoRecordStausChangedEvent += value;
                }
                
            }
        }
        /// <summary>
        /// 视频录像状态 true 表示正在录像 false表示未处于录像中
        /// </summary>
        public bool VideoRecordStatus
        {
            get
            {
                if (iv == null)
                {
                    return false;
                }
                return iv.VideoRecordStatus;
            }
        }

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="vrSet"></param>
        /// <returns></returns>
        public bool StartVideoRecord(VideoRecordSet vrSet)
        {
            CurrentVideoPlaySet.VideoRecordEnable = vrSet.Enable;
            CurrentVideoPlaySet.VideoRecordFilePath = vrSet.VideoRecordFilePath;
            CurrentVideoPlaySet.VideoRecordFileName = vrSet.VideoRecordFileName;
            CurrentVideoPlaySet.VideoRecordFilePath_Server = vrSet.VideoRecordFilePath_Server;
            CurrentVideoPlaySet.VideoRecordFileName_Server = vrSet.VideoRecordFileName_Server;
            CurrentVideoPlaySet.TimeOutVideoRecordCloseSecond = vrSet.TimeOutVideoRecordCloseSecond;
            if (!string.IsNullOrEmpty(CurrentVideoPlaySet.VideoRecordFilePath)
                && (!Directory.Exists(CurrentVideoPlaySet.VideoRecordFilePath)))
            {
                Directory.CreateDirectory(CurrentVideoPlaySet.VideoRecordFilePath);
            }
            return iv.StartVideoRecord(vrSet);
        }

        /// <summary>
        /// 关闭录像（不关闭视频）
        /// </summary>
        /// <returns></returns>
        public bool StopVideoRecord()
        {
            if (iv == null)
            {
                return false;
            }
            return iv.StopVideoRecord();
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="snapSet"></param>
        /// <returns></returns>
        public bool Snap(VideoSnapSet snapSet)
        {
            if (iv == null)
            {
                return false;
            }
            return iv.StopVideoRecord();
        }
    }
}
