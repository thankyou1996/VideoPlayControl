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

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放窗口
    /// </summary>
    public partial class VideoPlayWindow : UserControl
    {
        #region 全局变量
        int intx = 0;

        /// <summary>
        /// 当前视频视频设备信息
        /// </summary>
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 当前摄像头信息
        /// </summary>
        public CameraInfo CurrentCameraInfo;

        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        private Enum_VideoPlayState videoPlayState = Enum_VideoPlayState.VideoInfoNull;

        public Enum_VideoPlayState VideoPlayState
        {
            get { return videoPlayState; }
            set
            {
                if (videoPlayState != value)
                {
                    videoPlayState = value;
                    switch (videoPlayState)
                    {
                        case Enum_VideoPlayState.InPlayState:
                            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay);
                            break;
                    }
                }
            }
        }
        /// <summary>
        /// 当前播放设置
        /// </summary>
        public VideoPlaySetting CurrentVideoPlaySet = new VideoPlaySetting();

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

        public PictureBox PicMain
        {
            get { return picPlayMain; }
            set { picPlayMain = value; }
        }

        public VideoPlayWindow()
        {
            InitializeComponent();
            VideoPlayEventCallBack(Enum_VideoPlayEventType.InitEnd);
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
                SDKEventCallBackEvent( this,etType, strTag);
            }
        }

        #endregion

        #region 视频播放事件回调
        /// <summary>
        /// 视频播放事件回调_委托
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="strTag"></param>
        public delegate void VideoPlayEventCallBackDelegate(object sender, Enum_VideoPlayEventType eventType);

        /// <summary>
        /// 视频播放事件回调_事件
        /// </summary>
        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;

        /// <summary>
        /// 视频播放事件回调
        /// </summary>
        private void VideoPlayEventCallBack(Enum_VideoPlayEventType eventType)
        {
            switch (eventType)      //部分特殊处理
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
            if (VideoPlayEventCallBackEvent != null)
            {
                VideoPlayEventCallBackEvent(this, eventType);
            }
        }

        #endregion
        
        #endregion

        private void VideoPlayMain_Load(object sender, EventArgs e)
        {
            //SDKState.SDKStateChangeEvent += SDKStateChange;
            SDKState.SDKEventStateEvent += SDKStateChangeEvent;
            intptrPlayMain = picPlayMain.Handle;
            VideoPlayEventCallBack(Enum_VideoPlayEventType.LoadEnd);
        }
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
            VideoPlayEventCallBack(Enum_VideoPlayEventType.SetVideoInfo);
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoTypeNotExists);
            }
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
            VideoPlayEventCallBack(Enum_VideoPlayEventType.SetVideoInfo);
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoTypeNotExists);
            }
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
            VideoPlayEventCallBack(Enum_VideoPlayEventType.SetVideoInfo);
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoTypeNotExists);
            }
        }

        public void Init_VideoInfo(VideoInfo videoInfo, CameraInfo cameraInfo, VideoPlaySetting videoPlaySet)
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
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
            VideoPlayEventCallBack(Enum_VideoPlayEventType.SetVideoInfo);
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Unrecognized)
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoTypeNotExists);
            }

            //if (CurrentVideoInfo.VideoType == Enum_VideoType.CloundSee)
            //{
            //    CloundSee_VideoLPRECTChanged();
            //    CloundSee_InitSDKCallBack();
            //}
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
            if (CurrentVideoInfo.VideoType == Enum_VideoType.Ezviz)
            {
                #region 旧代码
                //    //SDK_EzvizSDK.OpenSDK_MessageHandler openSDK_MessageHandler = new SDK_EzvizSDK.OpenSDK_MessageHandler(Ezviz_EventCallback);
                //    //SDK_EzvizSDK.OpenSDK_DataCallBack RealPlayCallBack = new SDK_EzvizSDK.OpenSDK_DataCallBack(Ezviz_DataCallBack);
                //    int Temp_intSessiongLength = 0;
                //    Temp_intptrSessiongID = IntPtr.Zero;
                //    openSDK_MessageHandler = new SDK_EzvizSDK_Old.OpenSDK_MessageHandler(Ezviz_EventCallback_Old);
                //    int intResult = SDK_EzvizSDK_Old.OpenSDK_AllocSession_Old(openSDK_MessageHandler, intEzivz_UserID, out Temp_intptrSessiongID, out Temp_intSessiongLength);
                //    if (intResult == 0)
                //    {
                //        //连接成功
                //        VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
                //    }
                //    else
                //    {
                //        //连接失败
                //        VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed);
                //    }
                //    strEzivz_SessionID = Marshal.PtrToStringAnsi(Temp_intptrSessiongID);
                //    RealPlayCallBack = new SDK_EzvizSDK_Old.OpenSDK_DataCallBack(Ezviz_DataCallBack_Old);
                //    intResult = SDK_EzvizSDK_Old.OpenSDK_SetDataCallBack(strEzivz_SessionID, RealPlayCallBack, "");
                #endregion

                #region 新代码
                //ezviz

                #endregion
            }
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
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConTimeout: //连接超时
                    videoEvType = Enum_SDKEventType.ConnectTimeOut;
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.RequestVideoTimeout);
                    break;

                case SDK_JCSDK.JCEventType.JCET_DisconOK:   //连接断开
                    videoEvType = Enum_SDKEventType.DisconnectOK;
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConAbout:
                    videoEvType = Enum_SDKEventType.ConnectAbnormally;
                    break;

                case SDK_JCSDK.JCEventType.JCET_UserAccessError:
                    videoEvType = Enum_SDKEventType.UserAccessError;
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.UserAccessError);
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
                else if ( Temp_NetworkState == -1 || Temp_NetworkState == 0|| Temp_NetworkState==-2)
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
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
                if (intCloundSee_ConnID == -1)
                {
                    //连接失败
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed);
                }
            }
            else
            {
                //生成网络状态状态异常事件
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoDeviceNotOnline);
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
        
        #region Ezviz 萤石云

        #region 全局变量 

        IntPtr intptrSessionID = IntPtr.Zero;
        SDK_EzvizSDK.MsgHandler callBack;
        SDK_EzvizSDK.DataCallBack Ezviz_DataCallBack;
        GCHandle Ezviz_gchMsgBack;
        GCHandle Ezviz_gchVideoRecord;
        IntPtr iUser = IntPtr.Zero;
        #endregion

        #region 基本事件

        /// <summary>
        /// 萤石视频播放
        /// </summary>
        public void Ezviz_VideoPlay()
        {
            int intLenght = 0;
            int intResult = 0;
            CurrentVideoInfo.NetworkState = SDK_EzvizSDK.GetDevOnlineState(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel);
            if (CurrentVideoInfo.NetworkState != 1)
            {
                //设备离线
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoDeviceNotOnline);
                return;
            }
            callBack = new SDK_EzvizSDK.MsgHandler(Ezviz_MsgCallback);
            Ezviz_gchMsgBack = GCHandle.Alloc(callBack);
            string strUser = CurrentVideoInfo.DVSAddress + "_" + CurrentCameraInfo.Channel;
            iUser = Marshal.StringToHGlobalAnsi(strUser);
            intResult = SDK_EzvizSDK.OpenSDK_AllocSessionEx(callBack, iUser, out intptrSessionID, out intLenght);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                //录像启用
                Ezviz_DataCallBack = new SDK_EzvizSDK.DataCallBack(Ezviz_DataCallBackEvent);
                Ezviz_gchVideoRecord = GCHandle.Alloc(Ezviz_DataCallBack);
                intResult = SDK_EzvizSDK.OpenSDK_SetDataCallBack(intptrSessionID, Ezviz_DataCallBack, iUser);
            }
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            //intResult = SDK_EzvizSDK.OpenSDK_SetVideoLevel(intptrSessionID, CurrentCameraInfo.Channel, 0);
            intResult = SDK_EzvizSDK.OpenSDK_StartRealPlayEx(intptrSessionID, intptrPlayMain, intptrdevSerial, CurrentCameraInfo.Channel, CurrentVideoInfo.Password);
            //intResult = SDK_EzvizSDK.OpenSDK_StartRealPlay(intptrSessionID, intptrPlayMain, CurrentCameraInfo.CameraUniqueCode, ProgParameter.strEzviz_AccessToken, 2, null, ProgParameter.strEzviz__AppID, 0);
            if (intResult == 0)
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
            }
            else
            {
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed);
            }
        }

        /// <summary>
        /// 消息事件回调
        /// </summary>
        /// <param name="intptrSessionId"></param>
        /// <param name="iMsgType"></param>
        /// <param name="iErrorCode"></param>
        /// <param name="pMessageInfo"></param>
        /// <param name="pUser"></param>
        public void Ezviz_MsgCallback(IntPtr intptrSessionId, SDK_EzvizSDK.EzvizMeesageType iMsgType, uint iErrorCode, string pMessageInfo, IntPtr pUser)
        {
            string strUser = Marshal.PtrToStringAnsi(pUser);
            if (iUser == pUser)
            {
                string strTag = "";
                Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
                switch (iMsgType)
                {
                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_EXCEPTION:
                        if (iErrorCode == 2012)
                        {
                            //密码错误 ，自己测试验证，非官方确认
                            VideoPlayEventCallBack(Enum_VideoPlayEventType.UserAccessError);
                        }
                        else
                        {
                            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);
                        }

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_RECONNECT:
                        VideoPlayState = Enum_VideoPlayState.Connecting;

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_RECONNECT_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_START:
                        CurrentVideoInfo.NetworkState = 1;          //置为在线
                        VideoPlayState = Enum_VideoPlayState.InPlayState;
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_STOP:
                        VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_ARCHIVE_END:
                        //VideoPlayState = Enum_VideoPlayState.NotInPlayState;

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_START:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_STOP:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_VOICETALK_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZ_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_FILE:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_SEARCH_END:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_RECORD_SEARCH_FAILED:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_DEFENSE_SUCCESS:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_DEFENSE_FAILED:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PLAY_ARCHIVE_EXCEPTION:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZCTRL_SUCCESS:

                        break;

                    case SDK_EzvizSDK.EzvizMeesageType.INS_PTZCTRL_FAILED:

                        break;
                }
                if (videoEvType == Enum_SDKEventType.Unrecognized)
                {
                    strTag = strTag = iMsgType.ToString();
                }
                SDKEventCallBack(videoEvType, strTag);
            }
        }

        /// <summary>
        /// 萤石数据回调
        /// </summary>
        /// <param name="enType"></param>
        /// <param name="pData"></param>
        /// <param name="iLen"></param>
        /// <param name="pUser"></param>
        public void Ezviz_DataCallBackEvent(SDK_EzvizSDK.DataType enType, IntPtr pData, int iLen, IntPtr pUser)
        {
            byte[] managedArray = new byte[iLen];
            Marshal.Copy(pData, managedArray, 0, iLen);
            string strUser = Marshal.PtrToStringAnsi(pUser);
            lstVideoRecord.AddRange(managedArray);
        }

        /// <summary>
        /// 萤石视频关闭
        /// </summary>
        public void Ezviz_VideoClose()
        {
            SDK_EzvizSDK.OpenSDK_StopRealPlay(intptrSessionID, 0);
            SDK_EzvizSDK.OpenSDK_FreeSession(intptrSessionID.ToString());
            
            if (Ezviz_gchMsgBack != null && Ezviz_gchMsgBack.IsAllocated)
            {
                Ezviz_gchMsgBack.Free();
            } 
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                Ezviz_GenerateRecord(CurrentVideoPlaySet.VideoRecordFilePath);
                if (Ezviz_gchVideoRecord != null && Ezviz_gchVideoRecord.IsAllocated)
                {
                    Ezviz_gchVideoRecord.Free();
                }
            }
            else
            {
                lstVideoRecord = new List<byte>();
            }
            
        }

        /// <summary>
        /// 萤石生成录像文件
        /// </summary>
        /// <param name="strRecFilePath"></param>
        private void Ezviz_GenerateRecord(string strRecFilePath = "")
        {
            if (lstVideoRecord.Count > 0)
            {
                if (string.IsNullOrEmpty(strRecFilePath))
                {
                    //不存在路径 使用默认路径 
                    //默认路径格式 [当前工作路径/EzvizRecFile/萤石云编号/时间(yyyyMMddHHmmss)_通道号(01).mp4]
                    StringBuilder sbRecDicPath = new StringBuilder();
                    sbRecDicPath.Append(ProgConstants.strEzviz_RecDicPath);    //默认路径
                    sbRecDicPath.Append("\\" + CurrentVideoInfo.DVSAddress);    //萤石云编号
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
                    //路径格式 [传入的路径/摄像机编号_通道号（BCD 向左补足2位)_时间(yyyyMMddHHmmss)_13(固定码 萤石13).mp4]
                    sbRecFilePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                    sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                    sbRecFilePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                    sbRecFilePath.Append("_" + "13.mp4");                                                   //分类后缀及文件格式
                    strRecFilePath = sbRecFilePath.ToString();
                }
                byte[] Temp_b = lstVideoRecord.ToArray();
                using (FileStream f = File.OpenWrite(strRecFilePath))
                {
                    f.Write(Temp_b, 0, Temp_b.Length);
                }
                lstVideoRecord = new List<byte>();
            }
        }

        /// <summary>
        /// 萤石云云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        private void Ezviz_PTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            SDK_EzvizSDK.PTZAction ptzAction = bolStart ? SDK_EzvizSDK.PTZAction.START : SDK_EzvizSDK.PTZAction.STOP;
            SDK_EzvizSDK.PTZCommand ptzCommand=SDK_EzvizSDK.PTZCommand.AUTO;
            switch (PTZControl)
            {
                case Enum_VideoPTZControl.PTZControl_Up:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UP;
                    break;
                case Enum_VideoPTZControl.PTZControl_Down:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWN;
                    break;
                case Enum_VideoPTZControl.PTZControl_Left:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.LEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_Right:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.RIGHT;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftUp:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UPLEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftDown:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWNLEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightUp:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.UPRIGHT;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightDown:
                    ptzCommand = SDK_EzvizSDK.PTZCommand.DOWNRIGHT;
                    break;
            }
            IntPtr intptrdevSerial = Marshal.StringToHGlobalAnsi(CurrentVideoInfo.DVSAddress);
            SDK_EzvizSDK.OpenSDK_PTZCtrlEx(intptrSessionID, intptrdevSerial, CurrentCameraInfo.Channel, ptzCommand, ptzAction, 3);
        }
        #endregion

        #endregion

        #region SKVideo 时刻视频

        #region  基本事件
        private void SKVideo_VideoPlay()
        {
            string strRecordPath = "";
            int intVideoRecordEnable = 0;
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                strRecordPath = CurrentVideoPlaySet.VideoRecordFilePath;
                intVideoRecordEnable = 1;
            }
            SDK_SKVideoSDK.p_sdkc_start_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel, intptrPlayMain, intVideoRecordEnable, 15, 5, strRecordPath);
            if (CurrentVideoPlaySet.PerVideoRecord)
            {
                SDK_SKVideoSDK.p_sdkc_get_revideo_data(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel, CurrentVideoPlaySet.PreVideoRecordFilePath);
            }
            VideoPlayState = Enum_VideoPlayState.InPlayState;
        }


        private void SKVideo_VideoClose()
        {
            SDK_SKVideoSDK.p_sdkc_stop_rt_video(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel, intptrPlayMain);
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
        }

        private void SKVideo_PTZControl(Enum_VideoPTZControl PTZControl,bool bolStart)
        {
            if (!bolStart)
            {
                SDK_SKVideoSDK.p_sdkc_onvif_ptz_stop(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel);
                return;
            }
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
            SDK_SKVideoSDK.p_sdkc_onvif_ptz_continue_move(CurrentVideoInfo.DVSAddress, CurrentCameraInfo.Channel, Temp_iXSpeed, Temp_iYSpeed, Temp_iZSpeed);
        }
        #endregion

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
                VideoPlayEventCallBack(Enum_VideoPlayEventType.DeviceNotExist);
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
                VideoPlayEventCallBack(Enum_VideoPlayEventType.DevLoginException);
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
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed);
                return;
            }

            SDK_HuaMai.OPEN_VIDEO_RES videoRes = new SDK_HuaMai.OPEN_VIDEO_RES();
            iResult = SDK_HuaMai.hm_pu_start_video(iOpenVideo, ref videoRes);
            if (iResult != ProgConstants.c_iHuaMaiSDK_Result_Success)
            {
                //开始播放视频异常
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException);
                return;
            }
            SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //IntPtr iWnd = pictureBox1.Handle;
            iPort = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_video_display_open_port(this.Handle, ref disp_op, ref iPort);
            iResult = SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
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
            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
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
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;
                default:
                    //不做操作
                    break;
            }
        }



        #endregion


        #endregion

        #region Axis 安迅士

        private AxisMediaParser parser;
        private AxisMediaViewer viewer;
        private int viewerWidth;
        private int viewerHeight;

        #region 基本事件
        private void Axis_VideoPlay()
        {
            Task.Factory.StartNew(() =>
            {
                // Create AXIS Media Parser and AXIS Media Viewer components
                parser = new AxisMediaParser();
                viewer = new AxisMediaViewer();
            }).Wait();

            //事件注册
            parser.OnVideoSample += OnVideoSample;
            parser.OnAudioSample += OnAudioSample;
            parser.OnMetaDataSample += OnMetaDataSample;
            parser.OnError += OnError;

            //流媒体参数
            parser.ShowLoginDialog = true;
            string strUrl = "axrtsphttp://" + CurrentVideoInfo.DVSAddress + "/axis-media/media.amp?videocodec=JPEG";
            parser.MediaURL = strUrl;
            parser.MediaUsername = CurrentVideoInfo.UserName;
            parser.MediaPassword = CurrentVideoInfo.Password;

            //设置页面参数
            viewer.VideoRenderer = (int)AMV_RENDER_OPTIONS.AMV_VIDEO_RENDERER_EVR;      //视频解码器，注意回放视频是要同一
            //图片回调
            //viewer.EnableOnDecodedImage = true;
            //viewer.OnDecodedImage += OnDecodedImage;
            //viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_RGB24;
            viewer.EnableOnDecodedImage = false;
            viewer.ColorSpace = (short)AMV_COLOR_SPACE.AMV_CS_YUY2;
            viewer.LiveMode = true;     //实时模式

            int cookieID;
            int numberOfStreams;
            object objmediaTypeBuffer;
            parser.Connect(out cookieID, out numberOfStreams, out objmediaTypeBuffer); //连接
            viewer.Init(0, objmediaTypeBuffer, picPlayMain.Handle.ToInt64());               //初始化
            //viewer.GetVideoSize(out viewerWidth, out viewerHeight);
            viewer.SetVideoPosition(0, 0, picPlayMain.Width, picPlayMain.Height);
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lstVideoRecord = new List<byte>();
                byte[] bytsMediaType = (byte[])objmediaTypeBuffer;
                lstVideoRecord.AddRange(BitConverter.GetBytes(bytsMediaType.Length));
                lstVideoRecord.AddRange(bytsMediaType);
            }
            viewer.Start();
            parser.Start();
            VideoPlayState = Enum_VideoPlayState.Connecting;
        }

        private void Axis_VideoColse()
        {
            if (parser.Status == (int)AMP_STATUS.AMP_STATUS_RUNNING)
            {
                parser.Stop();
                viewer.Stop();
            }
            if (CurrentVideoPlaySet.VideoRecordEnable && lstVideoRecord.Count > 0)
            {
                Axis_GenerateRecord(CurrentVideoPlaySet.VideoRecordFilePath);
            }
            parser.OnVideoSample -= OnVideoSample;
            parser.OnAudioSample -= OnAudioSample;
            parser.OnMetaDataSample -= OnMetaDataSample;
            parser.OnError -= OnError;
            viewer.OnDecodedImage -= OnDecodedImage;
            Marshal.FinalReleaseComObject(viewer);
            viewer = null;
            Marshal.FinalReleaseComObject(parser);
            parser = null;
        }

        private void Axis_GenerateRecord(string strVideoRecordPath)
        {
            if (lstVideoRecord.Count > 0)
            {

                if (!strVideoRecordPath.EndsWith(".bin"))
                {
                    //不存在文件名称
                    CommonMethod.Common.CreateFolder(strVideoRecordPath);//创建文件夹
                    StringBuilder sbRecFilePath = new StringBuilder();
                    sbRecFilePath.Append(strVideoRecordPath);
                    sbRecFilePath.Append("\\" + CurrentVideoInfo.DVSNumber);                                //视频设备编号
                    sbRecFilePath.Append("_" + CurrentCameraInfo.Channel.ToString().PadLeft(2, '0'));       //通道号
                    sbRecFilePath.Append("_" + DateTime.Now.ToString("yyyyMMddHHmmss"));                    //时间
                    sbRecFilePath.Append("_" + "06.bin");                                                   //分类后缀及文件格式
                    strVideoRecordPath = sbRecFilePath.ToString();
                }
                else
                {
                    string Temp_strUpperLevelFolderPath = strVideoRecordPath.Substring(0, strVideoRecordPath.LastIndexOf("\\"));
                    CommonMethod.Common.CreateFolder(strVideoRecordPath);//创建文件夹
                }
                //统一写入文件
                using (FileStream f = new FileStream(strVideoRecordPath, FileMode.Create))
                {
                    f.Write(lstVideoRecord.ToArray(), 0, lstVideoRecord.Count);
                }
                lstVideoRecord = new List<byte>();
            }
        }

        #endregion

        #region 回调事件
        /// <summary>
        /// 回调_视频信息
        /// </summary>
        /// <param name="cookieID"></param>
        /// <param name="sampleType"></param>
        /// <param name="sampleFlags"></param>
        /// <param name="startTime"></param>
        /// <param name="stopTime"></param>
        /// <param name="SampleArray"></param>
        private void OnVideoSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
        {
            #region 视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = (byte[])SampleArray;
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
            #endregion
            long renderStartTime = 0;
            long renderStopTime = 1;
            if ((long)startTime + parser.LiveTimeOffset > 0)
            {
                renderStartTime = (long)startTime + parser.LiveTimeOffset;
                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
            }
            viewer.RenderVideoSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);
            VideoPlayState = Enum_VideoPlayState.InPlayState;
        }
        void UpdateTimeDisplay(DateTime time)
        {
            if (InvokeRequired)
            {
                // If called from a non UI thread, let the UI thread perform the call 
                BeginInvoke(new Action<DateTime>(UpdateTimeDisplay), new object[] { time });
                return;
            }

            // Update the time label
            this.Text = time.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }
        // Event handler from the parser for each audio frame buffer
        private void OnAudioSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, object SampleArray)
        {
            // Let viewer render audio sample
            //视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = (byte[])SampleArray;
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
            // Add LiveTimeOffset to original timestamp for optimal latency when rendering
            long renderStartTime = 0;
            long renderStopTime = 1;
            if ((long)startTime + parser.LiveTimeOffset > 0)
            {
                renderStartTime = (long)startTime + parser.LiveTimeOffset;
                renderStopTime = (long)stopTime + parser.LiveTimeOffset;
            }
            viewer.RenderAudioSample(sampleFlags, (ulong)renderStartTime, (ulong)renderStopTime, SampleArray);
        }

        private void OnMetaDataSample(int cookieID, int sampleType,
            int sampleFlags, ulong startTime, ulong stopTime, string metaData)
        {
            //视频录像
            if (CurrentVideoPlaySet.VideoRecordEnable)
            {
                lock (objVideoRecordLock)
                {
                    byte[] bufferBytes = System.Text.Encoding.UTF8.GetBytes(metaData);
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleType));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(sampleFlags));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(startTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(stopTime));
                    lstVideoRecord.AddRange(BitConverter.GetBytes(bufferBytes.Length));
                    lstVideoRecord.AddRange(bufferBytes);
                }
            }
        }

        /// <summary>
        /// 回调_异常事件
        /// </summary>
        /// <param name="errorCode"></param>
        private static void OnError(int errorCode)
        {
            AMP_ERROR ampError = (AMP_ERROR)errorCode;
            MessageBox.Show(string.Format("Parser OnErrorEventHandler {1} (0x{0:X})",
                errorCode, ampError.ToString()));
        }

        /// <summary>
        /// 回调_图片解码
        /// </summary>
        /// <param name="StartTime"></param>
        /// <param name="ColorSpace"></param>
        /// <param name="SampleArray"></param>
        private void OnDecodedImage(ulong StartTime, short ColorSpace, object SampleArray)
        {
            //byte[] decodedData = (byte[])SampleArray;
            //Bitmap bm = new Bitmap(CreateBitmap(decodedData));
            //bm.Save("firstImage.jpeg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private static Bitmap CreateBitmap(byte[] data)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
            {
                int bitmapFileHeaderSize = 14;
                binaryWriter.Write('B');
                binaryWriter.Write('M');
                binaryWriter.Write(bitmapFileHeaderSize + data.Length); // 4 bytes
                binaryWriter.Write((short)0);
                binaryWriter.Write((short)0);
                int bitmapInfoHeaderLength = BitConverter.ToInt32(data, 0);
                binaryWriter.Write(bitmapFileHeaderSize + bitmapInfoHeaderLength);
                binaryWriter.Write(data);

                return (Bitmap)Image.FromStream(memoryStream);
            }
        }

        #endregion

        #endregion

        #region HikDVR 海康DVR 直接访问模式

        #region 全局变量
        int _intDVRHwd;
        int intRet;
        #endregion

        #region 基本事件
        /// <summary>
        /// 海康视频播放
        /// </summary>
        public void HikDVR_VideoPlay()
        {
            NET_DVR_DEVICEINFO_V30 dev = new NET_DVR_DEVICEINFO_V30();

            _intDVRHwd = NET_DVR_Login_V30(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref dev);
            if (_intDVRHwd < 0)
            {
                //登陆失败
                return;
            }


            NET_DVR_PREVIEWINFO lpPreviewInfo = new NET_DVR_PREVIEWINFO();
            lpPreviewInfo.hPlayWnd = intptrPlayMain;//预览窗口
            lpPreviewInfo.lChannel = CurrentCameraInfo.Channel;
            lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
            lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流


            //NET_DVR_CLIENTINFO cli = new NET_DVR_CLIENTINFO();
            //cli.lLinkMode = 0;// 设置连接方式  /*  最高位(31)为 0 表示主码流，为 1 表示子码流，0－30 位表示码流连接方式：0：TCP方式,1：UDP 方式,2：多播方式,3 - RTP方式，4—音视频分开 */ 
            //cli.lChannel = channel + 32;
            //cli.hPlayWnd = playHandle;

            // 开始播放视频
            //Thread.Sleep(50);
            IntPtr pUser = new IntPtr();
            REALDATACALLBACK RealData = new REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数

            //intRet = NET_DVR_RealPlay_V30(_intDVRHwd, ref cli, null, pUser, 1);//130814
            intRet = NET_DVR_RealPlay_V40(_intDVRHwd, ref lpPreviewInfo, null, pUser);//140521
            //intRet = NET_DVR_RealPlay(_intDVRHwd, ref cli);//130814
            NET_DVR_OpenSound(intRet);//140609
            if (intRet < 0)
            {
                videoPlayState = Enum_VideoPlayState.InPlayState;
                return;
            }
        }

        

        /// <summary>
        /// 海康视频关闭
        /// </summary>
        public void HikDVR_VideoClose()
        {
            NET_DVR_StopRealPlay(intRet);
            NET_DVR_Logout(_intDVRHwd);
            return;
        }
        #endregion

        #region 回调函数
        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {
        }
        #endregion

        #endregion


        #region XMVideo 雄迈SDK
        #region 全局变量
        int lLogin = -1;
        public int m_iPlayhandle;	//play handle
        #endregion

        #region 基本事件
        /// <summary>
        /// 雄迈视频播放
        /// </summary>
        private void XMVideo_VideoPlay()
        {
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            #region 连接类型选择 
            CurrentVideoPlaySet.ConnType = CommonMethod.Verification.isIP(CurrentVideoInfo.DVSAddress) ? Enum.Enum_VideoConnType.Direct : Enum.Enum_VideoConnType.Clound;
            if (CurrentVideoPlaySet.ConnType == Enum.Enum_VideoConnType.Clound)
            {
                //雄迈云
                lLogin = SDK_XMSDK.H264_DVR_Login_Cloud(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, "");
                //lLogin = SDK_XMSDK.H264_DVR_LoginEx_V2(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,1, out nError, SocketStyle.TCPSOCKET);
                //lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,  out nError, SocketStyle.PLUGLANSOCKET);
            }
            else
            {
                //默认直连
                lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, SocketStyle.TCPSOCKET);
            }
            //lLogin = SDK_XMSDK.H264_DVR_Login("192.168.2.165", 34567, "admin", "123456", out OutDev, out nError, SocketStyle.TCPSOCKET);
            #endregion

            if (lLogin <= 0)
            {
                CurrentVideoInfo.NetworkState = 0;//离线
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed); //连接异常
                return;
            }
            
            VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess); //连接成功
            H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            playstru.nChannel = CurrentCameraInfo.Channel;
            //playstru.nChannel = 0;
            playstru.nStream =0;
            playstru.nMode = 1;
            playstru.hWnd = intptrPlayMain;
            m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(lLogin), ref playstru);
            if (m_iPlayhandle > 0)
            {
                CurrentVideoInfo.NetworkState = 1;//在线
                VideoPlayState = Enum_VideoPlayState.InPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay); //连接成功
                if (CurrentVideoPlaySet.VideoRecordEnable)
                {
                    XMVideo_VideoRecordStart(CurrentVideoPlaySet.VideoRecordFilePath);
                }
            }
            else
            {

                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                int intResult = SDK_XMSDK.H264_DVR_GetLastError();
                //视频播放异常，后期根据 H264_DVR_GetLastError 获取错误码进行操作及 提示
                switch (intResult)
                {
                    case (int)SDK_RET_CODE.H264_DVR_NATCONNET_REACHED_MAX:
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnNumMax); //连接成功
                        break;
                    default:
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException); //连接成功
                        break;
                }
            }
        }

        /// <summary>
        /// 雄迈视频录像
        /// </summary>
        public bool XMVideo_VideoRecordStart(string strRecFilePath)
        {
            StringBuilder sbRecFilePath = new StringBuilder();
            if (string.IsNullOrEmpty(strRecFilePath))
            {
                //不存在路径 使用默认路径 
                strRecFilePath = ProgConstants.strXMVideo_RecDicPath + "\\" + CurrentVideoInfo.DVSAddress;    //默认路径
                if (!Directory.Exists(strRecFilePath))
                {
                    //文件夹不存在，创建文件夹
                    Directory.CreateDirectory(strRecFilePath);
                }
            }
            if (!strRecFilePath.EndsWith(".h264"))
            {
                //后缀错误，使用默认文件生成
                //默认路径格式 [当前工作路径/XMVideoRecFile/DVSAddress/时间(yyyyMMddHHmmss)_通道号(01)]

                strRecFilePath += "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel, CurrentVideoInfo.VideoType);
            }
            bool bolResult = SDK_XMSDK.H264_DVR_StartLocalRecord(m_iPlayhandle, strRecFilePath, Convert.ToInt32(MEDIA_FILE_TYPE.MEDIA_FILE_NONE));
            return bolResult;
        }

        /// <summary>
        /// 雄迈视频关闭
        /// </summary>
        public void XMVideo_VideoClose()
        {
            int intResult = -1;
            bool bolResult = false;
            bolResult = SDK_XMSDK.H264_DVR_StopLocalPlay(m_iPlayhandle);   //停止录像
            intResult = SDK_XMSDK.H264_DVR_StopRealPlay(m_iPlayhandle, (uint)intptrPlayMain);
            intResult = SDK_XMSDK.H264_DVR_Logout(lLogin);
            return;
        }


        /// <summary>
        /// 云台控制
        /// </summary>
        private void XMVideo_PTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            SDK_XMSDK.PTZ_ControlType XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.EXTPTZ_TOTAL;
            //云台控制类型改变
            switch (PTZControl) //云视通仅 上下
            {
                case Enum_VideoPTZControl.PTZControl_Up:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.TILT_UP;
                    break;
                case Enum_VideoPTZControl.PTZControl_Down:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.TILT_DOWN;
                    break;
                case Enum_VideoPTZControl.PTZControl_Left:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_LEFT;
                    break;
                case Enum_VideoPTZControl.PTZControl_Right:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_RIGHT;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftUp:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_LEFTTOP;
                    break;
                case Enum_VideoPTZControl.PTZControl_LeftDown:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_LEFTDOWN;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightUp:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_RIGTHTOP;
                    break;
                case Enum_VideoPTZControl.PTZControl_RightDown:
                    XMVideoPtzType = SDK_XMSDK.PTZ_ControlType.PAN_RIGTHDOWN;
                    break;
            }
            if (XMVideoPtzType != SDK_XMSDK.PTZ_ControlType.EXTPTZ_TOTAL)
            {

                Console.WriteLine("PTZControl" + "_" + bolStart.ToString());
                //Cono
                //SDK_JCSDK.JCSDK_SendPTZCommand(intCloundSee_ConnID, XMVideoPtzType, bolStart);
                bool bolTemp = !bolStart;
                bool bolResult = SDK_XMSDK.H264_DVR_PTZControl(lLogin, CurrentCameraInfo.Channel, Convert.ToInt32(XMVideoPtzType), bolTemp, CurrentVideoPlaySet.PTZSpeed);
                StringBuilder sbDisplayInfo = new StringBuilder();
                sbDisplayInfo.Append(DateTime.Now.ToString() + "_");
                sbDisplayInfo.Append("PTZContorl");
                sbDisplayInfo.Append("_" + lLogin);
                sbDisplayInfo.Append("_" + CurrentCameraInfo.Channel);
                sbDisplayInfo.Append("_" + XMVideoPtzType.ToString());
                sbDisplayInfo.Append("_" + bolTemp);
                sbDisplayInfo.Append("_" + CurrentVideoPlaySet.PTZSpeed);
                sbDisplayInfo.Append("Result:" + bolResult.ToString());
                Console.WriteLine(sbDisplayInfo.ToString());
            }
        }

        #endregion

        #region 回调函数

        #endregion

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
                case Enum_VideoType.CloundSee:  //云视通设备
                    CloundSee_VideoPlay();
                    break;
                case Enum_VideoType.IPCWA:      //普顺达设备（SK835）
                    IPCWA_VideoPlay();
                    break;
                case Enum_VideoType.Ezviz:
                    Ezviz_VideoPlay();          //萤石云设备
                    break;
                case Enum_VideoType.SKVideo:
                    SKVideo_VideoPlay();        //时刻视频设备
                    break;
                case Enum_VideoType.HuaMaiVideo://华迈设备
                    HuaMaiVideo_VideoPlay();
                    break;
                case Enum_VideoType.Axis:       //安讯士
                    Axis_VideoPlay();
                    break;
                case Enum_VideoType.HikDVR:
                    HikDVR_VideoPlay();
                    break;
                case Enum_VideoType.XMaiVideo:
                    XMVideo_VideoPlay();
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
            if (VideoPlayState != Enum_VideoPlayState.VideoInfoNull)
            {
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_VideoClose();
                        break;
                    case Enum_VideoType.IPCWA:
                        IPCWA_VideoClose();
                        break;
                    case Enum_VideoType.Ezviz:
                        Ezviz_VideoClose();
                        break;
                    case Enum_VideoType.SKVideo:
                        SKVideo_VideoClose();
                        break;
                    case Enum_VideoType.HuaMaiVideo:
                        HuaMaiVideo_VideoClose();
                        break;
                    case Enum_VideoType.Axis:
                        Axis_VideoColse();
                        break;
                    case Enum_VideoType.HikDVR:
                        HikDVR_VideoClose();
                        break;
                    case Enum_VideoType.XMaiVideo:
                        XMVideo_VideoClose();
                        break;

                }
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
            }
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
                    case Enum_VideoType.Ezviz:
                        Ezviz_PTZControl(PTZControl, bolStart);
                        break;
                    case Enum_VideoType.SKVideo:
                        SKVideo_PTZControl(PTZControl, bolStart);
                        break;
                    case Enum_VideoType.XMaiVideo:
                        XMVideo_PTZControl(PTZControl, bolStart);
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
            if (CurrentVideoInfo != null&& VideoPlayState==Enum_VideoPlayState.InPlayState)
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
                    case Enum_VideoType.Axis:
                        viewer.SetVideoPosition(0, 0, picPlayMain.Width, picPlayMain.Height);
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

    }
}
