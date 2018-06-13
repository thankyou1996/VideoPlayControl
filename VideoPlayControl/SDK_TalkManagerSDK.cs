using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    class SDK_TalkManagerSDK
    {
        #region "API声明"
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void CallBack(IntPtr buffer, int lenght);
        /// <summary>
        /// 初始化客户端
        /// </summary>
        /// <param name="locateIp">绑定IP地址</param>
        /// <param name="LocatePort">本地语音端口</param>
        /// <param name="Index">序号</param>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Start", SetLastError = true)]
        public static extern bool Start(string locateIp, int locatePort);
        /// <summary>
        /// 初始化服务端
        /// </summary>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Init", SetLastError = true)]
        public static extern bool Init();
        /// <summary>
        /// 虚构化服务端
        /// </summary>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Dispose", SetLastError = true)]
        public static extern bool Dispose();
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Stop", SetLastError = true)]
        public static extern bool Stop();
        /// <summary>
        /// 查看客户端状态
        /// </summary>
        /// <returns> 0:未通话 1:已通话</returns>
        /// <remarks></remarks>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Status", SetLastError = true)]
        public static extern int Status();
        /// <summary>
        /// 播放
        /// </summary>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Play", SetLastError = true)]
        public static extern bool Play();
        /// <summary>
        /// 结束播放
        /// </summary>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Close", SetLastError = true)]
        public static extern bool Close();
        /// <summary>
        /// 录音
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_RegistCallback", SetLastError = true)]
        public static extern void RegistCallback(CallBack pro);
        /// <summary>
        /// 录音
        /// </summary>
        /// <returns></returns>
        /// <remarks></remarks>
        [DllImport(ProgConstants.c_strTalkManagerSDKFilePath, EntryPoint = "Server_Send", SetLastError = true)]
        public static extern bool Send(byte[] Buffer, int lenght);
        #endregion

        #region "结构体"

        public enum STATUS_TYPE : int
        {
            /// <summary>
            /// 已经停止
            /// </summary>
            Stopped,
            /// <summary>
            /// 正在工作中
            /// </summary>
            Running
        }

        public enum TALK_STATUS : int
        {
            /// <summary>
            ///  无效的状态
            /// </summary>
            ENUM_STATUS_INVALID,
            /// <summary>
            /// 正在语音通话中
            /// </summary> 
            ENUM_STATUS_TALKING
        }

        #endregion
    }
}
