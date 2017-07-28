using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using System.Runtime.InteropServices;

namespace VideoPlayControl
{
    public partial class VideoPlayWindow : UserControl
    {
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 当前视频播放状态
        /// </summary>
        Enum_VideoPlayState VideoPlayState = Enum_VideoPlayState.VideoInfoNull;

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
        public delegate void SDKEventCallBackDelegate(object sender, Enum_SDKEventType etType,string strTag);

        /// <summary>
        /// SDK事件回调事件
        /// </summary>
        public event SDKEventCallBackDelegate SDKEventCallBackEvent;

        /// <summary>
        /// SDK事件回调
        /// </summary>
        /// <param name="etType"></param>
        /// <param name="strTag"></param>
        private void SDKEventCallBack(Enum_SDKEventType etType,string strTag)
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
        //  云视通_初始化SDK回调
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
            if (etType == SDK_JCSDK.JCEventType.JCET_ConnectOK)
            {
                CloundSee_EventCallBack(etType, "连接成功，开始播放视频");
                SDK_JCSDK.JCSDK_EnableDecoder(intCloundSee_ConnID, true);
                VideoPlayState = Enum_VideoPlayState.InPlayState;
                SDK_JCSDK.JCSDK_SetVideoPreview(intCloundSee_ConnID, intptrPlayMain, intptrCloundSee_PlayRect);
            }
            else
            {
                CloundSee_EventCallBack(etType);
            }
        }


        private void CloundSee_EventCallBack(SDK_JCSDK.JCEventType etType, string strTag="")
        {
            Enum_SDKEventType videoEvType = Enum_SDKEventType.Unrecognized;
            switch (etType)
            {
                case SDK_JCSDK.JCEventType.JCET_ConnectOK:
                    videoEvType = Enum_SDKEventType.ConnectOK;
                break;

                default:
                    strTag = Convert.ToString(etType);
                    break;
            }
            SDKEventCallBack(videoEvType, strTag);
        }
        #endregion

        #region 事件

        /// <summary>
        /// 视频播放
        /// </summary>
        private void CloundSee_VideoPlay()
        {
            bool bolCouldID = !CommonMethod.Verification.isIP(CurrentVideoInfo.DVSAddress);
            int intChannel = 0;
            //.Net2.0 无法获取首个对象 通过循环获取
            foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
            {
                intChannel = kv.Value.Channel;
                break;
            }
            intCloundSee_ConnID = SDK_JCSDK.JCSDK_Connect(CurrentVideoInfo.DVSAddress,
                                    CurrentVideoInfo.DVSConnectPort,
                                    intChannel,
                                    CurrentVideoInfo.UserName,
                                    CurrentVideoInfo.Password,
                                    bolCouldID,
                                    "");

        }

        /// <summary>
        /// 关闭视频播放
        /// </summary>
        public void CloundSee_VideoClose()
        {
            SDK_JCSDK.JCSDK_Disconnect(intCloundSee_ConnID);
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
            switch (CurrentVideoInfo.VideoType)
            {
                case Enum_VideoType.CloundSee:
                    CloundSee_PTZControl(PTZControl, bolStart);
                    break;
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
                            SDK_JCSDK.JCSDK_SetVideoPreview(intCloundSee_ConnID, intptrPlayMain, intptrCloundSee_PlayRect);
                        }
                        break;
                }
            }
        }

        #endregion
        
    }
}
