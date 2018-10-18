using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 程序公用参数
    /// </summary>
    public static class ProgConstants
    {
        #region SDK 文件路径
        /// <summary>
        /// 中维(云视通)SDK
        /// </summary>
        public const string c_strCloundSeeSDKFilePath = "\\JCSDK\\JCSDK.dll";
        /// <summary>
        /// 萤石云  SDK（旧版本）
        /// </summary>
        public const string c_strEzvizSDKOldSDKFilePath = "\\ezviz_Old\\OpenNetStream.dll";

        /// <summary>
        /// 萤石云SDK 
        /// </summary>
        public const string c_strEzvizSDKFilePath = "\\Ezviz\\OpenNetStream.dll";
        /// <summary>
        /// 华迈SDK 
        /// 只能存在在根目录下
        /// </summary>
        public const string c_strHuaMaiSDKFilePath = "\\hmsdk.dll";

        /// <summary>
        /// 时刻SDK  
        /// </summary>
        public const string c_strSKVideoSDKFilePath = "\\SKVideoSDK\\VLC_SDK.DLL";

        /// <summary>
        /// 时刻SK8604H  
        /// </summary>
        public const string c_strSKNVideoSDKFilePath = "\\SKNVideo\\SK_NSDK.DLL";
        /// <summary>
        /// 海康SDK
        /// </summary>
        public const string c_strHikVideoSDKFilePath = "HIkVideoSDK\\HCNetSDK.dll";

        /// <summary>
        /// 雄迈SDK 
        /// </summary>
        public const string c_strXMVideoSDKFilePath = "\\XMVideoSDK\\NetSdk.dll";

        /// <summary>
        /// 蓝色星际
        /// </summary>
        public const string c_strBlueSkyVideoSDKFilePath = "\\BlueSkyVideoSDK\\dvxSdk.dll";

        public const string c_strBlueSkyVideoSDKFilePath1 = "\\BlueSkyVideoSDK\\UKeyVerify_Cpp.dll";

        /// <summary>
        /// 多方通话SDK
        /// </summary>
        public const string c_strTalkManagerSDKFilePath = "\\TalkManagerSDK\\VoiceSDK.DLL";

        /// <summary>
        /// 宇视SDK 
        /// </summary>
        public const string c_strIMOSSDKFilePath = "\\IMOSSDK\\imos_sdk.dll";

        /// <summary>
        /// 宇视SDK frame
        /// </summary>
        public const string c_strIMOSSDKFrameFilePath = "\\IMOSSDK\\xp_frame.dll";
        #endregion

        #region SDK默认参数

        #region CloundSee 云视通

        /// <summary>
        /// 云视通默认初始化 端口
        /// </summary>
        public const int c_intCloundSee_intLocStartPort = -1;

        /// <summary>
        /// 云视通默认临时文件存放位置
        /// </summary>
        public static readonly string ro_strCloundSee_TempDicPath = Environment.CurrentDirectory + "\\CloundSeeTempFile";

        /// <summary>
        /// 云视通默认录像文件存放地址
        /// </summary>
        public static readonly string strCloundSee_RecDicPath = Environment.CurrentDirectory + "\\CloundSeeRecFile";
        #endregion

        #region IPCWA 深圳普顺达
        /// <summary>
        /// 普顺达默认录像文件存放地址
        /// </summary>
        public static readonly string strIPCWA_RecDicPath = Environment.CurrentDirectory + "\\IPCWARecFile";
        #endregion

        #region Ezviz 萤石云
        /// <summary>
        /// 开放平台认证中心地址
        /// </summary>
        public const string c_strEzviz_AuthAddr_Default = "https://auth.ys7.com";

        /// <summary>
        /// 开放平台后台地址
        /// </summary>
        public const string c_strEzviz_PlatForm_Default = "https://open.ys7.com";

        /// <summary>
        /// AppKey
        /// 1acd8ddc451f48a4b8b4666716e8f9ce 洪栋城
        /// </summary>
        //public const string c_strEzviz_AppID_Default = "1acd8ddc451f48a4b8b4666716e8f9ce";
        public const string c_strEzviz_AppID_Default = "5b97c1d157474f96b8d4c75b936a0057";//少春

        /// <summary>
        /// AppSecret
        /// 518335cd3421f16a4b4e88164225c432 洪栋城
        /// </summary>
        public const string c_strEzviz_AppSecret_Default = "4318d0cc4c43ca156052ba688bc9006a";  //少春

        /// <summary>
        /// 萤石云默认录像文件存放地址
        /// </summary>
        public static readonly string strEzviz_RecDicPath = Environment.CurrentDirectory + "\\EzvizRecFile";
        #endregion

        #region HuaMai 华迈
        /// <summary>
        /// 华迈云登录信息_IP
        /// </summary>
        public const string c_strHuaMaiSDK_LoginInfo_IP = "huamaiyun.com";
        /// <summary>
        /// 华迈云登录信息_端口
        /// </summary>
        public const int c_strHuaMaiSDK_LoginInfo_Port = 80;

        /// <summary>
        /// 华迈云登录信息_系统类型
        /// </summary>
        public const string c_strHuaMaiSDK_LoginInfo_PlatType = "pc";

        /// <summary>
        /// 华迈云登录信息_硬件版本
        /// </summary>
        public const string c_strHuaMaiSDK_LoginInfo_HardVer = "Pentium4";

        /// <summary>
        /// 华迈云登录信息_软件版本
        /// </summary>
        public const string c_strHuaMaiSDK_LoginInfo_SoftVer = "v1.1.0.1789";

        /// <summary>
        /// 华迈_结果_成功
        /// </summary>
        public const UInt32 c_iHuaMaiSDK_Result_Success = 0;
        #endregion

        #region 海康
        public readonly  static string strHikVideo_RecDicPath = Environment.CurrentDirectory + "\\HikVideoRecFile";
        #endregion
        #region XMVideo 雄迈
        public readonly static string strXMVideo_RecDicPath = Environment.CurrentDirectory + "\\XMVideoRecFile";

        #endregion

        #region BlueSky 蓝色星际
        public readonly static string strBlueSkyVideo_RecDicPath = Environment.CurrentDirectory + "\\BlueSkyVideoRecFile";

        #endregion

        #endregion

        #region 程序常量

        #region 时刻视频设备
        /// <summary>
        /// 对讲模式
        /// </summary>
        public const int c_intSKVideoTalkMode_Talk = 1;

        /// <summary>
        /// 监听模式
        /// </summary>
        public const int c_intSKVideoTalkMode_Monitor = 3;

        /// <summary>
        /// 喊话模式
        /// </summary>
        public const int c_intSKVideoTalkMode_Shout = 2;
        #endregion

        #endregion
    }
}
