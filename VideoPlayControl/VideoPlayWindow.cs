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
using static VideoPlayControl.SDK_EzvizSDK_Old;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using static VideoPlayControl.SDK_HikClientSDK;
using AxisMediaParserLib;
using AxisMediaViewerLib;
using System.Threading.Tasks;
using VideoPlayControl.VideoPlay;
using VideoPlayControl.VideoBasicClass;
using VideoPlayControl.Enum;

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放窗口
    /// </summary>
    public partial class VideoPlayWindow : UserControl,IVideoPlay
    {
        #region 常量 
        /// <summary>
        /// 声音打开
        /// </summary>
        private const string c_strSoundOn= "Sound_On";
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
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 当前摄像头信息
        /// </summary>
        public CameraInfo CurrentCameraInfo;

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

        /// <summary>
        /// 播放窗口句柄
        /// </summary>
        IntPtr intptrPlayMain = IntPtr.Zero;


        List<byte> lstVideoRecord = new List<byte>();
        private object objVideoRecordLock = new object();
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

        #region 委托事件

        #region SDK事件回调
        /// <summary>
        /// SDK事件回调委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="etType"></param>
        public delegate void SDKEventCallBackDelegate(object sender, Enum_SDKEventType etType, string strtTag);

        /// <summary>
        /// SDK事件回调事件
        /// </summary>
        public event SDKEventCallBackDelegate SDKEventCallBackEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private void SDKEventCallBack(Enum_SDKEventType etType, string strTag = "")
        {
            if (SDKEventCallBackEvent != null)
            {
                SDKEventCallBackEvent(this, etType, strTag);
            }
        }

        #endregion


        #region 视频播放回调事件2
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
        private bool VideoPlayCallback(VideoPlayCallbackValue value)
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



        #endregion


        private void VideoPlayMain_Load(object sender, EventArgs e)
        {
            //SDKState.SDKStateChangeEvent += SDKStateChange;
            SDKState.SDKEventStateEvent += SDKStateChangeEvent;
            intptrPlayMain = picPlayMain.Handle;
            this.Disposed += VideoPlayWindow_Disposed;
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoadEnd });
        }

        private void VideoPlayWindow_Disposed(object sender, EventArgs e)
        {
            VideoClose();
            Console.WriteLine("VideoPlayControlcClose");
            //throw new NotImplementedException();
        }


        /// <summary>
        /// SDK状态改变事件
        /// </summary>
        /// <param name="sdkType"></param>
        /// <param name="sdkStateEvent"></param>
        public void SDKStateChangeEvent(Enum_VideoType sdkType, Enum_SDKStateEventType sdkStateEvent)
        {
            switch (sdkType)
            {
                case Enum_VideoType.CloundSee:
                    if (sdkStateEvent == Enum_SDKStateEventType.SDKReleaseStart)
                    {
                        //开始释放SDK 
                        CloundSee_VideoClose();
                        intCloundSee_ConnID = -1;
                    }
                    break;
            }
        }

        #region  视频设备基本信息赋值

        public void Init_VideoInfo(VideoInfo videoInfo)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                VideoClose();
            }
            intConnCount = 0;
            CurrentVideoInfo = videoInfo;
            Init_SetVideoInfo();
            //.Net2.0 无法获取首个对象 通过循环获取
            foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
            {
                CurrentCameraInfo = kv.Value;
                break;
            }
            if (VideoPlayState == Enum_VideoPlayState.VideoInfoNull)
            {
                VideoPlayState = Enum_VideoPlayState.VideoInfoInit;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.SetVideoInfo });
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoTypeNotExists });
            }
            InterfaceInit();
        }

        public void Init_VideoInfo(VideoInfo videoInfo, int intChannel)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                VideoClose();
            }
            intConnCount = 0;
            CurrentVideoInfo = videoInfo;
            Init_SetVideoInfo();
            //.Net2.0 无法获取首个对象 通过循环获取
            CurrentCameraInfo = videoInfo.Cameras[intChannel];
            if (VideoPlayState == Enum_VideoPlayState.VideoInfoNull)
            {
                VideoPlayState = Enum_VideoPlayState.VideoInfoInit;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.SetVideoInfo });
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoTypeNotExists });
            }
            InterfaceInit();
        }

        public void Init_VideoInfo(VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                VideoClose();
            }
            intConnCount = 0;
            CurrentVideoInfo = videoInfo;
            Init_SetVideoInfo();
            //.Net2.0 无法获取首个对象 通过循环获取
            foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
            {
                CurrentCameraInfo = kv.Value;
                break;
            }
            CurrentVideoPlaySet = videoPlaySet;
            if (VideoPlayState == Enum_VideoPlayState.VideoInfoNull)
            {
                VideoPlayState = Enum_VideoPlayState.VideoInfoInit;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.SetVideoInfo });
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoTypeNotExists });
            }
            InterfaceInit();
        }

        public void Init_VideoInfo(VideoInfo videoInfo, CameraInfo cameraInfo, VideoPlaySetting videoPlaySet)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState || (iv != null && iv.VideoPlayState != Enum_VideoPlayState.VideoInfoNull))
            {
                VideoClose();
            }
            CurrentVideoInfo = videoInfo;
            Init_SetVideoInfo();
            intConnCount = 0;
            CurrentCameraInfo = cameraInfo;
            CurrentVideoPlaySet = videoPlaySet;
            if (VideoPlayState == Enum_VideoPlayState.VideoInfoNull)
            {
                VideoPlayState = Enum_VideoPlayState.VideoInfoInit;
            }
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.SetVideoInfo });
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoTypeNotExists });
            }

            //if (CurrentVideoInfo.VideoType == Enum_VideoType.CloundSee)
            //{
            //    CloundSee_VideoLPRECTChanged();
            //    CloundSee_InitSDKCallBack();
            //}
            InterfaceInit();
        }

        private void Init_SetVideoInfo()
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                VideoClose();
            }
            //if (CurrentVideoInfo.VideoType == Enum_VideoType.IPCWA)
            //{
            //    //普顺达设备特殊 单独控件
            //    picPlayMain.Visible = false;
            //    axRASPlayerOCX1.Visible = true;
            //}
            //else
            //{
            //    picPlayMain.Visible = true;
            //    axRASPlayerOCX1.Visible = false;
            //}
            if (CurrentVideoInfo.VideoType == Enum_VideoType.CloundSee)
            {
                CloundSee_VideoLPRECTChanged();
                CloundSee_InitSDKCallBack();
            }
            InterfaceInit();
        }

        private void InterfaceInit()
        {
            if (iv != null && iv.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                iv.VideoClose();
            }
            if (iv == null)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.HikDVR:
                        iv = new VideoPlay_HikDVR();
                        break;
                    case Enum_VideoType.BlueSky:
                        iv = new VideoPlay_BuleSky(this.Handle);
                        break;
                    case Enum_VideoType.Axis:
                        iv = new VideoPlay_AXIS();
                        break;
                    case Enum_VideoType.XMaiVideo:
                        iv = new VideoPlay_XMai();
                        break;
                    case Enum_VideoType.Ezviz:
                        iv = new VideoPlay_Ezviz();
                        break;
                    case Enum_VideoType.SKNVideo:
                        iv = new VideoPlay_SKNVideo();
                        break;
                    case Enum_VideoType.ZLVideo:
                        iv = new VideoPlay_ZLVideo();
                        break;
                    case Enum_VideoType.SKVideo:
                        iv = new VideoPlay_Shike();
                        break;
                    case Enum_VideoType.DaHuaVideo:
                        iv = new VideoPlay_DaHua();
                        break;
                    default:
                        iv = null;
                        break;

                }
            }
            else
            {
                if (iv.CurrentVideoInfo.VideoType != CurrentVideoInfo.VideoType)
                {
                    iv = null;
                    switch (CurrentVideoInfo.VideoType)
                    {
                        case Enum_VideoType.HikDVR:
                            iv = new VideoPlay_HikDVR();
                            break;
                        case Enum_VideoType.BlueSky:
                            iv = new VideoPlay_BuleSky(this.Handle);
                            break;
                        case Enum_VideoType.Axis:
                            iv = new VideoPlay_AXIS();
                            break;
                        case Enum_VideoType.XMaiVideo:
                            iv = new VideoPlay_XMai();
                            break;
                        case Enum_VideoType.Ezviz:
                            iv = new VideoPlay_Ezviz();
                            break;
                        case Enum_VideoType.SKNVideo:
                            iv = new VideoPlay_SKNVideo();
                            break;
                        case Enum_VideoType.ZLVideo:
                            iv = new VideoPlay_ZLVideo();
                            break;
                        case Enum_VideoType.SKVideo:
                            iv = new VideoPlay_Shike();
                            break;
                        case Enum_VideoType.DaHuaVideo:
                            iv = new VideoPlay_DaHua();
                            break;
                        default:
                            iv = null;
                            break;
                    }
                }
            }
            if (iv != null)
            {
                iv.intptrPlayMain = intptrPlayMain;
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

        #region CloundSeeSDK 云视通

        #region 全局变量
        /// <summary>
        /// 云视通_当前连接ID
        /// </summary>
        public int intCloundSee_ConnID = -1;


        IntPtr intptrCloundSee_PlayRect = IntPtr.Zero;

        /// <summary>
        /// 云视通_事件回调
        /// </summary>
        public static SDK_JCSDK.JCEventCallback_t gEventCallback = null;
        #endregion

        #region 初始化
        /// <summary>
        /// 初始化SDK_云视通
        /// </summary>
        public void CloundSee_SDKInit1(int intLocStartPort = -1, string strTempFileDicPath = "")
        {
            if (SDKState.CloundSeeSDKState != Enum_SDKState.SDK_Init)
            {
                // 不属于初始化状态
                ProgParameter.intCloundSee_intLocStartPort = intLocStartPort;
                if (string.IsNullOrEmpty(strTempFileDicPath.Trim()))
                {
                    ProgParameter.strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
                }
                else
                {
                    ProgParameter.strCloundSee_TempDicPath = strTempFileDicPath;
                }

                //初始化
                if (SDK_JCSDK.JCSDK_InitSDK(ProgParameter.intCloundSee_intLocStartPort, ProgParameter.strCloundSee_TempDicPath))
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_Init;
                }
                else
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_InitFail;
                    return;
                }
            }
        }

        /// <summary>
        ///  云视通_注册SDK回调
        /// </summary>
        public void CloundSee_InitSDKCallBack()
        {
            gEventCallback = new SDK_JCSDK.JCEventCallback_t(CloundSee_JCEventCallback);
            SDK_JCSDK.JCSDK_RegisterCallback(gEventCallback, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero);
        }

        /// <summary>
        /// 云视通_事件回调函数
        /// </summary>
        /// <param name="nLinkID"></param>
        /// <param name="etType"></param>
        /// <param name="pData1"></param>
        /// <param name="pData2"></param>
        /// <param name="pUserData"></param>
        private void CloundSee_JCEventCallback(int nLinkID, SDK_JCSDK.JCEventType etType, IntPtr pData1, IntPtr pData2, IntPtr pUserData)
        {
            string strTag = "";
            Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
            switch (etType)
            {
                case SDK_JCSDK.JCEventType.JCET_ConnectOK:  //连接成功
                    videoEvType = Enum_SDKEventType.ConnectOK;
                    CurrentVideoInfo.NetworkState = 1;          //置为在线
                    CloundSee_VideoPreview(false);
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConTimeout: //连接超时
                    videoEvType = Enum_SDKEventType.ConnectTimeOut;
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestVideoTimeout });
                    break;

                case SDK_JCSDK.JCEventType.JCET_DisconOK:   //连接断开
                    videoEvType = Enum_SDKEventType.DisconnectOK;
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConAbout:
                    videoEvType = Enum_SDKEventType.ConnectAbnormally;
                    break;

                case SDK_JCSDK.JCEventType.JCET_UserAccessError:
                    videoEvType = Enum_SDKEventType.UserAccessError;
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.UserAccessError });
                    break;
            }
            if (videoEvType == Enum_SDKEventType.Unrecognized)
            {
                strTag = strTag = etType.ToString();
            }
            SDKEventCallBack(videoEvType, strTag);
        }

        #endregion

        #region 基本事件

        /// <summary>
        /// 视频播放(实际为视频连接，通过回调出发视频播放)
        /// </summary>
        private void CloundSee_VideoPlay()
        {
            bool bolCouldID = !CommonMethod.Verification.isIP(CurrentVideoInfo.DVSAddress);

            if (bolCouldID)
            {
                //使用云视通号
                //大于0设备在线  0 参数错误  -1设备离线  -2设备版本过早  -3其他原因
                int Temp_NetworkState = SDK_JCSDK.JCSDK_GetYstOnlineStatus(CurrentVideoInfo.DVSAddress, 1);
                if (Temp_NetworkState > 0)
                {
                    //设备在线
                    CurrentVideoInfo.NetworkState = 1;
                }
                else if (Temp_NetworkState == -1 || Temp_NetworkState == 0 || Temp_NetworkState == -2)
                {
                    //离线
                    CurrentVideoInfo.NetworkState = 0;
                }
                else
                {
                    //状态为明
                    CurrentVideoInfo.NetworkState = -1;
                }
            }
            else
            {
                //使IP地址 状态置为 未明
                CurrentVideoInfo.NetworkState = -1;
            }

            if (intCloundSee_ConnID != -1)
            {
                CloundSee_VideoClose();
            }
            if (CurrentVideoInfo.NetworkState != 0)
            {
                intCloundSee_ConnID = SDK_JCSDK.JCSDK_Connect(CurrentVideoInfo.DVSAddress,
                                    CurrentVideoInfo.DVSConnectPort,
                                    CurrentCameraInfo.Channel,
                                    CurrentVideoInfo.UserName,
                                    CurrentVideoInfo.Password,
                                    bolCouldID,
                                    "");
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnSuccess });
                if (intCloundSee_ConnID == -1)
                {
                    //连接失败
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnFailed });
                }
            }
            else
            {
                //生成网络状态状态异常事件
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoDeviceNotOnline });
                CurrentVideoPlaySet.AutoReconn = false;
            }

        }

        /// <summary>
        /// 视频预览
        /// </summary>
        private void CloundSee_VideoPreview(bool bolOnlySetPreview = true)
        {
            SDK_JCSDK.JCSDK_EnableDecoder(intCloundSee_ConnID, true);
            SDK_JCSDK.JCSDK_SetVideoPreview(intCloundSee_ConnID, intptrPlayMain, intptrCloundSee_PlayRect);
            if (!bolOnlySetPreview)
            {
                if (CurrentVideoPlaySet.VideoRecordEnable)      //录像使能
                {
                    CloundSee_VideoRecordStart(CurrentVideoPlaySet.VideoRecordFilePath);
                }
                if (CurrentVideoPlaySet.VideoMonitorEnable)     //音频使能
                {
                    CloundSee_VideoMonitorStart();
                }
                if (CurrentVideoPlaySet.PreSetPosi != -1)        //预置点
                {
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        CloundSee_SetPresetPosi(CurrentVideoPlaySet.PreSetPosi);
                        if (CurrentVideoPlaySet.FirstInForcePreSetPosi)
                        {
                            //仅首次生效
                            CurrentVideoPlaySet.PreSetPosi = -1;
                        }
                    }));
                }
            }
        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        private void CloundSee_VideoClose()
        {
            if (intCloundSee_ConnID != -1)
            {
                CloundSee_VideoRecordStop();
                CloundSee_VideoMonitorStop();
                for (int i = intCloundSee_ConnID; i > -1; i--)
                {
                    SDK_JCSDK.JCSDK_Disconnect(i);
                }
            }
        }

        /// <summary>
        /// 视频录像
        /// </summary>
        public void CloundSee_VideoRecordStart(string strRecFilePath)
        {
            if (string.IsNullOrEmpty(strRecFilePath))
            {
                //不存在路径 使用默认路径 
                //默认路径格式 [当前工作路径/CloundSeeRecFile/云视通号码/时间(yyyyMMddHHmmss)_通道号(01).mp4]
                StringBuilder sbRecDicPath = new StringBuilder();
                sbRecDicPath.Append(ProgConstants.strCloundSee_RecDicPath);    //默认路径
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
                sbRecFilePath.Append(".mp4");
                strRecFilePath = sbRecFilePath.ToString();
            }
            else if (!strRecFilePath.EndsWith(".mp4"))
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
                sbRecFilePath.Append("_" + "91.mp4");                                                   //分类后缀及文件格式
                strRecFilePath = sbRecFilePath.ToString();
            }
            SDK_JCSDK.JCSDK_StartRec(intCloundSee_ConnID, strRecFilePath);
        }

        /// <summary>
        /// 停止视频录像
        /// </summary>
        public void CloundSee_VideoRecordStop()
        {
            SDK_JCSDK.JCSDK_StopRec(intCloundSee_ConnID);
        }

        /// <summary>
        /// 监听使能
        /// </summary>
        public void CloundSee_VideoMonitorStart()
        {
            SDK_JCSDK.JCSDK_SetAudioPreview(intCloundSee_ConnID, intptrPlayMain);
        }

        /// <summary>
        /// 监听停止
        /// </summary>
        public void CloundSee_VideoMonitorStop()
        {
            SDK_JCSDK.JCSDK_SetAudioPreview(intCloundSee_ConnID, IntPtr.Zero);
        }

        /// <summary>
        /// 设置预置点位置（仅在主线程中调用有效）
        /// </summary>
        /// <param name="intPreSetPosi"></param>
        public void CloundSee_SetPresetPosi(int intPreSetPosi)
        {
            SDK_JCSDK.JCSDK_PresetCall(CurrentCameraInfo.Channel, intPreSetPosi);
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        private void CloundSee_PTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            SDK_JCSDK.JCPTZCmdType CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Auto;
            //云台控制类型改变
            switch (PTZControl) //云视通仅 上下
            {
                case Enum_VideoPTZControl.PTZControl_Up:
                    CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Up;
                    break;
                case Enum_VideoPTZControl.PTZControl_Down:
                    CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Down;
                    break;
                case Enum_VideoPTZControl.PTZControl_Left:
                    CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Left;
                    break;
                case Enum_VideoPTZControl.PTZControl_Right:
                    CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Right;
                    break;
            }
            if (CloundSee_PTZControl != SDK_JCSDK.JCPTZCmdType.JCPCT_Auto)
            {
                SDK_JCSDK.JCSDK_SendPTZCommand(intCloundSee_ConnID, CloundSee_PTZControl, bolStart);
            }

        }

        /// <summary>
        /// 视频播放区域改变
        /// </summary>
        public void CloundSee_VideoLPRECTChanged()
        {
            SDK_JCSDK.LPRECT rectMain = new SDK_JCSDK.LPRECT();
            Rectangle rect1 = picPlayMain.RectangleToScreen(picPlayMain.ClientRectangle);
            rectMain.Left = rect1.Left;
            rectMain.Right = rect1.Right;
            rectMain.Top = rect1.Top;
            rectMain.Bottom = rect1.Bottom;
            intptrCloundSee_PlayRect = Marshal.AllocHGlobal(Marshal.SizeOf(rectMain));
            Marshal.StructureToPtr(rectMain, intptrCloundSee_PlayRect, true);
        }

        #endregion

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




        #region HuaMaiVideo  华迈视频

        #region 全局变量
        IntPtr iNode = IntPtr.Zero;
        IntPtr iDev = IntPtr.Zero;
        IntPtr iPort = IntPtr.Zero;
        IntPtr iOpenVideo = IntPtr.Zero;
        #endregion

        #region 基本事件
        /// <summary>
        /// 华迈视频_视频播放
        /// </summary>
        private void HuaMaiVideo_VideoPlay()
        {
            UInt32 iResult = 0;
            iResult = SDK_HuaMai.hm_server_find_device_by_sn(ProgParameter.HuaMai_iTree, CurrentVideoInfo.DVSAddress, ref iNode);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success
                || iNode == IntPtr.Zero)
            {
                //查询不到设备
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DeviceNotExist });
                return;
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
                return;
            }

            SDK_HuaMai._OPEN_VIDEO_PARAM para = new SDK_HuaMai._OPEN_VIDEO_PARAM();
            para.channel = Convert.ToUInt32(CurrentCameraInfo.Channel);
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
                return;
            }

            SDK_HuaMai.OPEN_VIDEO_RES videoRes = new SDK_HuaMai.OPEN_VIDEO_RES();
            iResult = SDK_HuaMai.hm_pu_start_video(iOpenVideo, ref videoRes);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                //开始播放视频异常
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException });
                return;
            }
            SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //IntPtr iWnd = pictureBox1.Handle;
            iPort = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_video_display_open_port(this.Handle, ref disp_op, ref iPort);
            iResult = SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
            VideoPlayState = Enum_VideoPlayState.InPlayState;
        }
        /// <summary>
        /// 华迈视频_视频关闭
        /// </summary>
        public void HuaMaiVideo_VideoClose()
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


        #endregion

        #region 回调函数
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }
        #endregion

        #region 基本事件

        /// <summary>
        /// 视频播放
        /// </summary>
        public void VideoPlay()
        {

            if (VideoPlayState == Enum_VideoPlayState.InPlayState || VideoPlayState == Enum_VideoPlayState.Connecting)
            {
                //处于播放状态，释放
                VideoClose();
            }
            intConnCount++;
            //VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.Unrecognized:
                    //不做操作
                    break;
                case Enum_VideoType.CloundSee:  //云视通设备
                    CloundSee_VideoPlay();
                    break;
                case Enum_VideoType.IPCWA:      //普顺达设备（SK835）
                    IPCWA_VideoPlay();
                    break;
                case Enum_VideoType.HuaMaiVideo://华迈设备
                    HuaMaiVideo_VideoPlay();
                    break;
                default:
                    iv.VideoPlay();
                    break;
            }
        }

        /// <summary>
        /// 视频播放_视频设置
        /// </summary>
        public void VideoPlay_VideoPlaySetting(VideoPlaySetting videoPlaySetting)
        {
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:
                    CloundSee_SetPresetPosi(videoPlaySetting.PreSetPosi);
                    break;
            }
        }

        /// <summary>
        /// 设置预置点
        /// </summary>
        /// <param name="intPresetPosi"></param>
        public void SetPresetPosi(int intPresetPosi)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_SetPresetPosi(intPresetPosi);
                        break;
                }
            }
        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        public void VideoClose()
        {
            if (VideoPlayState != Enum_VideoPlayState.VideoInfoNull
                || (iv != null && iv.VideoPlayState != Enum_VideoPlayState.VideoInfoNull))
            //if(iv != null && iv.VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.Unrecognized:
                        //不做操作
                        break;
                    case Enum_VideoType.CloundSee:
                        CloundSee_VideoClose();
                        break;
                    case Enum_VideoType.IPCWA:
                        IPCWA_VideoClose();
                        break;
                    case Enum_VideoType.HuaMaiVideo:
                        HuaMaiVideo_VideoClose();
                        break;
                    default:
                        iv.VideoClose();
                        break;
                }
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            }
            TimeOutTimerDispose();
            picPlayMain.Refresh();
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        public void VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            if (VideoPlayState != Enum_VideoPlayState.VideoInfoNull)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_PTZControl(PTZControl, bolStart);
                        break;
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
        }

        public void Dispose()
        {
            //axRASPlayerOCX1.Dispose();
        }

        #endregion

        #region 控件事件
        private void VideoPlayMain_Move(object sender, EventArgs e)
        {
            VideoPlayWindows_Move();
        }

        private void picPlayMain_SizeChanged(object sender, EventArgs e)
        {
            if (CurrentVideoInfo != null
                && (VideoPlayState == Enum_VideoPlayState.InPlayState
                || (iv != null) && iv.VideoPlayState == Enum_VideoPlayState.InPlayState))
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_VideoLPRECTChanged();
                        if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                        {
                            CloundSee_VideoPreview();
                        }
                        break;
                    case Enum_VideoType.IPCWA:
                        if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                        {
                            //axRASPlayerOCX1.();
                        }
                        break;
                    default:
                        if (iv != null)
                        {
                            iv.VideoSizeChange(0, picPlayMain.Width, 0, picPlayMain.Bottom);
                        }
                        break;
                }
            }
        }
        #endregion

        #region VideoPlayWindows事件
        public void VideoPlayWindows_Move()
        {
            if (CurrentVideoInfo != null)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_VideoLPRECTChanged();
                        if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                        {
                            CloundSee_VideoPreview();
                        }
                        break;
                    case Enum_VideoType.IPCWA:
                        if (VideoPlayState == Enum_VideoPlayState.InPlayState)
                        {
                            //axRASPlayerOCX1.();
                        }
                        break;
                }
            }
        }


        /// <summary>
        /// 视频控件关闭
        /// </summary>
        public void VideoPlayWindows_Close()
        {
            VideoClose();
            SDKState.SDKEventStateEvent -= SDKStateChangeEvent;
            //axRASPlayerOCX1.Dispose();
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

        VideoInfo IVideoPlay.CurrentVideoInfo { get; set; }
        CameraInfo IVideoPlay.CurrentCameraInfo { get; set; }
        IntPtr IVideoPlay.intptrPlayMain { get; set; }

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

        bool IVideoPlay.VideoPlayCallback(VideoPlayCallbackValue value)
        {
            return true;
        }

        bool IVideoPlay.VideoPlay()
        {
            return true;
        }

        public bool VideoPlayEx()
        {
            return true;
        }

        bool IVideoPlay.VideoClose()
        {
            return true;
        }

        bool IVideoPlay.VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            return true;
        }

        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {

        }
    }
}
