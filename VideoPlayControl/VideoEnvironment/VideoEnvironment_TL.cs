using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using VideoPlayControl.SDKInterface;
using static VideoPlayControl.SDKInterface.SDK_TLi;

namespace VideoPlayControl.VideoEnvironment
{
    public class VideoEnvironment_TL
    {
        public static List<DeviceInfo> devices = new List<DeviceInfo>();
        public static Enum_SDKState s_TLVideoEnvironment = Enum_SDKState.SDK_Null;
        public static Enum_SDKState TLVideoEnvironment
        {
            get { return s_TLVideoEnvironment; }
            private set
            {
                s_TLVideoEnvironment = value;
                SDKState.SDKStateChange(Enum_VideoType.TLiVideo, s_TLVideoEnvironment);
            }
        }
        /// <summary>
        /// 通立SDK初始化
        /// </summary>
        /// <returns></returns>
        public static bool TLVideoEnvironment_Init(string strServerIp,UInt16 intPort,string  strUserName,string strPwd)
        {
            bool bolResult = false;
            NETDVR_startup();
            NETDVR_addrInfo_t nETDVR_AddrInfo_T = new NETDVR_addrInfo_t
            {
                ip = IPToInt(strServerIp),
                port = intPort
            };
            SDK_TLi.NETDVR_createClient(ref nETDVR_AddrInfo_T);
            NETDVR_loginInfo_3g_t ser_LoginInfo = new NETDVR_loginInfo_3g_t();
            ser_LoginInfo.name = "TLClient";
            ser_LoginInfo.user = strUserName;
            ser_LoginInfo.pass = strPwd;
            NETDVR_login_resp_t respInfo = new NETDVR_login_resp_t();
            int ret = SDK_TLi.NETDVR_loginServer_3g(ref ser_LoginInfo, ref respInfo);
            RefreshDeviceList();
            TLVideoEnvironment = Enum_SDKState.SDK_Init;
            return bolResult;
        }

        public static void RefreshDeviceList()
        {
            devices = GetDeviceList(1000);
        }

        /// <summary>
        /// 通立DK释放
        /// </summary>
        /// <returns></returns>
        public static bool DHVideoSDK_Release()
        {
            bool bolResult = false;
            //SDK_DaHua.CLIENT_Cleanup();
            TLVideoEnvironment = Enum_SDKState.SDK_Release;
            return bolResult;
        }

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="maxNum"></param>
        /// <returns></returns>
        private static List<DeviceInfo> GetDeviceList(int maxNum)
        {
            List<DeviceInfo> DeviceList = new List<DeviceInfo>();
            NETDVR_devicenode_t1 m_DeviceListBuf11 = new NETDVR_devicenode_t1();
            int pNum = 0;
            int result = NETDVR_getDeviceList(ref m_DeviceListBuf11, maxNum, ref pNum);
            if (result == (int)NETDVR_RETURN_CODE.NETDVR_SUCCESS)
            {
                if (pNum > 0) 
                {
                    for (int i = 0; i < pNum; i++)
                    {
                        DeviceInfo deviceInfo = new DeviceInfo();
                        deviceInfo.bLogin = false;
                        deviceInfo.devicenode = m_DeviceListBuf11.ss[i];
                        deviceInfo.nHandle = 0;

                        DeviceList.Add(deviceInfo);
                    }
                }
            }
            return DeviceList;//返回列表
        }
        private static uint IPToInt(string strIP)
        {
            //使用long ulong int 会溢出，使用uint就没问题
            return (uint)IPAddress.HostToNetworkOrder((int)IpToInt(strIP));
        }

        private static long IpToInt(string ip)
        {
            char[] separator = new char[] { '.' };
            string[] items = ip.Split(separator);
            return long.Parse(items[0]) << 24 | long.Parse(items[1]) << 16 | long.Parse(items[2]) << 8 | long.Parse(items[3]);
        }


        public static event StartTalkingDelegate TL_StartTalkingEvent;
        public static void TL_StartTalking(object StartTalkingValue)
        {
            if (TL_StartTalkingEvent != null)
            {
                TL_StartTalkingEvent(null, StartTalkingValue);
            }
        }
    }
}
