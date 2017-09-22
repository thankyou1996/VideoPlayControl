using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    public class SDK_EzvizSDK
    {
        /// <summary>
        /// SDK初始化
        /// </summary>
        /// <param name="strAuthAddr"></param>
        /// <param name="strPlatform"></param>
        /// <param name="strAppID"></param>
        /// <returns>0成功 -1失败</returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_InitLib(string strAuthAddr, string strPlatform, string strAppID);

        /// <summary>
        /// SDK释放
        /// </summary>
        /// <returns>0成功 -1失败</returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_FiniLib();
        
        /// <summary>
        /// 发送 Http 请求
        /// </summary>
        /// <param name="szUri"></param>
        /// <param name="szHeaderParam"></param>
        /// <param name="szBody"></param>
        /// <param name="iMessage"></param>
        /// <param name="iLength"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_HttpSendWithWait(string szUri, string szHeaderParam, string szBody, out IntPtr iMessage, out int iLength);

        /// <summary>
        /// 设置Token
        /// </summary>
        /// <param name="intptrToken"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_SetAccessToken(IntPtr intptrToken);

        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="iPageStart"></param>
        /// <param name="iPageSize"></param>
        /// <param name="iMessage"></param>
        /// <param name="iLength"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_Data_GetDevList(string accessToken, int iPageStart, int iPageSize, out IntPtr iMessage, out int iLength);

        public static extern int OpenSDK_Data_GetDeviceInfo(IntPtr intptrToken, int intptr);


        /// <summary>
        /// 申请会话
        /// </summary>
        /// <param name="CallBack"></param>
        /// <param name="UserID"></param>
        /// <param name="pSID"></param>
        /// <param name="SIDLth"></param>
        /// <param name="bSync"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_AllocSession(MsgHandler CallBack, IntPtr UserID, ref IntPtr pSID, ref int SIDLth, bool bSync, uint timeout);

        /// <summary>
        /// 申请会话
        /// </summary>
        /// <param name="CallBack"></param>
        /// <param name="UserID"></param>
        /// <param name="strSession"></param>
        /// <param name="intLength"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_AllocSessionEx(MsgHandler CallBack, IntPtr UserID, out IntPtr strSession, out int intLength);

        /// <summary>
        /// 消息回调
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="MsgType"></param>
        /// <param name="Error"></param>
        /// <param name="Info"></param>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public delegate void MsgHandler(IntPtr SID, EzvizMeesageType MsgType, uint Error, string Info, string strUser);

        /// <summary>
        /// 销毁SDK 操作句柄
        /// </summary>
        /// <param name="intptrSessionID"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_FreeSession(IntPtr intptrSessionID);

        /// <summary>
        /// 销毁SDK 操作句柄
        /// </summary>
        /// <param name="strSessionID"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_FreeSession(string strSessionID);


        /// <summary>
        /// 设备视频清晰度
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="intChannel"></param>
        /// <param name="intVideoLevel"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_SetVideoLevel(IntPtr SID, int intChannel,int intVideoLevel);


        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_SetDataCallBack(IntPtr SID, DataCallBack callback, IntPtr intptrUser);
        
        /// <summary>
        /// 数据回调
        /// </summary>
        /// <param name="enType"></param>
        /// <param name="pData"></param>
        /// <param name="iLen"></param>
        /// <param name="pUser"></param>
        public delegate void DataCallBack(DataType enType, IntPtr pData, int iLen, IntPtr pUser);

        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StartRealPlay(IntPtr SID, IntPtr PlayWnd, string CameraId, string Token, int VideoLevel, string SafeKey, string AppKey, uint pNSCBMsg);

        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StartRealPlay_Old(IntPtr szSessionId, IntPtr hPlayWnd, string szCameraId, string szAccessToken, int iVideoLevel, string szSafeKey, string szAppKey);


        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StopRealPlay(IntPtr SID, uint pNSCBMsg);

        /// <summary>
        /// 开始播放（异步接口）
        /// </summary>
        /// <param name="intptrSessionID"></param>
        /// <param name="intptrPlayWindows"></param>
        /// <param name="strDevSerial"></param>
        /// <param name="intChannel"></param>
        /// <param name="strSafeKey"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StartRealPlayEx(IntPtr intptrSessionID, IntPtr intptrPlayWindows, IntPtr strDevSerial, int intChannel, string strSafeKey);

        /// <summary>
        /// 停止播放（异步接口）
        /// </summary>
        /// <param name="intptrSessinoID"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StopRealPlayEx(IntPtr intptrSessinoID);


        /// <summary>
        /// 获取最后错误码
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_GetLastErrorCode();


        /// <summary>
        /// 获取最后错误描述
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern IntPtr OpenSDK_GetLastErrorDesc();

        #region 自定义方法

        /// <summary>
        /// 获取连接的Token
        /// Token存储至 ProgParameter.strEzviz_AccessToken
        /// </summary>
        /// <returns></returns>
        public static GetTokenResult GetAccessToken()
        {
            try
            {
                IntPtr intptrMessage;
                int intLenght;
                string strUrl = "https://open.ys7.com/api/lapp/token/get";
                StringBuilder sbParameter = new StringBuilder();
                sbParameter.AppendFormat("appKey={0}&", ProgParameter.strEzviz__AppID);
                sbParameter.AppendFormat("appSecret={0}&", ProgParameter.strEzviz_AppSecret);
                OpenSDK_HttpSendWithWait(strUrl, sbParameter.ToString(), "", out intptrMessage, out intLenght);
                string Temp_strResult = Marshal.PtrToStringAnsi(intptrMessage, intLenght);
                JObject Temp_jobject = (JObject)JsonConvert.DeserializeObject(Temp_strResult);
                GetTokenResult RequestResult = (GetTokenResult)Convert.ToInt32(Temp_jobject["code"]);
                if (RequestResult == GetTokenResult.RequestSuccess)
                {
                    //请求成功 赋值
                    ProgParameter.strEzviz_AccessToken = Convert.ToString(Temp_jobject["data"]["accessToken"]);
                }
                return RequestResult;
            }
            catch
            {
                //请求异常
                return GetTokenResult.RequestException;
            }

        }

        #endregion
    }

    /// <summary>
    /// Token 请求结果
    /// </summary>
    public enum GetTokenResult
    {
        /// <summary>
        /// 请求成功
        /// </summary>
        RequestSuccess = 200,

        /// <summary>
        /// 请求异常
        /// </summary>
        RequestException = -1,

        /// <summary>
        /// 参数错误
        /// </summary>
        ParameterError = 10001,

        /// <summary>
        /// AppKey 异常 (AppKey冻结)
        /// </summary>
        AppKeyException = 10005,

        /// <summary>
        /// AppKey 不存在
        /// </summary>
        AppKeyNotExist = 10017,

        /// <summary>
        /// 参数不匹配
        /// </summary>
        ParameterMismatch = 10030,

        /// <summary>
        /// 接口异常
        /// </summary>
        InterFaceException = 49999

    }

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

    /// <summary>
    /// 音视频流数据类型
    /// </summary>
    public enum DataType
    {
        /// <summary>
        /// 流头
        /// </summary>
        NET_DVR_SYAHEAD,

        /// <summary>
        /// 流数据
        /// </summary>
        NET_DVR_STREAMADATA,

        /// <summary>
        /// 结束标记
        /// </summary>
        NET_DVR_RECV_END,
    }


}
