using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 萤石云SDK
    /// </summary>
    public class SDK_EzvizSDK
    {
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        //[in] szAuthAddr 认证域名 
        //[in] szPlatform 平台域名  
        //[in] szAppId 向平台申请的AppId  5b97c1d157474f96b8d4c75b936a0057
        public static extern int OpenSDK_InitLib(string szAuthAddr, string szPlatform, string szAppId);

        /// <summary>
        /// 释放 SDK环境
        /// </summary>
        /// <returns></returns>
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_FiniLib();

        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_Data_GetDevList(string szAccessToken, int iPageStart, int iPageSize, out IntPtr pBuf, out int iLength);



        public delegate void OpenSDK_MessageHandler(string szSessionId, uint iMsgType, uint iErrorCode, string pMessageInfo, int pUser);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_AllocSession_Old(OpenSDK_MessageHandler YSMessageHanle, int pUser, out IntPtr pSession, out int iSessionLen);

        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_AllocSessionEx(OpenSDK_MessageHandler YSMessageHanle, int pUser, out IntPtr pSession, out int iSessionLen);


        //及其回调函数格式

        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_FreeSession(string pSession);

        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_StartRealPlay_Old(string szSessionId, IntPtr hPlayWnd, string szCameraId, string szAccessToken, int iVideoLevel, string szSafeKey, string szAppKey);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_StopRealPlay_Old(string szSessionId);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_StartSearch(string szSessionId, string szCameraId, string szAccessToken, string szStartTime, string szStopTime);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_StartPlayBack_Old(string szSessionId, IntPtr hPlayWnd, string szCameraId, string szAccessToken, string szSafeKey, string szStartTime, string szStopTime, string szAppKey);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_CapturePicture(IntPtr SID, string szFileName);
        [DllImport("\\ezviz\\OpenNetStream.dll")]
        public static extern int OpenSDK_GetLastErrorCode();
        //****************170417
        [DllImport("\\ezviz\\OpenNetStream.dll", EntryPoint = "OpenSDK_SetDataCallBack", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]//设置数据回调窗口 
        public static extern int OpenSDK_SetDataCallBack(string sessionId, OpenSDK_DataCallBack pDataCallBack, string pUser);
        //回调函数格式
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OpenSDK_DataCallBack(CallBackDateType dateType, IntPtr dateContent, int dataLen, string pUser);
        public enum CallBackDateType
        {
            NET_DVR_SYSHEAD = 0,
            NET_DVR_STREAMDATA = 1,
            NET_DVR_RECV_END = 2,
        };
    }
}
