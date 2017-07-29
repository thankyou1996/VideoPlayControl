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
    public partial class VideoPlayWindow : UserControl
    {
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
        Enum_VideoPlayState VideoPlayState = Enum_VideoPlayState.VideoInfoNull;

        VideoPlaySetting CurrentVideoPlaySet = new VideoPlaySetting();

        public VideoPlayWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 播放窗口句柄
        /// </summary>
        IntPtr intptrPlayMain = IntPtr.Zero;

        private void VideoPlayMain_Load(object sender, EventArgs e)
        {
            intptrPlayMain = picPlayMain.Handle;
        }

        public void Init_VideoInfo(VideoInfo videoInfo)
        {
            CurrentVideoInfo = videoInfo;
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
        }

        public void Init_VideoInfo(VideoInfo videoInfo, VideoPlaySetting videoPlaySet)
        {
            CurrentVideoInfo = videoInfo;
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
        }


        #region 委托事件

        #region SDK状态改变事件回调
        public delegate void SDKStateChangedCallBackDelegate(object sender, Enum_VideoType videoType, Enum_SDKState sdkState);

        public event SDKStateChangedCallBackDelegate SDKStateChangedCallBackEvent;
        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private void SDKStateChangedCallBack(Enum_VideoType videoType, Enum_SDKState sdkState)
        {
            if (SDKStateChangedCallBackEvent != null)
            {
                SDKStateChangedCallBackEvent(this, videoType, sdkState);
            }
        }

        #endregion

        #region SDK事件回调
        /// <summary>
        /// SDK事件回调委托
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        public delegate void SDKEventCallBackDelegate(object sender, Enum_SDKEventType etType, string strTag);

        /// <summary>
        /// SDK事件回调事件
        /// </summary>
        public event SDKEventCallBackDelegate SDKEventCallBackEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private void SDKEventCallBack(Enum_SDKEventType etType, string strTag)
        {
            if (SDKEventCallBackEvent != null)
            {
                SDKEventCallBackEvent(this, etType, strTag);
            }
        }
        #endregion
        #endregion

        #region CloundSeeSDK 云视通

        #region 全局变量
        /// <summary>
        /// 云视通_当前连接ID
        /// </summary>
        int intCloundSee_ConnID = -1;


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
        public void CloundSee_SDKInit(int intLocStartPort = -1, string strTempFileDicPath = "")
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
                    SDKStateChangedCallBack(Enum_VideoType.CloundSee, SDKState.CloundSeeSDKState);
                }
                else
                {
                    SDKState.CloundSeeSDKState = Enum_SDKState.SDK_InitFail;
                    SDKStateChangedCallBack(Enum_VideoType.CloundSee, SDKState.CloundSeeSDKState);
                    return;
                }
            }
            CloundSee_VideoLPRECTChanged();
            CloundSee_InitSDKCallBack();
        }

        /// <summary>
        //  云视通_注册SDK回调
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
            Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
            string strTag = "";
            switch (etType)
            {
                case SDK_JCSDK.JCEventType.JCET_ConnectOK:  //连接成功
                    videoEvType = Enum_SDKEventType.ConnectOK;
                    strTag = "[" + CurrentVideoInfo.DVSAddress + "]连接成功,开始播放视频";
                    CloundSee_VideoPreview(false);
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConTimeout: //连接成功
                    videoEvType = Enum_SDKEventType.ConnectTimeOut;
                    strTag = "[" + CurrentVideoInfo.DVSAddress + "]连接超时";
                    break;

                case SDK_JCSDK.JCEventType.JCET_DisconOK:   //连接断开
                    videoEvType = Enum_SDKEventType.DisconnectOK;
                    strTag = "[" + CurrentVideoInfo.DVSAddress + "]连接正常断开";
                    break;

                case SDK_JCSDK.JCEventType.JCET_ConAbout:
                    videoEvType = Enum_SDKEventType.ConnectAbnormally;
                    strTag = "[" + CurrentVideoInfo.DVSAddress + "]连接异常断开";
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

            intCloundSee_ConnID = SDK_JCSDK.JCSDK_Connect(CurrentVideoInfo.DVSAddress,
                                    CurrentVideoInfo.DVSConnectPort,
                                    CurrentCameraInfo.Channel,
                                    CurrentVideoInfo.UserName,
                                    CurrentVideoInfo.Password,
                                    bolCouldID,
                                    "");
        }

        /// <summary>
        /// 视频预览
        /// </summary>
        private void CloundSee_VideoPreview(bool bolOnlySetPreview=true)
        {
            SDK_JCSDK.JCSDK_EnableDecoder(intCloundSee_ConnID, true);
            SDK_JCSDK.JCSDK_SetVideoPreview(intCloundSee_ConnID, intptrPlayMain, intptrCloundSee_PlayRect);
            if (!bolOnlySetPreview)
            {
                if (CurrentVideoPlaySet.VideoRecordEnable)
                {
                    CloundSee_VideoRecordStart("");
                }
                if (CurrentVideoPlaySet.VideoMonitorEnable)
                {
                    ColundSee_VideoMonitorStart();
                }
            }
        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        public void CloundSee_VideoClose()
        {
            CloundSee_VideoRecordStop();
            CloundSee_VideoMonitorStop();
            SDK_JCSDK.JCSDK_Disconnect(intCloundSee_ConnID);
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
                sbRecDicPath.Append(ProgConstants.ro_strCloundSee_RecDicPath);    //默认路径
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
        public void ColundSee_VideoMonitorStart()
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
        /// 设置预置点位置
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
            switch (PTZControl)
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

            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:
                    CloundSee_VideoPlay();
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

        public void SetPresetPosi(int intPresetPosi)
        {
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:
                    CloundSee_SetPresetPosi(intPresetPosi);
                    break;
            }
        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        public void VideoClose()
        {
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:
                    CloundSee_VideoClose();
                    break;
            }
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
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
                }
            }
                
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
                }
            }
        }
        #endregion
    }
}
