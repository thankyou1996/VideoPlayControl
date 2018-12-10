using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PublicClassCurrency;
using VideoPlayControl.Enum;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoPlay
{
    class VideoPlay_XMai : IVideoPlay
    {
        VideoInfo currentVideoInfo;
        #region 全局变量
        int lLogin = -1;
        public int m_iPlayhandle;	//play handle
        /// <summary>
        /// 重复播放次数
        /// </summary>
        public const int c_intMaxRealPlayNum = 5;

        public bool bolRequestRealVideoFlag = false;
        #endregion

        public VideoInfo CurrentVideoInfo
        {
            get { return currentVideoInfo; }
            set
            {

                string Temp_strKey = GetDevListKey(value);
                if (currentVideoInfo != null && SDK_XMSDK.dicXMVideoList.ContainsKey(Temp_strKey))
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
        /// <summary>
        /// 音频通道状态
        /// </summary>
        public Enum_VideoPlaySoundState SoundState { get; set; }
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
            bool bolResule = false;
            int intResult = -1;
            bool bolResult = false;
            bolRequestRealVideoFlag = false;
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "CloseStart");
            bolResult = SDK_XMSDK.H264_DVR_StopLocalPlay(m_iPlayhandle);                        //停止录像
            intResult = SDK_XMSDK.H264_DVR_StopRealPlay(m_iPlayhandle, (uint)intptrPlayMain);   //SDK关闭事件
            currentVideoInfo.VideoLoginStateChangeEvent -= VideoLoginStateChanged;              //程序取消事件注册
            VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "CloseEnd");
            return bolResule;
        }

        public bool VideoPlay()
        {
            bool bolResule = false;
            //currentVideoInfo.VideoLoginStateChangeEvent += VideoLoginStateChanged;//注册事件
            //VideoPlayState = Enum_VideoPlayState.Connecting;//状态置为连接中
            //VideoPlayEventCallBack(Enum_VideoPlayEventType.LoginStart); //开始登陆
            ////如果当前未登录，通过登陆状态改变回调触发实时播放
            ////如果已经登陆，直接获取登陆句柄进行实时预览
            //string Temp_strKey = GetDevListKey(CurrentVideoInfo);
            //if (SDK_XMSDK.DeviceLogin(Temp_strKey))
            //{
            //    lLogin = CurrentVideoInfo.LoginHandle;
            //    VideoRealPlay();
            //}
            VideoPlayEx();
            return bolResule;
        }

        public bool VideoPlayEx()
        {
            bool bolResule = false;
            currentVideoInfo.VideoLoginStateChangeEvent += VideoLoginStateChanged;//注册事件
            VideoPlayState = Enum_VideoPlayState.Connecting;//状态置为连接中
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginStart });//开始登陆
            //如果当前未登录，通过登陆状态改变回调触发实时播放
            //如果已经登陆，直接获取登陆句柄进行实时预览
            string Temp_strKey = GetDevListKey(CurrentVideoInfo);
            if (SDK_XMSDK.DeviceLogin(Temp_strKey))
            {
                lLogin = CurrentVideoInfo.LoginHandle;
                Thread t = new Thread(new ThreadStart(VideoRealPlay));
                t.IsBackground = true;
                t.Start();
            }
            return bolResule;
        }

        private void VideoRealPlay()
        {

            H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            playstru.nChannel = CurrentCameraInfo.Channel - 1;
            playstru.nStream = 1;
            playstru.nMode = 0;
            playstru.hWnd = intptrPlayMain;
            bolRequestRealVideoFlag = true;
            int Temp_intCount = 0;
            while (bolRequestRealVideoFlag)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestConn });
                m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(lLogin), ref playstru);
                if (m_iPlayhandle > 0)
                {
                    CurrentVideoInfo.NetworkState = 1;//在线
                    VideoPlayState = Enum_VideoPlayState.InPlayState;
                    VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });//开始播放
                    bolRequestRealVideoFlag = false;
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
                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.ConnNumMax });//达到最大连接数量
                            break;
                        case (int)SDK_RET_CODE.H264_DVR_INVALID_HANDLE: //句柄错误
                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException, EventContent = intResult.ToString() + "句柄错误" });//视频播放异常
                            //退出,重新登陆
                            //注意: 有可能是后台登陆成功后触发这个错误 重新调用登陆接口打开新线程进行登陆
                            //将重连播放的标签置为Flase 结束前一个登陆线程
                            int Temp_intResult = SDK_XMSDK.H264_DVR_Logout(lLogin);
                            CurrentVideoInfo.LoginHandle = -1;
                            CurrentVideoInfo.LoginState = 0;
                            SDK_XMSDK.DeviceLogin(CurrentVideoInfo);
                            bolRequestRealVideoFlag = false;
                            break;
                        default:
                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlayException, EventContent = intResult.ToString() });//视频播放异常
                            break;
                    }
                    Thread.Sleep(2000);
                }
                if (Temp_intCount > c_intMaxRealPlayNum || m_iPlayhandle > 0)
                {
                    bolRequestRealVideoFlag = false;
                }
                Temp_intCount++;
            }
        }

        public void VideoLoginStateChanged(object sender, object VideoLoginStateChangedVideo)
        {
            if (CurrentVideoInfo.LoginState == 1)
            {
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });//登陆成功
                //表示连接成功
                lLogin = CurrentVideoInfo.LoginHandle;
                VideoRealPlay();
            }
            else if (CurrentVideoInfo.LoginState == 2)
            {
                //登陆中
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LogonIn });//登陆中
            }
            else if (CurrentVideoInfo.LoginState == -1)
            {
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException, EventContent = currentVideoInfo.LoginPrompt });//登陆异常
                //TODO 登陆异常  后期完善获取错误码进行信息设置
            }
        }


        public void VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {

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
                    bolResult = SDK_XMSDK.H264_DVR_PTZControl(lLogin, CurrentCameraInfo.Channel - 1, Convert.ToInt32(XMVideoPtzType), bolTemp, CurrentVideoPlaySet.PTZSpeed);
                }
            }
            return bolResult;
        }



        private string GetDevListKey(VideoInfo v)
        {
            StringBuilder sbKey = new StringBuilder();
            sbKey.Append(v.DVSAddress);
            sbKey.Append("_");
            sbKey.Append(v.DVSConnectPort);
            return sbKey.ToString();
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

                strRecFilePath += "\\" + VideoRecordInfoConvert.GetVideoRecordName(CurrentVideoInfo.DVSNumber, CurrentCameraInfo.Channel - 1, CurrentVideoInfo.VideoType);
            }
            bool bolResult = SDK_XMSDK.H264_DVR_StartLocalRecord(m_iPlayhandle, strRecFilePath, Convert.ToInt32(MEDIA_FILE_TYPE.MEDIA_FILE_NONE));
            return bolResult;
        }

        public bool OpenSound()
        {
            return false;
        }

        public bool CloseSound()
        {
            return false;
        }

    }
}
