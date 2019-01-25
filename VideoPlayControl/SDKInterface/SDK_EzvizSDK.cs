using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

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
        /// 全局配置信息, 根据ConfigKey进行配置 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_SetConfigInfo(ConfigKey key,int value);


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


        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_Data_GetDeviceInfo(IntPtr szAccessToken, IntPtr szDeviceSerial, out IntPtr pBuf,out int iLength);


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
        public delegate void MsgHandler(IntPtr SID, EzvizMeesageType MsgType, uint Error, string Info, IntPtr iUser);

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
        /// <param name="SID">设备序列号</param>
        /// <param name="intChannel">设备通道号</param>
        /// <param name="intVideoLevel">视频质量，输入范围在0-3之间, 0-流畅; 1-均衡; 2-高清; 3-超清</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_SetVideoLevel(IntPtr SID, int intChannel,int intVideoLevel);


        /// <summary>
        /// 设置视频数据回调
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="callback"></param>
        /// <param name="intptrUser"></param>
        /// <returns></returns>
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
        /// 针对摄像头进行预览, 指定主\子码流 异步接口
        /// </summary>
        /// <param name="szSessionId"></param>
        /// <param name="hPlayWnd"></param>
        /// <param name="szDevSerial"></param>
        /// <param name="iChannelNo"></param>
        /// <param name="szSafeKey"></param>
        /// <param name="iStreamType">主子码流 1-主, 2-子, -1-默认码流类型</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StartPlayWithStreamType(IntPtr szSessionId, IntPtr hPlayWnd, IntPtr szDevSerial, int iChannelNo, string szSafeKey,int  iStreamType );
        /// <summary>
        /// 停止播放（异步接口）
        /// </summary>
        /// <param name="intptrSessinoID"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_StopRealPlayEx(IntPtr intptrSessionID);

        /// <summary>
        /// 云台控制（异步接口）
        /// </summary>
        /// <param name="intptrSessionID"></param>
        /// <param name="intptrDevSerial"></param>
        /// <param name="intChannel"></param>
        /// <param name="enCommand"></param>
        /// <param name="enAction"></param>
        /// <param name="iSpeed"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_PTZCtrlEx(IntPtr intptrSessionID, IntPtr intptrDevSerial, int intChannel, PTZCommand enCommand, PTZAction enAction, int iSpeed);


        /// <summary>
        /// 获取设备能力
        /// </summary>
        /// <param name="DevSerial"></param>
        /// <param name="ChannelNo"></param>
        /// <param name="bUpdate"></param>
        /// <param name="pBuf"></param>
        /// <param name="iBufLen"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_Data_GetDevDetailInfo(string DevSerial, int ChannelNo, bool bUpdate, ref IntPtr pBuf, ref int iBufLen);



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




        #region 音频相关
        /// <summary>
        /// 打开音频通道
        /// </summary>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_OpenSound(IntPtr szSessionId);

        /// <summary>
        /// 关闭音频通道 
        /// </summary>
        /// <param name="szSessionId"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_CloseSound(IntPtr szSessionId);
        #endregion

        #region 自定义方法

        /// <summary>
        /// 获取连接的Token
        /// Token存储至 ProgParameter.strEzviz_AccessToken
        /// </summary>
        /// <returns></returns>
        public static JsonRequestResult GetAccessToken()
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
                JsonRequestResult RequestResult = (JsonRequestResult)Convert.ToInt32(Temp_jobject["code"]);
                if (RequestResult == JsonRequestResult.RequestSuccess)
                {
                    //请求成功 赋值
                    ProgParameter.strEzviz_AccessToken = Convert.ToString(Temp_jobject["data"]["accessToken"]);
                }
                return RequestResult;
            }
            catch
            {
                //请求异常
                return JsonRequestResult.RequestException;
            }

        }


        /// <summary>
        /// 获取设备是否在线
        /// 1在线 0离线 -1 状态未明 -2表示表示无设备权限
        /// </summary>
        /// <param name="strDevSerial"></param>
        /// <returns></returns>
        public static int GetDevOnlineState(string strDevSerial,int intChannel)
        {
           
            //Thread.Sleep(10000);
            int intResult = -1;
            string Temp_strDeviceData = "";
            try
            {
                IntPtr intptrToken = Marshal.StringToHGlobalAnsi(ProgParameter.strEzviz_AccessToken);
                IntPtr intptrDevSerial = Marshal.StringToHGlobalAnsi(strDevSerial);
                IntPtr intptrDevInfo = IntPtr.Zero;
                int intLength;
                int Temp_intResult = SDK_EzvizSDK.OpenSDK_Data_GetDeviceInfo(intptrToken, intptrDevSerial, out intptrDevInfo, out intLength);
                if (Temp_intResult != 0)
                {
                    //接口获取信息失败 状态置为未知
                    intResult = -1;
                }
                else
                {
                    string strResult = Marshal.PtrToStringAnsi(intptrDevInfo);
                    Temp_strDeviceData = strResult;
                    if (!string.IsNullOrEmpty(strResult))
                    {
                        JObject Temp_jobject = (JObject)JsonConvert.DeserializeObject(strResult);
                        JsonRequestResult RequestResult = (JsonRequestResult)Convert.ToInt32(Temp_jobject["result"]["code"]);
                        if (RequestResult == JsonRequestResult.RequestSuccess)
                        {
                            //请求成功 赋值
                            JArray jar = JArray.Parse(Temp_jobject["result"]["data"].ToString());
                            foreach (JObject jo in jar)
                            {
                                if (intChannel.ToString() == jo["cameraNo"].ToString())
                                {
                                    intResult = Convert.ToInt32(jo["status"]);
                                    break;
                                }
                            }
                        }
                        else if (RequestResult == JsonRequestResult.NoDeviceAuthority)
                        {
                            intResult = -2;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                CommonMethod.LogWrite.WritExceptionLog("GetDevOnlineState", ex);
                CommonMethod.LogWrite.WriteEventLog("DevException ", Temp_strDeviceData);
                intResult = -1;
            }
            intResult = -1;
            return intResult;
        }

        /// <summary>
        /// 获取设备清晰度功能
        /// </summary>
        /// <param name="strDvsAddress"></param>
        /// <param name="intChannel"></param>
        /// <returns></returns>
        public static List<SDK_EzvizSDK.VideoQualityInfo> GetDevVideoQualityInfo(string strDvsAddress,int intChannel)
        {
            List<SDK_EzvizSDK.VideoQualityInfo> result = new List<SDK_EzvizSDK.VideoQualityInfo>();
            string strBuf = string.Empty;
            IntPtr hBuf = Marshal.StringToHGlobalAnsi(strBuf);
            int iLen = 0;
            int iRet = SDK_EzvizSDK.OpenSDK_Data_GetDevDetailInfo(strDvsAddress, intChannel, false, ref hBuf, ref iLen);
            if (iRet == 0)
            {
                strBuf = Marshal.PtrToStringAnsi(hBuf);
                Newtonsoft.Json.Linq.JObject json = Newtonsoft.Json.Linq.JObject.Parse(strBuf);
                if (json["videoQualityInfos"] != null)
                {
                    List<Newtonsoft.Json.Linq.JToken> listRecord = json["videoQualityInfos"].Children().ToList();
                    int i = 0;
                    int tabIndex = i;
                    listRecord.ForEach(x =>
                    {
                        result.Add(Newtonsoft.Json.JsonConvert.DeserializeObject<SDK_EzvizSDK.VideoQualityInfo>(x.ToString()));
                    });
                }
            }
            return result;
        }
        #endregion

        /// <summary>
        /// Token 请求结果
        /// </summary>
        public enum JsonRequestResult
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
            /// 无设备权限
            /// </summary>
            NoDeviceAuthority = 20018,

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

        /// <summary>
        /// 云台动作
        /// </summary>
        public enum PTZAction
        {
            START,
            STOP
        }

        public enum PTZCommand
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
            UPLEFT,
            DOWNLEFT,
            UPRIGHT,
            DOWNRIGHT,
            ZOOMMIN,
            ZOOMOUT,
            FOCUSNEAR,
            FOCUSFAR,
            IRISSSTARTUP,
            IRISSTOPDOWN,
            LIGHT,
            WIPER,
            AUTO
        }

        public class VideoQualityInfo
        {
            public string videoQualityName;
            public string videoLevel;
            public string streamType;

            public override string ToString()
            {
                return videoQualityName;
            }
        }


        /// <summary>
        /// 全局配置信息枚举
        /// </summary>
        public enum ConfigKey
        {
            /// <summary>
            /// 数据输出使用UTF8
            /// </summary>
            CONFIG_DATA_UTF8 = 1,
            /// <summary>
            /// 码流数据输出经过转封装处理, 用于录像存储
            /// value: 1原始数据   0 经过封装库  
            /// 默认为0
            /// </summary>
            CONFIG_OPEN_STREAMTRANS = 2,
            /// <summary>
            /// P2P开关, 用于关闭P2P
            /// </summary>
            CONFIG_CLOSE_P2P = 3,
            /// <summary>
            /// 配置日志等级,参见 #OpenSDK_LogLevel
            /// </summary>
            CONFIG_LOG_LEVEL = 4,
            CONFIG_P2P_MAXNUM = 6,
            CONFIG_P2P_CHECK_PERIOD = 7,
            CONFIG_P2P_EXPIRE = 8
        }
    }

    
}
