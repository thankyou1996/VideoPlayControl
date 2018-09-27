using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 萤石云SDK
    /// </summary>
    public class SDK_EzvizSDK_Old
    {
        #region 枚举参数
        /// <summary>
        /// 消息类型枚举
        /// </summary>
        public enum EzvizMeesageType
        {
            /// <summary>
            /// 播放异常，通常是设备断线或网络异常造成
            /// </summary>
            INS_PLAY_EXCEPTION,

            /// <summary>
            /// 重连，实时流播放时内部会自动重连
            /// </summary>
            INS_PLAY_RECONNECT,

            /// <summary>
            /// 重连异常
            /// </summary>
            INS_PLAY_RECONNECT_EXCEPTION,

            /// <summary>
            /// 播放开始
            /// </summary>
            INS_PLAY_START,

            /// <summary>
            /// 播放终止
            /// </summary>
            INS_PLAY_STOP,

            /// <summary>
            /// 播放结束，回放结束时会有此消息
            /// </summary>
            INS_PLAY_ARCHIVE_END,

            /// <summary>
            /// 语音对讲开始
            /// </summary>
            INS_VOICETALK_START,

            /// <summary>
            /// 语音对讲停止
            /// </summary>
            INS_VOICETALK_STOP,

            /// <summary>
            /// 语音对讲异常
            /// </summary>
            INS_VOICETALK_EXCEPTION,

            /// <summary>
            /// 云台控制异常
            /// </summary>
            INS_PTZ_EXCEPTION,

            /// <summary>
            /// 查询的录像文件(录像搜索结果)
            /// </summary>
            INS_RECORD_FILE,

            /// <summary>
            /// 录像查询结束（暂不使用）
            /// </summary>
            INS_RECORD_SEARCH_END,

            /// <summary>
            /// 录像查询失败
            /// </summary>
            INS_RECORD_SEARCH_FAILED,

            /// <summary>
            /// 布防成功
            /// </summary>
            INS_DEFENSE_SUCCESS,

            /// <summary>
            /// 布防失败
            /// </summary>
            INS_DEFENSE_FAILED,

            /// <summary>
            /// 回放异常结束，可能是接收数据超时
            /// </summary>
            INS_PLAY_ARCHIVE_EXCEPTION,

            /// <summary>
            /// 云台控制命令发送成功
            /// </summary>
            INS_PTZCTRL_SUCCESS,

            /// <summary>
            /// 云台控制失败
            /// </summary>
            INS_PTZCTRL_FAILED
        }

        #endregion
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        //[in] szAuthAddr 认证域名 
        //[in] szPlatform 平台域名  
        //[in] szAppId 向平台申请的AppId  5b97c1d157474f96b8d4c75b936a0057
        public static extern int OpenSDK_InitLib(string szAuthAddr, string szPlatform, string szAppId);

        /// <summary>
        /// 释放 SDK环境
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_FiniLib();

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_Data_GetDevList(string szAccessToken, int iPageStart, int iPageSize, out IntPtr pBuf, out int iLength);


        /// <summary>
        /// 消息回调事件
        /// </summary>
        /// <param name="szSessionId"></param>
        /// <param name="iMsgType"></param>
        /// <param name="iErrorCode"></param>
        /// <param name="pMessageInfo"></param>
        /// <param name="pUser"></param>
        //[UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void OpenSDK_MessageHandler(string szSessionId, EzvizMeesageType iMsgType, uint iErrorCode, string pMessageInfo, int pUser);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_AllocSession_Old(OpenSDK_MessageHandler YSMessageHanle, int pUser, out IntPtr pSession, out int iSessionLen);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_AllocSessionEx(OpenSDK_MessageHandler YSMessageHanle, int pUser, out IntPtr pSession, out int iSessionLen);
        
        //及其回调函数格式
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_FreeSession(string pSession);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_FreeSession_Old(string pSession);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StartRealPlay_Old(string szSessionId, IntPtr hPlayWnd, string szCameraId, string szAccessToken, int iVideoLevel, string szSafeKey, string szAppKey);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StartRealPlayEx(string szSessionId, IntPtr hPlayWnd, string szVideoId, int szCameraId, string szSafeKey);
        //[DllImport("\\ezviz\\OpenNetStream.dll")]
        //public static extern int OpenSDK_StartRealPlay(string szSessionId, IntPtr hPlayWnd, string szVideoId, int szCameraId, string szSafeKey);
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StartRealPlay(IntPtr SID, IntPtr PlayWnd, string CameraId, string Token, int VideoLevel, string SafeKey, string AppKey, uint pNSCBMsg);


        /// <summary>
        /// 设置视频清晰度
        /// </summary>
        /// <param name="szDevSerial"></param>
        /// <param name="iChannelNo"></param>
        /// <param name="iVideoLevel"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_SetVideoLevel(string szDevSerial, int iChannelNo, int iVideoLevel);


        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StopRealPlay_Old(string szSessionId);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]//SDK关闭播放
        public static extern int OpenSDK_StopRealPlay(IntPtr SID, uint pNSCBMsg);

        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StartSearch(string szSessionId, string szCameraId, string szAccessToken, string szStartTime, string szStopTime);
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_StartPlayBack_Old(string szSessionId, IntPtr hPlayWnd, string szCameraId, string szAccessToken, string szSafeKey, string szStartTime, string szStopTime, string szAppKey);
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_CapturePicture(IntPtr SID, string szFileName);
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath)]
        public static extern int OpenSDK_GetLastErrorCode();
        //****************170417
        [DllImport(ProgConstants.c_strEzvizSDKOldSDKFilePath, EntryPoint = "OpenSDK_SetDataCallBack", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]//设置数据回调窗口 
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
