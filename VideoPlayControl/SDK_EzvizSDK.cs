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

        //public static extern int OpenSDK_AllocSessionEx(MsgHandler CallBack, IntPtr UserID, )

        /// <summary>
        /// 消息回调
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="MsgType"></param>
        /// <param name="Error"></param>
        /// <param name="Info"></param>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public delegate int MsgHandler(IntPtr SID, uint MsgType, uint Error, string Info, IntPtr pUser);



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
}
