using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_InitLib(string strAuthAddr, string strPlatform, string strAppID);

        /// <summary>
        /// SDK释放
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strEzvizSDKFilePath)]
        public static extern int OpenSDK_FindLib();


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
        /// 消息回调
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="MsgType"></param>
        /// <param name="Error"></param>
        /// <param name="Info"></param>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public delegate int MsgHandler(IntPtr SID, uint MsgType, uint Error, string Info, IntPtr pUser);


    }
}
