using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    class VideoPlay_XMai : IVideoPlay
    {
        VideoInfo currentVideoInfo;
        #region 全局变量
        int lLogin = -1;
        public int m_iPlayhandle;	//play handle
        #endregion

        public VideoInfo CurrentVideoInfo
        {
            get { return currentVideoInfo; }
            set
            {

                string Temp_strKey = GetDevListKey(value);
                if (currentVideoInfo != null&& SDK_XMSDK.dicXMVideoList.ContainsKey(Temp_strKey))
                {
                    //注销事件
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].VideoLoginStateChangeEvent -= VideoLoginStateChanged;
                }
                if (SDK_XMSDK.dicXMVideoList.ContainsKey(Temp_strKey))
                {
                    #region 数据源数据赋值（避免出现数据源与赋值数据不一致情况）
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSNumber = value.DVSNumber;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].OnlyIntercom = value.OnlyIntercom;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].IntercomEnable = value.IntercomEnable;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].AutoIntercom = value.AutoIntercom;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].VideoPlayTime_Minute = value.VideoPlayTime_Minute;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].PreviewPwd = value.PreviewPwd;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].Password = value.Password;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].UserName = value.UserName;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSChannelNum = value.DVSChannelNum;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSDataPort = value.DVSDataPort;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSConnectPort = value.DVSConnectPort;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSAddress = value.DVSAddress;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSName = value.DVSName;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].DVSType = value.DVSType;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].HostID = value.HostID;
                    SDK_XMSDK.dicXMVideoList[Temp_strKey].Cameras = value.Cameras;
                    #endregion
                }
                else
                {
                    SDK_XMSDK.dicXMVideoList[Temp_strKey] = value;
                }
                currentVideoInfo = SDK_XMSDK.dicXMVideoList[Temp_strKey];

            }
        }
        public CameraInfo CurrentCameraInfo { get; set; }
        public VideoPlaySetting CurrentVideoPlaySet { get; set; }
        public IntPtr intptrPlayMain { get; set; }
        public Enum_VideoPlayState VideoPlayState { get; set; }
        public int VideoplayWindowWidth { get; set; }
        public int VideoplayWindowHeight { get; set; }
        public event VideoPlayEventCallBackDelegate VideoPlayEventCallBackEvent;
        private void VideoPlayEventCallBack(Enum_VideoPlayEventType eventType)
        {
            if (VideoPlayEventCallBackEvent != null)
            {
                VideoPlayEventCallBackEvent(this, eventType);
            }
        }

        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent;
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
            bool bolResule = false;
            int intResult = -1;
            bool bolResult = false;
            bolResult = SDK_XMSDK.H264_DVR_StopLocalPlay(m_iPlayhandle);                        //停止录像
            intResult = SDK_XMSDK.H264_DVR_StopRealPlay(m_iPlayhandle, (uint)intptrPlayMain);   //SDK关闭事件
            currentVideoInfo.VideoLoginStateChangeEvent -= VideoLoginStateChanged;              //程序取消事件注册
            return bolResule;
        }

        public bool VideoPlay()
        {
            bool bolResule = false;
            currentVideoInfo.VideoLoginStateChangeEvent += VideoLoginStateChanged;//注册事件
            VideoPlayState = Enum_VideoPlayState.Connecting;//状态置为连接中
            VideoPlayEventCallBack(Enum_VideoPlayEventType.LoginStart); //开始登陆
            //如果当前未登录，通过登陆状态改变回调触发实时播放
            //如果已经登陆，直接获取登陆句柄进行实时预览
            string Temp_strKey = GetDevListKey(CurrentVideoInfo);
            if (SDK_XMSDK.DeviceLogin(Temp_strKey))
            {
                lLogin = CurrentVideoInfo.LoginHandle;
                VideoRealPlay();
            }
            return bolResule;
        }

        public void VideoLoginStateChanged(object sender ,object VideoLoginStateChangedVideo)
        {
            if(CurrentVideoInfo.LoginState==1)
            {

                VideoPlayEventCallBack(Enum_VideoPlayEventType.LoginSuccess); //登陆成功
                //表示连接成功
                lLogin = CurrentVideoInfo.LoginHandle;
                VideoRealPlay();
            }
            else if (CurrentVideoInfo.LoginState == -1)
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.DevLoginException);
                //TODO 登陆异常  后期完善获取错误码进行信息设置
            }
        }

        
        public bool VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            return false;
        }
        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            bool bolResult = false;
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
                bool bolTemp = !bolStart;
                if (lLogin > 0)
                {
                    bolResult = SDK_XMSDK.H264_DVR_PTZControl(lLogin, CurrentCameraInfo.Channel, Convert.ToInt32(XMVideoPtzType), bolTemp, CurrentVideoPlaySet.PTZSpeed);
                }
            }
            return bolResult;
        }


        private void VideoRealPlay()
        {
            VideoPlayEventCallBack(Enum_VideoPlayEventType.RequestConn); //连接异常
            H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            playstru.nChannel = CurrentCameraInfo.Channel;
            //playstru.nChannel = 0;
            playstru.nStream = 0;
            playstru.nMode = 1;
            playstru.hWnd = intptrPlayMain;
            m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(lLogin), ref playstru);
            if (m_iPlayhandle > 0)
            {

                CurrentVideoInfo.NetworkState = 1;//在线
                VideoPlayState = Enum_VideoPlayState.InPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay); //开始播放
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
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnNumMax); //达到最大连接数量
                        break;
                    default:
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException); //视频播放异常
                        break;
                }
            }
        }


        private string GetDevListKey(VideoInfo v)
        {
            StringBuilder sbKey = new StringBuilder();
            sbKey.Append(v.DVSAddress);
            sbKey.Append("_");
            sbKey.Append(v.DVSConnectPort);
            return sbKey.ToString();
        }
        #region XMVideo 雄迈SDK

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
            //lLogin = SDK_XMSDK.H264_DVR_Login("192d.168.2.165", 34567, "admin", "123456", out OutDev, out nError, SocketStyle.TCPSOCKET);
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
            playstru.nStream = 0;
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
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnNumMax); //达到最大连接数量
                        break;
                    default:
                        VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException); //连接异常
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
    }
}
