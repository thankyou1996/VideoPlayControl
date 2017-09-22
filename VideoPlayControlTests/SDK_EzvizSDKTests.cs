using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class SDK_EzvizSDKTests
    {
        [TestMethod()]
        public void OpenSDK_HttpSendWithWaitTest()
        {
            IntPtr iMessage;
            int iLength;
            string jsonStr = BuildParams("token");
            string strApiUrl = "https://open.ys7.com/api/method";
            string strUrl2 = "https://open.ys7.com/api/lapp/token/get";
            string strParrameter = "appKey=1acd8ddc451f48a4b8b4666716e8f9ce&appSecret=518335cd3421f16a4b4e88164225c432";
            int aaa = SDK_EzvizSDK.OpenSDK_HttpSendWithWait(strUrl2, strParrameter, "", out iMessage, out iLength);
            //int aaa = SDK_EzvizSDK.OpenSDK_HttpSendWithWait(strApiUrl, jsonStr, "", out iMessage, out iLength);
            string returnstr = Marshal.PtrToStringAnsi(iMessage, iLength);

            Assert.AreEqual(1, returnstr);
        }
        //处理json获取token
        public static string BuildParams(string _type)
        {
            string str = string.Empty;
            string str6 = _type.ToLower();
            string PhoneNumber = "15159772128";
            string AppKey = "1acd8ddc451f48a4b8b4666716e8f9ce";
            string SecretKey = "518335cd3421f16a4b4e88164225c432";
            if (str6 != null)
            {
                if (!(str6 == "token"))
                {
                    if (str6 == "msg")
                    {
                        str = "msg/get";
                    }
                    else
                    {
                        str = "msg/get";
                    }
                }
                else
                {
                    str = "token/getAccessToken";
                }
            }
            TimeSpan span = (TimeSpan)(DateTime.Now - TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(0x7b2, 1, 1, 0, 0, 0)));
            string str2 = Math.Round(span.TotalSeconds, 0).ToString();
            string str3 = MD5Encrypt("phone:" + PhoneNumber + ",method:" + str + ",time:" + str2 + ",secret:" + SecretKey, 0x20).ToLower();
            return ("{\"id\":\"100\",\"system\":{\"key\":\"" + AppKey + "\",\"sign\":\"" + str3 + "\",\"time\":\"" + str2 + "\",\"ver\":\"1.0\"},\"method\":\"" + str + "\",\"params\":{\"phone\":\"" + PhoneNumber + "\"}}");
        }

        //MD5加密
        public static string MD5Encrypt(string str, int code)
        {
            MD5 md = new MD5CryptoServiceProvider();
            Encoding encoding = Encoding.UTF8;
            byte[] buffer = md.ComputeHash(encoding.GetBytes(str));
            StringBuilder builder = new StringBuilder(code);
            for (int i = 0; i < buffer.Length; i++)
            {
                builder.Append(buffer[i].ToString("x").PadLeft(2, '0'));
            }
            return builder.ToString();
        }

        [TestMethod()]
        public void GetAccessTokenTest()
        {
            //SDKState.Ezvie_SDKInit();
            int intInitResult = SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual(200, (int)result);
        }

        [TestMethod()]
        public void OpenSDK_Data_GetDevListTest()
        {
            SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            IntPtr intptrMessage;
            int intLenght;
            int intResult = SDK_EzvizSDK.OpenSDK_Data_GetDevList(ProgParameter.strEzviz_AccessToken, 0, 50, out intptrMessage, out intLenght);
            string strDevInfoJosn = Marshal.PtrToStringAnsi(intptrMessage);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", strDevInfoJosn);
        }

        [TestMethod()]
        public void OpenSDK_AllocSessionTest()
        {
            SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            string strSession;
            IntPtr intptrSession = IntPtr.Zero;
            int intLenght = 0;
            SDK_EzvizSDK.MsgHandler m = new SDK_EzvizSDK.MsgHandler(MsgHandler);
            int intResult = SDK_EzvizSDK.OpenSDK_AllocSession(m, IntPtr.Zero, ref intptrSession, ref intLenght, false, uint.MaxValue);
            strSession = Marshal.PtrToStringAnsi(intptrSession);
            intResult = SDK_EzvizSDK.OpenSDK_FreeSession(intptrSession);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", strSession);
        }

        [TestMethod()]
        public void OpenSDK_AllocSessionExTest()
        {
            SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            //GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            string strSession;
            IntPtr intptrSession = IntPtr.Zero;
            int intLenght = 0;
            SDK_EzvizSDK.MsgHandler m = new SDK_EzvizSDK.MsgHandler(MsgHandler);
            int intResult = SDK_EzvizSDK.OpenSDK_AllocSessionEx(m, IntPtr.Zero, out intptrSession, out intLenght);
            strSession = Marshal.PtrToStringAnsi(intptrSession);
            intResult = SDK_EzvizSDK.OpenSDK_FreeSession(strSession);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", strSession);
        }



        public void MsgHandler(IntPtr SID, EzvizMeesageType MsgType, uint Error, string Info, string strUser)
        {
            switch (MsgType)
            {
                case EzvizMeesageType.INS_PLAY_START:

                    break;
                case EzvizMeesageType.INS_PLAY_EXCEPTION:

                    break;
            }
            //MessageBox.Show(MsgType.ToString());
        }

        [TestMethod()]
        public void OpenSDK_StartRealPlayExTest()
        {
            int intResult = 0;
            intResult = SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            IntPtr intptrToken = Marshal.StringToHGlobalAnsi(ProgParameter.strEzviz_AccessToken);
            intResult = SDK_EzvizSDK.OpenSDK_SetAccessToken(intptrToken);
            IntPtr intptrSession = IntPtr.Zero;
            int intLenght = 0;
            PictureBox pic = new PictureBox();
            SDK_EzvizSDK.MsgHandler m = new SDK_EzvizSDK.MsgHandler(MsgHandler);
            intResult = SDK_EzvizSDK.OpenSDK_AllocSessionEx(m, IntPtr.Zero, out intptrSession, out intLenght);
            intResult = SDK_EzvizSDK.OpenSDK_SetVideoLevel(intptrSession, 1, 1);
            SDK_EzvizSDK.DataCallBack callback = new SDK_EzvizSDK.DataCallBack(DataCallBack);
            IntPtr inptrUser = Marshal.StringToHGlobalAnsi("10086");
            intResult = SDK_EzvizSDK.OpenSDK_SetDataCallBack(intptrSession, callback, inptrUser);
            IntPtr ii = Marshal.StringToHGlobalAnsi("756217914");
            intResult = SDK_EzvizSDK.OpenSDK_StartRealPlayEx(intptrSession, IntPtr.Zero, ii, 1, null);
            int intErrorCode = 0;
            string strErrorDesc = "";
            if (intResult == -1)
            {
                //错误码
                intErrorCode = SDK_EzvizSDK.OpenSDK_GetLastErrorCode();
                IntPtr i = SDK_EzvizSDK.OpenSDK_GetLastErrorDesc();
                strErrorDesc = Marshal.PtrToStringAnsi(i);
            }
            Thread.Sleep(3000);
            intResult = SDK_EzvizSDK.OpenSDK_StopRealPlayEx(intptrSession);
            intResult = SDK_EzvizSDK.OpenSDK_FreeSession(intptrSession);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", intErrorCode);
        }

        [TestMethod()]
        public void OpenSDK_StartRealPlayTest()
        {
            SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            string strSession;
            IntPtr intptrSession = IntPtr.Zero;
            int intLenght = 0;
            PictureBox pic = new PictureBox();
            SDK_EzvizSDK.MsgHandler m = new SDK_EzvizSDK.MsgHandler(MsgHandler);
            int intResult = SDK_EzvizSDK.OpenSDK_AllocSession(m, IntPtr.Zero, ref intptrSession, ref intLenght,false,uint.MaxValue);
            strSession = Marshal.PtrToStringAnsi(intptrSession);
            intResult = SDK_EzvizSDK.OpenSDK_StartRealPlay(intptrSession, pic.Handle, "7e1c18bad66544408b38d1711552e320", ProgParameter.strEzviz_AccessToken, 0, null, ProgParameter.strEzviz__AppID, 0);
            Thread.Sleep(5000);
            intResult = SDK_EzvizSDK.OpenSDK_StopRealPlayEx(intptrSession);
            Thread.Sleep(5000);
            intResult = SDK_EzvizSDK.OpenSDK_FreeSession(strSession);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", strSession);
        }

        public void DataCallBack(DataType enType, IntPtr pData, int iLen, IntPtr pUser)
        {
            string x = Marshal.PtrToStringAnsi(pUser);
        }

        [TestMethod()]
        public void OpenSDK_StartRealPlay_OldTest()
        {
            SDK_EzvizSDK.OpenSDK_InitLib(ProgParameter.strEzviz__AuthAddr, ProgParameter.strEzviz__PlatForm, ProgParameter.strEzviz__AppID);
            GetTokenResult result = SDK_EzvizSDK.GetAccessToken();
            string strSession;
            IntPtr intptrSession = IntPtr.Zero;
            int intLenght = 0;
            PictureBox pic = new PictureBox();
            SDK_EzvizSDK.MsgHandler m = new SDK_EzvizSDK.MsgHandler(MsgHandler);
            int intResult = SDK_EzvizSDK.OpenSDK_AllocSession(m, IntPtr.Zero, ref intptrSession, ref intLenght,false,uint.MaxValue);
            strSession = Marshal.PtrToStringAnsi(intptrSession);
            intResult = SDK_EzvizSDK.OpenSDK_StartRealPlay_Old(intptrSession, pic.Handle, "6e1c18bad66544408b38d1711552e320", ProgParameter.strEzviz_AccessToken, 0, null, ProgParameter.strEzviz__AppID);
            //Thread.Sleep(5000);
            intResult = SDK_EzvizSDK.OpenSDK_StopRealPlayEx(intptrSession);
            //Thread.Sleep(5000);
            intResult = SDK_EzvizSDK.OpenSDK_FreeSession(strSession);
            SDK_EzvizSDK.OpenSDK_FiniLib();
            Assert.AreEqual("1", strSession);
        }
    }
}