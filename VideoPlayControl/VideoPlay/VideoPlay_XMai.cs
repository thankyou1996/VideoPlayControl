using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using PublicClassCurrency;

namespace VideoPlayControl.VideoPlay
{
    class VideoPlay_XMai : IVideoPlay
    {
        public VideoInfo CurrentVideoInfo { get; set; }
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

        public bool VideoClose()
        {
            bool bolResule = false;
            int intResult = -1;
            bool bolResult = false;
            bolResult = SDK_XMSDK.H264_DVR_StopLocalPlay(m_iPlayhandle);   //停止录像
            intResult = SDK_XMSDK.H264_DVR_StopRealPlay(m_iPlayhandle, (uint)intptrPlayMain);
            intResult = SDK_XMSDK.H264_DVR_Logout(lLogin);
            return bolResule;
        }

        public bool VideoPlay()
        {
            bool bolResule = false;
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            new Thread(test).Start();

            //#region 连接类型选择 
            //CurrentVideoPlaySet.ConnType = CommonMethod.Verification.isIP(CurrentVideoInfo.DVSAddress) ? Enum.Enum_VideoConnType.Direct : Enum.Enum_VideoConnType.Clound;
            //if (CurrentVideoPlaySet.ConnType == Enum.Enum_VideoConnType.Clound)
            //{
            //    //雄迈云
            //    lLogin = SDK_XMSDK.H264_DVR_Login_Cloud(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, "");
            //    //lLogin = SDK_XMSDK.H264_DVR_LoginEx_V2(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,2, out nError, SocketStyle.TCPSOCKET);
            //    //lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,  out nError, SocketStyle.PLUGLANSOCKET);
            //}
            //else
            //{
            //    //默认直连
            //    lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, SocketStyle.TCPSOCKET);
            //}
            ////lLogin = SDK_XMSDK.H264_DVR_Login("192.168.2.165", 34567, "admin", "123456", out OutDev, out nError, SocketStyle.TCPSOCKET);
            //#endregion

            //if (lLogin <= 0)
            //{
            //    CurrentVideoInfo.NetworkState = 0;//离线
            //    VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            //    VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed); //连接异常
            //    bolResule = false ;
            //}

            //VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess); //连接成功
            //H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            //playstru.nChannel = CurrentCameraInfo.Channel;
            ////playstru.nChannel = 0;
            //playstru.nStream = 0;
            //playstru.nMode = 1;
            //playstru.hWnd = intptrPlayMain;
            //m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(lLogin), ref playstru);
            //if (m_iPlayhandle > 0)
            //{
            //    CurrentVideoInfo.NetworkState = 1;//在线
            //    VideoPlayState = Enum_VideoPlayState.InPlayState;
            //    VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlay); //连接成功
            //    if (CurrentVideoPlaySet.VideoRecordEnable)
            //    {
            //        XMVideo_VideoRecordStart(CurrentVideoPlaySet.VideoRecordFilePath);
            //    }
            //}
            //else
            //{

            //    VideoPlayState = Enum_VideoPlayState.NotInPlayState;
            //    int intResult = SDK_XMSDK.H264_DVR_GetLastError();
            //    //视频播放异常，后期根据 H264_DVR_GetLastError 获取错误码进行操作及 提示
            //    switch (intResult)
            //    {
            //        case (int)SDK_RET_CODE.H264_DVR_NATCONNET_REACHED_MAX:
            //            VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnNumMax); //达到最大连接数量
            //            break;
            //        default:
            //            VideoPlayEventCallBack(Enum_VideoPlayEventType.VideoPlayException); //连接异常
            //            break;
            //    }
            //}
            return bolResule;

        }

        public void test()
        {
            Console.WriteLine(DateTime.Now.ToString() + "_1");
            bool bolResule = false;
            H264_DVR_DEVICEINFO OutDev;
            int nError = 0;
            VideoPlayState = Enum_VideoPlayState.Connecting;
            #region 连接类型选择 
            CurrentVideoPlaySet.ConnType = CommonMethod.Verification.isIP(CurrentVideoInfo.DVSAddress) ? Enum.Enum_VideoConnType.Direct : Enum.Enum_VideoConnType.Clound;
            if (CurrentVideoPlaySet.ConnType == Enum.Enum_VideoConnType.Clound)
            {
                //雄迈云
                lLogin = SDK_XMSDK.H264_DVR_Login_Cloud(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, "");
                //lLogin = SDK_XMSDK.H264_DVR_LoginEx_V2(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,2, out nError, SocketStyle.TCPSOCKET);
                //lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev,  out nError, SocketStyle.PLUGLANSOCKET);
            }
            else
            {
                //默认直连
                lLogin = SDK_XMSDK.H264_DVR_Login(CurrentVideoInfo.DVSAddress, Convert.ToUInt16(CurrentVideoInfo.DVSConnectPort), CurrentVideoInfo.UserName, CurrentVideoInfo.Password, out OutDev, out nError, SocketStyle.TCPSOCKET);
            }
            Console.WriteLine(DateTime.Now.ToString() + "_2");
            //lLogin = SDK_XMSDK.H264_DVR_Login("192.168.2.165", 34567, "admin", "123456", out OutDev, out nError, SocketStyle.TCPSOCKET);
            #endregion

            if (lLogin <= 0)
            {
                CurrentVideoInfo.NetworkState = 0;//离线
                VideoPlayState = Enum_VideoPlayState.NotInPlayState;
                VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnFailed); //连接异常
                bolResule = false;
            }

            VideoPlayEventCallBack(Enum_VideoPlayEventType.ConnSuccess); //连接成功
            H264_DVR_CLIENTINFO playstru = new H264_DVR_CLIENTINFO();
            playstru.nChannel = CurrentCameraInfo.Channel;
            //playstru.nChannel = 0;
            playstru.nStream = 0;
            playstru.nMode = 1;
            playstru.hWnd = intptrPlayMain;
            m_iPlayhandle = SDK_XMSDK.H264_DVR_RealPlay(Convert.ToInt32(lLogin), ref playstru);
            Console.WriteLine(DateTime.Now.ToString() + "_3");
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
                Console.WriteLine(DateTime.Now.ToString() + "_3");
            }
            Console.WriteLine(DateTime.Now.ToString() + "_4");
        }

        public bool VideoSizeChange(int intLeft, int intRight, int intTop, int intBottom)
        {
            //throw new NotImplementedException();
            return false;
        }


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

        public bool VideoPTZControl(Enum_VideoPTZControl PTZControl, bool bolStart)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region 回调函数

        #endregion

        #endregion
    }
}
