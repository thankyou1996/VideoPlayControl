using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    public class SDK_JCSDK
    {

        #region 初始化
        /// <summary>
        /// 初始化 连接端口(默认-1)
        /// </summary>
        /// <param name="nLocStartPort">连接端口(默认-1)</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_InitSDK(int nLocStartPort);

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="nLocStartPort">连接端口(默认-1)</param>
        /// <param name="strTempFilePath">SDK临时文件路径</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_InitSDK(int nLocStartPort, string strTempFilePath);

        #endregion

        
        //释放SDK
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern void JCSDK_ReleaseSDK();
        
        /// <summary>
        /// 连接云服务器
        /// </summary>
        /// <param name="szServer">设备序列号或者</param>
        /// <param name="nPort">端口</param>
        /// <param name="nChannel">通道号</param>
        /// <param name="szNetUser">用户名</param>
        /// <param name="szPwd">密码</param>
        /// <param name="bNumOrIP">序列号(TRUE) IP(FALSE)</param>
        /// <param name="pUserData"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern int JCSDK_Connect(string szServer, int nPort, int nChannel, string szNetUser, string szPwd, bool bNumOrIP, string pUserData);
        //public static extern int JCSDK_Connect(string szServer, int nPort, int nChannel, string szNetUser, string szPwd, bool bNumOrIP, PUserData pUserData);
        
            
        /// <summary>
        /// 断开视频设备连接
        /// </summary>
        /// <param name="nLinkID"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_Disconnect(int nLinkID);


        /// <summary>
        /// 视频解码
        /// </summary>
        /// <param name="nLinkID"></param>
        /// <param name="bEnable">打开解码(TRUE)  关闭解码(FALSE)</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]//bEnable：开启或关闭解码器
        public static extern bool JCSDK_EnableDecoder(int nLinkID, bool bEnable);


        /// <summary>
        /// 设置视频预览
        /// </summary>
        /// <param name="nLinkID">连接序号</param>
        /// <param name="hWnd">窗口句柄   IntPtr.Zero(表示关闭)</param>
        /// <param name="pRect">显示区域句柄  IntPtr.Zero(表示关闭)</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_SetVideoPreview(int nLinkID, IntPtr hWnd, IntPtr pRect);

        /// <summary>
        /// 设置音频预览
        /// </summary>
        /// <param name="nLinkID">连接序号</param>
        /// <param name="hWnd">窗口句柄   IntPtr.Zero(表示关闭)</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_SetAudioPreview(int nLinkID, IntPtr hWnd);

        /// <summary>
        /// 开始录像
        /// </summary>
        /// <param name="nLinkID">连接ID</param>
        /// <param name="szFilename">存放路径</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_StartRec(int nLinkID, string szFilename);

        /// <summary>
        /// 结束录像
        /// </summary>
        /// <param name="nLinkID">连接ID</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_StopRec(int nLinkID);


        /// <summary>
        /// 云台控制命令
        /// </summary>
        /// <param name="nLinkID">连接ID</param>
        /// <param name="eCmd">控制命令</param>
        /// <param name="bStartOrStop">Start(TRUE) Stop(FALSE)</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_SendPTZCommand(int nLinkID, JCPTZCmdType eCmd, bool bStartOrStop);

        /// <summary>
        /// 显示预置点
        /// </summary>
        /// <param name="nLacolChannel">当前通道号</param>
        /// <param name="nLinkID">预制点位置</param>
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern void JCSDK_PresetCall(int nLacolChannel, int nLinkID);


        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        //public static extern void JCSDK_RegisterCallback(JCEventCallback_t funEventCallback, JCDataCallback_t funDataCallback, JCRawDataCallback_t funRawDataCallback, JCLanSearchDeviceCallback_t funLanSearchDeviceCallback);
        //public static extern void JCSDK_RegisterCallback(JCEventCallback_t funEventCallback, JCDataCallback_t funDataCallback, JCDownloadDataCallback_t funDownloadDataCallback, JCRawDataCallback_t funRawDataCallback, JCLanSearchDeviceCallback_t funLanSearchDeviceCallback);
        public static extern void JCSDK_RegisterCallback(JCEventCallback_t funEventCallback, IntPtr funDataCallback, IntPtr funDownloadDataCallback, IntPtr funRawDataCallback, IntPtr funLanSearchDeviceCallback);


        //获取设备信息
        [DllImport(ProgConstants.c_strCloundSeeSDKFilePath)]
        public static extern bool JCSDK_GetDeviceInfo(int nLinkID, PJCDeviceInfo pDevInfo);




        
        ////设置视频预览
        //[DllImport(ProgConstants.c_strCurrentSDKFilePath)]
        //public static extern bool JCSDK_SetVideoPreview(int nLinkID, IntPtr hWnd, ref LPRECT pRect);

        



        
        
        

        

        [StructLayout(LayoutKind.Sequential)]
        public struct PJCDeviceInfo
        {
            public JCDeviceType eDevType;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct LPRECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        //码流帧
        public struct PJCStreamFrame
        {
            public JCFrameType sType;
            public IntPtr pFrameData;
            public int nFrameSize;
        }
        //yv12数据帧
        public struct PJCRawFrame
        {
            public int dwWidth;
            public int dwHeight;
            public IntPtr pY;
            public IntPtr pU;
            public IntPtr pV;
            public int dwYPitch;
            public int dwUPitch;
            public int dwVPitch;
        }
        public struct PJCLanDeviceInfo
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szCloudSEE;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szIP;
            public int nPort;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szDeviceName;
            public int nDeviceType;
            public int nChannelNum;
        }

        public enum PUserData
        {
            Connect
        }
        public enum JCDeviceType
        {
            JCDT_All = 0,		//未知设备
            JCDT_Card,			//视频采集卡
            JCDT_DVR,			//DVR
            JCDT_IPC,			//IPC
            JCDT_NVR,			//NVR
        }
        public enum JCPTZCmdType
        {
            JCPCT_Up,			//上 Up
            JCPCT_Down,			//下 Down
            JCPCT_Left,			//左 Left
            JCPCT_Right,		//右 Right
            JCPCT_Auto,			//自动巡航 Auto
            JCPCT_IrisUp,		//光圈大 Iris Up
            JCPCT_IrisDown,		//光圈小 Iris Down
            JCPCT_FacolUp,		//变焦大 Facol Up
            JCPCT_FacolDown,	//变焦小 Facol Down
            JCPCT_ZoomUp,		//变倍大 Zoom Up
            JCPCT_ZoomDown,		//变倍小 Zoom Down
            JCPCT_Custom1,		//自定义功能1(具体功能由设备决定)
            JCPCT_Custom2,		//自定义功能2(具体功能由设备决定)
            JCPCT_Custom3,		//自定义功能3(具体功能由设备决定)
            JCPCT_Custom4,		//自定义功能4(具体功能由设备决定)
        }
        public enum JCEventType
        {
            //连接部分 Connect part
            JCET_Connected, //未使用 unused
            JCET_ConnectOK,	//连接成功  Connect successfully
            JCET_UserAccessError, //用户验证失败 Fail to user validation
            JCET_NoChannel,		//主控通道未开启  Master channel closed
            JCET_ConTypeError,	//连接类型错误 Connection type error
            JCET_ConCountLimit,	//超过主控连接最大数 excess Max. connection quantity of master
            JCET_ConTimeout,	//连接超时 Connection timeout
            JCET_DisconOK, //断开连接成功 Disconnected successfully
            JCET_ConAbout, //连接异常断开 Connection abnormally disconnected
            JCET_ServiceStop,	//主控断开连接 Master disconnected

            //远程录像相关 about remote record 
            JCET_GetFileListOK,		//获取远程录像成功 Get remote record successfully
            JCET_GetFileListError,	//获取远程录像失败 Fail to get remote record

            JCET_RemotePlayBegin,	//远程回放开始 Start remote playback
            JCET_RemotePlayEnd,		//远程回放结束 Remote playback end
            JCET_RemoteError,		//远程回放失败 Fail to remote playback
            JCET_RemotePlayTimeout,	//远程回访超时 Remote playback timeout

            JCET_DownloadData,		//录像下载数据 download record data
            JCET_DownloadEnd,		//录像下载完成 finish downloading record
            JCET_DownloadStop,		//录像下载停止 download stop
            JCET_DownloadError,		//远程下载失败 Fail to download
            JCET_DownloadTimeout,	//远程下载超时 Remote download timeout 

            //其他 Others
            JCET_StreamReset,	//码流重置信号(码流配置改变,须关闭并重新开启解码、录像等) 
            //Stream reset singals(stream setting was changed,it should close and restart decode,record etc._

            JCET_Alarm,	//报警信号 alarm singals
        };
        public enum JCFrameType
        {
            JCFT_I,			//视频I帧 Video frame rate I
            JCFT_P,			//视频P帧 Video frame rate P
            JCFT_B,			//视频B帧 Video frame rate B
            JCFT_Audio,		//音频帧  Audio frame rate
        };
        public enum JCTalkEventType
        {
            JCTET_Accepted,		//对方接受语音对讲  Accepted audio talk
            JCTET_Data,			//语音对讲数据 Audio talk datas
            JCTET_Stoped,		//语音对讲结束  Audio talk stopped

        };
        public enum JCCodecID
        {
            JCCID_Unknown,		//未知编码 unknow code

            //视频编码 video decode
            JCCID_JENC04,		//中维04版编码 JOVISION 04 version code
            JCCID_H264,			//H264编码  H.264 code
            //音频编码 audio decode
            JCCID_PCM,			//PCM数据 PCM data
            JCCID_AMR,			//AMR编码  AMR data
            JCCID_G711A,		//G711编码A decode A
            JCCID_G711U,		//G711编码U  decode U

            //语音对讲用   Two way audio
            JCCID_G729A_8k16b,	//PC板卡类产品用 used by DVR card based on PC 
            JCCID_PCM_8k8b,		//旧设备使用，新设备已弃用 Old device use,new device give up
            JCCID_G711A_8k16b,	//嵌入式设备(IPC/DVR/NVR)使用  Embedded device(IPC/DVR/NVR)use
            JCCID_G711U_8k16b,	//嵌入式设备(IPC/DVR/NVR)使用  Embedded device(IPC/DVR/NVR)use  

            JCCID_Undefined = 0xFF

        };

        public enum JCDownloadEventType
        {
            JCDET_DownloadData,		//录像下载数据 download record data
            JCDET_DownloadEnd,		//录像下载完成 finish downloading record
            JCDET_DownloadStop,		//录像下载停止 download stop
            JCDET_DownloadError,	//远程下载失败 Fail to download
            JCDET_DownloadTimeout,	//远程下载超时 Remote download timeout
        };
        //private static ZYB_PC_Common.GlobalHook.UserActivityHook.HookProc hookproc;

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCEventCallback_t(int nLinkID, JCEventType etType, IntPtr pData1, IntPtr pData2, IntPtr pUserData);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCDataCallback_t(int nLinkID, PJCStreamFrame pFrame, IntPtr pUserData);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCRawDataCallback_t(int nLinkID, PJCRawFrame pFrame, IntPtr pUserData);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCLanSearchDeviceCallback_t(PJCLanDeviceInfo pDevice);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCUserDataCallback_t(int nLinkID, byte[] pData, int nSize);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCTalkCallback_t(int nLinkID, JCTalkEventType etType, JCCodecID cdCodec, byte[] pData, int nSize, IntPtr pUserData);
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void JCDownloadDataCallback_t(int nLinkID, JCDownloadEventType etType, string pData, UInt64 dwSize, UInt64 dwFileSize, UInt64 pUserData);
    }
}
