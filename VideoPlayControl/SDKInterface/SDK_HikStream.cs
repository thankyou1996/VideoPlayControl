using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl.SDKInterface
{
    class SDK_HikStream
    {
        private delegate int pDataRec(int sid, int iusrdata, int idatatype, IntPtr pdata, int ilen);
        /// <summary>
        /// pMsgBack回调代理
        /// </summary>
        /// <param name="sid">SessionID值</param>
        /// <param name="opt">消息类型</param>
        /// <param name="param1"></param>
        /// <param name="param2">param1，param2视消息的类型决定其有效性</param>
        /// <returns></returns>
        private delegate int pMsgBack(int sid, int opt, int param1, int param2);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sid"></param>
        /// <param name="opt"></param>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        public delegate void HikClientSDK_CALLBACK(int sid, int opt, int param1, int param2);
        public static event HikClientSDK_CALLBACK OnNotify;//定义事件 实际上是对回调的封装,,方便使用本类的用户,同时避免回调被提前回收等问题
        // 初始化ACE，该函数需要在窗口加载的时候调用
        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int InitStreamClientLib();
        // 关闭ACE，窗口退出的时候调用
        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int FiniStreamClientLib();

        //120328
        public static void DisLogout()
        {
            FiniStreamClientLib();
        }

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        //static extern int HIKS_CreatePlayer(IHikClientAdviseSink pSink, IntPtr pWndSiteHandle, pDataRec pRecFunc, pMsgBack pMsgFunc, int TransMethod);
        private static extern int HIKS_CreatePlayer(int j, IntPtr pWndSiteHandle, pDataRec pRecFunc, pMsgBack pMsgFunc, int TransMethod);

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath, EntryPoint = "HIKS_OpenURL", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HIKS_OpenURL(int Hsession, string URL, int inuserdata);


        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_GetVideoParams(int Hsession, ref int ibri, ref int icon, ref int isat, ref int ihue);


        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_SetVideoParams(int Hsession, int ibri, int icon, int isat, int ihue);

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        private static extern int HIKS_PTZControl(int Hsession, int ucommand, int iparam1, int iparam2, int iparam3, int iparam4);

        /// <summary>
        /// 播放视频
        /// </summary>
        /// <param name="Hsession">Player的标示</param>
        /// <returns>成功返回1 失败返回-1</returns>
        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_Play(int Hsession);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Hsession"></param>
        /// <param name="bExclusive">是否独占</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_OpenSound(int Hsession, bool bExclusive);

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_CloseSound(int Hsession);

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_SetVolume(int Hsession, UInt16 volume);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="playHandle"></param>
        /// <returns></returns>
        /// 

        [DllImport(ProgConstants.c_strHIKStramSDKFilePath, EntryPoint = "HIKS_Stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int HIKS_Stop(int hSession);
        [DllImport(ProgConstants.c_strHIKStramSDKFilePath)]
        public static extern int HIKS_Destroy(int Hsession);
    }
}
