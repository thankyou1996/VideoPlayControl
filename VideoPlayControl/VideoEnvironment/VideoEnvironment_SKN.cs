using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using VideoPlayControl.SDKInterface;

namespace VideoPlayControl.VideoEnvironment
{
    public class VideoEnvironment_SKN
    {
        public static Enum_SDKState s_SKVNVideoSDKState = Enum_SDKState.SDK_Null;
        public static Enum_SDKState SKVNVideoSDKState
        {
            get { return s_SKVNVideoSDKState; }
            private set
            {
                s_SKVNVideoSDKState = value;
                SDKState.SDKStateChange(Enum_VideoType.SKNVideo, s_SKVNVideoSDKState);
            }
        }
        /// <summary>
        /// 时刻H265
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState SKNVideoSDK_Init(string server_addr, int server_port, string client_guid, string sdk_xml_cfg_full_path, string default_save_dir)
        {
            string str = Environment.CurrentDirectory;
            SDK_SKNVideo.SDK_NSK_CLIENT_init(server_addr, server_port, client_guid, sdk_xml_cfg_full_path, default_save_dir);
            callbackvalue = new SDK_SKNVideo.CallBack(callback);
            SDK_SKNVideo.SDK_NSK_ALL_regeist_msg_callback(callbackvalue);
            //SDK_SKNVideo.SDK_NSK_ALL_open_console();
            SKVNVideoSDKState = Enum_SDKState.SDK_Init;
            return SKVNVideoSDKState;
        }

        /// <summary>
        /// 时刻H265 释放
        /// </summary>
        /// <returns></returns>
        public static Enum_SDKState SKNVideoSDK_Release()
        {
            SKVNVideoSDKState = Enum_SDKState.SDK_Release;
            return SKVNVideoSDKState;
        }

        private static SDK_SKNVideo.CallBack callbackvalue;

        public static void callback(int msg_id, string msg_info, int arg1, int arg2, IntPtr data1, int data1_len, IntPtr data2, int data2_len)
        {
            Console.WriteLine("callback " + msg_id + "  " + msg_info);
            string strGuid = Marshal.PtrToStringAnsi(data1);
            switch (msg_info)
            {
                case "Download progress.":
                    break;

                case "Download done.":

                    break;

                case "Device event":
                    string streventdata= Marshal.PtrToStringAnsi(data2);
                    break;

            }
        }

    }
}
