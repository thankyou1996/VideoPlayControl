using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    public class dvxSdkType
    {
        /// <summary>
        /// 系统版本信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SystemVersionInfo
        {
            /// <summary>
            /// 产品开发编号
            /// </summary>
            public int product;

            /// <summary>
            /// 销售型号
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] model;

            /// <summary>
            /// 录像机版本
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] version;

            /// <summary>
            /// 产品系列号
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] serial;

            /// <summary>
            /// 机器标示 <前2字节为0， 后6各字节为MAC地址>
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public Byte[] macid;
        };

        /// <summary>
        /// 模块信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct Module
        {
            /// <summary>
            /// 模块编号
            /// </summary>
            public Byte module;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]

            public Byte[] res;

            /// <summary>
            /// 模块版本号
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public Byte[] version;

            /// <summary>
            /// 模块编译日期
            /// </summary>
            public UInt32 buildTime;
        };

        /// <summary>
        /// 系统模块信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SysModulePara
        {
            /// <summary>
            /// 模块个数(0-32) 
            /// </summary>
            public Char count;

            public Char res;

            /// <summary>
            /// 子开发版本号，在NVR和IPCB04  阶段取值为4，会逐渐增大，处理上不要写死； 
            /// </summary>
            public Char s_rdver;

            /// <summary>
            /// 用于结合大版本区分功能序列；
            /// </summary>
            public Char rdver;

            //产品开发设计过程版本号序列；0 和 1 预留给早期
            //版本，从2开始；（每个号对应到某个 bscp 版本，包
            //含一部分 bscp 功能集合） 
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Module[] moduleList;
        };

        /// <summary>
        /// 音视频描述
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct AVDescribe
        {
            /// <summary>
            /// bit1=MP4,bit2=MJPEG,bit3=H264,bit4=SVAC,bit5=H265
            /// </summary>
            public Byte vcodes;

            /// <summary>
            /// bit1=MP2,bit2=G.72x 
            /// </summary>
            public Byte acodes;

            /// <summary>
            /// bit=PAL,bit2=NTSC 
            /// </summary>
            public Byte systems;

            /// <summary>
            /// bit1=QCIF,bit2=CIF,bit3=halfD1,bit4=D1,bit5=DCIF,bit6=HD 
            /// </summary>
            public Byte SDResolut;

            //当bit6=HD被置位时，须参考HDResolution中的定义 
            /// <summary>
            /// bit1=720I,bit2=720P,bit3=1080I,bit4=1080P, bit5=960H
            /// </summary>
            public Byte HDResolution;

            /// <summary>
            /// 非标准分辨率 //bit1:1280*960 ,bit2 :1600 *1200, bit3:2048* 1536, bit4 :640*480 , bit5 :1920*1024, bit6 :800x600,bit7 :1280x1024 ,bit8 : 1024x768
            /// </summary>
            public Byte NSDResolution;

            /// <summary>
            /// bit1:320x180, bit2:320x240, bit3:640x360, bit4: 720x576, bit5:800x450,bit6:1280x800;bit7:1200x1200;bit8:1920x1200;
            /// </summary>
            public Byte NSDres02;

            /// <summary>
            /// bit1=MAIN,bit2=SUB1,bit2=SUB2…bit3是图片流  最大支持8个码流,
            /// </summary>
            public Byte bitstreams;
        };

        /// <summary>
        /// 系统信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SystemDescribleInfo
        {
            /// <summary>
            /// 平台编号 //SUNFLOWER(1)|CHALLENGER(2)|LIMIT(3)|LC(4) LOTUS(5) PENNY (6) TULIP (7))
            /// </summary>
            public Char platform;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]

            public Byte[] res;

            public UInt32 features; //总体能力与功能指标(取值 bit1~ bit32)  bit1~bit7:  预留;  
                                    //Bit8：宽动态  ；( IPC 专用)               //Bit9:  日夜转换；( IPC 专用) 
                                    //Bit10:  背光补偿；( IPC 专用)             //Bit11：数字降噪；( IPC 专用) 
                                    //Bit12：强光抑制；( IPC 专用)              //Bit13:支持BNC功能 
                                    //Bit15：卡号;                              //Bit16：智能(IPC:1支持,0不支持;tulipB:0支持,1不支持);
                                    //Bit17: SIP协议                            //Bit18：视频切片信息
                                    //Bit19：支持IP 通道ROI; ( NVR 专用)        //Bit20：支持IP 通道抓图；(NVR 专用)
                                    //Bit21：葡萄牙文；                         //Bit22：曲面校正；( IPC 专用)
                                    //Bit23：去雾；( IPC 专用)                  //Bit24：图像旋转；( IPC 专用)
                                    //Bit25：图像诊断；（IPC 专用）             //Bit26: IPC 通道为主方式接入支持；（NVR 专用）
                                    //Bit27：Onvif over TCP ;                   //Bit28: 是否支持0通道(0是支持，1是不支持)
                                    //Bit29：0 菜单透明度，0：支持，1：不支持;(对IPC无意义)；
                                    //Bit30：IPC辅助对焦；0：支持，1：不支持;   //Bit31：单号  1 支持

            public HwSpec spec;

            public SwLimit limit;
        };

        /// <summary>
        /// 硬件信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct HwSpec
        {
            /// <summary>
            /// MP处理器
            /// </summary>
            public char chips;

            /// <summary>
            /// 通道数
            /// </summary>
            public char videoInputs;
            public char videoOutputs;
            public char audioInputs;
            public char audioOutputs;
            public char speechInputs;
            public char speechOutputs;
            public char alarmInputs;
            public char alarmOutputs;
            /// <summary>
            /// 网口数
            /// </summary>
            public char netIfaces;
            public char rs232ports;
            public char rs485ports;
            public char usbports;
            /// <summary>
            /// 监视器输出个数
            /// </summary>
            public char monitors;

            /// <summary>
            /// 总盘位
            /// </summary>
            public char shelfs;

            /// <summary>
            /// IPC 专用// 0: No Sensor ; 1: 9P031 ; 2: 9M034 ; 3: IMX036;4 : AR0331; 5:AR0130, 6: IMX122, 7:OV9712 , 8:IMX138, 9:IMX236 
            /// </summary>
            public char sensor;

            /// <summary>
            /// 1：Line in; 2: mic in;3：Both
            /// </summary>
            public char audioIntype;

            /// <summary>
            /// 红外支持：1：yes，0：no
            /// </summary>
            public char infrared;

            /// <summary>
            /// 网卡是否不支持1000M，默认0:支持1000M，1：不支持1000M
            /// </summary>
            public char iface_no1000m;

            /// <summary>
            /// 支持双网口, 0,不支持，1：支持
            /// </summary>
            public char with_iface2;

            /// <summary>
            /// 是否支持sd卡，0 非法值，1 支持 ， 2 不支持
            /// </summary>
            public char sdCard;

            /// <summary>
            /// 不支持风扇报警，0，正常1，不支持；
            /// </summary>
            public char no_fan_alarm;

            /// <summary>
            /// 0:Normal
            /// </summary>
            public char analog_chan_mess_flag;

            /// <summary>
            /// 0：nornal，1：标识无时钟芯片的设备机型；
            /// </summary>
            public char no_rtc;

            /// <summary>
            /// 网口交换芯片的--端口扩展，标识即插即用型NVR；//0: 没有网络端口倍增；1：带网口倍增（带即插即用功能）
            /// </summary>
            public char netMuiltiPorter;

            /// <summary>
            /// /** 仅判断B03及以前版本。支持双IP配置。0:默认不支持 1:支持*/
            /// </summary>
            public char oldVersionSupportTwoIp;

            /// <summary>
            /// 0:不支持，1:支持
            /// </summary>
            public char supportPIR;

            /// <summary>
            /// 0:不支持，1:支持
            /// </summary>
            public char supportWifi;

            /// <summary>
            /// 硬件支持 bitmap; 0:不支持;1:支持； (bit1:电动镜头)
            /// </summary>
            public char HardwareSupport;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] res; // //保留
        };

        /// <summary>
        /// 迸发处理能力
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SwLimit
        {
            /// <summary>
            /// 最大并发登陆会话数，缺省为10
            /// </summary>
            public UInt16 sessions;
            /// <summary>
            /// 最大并发传输，缺省为16
            /// </summary>
            public UInt16 streams;
            /// <summary>
            /// 最大并发远程回放连接数 缺省值8
            /// </summary>
            public UInt16 netplays;
            /// <summary>
            /// 最大并发下载链接，缺省8
            /// </summary>
            public UInt16 dumps;
            /// <summary>
            /// 最大并发语音数 缺省1
            /// </summary>
            public UInt16 speeches;
            /// <summary>
            /// 最大网络带宽（M）
            /// </summary>
            public UInt16 bandwith;
            /// <summary>
            /// 最大通道名称叠加数量; 0~1:均标示 1个； 
            /// </summary>
            public UInt16 chanNameOsdNum;
            /// <summary>
            /// 最大帧率，用于支持50、60，
            /// </summary>
            public UInt16 max_frame_rate;
            /// <summary>
            /// 最大视频编码帧数（CIF） 0 :为无效值；
            /// </summary>
            public UInt16 max_vcodec_frm;
            /// <summary>
            /// 默认为0， >1  , HwSpec中的	audioInputs，speechnum 要正常使用，目的是兼容错误的使用方式；
            /// </summary>
            public UInt16 swSpecInfo;
            /// <summary>
            /// 视频遮盖数量，>0 有效，为0 时为	不使用；
            /// </summary>
            public UInt16 masknum;
            /// <summary>
            /// 最大子码流帧率，0 为无效 (兼容性考虑)； 
            /// </summary>
            public Byte max_substream_frmrate;
            /// <summary>
            /// IPC配置导出能力=1为支持；// 
            /// </summary>
            public Byte ipc_cfg_export;
            /// <summary>
            /// IPC 专用，采集分辨率 
            /// </summary>
            public UInt32 sampleResol;
            /// <summary>
            /// IPCBNC输出制式配置能力，=1表示支持；
            /// </summary>
            public Byte ipc_bnc_signal_cfg;
            /// <summary>
            ///  0:支持，1：不支持，无ai调整
            /// </summary>
            public Byte without_AiTunner;
            /// <summary>
            /// IPC 蜂鸣器能力 0：不支持1:支持
            /// </summary>
            public Byte ipc_buzzer;
            /// <summary>
            /// ipc智能类型 1(2012版多路并发智能) ; 2(2015 版智能);
            /// </summary>
            public Byte intelligent_type;

            public UInt32 features;     //功能标志位(bitmap) (取值 bit1~ bit32)
                                        //Bit1：日夜转换延时和转换灵敏度控制 0:不支持 1：支持（IPC 专用）
                                        //Bit2: 图像质量控制 0：不支持 1：支持（IPC 专用）
                                        //Bit3: 低照下宽动态关闭控制 0：不支持 1：支持（IPC 专用）
                                        //Bit4: 红增益、蓝增益 0:不支持 1：支持（IPC 专用）
                                        //Bit5: 增益强度 0：不支持 1：支持（IPC 专用）
                                        //Bit6: 快门速度支持 1/100000； 0：不支持 1：支持（IPC专用）
                                        //Bit7: B05 之后 A 对帧率的特殊要求，所有分辨率支持 - 30,50,60(附:1920*1200 只支持-30,50， 不支持) 
                                        //注意：Bit7 和 max_frame_rate 是 互 斥 的 ， 在 bit7 为 0 的 时 候 max_frame_rate 有效； 0：不支持 1：支持（IPC 专用）
                                        //Bit8: 左右镜像、上下镜像、中心镜像能力支持 0：不支持(只有镜像只有开与关两项)  1:支持（关、左右镜像、上下镜像、中心镜四项） （IPC 专用）

            /// <summary>
            /// 星际云的能力, 不支持(0),支持(1)
            /// </summary>
            public Byte bsr_Cloud;
            /// <summary>
            /// 电信手机看店平台能力，不支持(0),支持(1)
            /// </summary>
            public Byte tele_LookAf_Plat;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]

            public Byte[] res2;
            /// <summary>
            /// 功能标志(bitmap) //  (取值 bit1~ bit32)
            /// //Bit1： 断网补录 0:不支持 1：支持（ dvr/hdvr/nvr 专用）
            //Bit2： 理财性质支持（ 0： 不支持； 1 支持）（ dvr/hdvr/nvr专用）
            //Bit3:  H.265支持（ 0： 不支持； 1 支持）（ dvr/hdvr/nvr专用）
            /// </summary>
            public UInt32 features_dvx;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
            public Byte[] res3;
        };

        /// <summary>
        /// 产品序列号
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SystemSerialGet
        {
            /// <summary>
            /// 产品序列号
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26)]
            public Byte[] serial;

            /// <summary>
            /// 保留
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public Byte[] res1;

            /// <summary>
            /// 版本类型，见下表格
            /// </summary>
            public Char version_type;

            public Char res2;
        };

        /// <summary>
        /// 授权信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct UkeyAuthizeParam
        {
            /// <summary>
            /// 附带的有效授权信息长度 
            /// </summary>
            public UInt32 authLen;

            /// <summary>
            /// 附带的授权信息 
            /// </summary>
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64 * 1024)]
            public Byte[] auth;
        };

        /// <summary>
        /// 现场流打开参数
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct RealOpenPara
        {
            /// <summary>
            /// .通道号，1-16表示1-16通道。 
            /// </summary>
            public Char channel;

            /// <summary>
            /// 0表示主码流，1表示子码流。
            /// </summary>
            public Char subStream;

            /// <summary>
            ///  传输协议: 1, TCP，4RTP
            /// </summary>
            public Char transProc;

            public Char transMode;

            public int ip;
        };

        /// <summary>
        /// IPC预览时的参数设置，仅对IPC有效, 自定义，非协议
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct IPCPreViewPara
        {
            /// <summary>
            /// 图像增强
            /// </summary>
            public bool bImageEhnace;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public bool[] bres;
            /// <summary>
            /// 通道设置
            /// </summary>
            public char channels;
            /// <summary>
            /// 码流选择
            /// </summary>
            public char subStream;
            /// <summary>
            /// 传输协议
            /// </summary>
            public char transProc;
            public char res;
        };


        /// <summary>
        /// 对讲流打开参数
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct SpeechOpenPara
        {
            /// <summary>
            /// /**< 通道号，对应的音视频物理通道(0-16) */
            /// </summary>
            public int channel;

            /// <summary>
            /// /**< 传输协议，1=TCP,2=RTP,3=UDP */
            /// </summary>
            public int transType;

            /// <summary>
            /// /**< 传输模式，1=主动模式，2=被动模式 */
            /// </summary>
            public int transMode;

            /// <summary>
            /// /**< IP地址，被动时为0 */
            /// </summary>
            public int ip;

            /// <summary>
            /// /**< 端口号，被动时为0(由服务器返回--固定3720) */
            /// </summary>
            public int port;
        };


        /**********************************************************************************/
        // 返回值定义
        public enum ReturnError
        {
            /// <summary>
            ///  对于没有实现的方法或属性设置返回值均为 -1
            /// </summary>
            DVX_ERR_NOIMPL = (-1),

            /// <summary>
            /// 函数执行成功，返回值均为 0
            /// </summary>
            DVX_OK = (0),
            /// 3.对于小于0x10000均为dvr错误码

            /// 5.本地错误码：从0x20000开始
            DVX_ERR_BASE = 0x00020000,

            /// 5.1一般性错误
            DVX_ERR_ASSERT = (DVX_ERR_BASE + 0x1),      ///< 出现了绝不应该出现的情况，基本上是SDK的问题
            DVX_ERR_MALLOCMEMORY = (DVX_ERR_BASE + 0x2),        ///< 分配内存出错，系统错误
            DVX_ERR_CREATE_EVENT = (DVX_ERR_BASE + 0x3),        ///< 创建Event句柄出错，系统错误
            DVX_ERR_CREATE_THREAD = (DVX_ERR_BASE + 0x4),       ///< 创建线程出错，系统错误
            DVX_ERR_PARA = (DVX_ERR_BASE + 0x5),        ///< 参数错误
            DVX_ERR_SDK_NO_INIT = (DVX_ERR_BASE + 0x6),     ///< SDK没有初始化
            DVX_ERR_DVX_NO_LOGIN = (DVX_ERR_BASE + 0x7),        ///< 还没有登录
            DVX_ERR_DVX_INVALID_HANDLE = (DVX_ERR_BASE + 0x8),  ///< 无效的DvxHandle句柄
            DVX_ERR_COMMON = (DVX_ERR_BASE + 0x9),      ///< 通用错误

            /// 5.2网络错误
            DVX_ERR_ERR_TRANS_OPEN = (DVX_ERR_BASE + 0x21),  ///<打开传输流错误
            DVX_ERR_NET_DISCONNECT = (DVX_ERR_BASE + 0x22),  ///<网络断开
            DVX_ERR_HELLO = (DVX_ERR_BASE + 0x23),  ///<网络断开

            /// 5.3报警错误
            DVX_ERR_ALARM_DISABLE = (DVX_ERR_BASE + 0x101), ///< 报警功能没有打开
            DVX_ERR_ENABLE_ALARM = (DVX_ERR_BASE + 0x102),  ///< 启动报警功能时出错
            DVX_ERR_NOMORE_ALARM = (DVX_ERR_BASE + 0x103),  ///< 没有更多的报警信息了

            /// 5.4现场错误
            DVX_ERR_REAL_INVALID_HANDLE = (DVX_ERR_BASE + 0x201),   ///< 无效的现场句柄

            /// 5.5对讲错误
            DVX_ERR_SPEECH_INVALID_HANDLE = (DVX_ERR_BASE + 0x301), ///< 无效的对讲句柄

            /// 5.6 本地回放错误
            DVX_ERR_LOCALPLAY_INVALID_HANDLE = (DVX_ERR_BASE + 0x401),  ///< 无效的本地回放句柄
            DVX_ERR_LOCALPLAY_INVALID_FNAME = (DVX_ERR_BASE + 0x402),     ///< 无效的本地回放句柄
            DVX_ERR_LOCALPLAY_NO_OPEN = (DVX_ERR_BASE + 0x403),         ///< 本地回放，还没有打开

            /// 5.7 
            DVX_ERR_CREATE_FILE = (DVX_ERR_BASE + 0x501), ///<创建文件失败
            DVX_ERR_NET = (DVX_ERR_BASE + 0x901), ///<网络错误
            DVX_BSCP_BUSY = (DVX_ERR_BASE + 0x902), ///<命令通道忙
            DVX_BSCP_TIMEOUT = (DVX_ERR_BASE + 0x903), ///<bscp命令执行超时
            DVX_BSCP_NETERR = (DVX_ERR_BASE + 0x904), ///<bscp网络错误
            DVX_ERR_INIT = (DVX_ERR_BASE + 0x905), ///<初始化错误
            DVX_ERR_NET_INIT = (DVX_ERR_BASE + 0x906), ///<网络初始化错误
        };
    }
    public class SDK_BlueSDK
    {
        /// <summary>
        /// 初始化SDK。使用SDK时，首先就要调用这个函数。 
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSdkInit();

        /// <summary>
        /// 卸载
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSdkDeInit();

        /// <summary>
        /// 创建一个新的SDK实例 
        /// </summary>
        /// <param name="ip"> Dvr的ip地址</param>
        /// <param name="nCmdPort">命令端口</param>
        /// <param name="nDataPort">数据端口</param>
        /// <param name="szUserName">登录名</param>
        /// <param name="szPasswd">密码</param>
        /// <param name="pDvr">DVR 句柄</param>
        /// <param name="bReceiveAlerts"></param>
        /// <returns></returns>

        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxCreate(string ip, ushort nCmdPort, ushort nDataPort, string szUserName, string szPasswd, ref IntPtr pDvr, bool bReceiveAlerts = true);

        /// <summary>
        /// 获取系统版本信息 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄 </param>
        /// <param name="pVersion">版本信息结构体</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSysVersion(IntPtr hDvx, ref dvxSdkType.SystemVersionInfo pVersion);

        /// <summary>
        /// 获取模块版本信息
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄</param>
        /// <param name="pModules">模块版本信息</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSysModulesGet(IntPtr hDvx, ref dvxSdkType.SysModulePara pModules);

        /// <summary>
        /// 获取系统版本信息 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄</param>
        /// <param name="pDes">系统信息</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSysDescribeEx(IntPtr hDvx, ref dvxSdkType.SystemDescribleInfo pDes);

        /// <summary>
        /// 能力描述 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄</param>
        /// <param name="pInfo">音视频编解码等详细参数 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxAVDescrible(IntPtr hDvx, ref dvxSdkType.AVDescribe pInfo);

        /// <summary>
        /// 获取系统版本信息
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄</param>
        /// <param name="pSerial">产品序列号</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSysSerialGet(IntPtr hDvx, ref dvxSdkType.SystemSerialGet pSerial);

        /// <summary>
        /// 检查当前是否处理登录状态 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool dvxIsLogin(IntPtr hDvx);

        /// <summary>
        /// 登出Dvx，不会释放内部资源，如果继续使用DVR功能，则需再次dvxLogin。 
        /// </summary>
        /// <param name="hDvx">由dvxCreate成功创建的Dvx句柄</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLogout(IntPtr hDvx);

        /// <summary>
        /// 登录Dvx，在网络断线，或DVR重启之后，如果想继续使用已创建的Dvx句柄，需要显示的调用dvxLogin。 
        /// </summary>
        /// <param name="hDvx">由dvxCreate成功创建的Dvx句柄 </param>
        /// <param name="szUserName">Dvx上的现有用户名, DVR出厂默认为admin </param>
        /// <param name="szPasswd">对应的密码，DVR出厂默认为123456 </param>
        /// <param name="msTimeout">超时时间，单位ms。 </param>
        /// <param name="bReceiveAlerts"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLogin(IntPtr hDvx, string szUserName, string szPasswd, int msTimeout, bool bReceiveAlerts = true);

        /// <summary>
        /// 设置远程角色的权限 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄 </param>
        /// <param name="pParam">角色权限结构参数 </param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSecuritySessionAuthizeSet(IntPtr hDvx, ref dvxSdkType.UkeyAuthizeParam pParam, ref int pValue);

        /// <summary>
        /// 开启实时图像预览。
        /// </summary>
        /// <param name="hDvx">由dvxCreate成功创建的Dvx句柄 </param>
        /// <param name="pPara">开启实现流的参数结构。 </param>
        /// <param name="hPlayWnd">实时视频的播放窗口句柄，如果为NULL，则内部不启用播放。 </param>
        /// <param name="hNotifyWnd">可以接收Windows消息的窗口句柄 </param>
        /// <param name="msgId">指定的消息ID </param>
        /// <param name="phReal">返回实时图像预览的句柄</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealOpen(IntPtr hDvx, ref dvxSdkType.RealOpenPara pPara, IntPtr hPlayWnd, IntPtr hNotifyWnd, UInt32 msgId, ref IntPtr phReal);

        /// <summary>
        /// 图像增强
        /// </summary>
        /// <param name="hReal">现场流句柄</param>
        /// <param name="bImageEnhance"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealImageEnhance(IntPtr hReal, bool bImageEnhance);

        /// <summary>
        /// 开始实时预览。 
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealStart(IntPtr hReal);

        /// <summary>
        /// 停止实时预览。之后还可以通过dvxRealStart再次开始。 
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealStop(IntPtr hReal);

        /// <summary>
        /// 关闭实时预览。 
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealClose(ref IntPtr hReal);

        /// <summary>
        /// 关闭对讲流，要释放相应的资源 
        /// </summary>
        /// <param name="hSpeech">对讲流句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSpeechClose(ref IntPtr hSpeech);

        /// <summary>
        /// 设置显示智能叠加信息的语言
        /// </summary>
        /// <param name="hPlay"></param>
        /// <param name="nLanguage">1-中文简体，2-英文，3-中文繁体</param>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void dvxPlayShowAiLang(IntPtr hPlay, int nLanguage);

        /// <summary>
        /// 播放声音。 
        /// </summary>
        /// <param name="hPlay">回放实例的句柄。可以是实时预览或远程回放、本地回放句柄。 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxPlaySound(IntPtr hPlay);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="hDvx">登录的句柄</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSecuritySessionAuthClear(IntPtr hDvx);

        /// <summary>
        /// 销毁指定的SDK实例 
        /// </summary>
        /// <param name="hDvx">指定的DVR的DvxHandle句柄</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxDestory(IntPtr hDvx);

        /// <summary>
        /// 停止对讲 
        /// </summary>
        /// <param name="hSpeech">对讲流句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSpeechStop(IntPtr hSpeech);

        /// <summary>
        /// 设置为静音。 
        /// </summary>
        /// <param name="hPlay">回放实例的句柄。可以是实时预览或远程回放、本地回放句柄。 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxStopSound(IntPtr hPlay);

        /// <summary>
        /// 打开一个新的对讲流 
        /// </summary>
        /// <param name="hDvx">当前Dvr的句柄 </param>
        /// <param name="pPara">打开对讲流的参数 </param>
        /// <param name="hNotifyWnd">接收对讲模块消息的窗口句柄 </param>
        /// <param name="msgId">指定接收的消息ID，具体的消息，由wParam, lParam指定 </param>
        /// <param name="phSpeech">返回对讲句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSpeechOpen(IntPtr hDvx, ref dvxSdkType.SpeechOpenPara pPara, IntPtr hNotifyWnd, UInt32 msgId, ref IntPtr phSpeech);

        /// <summary>
        /// 开始对讲 
        /// </summary>
        /// <param name="hSpeech"> 对讲流句柄 </param>
        /// <param name="bNeedEnc"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxSpeechStart(IntPtr hSpeech, bool bNeedEnc = false);

        /// <summary>
        /// 检查当前是否正在另存实时预览视频。 
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern bool dvxRealIsSaving(IntPtr hReal);

        /// <summary>
        /// 开始另存实时预览视频 
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <param name="szFName">另存的文件路径</param>
        /// <param name="fileType">文件类型</param>
        /// <param name="openMode">文件打开方式</param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealStartSaveAs(IntPtr hReal, string szFName, int fileType, int openMode);

        /// <summary>
        /// 停止另存实时预览视频
        /// </summary>
        /// <param name="hReal">实时图像预览的句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxRealStopSaveAs(IntPtr hReal);

        /// <summary>
        /// 打开本地播放
        /// </summary>
        /// <param name="szFName">本地bsr文件名 </param>
        /// <param name="hPlayWnd">回放视频的播放窗口句柄 </param>
        /// <param name="hNotifyWnd">接收回放模块消息的窗口句柄 </param>
        /// <param name="msgId">指定接收的消息ID</param>
        /// <param name="phPlay">返回本地回放句柄</param>
        /// <param name="bUeyAreaCompareOrder"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayOpen(string szFName, IntPtr hPlayWnd, IntPtr hNotifyWnd, UInt32 msgId, ref IntPtr phPlay, bool bUeyAreaCompareOrder = false);

        /// <summary>
        /// 停止回放
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayStop(IntPtr hPlay);

        /// <summary>
        /// 关闭本地回放 
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayClose(ref IntPtr hPlay);

        /// <summary>
        /// 设置播放模式 
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <param name="nPlayMode">播放模式 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlaySetPlayMode(IntPtr hPlay, int nPlayMode);

        /// <summary>
        /// 开始回放 
        /// </summary>
        /// <param name="hPlay"> 回放句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayPlay(IntPtr hPlay);

        /// <summary>
        /// 得到本地文件的时间
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <param name="msBegin">起始时间 </param>
        /// <param name="msEnd">结束时间 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayGetTime(IntPtr hPlay, ref Int64 msBegin, ref Int64 msEnd);

        /// <summary>
        /// 获取当前以播放时间 
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <param name="ms">已经播放的时间 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxPlayGetPos(IntPtr hPlay, ref Int64 ms);

        /// <summary>
        /// 跳转 
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <param name="ms">跳转的时间(绝对时间) </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlaySeek(IntPtr hPlay, Int64 ms);

        /// <summary>
        /// 暂停播放，可用Start再接着播放 
        /// </summary>
        /// <param name="hPlay">本地回放句柄 </param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int dvxLocalPlayPause(IntPtr hPlay);


        [DllImport(ProgConstants.c_strBlueSkyVideoSDKFilePath1)]
        public static extern int dvxUkeyEt199ReadAllInfo(ref Byte[] pOutBuf, int outBufLen, ref int pRealLen);
    }
}
