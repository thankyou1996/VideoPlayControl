using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using static VideoPlayControl_UserDemo1.SDK_TLi;

namespace VideoPlayControl_UserDemo1
{
    class Program
    {
        static NETDVR_loginInfo_3g_t ser_LoginInfo;
        static NETDVR_addrInfo_t nETDVR_AddrInfo_T;
        public static void Main(string[] args)
        {
            SDK_TLi.NETDVR_cleanup();
            int ret = SDK_TLi.NETDVR_startup();
            Console.WriteLine(ret);
            nETDVR_AddrInfo_T = new NETDVR_addrInfo_t
            {
                ip = IPToInt("192.168.2.18"),
                port = 10000
            };
            ret = SDK_TLi.NETDVR_createClient(ref nETDVR_AddrInfo_T);
            Console.WriteLine(ret);
            ser_LoginInfo = new NETDVR_loginInfo_3g_t();
            ser_LoginInfo.name = "TLClient";
            ser_LoginInfo.user = "cs";
            ser_LoginInfo.pass = "cs";
            ret = SDK_TLi.NETDVR_loginServer_3g(ref ser_LoginInfo);
            Console.WriteLine(ret);
            //devices = GetDeviceList(1000);
            //TLVideoEnvironment = Enum_SDKState.SDK_Init;
            Console.ReadKey();
        }


        /// <summary>
        /// 通立DK释放
        /// </summary>
        /// <returns></returns>
        public static bool DHVideoSDK_Release()
        {
            bool bolResult = false;
            //SDK_DaHua.CLIENT_Cleanup();
            //TLVideoEnvironment = Enum_SDKState.SDK_Release;
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
    }
}
