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

namespace VideoPlayControl
{
    /// <summary>
    /// 视频播放窗口
    /// </summary>
    public partial class VideoPlayWindow : UserControl
    {
        int intx =0;

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
        public Enum_VideoPlayState VideoPlayState = Enum_VideoPlayState.VideoInfoNull;

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
        public delegate void SDKEventCallBackDelegate(object sender, Enum_SDKEventType etType,string strtTag);

        /// <summary>
        /// SDK事件回调事件
        /// </summary>
        public event SDKEventCallBackDelegate SDKEventCallBackEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private void SDKEventCallBack(Enum_SDKEventType etType,string strTag="")
        {
            if (SDKEventCallBackEvent != null)
            {
                SDKEventCallBackEvent(this, etType, strTag);
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
                        this.BeginInvoke(new EventHandler(delegate {
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

        public void Init_VideoInfo(VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
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
            CurrentVideoInfo = videoInfo;
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
            if (CurrentVideoInfo.VideoType == Enum_VideoType.CloundSee)
            {
                CloundSee_VideoLPRECTChanged();
                CloundSee_InitSDKCallBack();
            }
        }

        private void Init_SetVideoInfo()
        {
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
                    VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay);
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
                default:
                    strTag = etType.ToString();
                    break;
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
                    CurrentVideoInfo.NetworkState = 1;
                }
                else if (Temp_NetworkState == -1)
                {
                    CurrentVideoInfo.NetworkState = 0;
                }
                else
                {
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
                //VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
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
            SDK_JCSDK.JCPTZCmdType CloundSee_PTZControl = SDK_JCSDK.JCPTZCmdType.JCPCT_Up;
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
            SDK_JCSDK.JCSDK_SendPTZCommand(intCloundSee_ConnID, CloundSee_PTZControl, bolStart);
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
        
        #region 基本事件

        /// <summary>
        /// 视频播放
        /// </summary>
        public void VideoPlay()
        {
            if (VideoPlayState == Enum_VideoPlayState.InPlayState)
            {
                //处于播放状态，释放
                VideoClose();
            }
            intConnCount++;
            VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess);
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:  //云视通设备
                    CloundSee_VideoPlay();
                    break;
                case Enum_VideoType.IPCWA:      //普顺达设备（SK835）
                    IPCWA_VideoPlay();
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
            if (VideoPlayState==Enum_VideoPlayState.InPlayState)
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
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoClose);
                switch (CurrentVideoInfo.VideoType)
                {
                    case Enum_VideoType.CloundSee:
                        CloundSee_VideoClose();
                        break;
                    case Enum_VideoType.IPCWA:
                        IPCWA_VideoClose();
                        break;
                }
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            }
        }

        /// <summary>
        /// 云台控制
        /// </summary>
        /// <param name="PTZControl"></param>
        /// <param name="bolStart"></param>
        public void VideoPTZControl(Enum_VideoPTZControl PTZControl,bool bolStart)
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
            VideoPlayWindows_Move();
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
