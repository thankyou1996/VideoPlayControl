using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;
using VideoPlayControl.VideoBasicClass;
using static VideoPlayControl.SDKInterface.SDK_TDWYSDK;

namespace VideoPlayControl.VideoPlay
{
    /// <summary>
    /// 天地伟业
    /// </summary>
    public class VideoPlay_TDWY : IVideoPlay_Basic
    {
        int _iLogonID = -1;
        int m_iConnectId = -1;
        public VideoPlay_TDWY(CameraInfo cInfo)
        {
            CurrentCameraInfo = cInfo;
        
        }
        private void Dispose()
        { 
        
        }

        private void VideoEnvironment_TDWY_MAIN_NOTIFYEvent(Int32 _ulLogonID, Int32 _iWparam, IntPtr _iLParam, IntPtr _iUser)
        {
            if (_ulLogonID == _iLogonID)
            {
                int iMsg = _iWparam & 0xffff;
                //表示属于当前信息登录信息
                switch (iMsg)
                {
                    //登陆状态消息 
                    //param1 登陆IP
                    //param2 登陆ID
                    //param3 登陆状态
                    case NetSDKMsg.WCM_LOGON_NOTIFY:
                        Int32 iStatus = _iLParam.ToInt32();
                        if (iStatus == NetSDKMsg.LOGON_SUCCESS)
                        {
                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginSuccess });
                            //初始化通道列表                         
                            //Int32 iChanNum = 0;
                            //SDK_TDWY.NetClient_GetChannelNum(_iLogonID, ref iChanNum);
                            CLIENTINFO channel = new CLIENTINFO
                            {
                                m_iServerID = _iLogonID,
                                m_iTimeout = 20,
                                m_iNetMode = 1,
                                m_iChannelNo = CurrentCameraInfo.Channel - 1,
                                m_iStreamNO = (CurrentVideoPlaySet.PlayStream == Enum.Enum_VideoStream.SubStream) ? 1 : 0,
                                m_cNetFile = new char[255],
                                m_cRemoteIP = new char[16],
                            };
                            Array.Copy(CurrentVideoInfo.DVSAddress.ToArray(), channel.m_cRemoteIP, CurrentVideoInfo.DVSAddress.Length);
                            //开始接收一路视频数据	
                            UInt32 uiConID = 0;
                            int iRet = SDK_TDWYSDK.NetClient_StartRecv(ref uiConID, ref channel, null);

                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestConn });
                            if (iRet < 0)
                            {
                                //操作失败
                                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestVideoTimeout });
                            }
                            m_iConnectId = Convert.ToInt32(uiConID);
                        }
                        else
                        {
                            //触发相关时间进行提示
                            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
                            Console.WriteLine("登录失败，Status:" + iStatus);
                        }
                        break;
                    case NetSDKMsg.WCM_VIDEO_HEAD_EX:
                        RECT rect = new RECT();
                        SDK_TDWYSDK.NetClient_StartPlay(m_iConnectId, intptrPlayMain, rect, 0);
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoPlay });
                        break;
                    case NetSDKMsg.WCM_ERR_DIGITCHANNEL_NOT_ENABLED:
                        VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.RequestVideoTimeout });
                        break;
                    default:
                        Console.WriteLine("TDWY- MyMAIN_NOTIFY_V4: " + iMsg);
                        break;
                }
            }
        }

        /// <summary>
        /// 视频播放
        /// </summary>
        /// <returns></returns>
        public override bool VideoPlay()
        {
            VideoEnvironment.VideoEnvironment_TDWY.MAIN_NOTIFYEvent -= VideoEnvironment_TDWY_MAIN_NOTIFYEvent;
            VideoEnvironment.VideoEnvironment_TDWY.MAIN_NOTIFYEvent += VideoEnvironment_TDWY_MAIN_NOTIFYEvent;
            //1、登录
            SDK_TDWYSDK.LogonPara tInfo = new SDK_TDWYSDK.LogonPara();
            tInfo.iSize = Marshal.SizeOf(tInfo);
            tInfo.iNvsPort = CurrentVideoInfo.DVSConnectPort;
            tInfo.cNvsIP = new char[32];
            Array.Copy(CurrentVideoInfo.DVSAddress.ToArray(), tInfo.cNvsIP, CurrentVideoInfo.DVSAddress.Length);
            tInfo.cUserName = new char[16];
            Array.Copy(CurrentVideoInfo.UserName.ToArray(), tInfo.cUserName, CurrentVideoInfo.UserName.Length);
            tInfo.cUserPwd = new char[16];
            Array.Copy(CurrentVideoInfo.Password.ToArray(), tInfo.cUserPwd, CurrentVideoInfo.Password.Length);
            IntPtr intptr = Marshal.AllocCoTaskMem(tInfo.iSize);
            Marshal.StructureToPtr(tInfo, intptr, true);//false容易造成内存泄漏
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.LoginStart });
            int iRet = SDK_TDWYSDK.NetClient_Logon_V4(0, intptr, tInfo.iSize);
            Marshal.FreeHGlobal(intptr);//释放分配的非托管内存。
            _iLogonID = iRet;
            if (_iLogonID < 0)
            {
                //登录失败
                iRet = SDK_TDWYSDK.NetClient_Logoff(_iLogonID);
                VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.DevLoginException });
                return false;
            }
            //通过回调进行后续操作
            return true;
        }

        public override bool VideoClose()
        {
            VideoEnvironment.VideoEnvironment_TDWY.MAIN_NOTIFYEvent -= VideoEnvironment_TDWY_MAIN_NOTIFYEvent;
            int iRet = SDK_TDWYSDK.NetClient_StopPlay(m_iConnectId);
            iRet = SDK_TDWYSDK.NetClient_StopRecv(m_iConnectId);
            iRet = SDK_TDWYSDK.NetClient_Logoff(_iLogonID);
            VideoPlayCallback(new VideoPlayCallbackValue { evType = Enum_VideoPlayEventType.VideoClose });
            return true;
        }
    }
}
