using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl.SDKInterface
{
    public class SDK_ZLNetSDK
    {
        public SDK_ZLNetSDK()
        {

        }

        ///////////////////////////////////////////////////
        //结构体定义
        #region << data struct definition >>
        /************************************************************************
        ** 常量定义
        ***********************************************************************/
        public const int ZLNET_SERIALNO_LEN = 48;                                       // 设备序列号字符长度
        public const int ZLNET_MAX_DISKNUM = 256;                                   // 最大硬盘个数
        public const int ZLNET_MAX_SDCARDNUM = 32;                               // 最大SD卡个数
        public const int ZLNET_MAX_BURNING_DEV_NUM = 32;                    // 最大刻录设备个数
        public const int ZLNET_BURNING_DEV_NAMELEN = 32;                    // 刻录设备名字最大长度
        public const int ZLNET_MAX_LINK = 6;                                                // 
        public const int ZLNET_MAX_CHANNUM = 32;                            // 最大通道个数
        public const int ZLNET_MAX_CHANNUM_EX = 1024;                       // 扩展最大通道数
        public const int ZLNET_MAX_ALARMIN = 128;                           // 最大报警输入个数
        public const int ZLNET_MAX_ALARMOUT = 64;                           // 最大报警输出个数
        public const int ZLNET_MAX_RIGHT_NUM = 200;                         // 用户权限个数上限
        public const int ZLNET_MAX_GROUP_NUM = 20;                          // 用户组个数上限
        public const int ZLNET_MAX_USER_NUM = 200;                          // 用户个数上限
        public const int ZLNET_RIGHT_NAME_LENGTH = 32;                      // 权限名长度
        public const int ZLNET_USER_NAME_LENGTH = 8;                        // 用户名长度
        public const int ZLNET_USER_PSW_LENGTH = 8;                         // 用户密码长度
        public const int ZLNET_USER_NAME_LENGTH_EX = 16;			        // 用户名长度扩展,对应扩展接口ZLNET_QueryUserInfoEx和ZLNET_OperateUserInfoEx
        public const int ZLNET_USER_PSW_LENGTH_EX = 16;			        // 用户密码长度扩展
        public const int ZLNET_USER_NAME_64 = 64;			                    // 用户名长度扩展,对应扩展接口ZLNET_Login_V30
        public const int ZLNET_USER_PSW_64 = 64;		                        // 用户密码长度扩展
        public const int ZLNET_MEMO_LENGTH = 32;                            // 备注长度
        public const int ZLNET_MAX_STRING_LEN = 128;                        // 
        public const int ZLNET_DVR_SERIAL_RETURN = 1;                       // 设备发送序列号回调
        public const int ZLNET_DVR_DISCONNECT = -1;                         // 验证期间设备断线回调
        public const int ZLNET_MAX_STRING_LINE_LEN = 6;                     // 最多六行
        public const int ZLNET_MAX_PER_STRING_LEN = 20;                     // 每行最大长度
        public const int ZLNET_MAX_MAIL_NAME_LEN = 64;                      // 新的邮件结构体支持的用户名长度
        public const int ZLNET_MAX_MAIL_PSW_LEN = 64;                       // 新的邮件结构体支持的密码长度
        public const int ZLNET_FTP_URL_LEN = 64;                            // FTP url len
        public const int ZLNET_MAX_IP_LEN = 256;                            // 

        // 远程配置结构体相关常量
        public const int ZLNET_MAX_MAIL_ADDR_LEN = 128;                     // 邮件发(收)地址最大长度
        public const int ZLNET_MAX_MAIL_SUBJECT_LEN = 64;                   // 邮件主题最大长度
        public const int ZLNET_MAX_IPADDR_LEN = 16;                         // IP地址字符串长度
        public const int ZLNET_MACADDR_LEN = 40;                            // MAC地址字符串长度
        public const int ZLNET_MAX_URL_LEN = 128;                           // URL字符串长度
        public const int ZLNET_VER_SOFTWARE = 128;                          // 软件版本号
        public const int ZLNET_VERSION_LEN = 48;                            // 版本号最大长度
        public const int ZLNET_MAX_DEV_ID_LEN = 48;                         // 机器编号最大长度
        public const int ZLNET_MAX_HOST_NAMELEN = 64;                       // 主机名长度
        public const int ZLNET_MAX_HOST_PSWLEN = 32;                        // 密码长度
        public const int ZLNET_MAX_NAME_LEN = 16;                           // 通用名字字符串长度
        public const int ZLNET_MAX_ETHERNET_NUM = 2;                        // 以太网口最大个数
        public const int ZLNET_DEV_SERIALNO_LEN = 48;                       // 序列号字符串长度
        public const int ZLNET_DEV_TYPE_LEN = 32;                           // 设备类型字符串长度
        public const int ZLNET_N_WEEKS = 7;                                 // 一周的天数
        public const int ZLNET_N_TSECT = 6;                                 // 通用时间段个数
        public const int ZLNET_N_REC_TSECT = 6;                             // 录像时间段个数
        public const int ZLNET_N_COL_TSECT = 2;                             // 颜色时间段个数
        public const int ZLNET_CHAN_NAME_LEN = 32;                          // 通道名长度，DVR DSP能力限制，最多32字节
        public const int ZLNET_CHAN_NAME_LEN_EX = 80;			        // 通道名长度扩展
        public const int ZLNET_N_ENCODE_AUX = 3;                            // 扩展码流个数
        public const int ZLNET_N_TALK = 1;                                  // 最多对讲通道个数
        public const int ZLNET_N_COVERS = 1;                                // 遮挡区域个数
        public const int ZLNET_N_ALARM_TSECT = 2;                           // 报警提示时间段个数
        public const int ZLNET_MAX_ALARMOUT_NUM = 16;                       // 报警输出口个数上限
        public const int ZLNET_MAX_AUDIO_IN_NUM = 16;                       // 音频输入口个数上限
        public const int ZLNET_MAX_VIDEO_IN_NUM = 32;                       // 视频输入口个数上限
        public const int ZLNET_MAX_ALARM_IN_NUM = 32;                       // 报警输入口个数上限
        public const int ZLNET_MAX_DISK_NUM = 16;                           // 硬盘个数上限，暂定为16
        public const int ZLNET_MAX_DECODER_NUM = 32;                        // 解码器(485)个数上限
        public const int ZLNET_MAX_232FUNCS = 10;                           // 232串口功能个数上限
        public const int ZLNET_MAX_232_NUM = 2;                             // 232串口个数上限
        public const int ZLNET_MAX_COMM_NUM = 32;                           // 串口个数上限
        public const int ZLNET_MAX_DECPRO_LIST_SIZE = 100;                  // 解码器协议列表个数上限
        public const int ZLNET_FTP_MAXDIRLEN = 240;                         // FTP文件目录最大长度
        public const int ZLNET_MATRIX_MAXOUT = 16;                          // 矩阵输出口最大个数
        public const int ZLNET_TOUR_GROUP_NUM = 6;                          // 矩阵输出组最大个数
        public const int ZLNET_MAX_DDNS_NUM = 20;                           // 设备支持的ddns服务器最大个数
        public const int ZLNET_MAX_SERVER_TYPE_LEN = 32;                    // ddns服务器类型，最大字符串长度
        public const int ZLNET_MAX_DOMAIN_NAME_LEN = 256;                   // ddns域名，最大字符串长度
        public const int ZLNET_MAX_DDNS_ALIAS_LEN = 32;                     // ddns服务器别名，最大字符串长度
        public const int ZLNET_MOTION_ROW = 32;                             // 动态检测区域的行数
        public const int ZLNET_MOTION_COL = 32;                             // 动态检测区域的列数
        public const int ZLNET_FTP_USERNAME_LEN = 64;                       // FTP配置，用户名最大长度
        public const int ZLNET_FTP_PASSWORD_LEN = 64;                       // FTP配置，密码最大长度
        public const int ZLNET_TIME_SECTION = 2;                            // FTP配置，每天时间段个数
        public const int ZLNET_FTP_MAX_PATH = 240;                          // FTP配置，文件路径名最大长度
        public const int ZLNET_INTERVIDEO_UCOM_CHANID = 32;                 // 平台接入配置，U网通通道ID
        public const int ZLNET_INTERVIDEO_UCOM_DEVID = 32;                  // 平台接入配置，U网通设备ID
        public const int ZLNET_INTERVIDEO_UCOM_REGPSW = 16;                 // 平台接入配置，U网通注册密码
        public const int ZLNET_INTERVIDEO_UCOM_USERNAME = 32;               // 平台接入配置，U网通用户名
        public const int ZLNET_INTERVIDEO_UCOM_USERPSW = 32;                // 平台接入配置，U网通密码
        public const int ZLNET_INTERVIDEO_NSS_IP = 32;                      // 平台接入配置，中兴力维IP
        public const int ZLNET_INTERVIDEO_NSS_SERIAL = 32;                  // 平台接入配置，中兴力维serial
        public const int ZLNET_INTERVIDEO_NSS_USER = 32;                    // 平台接入配置，中兴力维user
        public const int ZLNET_INTERVIDEO_NSS_PWD = 50;                     // 平台接入配置，中兴力维password
        public const int ZLNET_INTERVIDEO_MR_ID = 32;                       // 平台接入配置，明软ID
        public const int ZLNET_INTERVIDEO_MR_USERPSW = 32;                  // 平台接入配置，明软用户名密码
        public const int ZLNET_MAX_VIDEO_COVER_NUM = 16;                    // 遮挡区域最大个数
        public const int ZLNET_MAX_WATERMAKE_DATA = 4096;                   // 水印图片数据最大长度
        public const int ZLNET_MAX_WATERMAKE_LETTER = 128;                  // 水印文字最大长度
        public const int ZLNET_MAX_WLANDEVICE_NUM = 10;                     // 最多搜索出的无线设备个数
        public const int ZLNET_MAX_ALARM_NAME = 64;                         // 地址长度
        public const int ZLNET_MAX_REGISTER_SERVER_NUM = 10;                // 主动注册服务器个数
        public const int ZLNET_SNIFFER_FRAMEID_NUM = 6;                     // 6个FRAME ID 选项
        public const int ZLNET_SNIFFER_CONTENT_NUM = 4;                     // 每个FRAME对应的4个抓包内容
        public const int ZLNET_SNIFFER_CONTENT_NUM_EX = 8;                  // 每个FRAME对应的8个抓包内容
        public const int ZLNET_SNIFFER_PROTOCOL_SIZE = 20;                  // 协议名字长度
        public const int ZLNET_MAX_PROTOCOL_NAME_LENGTH = 20;               // 
        public const int ZLNET_SNIFFER_GROUP_NUM = 4;                       // 4组抓包设置
        public const int ZLNET_MAX_PATH_STOR = 240;                         // 远程目录的长度
        public const int ZLNET_ALARM_OCCUR_TIME_LEN = 40;                   // 新的报警上传时间的长度
        public const int ZLNET_VIDEO_OSD_NAME_NUM = 64;                     // 叠加的名称长度，目前支持32个英文，16个中文
        public const int ZLNET_VIDEO_CUSTOM_OSD_NUM = 8;                    // 支持的自定义叠加的数目，不包含时间和通道
        public const int ZLNET_CONTROL_AUTO_REGISTER_NUM = 100;             // 支持定向主动注册服务器的个数
        public const int ZLNET_MMS_RECEIVER_NUM = 100;                      // 支持短信接收者的个数
        public const int ZLNET_MMS_SMSACTIVATION_NUM = 100;                 // 支持短信发送者的个数
        public const int ZLNET_MMS_DIALINACTIVATION_NUM = 100;              // 支持拨号发送者的个数
        public const int ZLNET_MAX_ALARMOUT_NUM_EX = 32;                    // 报警输出口个数上限扩展
        public const int ZLNET_MAX_VIDEO_IN_NUM_EX = 32;                    // 视频输入口个数上限扩展
        public const int ZLNET_MAX_ALARM_IN_NUM_EX = 32;                    // 报警输入口个数上限
        public const int ZLNET_MAX_IPADDR_OR_DOMAIN_LEN = 64;               // IP地址字符串长度密码最大长度
        public const int ZLNET_NVR_PASSWORD_LEN = 64;                       // NVR密码最大长度 
        public const int ZLNET_DEVICE_ENABLE_NUM = 64;                      // 设备能力个数
        public const int ZLENT_DEVICE_ENABLE_STR_LEN = 8;                   // 设备能力字符串长度
        public const int ZLNET_LATTICE_LEN = 2560;                          // 点阵定义32 * 24 * 24 / 8
        public const int ZLNET_CHANNEL_MODE_MAX_NUM = 32;                   // 通道模式最大个数
        public const int ZLNET_RTSP_URL_MAX_NUM = 10;                       // URL，最大字符串长度
        public const int ZLNET_WIFI_PSW_LENGTH = 64;                        // wifi密码长度
        public const int ZLNET_WIFI_NET_CARD_LEN = 12;                      // 无线网卡名长度
        public const int ZLNET_WIFI_JUNCTION_LEN = 36;                      // 连接点名称长度
        public const int ZLNET_WIFI_PROTOCOL_LNE = 8;                       // 协议加密方式长度
        public const int ZLNET_MAX_WIFI_INFO_NUM = 20;                      // wifi最大扫描个数
        public const int ZLNET_NVR_CHAN_NAME_LEN = 64;                      // NVR通道名长度,最多64字节
        public const int ZLNET_AEB_IP_LEN = 32;                             // 美电贝尔GB28181 IP长度
        public const int ZLNET_AEB_ID_LEN = 32;                             // 美电贝尔GB28181 ID长度
        public const int ZLNET_AEB_DOMAIN_LEN = 128;                        // 美电贝尔GB28181 域名长度
        public const int ZLNET_AEB_PSW_LEN = 32;                            // 美电贝尔GB28181 密码长度
        public const int ZLNET_AEB_INFO_LEN = 32;                           // 美电贝尔GB28181 信息长度
        public const int ZLNET_AEB_ALARM_INFO_NUM = 32;                     // AEB GB28181最大报警报警信息个数
        public const int ZLNET_KONLAN_IP_LEN = 32;                          // 康联 IP长度
        public const int ZLNET_KONLAN_ID_LEN = 32;                          // 康联 ID长度
        public const int ZLNET_OEM_SHTY_ID_LEN = 32;                        // OEM_SHTY ID
        public const int ZLNET_OEM_SHTY_SERVER_IP_LEN = 32;                 // OEM_SHTY Server IP
        public const int ZLNET_OEM_SHTY_INFO_LEN = 256;                     // OEM SHTY 信息长度
        public const int ZLNET_SHTY_TIME_NUM = 2;                           // OEM_SHTY 时间段个数
        public const int ZLNET_MAX_PROTOCOL_NAME_LEN = 64;                  // 协议名最大长度
        public const int ZLNET_NVR_MAX_URL_LEN = 256;                       // URL字符串长度
        public const int ZLNET_ALARM_STATE_NUM = 32;                        // 报警状态个数
        public const int ZLNET_MAX_PRESET_NUM = 256;                        // 最大预置点个数
        public const int ZLNET_MAX_TOUR_NUM = 2;                            // 巡航组个数
        public const int ZLNET_MAX_TOUR_PRESET_NUM = 32;                    // 巡航组添加的最大预置点
        public const int ZLNET_MAX_GUARD_PRESET_NUM = 8;                    // 看守位的最大预置点
        public const int ZLNET_MAX_SERVERIP_LEN = 25;                       // 手机推送服务ip最大长度
        public const int ZLNET_MAX_SERVERURI_LEN = 40;                      // 手机推送服务URL最大长度
        public const int ZLNET_MAX_PUSH_NAME_LEN = 20;                      // 手机推送服务别名最大长度
        public const int ZLNET_MAX_ACCESS_POINT_LEN = 32;                   // 3G接入点最大长度
        public const int ZLNET_MAX_DIAL_NUMBERS_LEN = 32;                   // 3G拨号号码最大长度
        public const int ZLNET_MAX_3G_USER_LEN = 32;                        // 3G用户名最大长度
        public const int ZLNET_MAX_3G_PSW_LEN = 32;                         // 3G密码最大长度
        public const int ZLNET_MAX_3G_IP_LEN = 32;                          // 3G密码最大长度
        public const int ZLNET_MAX_BACKUP_NAME_LEN = 32;                    // 备份设备最大长度
        public const int ZLNET_MAX_BACKUP_URL_LEN = 128;                    // 备份路径最大长度
        public const int ZLNET_MAX_BACKUP_DEVICE_NUM = 2;                   // 备份设备个数
        public const int ZLNET_MAX_BACKUP_FILENAME_LEN = 24;                // 备份名最大长度
        public const int ZLNET_MAX_BACKUP_EXTNAME_LEN = 4;                  // 备份扩展名最大长度
        public const int ZLNET_MAX_BACKUP_NUM = 100;                        // 备份文件最大个数
        public const int ZLNET_MAX_KEY_LEN = 256;                           // 密钥最大长度
        public const int ZLNET_KA_REMOTE_NUM = 5;                           // 遥控器最大个数
        public const int ZLNET_KA_SENSOR_NUM = 16;                          // 传感器最大个数
        public const int ZLNET_CLOUD_STORAGE_URL_LEN = 300;                 // 云存储url绑定长度
        public const int ZLNET_CLOUD_STO_UPLOADPATH_LEN = 24;               // 云存储上传路径长度
        public const int ZLNET_MAX_HG_WIRELESS_MSG = 32;                    // 韩国无线模块信息最大长度
        public const int ZLNET_MAX_HG_WIRELESS_MODULE = 32;                 // 韩国客户无线模块最大个数
        public const int ZLNET_MAX_TOKEN_LEN = 60;                          // 设备令牌长度
        public const int ZLNET_PUSH_TYPE_NUM = 18;                          // 推送类型数
        public const int ZLNET_MAX_UDX_DEV = 2048;                          // 

        // 查询类型，对应ZLNET_QueryDevState接口
        public const int ZLNET_DEVSTATE_COMM_ALARM = 0x0001;                // 查询普通报警状态(包括外部报警，视频丢失，动态检测)
        public const int ZLNET_DEVSTATE_SHELTER_ALARM = 0x0002;             // 查询遮挡报警状态
        public const int ZLNET_DEVSTATE_RECORDING = 0x0003;                 // 查询录象状态
        public const int ZLNET_DEVSTATE_DISK = 0x0004;                      // 查询硬盘信息
        public const int ZLNET_DEVSTATE_RESOURCE = 0x0005;                  // 查询系统资源状态
        public const int ZLNET_DEVSTATE_BITRATE = 0x0006;                   // 查询通道码流
        public const int ZLNET_DEVSTATE_CONN = 0x0007;                      // 查询设备连接状态
        public const int ZLNET_DEVSTATE_PROTOCAL_VER = 0x0008;              // 查询网络协议版本号，pBuf = int*
        public const int ZLNET_DEVSTATE_TALK_ECTYPE = 0x0009;               // 查询设备支持的语音对讲格式列表，见结构体ZLNET_DEV_TALKFORMAT_LIST
        public const int ZLNET_DEVSTATE_SD_CARD = 0x000A;                   // 查询SD卡信息(IPC类产品)
        public const int ZLNET_DEVSTATE_BURNING_DEV = 0x000B;               // 查询刻录机信息
        public const int ZLNET_DEVSTATE_BURNING_PROGRESS = 0x000C;          // 查询刻录进度
        public const int ZLNET_DEVSTATE_PLATFORM = 0x000D;                  // 查询设备支持的接入平台
        public const int ZLNET_DEVSTATE_CAMERA = 0x000E;                    // 查询摄像头属性信息(IPC类产品)，pBuf = ZLNET_DEV_CAMERA_INFO *，可以有多个结构体
        public const int ZLNET_DEVSTATE_SOFTWARE = 0x000F;                  // 查询设备软件版本信息
        public const int ZLNET_DEVSTATE_LANGUAGE = 0x0010;                  // 查询设备支持的语音种类
        public const int ZLNET_DEVSTATE_DSP = 0x0011;                       // 查询DSP能力描述
        public const int ZLNET_DEVSTATE_OEM = 0x0012;                       // 查询OEM信息
        public const int ZLNET_DEVSTATE_NET = 0x0013;                       // 查询网络运行状态信息
        public const int ZLNET_DEVSTATE_TYPE = 0x0014;                      // 查询设备类型
        public const int ZLNET_DEVSTATE_SNAP = 0x0015;                      // 查询抓图功能属性(IPC类产品)
        public const int ZLNET_DEVSTATE_RECORD_TIME = 0x0016;               // 查询最早录像时间和最近录像时间
        public const int ZLNET_DEVSTATE_NET_RSSI = 0x0017;                  // 查询无线网络信号强度，见结构体ZLNET_DEV_WIRELESS_RSS_INFO
        public const int ZLNET_DEVSTATE_BURNING_ATTACH = 0x0018;            // 查询附件刻录选项
        public const int ZLNET_DEVSTATE_BACKUP_DEV = 0x0019;                // 查询备份设备列表
        public const int ZLNET_DEVSTATE_BACKUP_DEV_INFO = 0x001A;           // 查询备份设备详细信息
        public const int ZLNET_DEVSTATE_BACKUP_FEEDBACK = 0x001B;           // 备份进度反馈
        public const int ZLNET_DEVSTATE_ATM_QUERY_TRADE = 0x001C;           // 查询ATM交易类型
        public const int ZLNET_DEVSTATE_SIP = 0x001D;                       // 查询sip状态
        public const int ZLNET_DEVSTATE_HARDWARE_ID = 0x001E;               // 查询硬件ID
        public const int ZLNET_DEVSTATE_PRODUCT_TYPE = 0x001F;              // 查询产品类型
        public const int ZLNET_DEVSTATE_SERIAL = 0x0020;                    // 查询设备序列号
        public const int ZLNET_DEVSTATE_UUID = 0x0021;                      // 查询设备唯一ID号
        public const int ZLNET_DEVSTATE_UUID_CLOUD = 0x0022;                // 查询设备蛮牛云ID

        // 配置类型，对应ZLNET_GetDevConfig和ZLNET_SetDevConfig接口
        public const int ZLNET_DEV_DEVICECFG = 0x0001;                      // 设备属性配置
        public const int ZLNET_DEV_NETCFG = 0x0002;                         // 网络配置
        public const int ZLNET_DEV_CHANNELCFG = 0x0003;                     // 图象通道配置
        public const int ZLNET_DEV_PREVIEWCFG = 0x0004;                     // 预览参数配置
        public const int ZLNET_DEV_RECORDCFG = 0x0005;                      // 录像配置
        public const int ZLNET_DEV_COMMCFG = 0x0006;                        // 串口属性配置 ZLNET_DEV_COMM_CFG\ZLNET_DEV_COMM_CFG_V30
        public const int ZLNET_DEV_ALARMCFG = 0x0007;                       // 报警属性配置
        public const int ZLNET_DEV_TIMECFG = 0x0008;                        // DVR时间配置
        public const int ZLNET_DEV_TALKCFG = 0x0009;                        // 对讲参数配置
        public const int ZLNET_DEV_AUTOMTCFG = 0x000A;                      // 自动维护配置
        public const int ZLNET_DEV_VEDIO_MARTIX = 0x000B;                   // 本机矩阵控制策略配置
        public const int ZLNET_DEV_MULTI_DDNS = 0x000C;                     // 多ddns服务器配置
        public const int ZLNET_DEV_SNAP_CFG = 0x000D;                       // 抓图相关配置
        public const int ZLNET_DEV_WEB_URL_CFG = 0x000E;                    // HTTP路径配置
        public const int ZLNET_DEV_FTP_PROTO_CFG = 0x000F;                  // FTP上传配置 ZLNET_FTP_PROTO_CFG\ZLNET_FTP_PROTO_CFG_EX\ZLNET_FTP_SFTP_PROTO_CFG,取决于设备能力
        public const int ZLNET_DEV_INTERVIDEO_CFG = 0x0010;                 // 平台接入配置，此时channel参数代表平台类型，
        // channel=4： 代表贝尔阿尔卡特；channel=10：代表中兴力维；channel=11：代表U网通
        public const int ZLNET_DEV_VIDEO_COVER = 0x0011;                    // 区域遮挡配置
        public const int ZLNET_DEV_TRANS_STRATEGY = 0x0012;                 // 传输策略配置，画质优先\流畅性优先
        public const int ZLNET_DEV_DOWNLOAD_STRATEGY = 0x0013;              // 录象下载策略配置，高速下载\普通下载
        public const int ZLNET_DEV_WATERMAKE_CFG = 0x0014;                  // 图象水印配置
        public const int ZLNET_DEV_WLAN_CFG = 0x0015;                       // 无线网络配置
        public const int ZLNET_DEV_WLAN_DEVICE_CFG = 0x0016;                // 搜索无线设备配置
        public const int ZLNET_DEV_REGISTER_CFG = 0x0017;                   // 主动注册参数配置
        public const int ZLNET_DEV_CAMERA_CFG = 0x0018;                     // 摄像头属性配置
        public const int ZLNET_DEV_INFRARED_CFG = 0x0019;                   // 红外报警配置
        public const int ZLNET_DEV_SNIFFER_CFG = 0x001A;                    // Sniffer抓包配置
        public const int ZLNET_DEV_MAIL_CFG = 0x001B;                       // 邮件配置
        public const int ZLNET_DEV_DNS_CFG = 0x001C;                        // DNS服务器配置
        public const int ZLNET_DEV_NTP_CFG = 0x001D;                        // NTP配置
        public const int ZLNET_DEV_AUDIO_DETECT_CFG = 0x001E;               // 音频检测配置
        public const int ZLNET_DEV_STORAGE_STATION_CFG = 0x001F;            // 存储位置配置
        public const int ZLNET_DEV_PTZ_OPT_CFG = 0x0020;                    // 云台操作属性(已经废除，请使用ZLNET_GetPtzOptAttr获取云台操作属性)
        public const int ZLNET_DEV_DST_CFG = 0x0021;                        // 夏令时配置
        public const int ZLNET_DEV_ALARM_CENTER_CFG = 0x0022;               // 报警中心配置
        public const int ZLNET_DEV_VIDEO_OSD_CFG = 0x0023;                  // 视频OSD叠加配置 ZLNET_DVR_VIDEOOSD_CFG
        public const int ZLNET_DEV_CDMAGPRS_CFG = 0x0024;                   // CDMA\GPRS网络配置

        public const int ZLNET_DEV_IPFILTER_CFG = 0x0025;                   // IP过滤配置 暂不支持
        public const int ZLNET_DEV_TALK_ENCODE_CFG = 0x0026;                // 语音对讲编码配置 暂不支持
        public const int ZLNET_DEV_RECORD_PACKET_CFG = 0x0027;              // 录像打包长度配置 暂不支持
        public const int ZLNET_DEV_MMS_CFG = 0x0028;                        // 短信MMS配置  暂不支持
        public const int ZLNET_DEV_SMSACTIVATION_CFG = 0x0029;              // 短信激活无线连接配置 暂不支持
        public const int ZLNET_DEV_DIALINACTIVATION_CFG = 0x002A;           // 拨号激活无线连接配置 暂不支持
        public const int ZLNET_DEV_FILETRANS_STOP = 0x002B;                 // 停止文件上传
        public const int ZLNET_DEV_FILETRANS_BURN = 0x002C;                 // 刻录文件上传
        public const int ZLNET_DEV_SNIFFER_CFG_EX = 0x0030;                 // 网络抓包配置 暂不支持
        public const int ZLNET_DEV_DOWNLOAD_RATE_CFG = 0x0031;              // 下载速度限制 暂不支持
        public const int ZLNET_DEV_PANORAMA_SWITCH_CFG = 0x0032;            // 全景切换报警配置
        public const int ZLNET_DEV_LOST_FOCUS_CFG = 0x0033;                 // 失去焦点报警配置
        public const int ZLNET_DEV_ALARM_DECODE_CFG = 0x0034;               // 报警解码器配置
        public const int ZLNET_DEV_VIDEOOUT_CFG = 0x0035;                   // 视频输出参数配置 暂不支持
        public const int ZLNET_DEV_POINT_CFG = 0x0036;                      // 预制点使能配置 暂不支持
        public const int ZLNET_DEV_IP_COLLISION_CFG = 0x0037;               // Ip冲突检测报警配置(结构体ZLNET_ALARM_IP_COLLISION_CFG)
        public const int ZLNET_DEV_LOCALALARM_CFG = 0x0039;                 // 本地报警配置(结构体ZLNET_ALARMIN_CFG_EX)
        public const int ZLNET_DEV_NETALARM_CFG = 0x003A;                   // 网络报警配置(结构体ZLNET_ALARMIN_CFG_EX)
        public const int ZLNET_DEV_MOTIONALARM_CFG = 0x003B;                // 动检报警配置(结构体ZLNET_MOTION_DETECT_CFG_EX)
        public const int ZLNET_DEV_VIDEOLOSTALARM_CFG = 0x003C;             // 视频丢失报警配置(结构体ZLNET_VIDEO_LOST_CFG_EX)
        public const int ZLNET_DEV_BLINDALARM_CFG = 0x003D;                 // 视频遮挡报警配置(结构体ZLNET_BLIND_CFG_EX)
        public const int ZLNET_DEV_DISKALARM_CFG = 0x003E;                  // 硬盘报警配置(结构体ZLNET_DISK_ALARM_CFG_EX)
        public const int ZLNET_DEV_NETBROKENALARM_CFG = 0x003F;             // 网络中断报警配置(结构体ZLNET_NETBROKEN_ALARM_CFG_EX)
        public const int ZLNET_DEV_ENCODER_CFG = 0x0040;                    // 数字通道的前端编码器信息（混合DVR使用，结构体ZLNET_DEV_ENCODER_CFG） 暂不支持
        public const int ZLNET_DEV_TV_ADJUST_CFG = 0x0041;                  // TV调节配置（channel代表TV号(0开始)，类型结构体） 暂不支持
        public const int ZLNET_DEV_ABOUT_VEHICLE_CFG = 0x0042;              // 车载相关配置，北京公交使用  暂不支持
        public const int ZLNET_DEV_ATM_OVERLAY_ABILITY = 0x0043;            // 获取atm叠加支持能力信息，不支持Set  暂不支持
        public const int ZLNET_DEV_ATM_OVERLAY_CFG = 0x0044;                // atm叠加配置，新atm特有  暂不支持
        public const int ZLNET_DEV_DECODER_TOUR_CFG = 0x0045;               // 解码器解码轮巡配置  暂不支持
        public const int ZLNET_DEV_SIP_CFG = 0x0046;                        // SIP配置  暂不支持
        public const int ZLNET_DEV_LATTICE = 0x0047;                        // 设置通道名点阵，不支持Get,(结构体ZLNET_CHANNEL_NAME_LATTICE）
        public const int ZLNET_DEV_NET_ALARM_CFG = 0x0048;                  // 网络通道报警配置(结构体ZLNET_NET_CHANNEL_ALARM_CFG)
        public const int ZLNET_DEV_ASSIST_LATTICE = 0x0049;                 // 辅助通道名点阵（ZLNET_ASSIST_CHANNEL_NAME_LATTICE）

        // 二代配置，以下对应ZLNET_GetDevConfigEx和ZLNET_SetDevConfigEx接口
        public const int ZLNET_DEV_GATEWAYIPC_WORKMODE = 0x004A;            // 出入口相机工作参数(ZLNET_GATEWAY_CAMERA_WORKMODE)
        public const int ZLNET_DEV_ALARM_RULE_CFG = 0x0100;                         // 报警规则参数(ZLNET_ALARM_RULE_CONFIG)，dwSubCommand填ZLNET_F6ALARM_TYPE
        public const int ZLNET_DEV_VIDEOIN_CFG = 0x0101;                               // 视频输入前端选项(ZLNET_VIDEOIN_CONFIG)
        public const int ZLNET_DEV_SMARTSENSOR_CFG = 0x0102;                     // 智能传感器配置（ZLNET_SMARTSENSOR_CONFIG）
        public const int ZLNET_DEV_EVENT_GROUP_CFG = 0x0103;                      // 联动组配置（ZLNET_EVENT_HANDLER_GROUP）
        public const int ZLNET_DEV_SENSOR_ALARM_CFG = 0x0104;                    // 智能传感器报警配置（ZLNET_SENSOR_ALARM_CONFIG）
        public const int ZLNET_DEV_SHORTMSG_CFG = 0x0105;                           // 短信联系人配置（ZLNET_SHORTMSG_CFG）
        public const int ZLNET_DEV_AISENSOR_CFG = 0x0106;                             // AI传感器配置（ZLNET_ANALOG_CONFIG）
        public const int ZLNET_DEV_ALARMIN_CFG = 0x0107;                              // DI传感器配置（ZLNET_ALARMIN_CONFIG）
        public const int ZLNET_DEV_ALARMOUT_CFG = 0x0108;                           // DO配置（ZLNET_ALARMOUT_CONFIG）
        public const int ZLNET_DEV_COMMPORT_CFG = 0x0109;                         // 串口属性配置V30 (ZLNET_DEV_COMM_CFG_V30)

        // 报警类型，对应ZLNET_StartListen接口
        public const int ZLNET_COMM_ALARM = 0x1100;                         // 常规报警(包括外部报警，视频丢失，动态检测)
        public const int ZLNET_SHELTER_ALARM = 0x1101;                      // 视频遮挡报警
        public const int ZLNET_DISK_FULL_ALARM = 0x1102;                    // 硬盘满报警
        public const int ZLNET_DISK_ERROR_ALARM = 0x1103;                   // 硬盘故障报警
        public const int ZLNET_SOUND_DETECT_ALARM = 0x1104;                 // 音频检测报警
        public const int ZLNET_ALARM_DECODER_ALARM = 0x1105;                // 报警解码器报警
        public const int ZLNET_ALARM_IDVR_ALARM = 0x1106;                   // 智能ATM报警
        public const int ZLNET_ALARM_IDVR_STAFFCOUNT = 0x1107;              // 智能人员统计信息
        public const int ZLNET_ALARM_IDVR_PLATEID = 0x1108;                 // 智能车牌信息

        // 扩展报警类型，对应ZLNET_StartListenEx接口
        public const int ZLNET_ALARM_ALARM_EX = 0x2101;                     // 外部报警
        public const int ZLNET_MOTION_ALARM_EX = 0x2102;                    // 动态检测报警
        public const int ZLNET_VIDEOLOST_ALARM_EX = 0x2103;                 // 视频丢失报警
        public const int ZLNET_SHELTER_ALARM_EX = 0x2104;                   // 视频遮挡报警
        public const int ZLNET_SOUND_DETECT_ALARM_EX = 0x2105;              // 音频检测报警
        public const int ZLNET_DISKFULL_ALARM_EX = 0x2106;                  // 硬盘满报警
        public const int ZLNET_DISKERROR_ALARM_EX = 0x2107;                 // 坏硬盘报警
        public const int ZLNET_MIXED_CHN_ALARM_EX = 0x2109;                 // 网络通道断线报警
        public const int ZLNET_ENCODER_ALARM_EX = 0x210A;                   // 编码器报警
        public const int ZLNET_URGENCY_ALARM_EX = 0x210B;                   // 紧急报警
        public const int ZLNET_WIRELESS_ALARM_EX = 0x210C;                  // 无线报警
        public const int ZLNET_NEW_SOUND_DETECT_ALARM_EX = 0x210D;          // 新音频检测报警，报警信息的结构体见ZLNET_NEW_SOUND_ALARM_STATE；
        public const int ZLNET_ALARM_DECODER_ALARM_EX = 0x210E;             // 报警解码器报警
        public const int ZLNET_DECODER_DECODE_ABILITY = 0x210F;             // 解码器：解码能力报警
        public const int ZLNET_FDDI_DECODER_ABILITY = 0x2110;               // 光纤编码器状态报警
        public const int ZLNET_PANORAMA_SWITCH_ALARM_EX = 0x2111;           // 切换场景报警
        public const int ZLNET_LOSTFOCUS_ALARM_EX = 0x2112;                 // 失去焦点报警
        public const int ZLNET_OEMSTATE_EX = 0x2113;                        // oem报停状态
        public const int ZLNET_DSP_ALARM_EX = 0x2114;                       // DSP报警
        public const int ZLNET_ATMPOS_BROKEN_EX = 0x2115;                   // atm和pos机断开报警， 0：连接断开 1：连接正常
        public const int ZLNET_RECORD_CHANGED_EX = 0x2116;                  // 录像状态变化报警
        public const int ZLNET_DEVICE_REBOOT_EX = 0x2118;                   // 设备重启报警
        public const int ZLNET_CONFIG_CHANGED_EX = 0x2117;                  // 配置发生变化报警

        // 事件类型
        public const int ZLNET_CONFIG_RESULT_EVENT_EX = 0x3000;             // 修改配置的返回码；返回结构见DEV_SET_RESULT
        public const int ZLNET_REBOOT_EVENT_EX = 0x3001;                    // 设备重启事件；如果未发送重启命令，当前修改的配置不会立即生效
        public const int ZLNET_AUTO_TALK_START_EX = 0x3002;                 // 设备主动邀请开始语音对讲
        public const int ZLNET_AUTO_TALK_STOP_EX = 0x3003;                  // 设备主动停止语音对讲
        public const int ZLNET_CONFIG_CHANGE_EX = 0x3004;                   // 设备配置发生改变

        // 报警上传功能的报警类型，对应ZLNET_StartService接口、NEW_ALARM_UPLOAD结构体.
        public const int ZLNET_UPLOAD_ALARM = 0x4000;                       // 外部报警
        public const int ZLNET_UPLOAD_MOTION_ALARM = 0x4001;                // 动态检测报警
        public const int ZLNET_UPLOAD_VIDEOLOST_ALARM = 0x4002;             // 视频丢失报警
        public const int ZLNET_UPLOAD_SHELTER_ALARM = 0x4003;               // 视频遮挡报警
        public const int ZLNET_UPLOAD_SOUND_DETECT_ALARM = 0x4004;          // 音频检测报警
        public const int ZLNET_UPLOAD_DISKFULL_ALARM = 0x4005;              // 硬盘满报警
        public const int ZLNET_UPLOAD_DISKERROR_ALARM = 0x4006;             // 坏硬盘报警
        public const int ZLNET_UPLOAD_ENCODER_ALARM = 0x4007;               // 编码器报警
        public const int ZLNET_UPLOAD_DECODER_ALARM = 0x400B;               // 报警解码器报警
        public const int ZLNET_UPLOAD_EVENT = 0x400C;                       // 定时上传的

        // 异步接口回调类型
        public const uint ZLNET_RESPONSE_DECODER_CTRL_TV = 0x00000001;      // 对应ZLNET_CtrlDecTVScreen接口
        public const uint ZLNET_RESPONSE_DECODER_SWITCH_TV = 0x00000002;    // 对应ZLNET_SwitchDecTVEncoder接口
        public const uint ZLNET_RESPONSE_DECODER_PLAYBACK = 0x00000003;     // 对应ZLNET_DecTVPlayback接口

        // 报警联动动作，用于与报警联动动作掩码进行与、或操作
        public const uint ZLNET_ALARM_UPLOAD = 0x00000001;
        public const uint ZLNET_ALARM_RECORD = 0x00000002;
        public const uint ZLNET_ALARM_PTZ = 0x00000004;
        public const uint ZLNET_ALARM_MAIL = 0x00000008;
        public const uint ZLNET_ALARM_TOUR = 0x00000010;
        public const uint ZLNET_ALARM_TIP = 0x00000020;
        public const uint ZLNET_ALARM_OUT = 0x00000040;
        public const uint ZLNET_ALARM_FTP_UL = 0x00000080;
        public const uint ZLNET_ALARM_BEEP = 0x00000100;
        public const uint ZLNET_ALARM_VOICE = 0x00000200;
        public const uint ZLNET_ALARM_SNAP = 0x00000400;
        public const uint ZLNET_ALARM_PUSH = 0x00000800;
        public const uint ZLNET_ALARM_CLOUD = 0x00001000;

        // "恢复默认配置"掩码，可进行与、或操作
        public const uint ZLNET_RESTORE_COMMON = 0x00000001;                // 普通设置
        public const uint ZLNET_RESTORE_CODING = 0x00000002;                // 编码设置
        public const uint ZLNET_RESTORE_VIDEO = 0x00000004;                 // 录像设置
        public const uint ZLNET_RESTORE_COMM = 0x00000008;                  // 串口设置
        public const uint ZLNET_RESTORE_NETWORK = 0x00000010;               // 网络设置
        public const uint ZLNET_RESTORE_ALARM = 0x00000020;                 // 报警设置
        public const uint ZLNET_RESTORE_VIDEODETECT = 0x00000040;           // 视频检测
        public const uint ZLNET_RESTORE_PTZ = 0x00000080;                   // 云台控制
        public const uint ZLNET_RESTORE_OUTPUTMODE = 0x00000100;            // 输出模式
        public const uint ZLNET_RESTORE_CHANNELNAME = 0x00000200;           // 通道名称
        public const uint ZLNET_RESTORE_VIDEO_COLOR = 0x00010000;           // 视频颜色参数恢复默认
        public const uint ZLNET_RESTORE_ALL = 0x80000000;                   // 全部重置

        // 云台属性列表
        // 低四个字节掩码
        public const uint ZLNET_PTZ_DIRECTION = 0x00000001;                 // 方向
        public const uint ZLNET_PTZ_ZOOM = 0x00000002;                      // 变倍
        public const uint ZLNET_PTZ_FOCUS = 0x00000004;                     // 聚焦
        public const uint ZLNET_PTZ_IRIS = 0x00000008;                      // 光圈
        public const uint ZLNET_PTZ_ALARM = 0x00000010;                     // 报警功能
        public const uint ZLNET_PTZ_LIGHT = 0x00000020;                     // 灯光
        public const uint ZLNET_PTZ_SETPRESET = 0x00000040;                 // 设置预置点
        public const uint ZLNET_PTZ_CLEARPRESET = 0x00000080;               // 清除预置点
        public const uint ZLNET_PTZ_GOTOPRESET = 0x00000100;                // 转至预置点
        public const uint ZLNET_PTZ_AUTOPANON = 0x00000200;                 // 水平开始
        public const uint ZLNET_PTZ_AUTOPANOFF = 0x00000400;                // 水平结束
        public const uint ZLNET_PTZ_SETLIMIT = 0x00000800;                  // 设置边界
        public const uint ZLNET_PTZ_AUTOSCANON = 0x00001000;                // 自动扫描开始
        public const uint ZLNET_PTZ_AUTOSCANOFF = 0x00002000;               // 自动扫描开停止
        public const uint ZLNET_PTZ_ADDTOUR = 0x00004000;                   // 增加巡航点
        public const uint ZLNET_PTZ_DELETETOUR = 0x00008000;                // 删除巡航点
        public const uint ZLNET_PTZ_STARTTOUR = 0x00010000;                 // 开始巡航
        public const uint ZLNET_PTZ_STOPTOUR = 0x00020000;                  // 结束巡航
        public const uint ZLNET_PTZ_CLEARTOUR = 0x00040000;                 // 删除巡航
        public const uint ZLNET_PTZ_SETPATTERN = 0x00080000;                // 设置模式
        public const uint ZLNET_PTZ_STARTPATTERN = 0x00100000;              // 开始模式
        public const uint ZLNET_PTZ_STOPPATTERN = 0x00200000;               // 停止模式
        public const uint ZLNET_PTZ_CLEARPATTERN = 0x00400000;              // 清除模式
        public const uint ZLNET_PTZ_POSITION = 0x00800000;                  // 快速定位
        public const uint ZLNET_PTZ_AUX = 0x01000000;                       // 辅助开关
        public const uint ZLNET_PTZ_MENU = 0x02000000;                      // 球机菜单
        public const uint ZLNET_PTZ_EXIT = 0x04000000;                      // 退出球机菜单
        public const uint ZLNET_PTZ_ENTER = 0x08000000;                     // 确认
        public const uint ZLNET_PTZ_ESC = 0x10000000;                       // 取消
        public const uint ZLNET_PTZ_MENUUPDOWN = 0x20000000;                // 菜单上下操作
        public const uint ZLNET_PTZ_MENULEFTRIGHT = 0x40000000;             // 菜单左右操作
        public const uint ZLNET_PTZ_OPT_NUM = 0x80000000;                   // 操作的个数
        // 高四个字节掩码
        public const uint ZLNET_PTZ_DEV = 0x00000001;                       // 云台控制
        public const uint ZLNET_PTZ_MATRIX = 0x00000002;                    // 矩阵控制

        // 抓图视频编码类型
        public const int ZLNET_CODETYPE_MPEG4 = 0;
        public const int ZLNET_CODETYPE_H264 = 1;
        public const int ZLNET_CODETYPE_JPG = 2;

        // 码流控制列表
        public const int ZLNET_CAPTURE_BRC_CBR = 0;
        public const int ZLNET_CAPTURE_BRC_VBR = 1;
        public const int ZLNET_CAPTURE_BRC_MBR = 2;

        public const int ZLNET_WEEKS_NUM = 7;                               // 一个星期7天
        public const int ZLNET_TSECT_NUM = 6;                               // 每天6个时间段

        //智能ATM
        public const int ZLNET_IVA_MAX_CHANNEL = 4;                         // 最多通道数
        public const int ZLNET_IVA_MAX_NUM_ATMALARM_RECT = 10;              // 最多区域数

        //区域配置结构体相关常量
        public const int ZLNET_IVA_ATM_TOTAL = 20;                          // ATM区域类型总数
        public const int ZLNET_IVA_MAX_NUM_REGION = 20;                     // 最多检测区域数量
        public const int ZLNET_IVA_MAX_POLYGON_POINT = 20;                  // 多边形点数
        public const int ZLNET_IVA_MAX_NUM_FACE_AREA = 3;                   // 人脸区域数量
        public const int ZLNET_IVA_MAX_NUM_LICENSE_PLATE = 5;               // 车牌最多检测区域数量
        public const int ZLNET_IVA_MAX_NUM_PROCESS_AREA = 1;                // 处理区域最多个数
        public const int ZLNET_IVA_MAX_SHIELDED_AREA_NUM = 9;               // 屏蔽区域最多个数
        public const int ZLNET_IVA_MAX_SSB_AREA = 9;                        // 自助厅处理区域(1) + 屏蔽区域(10) + 操作区域(9)
        public const int ZLNET_IVA_MAX_NUM_SSBALARM = 9;                    // 自助银行报警区域
        public const int ZLNET_IVA_MAX_NUM_FACEALARM = 9;                   // 人脸报警区域
        public const int ZLNET_IVA_MAX_BZS_PROCESS_NUM = ZLNET_IVA_MAX_NUM_PROCESS_AREA + ZLNET_IVA_MAX_SHIELDED_AREA_NUM;
        public const int ZLNET_IVA_MAX_BZS_POLYGON_POINT = 10;              // 周界多边形点数
        public const int ZLNET_IVA_MAX_BZS_RULE_REGION = 18;                // 周界规则个数

        public const int ZLNET_IVA_MAX_REGIST_NUM = 16;                     // 设备支持的最大主动注册IP数量
        public const int ZLNET_IVA_MAX_ONLINE = 10;                         // 最多在线用户

        //算法调试
        public const int ZLNET_IVA_ARITHMETIC_DEBUG_LEN = 2;                // 算法调试个数
        public const int MAX_NUM_SSB_TRACKEDINFO = 10;                      // SSB算法调试信息的个数
        public const int MAX_NUM_SSB_TRACKEDINFO_EX = 20;                   // SSB算法调试信息的个数扩展

        //轨迹跟踪
        public const int MAX_TRACK_COUNT = 120;                             // 轨迹跟踪回调最大上传个数

        //智能人脸
        public const int ZLNET_IVA_MAX_FACE_AREA_NUM = 1;                   // 人脸检测最多区域个数
        public const int ZLNET_IVA_MAX_NUM_FACE_TRACKEDINFO = 10;           // 人脸算法调试信息结果个数
        public const int ZLNET_IVA_MAX_FACE_SHIELDED_AREA_NUM = 10;         // 屏蔽区域最多个数
        public const int ZLNET_IVA_MAX_FACE_ALARMRECT_NUM = 10;             // 人脸叠加区域上限

        public const int ZLNET_MAX_REV_LIST = 5;                            // 反向连接最大配置服务器数量
        public const int ZLNET_MAX_NETMULT_ID = 16;                         // 单通道最大播放数量

        // 错误类型代号，对应ZLNET_GetLastError接口的返回值
        public const int ZLNET_NOERROR = 0;                                 // 没有错误
        public const int ZLNET_ERROR = -1;                                  // 未知错误
        public const int ZLNET_SYSTEM_ERROR = 1;                            // Windows系统出错
        public const int ZLNET_NETWORK_ERROR = 2;                           // 网络错误，可能是因为网络超时
        public const int ZLNET_DEV_VER_NOMATCH = 3;                         // 设备协议不匹配
        public const int ZLNET_INVALID_HANDLE = 4;                          // 句柄无效
        public const int ZLNET_OPEN_CHANNEL_ERROR = 5;                      // 打开通道失败
        public const int ZLNET_CLOSE_CHANNEL_ERROR = 6;                     // 关闭通道失败
        public const int ZLNET_ILLEGAL_PARAM = 7;                           // 用户参数不合法
        public const int ZLNET_SDK_INIT_ERROR = 8;                          // SDK初始化出错
        public const int ZLNET_SDK_UNINIT_ERROR = 9;                        // SDK清理出错
        public const int ZLNET_RENDER_OPEN_ERROR = 10;                      // 申请render资源出错
        public const int ZLNET_DEC_OPEN_ERROR = 11;                         // 打开解码库出错
        public const int ZLNET_DEC_CLOSE_ERROR = 12;                        // 关闭解码库出错
        public const int ZLNET_MULTIPLAY_NOCHANNEL = 13;                    // 多画面预览中检测到通道数为0
        public const int ZLNET_TALK_INIT_ERROR = 14;                        // 录音库初始化失败
        public const int ZLNET_TALK_NOT_INIT = 15;                          // 录音库未经初始化
        public const int ZLNET_TALK_SENDDATA_ERROR = 16;                    // 发送音频数据出错
        public const int ZLNET_REAL_ALREADY_SAVING = 17;                    // 实时数据已经处于保存状态
        public const int ZLNET_NOT_SAVING = 18;                             // 未保存实时数据
        public const int ZLNET_OPEN_FILE_ERROR = 19;                        // 打开文件出错
        public const int ZLNET_PTZ_SET_TIMER_ERROR = 20;                    // 启动云台控制定时器失败
        public const int ZLNET_RETURN_DATA_ERROR = 21;                      // 对返回数据的校验出错
        public const int ZLNET_INSUFFICIENT_BUFFER = 22;                    // 没有足够的缓存
        public const int ZLNET_NOT_SUPPORTED = 23;                          // 当前SDK未支持该功能
        public const int ZLNET_NO_RECORD_FOUND = 24;                        // 查询不到录象
        public const int ZLNET_NOT_AUTHORIZED = 25;                         // 无操作权限
        public const int ZLNET_NOT_NOW = 26;                                // 暂时无法执行
        public const int ZLNET_NO_TALK_CHANNEL = 27;                        // 未发现对讲通道
        public const int ZLNET_NO_AUDIO = 28;                               // 未发现音频
        public const int ZLNET_NO_INIT = 29;                                // 网络SDK未经初始化
        public const int ZLNET_DOWNLOAD_END = 30;                           // 下载已结束
        public const int ZLNET_EMPTY_LIST = 31;                             // 查询结果为空
        public const int ZLNET_ERROR_GETCFG_SYSATTR = 32;                   // 获取系统属性配置失败
        public const int ZLNET_ERROR_GETCFG_SERIAL = 33;                    // 获取序列号失败
        public const int ZLNET_ERROR_GETCFG_GENERAL = 34;                   // 获取常规属性失败
        public const int ZLNET_ERROR_GETCFG_DSPCAP = 35;                    // 获取DSP能力描述失败
        public const int ZLNET_ERROR_GETCFG_NETCFG = 36;                    // 获取网络配置失败
        public const int ZLNET_ERROR_GETCFG_CHANNAME = 37;                  // 获取通道名称失败
        public const int ZLNET_ERROR_GETCFG_VIDEO = 38;                     // 获取视频属性失败
        public const int ZLNET_ERROR_GETCFG_RECORD = 39;                    // 获取录象配置失败
        public const int ZLNET_ERROR_GETCFG_PRONAME = 40;                   // 获取解码器协议名称失败
        public const int ZLNET_ERROR_GETCFG_FUNCNAME = 41;                  // 获取232串口功能名称失败
        public const int ZLNET_ERROR_GETCFG_485DECODER = 42;                // 获取解码器属性失败
        public const int ZLNET_ERROR_GETCFG_232COM = 43;                    // 获取232串口配置失败
        public const int ZLNET_ERROR_GETCFG_ALARMIN = 44;                   // 获取外部报警输入配置失败
        public const int ZLNET_ERROR_GETCFG_ALARMDET = 45;                  // 获取动态检测报警失败
        public const int ZLNET_ERROR_GETCFG_SYSTIME = 46;                   // 获取设备时间失败
        public const int ZLNET_ERROR_GETCFG_PREVIEW = 47;                   // 获取预览参数失败
        public const int ZLNET_ERROR_GETCFG_AUTOMT = 48;                    // 获取自动维护配置失败
        public const int ZLNET_ERROR_GETCFG_VIDEOMTRX = 49;                 // 获取视频矩阵配置失败
        public const int ZLNET_ERROR_GETCFG_COVER = 50;                     // 获取区域遮挡配置失败
        public const int ZLNET_ERROR_GETCFG_WATERMAKE = 51;                 // 获取图象水印配置失败
        public const int ZLNET_ERROR_SETCFG_GENERAL = 55;                   // 修改常规属性失败
        public const int ZLNET_ERROR_SETCFG_NETCFG = 56;                    // 修改网络配置失败
        public const int ZLNET_ERROR_SETCFG_CHANNAME = 57;                  // 修改通道名称失败
        public const int ZLNET_ERROR_SETCFG_VIDEO = 58;                     // 修改视频属性失败
        public const int ZLNET_ERROR_SETCFG_RECORD = 59;                    // 修改录象配置失败
        public const int ZLNET_ERROR_SETCFG_485DECODER = 60;                // 修改解码器属性失败
        public const int ZLNET_ERROR_SETCFG_232COM = 61;                    // 修改232串口配置失败
        public const int ZLNET_ERROR_SETCFG_ALARMIN = 62;                   // 修改外部输入报警配置失败
        public const int ZLNET_ERROR_SETCFG_ALARMDET = 63;                  // 修改动态检测报警配置失败
        public const int ZLNET_ERROR_SETCFG_SYSTIME = 64;                   // 修改设备时间失败
        public const int ZLNET_ERROR_SETCFG_PREVIEW = 65;                   // 修改预览参数失败
        public const int ZLNET_ERROR_SETCFG_AUTOMT = 66;                    // 修改自动维护配置失败
        public const int ZLNET_ERROR_SETCFG_VIDEOMTRX = 67;                 // 修改视频矩阵配置失败
        public const int ZLNET_ERROR_SETCFG_COVER = 68;                     // 修改区域遮挡配置失败
        public const int ZLNET_ERROR_SETCFG_WATERMAKE = 69;                 // 修改图象水印配置失败
        public const int ZLNET_ERROR_SETCFG_WLAN = 70;                      // 修改无线网络信息失败
        public const int ZLNET_ERROR_SETCFG_WLANDEV = 71;                   // 选择无线网络设备失败
        public const int ZLNET_ERROR_SETCFG_REGISTER = 72;                  // 修改主动注册参数配置失败
        public const int ZLNET_ERROR_SETCFG_CAMERA = 73;                    // 修改摄像头属性配置失败
        public const int ZLNET_ERROR_SETCFG_INFRARED = 74;                  // 修改红外报警配置失败
        public const int ZLNET_ERROR_SETCFG_SOUNDALARM = 75;                // 修改音频报警配置失败
        public const int ZLNET_ERROR_SETCFG_STORAGE = 76;                   // 修改存储位置配置失败
        public const int ZLNET_AUDIOENCODE_NOTINIT = 77;                    // 音频编码接口没有成功初始化
        public const int ZLNET_DATA_TOOLONGH = 78;                          // 数据过长
        public const int ZLNET_UNSUPPORTED = 79;                            // 设备不支持该操作
        public const int ZLNET_DEVICE_BUSY = 80;                            // 设备资源不足
        public const int ZLNET_SERVER_STARTED = 81;                         // 服务器已经启动
        public const int ZLNET_SERVER_STOPPED = 82;                         // 服务器尚未成功启动
        public const int ZLNET_LISTER_INCORRECT_SERIAL = 83;                // 输入序列号有误
        public const int ZLNET_QUERY_DISKINFO_FAILED = 84;                  // 获取硬盘信息失败
        public const int ZLNET_ERROR_GETCFG_SESSION = 85;                   // 获取连接Session信息
        public const int ZLNET_USER_FLASEPWD_TRYTIME = 86;                  // 输入密码错误超过限制次数
        public const int ZLNET_LOGIN_ERROR_PASSWORD = 100;                  // 密码不正确
        public const int ZLNET_LOGIN_ERROR_USER = 101;                      // 帐户不存在
        public const int ZLNET_LOGIN_ERROR_TIMEOUT = 102;                   // 等待登录返回超时
        public const int ZLNET_LOGIN_ERROR_RELOGGIN = 103;                  // 帐号已登录
        public const int ZLNET_LOGIN_ERROR_LOCKED = 104;                    // 帐号已被锁定
        public const int ZLNET_LOGIN_ERROR_BLACKLIST = 105;                 // 帐号已被列为黑名单
        public const int ZLNET_LOGIN_ERROR_BUSY = 106;                      // 资源不足，系统忙
        public const int ZLNET_LOGIN_ERROR_CONNECT = 107;                   // 登录设备超时，请检查网络并重试
        public const int ZLNET_LOGIN_ERROR_NETWORK = 108;                   // 网络连接失败
        public const int ZLNET_LOGIN_ERROR_SUBCONNECT = 109;                // 登录设备成功，但无法创建视频通道，请检查网络状况
        public const int ZLNET_RENDER_SOUND_ON_ERROR = 120;                 // Render库打开音频出错
        public const int ZLNET_RENDER_SOUND_OFF_ERROR = 121;                // Render库关闭音频出错
        public const int ZLNET_RENDER_SET_VOLUME_ERROR = 122;               // Render库控制音量出错
        public const int ZLNET_RENDER_ADJUST_ERROR = 123;                   // Render库设置画面参数出错
        public const int ZLNET_RENDER_PAUSE_ERROR = 124;                    // Render库暂停播放出错
        public const int ZLNET_RENDER_SNAP_ERROR = 125;                     // Render库抓图出错
        public const int ZLNET_RENDER_STEP_ERROR = 126;                     // Render库步进出错
        public const int ZLNET_RENDER_FRAMERATE_ERROR = 127;                // Render库设置帧率出错
        public const int ZLNET_GROUP_EXIST = 140;                           // 组名已存在
        public const int ZLNET_GROUP_NOEXIST = 141;                         // 组名不存在
        public const int ZLNET_GROUP_RIGHTOVER = 142;                       // 组的权限超出权限列表范围
        public const int ZLNET_GROUP_HAVEUSER = 143;                        // 组下有用户，不能删除
        public const int ZLNET_GROUP_RIGHTUSE = 144;                        // 组的某个权限被用户使用，不能出除
        public const int ZLNET_GROUP_SAMENAME = 145;                        // 新组名同已有组名重复
        public const int ZLNET_USER_EXIST = 146;                            // 用户已存在
        public const int ZLNET_USER_NOEXIST = 147;                          // 用户不存在
        public const int ZLNET_USER_RIGHTOVER = 148;                        // 用户权限超出组权限
        public const int ZLNET_USER_PWD = 149;                              // 保留帐号，不容许修改密码
        public const int ZLNET_USER_FLASEPWD = 150;                         // 密码不正确
        public const int ZLNET_USER_NOMATCHING = 151;                       // 密码不匹配
        public const int ZLNET_ERROR_GETCFG_ETHERNET = 300;                 // 获取网卡配置失败
        public const int ZLNET_ERROR_GETCFG_WLAN = 301;                     // 获取无线网络信息失败
        public const int ZLNET_ERROR_GETCFG_WLANDEV = 302;                  // 获取无线网络设备失败
        public const int ZLNET_ERROR_GETCFG_REGISTER = 303;                 // 获取主动注册参数失败
        public const int ZLNET_ERROR_GETCFG_CAMERA = 304;                   // 获取摄像头属性失败
        public const int ZLNET_ERROR_GETCFG_INFRARED = 305;                 // 获取红外报警配置失败
        public const int ZLNET_ERROR_GETCFG_SOUNDALARM = 306;               // 获取音频报警配置失败
        public const int ZLNET_ERROR_GETCFG_STORAGE = 307;                  // 获取存储位置配置失败
        public const int ZLNET_ERROR_GETCFG_MAIL = 308;                     // 获取邮件配置失败
        public const int ZLNET_CONFIG_DEVBUSY = 309;                        // 暂时无法设置
        public const int ZLNET_CONFIG_DATAILLEGAL = 310;                    // 配置数据不合法
        public const int ZLNET_ERROR_GETCFG_DST = 311;                      // 获取夏令时配置失败
        public const int ZLNET_ERROR_SETCFG_DST = 312;                      // 设置夏令时配置失败
        public const int ZLNET_ERROR_GETCFG_VIDEO_OSD = 313;                // 获取视频OSD叠加配置失败
        public const int ZLNET_ERROR_SETCFG_VIDEO_OSD = 314;                // 设置视频OSD叠加配置失败
        public const int ZLNET_ERROR_GETCFG_GPRSCDMA = 315;                 // 获取CDMA\GPRS网络配置失败
        public const int ZLNET_ERROR_SETCFG_GPRSCDMA = 316;                 // 设置CDMA\GPRS网络配置失败
        public const int ZLNET_ERROR_GETCFG_IPFILTER = 317;                 // 获取IP过滤配置失败
        public const int ZLNET_ERROR_SETCFG_IPFILTER = 318;                 // 设置IP过滤配置失败
        public const int ZLNET_ERROR_GETCFG_TALKENCODE = 319;               // 获取语音对讲编码配置失败
        public const int ZLNET_ERROR_SETCFG_TALKENCODE = 320;               // 设置语音对讲编码配置失败
        public const int ZLNET_ERROR_GETCFG_RECORDLEN = 321;                // 获取录像打包长度配置失败
        public const int ZLNET_ERROR_SETCFG_RECORDLEN = 322;                // 设置录像打包长度配置失败
        public const int ZLNET_DONT_SUPPORT_SUBAREA = 323;                  // 不支持网络硬盘分区
        public const int ZLNET_ERROR_GET_AUTOREGSERVER = 324;               // 获取设备上主动注册服务器信息失败
        public const int ZLNET_ERROR_CONTROL_AUTOREGISTER = 325;            // 主动注册重定向注册错误
        public const int ZLNET_ERROR_DISCONNECT_AUTOREGISTER = 326;         // 断开主动注册服务器错误
        public const int ZLNET_ERROR_GETCFG_MMS = 327;                      // 获取mms配置失败
        public const int ZLNET_ERROR_SETCFG_MMS = 328;                      // 设置mms配置失败
        public const int ZLNET_ERROR_GETCFG_SMSACTIVATION = 329;            // 获取短信激活无线连接配置失败
        public const int ZLNET_ERROR_SETCFG_SMSACTIVATION = 330;            // 设置短信激活无线连接配置失败
        public const int ZLNET_ERROR_GETCFG_DIALINACTIVATION = 331;         // 获取拨号激活无线连接配置失败
        public const int ZLNET_ERROR_SETCFG_DIALINACTIVATION = 332;         // 设置拨号激活无线连接配置失败
        public const int ZLNET_ERROR_GETCFG_VIDEOOUT = 333;                 // 查询视频输出参数配置失败
        public const int ZLNET_ERROR_SETCFG_VIDEOOUT = 334;                 // 设置视频输出参数配置失败
        public const int ZLNET_ERROR_GETCFG_OSDENABLE = 335;                // 获取osd叠加使能配置失败
        public const int ZLNET_ERROR_SETCFG_OSDENABLE = 336;                // 设置osd叠加使能配置失败
        public const int ZLNET_ERROR_SETCFG_ENCODERINFO = 337;              // 设置数字通道前端编码接入配置失败
        public const int ZLNET_ERROR_GETCFG_TVADJUST = 338;                 // 获取TV调节配置失败
        public const int ZLNET_ERROR_SETCFG_TVADJUST = 339;                 // 设置TV调节配置失败
        public const int ZLNET_ERROR_CONNECT_FAILED = 340;                  // 请求建立连接失败
        public const int ZLNET_ERROR_SETCFG_BURNFILE = 341;                 // 请求刻录文件上传失败
        public const int ZLNET_ERROR_SNIFFER_GETCFG = 342;                  // 获取抓包配置信息失败
        public const int ZLNET_ERROR_SNIFFER_SETCFG = 343;                  // 设置抓包配置信息失败
        public const int ZLNET_ERROR_DOWNLOADRATE_GETCFG = 344;             // 查询下载限制信息失败
        public const int ZLNET_ERROR_DOWNLOADRATE_SETCFG = 345;             // 设置下载限制信息失败
        public const int ZLNET_ERROR_SEARCH_TRANSCOM = 346;                 // 查询串口参数失败
        public const int ZLNET_ERROR_GETCFG_POINT = 347;                    // 获取预制点信息错误
        public const int ZLNET_ERROR_SETCFG_POINT = 348;                    // 设置预制点信息错误
        public const int ZLNET_SDK_LOGOUT_ERROR = 349;                      // SDK没有正常登出设备
        public const int ZLNET_ERROR_GET_VEHICLE_CFG = 350;                 // 获取车载配置失败
        public const int ZLNET_ERROR_SET_VEHICLE_CFG = 351;                 // 设置车载配置失败
        public const int ZLNET_ERROR_GET_ATM_OVERLAY_CFG = 352;             // 获取atm叠加配置失败
        public const int ZLNET_ERROR_SET_ATM_OVERLAY_CFG = 353;             // 设置atm叠加配置失败
        public const int ZLNET_ERROR_GET_ATM_OVERLAY_ABILITY = 354;         // 获取atm叠加能力失败
        public const int ZLNET_ERROR_GET_DECODER_TOUR_CFG = 355;            // 获取解码器解码轮巡配置失败
        public const int ZLNET_ERROR_SET_DECODER_TOUR_CFG = 356;            // 设置解码器解码轮巡配置失败
        public const int ZLNET_ERROR_CTRL_DECODER_TOUR = 357;               // 控制解码器解码轮巡失败
        public const int ZLNET_GROUP_OVERSUPPORTNUM = 358;                  // 超出设备支持最大用户组数目
        public const int ZLNET_USER_OVERSUPPORTNUM = 359;                   // 超出设备支持最大用户数目
        public const int ZLNET_ERROR_GET_SIP_CFG = 368;                     // 获取SIP配置失败
        public const int ZLNET_ERROR_SET_SIP_CFG = 369;                     // 设置SIP配置失败
        public const int ZLNET_ERROR_GET_SIP_ABILITY = 370;                 // 获取SIP能力失败
        public const int ZLNET_TALK_REJECT = 371;                           // 拒绝对讲
        public const int ZLNET_TALK_BUSY = 372;                             // 资源冲突、不能对讲
        public const int ZLNET_TALK_FORMAT_NOT_SUPPORTED = 373;             // 拒绝对讲，编码格式不支持
        public const int ZLNET_ERROR_UPSUPPORT_WAV = 374;                   // 不支持的WAV文件
        public const int ZLNET_ERROR_CHANGE_FORMAT_WAV = 375;               // 转换WAV采样率失败
        public const int ZLNET_ERROR_PACKFRAME = 376;                       // 打包失败
        public const int ZLNET_ERROR_LATTICE_CFG = 377;                     // 设置点阵配置失败
        public const int ZLNET_ERROR_JSON_BEYOND = 378;                     // JSON包超出最大限制
        public const int ZLNET_ERROR_DEVICE_NOT_SUPPORT = 379;              // 设备不支持此协议
        public const int ZLNET_P2P_CONNECT_ERR = 400;                       // 尚未连接服务器或与已断开
        public const int ZLNET_P2P_CONNECT_MAX = 401;                       // 连接服务器已满
        public const int ZLNET_P2P_OFFLINE = 402;                           // 对方不在线
        public const int ZLNET_PORT_CONFILCT = 403;                         // 端口冲突
        public const int ZLNET_REUSE_OR_PASSWD_ERR = 404;                   // 账号复用或控制密码保存失败
        public const int ZLNET_CONNECT_MAX = 410;                           // 连接数满
        public const int ZLNET_NVR_SEARCHED_DEV_IP_ERR = 411;               // NVR搜索到的设备IP信息获取失败(未提供用户名密码)
        public const int ZLNET_ERROR_NOT_SUPPORT_JSON_F6 = 412;             // 设备不支持f6协议
        public const int ZLNET_ERROR_JSON_ANALYSIS_ERROR = 413;             // JSON解析失败
        public const int ZLNET_ERROR_DATA_ILLEGAL = 414;                    // 数据不合法
        public const int ZLNET_ERROR_TEMPORARILY_UNABLE_TO_SET = 415;       // 暂时无法设置
        public const int ZLNET_ERROR_PLAYBACK_ABILITY = 416;                // 超出通道回放能力

        /************************************************************************
        ** 设备功能项
        ***********************************************************************/
        //主功能项szEn[0]
        public const string ZLNET_FUNC_CHANNEL = "CHANNEL";                 // szEn[0]表示通道相关的能力
        //掩码dwEnMask[0]
        public const int ZLNET_FUNCMASK_CHANNEL_MODE = 0x01;                // dwEnMask[0] 第一位代表通道模式
        public const int ZLNET_FUNCMASK_CHANNEL_COLOR = 0x02;               // dwEnMask[0] 第二位代表通道图像颜色
        public const int ZLNET_FUNCMASK_CHANNEL_PTZ_SIMULATION = 0x04;      // dwEnMask[0] 第三位代表云台模拟控制
        public const int ZLNET_FUNCMASK_CHANNEL_RECORD_BACKUP = 0x08;       // dwEnMask[0] 第四位代表录像备份
        public const int ZLNET_FUNCMASK_CHANNEL_NETPLAY_MUL = 0x10;         // dwEnMask[0] 第五位代表网络回放支持一个通道同时放多个文件

        // 支持用户名最大长度为8位或16位的设备，对应扩展接口ZLNET_QueryUserInfoEx和ZLNET_OperateUserInfoEx
        public const int ZLNET_DEC_MAX_SPLIT_MODE = 64;                     // 
        public const int ZLNET_DEC_MAX_VIDEOLIST = 16;                      //
        public const int ZLNET_DEC_MAX_SPLITNUM = 36;                       //
        public const int N_COLOR_SECTION = 2;
        public const int ZLNET_IPIFILTER_NUM = 200;                         // IP个数
        public const int ZLNET_IVA_AUDIO_UPLOAD_INFO_NUM = 40;
        public const int ZLNET_MAX_CAPTURE_OPTION_ITEM = 32;                // 
        public const int ZLNET_HDMI_ITEM_COUNT = 12;                        // 
        public const int ZLNET_HDMI_FILE_COUNT = 32;                        // 
        public const int ZLNET_CARD_OVERLAY_COUNT = 4;                      // 

        //
        //public const int ZLNET_DEV_USER_END_CFG = 1000;                     //
        public const int MAX_ENC_CHIP_NR = 32;
        public const int ZLNET_CARDNUM_LEN = 20;                            // 录像文件卡号长度
        public const int ZLNET_P2P_DEVICE_ID_LEN = 32;                      // 
        public const int ZLNET_P2P_PASSWORD_LEN = 7;                        // 
        public const int ZLNET_NAME_MAX_LEN = 16;
        public const int ZLNET_DECODER_OUT_SLOTS_MAX_NUM = 16;
        public const int ZLNET_DECODER_IN_SLOTS_MAX_NUM = 16;
        public const int ALARM_MAX_NAME = 64;
        public const int ZLNET_ATM_MAX_TRADE_TYPE_NAME = 64;
        public const int ZLNET_ATM_MAX_TRADE_NUM = 1024;
        public const int ZLNET_MAX_ALARM_DECODER_NUM = 16;
        public const int ZLNET_MAX_BACKUPDEV_NUM = 16;
        public const int ZLNET_MAX_BACKUP_NAME = 32;
        public const int ZLNET_MAX_BACKUPRECORD_NUM = 1024;


        /************************************************************************
        ** 枚举定义
        ***********************************************************************/
        // 设备类型
        public enum ZLNET_DEVICE_TYPE
        {
            ZLNET_NULL = 0,
            ZLNET_IPC_NEW = 51,//新IPC
            ZLNET_DVR = 100,
            ZLNET_DVR_6004,
            ZLNET_DVR_6008,
            ZLNET_DVR_6016,
            ZLNET_DVR_7004 = 110,
            ZLNET_DVR_7008,
            ZLNET_DVR_7008E,
            ZLNET_DVR_7016,
            ZLNET_DVR_7016E,
            ZLNET_DVR_7016H,
            ZLNET_DVR_7032,
            ZLNET_DVR_7024,
            ZLNET_DVR_7016N,
            ZLNET_DVR_7008N,
            ZLNET_DVR_8004 = 120,
            ZLNET_DVR_8008,
            ZLNET_DVR_8016,
            ZLNET_DVR_8016E,
            ZLNET_DVR_9016 = 130,
            ZLNET_DVR_9008,
            ZLNET_DVR_9016N,

            ZLNET_IPC_Int = 140,
            ZLNET_IVA_PLATEID,			//智能车牌
            ZLNET_IVA_STAFFCOUNT,		//智能人数统计
            ZLNET_IVA_BZS,				//智能周界
            ZLNET_IVA_ATM = 150,		//智能ATM
            ZLNET_IVA_SSB,				//智能SSB
            ZLNET_IVA_FACE,				//智能人脸
            ZLNET_IVA_ATM_SSB,			//智能ATM自助银行混合型
            ZLNET_IVA_G6,			    //G6银行混合型

            ZLNET_NVD = 160,			//解码器

            ZLNET_IPC = 180,
            ZLNET_IPC_3507_SD,			//3507标清
            ZLNET_IPC_3507_720p,		//3507 720p
            ZLNET_IPC_3507_VGA,			//3507VGA
            ZLNET_IPC_3516_720p = 188,	//3516 720p
            ZLNET_IPC_3516_1080p,		//3516 1080p
            ZLNET_IPC_3518C_720p,		//3518 720p
            ZLNET_IPC_201E_60,		    //3516 60帧
            ZLNET_IPC_3518A_720p,		//3518A 720p
            ZLNET_IPC_3516_SD,		    //3516标清
            ZLNET_IPC_3518C_SVGA,		//3518VGA

            ZLNET_DVR_D7004E = 200,
            ZLNET_DVR_D7008E,
            ZLNET_DVR_D7016E,
            ZLNET_DVR_D7004,
            ZLNET_DVR_D7008,
            ZLNET_DVR_D7016,
            ZLNET_DVR_D8004,
            ZLNET_DVR_D8008,
            ZLNET_DVR_D8016,
            ZLNET_DVR_D8308,
            ZLNET_DVR_D8316,
            ZLNET_DVR_D8324,
            ZLNET_DVR_D8332,
            ZLNET_DVR_D8408,
            ZLNET_DVR_D8416,
            ZLNET_DVR_D8424,
            ZLNET_DVR_D8816,

            ZLNET_DVR_NEW = 230,
            ZLNET_DVR_7004N,
            ZLNET_DVR_7116E,
            ZLNET_DVR_9104,
            ZLNET_DVR_7116,
            ZLNET_DVR_7108E,
            ZLNET_DVR_6116,
            ZLNET_DVR_7116EW,
            ZLNET_DVR_6104,
            ZLNET_DVR_6108,
            ZLNET_DVR_7116L,
            ZLNET_DVR_7108L,
            ZLNET_DVR_7104E,
            ZLNET_DVR_7116EN,
            ZLNET_NVR_832,
            ZLNET_NVR_208P,
            ZLNET_NVR_208,
            ZLNET_NVR_216,
            ZLNET_NVR_232,
            ZLNET_DVR_7104EN,
            ZLNET_DVR_7108EN,
            ZLNET_DVR_9008EN,
            ZLNET_DVR_9016EN,

            //由于协议问题，下面超过255的实际已经收不到了
            ZLNET_NVR_204,
            ZLNET_NVR_204P,
            ZLNET_NVR_208ES,
            ZLNET_NVR_204F,
            ZLNET_NVR_204FP,
            ZLNET_NVR_204SF,
            ZLNET_NVR_208F,
            ZLNET_NVR_216P,
            ZLNET_NVR_216F,
            ZLNET_DVR_9016E,
            ZLNET_DVR_9008E,

            ZLNET_DVR_6104_20D_V1,
            ZLNET_DVR_6104L_15A_V1,
            ZLNET_DVR_6108_20D_V1,
            ZLNET_DVR_6104_20D_V3,
            ZLNET_DVR_6104L_15A_V3,
            ZLNET_DVR_6108_20D_V3,
            ZLNET_DVR_6104S_20D_V5,
            ZLNET_DVR_6104S_15A_V5,
            ZLNET_DVR_6108S_20D_V5,
            ZLNET_DVR_6108SL_20D_V5,

            ZLNET_DVR_8328N,
            ZLNET_NVR_2104L,
            ZLNET_NVR_2108L,
            ZLNET_NVR_2204,
            ZLNET_NVR_2208,
            ZLNET_TVR_6104L_V01,
            ZLNET_TVR_6108L,
            ZLNET_TVR_6116L,

            ZLNET_UNKNOWN = 255,
        };

        // 语言种类
        public enum ZLNET_LANGUAGE_TYPE
        {
            ZLNET_LANGUAGE_ENGLISH,							// 英文
            ZLNET_LANGUAGE_CHINESE_SIMPLIFIED,				// 简体中文
            ZLNET_LANGUAGE_CHINESE_TRADITIONAL,				// 繁体中文
            ZLNET_LANGUAGE_ITALIAN,							// 意大利文
            ZLNET_LANGUAGE_SPANISH,							// 西班牙文
            ZLNET_LANGUAGE_JAPANESE,						// 日文版
            ZLNET_LANGUAGE_RUSSIAN,							// 俄文版
            ZLNET_LANGUAGE_FRENCH,							// 法文版
            ZLNET_LANGUAGE_GERMAN, 							// 德文版
            ZLNET_LANGUAGE_PORTUGUESE,						// 葡萄牙语
            ZLNET_LANGUAGE_TURKEY,							// 土尔其语
            ZLNET_LANGUAGE_POLISH,							// 波兰语
            ZLNET_LANGUAGE_ROMANIAN,						// 罗马尼亚
            ZLNET_LANGUAGE_HUNGARIAN,						// 匈牙利语
            ZLNET_LANGUAGE_FINNISH,							// 芬兰语
            ZLNET_LANGUAGE_ESTONIAN,						// 爱沙尼亚语
            ZLNET_LANGUAGE_KOREAN,							// 韩语
            ZLNET_LANGUAGE_FARSI,							// 波斯语
            ZLNET_LANGUAGE_DANSK,							// 丹麦语
            ZLNET_LANGUAGE_CZECHISH,						// 捷克文
            ZLNET_LANGUAGE_BULGARIA,						// 保加利亚文
            ZLNET_LANGUAGE_SLOVAKIAN,						// 斯洛伐克语
            ZLNET_LANGUAGE_SLOVENIA,						// 斯洛文尼亚文
            ZLNET_LANGUAGE_CROATIAN,						// 克罗地亚语
            ZLNET_LANGUAGE_DUTCH,							// 荷兰语
            ZLNET_LANGUAGE_GREEK,							// 希腊语
            ZLNET_LANGUAGE_UKRAINIAN,						// 乌克兰语
            ZLNET_LANGUAGE_SWEDISH,							// 瑞典语
            ZLNET_LANGUAGE_SERBIAN,							// 塞尔维亚语
            ZLNET_LANGUAGE_VIETNAMESE,						// 越南语
            ZLNET_LANGUAGE_LITHUANIAN,						// 立陶宛语
            ZLNET_LANGUAGE_FILIPINO,						// 菲律宾语
            ZLNET_LANGUAGE_ARABIC,							// 阿拉伯语
            ZLNET_LANGUAGE_CATALAN,							// 加泰罗尼亚语
            ZLNET_LANGUAGE_LATVIAN,							// 拉脱维亚语
            ZLNET_LANGUAGE_THAI,							// 泰语
            ZLNET_LANGUAGE_HEBREW,							// 希伯来语
            ZLNET_LANGUAGE_Bosnian,							// 波斯尼亚文
        };

        // 升级类型
        public enum ZLNET_UPGRADE_TYPE
        {
            ZLNET_UPGRADE_BIOS_TYPE = 1,					// BIOS升级
            ZLNET_UPGRADE_WEB_TYPE,							// WEB升级
            ZLNET_UPGRADE_BOOT_YPE,							// BOOT升级
            ZLNET_UPGRADE_CHARACTER_TYPE,					// 汉字库
            ZLNET_UPGRADE_LOGO_TYPE,						// LOGO
            ZLNET_UPGRADE_EXE_TYPE,							// EXE，例如播放器等
        };

        // 录象类型(定时、动态检测、报警)
        public enum ZLNET_REC_TYPE
        {
            ZLNET_REC_TYPE_TIM = 0,
            ZLNET_REC_TYPE_MTD,
            ZLNET_REC_TYPE_ALM,
            ZLNET_REC_TYPE_NUM,
        };

        // 网络类型
        public enum ZLNET_GPRSCDMA_NETWORK_TYPE
        {
            ZLNET_TYPE_AUTOSEL = 0,							// 自动选择
            ZLNET_TYPE_TD_SCDMA,							// TD-SCDMA网络
            ZLNET_TYPE_WCDMA,								// WCDMA网络
            ZLNET_TYPE_CDMA_1x,								// CDMA 1.x网络
            ZLNET_TYPE_EDGE,								// GPRS网络
            ZLNET_TYPE_EVDO,								// EVDO网络
            ZLNET_TYPE_WIFI,								// 无线
        };

        // 接口类型，对应ZLNET_SetSubconnCallBack接口
        public enum ZLNET_INTERFACE_TYPE
        {
            ZLNET_INTERFACE_OTHER = 0x00000000,				// 未知接口
            ZLNET_INTERFACE_REALPLAY,						// 实时监视接口
            ZLNET_INTERFACE_PREVIEW,						// 多画面预览接口
            ZLNET_INTERFACE_PLAYBACK,						// 回放接口
            ZLNET_INTERFACE_DOWNLOAD,						// 下载接口
        };

        /////////////////////////////////监视相关/////////////////////////////////

        // 预览类型，对应ZLNET_RealPlayEx接口
        public enum ZLNET_REALPLAYTYPE
        {
            ZLNET_RType_Realplay = 0,		// 实时预览
            ZLNET_RType_Multiplay,			// 多画面预览 - 全通道

            ZLNET_RType_Realplay_0,			// 实时监视-主码流，等同于ZLNET_RType_Realplay
            ZLNET_RType_Realplay_1,			// 实时监视-从码流1
            ZLNET_RType_Realplay_2,			// 实时监视-从码流2
            ZLNET_RType_Realplay_3,			// 实时监视-从码流3

            ZLNET_RType_Multiplay_1,		// 多画面预览－1画面
            ZLNET_RType_Multiplay_4,		// 多画面预览－4画面
            ZLNET_RType_Multiplay_8,		// 多画面预览－8画面
            ZLNET_RType_Multiplay_9,		// 多画面预览－9画面
            ZLNET_RType_Multiplay_16,		// 多画面预览－16画面
            ZLNET_RType_Multiplay_6,		// 多画面预览－6画面
            ZLNET_RType_Multiplay_12,		// 多画面预览－12画面
            ZLNET_RType_Multiplay_0,
            ZLNET_RType_Multiplay_32,		// 多画面预览 - 32画面
        };

        /////////////////////////////////云台相关/////////////////////////////////

        // 通用云台控制命令
        public enum ZLNET_PTZ_ControlType
        {
            ZLNET_PTZ_UP_CONTROL = 0,						// 上
            ZLNET_PTZ_DOWN_CONTROL,							// 下
            ZLNET_PTZ_LEFT_CONTROL,							// 左
            ZLNET_PTZ_RIGHT_CONTROL,						// 右
            ZLNET_PTZ_ZOOM_ADD_CONTROL,						// 变倍+
            ZLNET_PTZ_ZOOM_DEC_CONTROL,						// 变倍-
            ZLNET_PTZ_FOCUS_ADD_CONTROL,					// 调焦+
            ZLNET_PTZ_FOCUS_DEC_CONTROL,					// 调焦-
            ZLNET_PTZ_APERTURE_ADD_CONTROL,					// 光圈+
            ZLNET_PTZ_APERTURE_DEC_CONTROL,					// 光圈-
            ZLNET_PTZ_POINT_MOVE_CONTROL,					// 转至预置点
            ZLNET_PTZ_POINT_SET_CONTROL,					// 设置
            ZLNET_PTZ_POINT_DEL_CONTROL,					// 删除
            ZLNET_PTZ_POINT_LOOP_CONTROL,					// 点间巡航
            ZLNET_PTZ_LAMP_CONTROL,							// 灯光
        };

        // 云台控制扩展命令
        public enum ZLNET_EXTPTZ_ControlType
        {
            ZLNET_EXTPTZ_CAMOPER = 0x13,					// 镜头设置 param2（1-镜头重置 2-自动聚焦）
            ZLNET_EXTPTZ_LEFTTOP = 0x20,					// 左上
            ZLNET_EXTPTZ_RIGHTTOP,							// 右上
            ZLNET_EXTPTZ_LEFTDOWN,							// 左下
            ZLNET_EXTPTZ_RIGHTDOWN,							// 右下
            ZLNET_EXTPTZ_ADDTOLOOP,							// 加入预置点到巡航 巡航线路 预置点值
            ZLNET_EXTPTZ_DELFROMLOOP,						// 删除巡航中预置点 巡航线路 预置点值
            ZLNET_EXTPTZ_CLOSELOOP,							// 清除巡航 巡航线路
            ZLNET_EXTPTZ_STARTPANCRUISE,					// 开始水平旋转
            ZLNET_EXTPTZ_STOPPANCRUISE,						// 停止水平旋转
            ZLNET_EXTPTZ_SETLEFTBORDER,						// 设置左边界
            ZLNET_EXTPTZ_SETRIGHTBORDER,					// 设置右边界
            ZLNET_EXTPTZ_STARTLINESCAN,						// 开始线扫
            ZLNET_EXTPTZ_CLOSELINESCAN,						// 停止线扫
            ZLNET_EXTPTZ_SETMODESTART,						// 设置模式开始	模式线路
            ZLNET_EXTPTZ_SETMODESTOP,						// 设置模式结束	模式线路
            ZLNET_EXTPTZ_RUNMODE,							// 运行模式	模式线路
            ZLNET_EXTPTZ_STOPMODE,							// 停止模式	模式线路
            ZLNET_EXTPTZ_DELETEMODE,						// 清除模式	模式线路
            ZLNET_EXTPTZ_REVERSECOMM,						// 翻转命令
            ZLNET_EXTPTZ_FASTGOTO,							// 快速定位 水平坐标(8192) 垂直坐标(8192) 变倍(4)
            ZLNET_EXTPTZ_AUXIOPEN,							// 辅助开关开 辅助点
            ZLNET_EXTPTZ_AUXICLOSE,							// 辅助开关关 辅助点
            ZLNET_EXTPTZ_OPENMENU = 0x36,					// 打开球机菜单
            ZLNET_EXTPTZ_CLOSEMENU,							// 关闭菜单
            ZLNET_EXTPTZ_MENUOK,							// 菜单确定
            ZLNET_EXTPTZ_MENUCANCEL,						// 菜单取消
            ZLNET_EXTPTZ_MENUUP,							// 菜单上
            ZLNET_EXTPTZ_MENUDOWN,							// 菜单下
            ZLNET_EXTPTZ_MENULEFT,							// 菜单左
            ZLNET_EXTPTZ_MENURIGHT,							// 菜单右
            ZLNET_EXTPTZ_ALARMHANDLE = 0x40,				// 报警联动云台 parm1：报警输入通道；parm2：报警联动类型1-预置点2-线扫3-巡航；parm3：联动值，如预置点号
            ZLNET_EXTPTZ_MATRIXSWITCH = 0x41,				// 矩阵切换 parm1：监视器号(视频输出号)；parm2：视频输入号；parm3：矩阵号
            ZLNET_EXTPTZ_LIGHTCONTROL,						// 灯光控制器
            ZLNET_EXPTZ_INFRAED_FUN,						// 红外功能控制
            ZLNET_PTZ_WIPERS_CONTROL,						// 雨刷
            ZLNET_EXTPTZ_UP_TELE = 0x70,					// 上 + TELE param1=速度(1-8)，下同
            ZLNET_EXTPTZ_DOWN_TELE,							// 下 + TELE
            ZLNET_EXTPTZ_LEFT_TELE,							// 左 + TELE
            ZLNET_EXTPTZ_RIGHT_TELE,						// 右 + TELE
            ZLNET_EXTPTZ_LEFTUP_TELE,						// 左上 + TELE
            ZLNET_EXTPTZ_LEFTDOWN_TELE,						// 左下 + TELE
            ZLNET_EXTPTZ_TIGHTUP_TELE,						// 右上 + TELE
            ZLNET_EXTPTZ_RIGHTDOWN_TELE,					// 右下 + TELE
            ZLNET_EXTPTZ_UP_WIDE,							// 上 + WIDE param1=速度(1-8)，下同
            ZLNET_EXTPTZ_DOWN_WIDE,							// 下 + WIDE
            ZLNET_EXTPTZ_LEFT_WIDE,							// 左 + WIDE
            ZLNET_EXTPTZ_RIGHT_WIDE,						// 右 + WIDE
            ZLNET_EXTPTZ_LEFTUP_WIDE,						// 左上 + WIDE
            ZLNET_EXTPTZ_LEFTDOWN_WIDE,						// 左下 + WIDE
            ZLNET_EXTPTZ_TIGHTUP_WIDE,						// 右上 + WIDE
            ZLNET_EXTPTZ_RIGHTDOWN_WIDE,					// 右下 + WIDE
            ZLNET_EXTPTZ_TOTAL,								// 最大命令值
        };

        public enum ZLNET_EXTPTZ_CONTROLTYPE_IFRARED
        {
            ZLNET_EXTPTZ_IFRARED_MODE = 0x77,
            ZLNET_EXTPTZ_IFRARED_SENSITIVITY = 0x7B,
            ZLNET_EXTPTZ_IFRARED_FUNC = 0x7D,
        };

        /////////////////////////////////日志相关/////////////////////////////////

        // 日志查询类型
        public enum ZLNET_LOG_QUERY_TYPE
        {
            ZLNET_LOG_QUY_ALL = 0,								// 所有日志
            ZLNET_LOG_QUY_SYSTEM,								// 系统日志
            ZLNET_LOG_QUY_CONFIG,								// 配置日志
            ZLNET_LOG_QUY_STORAGE,								// 存储相关
            ZLNET_LOG_QUY_ALARM,								// 报警日志
            ZLNET_LOG_QUY_RECORD,								// 录象相关
            ZLNET_LOG_QUY_ACCOUNT,								// 帐号相关
            ZLNET_LOG_QUY_CLEAR,								// 清除日志
            ZLNET_LOG_QUY_PLAYBACK								// 回放相关
        };

        // 日志类型
        public enum ZL_LOG_TYPE
        {
            ZLNET_LOG_REBOOT = 0x0000,						// 设备重启
            ZLNET_LOG_SHUT,									// 设备关机
            ZLNET_LOG_UPGRADE = 0x0004,						// 设备升级
            ZLNET_LOG_CONFSAVE = 0x0100,					// 保存配置
            ZLNET_LOG_CONFLOAD,								// 读取配置
            ZLNET_LOG_FSERROR = 0x0200,						// 文件系统错误
            ZLNET_LOG_HDD_WERR,								// 硬盘写错误
            ZLNET_LOG_HDD_RERR,								// 硬盘读错误
            ZLNET_LOG_HDD_TYPE,								// 设置硬盘类型
            ZLNET_LOG_HDD_FORMAT,							// 格式化硬盘
            ZLNET_LOG_HDD_NOSPACE,							// 当前工作盘空间不足
            ZLNET_LOG_HDD_TYPE_RW,							// 设置硬盘类型为读写盘
            ZLNET_LOG_HDD_TYPE_RO,							// 设置硬盘类型为只读盘
            ZLNET_LOG_HDD_TYPE_RE,							// 设置硬盘类型为冗余盘
            ZLNET_LOG_HDD_TYPE_SS,							// 设置硬盘类型为快照盘
            ZLNET_LOG_HDD_NONE,								// 无硬盘记录
            ZLNET_LOG_HDD_NOWORKHDD,						// 无工作盘(没有读写盘)
            ZLNET_LOG_HDD_TYPE_BK,							// 设置硬盘类型为备份盘
            ZLNET_LOG_HDD_TYPE_REVERSE,						// 设置硬盘类型为保留分区
            ZLNET_LOG_ALM_IN = 0x0300,						// 外部输入报警开始
            ZLNET_LOG_NETALM_IN,							// 网络报警输入
            ZLNET_LOG_ALM_END = 0x0302,						// 外部输入报警停止
            ZLNET_LOG_LOSS_IN,								// 视频丢失报警开始
            ZLNET_LOG_LOSS_END,								// 视频丢失报警结束
            ZLNET_LOG_MOTION_IN,							// 动态检测报警开始
            ZLNET_LOG_MOTION_END,							// 动态检测报警结束
            ZLNET_LOG_ALM_BOSHI,							// 报警器报警输入
            ZLNET_LOG_NET_ABORT = 0x0308,					// 网络断开
            ZLNET_LOG_NET_ABORT_RESUME,						// 网络恢复
            ZLNET_LOG_CODER_BREAKDOWN,						// 编码器故障
            ZLNET_LOG_CODER_BREAKDOWN_RESUME,				// 编码器故障恢复
            ZLNET_LOG_BLIND_IN,								// 视频遮挡
            ZLNET_LOG_BLIND_END,							// 视频遮挡恢复
            ZLNET_LOG_ALM_TEMP_HIGH,						// 温度过高
            ZLNET_LOG_ALM_VOLTAGE_LOW,						// 电压过低
            ZLNET_LOG_ALM_BATTERY_LOW,						// 电池容量不足
            ZLNET_LOG_ALM_ACC_BREAK,						// ACC断电
            ZLNET_LOG_INFRAREDALM_IN = 0x03a0,				// 无线报警开始
            ZLNET_LOG_INFRAREDALM_END,						// 无线报警结束
            ZLNET_LOG_IPCONFLICT,							// IP冲突
            ZLNET_LOG_IPCONFLICT_RESUME,					// IP恢复
            ZLNET_LOG_SDPLUG_IN,							// SD卡插入
            ZLNET_LOG_SDPLUG_OUT,							// SD卡拔出
            ZLNET_LOG_NET_PORT_BIND_FAILED,					// 网络端口绑定失败
            ZLNET_LOG_AUTOMATIC_RECORD = 0x0400,			// 自动录像
            ZLNET_LOG_MANUAL_RECORD = 0x0401,				// 手动录象
            ZLNET_LOG_CLOSED_RECORD,						// 停止录象
            ZLNET_LOG_LOGIN = 0x0500,						// 登录
            ZLNET_LOG_LOGOUT,								// 注销
            ZLNET_LOG_ADD_USER,								// 添加用户
            ZLNET_LOG_DELETE_USER,							// 删除用户
            ZLNET_LOG_MODIFY_USER,							// 修改用户
            ZLNET_LOG_ADD_GROUP,							// 添加用户组
            ZLNET_LOG_DELETE_GROUP,							// 删除用户组
            ZLNET_LOG_MODIFY_GROUP,							// 修改用户组
            ZLNET_LOG_NET_LOGIN = 0x0508,					// 网络用户登录
            ZLNET_LOG_CLEAR = 0x0600,						// 清除日志
            ZLNET_LOG_SEARCHLOG,							// 查询日志
            ZLNET_LOG_SEARCH = 0x0700,						// 录像查询
            ZLNET_LOG_DOWNLOAD,								// 录像下载
            ZLNET_LOG_PLAYBACK,								// 录像回放
            ZLNET_LOG_BACKUP,								// 备份录像文件
            ZLNET_LOG_BACKUPERROR,							// 备份录像文件失败

            ZLNET_LOG_TYPE_NR = 8,
        };

        // 扩展日志类型，对应ZLNET_QueryLogEx接口，条件(int nType = 1；参数reserved = &nType)
        public enum ZLNET_NEWLOG_TYPE
        {
            ZLNET_NEWLOG_REBOOT = 0x0000,					// 设备重启
            ZLNET_NEWLOG_SHUT,								// 设备关机
            ZLNET_NEWLOG_UPGRADE = 0x0004,					// 设备升级
            ZLNET_NEWLOG_CONFSAVE = 0x0100,					// 保存配置
            ZLNET_NEWLOG_CONFLOAD,							// 读取配置
            ZLNET_NEWLOG_FSERROR = 0x0200,					// 文件系统错误
            ZLNET_NEWLOG_HDD_WERR,							// 硬盘写错误
            ZLNET_NEWLOG_HDD_RERR,							// 硬盘读错误
            ZLNET_NEWLOG_HDD_TYPE,							// 设置硬盘类型
            ZLNET_NEWLOG_HDD_FORMAT,						// 格式化硬盘
            ZLNET_NEWLOG_HDD_NOSPACE,						// 当前工作盘空间不足
            ZLNET_NEWLOG_HDD_TYPE_RW,						// 设置硬盘类型为读写盘
            ZLNET_NEWLOG_HDD_TYPE_RO,						// 设置硬盘类型为只读盘
            ZLNET_NEWLOG_HDD_TYPE_RE,						// 设置硬盘类型为冗余盘
            ZLNET_NEWLOG_HDD_TYPE_SS,						// 设置硬盘类型为快照盘
            ZLNET_NEWLOG_HDD_NONE,							// 无硬盘记录日志
            ZLNET_NEWLOG_HDD_NOWORKHDD,						// 无工作盘(没有读写盘)
            ZLNET_NEWLOG_HDD_TYPE_BK,						// 设置硬盘类型为备份盘
            ZLNET_NEWLOG_HDD_TYPE_REVERSE,					// 设置硬盘类型为保留分区
            ZLNET_NEWLOG_ALM_IN = 0x0300,					// 外部输入报警开始
            ZLNET_NEWLOG_NETALM_IN,							// 网络报警
            ZLNET_NEWLOG_ALM_END = 0x0302,					// 外部输入报警停止
            ZLNET_NEWLOG_LOSS_IN,							// 视频丢失报警开始
            ZLNET_NEWLOG_LOSS_END,							// 视频丢失报警结束
            ZLNET_NEWLOG_MOTION_IN,							// 动态检测报警开始
            ZLNET_NEWLOG_MOTION_END,						// 动态检测报警结束
            ZLNET_NEWLOG_ALM_BOSHI,							// 报警器报警输入
            ZLNET_NEWLOG_NET_ABORT = 0x0308,				// 网络断开
            ZLNET_NEWLOG_NET_ABORT_RESUME,					// 网络恢复
            ZLNET_NEWLOG_CODER_BREAKDOWN,					// 编码器故障
            ZLNET_NEWLOG_CODER_BREAKDOWN_RESUME,			// 编码器故障恢复
            ZLNET_NEWLOG_BLIND_IN,							// 视频遮挡
            ZLNET_NEWLOG_BLIND_END,							// 视频遮挡恢复
            ZLNET_NEWLOG_ALM_TEMP_HIGH,						// 温度过高
            ZLNET_NEWLOG_ALM_VOLTAGE_LOW,					// 电压过低
            ZLNET_NEWLOG_ALM_BATTERY_LOW,					// 电池容量不足
            ZLNET_NEWLOG_ALM_ACC_BREAK,						// ACC断电
            ZLNET_NEWLOG_LOG_DEFINED = 0x312,				// 布防
            ZLNET_NEWLOG_LOG_HOMEDEFINED,					// 留守布防
            ZLNET_NEWLOG_LOG_UNDEFINED,						// 撤防
            ZLNET_NEWLOG_LOG_NORMAL_ALARM,					// 一般报警
            ZLNET_NEWLOG_LOG_EMERGENCY_ALARM,				// 紧急报警
            ZLNET_NEWLOG_INFRAREDALM_IN = 0x03a0,			// 无线报警开始
            ZLNET_NEWLOG_INFRAREDALM_END,					// 无线报警结束
            ZLNET_NEWLOG_IPCONFLICT,						// IP冲突
            ZLNET_NEWLOG_IPCONFLICT_RESUME,					// IP恢复
            ZLNET_NEWLOG_SDPLUG_IN,							// SD卡插入
            ZLNET_NEWLOG_SDPLUG_OUT,						// SD卡拔出
            ZLNET_NEWLOG_NET_PORT_BIND_FAILED,				// 网络端口绑定失败
            ZLNET_NEWLOG_AUTOMATIC_RECORD = 0x0400,			// 自动录象
            ZLNET_NEWLOG_MANUAL_RECORD,						// 手动录象开
            ZLNET_NEWLOG_CLOSED_RECORD,						// 停止录象
            ZLNET_NEWLOG_LOGIN = 0x0500,					// 登录
            ZLNET_NEWLOG_LOGOUT,							// 注销
            ZLNET_NEWLOG_ADD_USER,							// 添加用户
            ZLNET_NEWLOG_DELETE_USER,						// 删除用户
            ZLNET_NEWLOG_MODIFY_USER,						// 修改用户
            ZLNET_NEWLOG_ADD_GROUP,							// 添加用户组
            ZLNET_NEWLOG_DELETE_GROUP,						// 删除用户组
            ZLNET_NEWLOG_MODIFY_GROUP,						// 修改用户组
            ZLNET_NEWLOG_NET_LOGIN = 0x0508,				// 网络用户登录
            ZLNET_NEWLOG_CLEAR = 0x0600,					// 清除日志
            ZLNET_NEWLOG_SEARCHLOG,							// 查询日志
            ZLNET_NEWLOG_SEARCH = 0x0700,					// 录像查询
            ZLNET_NEWLOG_DOWNLOAD,							// 录像下载
            ZLNET_NEWLOG_PLAYBACK,							// 录像回放
            ZLNET_NEWLOG_BACKUP,							// 备份录像文件
            ZLNET_NEWLOG_BACKUPERROR,						// 备份录像文件失败

            ZLNET_LOG_MODIFIED_TIME = 0x0800,				// 修改时间
            ZLNET_LOG_MODIFY_ENCODE_MODE,					// 修改编码模式
            ZLNET_LOG_ADVANCEDALO,							// 报警输出
            ZLNET_LOG_FORMAT_BACKUP_DEVICE,					// 格式化备份设备
            ZLNET_LOG_STOP_BACKUP,							// 停止备份
            ZLNET_LOG_MODIFY_IPINFO,						// 修改IP信息
            ZLNET_LOG_MODIFY_PPPOE,							// 修改pppoe配置
            ZLNET_LOG_MODIFY_DDNS,							// 修改DDNS配置
            ZLNET_LOG_MODIFY_3G,							// 修改3G配置  LOG_SEND_ALARM_FAIL

            ZLNET_LOG_SEND_ALARM_FAIL = 0x0900,				// 云存储上传文件失败
            ZLNET_LOG_SEND_VIDEO_FAIL,
            ZLNET_LOG_SEND_CLOUD_STORAGE,					// 上传云存储文件
            ZLNET_LOG_SEND_CS_SUCCESS,						// 云存储上传成功
            ZLNET_LOG_SEND_CS_STOP,							// 云存储录像停止上传

            ZLNET_NEWLOG_TYPE_NR = 8,
        };

        ///////////////////////////////语音对讲相关///////////////////////////////

        // 语音编码类型
        public enum ZLNET_TALK_CODING_TYPE
        {
            ZLNET_TALK_DEFAULT = 0,							// 无头PCM
            ZLNET_TALK_PCM,									// 带头PCM
            ZLNET_TALK_G711a,								// G711a
            ZLNET_TALK_AMR,									// AMR
            ZLNET_TALK_G711u,								// G711u
            ZLNET_TALK_G726,								// G726 MS-MEDIA标准
            ZLNET_TALK_G723_53,								// G723_53
            ZLNET_TALK_G723_63,								// G723_63
            ZLNET_TALK_AAC,									// AAC
            ZLNET_TALK_OGG,									// OGG
            ZLNET_TALK_G726_STD,                            // G726 RFC标准
        };

        // 对讲方式
        public enum ZLNET_USEDEV_MODE
        {
            ZLNET_TALK_CLIENT_MODE,							// 设置客户端方式进行语音对讲
            ZLNET_TALK_SERVER_MODE,							// 设置服务器方式进行语音对讲
            ZLNET_TALK_ENCODE_TYPE,							// 设置语音对讲编码格式
            ZLNET_ALARM_LISTEN_MODE,						// 设置报警订阅方式
            ZLNET_CONFIG_AUTHORITY_MODE,					// 设置通过权限进行配置管理
        };

        // AMR编码类型
        public enum ZLNET_ARM_ENCODE_MODE
        {
            ZLNET_TALK_AMR_AMR475 = 1,						// AMR475编码
            ZLNET_TALK_AMR_AMR515,							// AMR515编码
            ZLNET_TALK_AMR_AMR59,							// AMR59编码
            ZLNET_TALK_AMR_AMR67,							// AMR67编码
            ZLNET_TALK_AMR_AMR74,							// AMR74编码
            ZLNET_TALK_AMR_AMR795,							// AMR795编码
            ZLNET_TALK_AMR_AMR102,							// AMR102编码
            ZLNET_TALK_AMR_AMR122,							// AMR122编码
        };

        /////////////////////////////////控制相关/////////////////////////////////

        // 控制类型，对应ZLNET_ControlDevice接口
        public enum ZLNET_CtrlType
        {
            ZLNET_CTRL_REBOOT = 0,							// 重启设备
            ZLNET_CTRL_SHUTDOWN,							// 关闭设备
            ZLNET_CTRL_DISK,								// 硬盘管理
            ZLNET_KEYBOARD_POWER = 3,						// 网络键盘
            ZLNET_KEYBOARD_ENTER,
            ZLNET_KEYBOARD_ESC,
            ZLNET_KEYBOARD_UP,
            ZLNET_KEYBOARD_DOWN,
            ZLNET_KEYBOARD_LEFT,
            ZLNET_KEYBOARD_RIGHT,
            ZLNET_KEYBOARD_BTN0,
            ZLNET_KEYBOARD_BTN1,
            ZLNET_KEYBOARD_BTN2,
            ZLNET_KEYBOARD_BTN3,
            ZLNET_KEYBOARD_BTN4,
            ZLNET_KEYBOARD_BTN5,
            ZLNET_KEYBOARD_BTN6,
            ZLNET_KEYBOARD_BTN7,
            ZLNET_KEYBOARD_BTN8,
            ZLNET_KEYBOARD_BTN9,
            ZLNET_KEYBOARD_BTN10,
            ZLNET_KEYBOARD_BTN11,
            ZLNET_KEYBOARD_BTN12,
            ZLNET_KEYBOARD_BTN13,
            ZLNET_KEYBOARD_BTN14,
            ZLNET_KEYBOARD_BTN15,
            ZLNET_KEYBOARD_BTN16,
            ZLNET_KEYBOARD_SPLIT,
            ZLNET_KEYBOARD_ONE,
            ZLNET_KEYBOARD_NINE,
            ZLNET_KEYBOARD_ADDR,
            ZLNET_KEYBOARD_INFO,
            ZLNET_KEYBOARD_REC,
            ZLNET_KEYBOARD_FN1,
            ZLNET_KEYBOARD_FN2,
            ZLNET_KEYBOARD_PLAY,
            ZLNET_KEYBOARD_STOP,
            ZLNET_KEYBOARD_SLOW,
            ZLNET_KEYBOARD_FAST,
            ZLNET_KEYBOARD_PREW,
            ZLNET_KEYBOARD_NEXT,
            ZLNET_KEYBOARD_JMPDOWN,
            ZLNET_KEYBOARD_JMPUP,
            ZLNET_TRIGGER_ALARM_IN = 100,					// 触发报警输入,实际是触发设备的网络报警，目前废弃
            ZLNET_TRIGGER_ALARM_OUT,						// 触发报警输出
            ZLNET_CTRL_MATRIX,								// 矩阵控制
            ZLNET_CTRL_SDCARD,								// SD卡控制(IPC产品)参数同硬盘控制
            ZLNET_BURNING_START,							// 刻录机控制，开始刻录
            ZLNET_BURNING_STOP,								// 刻录机控制，结束刻录
            ZLNET_BURNING_ADDPWD,							// 刻录机控制，叠加密码(以'\0'为结尾的字符串，最大长度8位)
            ZLNET_BURNING_ADDHEAD,							// 刻录机控制，叠加片头(以'\0'为结尾的字符串，最大长度1024字节，支持分行，行分隔符'\n')
            ZLNET_BURNING_ADDSIGN,							// 刻录机控制，叠加打点到刻录信息(参数无)
            ZLNET_BURNING_ADDCURSTOMINFO,					// 刻录机控制，自定义叠加(以'\0'为结尾的字符串，最大长度1024字节，支持分行，行分隔符'\n')
            ZLNET_CTRL_RESTOREDEFAULT,						// 恢复设备的默认设置
            ZLNET_CTRL_CAPTURE_START,						// 触发设备抓图
            ZLNET_CTRL_CLEARLOG,							// 清除日志
            ZLNET_TRIGGER_ALARM_WIRELESS = 200,				// 触发无线报警(IPC产品)
            ZLNET_MARK_IMPORTANT_RECORD,					// 标识重要录像文件
            ZLNET_CTRL_DISK_SUBAREA, 						// 网络硬盘分区
            ZLNET_BURNING_ATTACH,							// 刻录机控制，附件刻录.
            ZLNET_BURNING_PAUSE,							// 刻录暂停
            ZLNET_BURNING_CONTINUE,							// 刻录继续
            ZLNET_BURNING_POSTPONE,							// 刻录顺延
            ZLNET_CTRL_OEMCTRL,								// 报停控制
            ZLNET_BACKUP_START,								// 设备备份开始
            ZLNET_BACKUP_STOP,								// 设备备份停止
            ZLNET_CONTROL_DELETE_CONFIG,                    // 删除配置
        };

        // IO控制命令，对应ZLNET_QueryIOControlState接口
        public enum ZLNET_IOTYPE
        {
            ZLNET_ALARMINPUT = 1,							// 控制报警输入
            ZLNET_ALARMOUTPUT = 2,							// 控制报警输出
            ZLNET_DECODER_ALARMOUT = 3,						// 控制报警解码器输出
            ZLNET_WIRELESS_ALARMOUT = 5,					// 控制无线报警输出
            ZLNET_ALARM_TRIGGER_MODE = 7,					// 报警触发方式（手动,自动,关闭），使用TRIGGER_MODE_CONTROL结构体
        };

        /////////////////////////////////配置相关/////////////////////////////////

        // 配置文件类型，供ZLNET_ExportConfigFile接口使用
        public enum ZLNET_CONFIG_FILE_TYPE
        {
            ZLNET_CONFIGFILE_ALL = 0,					// 全部配置文件
            ZLNET_CONFIGFILE_LOCAL,						// 本地配置文件
            ZLNET_CONFIGFILE_NETWORK,					// 网络配置文件
            ZLNET_CONFIGFILE_USER,						// 用户配置文件
        };

        // NTP
        public enum ZLNET_TIME_ZONE_TYPE
        {
            ZLNET_TIME_ZONE_0,							// {0, 0*3600,"GMT+00:00"}
            ZLNET_TIME_ZONE_1,							// {1, 1*3600,"GMT+01:00"}
            ZLNET_TIME_ZONE_2,							// {2, 2*3600,"GMT+02:00"}
            ZLNET_TIME_ZONE_3,							// {3, 3*3600,"GMT+03:00"}
            ZLNET_TIME_ZONE_4,							// {4, 3*3600+1800,"GMT+03:30"}
            ZLNET_TIME_ZONE_5,							// {5, 4*3600,"GMT+04:00"}
            ZLNET_TIME_ZONE_6,							// {6, 4*3600+1800,"GMT+04:30"}
            ZLNET_TIME_ZONE_7,							// {7, 5*3600,"GMT+05:00"}
            ZLNET_TIME_ZONE_8,							// {8, 5*3600+1800,"GMT+05:30"}
            ZLNET_TIME_ZONE_9,							// {9, 5*3600+1800+900,"GMT+05:45"}
            ZLNET_TIME_ZONE_10,							// {10, 6*3600,"GMT+06:00"}
            ZLNET_TIME_ZONE_11,							// {11, 6*3600+1800,"GMT+06:30"}
            ZLNET_TIME_ZONE_12,							// {12, 7*3600,"GMT+07:00"}
            ZLNET_TIME_ZONE_13,							// {13, 8*3600,"GMT+08:00"}
            ZLNET_TIME_ZONE_14,							// {14, 9*3600,"GMT+09:00"}
            ZLNET_TIME_ZONE_15,							// {15, 9*3600+1800,"GMT+09:30"}
            ZLNET_TIME_ZONE_16,							// {16, 10*3600,"GMT+10:00"}
            ZLNET_TIME_ZONE_17,							// {17, 11*3600,"GMT+11:00"}
            ZLNET_TIME_ZONE_18,							// {18, 12*3600,"GMT+12:00"}
            ZLNET_TIME_ZONE_19,							// {19, 13*3600,"GMT+13:00"}
            ZLNET_TIME_ZONE_20,							// {20, -1*3600,"GMT-01:00"}
            ZLNET_TIME_ZONE_21,							// {21, -2*3600,"GMT-02:00"}
            ZLNET_TIME_ZONE_22,							// {22, -3*3600,"GMT-03:00"}
            ZLNET_TIME_ZONE_23,							// {23, -3*3600-1800,"GMT-03:30"}
            ZLNET_TIME_ZONE_24,							// {24, -4*3600,"GMT-04:00"}
            ZLNET_TIME_ZONE_25,							// {25, -5*3600,"GMT-05:00"}
            ZLNET_TIME_ZONE_26,							// {26, -6*3600,"GMT-06:00"}
            ZLNET_TIME_ZONE_27,							// {27, -7*3600,"GMT-07:00"}
            ZLNET_TIME_ZONE_28,							// {28, -8*3600,"GMT-08:00"}
            ZLNET_TIME_ZONE_29,							// {29, -9*3600,"GMT-09:00"}
            ZLNET_TIME_ZONE_30,							// {30, -10*3600,"GMT-10:00"}
            ZLNET_TIME_ZONE_31,							// {31, -11*3600,"GMT-11:00"}
            ZLNET_TIME_ZONE_32,							// {32, -12*3600,"GMT-12:00"}
        };

        public enum ZLNET_SNAP_TYPE
        {
            ZLNET_SNAP_TYP_TIMING = 0,
            ZLNET_SNAP_TYP_ALARM,
            ZLNET_SNAP_TYP_NUM,
        };

        //NVR网络通道状态
        public enum ZLNET_NVR_NET_CHANNEL_STATE
        {
            ZLNET_STATE_NULL = 0,			//正常
            ZLNET_STATE_NO_SET,				//未开启
            ZLNET_STATE_ERROR,				//错误
            ZLNET_STATE_LOGINING,			//正在登录
            ZLNET_STATE_LOGIN_TIMEOUT,		//登录超时
            ZLNET_STATE_NET_FAILED,			//网络错误
            ZLNET_STATE_USER_PWD_FAILED,	//用户名密码错误
            ZLNET_STATE_USER_UNREPEAT,		//账号不能复用
            ZLNET_STATE_USER_LOCKED,		//帐号已锁定
            ZLNET_STATE_CHANNEL_UNEXIST,	//通道不存在
            ZLNET_STATE_MAIN_STREAM_NODATA,	//无主码流数据
            ZLNET_STATE_SUB_STREAM_NODATA,	//无辅码流数据
            ZLNET_STATE_VDEC_LACK_ABILITY,	//解码能力不够
            ZLNET_STATE_VDEC_INABILITY,		//无法解码
            ZLNET_STATE_NET_LACK_ABILITY,	//网络接入能力超出
        };

        //NVR 协议权限和设备能力权限定义
        public enum ZLNET_NVR_PROANDDEV_ABILITY
        {
            //大的权限
            ZLNET_ABILITY_VIDEO = 0,				//视频。没这个能力，不能添加到网络通道
            ZLNET_ABILITY_SEARCH,					//搜索
            ZLNET_ABILITY_PTZ,						//云台
            ZLNET_ABILITY_ALARM,					//报警
            ZLNET_ABILITY_SET_CONFIG,				//设置配置
            ZLNET_ABILITY_REBOOT,					//重启设备
            ZLNET_ABILITY_JPG,						//是否支持抓图功能
            ZLNET_ABILITY_BROADCAST_SET_ADDR,		//广播方式修改设备地址

            //ABILITY_SET_CONFIG的小能力
            ZLNET_ABILITY_SET_ENCODE_CONFIG = 16,	//设置编码配置
            ZLNET_ABILITY_SET_CHANNEL_NAME,			//设置通道名称
            ZLNET_ABILITY_SET_VIDEO_COLOR,			//设置编码色调
            ZLNET_ABILITY_SET_VIDEO_MOTION_PARAM,	//设置视频检查参数
            ZLNET_ABILITY_SET_TIME,					//设置时间
            ZLNET_ABILITY_SET_ADDRESS,				//设置地址

            //报警小能力
            ZLNET_ABILITY_VIDEO_ALARM,				//视频报警
            ZLNET_ABILITY_OUT_ALARM,				//外部报警

            //云台小能力
            ZLNET_ABILITY_PTZ_PRESET,				//预置点操作
            ZLNET_ABILITY_PTZ_TOUR,					//巡航操作

            //
            ZLNET_ABILITY_MAX = 64,
        };

        //DDNS类型
        public enum ZLNET_DDNS_MODE
        {
            ZLNET_ZL_DDNS = 0,
            ZLNET_BXS_DDNS,
        };

        // 对应ZLNET_RefreshInfo接口
        public enum ZLNET_REFRESH_TYPE
        {
            ZLNET_REFRESH_TMP_OSD = 1,	// 临时OSD，仅显示叠加，不保存进设备配置，pData此时为ZLNET_DVR_VIDEOOSD_CFG*
            ZLNET_REFRESH_TTS,			// TTS推送，pData此时为char*, ANSI code字符串
        };

        /************************************************************************
        ** 结构体定义
        ***********************************************************************/

        // 时间
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_TIME
        {
            public uint dwYear;			// 年
            public uint dwMonth;		// 月
            public uint dwDay;			// 日
            public uint dwHour;			// 时
            public uint dwMinute;		// 分
            public uint dwSecond;		// 秒
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVTIME
        {
            public uint time;

            public uint InitSecond()
            {
                uint second = time & ((1 << 6) - 1);
                return second;
            }
            public uint InitMinute()
            {
                uint minute = (time >> 6) & ((1 << 6) - 1);
                return minute;
            }

            public uint InitHour()
            {
                uint hour = (time >> 12) & ((1 << 5) - 1);
                return hour;
            }

            public uint InitDay()
            {
                uint day = (time >> 17) & ((1 << 5) - 1);
                return day;
            }

            public uint InitMouth()
            {
                uint month = (time >> 22) & ((1 << 4) - 1);
                return month;
            }

            public uint InitYear()
            {
                uint year = (time >> 26) & ((1 << 6) - 1) + 2000;
                return year;
            }
        };

        ///////////////////////////////监视相关定义///////////////////////////////

        // 回调原始视频帧的帧参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VideoFrameParam
        {
            public byte encode;					// 编码类型
            public byte frametype;				// I = 0, P = 1, B = 2...
            public byte framerate;				// PAL - 0, NTSC - 1
            public byte res;					        //
            public uint width;					    // 宽
            public uint height;				        // 高
            public ZLNET_TIME stTime;		// 码流头时间
            public uint nTimeStamp;		    // 附加时间戳
            public uint nSequence;		    // 帧序号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.U4)]
            public uint[] reserved;	            //保留
        };

        // 回调解码后音频帧（PCM）的帧参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CBPCMDataParam
        {
            public byte channels;				// 声道数
            public byte samples;				// 采样 0 - 8000, 1 - 11025, 2 - 16000, 3 - 22050, 4 - 32000, 5 - 44100, 6 - 48000
            public byte depth;					// 采样深度 取值8或者16等。直接表示
            public byte param1;					// 0 - 指示无符号，1-指示有符号
            public uint reserved;				// 保留
        };

        // 回调原始音频帧的帧参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AudioFrameParam
        {
            public byte encode;				    // 编码类型,见ZLNET_TALK_CODING_TYPE
            public byte channels;			    // 声道数
            public byte samples;				// 采样率 0 - 8000, 1 - 11025, 2 - 16000, 3 - 22050, 4 - 32000, 5 - 44100, 6 - 48000
            public byte depth;					// 采样深度 取值8或者16等。直接表示
            public int compressrate;			// 压缩比，encode 为ZLNET_TALK_G726、ZLNET_TALK_G726_STD 时有效 0-16K，1-24K, 2-32K, 3-40K
            public ZLNET_TIME stTime;		    // 码流头时间
            public uint nTimeStamp;		        // 附加时间戳
            public uint nSequence;		        // 帧序号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.U4)]
            public uint[] reserved;	            //保留
        };

        //
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_STRING
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PER_STRING_LEN)]
            public string str;
        }

        // 通道画面字幕叠加的数据结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_OSDSTRING
        {
            public int bEnable;				// 使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_STRING_LINE_LEN, ArraySubType = UnmanagedType.U4)]
            public uint[] dwPosition;	            //各行字符的位置　用1-9整数表示，与小键盘位置对应
            //		7左上	8上		9右上
            //		4左		5中		6右
            //		1左下	2下		3右下
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_STRING_LINE_LEN, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_STRING[] szStrings;	            // 最多六行字符，每行最多20个字节
        };

        ///////////////////////////////回放相关定义///////////////////////////////

        //[StructLayout(LayoutKind.Explicit, Pack = 1)]
        //public unsafe struct STRUCT_ATM_INFO
        //{
        //    [FieldOffset(0)]
        //    public fixed byte cardNo[ZLNET_CARDNUM_LEN];		// ATM卡号
        //    [FieldOffset(ZLNET_CARDNUM_LEN)]
        //    public fixed byte amount[16];				        // 交易金额
        //    [FieldOffset(ZLNET_CARDNUM_LEN + 16)]
        //    public fixed byte opType[4];				        // ATM操作类型
        //    [FieldOffset(ZLNET_CARDNUM_LEN + 16 + 4)]
        //    public fixed byte reversed[88];
        //};

        //[StructLayout(LayoutKind.Explicit, Pack = 1)]
        //public unsafe struct UNION_RECINFO
        //{
        //    [FieldOffset(0)]
        //    public  fixed byte          filename[128];			    // 文件名

        //    [FieldOffset(0)]
        //    public  STRUCT_ATM_INFO     atminfo;
        //}

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ATMINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CARDNUM_LEN)]
            public string cardNo;				// ATM卡号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string amount;				// 交易金额

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 4)]
            public string opType;				// ATM操作类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
            public byte[] reversed;
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_RECINFO
        {
            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string filename;			// 文件名

            [FieldOffset(0)]
            public STRUCT_ATMINFO atminfo;			// 仅限台湾ATM设备使用
        };

        // 录像文件信息  
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RECORDFILE_INFO
        {
            public uint ch;						// 通道号
            //public ZLNET_UNION_REC_INFO     unInfo;
            public UNION_RECINFO unInfo;
            public uint size;					            // 文件长度，KB
            public ZLNET_TIME starttime;				// 开始时间
            public ZLNET_TIME endtime;				// 结束时间
            public uint driveno;				// 磁盘号(区分网络录像和本地录像的类型，0－127表示本地录像，128表示网络录像)
            public uint startcluster;			// 起始簇号
            public byte nRecordFileType;		// 录象文件类型  0：普通录象；1：报警录象；2：移动检测；3：卡号录象；5：图片
            public byte bImportantRecID;		// 0:普通录像 1:重要录像
            public byte bHint;					// 文件定位索引
            public byte byNetMultID;			// 播放项ID. 网络库上层使用,不是查询所得! 是用户回放的时候用来区分同一个通道的不同项而使用, 是一个输入值!
            // 由于支持该功能的设备最多支持一个通道16项, 所以传入的值会被内部做取余处理, 范围为[0,15]
        };

        //码流回调订阅参数
        public enum ZLNET_MEDIA_TYPE_FLAG
        {
            ZLNET_MEDIA_NORMAL = 0x0001,		                //私有混合流,带私有头（需用我司解码库解码)
            ZLNET_MEDIA_VIDEO_ORIGINAL = 0x0002,            //原始视频,不带私有头（如H264、H265，具体由设备本身决定）
            ZLNET_MEDIA_VIDEO_YUV420 = 0x0004,              //视频YUV
            ZLNET_MEDIA_AUDIO_PCM = 0x0008,		            //音频PCM
            ZLNET_MEDIA_AUDIO_ORIGINAL = 0x0010,		    //原始音频,不带私有头(如G711、AAC，具体由设备本身决定)
        }

        // 按文件回放高级参数，对应接口ZLNET_PlayBackByRecordFileV3
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RECORDFILE_EXTERN
        {
            public uint fileOffset;				// 文件偏移量
            public uint nMediaFlag;				// 数据回调类型，回调不为NULL时有效，ZLNET_MEDIA_TYPE_FLAG的组合，填0会被默认置为ZLNET_MEDIA_NORMAL

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 119)]
            public byte[] reversed;

            public byte streamType;				//0主码流，1辅码流1, 2辅码流2
        };

        // 录像查询参数，对应接口ZLNET_QueryRecordFileEx
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_QUERY_RECORD_PARAM
        {
            public int nChannel;
            public int nStreamType;		//0主码流，1辅码流1, 2辅码流2
            public int nRecordFileType;	//0	所有录像文件 1外部报警视频 2动检视频 3报警视频 4卡号视频 5图片
            public ZLNET_TIME tmStart;
            public ZLNET_TIME tmEnd;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CARDNUM_LEN)]
            public string szCardid;	        //nRecordFileType==4时有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;		        //预留
        };

        // 视频回调帧
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_FRAME_CB
        {
            public ZLNET_VideoFrameParam stParam;       //编码参数
            public IntPtr pBuffer;                                      //码流数据指针
            public uint nBufSize;                                      //码流数据长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szRes;		        //预留
        }

        // 音频回调帧
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUDIO_FRAME_CB
        {
            public ZLNET_AudioFrameParam stParam;       //编码参数
            public IntPtr pBuffer;                                      //码流数据指针
            public uint nBufSize;                                      //码流数据长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szRes;		        //预留
        }

        // YUV回调帧
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_YUV_FRAME_CB
        {
            public ZLNET_CBPCMDataParam stParam;       //编码参数
            public IntPtr pBuffer;                                      //码流数据指针
            public uint nBufSize;                                      //码流数据长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szRes;		        //预留
        }

        // 按时间回放参数
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)] // 4字节对齐
        public struct ZLNET_PLAY_BY_TIME_PARAM
        {
            public int nChannel;
            public int nStreamType;	    //0主码流，1辅码流1, 2辅码流2
            public ZLNET_TIME tmStart;
            public ZLNET_TIME tmEnd;
            public IntPtr hWnd;
            public uint nMediaFlag;	        //数据回调类型，ZLNET_MEDIA_TYPE_FLAG的组合，填0会被默认置为ZLNET_MEDIA_NORMAL

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 508)]
            public byte[] szRes;	        //预留
        };

        // 下载模式
        public enum ZLNET_DOWNLOADFILE_MODE
        {
            ZLNET_DOWNLOADFILE_DEFAULT = 0,		//默认, 我司私有混合流
            ZLNET_MODE_VIDEO,		                            //标准视频流(H264等，具体取决于设备)
        };

        //按时间下载参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DOWN_BY_TIME_PARAM
        {
            public int nChannel;               // 通道号
            public int nStreamType;            // 码流类型，仅部分设备支持，0主码流，1辅码流1, 2辅码流2
            public int nRecordFileType;        // 类型，该字段对大部分设备已经无效 0所有录像文件 1外部报警视频 2动检视频 3报警视频 4卡号视频 5图片
            public ZLNET_TIME tmStart;         // 开始时间
            public ZLNET_TIME tmEnd;           // 结束时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szFilePath;              // 保存的文件路径（注意如果文件已存在，会被覆盖)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;	        //预留
        };

        // 系统时间结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SYSTEM_TIME
        {
            public int year;		// 年。
            public int month;		// 月，January = 1, February = 2, and so on.
            public int day;		// 日。
            public int hour;		// 时。
            public int minute;	    // 分。
            public int second;	    // 秒。
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct SYSTEM_TIME_DST
        {
            public int year;		// 年。
            public int month;		// 月，January = 1, February = 2, and so on.
            public int day;		// 日。
            public int wday;		// 星期，Sunday = 0, Monday = 1, and so on
            public int hour;		// 时。
            public int minute;	    // 分。
            public int second;	    // 秒。
            public int isdst;		// 夏令时标识。
        };

        //夏令时时间结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IDVR_TIME_DST
        {
            public int tm_year;
            public int tm_mon;     // [0,11]
            public int tm_mday;    // [1,31]
            public int tm_wday;	// 星期
            public int tm_hour;    // [0,23]
            public int tm_min;     // [0,59]
            public int tm_sec;     // [0,59]
            public int isdst;		// 夏令时标识。
        };

        //智能DVR文件信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IDVR_LOG_FILE_ITEM
        {
            public uint id;			//报警ID
            public ZLNET_DEVTIME time;		//时间
            public byte chn;		//通道
            public byte type;		//文件类型 1录像 2报警前图片 3报警图
            public byte Length;		//录像时间(S)
            public byte Reserve;	//保留位
        };

        // 最早录像时间
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FURTHEST_RECORD_TIME
        {
            public int nChnCount;				// 通道数目

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_TIME[] stuFurthestTime;	    // 最早录像时间,有效值为前面0 到 (nChnCount-1)个.如果某通道没有录象的话，最早录象时间全为0

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)]
            public byte[] bReserved;			    // 保留字段
        };

        ///////////////////////////////报警相关定义///////////////////////////////

        // 普通报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CLIENT_STATE
        {
            public int channelcount;
            public int alarminputcount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_ALARM_STATE_NUM)]
            public byte[] alarm;				// 外部报警

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_ALARM_STATE_NUM)]
            public byte[] motiondection;		// 动态检测

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_ALARM_STATE_NUM)]
            public byte[] videolost;			// 视频丢失
        };

        // 报警IO控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_CONTROL
        {
            public UInt16 index;					// 端口序号
            public UInt16 state;					// 端口状态
        };

        // 触发方式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_TRIGGER_MODE_CONTROL
        {
            public UInt16 index;					// 端口序号
            public UInt16 mode;					// 触发方式(0关闭1手动2自动);不设置的通道，sdk默认将保持原来的设置。

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public Byte[] bReserved;
        };

        // 报警解码器控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DECODER_ALARM_CONTROL
        {
            public int decoderNo;				// 报警解码器号，从0开始
            public UInt16 alarmChn;				// 报警输出口，从0开始
            public UInt16 alarmState;				// 报警输出状态；1：打开，0：关闭
        };

        // 报警上传功能的报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEW_ALARM_UPLOAD
        {
            public uint dwAlarmType;			// 报警类型，dwAlarmType = ZLNET_UPLOAD_EVENT时，dwAlarmMask和bAlarmDecoderIndex是无效的
            public uint dwAlarmMask;			// 报警信息掩码，按位表示各报警通道状态

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szGlobalIP;	            // 客户端IP地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string szDomainName;	        // 客户端域名

            public int nPort;					// 报警上传时客户端连接的端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_ALARM_OCCUR_TIME_LEN)]
            public string szAlarmOccurTime;	    // 报警发生的时间

            public byte bAlarmDecoderIndex;		// 表示第几个报警解码器，dwAlarmType = ZLNET_UPLOAD_DECODER_ALARM 才有效.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15)]
            public byte[] bReservedSpace;
        };

        // 智能设备上传信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IDVR_UPLOAD
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string szDomainName;	// 设备域名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szIP;			// 设备IP地址

            public int nPort;			//设备端口号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szSerial;	    //设备序列号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_ALARM_OCCUR_TIME_LEN)]
            public string szOccurTime;	//上传时间
        };

        // 录像状态变化报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_RECORDING_CHANGED
        {
            public int nChannel;				// 录像通道号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        };

        /////////////////////////////语音对讲相关定义/////////////////////////////

        // 音频格式信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUDIO_FORMAT
        {
            public byte byFormatTag;		    // 编码类型，如0：PCM

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byRes;                // 预留

            public UInt16 nChannels;			// 声道数，建议1
            public UInt16 wBitsPerSample;		// 采样深度，建议16
            public uint nSamplesPerSec;		    // 采样率，建议8000
        };

        /////////////////////////////用户管理相关定义/////////////////////////////

        // 支持用户名最大长度为8位的设备，对应ZLNET_QueryUserInfo和ZLNET_OperateUserInfo接口
        // 权限信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OPR_RIGHT
        {
            public uint dwID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_RIGHT_NAME_LENGTH)]
            public string name;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;
        };

        // 用户信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_INFO
        {
            public uint dwID;
            public uint dwGroupID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH)]
            public string name;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_LENGTH)]
            public string passWord;

            public uint dwRightNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] rights;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;

            public uint dwReusable;		// 是否复用；1：复用，0：不复用
        };

        // 用户组信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_GROUP_INFO
        {
            public uint dwID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH)]
            public string name;

            public uint dwRightNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] rights;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;
        };

        // 用户信息表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_MANAGE_INFO
        {
            public uint dwRightNum;				// 权限信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_OPR_RIGHT[] rightList;

            public uint dwGroupNum;				// 用户组信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_GROUP_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_USER_GROUP_INFO[] groupList;

            public uint dwUserNum;				// 用户信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_USER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_USER_INFO[] userList;

            public uint dwSpecial;				// 用户复用能力；1：支持用户复用，0：不支持用户复用
        };

        // 权限信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OPR_RIGHT_EX
        {
            public uint dwID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_RIGHT_NAME_LENGTH)]
            public string name;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;
        };

        // 用户信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_INFO_EX
        {
            public uint dwID;
            public uint dwGroupID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string name;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_LENGTH_EX)]
            public string passWord;

            public uint dwRightNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] rights;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;

            public uint dwFouctionMask;			// 掩码，0x00000001 - 支持用户复用

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byReserve;
        };

        // 用户组信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_GROUP_INFO_EX
        {
            public uint dwID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string name;

            public uint dwRightNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] rights;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string memo;
        };

        // 用户信息表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_USER_MANAGE_INFO_EX
        {
            public uint dwRightNum;				// 权限信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_RIGHT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_OPR_RIGHT_EX[] rightList;

            public uint dwGroupNum;				// 用户组信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_GROUP_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_USER_GROUP_INFO_EX[] groupList;

            public uint dwUserNum;				// 用户信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_USER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_USER_INFO_EX[] userList;

            public uint dwFouctionMask;			// 掩码；0x00000001 - 支持用户复用，0x00000002 - 密码修改需要校验
            public byte byNameMaxLength;		// 支持的用户名最大长度
            public byte byPSWMaxLength;			// 支持的密码最大长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
            public byte[] byReserve;
        };

        ///////////////////////////////查询相关定义///////////////////////////////

        // 设备支持语言种类
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LANGUAGE_DEVINFO
        {
            public uint dwLanguageNum;			// 支持语言个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 252)]
            public byte[] byLanguageType;	        // 枚举值，详见ZLNET_LANGUAGE_TYPE
        };

        // 硬盘信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_DISKSTATE
        {
            public uint dwVolume;				// 硬盘的容量
            public uint dwFreeSpace;			// 硬盘的剩余空间
            public byte dwStatus;				// 硬盘的状态,0-休眠,1-活动,2-故障等；将unsigned int拆成四个BYTE
            public byte bDiskNum;				// 硬盘号
            public byte bSubareaNum;			// 分区号
            public byte bSignal;				// 标识，0为本地 1为远程
        };

        // 设备硬盘信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HARDDISK_STATE
        {
            public uint dwDiskNum;			// 个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DISKNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_DISKSTATE[] stDisks;	        // 硬盘或分区信息
        };

        // 语音编码信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_TALKDECODE_INFO
        {
            public ZLNET_TALK_CODING_TYPE encodeType;			// 编码类型
            public int nAudioBit;			            // 位数，如8或16
            public uint dwSampleRate;		// 采样率，如8000或16000
            public byte byCompressRate;			// 压缩比，针对G.726-ASF和G.726-STD 0-16K，1-24K, 2-32K, 3-40K

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
            public byte[] reserved;
        };

        // 设备支持的语音对讲类型
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_TALKFORMAT_LIST
        {
            public int nSupportNum;			// 个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_TALKDECODE_INFO[] type;			        // 编码类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;
        };

        // 云台属性信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PTZ_OPT_ATTR
        {
            public uint dwHighMask;				// 操作的掩码高位
            public uint dwLowMask;				// 操作的掩码低位
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_NAME_MAX_LEN)]
            public string szName;	                // 操作的协议名

            public UInt16 wCamAddrMin;			// 通道地址的最小值
            public UInt16 wCamAddrMax;			// 通道地址的最大值
            public UInt16 wMonAddrMin;			// 监视地址的最小值
            public UInt16 wMonAddrMax;			// 监视地址的最大值
            public byte bPresetMin;				// 预置点的最小值
            public byte bPresetMax;				// 预置点的最大值
            public byte bTourMin;				// 自动巡航线路的最小值
            public byte bTourMax;				// 自动巡航线路的最大值
            public byte bPatternMin;			// 轨迹线路的最小值
            public byte bPatternMax;			// 轨迹线路的最大值
            public byte bTileSpeedMin;			// 垂直速度的最小值
            public byte bTileSpeedMax;			// 垂直速度的最大值
            public byte bPanSpeedMin;			// 水平速度的最小值
            public byte bPanSpeedMax;			// 水平速度的最大值
            public byte bAuxMin;				// 辅助功能的最小值
            public byte bAuxMax;				// 辅助功能的最大值
            public int nInternal;				// 发送命令的时间间隔
            public byte cType;					// 协议的类型
            public byte bReserved_1;			// 保留
            public byte bFuncMask;				// 协议功能掩码,按位表示,置１表示支持,第一位表示内置云台功能，其它７位暂时保留
            public byte bReserved_2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] Reserved;
        };

        // 刻录机信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_BURNING
        {
            public uint dwDriverType;			// 刻录驱动器类型；0：DHFS，1：DISK，2：CDRW
            public uint dwBusType;				// 总线类型；0：USB，1：1394，2：IDE
            public uint dwTotalSpace;			// 总容量(KB)
            public uint dwRemainSpace;			// 剩余容量(KB)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_BURNING_DEV_NAMELEN)]
            public byte[] dwDriverName;	        // 刻录驱动器名称
        };

        // 设备刻录机信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BURNING_DEVINFO
        {
            public uint dwDevNum;		    // 刻录设备个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_BURNING_DEV_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_BURNING[] stDevs;	            // 各刻录设备信息
        };

        // 刻录进度
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BURNING_PROGRESS
        {
            public byte bBurning;				// 刻录机状态；0：可以刻录，1：刻录机类型不对，是一个非光盘设备，
            // 2：未找到刻录机，3：有其它光盘在刻录，4：刻录机处于非空闲状态，即在备份、刻录或回放中
            public byte bRomType;				// 盘片类型；0：智诺文件系统，1：移动硬盘或U盘，2：光盘
            public byte bOperateType;			// 操作类型；0：空闲，1：正在备份中，2：正在刻录中，3：正在进行光盘回放
            public byte bType;					// 备份或刻录过程状态；0：停止或结束，1：开始，2：出错，3：满，4：正在初始化
            public ZLNET_TIME stTimeStart;			// 开始时间　
            public uint dwTimeElapse;			// 已刻录时间(秒)
            public uint dwTotalSpace;			// 光盘总容量
            public uint dwRemainSpace;			// 光盘剩余容量
            public uint dwBurned;				// 已刻录容量
            public UInt16 dwStatus;				// 保留
            public UInt16 wChannelMask;			// 正在刻录的通道掩码
        };

        // 日志信息，对应接口ZLNET_QueryLog接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LOG_ITEM
        {
            public ZLNET_DEVTIME time;					// 日期
            public UInt16 type;					// 类型
            public byte reserved;				// 保留
            public byte data;					// 数据

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string context;				// 内容
        };

        // 日志信息，对应扩展接口ZLNET_QueryLogEx，参数reserved(int nType=1;reserved=&nType;)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEWLOG_ITEM
        {
            public ZLNET_DEVTIME time;					// 日期
            public UInt16 type;					// 类型
            public UInt16 data;					// 数据

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string szOperator; 			// 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string context;		        // 内容
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_OLDLOG
        {
            public ZLNET_LOG_ITEM stuLog;			// 旧的日志结构体

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] bReserved;		// 保留
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_LOG_ITEM
        {
            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szLogContext;		// 日志内容

            [FieldOffset(0)]
            public ZLNET_LOG_ITEM stuOldLog;
        }

        // 日志信息，对应接口ZLNET_QueryDeviceLog接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVICE_LOG_ITEM
        {
            public int nLogType;				// 日志类型
            public ZLNET_DEVTIME stuOperateTime;			// 日期

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szOperator; 		// 操作者

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] bReserved;

            public byte bUnionType;				//  union结构类型,0:szLogContext；1:stuOldLog。
            public UNION_LOG_ITEM unLogitem;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };

        // 录象日志信息，对应日志结构体里的context
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LOG_ITEM_RECORD
        {
            public ZLNET_DEVTIME time;					// 时间
            public byte channel;				// 通道
            public byte type;					// 录像类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_QUERY_DEVICE_LOG_PARAM
        {
            public ZLNET_LOG_QUERY_TYPE emLogType;			// 查询日志类型
            public ZLNET_TIME stuStartTime;		// 查询日志的开始时间
            public ZLNET_TIME stuEndTime;			// 查询日志的结束时间
            public int nStartNum;			// 在时间段中从第几条日志开始查询，开始第一次查询可设为0
            public int nEndNum;			// 一次查询中到第几条日志结束。

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] bReserved;
        };

        // 设备硬盘里的录象信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_DISK_RECORD_INFO
        {
            public ZLNET_TIME stuBeginTime;			// 最早录象时间
            public ZLNET_TIME stuEndTime;				// 最近录象时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reserved;
        };

        ///////////////////////////////控制相关定义///////////////////////////////

        // 硬盘操作
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISKCTRL_PARAM
        {
            public uint dwSize;					// 结构体大小，版本控制用
            public int nIndex;					// 为硬盘信息结构体ZLNET_HARDDISK_STATE里的数组stDisks下标，从0开始
            public int ctrlType;				// 操作类型，
            // 0 - 清除数据, 1 - 设为读写盘, 2 - 设为只读盘
            // 3 - 设为冗余盘, 4 - 恢复错误, 5 - 设为快照盘
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISKCTRL_SUBAREA
        {
            public byte bSubareaNum;			// 预分区的个数
            public byte bIndex;					// 为硬盘信息结构体ZL_HARDDISK_STATE里的数组stDisks下标，从0开始

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bSubareaSize;		// 分区大小（百分比）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] bReserved;			// 保留
        };

        // 报警状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMCTRL_PARAM
        {
            public uint dwSize;
            public int nAlarmNo;				// 报警通道号，从0开始
            public int nAction;				// 1：触发报警，0：停止报警
        };

        // 矩阵控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MATRIXCTRL_PARAM
        {
            public uint dwSize;
            public int nChannelNo;				// 视频输入号，从0开始
            public int nMatrixNo;				// 矩阵输出号，从0开始
        };

        // 刻录控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BURNING_PARM
        {
            public int channelMask;			// 通道掩码，按位表示要刻录的通道
            public int devMask;				// 刻录机掩码，根据查询到的刻录机列表，按位表示
        };

        // 附件刻录
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BURNING_PARM_ATTACH
        {
            public int bAttachBurn;		// 是否为附件刻录，0:不是; 1:是

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] bReserved;			// 保留字段
        };

        ///////////////////////////////配置相关定义///////////////////////////////

        //-------------------------------设备属性---------------------------------
        // 设备信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVICEINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_SERIALNO_LEN)]
            public string sSerialNumber;	        // 序列号
            public byte byAlarmInPortNum;		// DVR报警输入个数
            public byte byAlarmOutPortNum;		// DVR报警输出个数
            public byte byDiskNum;				// DVR硬盘个数
            public byte byDVRType;				// DVR类型, 见枚举ZLNET_DEVICE_TYPE
            public byte byChanNum;				// DVR通道个数
        };

        // 设备软件版本信息，高16位表示主版本号，低16位表示次版本号
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VERSION_INFO
        {
            public uint dwSoftwareVersion;
            public uint dwSoftwareBuildDate;
            public uint dwDspSoftwareVersion;
            public uint dwDspSoftwareBuildDate;
            public uint dwPanelVersion;
            public uint dwPanelSoftwareBuildDate;
            public uint dwHardwareVersion;
            public uint dwHardwareDate;
            public uint dwWebVersion;
        };

        // 设备软件版本信息，对应ZLNET_QueryDevState接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_VERSION_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szDevSerialNo;	        // 序列号

            public int byDevType;				    // 设备类型，见枚举ZLNET_DEVICE_TYPE

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType;			    // 设备详细型号，字符串格式，可能为空

            public int nProtocalVer;			    // 协议版本号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szSoftWareVersion;

            public uint dwSoftwareBuildDate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDspSoftwareVersion;

            public uint dwDspSoftwareBuildDate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szPanelVersion;

            public uint dwPanelSoftwareBuildDate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szHardwareVersion;

            public uint dwHardwareDate;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szWebVersion;

            public byte chHardVersion;	        //硬件版本类型 0：16M Flash  1：32M Flash
            public byte chSDState;		        //SD卡状态 0：无 1：有

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAPTURE_DSPINFO
        {
            public uint nMaxEncodePower;		// DSP 支持的最高编码能力。
            public UInt16 nMaxSupportChannel;	    // DSP 支持最多输入视频通道数。
            public UInt16 bChannelMaxSetSync;	    // DSP 每通道的最大编码设置是否同步 0-不同步, 1 -同步。
            public UInt16 nExpandChannel;		    // DSP 支持的扩展通道数，主要是多路回放使用，目前只是一个
            public UInt16 rev;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAPTURE_CAPABILITY
        {
            public int EncChipNR;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_ENC_CHIP_NR, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CAPTURE_DSPINFO[] EncChipInfo;
        };

        // DSP能力描述，对应ZLNET_GetDevConfig接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DSP_ENCODECAP
        {
            public uint dwVideoStandardMask;	// 视频制式掩码，按位表示设备能够支持的视频制式
            public uint dwImageSizeMask;		// 分辨率掩码，按位表示设备能够支持的分辨率设置，每位对应ZLNET_CAPTURE_SIZE的一个值
            public uint dwEncodeModeMask;		// 编码模式掩码，按位表示设备能够支持的编码模式设置
            public uint dwStreamCap;			// 按位表示设备支持的多媒体功能，
            // 第一位表示支持主码流
            // 第二位表示支持辅码流1
            // 第三位表示支持辅码流2
            // 第五位表示支持jpg抓图
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.U4)]
            public uint[] dwImageSizeMask_Assi;   // 表示主码流为各分辨率时，支持的辅码流分辨率掩码。

            public ZLNET_CAPTURE_CAPABILITY captureCapability;
        };

        // DSP能力描述，扩展类型，对应ZLNET_QueryDevState接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_DSP_ENCODECAP
        {
            public uint dwVideoStandardMask;	// 视频制式掩码，按位表示设备能够支持的视频制式
            public uint dwImageSizeMask;		// 分辨率掩码，按位表示设备能够支持的分辨率，每位对应ZLNET_CAPTURE_SIZE的一个值
            public uint dwEncodeModeMask;		// 编码模式掩码，按位表示设备能够支持的编码模式
            public uint dwStreamCap;			// 按位表示设备支持的多媒体功能，
            // 第一位表示支持主码流
            // 第二位表示支持辅码流1
            // 第三位表示支持辅码流2
            // 第五位表示支持jpg抓图
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
            public uint[] dwImageSizeMask_Assi;   // 表示主码流为各分辨率时，支持的辅码流分辨率掩码。

            public ZLNET_CAPTURE_CAPABILITY captureCapability;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] bMaxFrameOfImageSize;	// 不同分辨率下的最大采集帧率，与dwVideoStandardMask按位对应

            public Byte bEncodeCap;				// 标志，配置时要求符合下面条件，否则配置不能生效；
            // 0：主码流的编码能力+辅码流的编码能力 <= 设备的编码能力，
            // 1：主码流的编码能力+辅码流的编码能力 <= 设备的编码能力，
            // 辅码流的编码能力 <= 主码流的编码能力，
            // 辅码流的分辨率 <= 主码流的分辨率，
            // 主码流和辅码流的帧率 <= 前端视频采集帧率
            // 2：N5的计算方法
            // 辅码流的分辨率 <= 主码流的分辨率
            // 查询支持的分辨率和相应最大帧率

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 95)]
            public byte[] reserved;
        };

        // 系统信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_SYSTEM_ATTR_CFG
        {
            public UInt16 dwSize;
            public UInt16 wPowerFrequency;		//电源频率  0:50HZ 1:60HZ
            /* 下面是设备的只读部分 */
            public ZLNET_VERSION_INFO stVersion;
            public ZLNET_DSP_ENCODECAP stDspEncodeCap;			// DSP能力描述

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szDevSerialNo;	        // 序列号

            public Byte byDevType;				// 设备类型，见枚举ZLNET_DEVICE_TYPE

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType;	            // 设备详细型号，字符串格式，可能为空

            public Byte byVideoCaptureNum;		// 视频口数量
            public Byte byAudioCaptureNum;		// 音频口数量
            public Byte byTalkInChanNum;		// NSP
            public Byte byTalkOutChanNum;		// NSP
            public Byte byDecodeChanNum;		// NSP
            public Byte byAlarmInNum;			// 报警输入口数
            public Byte byAlarmOutNum;			// 报警输出口数
            public Byte byNetIONum;				// 网络口数
            public Byte byUsbIONum;				// USB口数量
            public Byte byIdeIONum;				// IDE数量
            public Byte byComIONum;				// 串口数量
            public Byte byLPTIONum;				// 并口数量
            public Byte byVgaIONum;				// NSP
            public Byte byIdeControlNum;		// NSP
            public Byte byIdeControlType;		// NSP
            public Byte byCapability;			// NSP，扩展描述
            public Byte byMatrixOutNum;			// 视频矩阵输出口数
            public uint uOEM;                   // OEM版本号
            /* 下面是设备的可写部分 */
            public Byte byOverWrite;			// 硬盘满处理方式(覆盖、停止)
            public Byte byRecordLen;			// 录象打包长度
            public Byte byDSTEnable;			// 是否实行夏令时 1-实行 0-不实行
            public UInt16 wDevNo;					// 设备编号，用于遥控
            public Byte byVideoStandard;		// 视频制式:0-PAL,1-NTSC
            public Byte byDateFormat;			// 日期格式
            public Byte byDateSprtr;			// 日期分割符(0："."，1："-"，2："/")
            public Byte byTimeFmt;				// 时间格式 (0-24小时，1－12小时)
            public Byte byLanguage;				// 枚举值详见ZLNET_LANGUAGE_TYPE
        };

        // 修改设备配置返回信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_SET_RESULT
        {
            public uint dwType;				// 类型(即GetDevConfig和SetDevConfig的类型)
            public UInt16 wResultCode;		// 返回码；0：成功，1：失败，2：数据不合法，3：暂时无法设置，4：没有权限
            public UInt16 wRebootSign;		// 重启标志；0：不需要重启，1：需要重启才生效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U4)]
            public uint[] dwReserved;			// 保留
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_DST
        {
            [FieldOffset(0)]
            public int iWeekDay;               // 周[0 - 6](nWeekOrDay：按周计算时)0:星期日, 1:星期一, 2:星期二,3:星期三,4:星期四,5:星期五,6:星期六
            [FieldOffset(0)]
            public int iDay;                   // 日期[1 - 31] (nWeekOrDay：按日期计算)
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        //DST(夏令时)配置
        public struct ZLNET_DST_POINT
        {
            public int nYear;					// 年[200 - 2037]
            public int nMonth;					// 月[1 - 12]
            public int nHour;					// 小时 [0 - 23]
            public int nMinute;				// 分钟 [0 - 59]
            public int nWeekOrDay;				// [-1 - 4]0:表示使用按日期计算的方法
            // 1: 按周计算: 第一周,2: 第二周,3: 第三周,4: 第四周,-1: 最后一周
            public UNION_DST unDst;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.U4)]
            public uint[] dwReserved;			    // 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DST_DEV_CFG
        {
            public uint dwSize;
            public int nDSTType;				// 夏令时定位方式 0:按日期定位方式, 1:按周定位方式
            public ZLNET_DST_POINT stDSTStart;             // 开始夏令时
            public ZLNET_DST_POINT stDSTEnd;				// 结束夏令时

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.U4)]
            public uint[] dwReserved;			    // 保留
        };

        // 自动维护配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUTOMT_CFG
        {
            public uint dwSize;
            public Byte byAutoRebootDay;		// 自动重启；0：从不, 1：每天，2：每星期日，3：每星期一，......
            public Byte byAutoRebootTime;		// 0：0:00，1：1:00，......23：23:00
            public Byte byAutoDeleteFilesTime;	// 自动删除文件；0：从不，1：24H，2：48H，3：72H，4：96H，5：ONE WEEK，6：ONE MONTH

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 13)]
            public Byte[] reserved;			    // 保留位
        };

        //-----------------------------图像通道属性-------------------------------

        // 分辨率列表，用于与分辨率掩码进行与、或操作
        public const uint ZLNET_CAPTURE_SIZE_D1 = 0x00000001;
        public const uint ZLNET_CAPTURE_SIZE_HD1 = 0x00000002;
        public const uint ZLNET_CAPTURE_SIZE_BCIF = 0x00000004;
        public const uint ZLNET_CAPTURE_SIZE_CIF = 0x00000008;
        public const uint ZLNET_CAPTURE_SIZE_QCIF = 0x00000010;
        public const uint ZLNET_CAPTURE_SIZE_VGA = 0x00000020;
        public const uint ZLNET_CAPTURE_SIZE_QVGA = 0x00000040;
        public const uint ZLNET_CAPTURE_SIZE_SVCD = 0x00000080;
        public const uint ZLNET_CAPTURE_SIZE_QQVGA = 0x00000100;
        public const uint ZLNET_CAPTURE_SIZE_SVGA = 0x00000200;
        public const uint ZLNET_CAPTURE_SIZE_XVGA = 0x00000400;
        public const uint ZLNET_CAPTURE_SIZE_WXGA = 0x00000800;
        public const uint ZLNET_CAPTURE_SIZE_SXGA = 0x00001000;
        public const uint ZLNET_CAPTURE_SIZE_WSXGA = 0x00002000;
        public const uint ZLNET_CAPTURE_SIZE_UXGA = 0x00004000;
        public const uint ZLNET_CAPTURE_SIZE_WUXGA = 0x00008000;
        public const uint ZLNET_CAPTURE_SIZE_LFT = 0x00010000;
        public const uint ZLNET_CAPTURE_SIZE_720 = 0x00020000;
        public const uint ZLNET_CAPTURE_SIZE_1080 = 0x00040000;
        public const uint ZLNET_CAPTURE_SIZE_1_3M = 0x00080000;
        public const uint ZLNET_CAPTURE_SIZE_960H = 0x00100000;
        public const uint ZLNET_CAPTURE_SIZE_HD1024 = 0x00200000;
        public const uint ZLNET_CAPTURE_SIZE_2_5M = 0x00400000;
        public const uint ZLNET_CAPTURE_SIZE_5M = 0x00800000;
        public const uint ZLNET_CAPTURE_SIZE_3M = 0x01000000;
        public const uint ZLNET_CAPTURE_SIZE_5_0M = 0x02000000;
        public const uint ZLNET_CAPTURE_SIZE_1_2M = 0x04000000;
        public const uint ZLNET_CAPTURE_SIZE_1408_1024 = 0x08000000;
        public const uint ZLNET_CAPTURE_SIZE_8M = 0x10000000;
        public const uint ZLNET_CAPTURE_SIZE_2560_1920 = 0x20000000;
        public const uint ZLNET_CAPTURE_SIZE_960_720 = 0x40000000;
        public const uint ZLNET_CAPTURE_SIZE_2560_1600 = 0x80000000;

        // 分辨率枚举，供ZLNET_DSP_ENCODECAP使用
        public enum ZLNET_CAPTURE_SIZE
        {
            ZLNET_DSP_CAPTURE_SIZE_D1 = 0,							// 704*576(PAL)  704*480(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_HD1,								// 352*576(PAL)  352*480(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_BCIF,							// 704*288(PAL)  704*240(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_CIF,								// 352*288(PAL)  352*240(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_QCIF,							// 176*144(PAL)  176*120(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_VGA,								// 640*480
            ZLNET_DSP_CAPTURE_SIZE_QVGA,							// 320*240
            ZLNET_DSP_CAPTURE_SIZE_SVCD,							// 480*480
            ZLNET_DSP_CAPTURE_SIZE_QQVGA,							// 160*128
            ZLNET_DSP_CAPTURE_SIZE_SVGA,							// 800*592
            ZLNET_DSP_CAPTURE_SIZE_XVGA,							// 1024*768
            ZLNET_DSP_CAPTURE_SIZE_WXGA,							// 1280*800
            ZLNET_DSP_CAPTURE_SIZE_SXGA,							// 1280*1024
            ZLNET_DSP_CAPTURE_SIZE_WSXGA,							// 1600*1024
            ZLNET_DSP_CAPTURE_SIZE_UXGA,							// 1600*1200
            ZLNET_DSP_CAPTURE_SIZE_WUXGA,							// 1920*1200
            ZLNET_DSP_CAPTURE_SIZE_LTF,								// 240*192
            ZLNET_DSP_CAPTURE_SIZE_720,								// 1280*720
            ZLNET_DSP_CAPTURE_SIZE_1080,							// 1920*1080
            ZLNET_DSP_CAPTURE_SIZE_HD960,							// 1280*960	1_3M
            ZLNET_DSP_CAPTURE_SIZE_960H,							// 944*576(PAL) 944*480(NTSC)
            ZLNET_DSP_CAPTURE_SIZE_HD1024 = 21,						// 1280*1024

            ZLNET_DSP_CAPTURE_SIZE_2_5M,							// 1872×1408
            ZLNET_DSP_CAPTURE_SIZE_5M,								// 3744*1408
            ZLNET_DSP_CAPTURE_SIZE_3M,								// 2048*1536
            ZLNET_DSP_CAPTURE_SIZE_5_0M,							// 2432*2050
            ZLNET_DSP_CAPTURE_SIZE_1_2M,							// 1216*1024
            ZLNET_DSP_CAPTURE_SIZE_1408_1024,						// 1408*1024
            ZLNET_DSP_CAPTURE_SIZE_8M,								// 3296*2472
            ZLNET_DSP_CAPTURE_SIZE_2560_1920,						// 2560*1920(5M)
            ZLNET_DSP_CAPTURE_SIZE_960_720,							// 960*720分辨率
            ZLNET_DSP_CAPTURE_SIZE_2560_1600, 						// 2560*1600(4M)

            //由于掩码限制为unsigned int（32位），导致老协议无法获取以下分辨率能力
            ZLNET_DSP_CAPTURE_SIZE_2336_1752 = 32, 					// 2336*1752(4_0M)
            ZLNET_DSP_CAPTURE_SIZE_2592_2048, 						// 2592*2048
            ZLNET_DSP_CAPTURE_SIZE_1920_1440, 						// 1920*1440
            ZLNET_DSP_CAPTURE_SIZE_2560_1440, 						// 2560*1440(4M_16:9)
            ZLNET_DSP_CAPTURE_SIZE_2592_1520, 						// 2592*1520(4M_4:3)
            ZLNET_DSP_CAPTURE_SIZE_2304_1296, 						// 2304*1296(3M_16:9)
            ZLNET_DSP_CAPTURE_SIZE_2048_1520, 						// 2048*1520(3M_4:3)
            ZLNET_DSP_CAPTURE_SIZE_NHD,								// 640*360
            ZLNET_DSP_CAPTURE_SIZE_QNHD,							// 320*180
            ZLNET_DSP_CAPTURE_SIZE_QQNHD,							// 160*90

            ZLNET_DSP_CAPTURE_SIZE_NR,
        };

        // 编码模式列表，用于与编码模式掩码进行与、或操作
        public const uint ZLNET_CAPTURE_COMP_DIVX_MPEG4 = 0x00000001;
        public const uint ZLNET_CAPTURE_COMP_MS_MPEG4 = 0x00000002;
        public const uint ZLNET_CAPTURE_COMP_MPEG2 = 0x00000004;
        public const uint ZLNET_CAPTURE_COMP_MPEG1 = 0x00000008;
        public const uint ZLNET_CAPTURE_COMP_H263 = 0x00000010;
        public const uint ZLNET_CAPTURE_COMP_MJPG = 0x00000020;
        public const uint ZLNET_CAPTURE_COMP_FCC_MPEG4 = 0x00000040;
        public const uint ZLNET_CAPTURE_COMP_H264 = 0x00000080;
        public const uint ZLNET_CAPTURE_COMP_H264M = 0x00000100;
        public const uint ZLNET_CAPTURE_COMP_H264E = 0x00000200;
        public const uint ZLNET_CAPTURE_COMP_H264H = 0x00000400;
        public const uint ZLNET_CAPTURE_COMP_H265 = 0x00000800;

        // 编码模式类型
        public enum ZLNET_DSP_COMPILE_TYPE
        {
            ZLNET_DSP_CAPTURE_COMP_DIVX_MPEG4 = 0,	// DIVX MPEG4
            ZLNET_DSP_CAPTURE_COMP_MS_MPEG4,		// MS MPEG4
            ZLNET_DSP_CAPTURE_COMP_MPEG2,			// MPEG2
            ZLNET_DSP_CAPTURE_COMP_MPEG1,			// MPEG1
            ZLNET_DSP_CAPTURE_COMP_H263,			// H.263
            ZLNET_DSP_CAPTURE_COMP_MJPG,			// MJPG
            ZLNET_DSP_CAPTURE_COMP_FCC_MPEG4,		// FCC MPEG4
            ZLNET_DSP_CAPTURE_COMP_H264,			// H.264 H.264B
            ZLNET_DSP_CAPTURE_COMP_H264M,			// H.264M
            ZLNET_DSP_CAPTURE_COMP_H264E,			// H.264E
            ZLNET_DSP_CAPTURE_COMP_H264H,			// H.264H
            ZLNET_DSP_CAPTURE_COMP_H265,			// H.265
            ZLNET_DSP_CAPTURE_COMP_H264PLUS,        // H.264+
            ZLNET_DSP_CAPTURE_COMP_H265PLUS,        // H.265+

            ZLNET_DSP_CAPTURE_COMP_NR,
        };

        public enum ZLNET_DSP_AUDIO_TYPE
        {
            ZLNET_DSP_AE_711A = 0,
            ZLNET_DSP_AE_PCM,
            ZLNET_DSP_AE_711U,
            ZLNET_DSP_AE_AMR,
            ZLNET_DSP_AE_AAC,
            ZLNET_DSP_AE_ADPCM,
            ZLNET_DSP_AE_G726,
            ZLNET_DSP_AE_G729,
            ZLNET_DSP_AE_MPEG2,
            ZLNET_DSP_AE_G726ASF,
        };

        // 设置SDK信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SDK_SWITCH_PARAM
        {
            public int nProto;          //特殊定制协议，如非确定请填0
            public int nLogPrint;      //底层日志打印开关，默认关闭，设1打开
            public int nLogFile;        //底层日志写文件开关，默认关闭，设1打开

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 61, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        // 时间段结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_TSECT
        {
            public uint bEnable;		// 录像掩码，按位分别为动态检测录像、报警录像、定时录像、Bit3~Bit15保留、Bit16动态检测抓图、Bit17报警抓图、Bit18定时抓图
            public int iBeginHour;
            public int iBeginMin;
            public int iBeginSec;
            public int iEndHour;
            public int iEndMin;
            public int iEndSec;
        };

        // 区域；各边距按整长8192的比例
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        };

        // OSD属性结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ENCODE_WIDGET
        {
            public uint rgbaFrontground;		// 物件的前景；按字节表示，分别为红、绿、蓝和透明度
            public uint rgbaBackground;			// 物件的背景；按字节表示，分别为红、绿、蓝和透明度
            public ZLNET_RECT rcRect;					// 位置
            public Byte bShow;					// 显示使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] byReserved;
        };

        // 通道音视频属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOENC_OPT
        {
            // 视频参数
            public Byte byVideoEnable;			// 视频使能；1：打开，0：关闭
            public Byte byBitRateControl;		// 码流控制；ZLNET_CAPTURE_BRC_CBR 0, ZLNET_CAPTURE_BRC_VBR 1 ZLNET_CAPTURE_BRC_MBR 2
            public Byte byFramesPerSec;			// 帧率
            public Byte byEncodeMode;			// 编码模式；参照ZLNET_DSP_COMPILE_TYPE
            public Byte byImageSize;			// 分辨率；参照ZLNET_CAPTURE_SIZE
            public Byte byImageQlty;			// 档次1-6
            public UInt16 wLimitStream;			// 限码流参数
            // 音频参数
            public Byte byAudioEnable;			// 音频使能；1：打开，0：关闭
            public Byte wFormatTag;				// 音频编码类型
            public UInt16 nChannels;				// 声道数
            public UInt16 wBitsPerSample;			// 采样深度
            public Byte bAudioOverlay;			// 音频叠加使能
            public Byte bReserved_2;
            public uint nSamplesPerSec;			// 采样率
            public Byte bIFrameInterval;		// I帧间隔帧数量，描述两个I帧之间的P帧个数，0-149
            public Byte bScanMode;				// NSP
            public Byte bReserved_3;
            public Byte bReserved_4;
        };

        // 画面颜色属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COLOR_CFG
        {
            public ZLNET_TSECT stSect;
            public Byte byBrightness;			// 亮度；0-100
            public Byte byContrast;				// 对比度；0-100
            public Byte bySaturation;			// 饱和度；0-100
            public Byte byHue;					// 色度；0-100
            public Byte byGainEn;				// 增益使能
            public Byte byGain;					// 增益；0-100
            public Byte bySharpness;            // 锐度；0-100
            public Byte byWhitebalance;			// 自动白电平控制，bit7置位表示开启自动控制.0x0,0x1,0x2分别代表低,中,高等级
        };

        // 图像通道属性结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_CHANNEL_CFG
        {
            public UInt16 dwSize;
            public Byte bNoise;
            public Byte byMicAutoSwitch;	    // MIC和线性音频 MIC:0  线性音频：1

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHAN_NAME_LEN)]
            public string szChannelName;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_REC_TYPE.ZLNET_REC_TYPE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOENC_OPT[] stMainVideoEncOpt;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_ENCODE_AUX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOENC_OPT[] stAssiVideoEncOpt;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_COL_TSECT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_COLOR_CFG[] stColorCfg;

            public ZLNET_ENCODE_WIDGET stTimeOSD;
            public ZLNET_ENCODE_WIDGET stChannelOSD;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_COVERS, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ENCODE_WIDGET[] stBlindCover;	        // 单区域遮挡

            public Byte byBlindEnable;			// 区域遮盖开关；0x00：不使能遮盖，0x01：仅遮盖设备本地预览，0x10：仅遮盖录像及网络预览，0x11：都遮盖
            public Byte byBlindMask;			// 区域遮盖掩码；第一位：设备本地预览；第二位：录像(及网络预览)
            public Byte bVolume;				// 音量阀值(0~100可调)
            public Byte bVolumeEnable;			// 音量阀值使能
            public Byte byMainEncodingLevel;	// 主码流编码等级
            public Byte bySubEncodingLevel1;	// 辅码流1编码等级
            public Byte byAudioType;			// 音频类型 ZLNET_DSP_AUDIO_TYPE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 39)]
            public Byte[] res;
        };

        // 预览图像参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_PREVIEW_CFG
        {
            public uint dwSize;
            public ZLNET_VIDEOENC_OPT stPreView;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_COL_TSECT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_COLOR_CFG[] stColorCfg;
        };

        //-------------------------------串口属性---------------------------------

        // 串口基本属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COMM_PROP
        {
            public Byte byDataBit;				// 数据位；0：5，1：6，2：7，3：8, 4:4
            public Byte byStopBit;				// 停止位；0：1位，1：1.5位，2：2位
            public Byte byParity;				// 校验位；0：无校验，1：奇校验；2：偶校验 3:MARK 4:SPACE
            public Byte byBaudRate;				// 波特率；0：300，1：600，2：1200，3：2400，4：4800，
            // 5：9600，6：19200，7：38400，8：57600，9：115200
        };

        // 485解码器配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_485_CFG
        {
            public ZLNET_COMM_PROP struComm;
            public Byte wProtocol;				// 协议类型，对应"协议名列表"下标
            public Byte bPTZType;				// 0-兼容，本地云台 1-远程网络云台,通过能力查询(见DEV_ENCODER_CFG)
            public Byte wDecoderAddress;		// 解码器地址；0 - 255
            public Byte byMartixID;				// 矩阵号
        };

        //485模拟控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_485_SIMULATION_CTRL
        {
            public int bSimulationCtrl;			//模拟控制 0-关闭 1-打开
            public int nSimulationSpeed;			//模拟速率 1~30s

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //485模拟控制配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_485_SIMULATION_CTRL_CFG
        {
            public int nSize;			    //结构体大小
            public int nValidNum;		    //有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_485_SIMULATION_CTRL[] simulationCtrl;	    //各通道模拟控制
        };

        // 232串口配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RS232_CFG
        {
            public ZLNET_COMM_PROP struComm;
            public Byte byFunction;				// 串口功能，对应"功能名列表"下标

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] byReserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_MAX_NAME_LENGTH
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string byMaxNameLenth;
        }

        // 串口配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_COMM_CFG
        {
            public uint dwSize;
            public uint dwDecProListNum;		// 解码器协议个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DECPRO_LIST_SIZE, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_MAX_NAME_LENGTH[] DecProName;             // 协议名列表

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DECODER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_485_CFG[] stDecoder;	            // 各解码器当前属性

            public uint dw232FuncNameNum;		// 232功能个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_232FUNCS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_MAX_NAME_LENGTH[] s232FuncName;	        // 功能名列表

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_232_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_RS232_CFG[] st232;	                // 各232串口当前属性
        };

        // 串口状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COMM_STATE
        {
            public uint uBeOpened;
            public uint uBaudRate;
            public uint uDataBites;
            public uint uStopBits;
            public uint uParity;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bReserved;
        };

        //串口类型
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COM_TYPE
        {
            public int nSize;				//结构体大小
            public int nComType;			//串口类型 0:232 1:485

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] Res;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COMM_INFO
        {
            public int nPort;				//串口号
            //部分设备已经淡化了串口类型的概念，所以以下4个参数可能无效
            public int nComType;			//串口类型 0:232 1:485
            public int nMode;				//工作模式：0：全双工 1：半双工
            public int nUsed;				//是否已被内部占用， 0：否 1：是
            public int nAddr;				//地址位，仅部分设备支持

            public ZLNET_COMM_PROP prop;    //参数，注意内部是枚举形式的，不是直接赋值

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string szProtocol;	    //协议名 "Transcom" "LED" "PTZ" "Console"

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //预留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_PRO_NAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string szProName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_COMM_CFG_V30
        {
            public int nNumber;			//info数组有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_COMM_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_COMM_INFO[] info;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DECPRO_LIST_SIZE, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_PRO_NAME[] szProtocolList;         // 支持的协议名列表，仅GET时有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //预留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CreateTransComParams
        {
            public int nPort;			//指定串口号（仅部分设备支持）,从0开始
            public int nComType;		//串口类型 0:232 1:485
            public ZLNET_COMM_PROP prop;	        //参数，注意内部是枚举形式的，不是直接赋值

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		    //预留
        };

        //-------------------------------录象配置---------------------------------

        // 定时录象
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_RECORD_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            public Byte byPreRecordLen;			// 预录时间，单位是s，0表示不预录
            public Byte byRedundancyEn;			// 录像冗余开关
            public Byte byRecordType;           // 录像码流类型：0-主码流 1-辅码流1 2-辅码流2 3-辅码流3
            public Byte byReserved;
        };

        // NTP配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NTP_DEV_CFG
        {
            public int bEnable;				//	是否启用
            public int nHostPort;				//	NTP服务器默认端口为123

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szHostIp;			    //	主机IP

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szDomainName;		    //	域名

            public int nType;					//	不可设置，0：表示IP，1：表示域名，2：表示IP和域名
            public int nUpdateInterval;		//	更新时间(分钟)
            public int nTimeZone;				//	见ZLNET_TIME_ZONE_TYPE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_STRUPERIOD
        {
            public ZLNET_TSECT struSect;				// 该时间段内的“使能”无效，可忽略
            public int bMdEn;					// 上传动态检测录象
            public int bAlarmEn;				// 上传外部报警录象
            public int bTimerEn;				// 上传普通定时录像

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] dwRev;
        };

        // FTP上传配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FTP_UPLOAD_CFG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_TIME_SECTION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_STRUPERIOD[] struperiod;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_FTP_WEEKS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_FTP_UPLOAD_CFG[] stFtpWeeks;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FTP_PROTO_CFG
        {
            public uint dwSize;
            public int bEnable;				// 是否启用

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szHostIp;		        // 主机IP

            public UInt16 wHostPort;				// 主机端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_FTP_MAX_PATH)]
            public string szDirName;		        // FTP目录路径

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_FTP_USERNAME_LEN)]
            public string szUserName;	            // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_FTP_PASSWORD_LEN)]
            public string szPassword;	            // 密码

            public int iFileLen;				// 文件长度
            public int iInterval;				// 相邻文件时间间隔

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_FTP_WEEKS[] struUploadCfg;

            public byte protocol;				// 0-FTP 1-SMB
            public byte NASVer;					// 网络存储服务器版本0=老的FTP(界面上显示时间段)，1=NAS存储(界面上屏蔽时间段)
            public uint dwFunctionMask;			// 功能能力掩码，按位表示，低16位(网络存储)依次表示FTP，SMB，NFS，高16位(本地存储)依次为DISK，U
            public int bAnonymous;				// 是否匿名登录

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_FTP_URL_LEN)]
            public string chHostIP;		        // 主机URL

            public int urlEable;				// 主机URL使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 52)]
            public Byte[] m_Rev;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FTP_PROTO_CFG_EX
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_FTP_PROTO_CFG[] struFtpCfg;            //0: 录像FTP 1:图片FTP
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FTP_SFTP_PROTO_CFG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_FTP_PROTO_CFG[] struFtpCfg;             //0: 录像FTP 1:图片FTP 2:录像SFTP 3：图片SFTP

            public int bSftpEnable;			//SFTP使能，只读不可配置
        };

        //-------------------------------网络配置---------------------------------

        // 以太网配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ETHERNET
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sDevIPAddr;	            // DVR IP 地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sDevIPMask;	            // DVR IP 地址掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sGatewayIP;	            // 网关地址

            /*
             * 1：10Mbps 全双工
             * 2：10Mbps 自适应
             * 3：10Mbps 半双工
             * 4：100Mbps 全双工
             * 5：100Mbps 自适应
             * 6：100Mbps 半双工
             * 7：自适应
             */
            // 为了扩展将unsigned int拆成四个
            public Byte dwNetInterface;			// NSP
            public Byte bTranMedia;				// 0：有线，1：无线
            public Byte bValid;					// 按位表示，第一位：1：有效 0：无效；第二位：0：DHCP关闭 1：DHCP使能；第三位：0：不支持DHCP 1：支持DHCP
            public Byte bDefaultEth;			// 是否作为默认的网卡 1：默认 0：非默认

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MACADDR_LEN)]
            public string byMACAddr;	            // MAC地址，只读
        };

        // 远程主机配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REMOTE_HOST
        {
            public Byte byEnable;				// 连接使能
            public Byte byAssistant;            // 目前只对于PPPoE服务器有用，0：在有线网卡拨号；1：在无线网卡上拨号
            public UInt16 wHostPort;				// 远程主机 端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sHostIPAddr;		    // 远程主机 IP 地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HOST_NAMELEN)]
            public string sHostUser;		        // 远程主机 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HOST_PSWLEN)]
            public string sHostPassword;	        // 远程主机 密码
        };

        // 邮件配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MAIL_CFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sMailIPAddr;	    // 邮件服务器IP地址

            public UInt16 wMailPort;			// 邮件服务器端口
            public UInt16 wReserved;			// 保留

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sSenderAddr;	    // 发送地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string sUserName;			// 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string sUserPsw;			// 用户密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sDestAddr;		    // 目的地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sCcAddr;		    // 抄送地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sBccAddr;		    // 暗抄地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_SUBJECT_LEN)]
            public string sSubject;	        // 标题
        };

        // 网络配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_NET_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string sDevName;	            // 设备主机名

            public UInt16 wTcpMaxConnectNum;		// TCP最大连接数
            public UInt16 wTcpPort;				// TCP帧听端口
            public UInt16 wUdpPort;				// UDP侦听端口
            public UInt16 wHttpPort;				// HTTP端口号
            public UInt16 wHttpsPort;				// HTTPS端口号
            public UInt16 wSslPort;				// SSL端口号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ETHERNET_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ETHERNET[] stEtherNet;	            // 以太网口

            public ZLNET_REMOTE_HOST struAlarmHost;			// 报警服务器
            public ZLNET_REMOTE_HOST struLogHost;			// 日志服务器
            public ZLNET_REMOTE_HOST struSmtpHost;			// SMTP服务器
            public ZLNET_REMOTE_HOST struMultiCast;			// 多播组
            public ZLNET_REMOTE_HOST struNfs;				// NFS服务器
            public ZLNET_REMOTE_HOST struPppoe;				// PPPoE服务器

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sPppoeIP; // PPPoE注册返回的IP

            public ZLNET_REMOTE_HOST struDdns;				// DDNS服务器

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HOST_NAMELEN)]
            public string sDdnsHostName;	        // DDNS主机名

            public ZLNET_REMOTE_HOST struDns;				// DNS服务器
            public ZLNET_MAIL_CFG struMail;				// 邮件配置
        };

        // 网络配置结构体——扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_NET_CFG_EX
        {
            public ZLNET_DEV_NET_CFG pDevNetCfg;

            //能力管控
            public int MaxNetMonitor;  //网络监控。0表示禁止网传，0x7FFFFFFF表示无限制
            public int MaxDownload;	//录像下载
        };

        // 网络配置结构体——扩展2
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_NET_CFG_NEW_EX
        {
            public ZLNET_DEV_NET_CFG pDevNetCfg;

            //能力管控
            public int MaxNetMonitor;   //网络监控。0表示禁止网传，0x7FFFFFFF表示无限制
            public int MaxDownload;	    //录像下载
            public int bUpnpEnable;	    //upnp使能
            public int nRtspPort;	    //RTSP端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I4)]
            public int[] Res;		        //保留
        };

        //RTSP配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_URL
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string url;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_RTSP_CONFIG
        {
            public int nSize;				//结构体大小
            public int nValidNum;			//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_RTSP_URL_MAX_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_URL[] chRstpUrl;		    //RTSP URL

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;				//保留
        };

        // 多ddns配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DDNS_SERVER_CFG
        {
            public uint dwId;					// ddns服务器id号
            public int bEnable;				// 使能，同一时间只能有一个ddns服务器处于使能状态

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVER_TYPE_LEN)]
            public string szServerType;	        // 服务器类型，希网..

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string szServerIp;		        // 服务器ip或者域名

            public uint dwServerPort;			// 服务器端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string szDomainName;	        // dvr域名，如jeckean.3322.org

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HOST_NAMELEN)]
            public string szUserName;			    // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HOST_PSWLEN)]
            public string szUserPsw;			    // 密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DDNS_ALIAS_LEN)]
            public string szAlias;			    // 服务器别名，如"ZL inter ddns"

            public uint dwAlivePeriod;			// DDNS 保活时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_MULTI_DDNS_CFG
        {
            public uint dwSize;
            public uint dwDdnsServerNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DDNS_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DDNS_SERVER_CFG[] struDdnsServer;
        };

        // 邮件配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MAIL_DEV_CFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string sMailIPAddr;	    // 邮件服务器地址(IP或者域名)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string sSubMailIPAddr;

            public UInt16 wMailPort;			// 邮件服务器端口
            public UInt16 wSubMailPort;
            public UInt16 wReserved;			// 保留

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sSenderAddr;	    // 发送地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_NAME_LEN)]
            public string sUserName;		    // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_NAME_LEN)]
            public string sUserPsw;		    // 用户密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sDestAddr;		    // 目的地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sCcAddr;		    // 抄送地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_ADDR_LEN)]
            public string sBccAddr;		    // 暗抄地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_MAIL_SUBJECT_LEN)]
            public string sSubject;	        // 标题

            public byte bEnable;		    // 使能0:false,	1:true
            public byte bSSLEnable;		    // SSL使能
            public UInt16 wSendInterval;	    // 发送时间间隔,[0,3600]秒
            public byte bAnonymous;		    // 匿名选项[0,1], 0表示FALSE,1表示TRUE.
            public byte bAttachEnable;	    // 附件使能[0,1], 0表示FALSE,1表示TRUE.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 154)]
            public byte[] reserved;
        };

        // DNS服务器配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DNS_DEV_CFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szPrimaryIp;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szSecondaryIp;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        // 录象下载策略配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_DOWNLOAD_STRATEGY_CFG
        {
            public uint dwSize;
            public int bEnable;				// TRUE：高速下载，FALSE：普通下载
        };

        // 网络传输策略配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_TRANSFER_STRATEGY_CFG
        {
            public uint dwSize;
            public int bEnable;
            public int iStrategy;				// 0：画质优先，1：流畅性优先，2：自动
        };

        // 设置登入时的相关参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PARAM
        {
            public int nWaittime;				// 等待超时时间(毫秒为单位)，为0默认5000ms

            //以下字段均已失效，所有操作的超时均统一使用nWaittime
            public int nConnectTime;			// 连接超时时间(毫秒为单位)，为0默认1500ms
            public int nConnectTryNum;			// 连接尝试次数，为0默认1次
            public int nSubConnectSpaceTime;	// 子连接之间的等待时间(毫秒为单位)，为0默认10ms
            public int nGetDevInfoTime;		// 获取设备信息超时时间，为0默认1000ms
            public int nConnectBufSize;		// 每个连接接收数据缓冲大小(字节为单位)，为0默认250*1024
            public int nGetConnInfoTime;		// 获取子连接信息超时时间(毫秒为单位)，为0默认1000ms
            public int nSearchRecordTime;      // 按时间查询录像文件的超时时间(毫秒为单位),为0默认为3000ms
            public int nsubDisconnetTime;      // 检测子链接断线等待时间(毫秒为单位)，为0默认为60000ms
            public byte byNetType;				// 网络类型, 0-LAN, 1-WAN
            public byte byPlaybackBufSize;      // 回放数据接收缓冲大小（M为单位），为0默认为4M

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byReserved1;            // 对齐

            public int nPicBufSize;            // 实时图片接收缓冲大小（字节为单位），为0默认为2*1024*1024

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] bReserved;			    // 保留字段
        };

        // 搜索类型，对应ZLNET_SearchDevices接口
        public enum ZLNET_SEARCH_MODE
        {
            ZL_MODE = 0,	//智领模式 端口6060(默认)
            DH_MODE,		//大华模式 端口5050
            ONVIF_MODE,		//ONVIF模式
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_UUID_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN - 16)]
            public string szUUID;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szDeviceName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_TCP_INFO
        {
            public int nPort;				// 端口
            public int nChn;				// 通道数量

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szSubmask;	        // 子网掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szGateway;	        // 网关

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MACADDR_LEN)]
            public string szMac;			    // MAC地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szDeviceType;		// 设备类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szSerial;			// 序列号
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_SEARCH_DEVICE
        {
            [FieldOffset(0)]
            public STRUCT_UUID_INFO stUuid;
            [FieldOffset(0)]
            public STRUCT_TCP_INFO stTcp;
        }

        // 对应ZLNET_SearchDevices接口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVICE_NET_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szIP;			        // IP

            public UNION_SEARCH_DEVICE unDeviceInfo;
            public byte bRegist;				// 是否反向注册信息
            public byte bIPCP;					// 是否IPCP设备
            public byte bFHK;					// 是否FHK设备
            public byte bOnvif;					// 是否是ONVIF设备

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] reverse;				// 预留
        };

        //-------------------------------报警属性---------------------------------

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_REC_TSECT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_REC_TSECT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_TSECT[] stRecTsect;
        }

        // 云台联动
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PTZ_LINK
        {
            public int iType;       // 0无联动 1联动预置点 2联动轮巡 3联动巡航
            public int iValue;      // 联动取值分别对应预置点号，巡航号等等
        };

        // 报警联动结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MSG_HANDLE
        {
            /* 消息处理方式，可以同时多种处理方式，包括
             * 0x00000001 - 报警上传
             * 0x00000002 - 联动录象
             * 0x00000004 - 云台联动
             * 0x00000008 - 发送邮件
             * 0x00000010 - 本地轮巡
             * 0x00000020 - 本地提示
             * 0x00000040 - 报警输出
             * 0x00000080 - Ftp上传
             * 0x00000100 - 蜂鸣
             * 0x00000200 - 语音提示
             * 0x00000400 - 抓图
             * 0x00000800 - 推送
             * 0x00001000 - 云存储
            */

            /* 当前报警所支持的处理方式，按位掩码表示 */
            public uint dwActionMask;

            /* 触发动作，按位掩码表示，具体动作所需要的参数在各自的配置中体现 */
            public uint dwActionFlag;

            /* 报警触发的输出通道，报警触发的输出，为1表示触发该输出 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARMOUT_NUM)]
            public Byte[] byRelAlarmOut;

            public uint dwDuration;				/* 报警持续时间 */

            /* 联动录象 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM)]
            public Byte[] byRecordChannel;        /* 报警触发的录象通道，为1表示触发该通道 */

            public uint dwRecLatch;				/* 录象持续时间 */

            /* 抓图通道 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM)]
            public Byte[] bySnap;
            /* 轮巡通道 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM)]
            public Byte[] byTour;

            /* 云台联动 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_PTZ_LINK[] struPtzLink;

            public uint dwEventLatch;			/* 联动开始延时时间，s为单位，范围是0~15，默认值是0 */
            /* 报警触发的无线输出通道，报警触发的输出，为1表示触发该输出 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARMOUT_NUM)]
            public Byte[] byRelWIAlarmOut;

            public Byte bMessageToNet;
            public Byte bMMSEn;                 /*短信报警使能*/
            public Byte bySnapshotTimes;        /*短信发送抓图张数 */
            public Byte bMatrixEn;				/*!< 矩阵使能 */
            public uint dwMatrix;				/*!< 矩阵掩码 */
            public Byte bLog;					/*!< 日志使能，目前只有在WTN动态检测中使用 */

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] Res;

            public uint dwBeepLatch;			//蜂鸣延时

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 96)]
            public Byte[] byReserved;
        };

        // 外部报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMIN_CFG
        {
            public Byte byAlarmType;			// 报警器类型，0：常闭，1：常开
            public Byte byAlarmEn;				// 报警使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;                 //NSP

            public ZLNET_MSG_HANDLE struHandle;				// 处理方式
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_MOTION_COL
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MOTION_COL)]
            public Byte[] byMotionCol;
        }

        // 动态检测报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MOTION_DETECT_CFG
        {
            public Byte byMotionEn;				// 动态检测报警使能
            public Byte byReserved;
            public UInt16 wSenseLevel;			// 灵敏度
            public UInt16 wMotionRow;				// 动态检测区域的行数
            public UInt16 wMotionCol;				// 动态检测区域的列数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MOTION_ROW, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_MOTION_COL[] byDetected;             // 检测区域，最多32*32块区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;	                //NSP

            public ZLNET_MSG_HANDLE struHandle;				//处理方式
        };

        // 视频丢失报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_LOST_CFG
        {
            public Byte byAlarmEn;				// 视频丢失报警使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;	                //NSP

            public ZLNET_MSG_HANDLE struHandle;				// 处理方式
        };

        // 图像遮挡报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BLIND_CFG
        {
            public Byte byBlindEnable;			// 使能
            public Byte byBlindLevel;			// 灵敏度1-6

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;	//NSP

            public ZLNET_MSG_HANDLE struHandle;				// 处理方式
        };

        // 硬盘消息(内部报警)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISK_ALARM_CFG
        {
            public Byte byNoDiskEn;				// 无硬盘时报警

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] byReserved_1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stNDSect; //NSP

            public ZLNET_MSG_HANDLE struNDHandle;			// 处理方式

            public Byte byLowCapEn;				// 硬盘低容量时报警
            public Byte byLowerLimit;			// 容量阀值，0-99

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved_2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stLCSect; //NSP

            public ZLNET_MSG_HANDLE struLCHandle;			// 处理方式

            public Byte byDiskErrEn;			// 硬盘故障报警
            public Byte bDiskNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved_3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stEDSect;               //NSP

            public ZLNET_MSG_HANDLE struEDHandle;			// 处理方式
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NETBROKEN_ALARM_CFG
        {
            public Byte byEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] byReserved;

            public ZLNET_MSG_HANDLE struHandle;
        };

        // 报警布防
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_ALARM_SCHEDULE
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARM_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARMIN_CFG[] struLocalAlmIn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARM_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARMIN_CFG[] struNetAlmIn;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_MOTION_DETECT_CFG[] struMotion;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEO_LOST_CFG[] struVideoLost;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_BLIND_CFG[] struBlind;

            public ZLNET_DISK_ALARM_CFG struDiskAlarm;
            public ZLNET_NETBROKEN_ALARM_CFG struNetBrokenAlarm;
        };

        // 报警解码器配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMDEC_CFG
        {
            public uint dwAddr;					    // 报警解码器地址
            public int bEnable;					// 报警解码器使能
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DECODER_OUT_SLOTS_MAX_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwOutSlots;	                // 现在只支持8个.

            public int nOutSlotNum;				// dwOutSlots数组有效元素个数.
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DECODER_IN_SLOTS_MAX_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_MSG_HANDLE[] struHandle;	                // 现在只支持8个.

            public int nMsgHandleNum;				// stuHandle数组有效元素个数.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
            public byte[] bReserved;
        };

        // 报警上传的配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMCENTER_UP_CFG
        {
            public Byte byEnable;			// 上传使能
            public Byte bReserverd;			// 保留
            public UInt16 wHostPort;			// 报警中心侦听端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sHostIPAddr;		// 报警中心IP

            public int nByTimeEn;			// 定时上传使能，可以用来向中心上传IP或域名等
            public int nUploadDay;			/* 设置上传日期
													    "Never = 0", "Everyday = 1", "Sunday = 2",
													    "Monday = 3", Tuesday = 4", "Wednesday = 5",
													    "Thursday = 6", "Friday = 7", "Saturday = 8"*/
            public int nUploadHour;		// 设置上传时间 ,[0~23]点

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300, ArraySubType = UnmanagedType.U4)]
            public uint[] dwReserved; 		// 保留待扩展。
        };

        // 全景切换报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PANORAMA_SWITCH_CFG
        {
            public int bEnable;			// 使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;			// 保留

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            public ZLNET_MSG_HANDLE struHandle;			// 报警联动
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_PANORAMA_SWITCH_CFG
        {
            public int nAlarmChnNum;			// 报警通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_PANORAMA_SWITCH_CFG[] stuPanoramaSwitch;
        };

        // 失去焦点报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LOST_FOCUS_CFG
        {
            public int bEnable;			// 使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;			// 保留

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            public ZLNET_MSG_HANDLE struHandle;			// 报警联动
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_LOST_FOCUS_CFG
        {
            public int nAlarmChnNum;			// 报警通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_LOST_FOCUS_CFG[] stuLostFocus;
        };

        // IP冲突检测报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_IP_COLLISION_CFG
        {
            public int bEnable;			// 使能
            public ZLNET_MSG_HANDLE struHandle;			// 报警联动

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;			// 保留
        };

        //网络通道异常配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_ALARM_CFG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] bEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_MSG_HANDLE[] struHandle;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300)]
            public Byte[] res;
        };

        //------------------------------多区域遮挡--------------------------------

        // 遮挡信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_COVER_ATTR
        {
            public ZLNET_RECT rcBlock;				// 覆盖的区域坐标
            public int nColor;					// 覆盖的颜色
            public Byte bBlockType;				// 覆盖方式；0：黑块，1：马赛克
            public Byte bEncode;				// 编码级遮挡；1：生效，0：不生效
            public Byte bPriview;				// 预览遮挡； 1：生效，0：不生效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 29)]
            public byte[] reserved;			    // 保留
        };

        // 多区域遮挡配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_VIDEOCOVER_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHAN_NAME_LEN)]
            public string szChannelName;          // 只读

            public Byte bTotalBlocks;			// 支持的遮挡块数
            public Byte bCoverCount;			// 已设置的遮挡块数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_COVER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEO_COVER_ATTR[] CoverBlock;             // 覆盖的区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
            public byte[] reserved;			    // 保留
        };

        ////////////////////////////////IPC产品支持////////////////////////////////

        // 配置无线网络信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_KEY
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string Key;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_KEYS
        {
            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_KEY[] szKeys;

            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szWPAKeys;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_WLAN_INFO
        {
            public int nEnable;				// 无线使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string szSSID;				    // SSID

            public int nLinkMode;				// 连接模式；0：auto，1：adhoc，2：Infrastructure
            public int nEncryption;			// 加密；0：off，2：WEP64bit，3：WEP128bit, 4:WPA-PSK-TKIP, 5: WPA-PSK-CCMP
            public int nKeyType;				// 0：Hex，1：ASCII
            public int nKeyID;					// 序号
            public UNION_KEYS unKeys;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        };

        // 选择使用某个无线设备
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_WLAN_DEVICE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string szSSID;

            public int nLinkMode;				// 连接模式；0：adhoc，1：Infrastructure
            public int nEncryption;			// 加密；0：off，2：WEP64bit，3：WEP128bit

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
            public byte[] reserved;
        };

        // 搜索到的无线设备列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_WLAN_DEVICE_LIST
        {
            public uint dwSize;
            public byte bWlanDevCount;			// 搜索到的无线设备个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_WLANDEVICE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_WLAN_DEVICE[] lstWlanDev;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
            public byte[] reserved;
        };

        // 主动注册参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_SERVER_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szServerIp;			    // 注册服务器IP

            public int nServerPort;			// 端口号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_REGISTER_SERVER
        {
            public uint dwSize;
            public Byte bServerNum;				// 支持的最大ip数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_REGISTER_SERVER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_SERVER_INFO[] lstServer;

            public Byte bEnable;				// 使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDeviceID;			    // 设备id

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 94)]
            public byte[] reserved;
        };

        // 摄像头属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_CAMERA_INFO
        {
            public Byte bBrightnessEn;			// 亮度可调；1：可，0：不可
            public Byte bContrastEn;			// 对比度可调
            public Byte bColorEn;				// 色度可调
            public Byte bGainEn;				// 增益可调
            public Byte bSaturationEn;			// 饱和度可调
            public Byte bBacklightEn;			// 背光补偿 0表示不支持背光补偿,1表示支持一级补偿（开,关），2表示支持两级补偿（关,高,低），3表示支持三级补偿（关,高,中,低）
            public Byte bExposureEn;			// 曝光选择:
            // 0:表示不支持曝光控制
            // 1:表示只支持自动曝光
            // n:曝光的等级数(1表示支持自动曝光 2~n表示支持的手动控制曝光的等级)
            public Byte bColorConvEn;			// 自动彩黑转换可调
            public Byte bAttrEn;				// 属性选项；1：可，0：不可
            public Byte bMirrorEn;				// 镜像；1：支持，0：不支持
            public Byte bFlipEn;				// 翻转；1：支持，0：不支持
            public Byte iWhiteBalance;			// 白平衡 2 支持情景模式， 1 支持白平衡 ，0 不支持
            public Byte iSignalFormatMask;		// 信号格式掩码，按位从低到高位分别为：0-Inside(内部输入) 1- BT656 2-720p 3-1080i  4-1080p  5-1080sF
            public Byte bRotate90;				//	90度旋转 0-不支持 1-支持
            public Byte bLimitedAutoExposure;   // 是否支持带时间上下限的自动曝光
            public Byte bCustomManualExposure;  // 是否支持用户自定义手动曝光时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
            public Byte[] bRev;				    // 保留
        };

        // 摄像头属性配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAMERA_CFG
        {
            public uint dwSize;
            public Byte bExposure;				// 曝光模式；取值范围取决于设备能力集：0-自动曝光，1-曝光等级1，2-曝光等级2…n-1最大曝光等级数 n带时间上下限的自动曝光 n+1自定义时间手动曝光 (n==bExposureEn）
            public Byte bBacklight;				// 背光补偿：背光补偿等级取值范围取决于设备能力集，0-关闭，1-背光补偿强度1，2-背光补偿强度2…n-最大背光补偿等级数
            public Byte bAutoColor2BW;			// 日/夜模式；2：开(黑白)，1：自动，0：关(彩色)
            public Byte bMirror;				// 镜像；1：开，0：关
            public Byte bFlip;					// 翻转；1：开，0：关
            public Byte bLensEn;				// 自动光圈功能能力: 1：支持；0 ：不支持
            public Byte bLensFunction;			// 自动光圈功能: 1:开启自动光圈；0: 关闭自动光圈
            public Byte bWhiteBalance;			// 白平衡 0:Disabled,1:Auto 2:sunny 3:cloudy 4:home 5:office 6:night
            public Byte bSignalFormat;			// 信号格式0-Inside(内部输入) 1- BT656 2-720p 3-1080i  4-1080p  5-1080sF
            public Byte bRotate90;				// 0-不旋转，1-顺时针90°，2-逆时针90°

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] reserved;               // 保留

            public float ExposureValue1;			// 自动曝光时间下限或者手动曝光自定义时间,毫秒为单位，取值0.1ms~80ms
            public float ExposureValue2;			// 自动曝光时间上限,毫秒为单位，取值0.1ms~80ms

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 108)]
            public byte[] bRev;				    // 保留
        };

        // (无线)红外报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_INFRARED_INFO
        {
            public int bEnable;				// 报警输入使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_ALARM_NAME)]
            public string szAlarmName;	        // 报警输入名称

            public int nAlarmInPattern;		// 报警器输入波形
            public int nAlarmOutPattern;		// 报警输出波形

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_ALARM_NAME)]
            public string szAlarmInAddress;       // 报警输入地址

            public int nSensorType;			// 外部设备传感器类型常开 or 常闭
            public int nDefendEfectTime;		// 布撤防延时时间，在此时间后该报警输入有效
            public int nDefendAreaType;		// 防区类型
            public int nAlarmSmoothTime;		// 报警平滑时间，即在此时间内如果只有一个报警输入连续输入两次则忽略掉后面一次

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            public ZLNET_MSG_HANDLE struHandle;				// 处理方式
        };

        // 无线遥控器配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WI_CONFIG_ROBOT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ALARM_MAX_NAME)]
            public string address;        // 遥控器地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ALARM_MAX_NAME)]
            public string name;	        // 遥控器名称

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;		// 保留字段
        };

        // 无线报警输出配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WI_CONFIG_ALARM_OUT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ALARM_MAX_NAME)]
            public string address;        // 报警输出地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ALARM_MAX_NAME)]
            public string name;	        // 报警输出名称

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;		// 保留字段
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_INFRARED_CFG
        {
            public uint dwSize;
            public byte bAlarmInNum;		// 无线报警输入数
            public byte bAlarmOutNum;		// 无线报警输出数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_WI_CONFIG_ALARM_OUT[] AlarmOutAddr;	    // 报警输出地址

            public byte bRobotNum;			// 遥控器个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_WI_CONFIG_ROBOT[] RobotAddr;			// 遥控器地址

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_INFRARED_INFO[] InfraredAlarm;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        // 新音频检测报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEW_SOUND_ALARM_STATE
        {
            public int channel;				// 报警通道号
            public int alarmType;				// 报警类型；0：音频值过低，1：音频值过高
            public uint volume;					// 音量值

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_NEW_SOUND_ALARM_STATE
        {
            public int channelcount;			// 报警的通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARM_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NEW_SOUND_ALARM_STATE[] SoundAlarmInfo;
        };

        // 抓图功能属性结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_QUERY_SNAP_INFO
        {
            public int nChannelNum;			// 通道号
            public uint dwVideoStandardMask;	// 分辨率(按位)，具体查看枚举CAPTURE_SIZE
            public int nFramesCount;			// Frequence[128]数组的有效长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] Frames;			        // 帧率(按数值)
            // -25：25秒1帧；-24：24秒1帧；-23：23秒1帧；-22：22秒1帧
            // ……
            // 0：无效；1：1秒1帧；2：1秒2帧；3：1秒3帧
            // 4：1秒4帧；5：1秒5帧；17：1秒17帧；18：1秒18帧
            // 19：1秒19帧；20：1秒20帧
            // ……
            // 25: 1秒25帧
            public int nSnapModeCount;			// SnapMode[16]数组的有效长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] SnapMode;			    // (按数值)0：定时触发抓图，1：手动触发抓图

            public int nPicFormatCount;		// Format[16]数组的有效长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] PictureFormat;		    // (按数值)0：BMP格式，1：JPG格式

            public int nPicQualityCount;		// Quality[32]数组的有效长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] PictureQuality;		    // 按数值
            // 100：图象质量100%；80:图象质量80%；60:图象质量60%
            // 50:图象质量50%；30:图象质量30%；10:图象质量10%
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] nReserved;			    // 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNAP_ATTR_EN
        {
            public int nChannelCount;			// 通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_QUERY_SNAP_INFO[] stuSnap;
        };

        // IP信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_IP
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string ip;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IPIFILTER_INFO
        {
            public uint dwIPNum;			// IP个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IPIFILTER_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_IP[] SZIP;               // IP

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] byReserve;			// 保留
        };

        // IP过滤配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_IPIFILTER_CFG
        {
            public uint dwSize;
            public uint dwEnable;				// 使能
            public uint dwType;					// 当前名单类型：0：白名单 1：黑名单（设备只能使一种名单生效，或者是白名单或者是黑名单）
            public ZLNET_IPIFILTER_INFO BannedIP;				// 黑名单
            public ZLNET_IPIFILTER_INFO TrustIP;				// 白名单

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] byReserve;			    // 保留
        };

        /*语音对讲编码配置*/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_TALK_ENCODE_CFG
        {
            public uint dwSize;
            public int nCompression;			// 压缩格式，枚举值，相见ZLNET_TALK_CODING_TYPE，请根据设备支持的语音对讲类型设置压缩格式。
            public int nMode;					// 编码模式，枚举值，为0时表示该压缩格式不支持编码模式。
            // 根据压缩格式可以设置对应的编码格式，如
            // AMR详见EM_ARM_ENCODE_MODE
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] byReserve;			    // 保留
        };

        // 以下是mobile功能相关
        // (事件触发多媒体彩信/短信发送)MMS配置结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_RECEIVER
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string rec;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_MMS_CFG
        {
            public uint dwSize;
            public uint dwEnable;				// 使能
            public uint dwReceiverNum;			// 短信接收者个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MMS_RECEIVER_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_RECEIVER[] SZReceiver;	            // 短信接收者，一般为手机号码

            public byte byType;					// 短信信息类型 0:MMS；1:SMS

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string SZTitle;			    // 短信信息标题

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 223)]
            public byte[] byReserve;			    // 保留
        };

        // (短信激活无线连接配置)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_SENDER
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string sed;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_SMSACTIVATION_CFG
        {
            public uint dwSize;
            public uint dwEnable;			// 使能
            public uint dwSenderNum;		// 短信发送者个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MMS_SMSACTIVATION_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_SENDER[] SZSender;	        // 短信发送者，一般为手机号码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] byReserve;			// 保留
        };

        // (拨号激活无线连接配置)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_CALLER
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string cal;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_DIALINACTIVATION_CFG
        {
            public uint dwSize;
            public uint dwEnable;			// 使能
            public uint dwCallerNum;		// 发送者个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MMS_DIALINACTIVATION_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_CALLER[] SZCaller;	        // 发送者, 一般为手机号码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] byReserve;			// 保留
        };
        // 以上是mobile功能相关

        // 无线网络信号强度结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_WIRELESS_RSS_INFO
        {
            public uint dwSize;
            public uint dwTDSCDMA;				// TD-SCDMA强度，范围：0－100
            public uint dwWCDMA;				// WCDMA强度，范围：0－100
            public uint dwCDMA1x;				// CDMA1x强度，范围：0－100
            public uint dwEDGE;					// EDGE强度，范围：0－100
            public uint dwEVDO;					// EVDO强度，范围：0－100
            public int nCurrentType;			// 当前类型
            // 0	设备不支持这一项
            // 1    TD_SCDMA
            // 2	WCDMA
            // 3	CDMA_1x
            // 4	EDGE
            // 5	EVDO
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 252)]
            public byte[] byReserve;			    // 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_SIP_CFG
        {
            public int bUnregOnBoot;		//Unregister on Reboot

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szAccoutName;		//Account Name

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szSIPServer;		//SIP Server

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szOutBoundProxy;	//Outbound Proxy

            public uint dwSIPUsrID;			//SIP User ID
            public uint dwAuthID;			//Authenticate ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szAuthPsw;			//Authenticate Password

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szSTUNServer;		//STUN Server

            public uint dwRegExp;			//Registration Expiration
            public uint dwLocalSIPPort;		//Local SIP Port
            public uint dwLocalRTPPort;		//Local RTP Port

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] bReserved;			//reserved
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_SIP_STATE
        {
            public int bOnline;		    //TRUE:online, FALSE:offline

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] bReserved;		    //保留
        };

        /***************************** 云台预制点配置 ***********************************/
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_POINTEANBLE
        {
            public byte bPoint;		//预制点的有效范围闭区间[1,80]，无效设置为0。
            public byte bEnable;	//是否有效,0无效，1有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] bReserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_POINTCFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szIP;	            // ip

            public int nPort;				// 端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_POINTEANBLE[] stuPointEnable;		// 预制点使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] bReserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_POINT_CFG
        {
            public int nSupportNum;		// 只读参数，设置的时候需要返回给sdk，表示支持的预制点数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_POINTCFG[] stuPointCfg;	    // 二维下标表示通道号。要设置的点数值放在前nSupportNum个下标里面。

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] bReserved;			// 保留
        };

        ////////////////////////////////车载DVR支持////////////////////////////////

        // GPS信息(车载设备)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GPS_Info
        {
            public ZLNET_TIME revTime;			    // 定位时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 50)]
            public string DvrSerial;			    // 设备序列号

            public double longitude;			    // 经度(单位是百万分之度，范围0-360度)
            public double latidude;			    // 纬度(单位是百万分之度，范围0-180度)
            public double height;				    // 高度(米)
            public double angle;					// 方向角(正北方向为原点，顺时针为正)
            public double speed;					// 速度(单位是海里，speed/1000*1.852公里/小时)
            public UInt16 starCount;				// 定位星数
            public int antennaState;			// 天线状态(true 好，false 坏)
            public int orientationState;		// 定位状态(true 定位，false 不定位)
        };

        // 抓图参数结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNAP_PARAMS
        {
            public uint Channel;				// 抓图的通道
            public uint Quality;				// 画质；1~6
            public uint ImageSize;				// 画面大小；0：QCIF，1：CIF，2：D1
            public uint mode;					// 抓图模式；0：表示请求一帧，1：表示定时发送请求，2：表示连续请求
            public uint InterSnap;				// 时间单位秒；mode=1且为车载设备时，此时间有效
            public uint CmdSerial;				// 请求序列号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U4)]
            public uint[] Reserved;
        };

        // 抓图功能配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNAP_DEV_CFG
        {
            public uint dwSize;
            public Byte bTimingEnable;			// 定时抓图开关(报警抓图开关在各报警联动配置中体现)
            public Byte bReserved;
            public Int16 PicTimeInterval;		// 定时抓图时间间隔，单位为秒,目前设备支持最大的抓图时间间隔为30分钟

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_SNAP_TYPE.ZLNET_SNAP_TYP_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOENC_OPT[] struSnapEnc;            // 抓图编码配置，现支持其中的分辨率、画质、帧率设置，帧率在这里是负数，表示一秒抓图的次数。
        };

        //////////////////////////////////ATM支持//////////////////////////////////

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNIFFER_FRAMEID
        {
            public int Offset;			// 标志位的位偏移
            public int Length;			// 标志位的长度

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string Key;			// 标志位的值
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNIFFER_CONTENT
        {
            public int Offset;			// 标志位的位偏移
            public int Offset2;		// 目前没有应用
            public int Length;			// 标志位的长度
            public int Length2;		// 目前没有应用

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 24)]
            public string KeyTitle;		// 标题的值
        };

        // 网络抓包配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNIFFER_FRAME
        {
            public ZLNET_SNIFFER_FRAMEID snifferFrameId;			// 每个FRAME ID 选项

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_SNIFFER_CONTENT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SNIFFER_CONTENT[] snifferContent;	        // 每个FRAME对应的4个抓包内容
        };

        // 每组抓包对应的配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ATM_SNIFFER_CFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string SnifferSrcIP;	    // 抓包源地址

            public int SnifferSrcPort;		// 抓包源端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string SnifferDestIP;	    // 抓包目标地址

            public int SnifferDestPort;	// 抓包目标端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public byte[] reserved;			// 保留字段

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_SNIFFER_FRAMEID_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SNIFFER_FRAME[] snifferFrame;	    // 6个FRAME 选项

            public int displayPosition;	// 显示位置
            public int recdChannelMask;	// 通道掩码
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNIFFER_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ATM_SNIFFER_CFG[] SnifferConfig;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;			// 保留字段
        };

        // 网络抓包配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNIFFER_FRAME_EX
        {
            public ZLNET_SNIFFER_FRAMEID snifferFrameId;			// 每个FRAME ID 选项

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_SNIFFER_CONTENT_NUM_EX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SNIFFER_CONTENT[] snifferContent;	        // 每个FRAME对应的8个抓包内容
        };

        // 每组抓包对应的配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ATM_SNIFFER_CFG_EX
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string SnifferSrcIP;			// 抓包源地址

            public int SnifferSrcPort;			// 抓包源端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string SnifferDestIP;			// 抓包目标地址

            public int SnifferDestPort;		// 抓包目标端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_SNIFFER_FRAMEID_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SNIFFER_FRAME_EX[] snifferFrame;		    // 6个FRAME 选项

            public int displayPosition;		// 显示位置
            public int recdChannelMask;		// 通道掩码
            public int bDateScopeEnable;		// 数据来源使能
            public int bProtocolEnable;		// 协议使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SNIFFER_PROTOCOL_SIZE)]
            public string szProtocolName;		    // 协议名字

            public int nSnifferMode;			// 抓包方式，0:net,1:232.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_TRADE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_ATM_MAX_TRADE_TYPE_NAME)]
            public string szTrade;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ATM_QUERY_TRADE
        {
            public int nTradeTypeNum;				// 实际交易类型数量
            public int nExceptionTypeNum;			// 实际异常事件数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_ATM_MAX_TRADE_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_TRADE[] szSupportTradeType;         // 交易事件名数组

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_ATM_MAX_TRADE_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_TRADE[] szSupportExceptionType;     // 异常事件名数组
        };

        /////////////////////////////////解码器支持/////////////////////////////////

        //设备接入协议枚举
        public enum ZLNET_PROTOCOL_TYPE
        {
            ZLNET_PROTOCOL_TYPE_ZL = 0,		//ZL
            ZLNET_PROTOCOL_TYPE_DH,			//大华
            ZLNET_PROTOCOL_TYPE_ONVIF,		//ONVIF协议
            ZLNET_PROTOCOL_TYPE_RTSP,       //RTSP

            ZLNET_PROTOCOL_TYPE_LOCAL = 100,    //本地通道
        };

        //解码器分割模式
        public enum ZLNET_DEC_SPLIT_MODE
        {
            ZLNET_DECODER_SPLIT_INVALID = 0,	//无效值

            ZLNET_DECODER_SPLIT_1 = 1,			//1分割即全屏
            ZLNET_DECODER_SPLIT_4,				//4
            ZLNET_DECODER_SPLIT_6,				//6
            ZLNET_DECODER_SPLIT_7,				//7
            ZLNET_DECODER_SPLIT_8,				//8
            ZLNET_DECODER_SPLIT_9,				//9
            ZLNET_DECODER_SPLIT_10,				//10
            ZLNET_DECODER_SPLIT_12,				//12
            ZLNET_DECODER_SPLIT_13,				//13
            ZLNET_DECODER_SPLIT_16,				//16
            ZLNET_DECODER_SPLIT_20,				//20
            ZLNET_DECODER_SPLIT_25,				//25
            ZLNET_DECODER_SPLIT_36,				//36
        };

        //解码器能力
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DECODER_CAP
        {
            public int nScreen;			//输出屏幕数
            public int nSplitModeNum;		//nSplitMode有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DEC_MAX_SPLIT_MODE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEC_SPLIT_MODE[] nSplitMode;		    //支持的分割模式

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //分辨率
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RESOLUTION
        {
            public int nWidth;
            public int nHight;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //解码器工作模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DECODER_MODE
        {
            public ZLNET_DEC_SPLIT_MODE nSplitMode;		//分割情况
            public int nGroupNum;		//组号 从0开始 与分割情况一起实现画面切换

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_DEVICE_INFO
        {
            public ZLNET_PROTOCOL_TYPE nProtocol;		//接入协议

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szIP;			//码流源的设备IP

            public int nPort;			//码流源的设备端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string szUser;	        //码流源的用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_LENGTH_EX)]
            public string szPasswd;	    //码流源的密码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_VIDEO_INFO
        {
            [FieldOffset(0)]
            public ZLNET_DEC_DEVICE_INFO devInfo;        //nMode为ZLNET_DEC_MODE_CONDEV时有效

            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szURL;		    //nMode为ZLNET_DEC_MODE_RTSP时有效

            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            public byte[] szRes;		    //预留
        };

        //上墙模式
        public enum ZLNET_DEC_VIDEO_MODE
        {
            ZLNET_DEC_MODE_CONDEV = 0,	//直连设备
            ZLNET_DEC_MODE_RTSP,		//RTSP
            ZLNET_DEC_MODE_LOCAL,		//解码器本地
        };

        //上墙视频
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_VIDEO_INFO
        {
            public ZLNET_DEC_VIDEO_MODE nMode;				//模式

            public int nChannel;			//码流源的通道号
            public int nStreamType;		//0主码流，1辅码流1, 2辅码流2
            public int nPlayTime;			//播放时间，秒，0代表不轮巡

            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            //public byte[]                   szRes;

            public UNION_VIDEO_INFO unVideoInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szReserve;			//保留字段
        };

        //解码器单窗口控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_VIDEO_WINDOW
        {
            public int nWndIndex;		//窗口号
            public int nInfoNum;		//数组videoInfo的有效元素数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DEC_MAX_VIDEOLIST, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEC_VIDEO_INFO[] videoInfo;	    //播放队列，n个码流源

            public int nTrigType;		//控制类型：0普通 1报警

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 124)]
            public byte[] szRes;		//预留
        };

        //解码器多窗口控制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_VIDEO_SCREEN
        {
            public int nInfoNum;		//数组wndInfo的有效元素数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DEC_MAX_SPLITNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEC_VIDEO_WINDOW[] wndInfo;	    //每个窗口的码流源，如果超出当前分割数，解码器自动增加分割

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;	        //预留
        };

        // 解码器回放控制类型
        public enum ZLNET_DEC_CTRL_PLAYBACK_TYPE
        {
            ZLNET_Dec_Playback_Play = 0,							// 播放
            ZLNET_Dec_Playback_Seek,								// 拖动
            ZLNET_Dec_Playback_Pause,								// 暂停
            ZLNET_Dec_Playback_Stop,								// 停止
        };

        // 按文件回放上墙
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_PLAYBACK_FILE_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szDevIp;		        // 前端DVR的IP地址

            public UInt16 wDevPort;				// 前端DVR的端口号
            public byte bDevChnEnable;          // 解码通道使能
            public byte byEncoderID;			// 对应解码通道号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string szDevUser;	            // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_LENGTH_EX)]
            public string szDevPwd;		        // 密码

            public ZLNET_RECORDFILE_INFO stuRecordInfo;	// 录像文件信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        };

        // 按时间回放上墙
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEC_PLAYBACK_TIME_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szDevIp;			// 前端DVR的IP地址

            public UInt16 wDevPort;			// 前端DVR的端口号
            public byte bDevChnEnable;		// 解码通道使能
            public byte byEncoderID;		// 对应解码通道号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string szDevUser;	        // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_LENGTH_EX)]
            public string szDevPwd;		    // 密码

            public int nChannelID;
            public ZLNET_TIME startTime;
            public ZLNET_TIME endTime;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
            public byte[] reserved;
        };

        /////////////////////////////////特殊版本/////////////////////////////////

        // 触发设备抓图，叠加卡号信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNAP_COMMANDINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szCardInfo;			// 卡号信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;			// 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_USE_CHANNEL_STATE
        {
            public int nChannelNum;		// 通道号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szUseType;			// 通道用途

            public uint dwStreamSize;		// 流量大小(单位：kb/s)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;			// 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_USER_NET_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szUserName;			    // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szUserGroup;		    // 用户组

            public ZLNET_TIME time;					// 登入时间
            public int nOpenedChannelNum;		// 开启的通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_USE_CHANNEL_STATE[] channelInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;
        };

        // 网络运行状态信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_TOTAL_NET_STATE
        {
            public int nUserCount;				// 用户数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_USER_NET_INFO[] stuUserInfo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        // 图象水印配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WATERMAKE_CFG_DEV
        {
            public uint dwSize;
            public int nEnable;		    // 使能
            public int nStream;		    // 码流(1～n)0-所有码流
            public int nKey;				// 数据类型(1-文字，2-图片)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_WATERMAKE_LETTER)]
            public string zLetterData;	    //	文字

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_WATERMAKE_DATA)]
            public string szData;             // 图片数据

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public Byte[] bReserved;			// 保留
        };

        // 存储位置设置结构体，每通道独立设置,每通道可以选择各种存储类型, 目前包括本地, 可移动, 远程存储.
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_STORAGE_STATION_CFG
        {
            public uint dwSize;
            public uint dwLocalMask;			    // 本地存储掩码；按位表示：
            // 第一位：系统预录，第二位：定时录像，第三位：动检录像，
            // 第四位：报警录像，第五位：卡号录像，第六位：手动录像
            public uint dwMobileMask;			    // 可移动存储掩码 存储掩码如本地存储掩码
            public int RemoteType;				    // 远程存储类型 0: Ftp  1: Smb
            public uint dwRemoteMask;			    // 远程存储掩码 存储掩码如本地存储掩码
            public uint dwRemoteSecondSelLocal;	    // 远程异常时本地存储掩码
            public uint dwRemoteSecondSelMobile;    // 远程异常时可移动存储掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PATH_STOR)]
            public string SubRemotePath;              // 远程目录, 其中长度为240

            public uint dwFunctionMask;			    //功能屏蔽位，按位表示，bit0 = 1:屏蔽抓图事件触发存储位置功能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 124)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_DECODER
        {
            public uint dwAlarmDecoder;			// 现在最多支持8个报警输入口，留8位待以后扩展
            public byte bDecoderIndex;			// 表示第几个报警解码器

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] bReserved;
        };

        // 报警解码器报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_DECODER_ALARM_DEV
        {
            public int nAlarmDecoderNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARM_DECODER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARM_DECODER[] stuAlarmDecoder;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bReserved;
        };

        //DSP报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DSP_ALARM
        {
            public int bError;			//0,DSP正常 1,DSP异常
            public uint dwErrorMask;	//按位表示，非0表示有此错误，0表示没有。(目前每次报警只有一位有效)
            //bit		DSP报警
            //1			DSP加载失败
            //2			DSP错误
            //3			制式不对
            //4			分辨率不支持
            //5			数据格式不支持
            //6			找不到I帧
            public uint dwDecChnnelMask;//按位表示，报警的解码通道号，dwErrorMask为DSP错误，制式不对，分辨率不支持，数据格式不支持时此项有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public byte[] bReserved;
        };

        // 光纤编码能力报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_FDDI_ALARM
        {
            public int nFDDINum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] bAlarm;
        };

        // 新音频检测报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUDIO_DETECT_INFO
        {
            public int bEnable;			// 报警输入使能
            public int Volume_min;			// 音量的最小值
            public int Volume_max;			// 音量的最大值

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;

            public ZLNET_MSG_HANDLE struHandle;			// 处理方式
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUDIO_DETECT_CFG
        {
            public uint dwSize;
            public int AlarmNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_AUDIO_IN_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_AUDIO_DETECT_INFO[] AudioDetectAlarm;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOGROUP_CFG
        {
            public int bTourEnable;			// 轮巡使能
            public int nTourPeriod;			// 轮巡间隔，单位秒, 5-300
            public uint dwChannelMask;			// 轮巡的通道，掩码形式表示

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] reserved;
        };

        // 本机矩阵控制策略配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_VIDEO_MATRIX_CFG
        {
            public uint dwSize;
            public int nMatrixNum;				// 矩阵个数(注：不允许修改)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MATRIX_MAXOUT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOGROUP_CFG[] struVideoGroup;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };

        // WEB路径配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_URL_CFG
        {
            public uint dwSize;
            public int bSnapEnable;			// 是否抓图
            public int iSnapInterval;			// 抓图周期

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szHostIp;               // HTTP主机IP

            public UInt16 wHostPort;
            public int iMsgInterval;			// 状态消息发送间隔

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szUrlState;	            // 状态消息上传URL

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szUrlImage;	            // 图片上传Url

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DEV_ID_LEN)]
            public string szDevId;	            // 机器的web编号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byReserved;
        };

        // OEM查询
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_OEM_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szVendor;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szType;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reserved;
        };

        //视频OSD叠加配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DVR_VIDEO_WIDGET
        {
            public uint rgbaFrontground;		// 物件的前景；按字节表示，分别为红、绿、蓝和透明度
            public uint rgbaBackground;			// 物件的背景；按字节表示，分别为红、绿、蓝和透明度
            public ZLNET_RECT rcRelativePos;		    // 位置,物件边距与整长的比例*8191
            public int bPreviewBlend;			// 预览叠加使能
            public int bEncodeBlend;			// 编码叠加使能
            public Byte bFontSize;				// 字体大小 1小 2中 3大

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public Byte[] bReserved;              // 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DVR_VIDEOITEM
        {
            public ZLNET_DVR_VIDEO_WIDGET StOSD_POS; 			// OSD叠加的位置和背景色

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VIDEO_OSD_NAME_NUM)]
            public string SzOSD_Name; 		// OSD叠加的名称
        };

        // 每个通道的OSD信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DVR_VIDEOOSD_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_VIDEO_CUSTOM_OSD_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DVR_VIDEOITEM[] StOSDTitleOpt; 	            // 每个通道的OSD信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public Byte[] bReserved;                  // 保留
        };

        // 配置CDMA/GPRS网络信息
        // 时间段结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_3G_TIMESECT
        {
            public byte bEnable;				  // 时间段使能，1表示该时间段有效，0表示该时间段无效。
            public byte bBeginHour;
            public byte bBeginMin;
            public byte bBeginSec;
            public byte bEndHour;
            public byte bEndMin;
            public byte bEndSec;
            public byte bReserved;                //保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_3G_TIMESECT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_TSECT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_3G_TIMESECT st3GTime;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CDMAGPRS_CFG_DEV
        {
            public uint dwSize;
            public int bEnable;					// 无线模块使能标志
            public uint dwTypeMask;                 // 设备支持网络类型掩码;按位表示,第一位;自动选择;
            // 第二位：TD-SCDMA网络；第三位：WCDMA网络;
            // 第四位：CDMA 1.x网络;第五位：CDMA2000网络;第六位：GPRS网络;
            // 第七位：EVDO网络;第八位：WIFI
            public uint dwNetType;                  // 当前的无线网络类型，为ZLNET_GPRSCDMA_NETWORK_TYPE值

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szAPN;					    // 接入点名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szDialNum;				    // 拨号号码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szUserName;			        // 拨号用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szPWD;					    // 拨号密码

            /* 下面是设备的只读部分 */
            public int iAccessStat;				// 无线网络注册状态

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szDevIP;				    // 前端设备拨号IP，字符串, 包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szSubNetMask;			    // 前端设备拨号子网掩码，字符串, 包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szGateWay;				    // 前端设备拨号网关，字符串, 包括'\0'结束符共16byte

            /* 上面是设备的只读部分 */
            public int iKeepLive;					// 保活时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_3G_TIMESECT[] stSect;                     // 3G拨号时间段，有效时间段之内，开启拨号；有效时间段之外，关闭拨号。

            public byte byActivate;                 //是否需要被语音或短信激活

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 171)]
            public byte[] Reserved;				    // 保留字节，用于扩展
        };

        // 录像打包长度配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RECORD_PACKET_CFG_DEV
        {
            public uint dwSize;
            public int nType;			// 0:按时间，1：按大小
            public int nValue;			// nType = 0时:单位分钟，nType = 1时:单位KB

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] Reserved;		// 保留字节，用于扩展
        };

        // (定向)主动注册服务器信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_AUTOREGISTER_INFO
        {
            public int lConnectionID;			// 连接ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szServerIp;	            // 主动注册服务器的IP

            public int nPort;					// 主动注册服务器端口0- 65535
            public int nState;                 // 服务器的状态：0－注册失败；1-注册成功; 2-连接失败

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserved;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_SERVER_AUTOREGISTER
        {
            public uint dwSize;
            public int nRegisterSeverCount;		// 主动注册服务器个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_CONTROL_AUTO_REGISTER_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DEV_AUTOREGISTER_INFO[] stuDevRegisterSeverInfo;	// 各主动注册服务器信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] reserved;
        };

        // 附件刻录附件上传
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_BURNFILE_TRANS_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PATH_STOR)]
            public string szSourFile;	        // 源文件路径

            public int nFileSize;			// 源文件大小，如果小于等于0，sdk自行计算文件大小.

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PATH_STOR)]
            public string szBurnFile;	        // 刻录后的文件名

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] bReserved;
        };

        // 郑州威科姆EC_U视频数据叠加使能配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OSD_ENABLE_CFG_DEV
        {
            public int bEnable;			// 使能
            public int nPort;				// 端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] bReserved;
        };

        // 车载相关配置:北京公交使用配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ABOUT_VEHICLE_CFG_DEV
        {
            public int bAutoBootEnable;				//自动开机使能
            public uint dwAutoBootTime;					//每天自动开机时间点, 单位秒,从0算起.[0,82800]
            public int bAutoShutDownEnable;			//自动关机使能
            public uint dwAutoShutDownTime;				//每天自动关机时间点, 单位秒,从0算起.[0,82800]
            public uint dwShutDownDelayTime;			//延时关机时间,单位秒.
            public byte bEventNoDisk;					//1,(Ignore:忽略); 2,(Reboot:重起系统)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 511)]
            public byte[] bReserved;					    //reserved byte.
        };

        // atm:查询叠加相关能力信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_PRO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
            public string pro;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_ATM_OVERLAY_GENERAL
        {
            public uint dwDataSource;			//1:Net(网络), 2:Com(串口), 3:Net&Com(网络和串口)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_PRO[] szProtocol;				//协议名字,最大长度32(保留一个结束符).

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] bReserved;
        };

        // atm:配置叠加设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_ATM_OVERLAY_CONFIG
        {
            public uint dwDataSource;			//1:Net(网络), 2:Com(串口)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
            public string szProtocol;				//协议名字，由ZLNET_DEV_ATM_OVERLAY_GENERAL返回

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] bReserved_1;

            public uint dwChannelMask;			//叠加的通道号，掩码表示。
            public byte bMode;					//1:Preview(预览叠加), 2:Encode(编码叠加), 3:Preview&Encode(预览和编码叠加)
            public byte bLocation;				//1:LeftTop(左上), 2:LeftBottom(左下), 3:RightTop(右上), 4:RightBottom(右下)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 258)]
            public byte[] bReserved_2;
        };

        // 备份设备列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_BACKUP
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_NAME)]
            public string szBackup;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_BACKUP_LIST
        {
            public int nBackupDevNum;			// 实际的备份设备数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_BACKUPDEV_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_BACKUP[] szBackupDevNames;       // 备份设备的名称
        };

        // 备份设备介质类型
        public enum ZLNET_DEV_BACKUP_TYPE
        {
            ZLNET_BT_ZLFS = 0,							// 智诺文件系统
            ZLNET_BT_DISK,								// 移动硬盘
            ZLNET_BT_CDRW								// 光盘刻录
        };

        //跨网段指令类型
        public enum ZlNET_OVERNET_COMMAND
        {
            ZLNET_OVERNET_LOGIN = 0,
            ZLNET_OVERNET_GETINFO,
            ZLNET_OVERNET_SETINFO
        };

        //跨网段登录参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OVERNET_LOGINPARAM
        {
            public int nSize;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
            public string szMac;	        //MAC地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
            public string szHostName;	    //主机名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szUserName;     //用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szPassWord;	    //密码

            public int nRet;           //操作结果
            public int nErr;           //错误码
        };

        //跨网段查询结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OVERNET_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
            public string Version;            // 8字节的版本信息

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string HostName;           // 主机名

            public uint HostIP;             // IP 地址
            public uint Submask;            // 子网掩码
            public uint GateWayIP;          // 网关 IP
            public uint DNSIP;              // DNS IP

            // 外部接口
            public uint AlarmServerIP;      // 报警中心IP
            public UInt16 AlarmServerPort;    // 报警中心端口
            public uint SMTPServerIP;       // SMTP server IP
            public UInt16 SMTPServerPort;     // SMTP server port
            public uint LogServerIP;        // Log server IP
            public UInt16 LogServerPort;      // Log server port

            // 本机服务端口
            public UInt16 HttpPort;           // HTTP服务端口号
            public UInt16 HttpsPort;          // HTTPS服务端口号
            public UInt16 TCPPort;            // TCP 侦听端口
            public UInt16 TCPMaxConn;         // TCP 最大连接数
            public UInt16 SSLPort;            // SSL 侦听端口
            public UInt16 UDPPort;            // UDP 侦听端口
            public uint McastIP;            // 组播IP
            public UInt16 McastPort;          // 组播端口

            // 其他
            public byte MonMode;            // 监视协议 0-TCP, 1-UDP, 2-MCAST //待确定1-TCP
            public byte PlayMode;           // 回放协议 0-TCP, 1-UDP, 2-MCAST//待确定1-TCP
            public byte AlmSvrStat;         // 报警中心状态 0-关闭, 1-打开

            public int MaxNetMonitor;      //网络监控。0表示禁止网传，0x7FFFFFFF表示无限制
            public int MaxDownload;        //录像下载
            public int bUpnpEnable;        //upnp
            public int RtspPort;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.I4)]
            public int[] Res;                //保留

        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OVERNET_PARAM
        {
            public ZLNET_OVERNET_LOGINPARAM stlog;
            public ZLNET_OVERNET_INFO stInfo;
        };

        // 备份设备接口类型
        public enum ZLNET_DEV_BACKUP_BUS
        {
            ZLNET_BB_USB = 0,		// usb接口
            ZLNET_BB_1394,			// 1394接口
            ZLNET_BB_IDE,			// ide接口
            ZLNET_BB_ESATA,			// esata接口
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_BACKUP_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szName;						// 设备名

            public byte byType;						// 备份设备的介质类型 枚举值见BACKUP_TYPE
            public byte byBus;						// 备份设备的接口类型 枚举值见BACKUP_BUS
            public uint nCapability;				// 总容量, 以kBytes为单位
            public uint nRemain;					// 剩余容量,以kBytes为单位

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szDirectory;				// 远程备份的目录
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_BACKUP_FEEDBACK
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szName;				// 设备名

            public uint nCapability;		// 总容量, 以kBytes为单位
            public uint nRemain;			// 当前备份剩余容量,以kBytes为单位
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BACKUP_RECORD
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_NAME)]
            public string szDeviceName;		//备份设备名称

            public int nRecordNum;			//备份记录数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_BACKUPRECORD_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_RECORDFILE_INFO[] stuRecordInfo;		//备份记录信息
        };

        /////////////////////////////////平台接入/////////////////////////////////

        // 平台接入配置 － U网通
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_INTERVIDEO_UCOM_CHN_CFG
        {
            public int bChnEn;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_UCOM_CHANID)]
            public string szChnId;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_INTERVIDEO_UCOM_CFG
        {
            public uint dwSize;
            public int bFuncEnable;			// 接入功能使能
            public int bAliveEnable;			// 心跳使能
            public uint dwAlivePeriod;			// 心跳周期，单位秒，0-3600

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szServerIp;             // CMS的IP

            public UInt16 wServerPort;			// CMS的Port

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_UCOM_REGPSW)]
            public string szRegPwd;               // 注册密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_UCOM_DEVID)]
            public string szDeviceId;             // 设备id

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_UCOM_USERNAME)]
            public string szUserName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_UCOM_USERPSW)]
            public string szPassWord;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_INTERVIDEO_UCOM_CHN_CFG[] struChnInfo;            // 通道id,en
        };

        // 平台接入配置 － 阿尔卡特
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_INTERVIDEO_BELL_CFG
        {
            public uint dwSize;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usCompanyID;			    // 公司ID，数值，不同的第三方服务公司，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDeviceNO;			        // 前端设备序列号，字符串，包括'\0'结束符共32byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szVSName;			        // 前端设备名称，字符串，包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szVapPath;			        // VAP路径

            public UInt16 usTcpPort;				    // TCP端口，数值：数值 1~65535
            public UInt16 usUdpPort;				    // UDP端口，数值：数值 1~65535

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public bool[] bCsEnable;			        // 中心服务器使能标志，数值：true使能，false不使能，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szCsIP;				        // 中心服务器IP地址，字符串，包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usCsPort;			        // 中心服务器端口，数值：数值 1~65535，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public bool[] bHsEnable;			        // 心跳服务器使能标志，数值：true使能，false不使能，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szHsIP;				        // 心跳服务器IP地址，字符串，包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usHsPort;			        // 心跳服务器端口，数值：数值 1~65535，考虑4字节对齐，目前只用数组第一个

            public int iHsIntervalTime;		    // 心跳服务器间隔周期，数值(单位:秒)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public bool[] bRsEnable;			        // 注册服务器使能标志，数值：true使能，false不使能，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szRsIP;				        // 注册服务器IP地址，字符串，包括'\0'结束符共16byte

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usRsPort;			        // 注册服务器端口，数值：数值 1~65535，考虑4字节对齐，目前只用数组第一个

            public int iRsAgedTime;			    // 注册服务器有效时间，数值(单位:小时)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szAuthorizeServerIp;        // 鉴权服务器IP

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usAuthorizePort;		    // 鉴权服务器端口，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szAuthorizeUsername;        // 鉴权服务器帐号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string szAuthorizePassword;        // 鉴权服务器密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string szIpACS;			        // ACS(自动注册服务器) IP

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.U2)]
            public UInt16[] usPortACS;			        // ACS Port，考虑4字节对齐，目前只用数组第一个

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szUsernameACS;		        // ACS用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string szPasswordACS;		        // ACS密码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I1)]
            public bool[] bVideoMonitorEnabled;       // DVS是否定期上报前端视频信号监控信息，数值：true使能，false不使能

            public int iVideoMonitorInterval;	    // 上报周期(分钟)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szCoordinateGPS;	        // GPS坐标

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szPosition;			        // 设备位置

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
            public string szConnPass;			        // 设备接入码
        };

        // 平台接入配置 － 中兴力维
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_INTERVIDEO_NSS_CFG
        {
            public uint dwSize;
            public UInt16 nSevPort;		// 服务器端口，数值，数值1~65535

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_NSS_IP)]
            public string szSevIp;        // 服务器IP地址，字符串，包括'\0'结束符共32byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_NSS_SERIAL)]
            public string szDevSerial;    // 前端设备序列号，字符串，包括'\0'结束符共32byte

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_NSS_USER)]
            public string szUserName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_NSS_PWD)]
            public string szPwd;
        };

        //平台接入配置 － 明软
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MR_SYSTEM_CONFIG
        {
            public uint serverip;
            public int serverport;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_MR_ID)]
            public string szDevID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_MR_USERPSW)]
            public string DVRUserName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_INTERVIDEO_MR_USERPSW)]
            public string DVRPassword;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_INTERVIDEO_MR_CFG
        {
            public int Enable;				//使能标志, 数值, 1 使能, 0 不使能.
            public ZLNET_MR_SYSTEM_CONFIG JFSysConfig;
        };

        ////////////////////////////////HDVR专用//////////////////////////////////
        // 报警联动扩展结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MSG_HANDLE_EX
        {
            /* 消息处理方式，可以同时多种处理方式，包括
             * 0x00000001 - 报警上传
             * 0x00000002 - 联动录象
             * 0x00000004 - 云台联动
             * 0x00000008 - 发送邮件
             * 0x00000010 - 本地轮巡
             * 0x00000020 - 本地提示
             * 0x00000040 - 报警输出
             * 0x00000080 - Ftp上传
             * 0x00000100 - 蜂鸣
             * 0x00000200 - 语音提示
             * 0x00000400 - 抓图
             * 0x00000800 - 推送
             * 0x00001000 - 云存储
            */

            /* 当前报警所支持的处理方式，按位掩码表示 */
            public uint dwActionMask;

            /* 触发动作，按位掩码表示，具体动作所需要的参数在各自的配置中体现 */
            public uint dwActionFlag;

            /* 报警触发的输出通道，报警触发的输出，为1表示触发该输出 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARMOUT_NUM_EX)]
            public Byte[] byRelAlarmOut;

            public uint dwDuration;				/* 报警持续时间 */

            /* 联动录象 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM_EX)]
            public Byte[] byRecordChannel;        /* 报警触发的录象通道，为1表示触发该通道 */

            public uint dwRecLatch;				/* 录象持续时间 */

            /* 抓图通道 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM_EX)]
            public Byte[] bySnap;
            /* 轮巡通道 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM_EX)]
            public Byte byTour;

            /* 云台联动 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_VIDEO_IN_NUM_EX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_PTZ_LINK[] struPtzLink;

            public uint dwEventLatch;			/* 联动开始延时时间，s为单位，范围是0~15，默认值是0 */
            /* 报警触发的无线输出通道，报警触发的输出，为1表示触发该输出 */
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARMOUT_NUM_EX)]
            public Byte[] byRelWIAlarmOut;

            public Byte bMessageToNet;
            public Byte bMMSEn;                 /*短信报警使能*/
            public Byte bySnapshotTimes;        /*短信发送抓图张数 */
            public Byte bMatrixEn;				/*!< 矩阵使能 */
            public uint dwMatrix;				/*!< 矩阵掩码 */
            public Byte bLog;					/*!< 日志使能，目前只有在WTN动态检测中使用 */

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 511)]
            public Byte[] byReserved;
        };

        // 外部报警扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMIN_CFG_EX
        {
            public Byte byAlarmType;			// 报警器类型，0：常闭，1：常开
            public Byte byAlarmEn;				// 报警使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;                 //NSP

            public ZLNET_MSG_HANDLE_EX struHandle;				// 处理方式
        };

        // 动态检测报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MOTION_DETECT_CFG_EX
        {
            public Byte byMotionEn;				// 动态检测报警使能
            public Byte byReserved;
            public UInt16 wSenseLevel;			// 灵敏度
            public UInt16 wMotionRow;				// 动态检测区域的行数
            public UInt16 wMotionCol;				// 动态检测区域的列数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MOTION_ROW, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_MOTION_COL[] byDetected;             // 检测区域，最多32*32块区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;	                //NSP

            public ZLNET_MSG_HANDLE_EX struHandle;				//处理方式
        };

        // 视频丢失报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_LOST_CFG_EX
        {
            public byte byAlarmEn;				// 视频丢失报警使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_TSECT[] stSect;	                //NSP

            public ZLNET_MSG_HANDLE_EX struHandle;				// 处理方式
        };

        // 图像遮挡报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BLIND_CFG_EX
        {
            public Byte byBlindEnable;			// 使能
            public Byte byBlindLevel;			// 灵敏度1-6

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public Byte[] byReserved;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stSect;	                //  NSP

            public ZLNET_MSG_HANDLE_EX struHandle;				// 处理方式
        };

        // 硬盘消息(内部报警)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISK_ALARM_CFG_EX
        {
            public byte byNoDiskEn;				// 无硬盘时报警

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byReserved_1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stNDSect;               //  NSP

            public ZLNET_MSG_HANDLE_EX struNDHandle;			// 处理方式

            public byte byLowCapEn;				// 硬盘低容量时报警
            public byte byLowerLimit;			// 容量阀值，0-99

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byReserved_2;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stLCSect;               //  NSP

            public ZLNET_MSG_HANDLE_EX struLCHandle;			// 处理方式

            public byte byDiskErrEn;			// 硬盘故障报警
            public byte bDiskNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] byReserved_3;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stEDSect;               //NSP

            public ZLNET_MSG_HANDLE_EX struEDHandle;			// 处理方式
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NETBROKEN_ALARM_CFG_EX
        {
            public byte byEnable;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] byReserved;

            public ZLNET_MSG_HANDLE_EX struHandle;
        };

        // 协议信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PROTOCOL_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
            public string protocolname;		    // 协议名

            public uint baudbase;				// 波特率
            public byte databits;				// 数据位
            public byte stopbits;				// 停止位
            public byte parity;					// 校验位
            public byte reserve;
        };

        // 语音对讲参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_TALK_CFG
        {
            // 音频输入参数
            public byte byInFormatTag;			// 编码类型，如PCM
            public byte byInChannels;			// 声道数
            public UInt16 wInBitsPerSample;		// 采样深度
            public uint dwInSamplesPerSec;		// 采样率

            // 音频输出参数
            public byte byOutFormatTag;			// 编码类型，如PCM
            public byte byOutChannels;			// 声道数
            public UInt16 wOutBitsPerSample;		// 采样深度
            public uint dwOutSamplesPerSec;		// 采样率
        };

        //NVR-设备搜索协议类型
        public enum ZLNET_NVR_PROTOCOL
        {
            NVR_PROTOCOL_TYPE_ZL = 0,
            NVR_PROTOCOL_TYPE_DH,
            NVR_PROTOCOL_TYPE_HH,
            NVR_PROTOCOL_TYPE_ONVIF,
            NVR_PROTOCOL_TYPE_RTSP,
            NVR_PROTOCOL_TYPE_TST,					//Aebell 协议名字 Aebell
            NVR_PROTOCOL_TYPE_LAS,					//Lonasee 龙安视协议
            NVR_PROTOCOL_TYPE_XM,
            NVR_PROTOCOL_TYPE_P2P,
            NVR_PROTOCOL_TYPE_XINHAI,
            NVR_PROTOCOL_TYPE_SAMSUNG,
            NVR_PROTOCOL_TYPE_PANASONIC,
            NVR_PROTOCOL_TYPE_XILIAN,
            NVR_PROTOCOL_TYPE_BSM,
            NVR_PROTOCOL_TYPE_PRIVATE = 15,
            NVR_PROTOCOL_TYPE_APDA,
            NVR_PROTOCOL_TYPE_SONY,
            NVR_PROTOCOL_TYPE_XTRON,
            NVR_PROTOCOL_TYPE_PRIVATE_SEARCH = 63,	//私有的搜索协议，只支持搜索功能
            NVR_PROTOCOL_TYPE_MAX = 64,				//最多支持64钟协议
        };

        //连接设备配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CONFIG_NET_CHN
        {
            public ZLNET_NVR_PROTOCOL protocol;			// 接入协议

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_NVR_MAX_URL_LEN)]
            public string ip;			        // 接入的设备IP

            public int Port;				// 接入的设备端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_NVR_PASSWORD_LEN)]
            public string UserName;	        // 接入的设备用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_NVR_PASSWORD_LEN)]
            public string Password;	        // 接入的设备密码
            public int channel;			// 接入的设备通道
            public int bEnable;			// 网络通道使能
            public int nNvrResolution;		// 当前网络通道的分辨率
            public int bTimeEnable;		// 时间同步使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public Byte[] nReserved;			// 保留
        };

        //连接设备配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CONFIG_NET
        {
            public int nSize;
            public int nValidNum;		//有效配置个数
            public int nMaxEncode;		//最大编码能力

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVR_CONFIG_NET_CHN[] NetConfig;
        };

        //NVR设备通道网络配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CHANNEL_NET_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string ip;					//IP地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string subnetMask;			//子网掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string gateway;			//网关地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string primaryDNS;			//首选DNS

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string secondaryDNS;		//备用DNS
        };

        //NVR接入设备网络参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_MIXED_DEV_NETCFG
        {
            public ZLNET_NVR_CONFIG_NET_CHN basicParam;		//连接的设备基本参数
            public ZLNET_NVR_CHANNEL_NET_CONFIG netParam;		//要进行配置的网络参数
        };

        //通道数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CHANNEL
        {
            public int nSize;
            public int nLocalChn;	    //本地通道数
            public int nMixChn;	    //网络通道数
            public int nMixAlarmIn;    //网络通道映射报警输入个数
        };

        //当前网络通道个数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CHANNEL_INFO_EX
        {
            public int nSize;
            public int nChannelNum;
            public int nError;
            public int Reserved1;
            public int Reserved2;
            public ZLNET_NVR_CONFIG_NET_CHN configNetChN;
        };

        //搜索结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_SEARCHINFO
        {
            public ZLNET_NVR_PROTOCOL eProtocol;	    //协议类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string ip;		        //ip或者URL

            public int nPort;			//端口号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szDevType;		//设备类型
        };

        //网络通道PTZ参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_NET_PTZ_PARAM
        {
            public int nSize;		    //结构体大小
            public int nChannel;	    //网络通道号
            public int minPreset;	    //预置点最小值；
            public int maxPreset;	    //预置点最大值；
            public int minTour;	    //自动巡航线路的最小值；
            public int maxTour;	    //自动巡航线路的最大值；
            public int minPattern;	    //轨迹线路的最小值；
            public int maxPattern;	    //轨迹线路的最大值；
        };

        //通道名点阵
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_NAME_LATTICE
        {
            public int nSize;					//结构体大小
            public int nChannel;				//通道
            public int nWidth;					//点阵宽度
            public int nHeight;				//点阵高度
            public int nCharacterSize;			//字符长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_LATTICE_LEN)]
            public byte[] buffer;	                //一个通道名的点阵大小
        };

        //辅助通道名点阵
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ASSIST_CHANNEL_NAME_LATTICE
        {
            public int nSize;			//结构体大小

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHAN_NAME_LEN)]
            public string szName;	        //通道名

            public ZLNET_CHANNEL_NAME_LATTICE lattice;        //点阵信息
            public ZLNET_ENCODE_WIDGET osd;			//osd叠加信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] res;			//保留
        };

        //NVR设备通道模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CHANNEL_MODE
        {
            public int nLocalD1Channel;	    //本地通d1道数
            public int nLocalCIFChannel;	    //本地通cif道数
            public int nLocal_960H_channels;   //本地960H通道数
            public int nLocal720PChannels;	    //本地通720P道数
            public int nLocal1080PChannels;    //本地通1080P道数
            public int nLocal3MChannels;	    //本地通3M道数
            public int nLocal5MChannels;	    //本地通5M道数

            public int nPlayBackNum;		    //回放路数

            public int nNetChannel;		    //网络通道数
            public int nAbility;			    //网络接入能力
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_CHANNEL_MODE_SUPPORT
        {
            public int nSize;				//结构体大小
            public int nMode;				//当前通道模式
            public int nModeNum;			//通道模式个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_CHANNEL_MODE_MAX_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVR_CHANNEL_MODE[] channelMode;        //通道模式
        };

        //NVR通道状态
        public enum ZLNET_MIXED_TIP_STATE
        {
            MIXED_TIP_STATE_NULL = 0,	//正常
            MIXED_TIP_STATE_NO_SET,     //未设置
            MIXED_TIP_STATE_ERROR,      //其它错误
            MIXED_TIP_STATE_LOGINING,       //登录中
            MIXED_TIP_STATE_LOGIN_TIMEOUT,          //登录超时
            MIXED_TIP_STATE_NET_FAILED,                 //网络错误1
            MIXED_TIP_STATE_SUB_NET_FAILED,         //网络错误2
            MIXED_TIP_STATE_USER_PWD_FAILED,
            MIXED_TIP_STATE_USER_UNREPEAT,
            MIXED_TIP_STATE_USER_LOCKED,
            MIXED_TIP_STATE_CHANNEL_UNEXIST,
            MIXED_TIP_STATE_MAIN_STREAM_NODATA,
            MIXED_TIP_STATE_SUB_STREAM_NODATA,
            MIXED_TIP_STATE_VDEC_LACK_ABILITY,		//解码能力不够
            MIXED_TIP_STATE_VDEC_INABILITY,			//无法解码
            MIXED_TIP_STATE_NET_LACK_ABILITY,		//网络接入能力超出
            MIXED_TIP_STATE_VDEC_ENCODE_NOSUPPORT,	//编码模式不支持
        };

        //NVR网络通道状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_STATE_NET_CHN
        {
            public int nChn;		//通道号
            public int nState;		//通道状态	enum ZLNET_MIXED_TIP_STATE
            public int nWith;		//分辨率宽
            public int nHeight;	//分辨率高
            public int nFps;		//帧率
            public int nBitRate;	//码率

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;
        };

        //NVR网络通道状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_STATE_NET
        {
            public int nSize;
            public int nNetChnNum;     //NVR有效网络通道数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVR_STATE_NET_CHN[] NetChnState;    //网络通道状态信息
        };

        //网络通道状态扩展
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHN_STATE
        {
            public int nChnNum;		//stNetChnState有效数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVR_STATE_NET_CHN[] stNetChnState; //网络通道状态信息
        };

        //NVR网络通道权限获取
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_PROANDDEV_ABILITY_PRIVILEGES
        {
            public int nSize;				//结构体大小
            public int nType;				//权限类型	0：NVR设备协议能力 1：接入设备能力 2:模块能力
            public int nChannel;			//0 == nType : 设备支持协议的类型（ZLNET_NVR_PROTOCOL）；1 == nType : 当前接入设备的网络通道；2 == nType nChannel无意义
            public Int64 nPrivileges;		//权限掩码 按位参看ZLNET_NVR_PROANDDEV_ABILITY

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;				//保留
        };

        //NVR网络通道外部报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_EXTERNAL_ALARM
        {
            public int nMixedChannel;				//网络通道的通道号
            public int nRemoteAlarmInChannel;		//前端IPC的报警通道号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] res;						//保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_EXTERNAL_ALARM_CFG
        {
            public int nSize;				//结构体大小
            public int nValidNum;			//实际网络通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NET_CHANNEL_EXTERNAL_ALARM[] alarmCfg;           //单个外部报警通道配置
        };

        //压缩格式
        public enum ZLNET_NET_CHANNEL_COMPRESS
        {
            ZLNET_COMPRESS_H264 = 0,
            ZLNET_COMPRESS_JPEG,
        };

        //码流类型
        public enum ZLNET_STREAM_TYPE
        {
            ZLNET_STREAM_MAIN = 0,
            ZLNET_STREAM_SUB,
            ZLNET_STREAM_JPG,
            ZLNET_STREAM_NUM,
        };

        //分辨率
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_RESOLUTION
        {
            public int nWidth;
            public int nHeight;
        };

        //获取编码配置的支持范围
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAPTURE_OPTIONITEM
        {
            public int nCompress;		//压缩样式
            public ZLNET_NET_CHANNEL_RESOLUTION resolution;	    //分辨率
            public int nMaxFps;		//最大帧率
            public int nMaxRate;		//最大码流(Kbps)
        };

        //获取每个网络通道编码配置的支持范围
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAPTURE_OPTION
        {
            public int nItemCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CAPTURE_OPTION_ITEM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CAPTURE_OPTIONITEM[] item;	    //最多支持16种
        };

        //获取所有网络通道编码配置的支持范围
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_CAPTURE_OPTION
        {
            public int nSize;				//结构体大小
            public int nValidNum;			//NVR有效网络通道数
            public int nStreamType;		//码流类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] nError;				//每个通道获取状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CAPTURE_OPTION[] capture;
        };

        //编码配置结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CAPTURE_FORMAT
        {
            public int nCompress;			//压缩样式
            public ZLNET_NET_CHANNEL_RESOLUTION resolution;	        //分辨率
            public int nFps;				//帧率(对于JPEG,大于128表示几秒一帧)
            public int nGop;				//关键帧间隔
            public int nQuality;			//图像质量，0最好，5最差
            public int nRateCtrl;			//0固定码流，1可变码率
            public int nRate;				//码流(Kbps)
        };

        //获取所有网络通道编码配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_CAPTURE_FORMAT
        {
            public int nSize;				//结构体大小
            public int nValidNum;			//NVR有效网络通道数
            public int nStreamType;		//码流类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] nError;				//每个通道获取状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CAPTURE_FORMAT[] capture;
        };

        //网络通道名
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_CHNAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_NVR_CHAN_NAME_LEN)]
            public string channelname;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_NAME
        {
            public int nSize;					//结构体大小
            public int nValidNum;			    //网络通道有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] bSyncFront;				//是否同步到前端

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_CHNAME[] chName;                 //通道名(UNICODE编码)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] Res;					//保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_NAME_EX
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_CHAN_NAME_LEN_EX)]
            public byte[] szChanNameLenEx;					//保留
        };

        //通道名配置(扩展支持1024通道)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_NAME_CFG
        {
            public int nChannelNum;                   //chName有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM_EX, ArraySubType = UnmanagedType.I4)]
            public int[] bSyncFront;						//是否同步到前端(前端是网络通道时有效，查询时无效）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CHANNEL_NAME_EX[] chName;      //通道名（由于设备性能不同，部分设备实际只支持32字节名称）(ASCII编码)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] Res;                                  //保留
        };

        //高清IPC视频参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_PARAM
        {
            public int nSize;			    //结构体大小

            public int nCmd;			    //视频参数默认命令 0：忽略 1：恢复默认值 2：自然 3：标准 4：艳丽 5:显示坏点 6：不显示坏点

            public int nLens;			    //光圈类型
            public int nShutter;		    //快门控制
            public int nAgc;			    //自动增益控制

            public int nSenseup;		    //帧累积

            public int nBrightness;	    //亮度
            public int nAcce;			    //亮度动态调节
            public int nDefog;			    //除雾功能

            public int nBackLight;		    //背光补偿
            public int nWhiteBal;		    //白平衡
            public int nDayNight;		    //日|夜

            public int nTwoDNR;		    //2D降噪	开关
            public int nThreeDNR;		    //3D降噪 开关
            public int nTdLevel;		    //3D降噪级别

            public int nMirror;		    //镜像 翻转

            public int nSharpness;		    //锐度开关
            public int nSharpnessLevel;    //锐度调整级别

            public int nLlsc;			    //图像四角亮度补偿 开关
            public int nNorP;			    //N|P 制式选择 实现帧率选择 N:30fps P:25fps
            public int nLensMode;		    //光圈模式  0:室内 1:室外

            public int nDayNightDelay;	    //日夜切换延时
            public int nDeflicker;		    //抗闪烁
            public int nContrast;		    //对比度
            public int nColorMode;		    //色彩模式

            public int nDayToNight;	    //日夜切换阈值
            public int nNightToDay;	    //夜日切换阈值

            public int nSaturation;	    // 饱和度	0-100
            public int nHue;			    // 色度	0-100

            public int nRgain;				//红调节
            public int nBgain;				//蓝调节
            public int nRGgain;			//红绿
            public int nBGgain;			//蓝绿
            public int nGamma;
            public int nExpEnable;			//曝光行数使能
            public int nAnalogEnable;		//模拟增益使能
            public int nAnalogValue;		//模拟增益值
            public int nDigitalEnable;		//数字增益使能
            public int nDigitalValue;		//数字增益值
            public int nExposureControl;	//曝光控制模式

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //保留
        };

        //前端操作类型
        public enum ZLNET_CHECK_TYPE
        {
            CHECK_IRIS = 0,			//光圈校验
            BAD_POINT_DETECT,		//坏点检测
        };

        //前端操作结果
        public enum ZLNET_CHECK_TRESULT
        {
            CHECK_FAIL = 0,			//校验失败
            CHECK_SUCCEED,			//校验成功
        };

        //IPC前端操作
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FRONT_END_OPERATE
        {
            public int nOperateType;		//操作类型	ZLNET_CHECK_TYPE

            public int nOperateParam1;		//操作类型1 nOperateType = CHECK_IRIS:停止值	；nOperateType = BAD_POINT_DETECT：最小坏点数
            public int nOperateParam2;		//操作类型2	nOperateType = CHECK_IRIS:关闭驱动值；nOperateType = BAD_POINT_DETECT：最大坏点数
            public int nOperateParam3;		//操作类型3	nOperateType = CHECK_IRIS:触发事件  ；nOperateType = BAD_POINT_DETECT：开始阈值

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //保留
        };

        //IPC前端操作结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FRONT_END_OPERATE_RESULT
        {
            public int nOperateType;		//操作类型	ZLNET_CHECK_TYPE
            public int nRetResult1;		//返回结果1 nOperateType = CHECK_IRIS 成功或失败 ；nOperateType = BAD_POINT_DETECT 成功或失败
            public int nRetResult2;		//返回结果2	nOperateType = BAD_POINT_DETECT 门阀值 门阀值
            public int nRetResult3;		//返回结果3	nOperateType = BAD_POINT_DETECT 门阀值 坏点个数
        };

        //所有网络通道视频参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_VIDEO_PARAM
        {
            public int nSize;				//结构体大小
            public int nValidNum;			//NVR有效网络通道数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] nError;				//每个通道获取状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEO_PARAM[] videoParam;
        };

        //球机视频参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DOME_CAMERA_VIDEO_PARAM
        {
            public int nSize;				//结构体大小

            public int nWhiteBalance;      //白平衡     Auto/Indoor/Outdoor/ATW
            public int nWideDynamic;       //宽动态     1:off  2:on
            public int nDayNight;			//日夜切换
            public int nBacklight;			//背光补偿1:off  2:on
            public int nSharp;				//锐度(0--15)
            public int nBrightness;		//亮度(0--27)
            public int n3Dreduction;		//3D降噪(0--5)
            public int nShutter;			//快门(0--21)
            public int nLens;				//光圈0-手动1-自动
            public int nFocus;				//对焦0-手动1-自动
            public int nAutoGain;			//自动增益(关闭/自动/高/中/低)
            public int nSaturation;        //饱和度(0-14)
            public int nHue;               //色调(0-3)
            public int nAutoFlip;			//自动图像翻转(0-off 1-on)
            public int nMirror;			//图像镜像(0-off 1-on)
            public int nFPS;				//帧率调节(0 -25fps 1-30fps)
            public int nFlicker;			//抗闪烁(0 - off 1 - on)
            public int nSlowShutter;		//慢快门(0-off 1-on)
            public int nAutoExposureMode;	//自动曝光模式(0 自动曝光1 快门优先2 光圈优先)
            public int nDigitalZoom;		//数字变倍(0-off 1-on)
            public int nZoom;				//变倍
            public int nFrameNoise;		//帧降噪
            public int nGainCtrl;			//增益控制
            public int nGainAdjust;		//增益调节
            public int nMenuFreeze;		//画面冻结
            public int nImageStabilizer;	//图像防抖
            public int nThroughFog;		//透雾功能
            public int nSmartIR;			//智能红外

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //网络通道抓图配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SNAP_FORMAT
        {
            public int nWidth;			//分辨率宽
            public int nHeight;		//分辨率宽
            public int nQuality;		//画质 1-6
            public int nFps;			//帧率
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_SNAP_FORMAT
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_SNAP_TYPE.ZLNET_SNAP_TYP_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SNAP_FORMAT[] format;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CHANNEL_SNAP
        {
            public int nSize;			//结构体大小
            public int nValidNum;		//NVR有效网络通道数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NET_CHANNEL_SNAP_FORMAT[] snap;
        };

        //NVR设备所支持的协议排序
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_PRONAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PROTOCOL_NAME_LEN)]
            public string proname;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVR_PROTOCOL_SORT
        {
            public int nSize;				//结构体大小
            public int nSortCount;			//支持协议个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_NVR_PROTOCOL.NVR_PROTOCOL_TYPE_MAX,
                ArraySubType = UnmanagedType.I4)]
            public int[] nSortList;		    //支持协议排序，按照ZLNET_NVR_PROTOCOL排序

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_NVR_PROTOCOL.NVR_PROTOCOL_TYPE_MAX,
                ArraySubType = UnmanagedType.Struct)]
            public STRUCT_PRONAME[] sortName;	        //支持协议名
        };

        //UPNP状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_UPNP_STATE
        {
            public int nSize;			//结构体大小
            public int nState;			//UPNP连接状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] Res;			//保留
        };

        //WIFI使能
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WIFI_ENABLE
        {
            public int nSize;		//结构体大小
            public int nCmd;		//命令 0：关闭 1：开启

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] Res;		//保留
        };

        //WIFI连接方式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WIFI_CONNECTION_TYPE
        {
            public int nSize;		//结构体大小
            public int nCmd;		//命令 0：手动 1：自动

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] Res;		//保留
        };

        //连接到AP需要设置的参数
        //ssid必须设置
        //jfs加密方式，根据扫描的结果进行设置
        //根据加密方式选择填充其余成员：
        //jfs=1	填充:	psk, proto, encryption
        //jfs=2 填充:	wep_tx_keyidx, wep_key
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_WIFI_CFG
        {
            public int nSize;			//结构体大小

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_NET_CARD_LEN)]
            public string ifname;		    //eth1 /eth2 //无线网卡名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_JUNCTION_LEN)]
            public string ssid;			//连接点名称

            /* 加密方式 */
            public int nJfs; 			//0:无密码 1:WPA|WPA2 	2:WEP
            public int nKeyType; 		//0:ascii 1:hex 密码格式

            /* WPA */
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_PSW_LENGTH)]
            public string psk;			//密码ascii 和 hex之分

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_PROTOCOL_LNE)]
            public string protocol;		//协议有WPA 和 RSN之分

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_PROTOCOL_LNE)]
            public string encryption;	    //加密方法，编码方式 TKIP | CCMP

            /* WEP */
            public int nWepTxKeyidx; 	//可以有4组密码，该成员变量表示选择哪组密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_PSW_LENGTH)]
            public string wepKey;			//密码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] Res;			//保留
        };

        //WIFI可能的加密类型  0为没有加密方式
        public enum ZLNET_WIFI_ENCRYPTION_TYPE
        {								// +相应的对ZLNET_DEV_WIFI_CFG的设置
            ZLNET_WIFI_NO = 0,			// |ssid=***, jfs=0
            ZLNET_WIFI_WEP,				// |ssid=***, jfs=2 ,wep_tx_keyidx=?, wep_key=***, key_type=?
            ZLNET_WIFI_WPA_TKIP,	 	// |ssid=***, jfs=1 ,proto=WPA, encryption=TKIP, psk=*** , key_type=?
            ZLNET_WIFI_WPA_CCMP,	 	// |ssid=***, jfs=1 ,proto=WPA, encryption=CCMP, psk=*** , key_type=?
            ZLNET_WIFI_WPA2_TKIP,		// |ssid=***, jfs=1 ,proto=RSN, encryption=TKIP, psk=*** , key_type=?
            ZLNET_WIFI_WPA2_CCMP		// |ssid=***, jfs=1 ,proto=RSN, encryption=CCMP, psk=*** , key_type=?
        };

        //一个无线路由信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WIRELESS_ROUTER_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MACADDR_LEN)]
            public string macAddr;		    //MAC地址

            public int nFreq;				//channel 频段
            public int nChannel;			//无线信道
            public int nSignalLevel;		//信号强度 dbm
            public int nFlags;				//加密方式 WPA-PSK-TKIP | WEP 等等  0:为没有加密 -1:为未知的加密方式

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_WIFI_JUNCTION_LEN)]
            public string ssid;	            //ap名称
        };

        //wifi扫描得到的信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNETl_WIFI_NETWORK_INFO
        {
            public int nSize;			//结构体大小
            public int nValidNum;		//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_WIFI_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_WIRELESS_ROUTER_INFO[] info;
        };

        //DDNS注册信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DDNS_REGISTER_INFO
        {
            public int nSize;				//结构体大小
            public int nCmd;				//注册命令
            public ZLNET_DDNS_SERVER_CFG struDdnsServer;		//DDNS服务器结构体
        };

        //DDNS状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_DDNS_SERVER_TYPE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVER_TYPE_LEN)]
            public string szDdnsServerType;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DDNS_STATE
        {
            public int nSize;			//结构体大小
            public int nValidNum;		//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DDNS_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_DDNS_SERVER_TYPE[] ddnsType;	    //设备支持的DDNS服务器类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_DDNS_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nState;			//DDNS状态码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //美电贝尔GB28181配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_AEB_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_INFO_LEN)]
            public string szAebInfo;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AEB_GB_PROTOCOL
        {
            public int nSize;				//结构体大小

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_ID_LEN)]
            public string deviceID;		    //美电贝尔GB28181 Device ID

            public int nSipPort;			//美电贝尔GB28181 sip 端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_DOMAIN_LEN)]
            public string deviceDomain;       //美电贝尔GB28181 Device 域名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_PSW_LEN)]
            public string password;		    //美电贝尔GB28181 密码

            public int nExpire;			//美电贝尔GB28181 有效时间
            public int nKeepLive;			//美电贝尔GB28181 保活时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_IP_LEN)]
            public string serverIp;		    //美电贝尔GB28181 Server IP

            public int nServerPort;		//美电贝尔GB28181 Server 端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_ID_LEN)]
            public string serverID;		    //美电贝尔GB28181 Server ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_AEB_DOMAIN_LEN)]
            public string serverDomain;       //美电贝尔GB28181 Server 域名

            public int nAlarmNum;			//报警通道数
            public int nChannelNum;		//通道数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_AEB_INFO[] channelInfo;		//美电贝尔GB28181 通道信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_AEB_ALARM_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_AEB_INFO[] alarmInfo;	        //美电贝尔GB28181 报警信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;				//保留
        };

        //康联网络配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KONLAN_NET_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_KONLAN_IP_LEN)]
            public string serverIP;		    //服务器IP

            public int nPort;			    //端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_KONLAN_ID_LEN)]
            public string id;			        //ID

            public int devicePort;		    //设备UDP端口
            public int curDefenseArea;	    //当前防区

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.U4)]
            public uint[] dwDefenseArea;		//防区掩码

            public int snapnum;			//抓图数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //通道录像状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_RECORD_STATE
        {
            public int nSize;								//结构体大小
            public int nChannelNum;						//通道数
            public uint dwRecordStateMask;					//各个通道录像状态掩码值 0:未录像 1:正在录像

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //上海地标定制
        //触发抓图
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_SHTY_TRIGGERSNAP
        {
            public uint dwSnapChannel;		//抓拍通道掩码
            public int nFrequency;			//抓拍频率 ， 秒
            public int nDelay;				//抓拍延时(1--60) 秒
        };

        //报警抓图
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_SHTY_ALARMSNAP
        {
            public uint dwSnapChannel;		//抓拍通道掩码
            public int nInterval; 			//抓拍间隔， 秒
            public int nPreSnap;			//预抓时长澹(1--60)秒
            public int nDelay;				//抓拍延时(1--60)秒
        };

        //定时抓图
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_SHTY_TIMESNAP
        {
            public uint dwSnapChannel;		//抓拍通道掩码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_SHTY_TIME_NUM, ArraySubType = UnmanagedType.Struct)]
            public SYSTEM_TIME[] tTime;		        //抓拍的时间点

            public int nInterval; 			//抓拍间隔， 秒
            public int nSnaptimes;			//抓拍次数
        };

        //设备ID设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_SHTY_LOGININFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_OEM_SHTY_ID_LEN)]
            public string DeviceID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_OEM_SHTY_SERVER_IP_LEN)]
            public string CenterServerIP;

            public int nServerport;
        };

        //上海地标定制
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_SHTY
        {
            public int nSize;			//结构体大小
            public ZLNET_CONFIG_SHTY_TRIGGERSNAP triggerSnap;	//触发抓图
            public ZLNET_CONFIG_SHTY_ALARMSNAP alarmSnap;		//报警抓图
            public ZLNET_CONFIG_SHTY_TIMESNAP timeSnap;		//定时抓图
            public ZLNET_CONFIG_SHTY_LOGININFO info;			//设备ID设置
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SHTY_UPLOAD
        {
            public int nCmd;			//命令

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_OEM_SHTY_INFO_LEN)]
            public string info;			//信息
        };

        //云台方向控制方式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PTZ_CONTROL
        {
            public int nSize;				//结构体大小
            public int nControlWay;		//方向控制方式

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //保留
        };

        //云台配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_PRESET
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_TOUR_PRESET_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nPerset;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PTZ_CONFIG
        {
            public int nSize;					//结构体大小
            public int nCurPresetNum;			//当前预置点个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_PRESET_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nPreset;			    //预置点

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_TOUR_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nCurTourPresetNum;	    //当前预置点个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_TOUR_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_PRESET[] nTourPreset;	        //巡航组添加的预置点

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_TOUR_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nTourTime;			    //巡航组时间

            public int nGuardIndex;			//看守位选择项
            public int nGuardType;				//看守位类型
            public int nGuardTypeIndex;		//看守位选对应类型的择项
            public int nGuardTime;				//看守位时间
            public int nInfraredMode;			//红外模式
            public int nInfraredSensitivit;	//红外灵敏度
            public int nInfraredFunc;			//红外功能
            public int nLinescan;				//线性扫描选择0：顺时针 1：逆时针
            public int nInfraredEnable;		//红外定时使能
            public ZLNET_TIME beginTime;				//开始时间
            public ZLNET_TIME endTime;				//结束时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;					//保留
        };

        //手机推送配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PHONE_PUSH_CONFIG
        {
            public int nSize;				//结构体大小

            public int nEnable;			//推送服务器使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVERIP_LEN)]
            public string szServerIP;		    //推送服务器IP地址(有可能为域名)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVERURI_LEN)]
            public string szUriLogin;	        //登录URI (没有用到)

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVERURI_LEN)]
            public string szUriGetToken;	    //获取设备ID URI

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_SERVERURI_LEN)]
            public string szUriSend;		    //推送消息URI

            public int nServerPort;		//服务器端口
            public int nPushPort;			//推送服务监听端口:默认81

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PUSH_NAME_LEN)]
            public string szDevName;		    //推送使用设备名称

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //3G网络类型
        public enum ZLNET_3G_TYPE
        {
            ZLNET_3G_WCDMA = 0,
            ZLNET_3G_CDMA2000,
            ZLNET_3G_TD_SCDMA,
            ZLNET_3G_UNKNOW,
            ZLNET_3G_TYPE_NUM,
        };

        //3G配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_3G_CONFIG
        {
            public int nSize;					//结构体大小

            public int bEnable;				//3G使能
            public int nType;					//3G网络类型,区分不同网络运营商

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_ACCESS_POINT_LEN)]
            public string szAccessPoint;	        //3G接入点

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DIAL_NUMBERS_LEN)]
            public string szDialNumbers;	        //3G拨号号码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_3G_USER_LEN)]
            public string szAccount;			    //3G帐号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_3G_PSW_LEN)]
            public string szPsw;				    //3G密码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_3G_IP_LEN)]
            public string szIP;					//3G IP

            public int nSignalIntensity;		//3G信号
            public int nOnlineState;			//3G在线状态
            public int nSimCard;				//Sim卡状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //录像备份功能
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RECORD_BACKUP_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_NAME_LEN)]
            public string szDevame;	        // 备份设备的名称

            public int nType;				// 备份设备的介质类型，取枚举类型ZLNET_DEV_BACKUP_TYPE的值
            public int nBus;				// 备份设备的接口类型，取枚举类型ZLNET_DEV_BACKUP_BUS的值
            public uint nCapability;		// 总容量，以Kilo-Bytes为单位
            public uint nRemain;			// 剩余容量，以Kilo-Bytes为单位

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_URL_LEN)]
            public string szDirectory;	    // 远程备份的目录

            public int nFlag;				// 备份设备状态
        };

        //备份设备列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BACKUP_DEVICE_LIST
        {
            public int nSize;				// 结构体大小
            public int nDeviceNum;			// 备份设备个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_BACKUP_DEVICE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_RECORD_BACKUP_INFO[] backup;
        };

        //备份文件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BACKUP_FILE_INFO
        {
            public int nChannel;				//通道号
            public int nAlarmType;				//报警类型
            public int nImage;					//图像质量
            public ZLNET_TIME startTime;				//开始时间
            public ZLNET_TIME endTime;				//结束时间
            public int nFileLength;			//文件长度，单位为KB
            public int nDiskNo;				//所在的硬盘号
            public int nDiskPart;				//所在的分区
            public int nFirstClusNo;			//文件首簇号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_FILENAME_LEN)]
            public string szBaseName;	            //文件名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_BACKUP_EXTNAME_LEN)]
            public string szExtName;	            //扩展名

            public int nChecked;				//是否选中，用于文件备份
        };

        //备份文件列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BACKUP_RECORD_FILE
        {
            public int nSize;					//结构体大小
            public int nBackupNum;				//备份文件数量
            public int nConvertToAVI;			//是否转换为AVI格式
            public int nBackMask;				//备份设备掩码
            public int bBackupEncrypt;			//备份是否加密

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_KEY_LEN)]
            public string szKey;			        //备份密钥

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_BACKUP_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_BACKUP_FILE_INFO[] backupInfo;
        };

        //备份操作
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_BACKUP_OPERATE
        {
            public int nSize;					// 结构体大小
            public int nOperateType;			// 备份操作类型 0:获取状态 1:停止备份 2:擦除
            public int nMask;					// nOperateType == 2 有效代表擦除那个设备
            public int nResult;				// 返回结果 nOperateType == 0 代表返回状态，nOperateType == 1 代表停止是否成功， nOperateType == 2 代表擦除是否成功
        };

        //多网卡模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CARD_MODE
        {
            public int nSize;			//结构体大小
            public int nMode;			//网卡模式 0：双网卡，1：容错，2：负载均衡。

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			//保留
        };

        //获取使用当前IP和配置IP
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CUR_IP_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sUseIPAddr;	        // DVR IP 使用地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sUseIPMask;	        // DVR IP 使用地址掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sUseGatewayIP;      // 使用网关地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sCfgIPAddr;	        // DVR IP 配置地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sCfgIPMask;	        // DVR IP 配置地址掩码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string sCfgGatewayIP;      // 配置网关地址
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NET_CARD_IP_INFO
        {
            public int nSize;			//结构体大小
            public int nCardNum;		//当前网卡个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ETHERNET_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CUR_IP_INFO[] ipInfo;         //网卡对应IP信息
        };

        //康联卡片机无线报警配置
        //康联无线设备枚举
        public enum ZLNET_KL_DEVICE_TYPE
        {
            ZLNET_KL_CONTROLLER = 0x01,	/*遥控器*/
            ZLNET_KL_DOOR_CONTACT,			/*门磁*/
            ZLNET_KL_INFRARED,				/*红外*/
            ZLNET_KL_SMOKE,					/*烟感*/
            ZLNET_KL_GAS,					/*气感*/
            ZLNET_KL_SWITCH,				/*开关*/
            ZLNET_KL_VIBRATE,				/*振动*/
            ZLNET_KL_TROUGH_BEAM,			/*对射*/
            ZLNET_KL_GLASSBREAK,			/*玻璃破碎*/
            ZLNET_KL_WATER_LEVEL,			/*水位*/
            ZLNET_KL_TEMPERATURE,			/*温度*/
        };

        //康联无线设备
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KL_DEVICE
        {
            public int nNameType;	    //名称类型
            public int nState;		    //状态 0：无配对 1：配对
            public int nArmingType;    //布防类型 0:留守布防 1：外出布防
            public int nAddr;		    //地址
            public int nVoice;		    //报警声音 0：关闭 1：开启

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //遥控器
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KL_DEVICE_REMOTE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_KA_REMOTE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_KL_DEVICE[] remote;
        };

        //传感器
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KL_DEVICE_REMOTE_SENSOR
        {
            public int nDelayOnset;	//布防延迟时间
            public int nDelayAlarm;	//报警延迟时间
            public int nSnapEnable;	//抓图使能
            public int nSnapShots;		//抓图张数
            public int nSnapInterval;	//抓图间隔
            public int nRecordTime;	//录像持续时间
            public int nRecordEnable;	//录像使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_KA_SENSOR_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_KL_DEVICE[] sensor;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KL_WIRELESS_ARMING
        {
            public int nSize;			//结构体大小
            public int nOperateType;	//0：获取 1：配对
            public int nKLType;		//0：遥控器 1：传感器
            public int nChannel;		//nOperateType == 0:无效 nOperateType == 1:配对通道
            public int nResult;		//nOperateType == 0:无效 nOperateType == 1:配对通道 0：失败 1：配对中 2：成功
            public ZLNET_KL_DEVICE_REMOTE remote;
            public ZLNET_KL_DEVICE_REMOTE_SENSOR sensor;
        };

        //云存储绑定类型
        public enum ZLNET_CLOUD_STORAGE_BIND_TYPE
        {
            ZLNET_CLOUD_STORAGE_NULL = -1,
            ZLNET_CLOUD_STORAGE_BAIDU = 0,
            ZLNET_CLOUD_STORAGE_DROPBOX,
        };

        //云存储绑定
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CLOUD_STORAGE_BIND
        {
            public int nSize;				//结构体大小
            public ZLNET_CLOUD_STORAGE_BIND_TYPE bindType;			//绑定类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STORAGE_URL_LEN)]
            public string chUrl;		        //云存储url

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STORAGE_URL_LEN)]
            public string chCode;		        //云存储校验码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STORAGE_URL_LEN)]
            public string chDeviceCode;	    //设备号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STORAGE_URL_LEN)]
            public string chCapacity;	        //容量

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STORAGE_URL_LEN)]
            public string chUser;		        //用户
            public int nBind;		        //nBind == 0 忽略 nBind == 1 绑定完成 nBind == 2 解除绑定

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_CHANNEL_MODE_MAX_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] res;		        //保留
        };

        //云存储报警联动
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CLOUD_STORAGE_ASSC
        {
            //动态检测
            public int bMDEnble;			//触发源
            public int bMDCloud;			//云存储
            public int bMDSnapshot;		//触发抓图
            public int bMDSnapshotTime;	//定时抓图
            public int nMDInterval;		//每张几秒（秒/张）
            public uint nMDSelect;		    //抓图联动
            public uint dwMDRecord;		    //联动录像
            public int bMDRecordEn;		//联动录像使能
            public int nMDRecordLatch;	    //录像延时

            //视频丢失
            public int bVLEnble;			//触发源
            public int bVLCloud;			//云存储
            public int bVLSnapshot;		//抓图
            public uint nVLSelect;		    //抓图联动
            public uint dwVLRecord;		    //联动录像
            public int bVLRecordEn;		//联动录像使能
            public int nVLRecordLatch;	    //录像延时

            //视频遮挡
            public int bVMEnble;			//触发源
            public int bVMCloud;			//云存储
            public int bVMSnapshot;		//抓图
            public uint nVMSelect;		    //抓图联动
            public uint dwVMRecord;		    //联动录像
            public int bVMRecordEn;		//联动录像使能
            public int nVMRecordLatch;	    //录像延时

            //本地报警
            public int bLAEnble;			//触发源
            public int bLACloud;			//云存储
            public int bLASnapshot;		//抓图
            public uint nLASelect;		    //抓图联动
            public uint dwLARecord;		    //联动录像
            public int bLARecordEn;		//联动录像使能
            public int nLARecordLatch;	    //录像延时
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CLOUD_STORAGE_ALARM
        {
            public int nSize;				//结构体大小
            public int nChannel;			//通道个数
            public int nAlarmChannel;		//报警输入通道

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] bAlarmCloud;	    //报警输入云存储使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CLOUD_STORAGE_ASSC[] detect;	            //联动

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CLOUD_STO_UPLOADPATH_LEN)]
            public string chPath;		        //云存储上传路径
        };

        //韩国客户无线模块
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HANGUO_WIRELESS
        {
            public int nSize;			//结构体大小
            public int nPid;			//无线局域网ID
            public int nCid;			//CID
            public int nChannel;		//通道
            public int nEncryption;	//安全
            public int nBand;			//频段

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //无线模块状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HANGUO_STATE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HG_WIRELESS_MSG)]
            public string szBcdmaId;		//MAC地址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_HG_WIRELESS_MSG)]
            public string szVersion;		//版本号

            public int nPid;			//无线局域网ID
            public int nCid;			//CID
            public int nStn;			//STN
            public int nState;			//状态
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HANGUO_WIRELESS_STATE
        {
            public int nSize;		//结构体大小
            public int nValid;		//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_HG_WIRELESS_MODULE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_HANGUO_STATE[] state;	    //无线模块状态

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//保留
        };

        //无线模块通道配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HANGUO_WIRELESS_CHANNEL
        {
            public int nSize;			//结构体大小
            public int nValid;			//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] bCfgSelect;	    //是否关联无线模块

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //SDI接入状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SDI_ACCESS_VIDEO_INFO
        {
            public int nEnable;			//是否接入视频
            public int nResolution;		//接入分辨率
            public int nMaxRate;			//接入最大帧率
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SDI_ACCESS_VIDEO_STATE
        {
            public int nSize;				//结构体大小
            public int nChannelNum;		//通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SDI_ACCESS_VIDEO_INFO[] sdiInfo;
        };

        ////////////////////////////////智能相关/////////////////////////////////
        //智能设备索引
        public enum ZLNET_IVA_DEV_INDEX
        {
            ZLNET_IVA_DEV_NULL = -1,
            ZLNET_IVA_DEV1 = 0,
            ZLNET_IVA_DEV2,
        };

        //智能ATM索引
        public enum ZLNET_IVA_ATM_INDEX
        {
            ZLNET_IVA_NULL = -1,
            ZLNET_IVA_ATM1 = 0,
            ZLNET_IVA_ATM2,
            ZLNET_IVA_ATM3,
            ZLNET_IVA_ATM4,
        };

        //自助银行厅室索引
        public enum ZLNET_IVA_SSB_INDEX
        {
            ZLNET_IVA_SSB_NULL = -1,
            ZLNET_IVA_SSB_HALL = 0,
            ZLNET_IVA_SSB_ROOM,
        };

        //自助银行索引
        public enum ZLNET_IVA_SSB_INDEX_NEW
        {
            ZLNET_IVA_SSB_NONE = -1,
            ZLNET_IVA_SSB1 = 0,
            ZLNET_IVA_SSB2,
        };

        //人脸通道索引
        public enum ZLNET_IVA_FACE_INDEX
        {
            ZLNET_IVA_FACE_NULL = -1,
            ZLNET_IVA_FACE_ANALYSIS = 0,	//分析通道
            ZLNET_IVA_FACE_PANORAMIC,		//全景通道
        };

        //车牌区域类型
        public enum ZLNET_LICENSE_PLATE_REGION_TYPE
        {
            ZLNET_IVA_LICENSE_PLATE_REGION_NULL = 0,
            ZLNET_IVA_LICENSE_PLATE_REGION_DETECTION,	//车辆屏蔽区域
            ZLNET_IVA_LICENSE_PLATE_REGION_FORBIDDEN,	//车辆检测区域
        };

        //逻辑通道顺序
        public enum ZLNET_IVA_LOGIC_CHANNEL
        {
            ZLNET_IVA_ATM1_PANEL = 0,		//ATM1面板
            ZLNET_IVA_ATM1_FACE,			//ATM1人脸
            ZLNET_IVA_ATM2_PANEL,			//ATM2面板
            ZLNET_IVA_ATM2_FACE,			//ATM2人脸
        };

        //日志存储模式
        public enum ZLNET_IVA_LOG_MODE
        {
            ZLNET_IVA_LOGMODE_NETSEND = 0,		//网络发送
            ZLNET_IVA_LOGMODE_LOCAL,			//本地存储
            ZLNET_IVA_LOGMODE_LOCALA_NETSEND	//网络发送并本地存储
        };

        //ATM+SSB混合型设备模式
        public enum ZLNET_IVA_ATM_SSB_MODE
        {
            ZLNET_IVA_ATM_SSB_NULL = 0,
            ZLNET_IVA_ATM_SSB_MIXED,		//ATM+SSB
            ZLNET_IVA_ATM_SSB_2ATM,			//两路ATM
            ZLNET_IVA_ATM_SSB_2SSB,			//两路SSB
            ZLNET_IVA_ATM_SSB_1ATM,			//单独ATM
            ZLNET_IVA_ATM_SSB_1SSB,			//单独SBB
        };

        //日志查询方式
        public enum ZLNET_IVA_LOG_SEARCH_MODE
        {
            ZLNET_IVA_SEARCHMODE_DATE = 0,	//日期模式
            ZLNET_IVA_SEARCHMODE_ID,		//ID模式
        };

        //日志下载模式
        public enum ZLNET_IVA_LOG_DOWNLOAD_MODE
        {
            ZLNET_IVA_DOWNLOADMODE_DOWNLOAD = 0,	//下载
            ZLNET_IVA_DOWNLOADMODE_DOWNLOADDEL,		//下载并删除
            ZLNET_IVA_DOWNLOADMODE_DEL,				//删除
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DOWN_PARAM
        {
            public int nMode;				//ZLNET_IVA_LOG_DOWNLOAD_MODE仅部分老设备支持
            public int nDataType;			//0下载所有 1仅下载图片 2仅下载视频

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;				//预留
        };

        //人员统计人员进入方向
        public enum ZLNET_IVA_HDCTTYPE
        {
            ZLNET_IVA_HDCT_IN = 0,		//人员进入
            ZLNET_IVA_HDCT_OUT			//人员离开
        };

        //智能报警类型
        public enum ZLNET_IVA_ALARM_TYPE
        {
            ZLNET_IVA_ATMALARMTYPE_ATM_DETECTAREA = 26,		//检测区域不明物报警(跟设备兼容)
            ZLNET_IVA_ATMALARMTYPE_ATM_KEYBOARDAREA,		//键盘区域不明物报警
            ZLNET_IVA_ATMALARMTYPE_ATM_CARDREGION,			//插卡口区域不明物报警
            ZLNET_IVA_ATMALARMTYPE_ATM_SHIELD,				//键盘罩区域不明物报警
            ZLNET_IVA_ATMALARMTYPE_ATM_ENTER,				//人员进入报警
            ZLNET_IVA_ATMALARMTYPE_ATM_LEAVE,				//人员离开报警
            ZLNET_IVA_ATMALARMTYPE_ATM_PROCESS_TOOLONG,		//人员长时间操作报警
            ZLNET_IVA_ATMALARMTYPE_ATM_PANEL_CAMERA_BLOCK,	//面板摄像头被堵报警
            ZLNET_IVA_ATMALARMTYPE_ATM_FACE_CAMERA_BLOCK,	//人脸摄像头被堵报警
            ZLNET_IVA_ATMALARMTYPE_ATM_PANEL_AMERA_NOSIGNAL,//面板摄像头无视频信号报警
            ZLNET_IVA_ATMALARMTYPE_ATM_FACE_CAMERA_NOSIGNAL,//人脸摄像头无视频信号报警
            ZLNET_IVA_ATMALARMTYPE_ATM_STRANGER,			//陌生人报警(正常人脸报警)
            ZLNET_IVA_ATMALARMTYPE_ATM_ARNORMAL,			//异常人报警
            ZLNET_IVA_ATMALARMTYPE_ATM_GPI,					//开关输入报警(外部报警)

            ZLNET_IVA_PLATEID_ALARM_TYPE = 51,				//车牌报警
            ZLNET_IVA_PLATEID_ALARM_GPI,					//车牌设备本地报警
            ZLNET_IVA_PARKING_ALARM = 55,					//车位报警信息

            ZLNET_IVA_STAFFCOUNT_FORWARD = 61,				//人头统计进入报警
            ZLNET_IVA_STAFFCOUNT_REVERSE,					//人头统计离开报警
            ZLNET_IVA_STAFFCOUNT_MULTIUSER,					//多人报警
            ZLNET_IVA_STAFFCOUNT_ALARM_GPI,					//开关输入报警(外部报警)

            ZLNET_IVA_SSB_TRAILING_WITHDRAWALS = 71,		//大厅尾随取款报警
            ZLNET_IVA_SSB_PEOPEL_HOVER,						//大厅人员徘徊
            ZLNET_IVA_SSB_PEOPEL_FELL,						//大厅人员倒地
            ZLNET_IVA_SSB_REMNANTS,							//大厅遗留物报警
            ZLNET_IVA_SSB_PEOPELS_GATHER,					//大厅多人聚集报警
            ZLNET_IVA_SSB_FORBIDDEN_ACCESS,                 //大厅禁止进入
            ZLNET_IVA_SSB_FIGHTING,                         //大厅打架事件
            ZLNET_IVA_SSB_CAMERA_NO_SIGNAL,					//大厅摄像头无信号报警
            ZLNET_IVA_SSB_CAMERA_ABNORMAL,					//大厅摄像头异常报警
            ZLNET_IVA_SSB_SPORTS_INVADE,					//加钞间运动入侵报警
            ZLNET_IVA_SSB_ROOM_CAMERA_NO_SIGNAL,			//加钞间摄像头无信号报警
            ZLNET_IVA_SSB_ALARM_GPI,						//开关输入报警(外部报警)
            ZLNET_IVA_SSB_SUSPICIOUS_TRAILING,				//大厅疑似尾随报警

            ZLNET_IVA_BZS_CROSS_FORWARD_ALARM = 101,		//正向跨线报警
            ZLNET_IVA_BZS_CROSS_REVERSE_ALARM,      		//反向跨线报警
            ZLNET_IVA_BZS_TOUCH_LINE_ALARM,					//正向触线报警
            ZLNET_IVA_BZS_TOUCH_LINE_NEG_DIR_ALARM, 		//反向触线报警
            ZLNET_IVA_BZS_CROSS_TWO_LINE_ALARM,				//双线检测报警
            ZLNET_IVA_BZS_AREA_ENTER_ALARM, 				//区域检测进入区域报警
            ZLNET_IVA_BZS_AREA_LEAVE_ALARM, 				//区域检测离开区域报警
            ZLNET_IVA_BZS_AREA_TOUCH_AREA_ALARM,			//区域检测触及区域报警
            ZLNET_IVA_BZS_AREA_LINGER_ALARM,				//区域检测徘徊报警
            ZLNET_IVA_BZS_AREA_APPEAR_ALARM,				//区域检测出现报警(子类型)
            ZLNET_IVA_BZS_AREA_DISAPPEAR_ALARM,				//区域检测消失报警(子类型)
            ZLNET_IVA_BZS_OBJECT_MOVE_ALARM,      			//盗移报警
            ZLNET_IVA_BZS_CAMERA_NO_SIGNAL_ALARM,			//摄像头无信号报警
            ZLNET_IVA_BZS_CAMERA_ABNORMAL_ALARM, 			//摄像头异常报警
            ZLNET_IVA_BZS_GPI_ALARM,						//开关输入报警(外部报警)
            ZLNET_IVA_BZS_LEGACY_ALARM,						//遗留物报警
            ZLNET_IVA_BZS_DENSITY_ALARM,					//密度检测报警
            ZLNET_IVA_BZS_TRAFFIC_ALARM,					//流量统计报警
            ZLNET_IVA_BZS_RETROGRADE_ALARM,					//逆行报警

            ZLNET_IVA_FACE_CAPTURE_ALARM = 131,				//人脸捕获报警
            ZLNET_IVA_FACE_ANALYSIS_NO_SIGNAL_ALARM,		//分析通道摄像头无信号
            ZLNET_IVA_FACE_PANORAMIC_NO_SIGNAL_ALARM,		//全景通道摄像头无信号
            ZLNET_IVA_FACE_GPI_ALARM,						//开关输入报警(外部报警)

            ZLNET_IVA_FTP_PIC_ALARM = 151,					//FTP图片上传(IPC传车牌报警图到NVR）

            ZLNET_IVA_ARMTYPE_MIN = ZLNET_IVA_ATMALARMTYPE_ATM_DETECTAREA,		//报警最小值
            ZLNET_IVA_ARMTYPE_MAX = ZLNET_IVA_FTP_PIC_ALARM,		//报警最大值(注意:增加报警类型需要替换成最大的类型值!!!)

        };

        public enum ZLNET_IVA_STAFF_ALARM_ENABLE_MASK
        {
            ZLNET_IVA_STAFF_FORWARD_MASK = 0x01,
            ZLNET_IVA_STAFF_REVERSE_MASK = 0x02,
            ZLNET_IVA_STAFF_MULTI_MASK = 0x04,
        };

        public enum ZLNET_IVA_ATM_ALARM_ENABLE_MASK
        {
            ZLNET_IVA_ATM_DETECTAREA_MASK = 0x1,				//检测区域不明物报警(跟设备兼容)
            ZLNET_IVA_ATM_KEYBOARDAREA_MASK = 0x2,				//键盘区域不明物报警
            ZLNET_IVA_ATM_CARDREGION_MASK = 0x4,				//插卡口区域不明物报警
            ZLNET_IVA_ATM_SHIELD_MASK = 0x8,					//键盘罩区域不明物报警
            ZLNET_IVA_ATM_ENTER_MASK = 0x10,					//人员进入报警
            ZLNET_IVA_ATM_LEAVE_MASK = 0x20,					//人员离开报警
            ZLNET_IVA_ATM_PROCESS_TOOLONG_MASK = 0x40,			//人员长时间操作报警
            ZLNET_IVA_ATM_PANEL_CAMERA_BLOCK_MASK = 0x80,		//面板摄像头被堵报警
            ZLNET_IVA_ATM_FACE_CAMERA_BLOCK_MASK = 0x100,		//人脸摄像头被堵报警
            ZLNET_IVA_ATM_PANEL_AMERA_NOSIGNAL_MASK = 0x200,	//面板摄像头无视频信号报警
            ZLNET_IVA_ATM_FACE_CAMERA_NOSIGNAL_MASK = 0x400,	//人脸摄像头无视频信号报警
            ZLNET_IVA_ATM_STRANGER_MASK = 0x800,				//陌生人报警(正常人脸报警)
            ZLNET_IVA_ATM_ARNORMA_MASK = 0x1000,				//异常人报警
            ZLNET_IVA_ATM_FACE_MULTI = 0x2000,					//多人脸报警
        };

        //自助银行报警类型使能
        public enum ZLNET_IVA_SSB_ALARM_ENABLE_MASK
        {
            ZLNET_IVA_SSB_TRAILING_WITHDRAWALS_MASK = 0x1,		//大厅尾随取款报警
            ZLNET_IVA_SSB_PEOPEL_HOVER_MASK = 0x2,				//大厅人员徘徊
            ZLNET_IVA_SSB_PEOPEL_FELL_MASK = 0x4,				//大厅人员倒地
            ZLNET_IVA_SSB_REMNANTS_MASK = 0x8,					//大厅遗留物报警
            ZLNET_IVA_SSB_PEOPELS_GATHER_MASK = 0x10,			//大厅多人聚集报警
            ZLNET_IVA_SSB_FORBIDDEN_ACCESS_MASK = 0x20,			//大厅禁止进入
            ZLNET_IVA_SSB_FIGHTING_MASK = 0x40,					//大厅打架事件
            ZLNET_IVA_SSB_CAMERA_NO_SIGNAL_MASK = 0x80,			//大厅摄像头无信号报警
            ZLNET_IVA_SSB_CAMERA_ABNORMAL_MASK = 0x100,			//大厅摄像头异常报警
            ZLNET_IVA_SSB_SPORTS_INVADE_MASK = 0x200,			//加钞间运动入侵
            ZLNET_IVA_SSB_ROOM_CAMERA_NO_SIGNAL_MASK = 0x400,	//加钞间摄像头无信号报警
            ZLNET_IVA_SSB_SUSPICIOUS_TRAILING_MASK = 0x1000,	//大厅疑似尾随报警
        };

        //周界报警类型使能
        public enum ZLNET_IVA_BZS_ALARM_ENABLE_MASK
        {
            ZLNET_IVA_BZS_SINGLE_WARNING_LINE_MASK = 0x01,			//正向跨越报警
            ZLNET_IVA_BZS_NEG_CROSS_WARNING_LINE_MASK = 0x02,       //反向跨线报警
            ZLNET_IVA_BZS_TOUCH_WARNING_LING_MASK = 0x04,           //正向触线报警
            ZLNET_IVA_BZS_NEG_TOUCH_WARNING_LINE_MASK = 0x08,        //反向触线报警
            ZLNET_IVA_BZS_DOUBLE_WARNING_LINE_MASK = 0x10,			//周界双警界线报警
            ZLNET_IVA_BZS_ENTER_AREA_WARNING_MASK = 0x20,			//进入区域报警
            ZLNET_IVA_BZS_LEAVE_AREA_WARNING_MASK = 0x40,           //离开区域报警
            ZLNET_IVA_BZS_TOUCH_AREA_WARNING_MASK = 0x80,           //触及区域报警
            ZLNET_IVA_BZS_LINGER_AREA_WARNING_MASK = 0x100,         //区域检测徘徊报警
            ZLNET_IVA_BZS_APPEAR_AREA_WARNING_MASK = 0x200,         //区域检测出现报警
            ZLNET_IVA_BZS_DISAPPEAR_AREA_WARNING_MASK = 0x400,		//区域检测消失报警
            ZLNET_IVA_BZS_OBJECT_STOLEN_MASK = 0x800,				//物品盗移报警
            ZLNET_IVA_BZS_CAMERA_NO_SIGNAL_MASK = 0x1000,           //摄像头无信号
            ZLNET_IVA_BZS_CAMERA_ABNORMAL_MASK = 0x2000,			//摄像头异常报警
        };

        //人脸报警类型使能
        public enum ZLNET_IVA_FACE_ALARM_ENABLE_MASK
        {
            ZLNET_IVA_FACE_CAPTURE_MASK = 0x01,						//人脸捕获报警
            ZLNET_IVA_FACE_CAMERA_NO_SIGNAL_MASK = 0x02,			//人脸通道摄像头无信号
            ZLNET_IVA_PANORAMIC_CAMERA_NO_SIGNAL_MASK = 0x04,		//全景通道摄像头无信号
        };

        //报警下载数据类型
        public enum ZLNET_IVA_DOWNLOAD_TYPE
        {
            ZLNET_IVA_DOWNLOAD_PREPIC = 0,	//报警前图
            ZLNET_IVA_DOWNLOAD_PICTURE,		//报警图片
            ZLNET_IVA_DOWNLOAD_VIDEO,		//视频
        };

        //报警下载状态
        public enum ZLNET_IVA_DOWNLOAD_STATE
        {
            ZLNET_IVA_DOWNSTATE_DOWN = 0,	//下载中
            ZLNET_IVA_DOWNSTATE_ONE_END,	//单张图片或一段视频结束
            ZLNET_IVA_DOWNSTATE_ALL_END,	//全部数据下载完成
        };

        //报警实时视频流类型定义
        public enum ZLNET_IVA_ALARMVIDEOTYPE
        {
            ZLNET_VIDEO_START = 1,			//视频流开始
            ZLNET_VIDEO_ALARM,				//视频流传送中
            ZLNET_VIDEO_STOP				//视频流结束
        };

        //区域类型
        public enum ZLNET_IVA_AREA_TYPE
        {
            ZLNET_IVA_AREA_NULL = -1,
            ZLNET_IVA_AREA_WARN = 0,				//报警区域	多
            ZLNET_IVA_AREA_KEYBOARD,				//键盘区域
            ZLNET_IVA_AREA_CARDPORT,				//插卡口区域
            ZLNET_IVA_AREA_KEYMASK,					//键盘罩区域
            ZLNET_IVA_AREA_HUMAN,					//人员活动区域 多
            ZLNET_IVA_AREA_FACEHUMAN,				//人脸区域	面板右边
            ZLNET_IVA_AREA_OBJSIZE,					//目标区域 (最小检测尺寸)
            ZLNET_IVA_AREA_SCREEN,					//屏幕区域	(没实现)
            ZLNET_IVA_VEHICLE_DETECTION_AREA,		//车辆检测区域
            ZLNET_IVA_VEHICLES_PROHIBITED_AREA,		//车辆屏蔽区域
            ZLNET_IVA_STAFF_DETECTION_LINE,			//人数统计检测线
            ZLNET_IVA_STAFF_DETECTION_REGION,		//人数统计检测区域
            ZLNET_IVA_BZS_PROCESS_REGION = 30,		//周界处理区域
            ZLNET_IVA_BZS_SHIELD_REGION,			//周界屏蔽区域
            ZLNET_IVA_BZS_CROSS_ONE_LINE_RULE,		//周界单线检测
            ZLNET_IVA_BZS_CROSS_TWO_LINE_RULE,		//周界双线检测
            ZLNET_IVA_BZS_AREA_DETECT_RULE,			//周界区域检测
            ZLNET_IVA_BZS_OBJECT_MOVE,				//周界盗移检测
            ZLNET_IVA_BZS_CROSS_LINE_RULE,			//新周界跨线单线检测
            ZLNET_IVA_BZS_CROSS_FENCE_RULE,			//新周界围栏检测
            ZLNET_IVA_SSB_HALL_PROCESS = 45,		//自助厅处理区域
            ZLNET_IVA_SSB_HALL_WITHDRAWALS,			//自助厅取款区域
            ZLNET_IVA_SSB_HALL_SHIELD,				//自助厅屏蔽区域
            ZLNET_IVA_SSB_ROOM_PROCESS,				//加钞间处理区域
            ZLNET_IVA_SSB_ROOM_SHIELD,				//加钞间屏蔽区域
            ZLNET_IVA_FACE_DETECT,					//人脸检测区域
            ZLNET_IVA_FACE_OVERLAY,					//人脸叠加区域
            ZLNET_IVA_FACE_SHIELD,					//人脸屏蔽区域 原保留一
            ZLNET_IVA_SSB_MULTI_LINE,				//自助银行多人警戒线	原保留二
            ZLNET_IVA_ATM_AREA_SHIELD,				//ATM屏蔽区域
            ZLNET_IVA_GRADIENT_LINE,				//梯度线
            ZLNET_IVA_485_OVERLAY_AREA,				//485叠加区域
            ZLNET_IVA_FACE_DETECT_SMALL,			//小人脸检测区域
            ZLNET_IVA_FACE_DETECT_BIG,				//大人脸检测区域
            ZLNET_IVA_AREA_TOTAL,
        };

        //视频叠加模式
        public enum ZLNET_IVA_VIDEOBLEND_MODE
        {
            ZLNET_IVA_VIDEOBLEND_PREVIEW = 0x1,		//网络预览叠加
            ZLNET_IVA_VIDEOBLEND_PIC = 0x2,			//抓图叠加
            ZLNET_IVA_VIDEOBLEND_LOCAL = 0x4,		//设备本地视频输出叠加
            ZLNET_IVA_VIDEOBLEND_DEBUG = 0x8,		//算法调试
            ZLNET_IVA_VIDEOBLEND_RULE = 0x10,       //网络预览规则框
            ZLNET_IVA_VIDEOBLEND_INFO = 0x20,       //网络预览报警框
            ZLNET_IVA_VIDEOBLEND_TRACK = 0x40,      //网络预览跟踪框、人脸跟踪
            ZLNET_IVA_VIDEOBLEND_OVERLAY = 0x80,    //是否叠加人脸区域
            ZLNET_IVA_TRACK_INFO = 0x100,			//跟踪轨迹
        };

        //在线用户操作类型
        public enum ZLNET_IVA_ONLINE_OPRATE
        {
            ZLNET_IVA_ONLINE_NULL = 0,
            ZLNET_IVA_ONLINE_KICK,		//踢除
            ZLNET_IVA_ONLINE_BLOCK,		//屏蔽
        };

        //车牌检测参数设置
        public enum ZLNET_IVA_LICENSE_PLATE_TYPE
        {
            ZLNET_IVA_PLATEID_CONFIGFLAG_NONE = 0x0,				//无配置
            ZLNET_IVA_PLATEID_CONFIGFLAG_VCOMPRESS = 0x1,   		//垂直方向压缩
            ZLNET_IVA_PLATEID_CONFIGFLAG_FIELDIMG = 0x2,   			//是否是场图像
            ZLNET_IVA_PLATEID_CONFIGFLAG_OUTPUTSINGLEFRAME = 0x4,	//军车识别
            ZLNET_IVA_PLATEID_CONFIGFLAG_INDIVIDUA = 0x8,   		//个性化车牌识别
            ZLNET_IVA_PLATEID_CONFIGFLAG_TWOROWYELLOW = 0x10,   	//双排黄色车识别
            ZLNET_IVA_PLATEID_CONFIGFLAG_ARMPOLICE = 0x20,   		//双排军车识别
            ZLNET_IVA_PLATEID_CONFIGFLAG_TWOROWARMY = 0x40,  		//同一车多幅图像只输出一个结果
            ZLNET_IVA_PLATEID_CONFIGFLAG_TRIGGE = 0x80,				//是否同时发送场景图像
        };

        //车辆方向
        public enum ZLNET_IVA_PLATEID_DRIVE
        {
            ZLNET_IVA_PLATEID_DRIVE_NULL = 0x0,
            ZLNET_IVA_PLATEID_DRIVE_LEFT,		//向左
            ZLNET_IVA_PLATEID_DRIVE_RIGHT,		//向右
            ZLNET_IVA_PLATEID_DRIVE_UP,		    //向上
            ZLNET_IVA_PLATEID_DRIVE_DOWN,		//向下
        };

        //逆向行驶报警
        public enum ZLNET_IVA_REVERSE_DRIVE_SET
        {
            ZLNET_IVA_EVERSE_DRIVE_NONE = 0x0,
            ZLNET_IVA_EVERSE_DRIVE_LEFT = 0x1,   	//向左
            ZLNET_IVA_EVERSE_DRIVE_RIGHT = 0x2,   	//向右
            ZLNET_IVA_EVERSE_DRIVE_UP = 0x4,		//向上
            ZLNET_IVA_EVERSE_DRIVE_DOWN = 0x8,   	//向下
        };

        //车牌颜色
        public enum ZLNET_IVA_PLATEID_COLOR
        {
            ZLNET_IVA_PLATEID_COLORUNKNOWN = 0,		//未知颜色
            ZLNET_IVA_PLATEID_COLORBLUE,			//蓝色
            ZLNET_IVA_PLATEID_COLORYELLOW,			//黄色
            ZLNET_IVA_PLATEID_COLORWHITE,			//白色
            ZLNET_IVA_PLATEID_COLORBLACK,			//黑色
            ZLNET_IVA_PLATEID_COLORGREEN,			//绿色
        };

        //车牌类型
        public enum ZLNET_IVA_PLATEID_TYPE
        {
            ZLNET_IVA_PLATEID_TYPEUNKNOWN = 0,		//未知类型
            ZLNET_IVA_PLATEID_TYPEBLUE,				//蓝车牌
            ZLNET_IVA_PLATEID_TYPEBLACK,			//黑车牌
            ZLNET_IVA_PLATEID_TYPEYELLOW,			//单排黄色车牌
            ZLNET_IVA_PLATEID_TYPEYELLOW2,			//双排黄色车牌
            ZLNET_IVA_PLATEID_TYPEPOLICE,			//警车车牌
            ZLNET_IVA_PLATEID_TYPEARMPOL,			//军警车牌
            ZLNET_IVA_PLATEID_TYPEINDIVI,			//个性化车牌
            ZLNET_IVA_PLATEID_TYPEARMY,				//单排军用车牌
            ZLNET_IVA_PLATEID_TYPEARMY2,			//双排军用车牌
            ZLNET_IVA_PLATEID_TYPEEMBASSY,			//大使馆车牌
            ZLNET_IVA_PLATEID_TYPEHONGKONG,			//香港车牌
        };

        //周界禁止区域类型
        public enum ZLNET_IVA_BZS_AREA_ALARM_MASK
        {
            ZLNET_IVA_BZS_AREA_ENTER = 0x0001,		    // 进入区域
            ZLNET_IVA_BZS_AREA_LEAVE = 0x0002,		    // 离开区域
            ZLNET_IVA_BZS_AREA_TOUCH_AREA = 0x0004,		// 触及区域
            ZLNET_IVA_BZS_AREA_OBJMOVE = 0x0008,		// 盗移
            ZLNET_IVA_BZS_AREA_LINGER = 0x0010,		    // 徘徊
            ZLNET_IVA_BZS_AREA_APPEAR = 0x0020,		    // 出现
            ZLNET_IVA_BZS_AREA_DISAPPEAR = 0x0040		// 消失
        };

        //周界单线使能
        public enum ZLNET_IVA_BZS_CROSS_LINE_MASK
        {
            ZLNET_IVA_BZS_CROSS_ONEWAY = 0x0001,		// 正向跨线
            ZLNET_IVA_BZS_CROSS_TWOWAY = 0x0002,		// 反向跨线
            ZLNET_IVA_BZS_TOUCHLINE_ONEWAY = 0x0004,	// 正向触线
            ZLNET_IVA_BZS_TOUCHLINE_TWOWAY = 0x0008 	// 反向触线
        };

        //背景更新掩码
        public enum ZLNET_IVA_BACKGROUND_UPDATE_MASK
        {
            ZLNET_IVA_ATM_MASK = 0x1,			//ATM 0-忽略 1-重启
            ZLNET_IVA_PLATEID_MASK = 0x2,		//车牌 0-忽略 1-重启
            ZLNET_IVA_STAFFCOUNT_MASK = 0x4,	//人头计数 0-忽略 1-重启
            ZLNET_IVA_SSB_MASK = 0x8,			//自助银行 0-忽略 1-重启
            ZLNET_IVA_BZS_MASK = 0x10,			//周界 0-忽略 1-重启
            ZLNET_IVA_VQDS_MASK = 0x20,			//周界 0-忽略 1-重启
        };

        //人头分析通道
        public enum ZLNET_IVA_STAFF_COUNT_CHANNEL
        {
            ZLNET_IVA_STAFFCOUNT_ANALYSIS_CH = -1,      //代表以前的一路设备
            ZLNET_IVA_STAFFCOUNT_ANALYSIS_CH1 = 0,
            ZLNET_IVA_STAFFCOUNT_ANALYSIS_CH2,
            ZLNET_IVA_STAFFCOUNT_ANALYSIS_CH3,
            ZLNET_IVA_STAFFCOUNT_ANALYSIS_CH4,
        };

        //人脸捕获模式
        public enum ZLNET_IVA_FACE_CAPTURE_MODE
        {
            ZLNET_IVA_FACE_CAPTURE = 0,		//抓拍模式
            ZLNET_IVA_FACE_THAN,			//比对模式
        };

        //人脸叠加模式
        public enum ZLNET_IVA_FACE_OVERLAY_MODE
        {
            ZLNET_IVA_FACE_NO_OVERLAY = 0,		//不叠加
            ZLNET_IVA_FACE_OVERLAY_FACE,		//叠加人脸
            ZLNET_IVA_FACE_OVERLAY_FACE_VIDEO,	//叠加人脸视频
        };

        //485叠加模式
        public enum ZLNET_IVA_485_OVERLAY_MODE
        {
            ZLNET_IVA_485_NO_OVERLAY = 0,	//不叠加
            ZLNET_IVA_485_OVERLAY,			//叠加485
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMRECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        };

        //时间结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_TIME
        {
            public int tm_year;
            public int tm_mon;     // [0,11]
            public int tm_mday;    // [1,31]
            public int tm_hour;    // [0,23]
            public int tm_min;     // [0,59]
            public int tm_sec;     // [0,59]
        };

        //点坐标
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_POINT
        {
            public int x;
            public int y;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_RECTINFO
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
            public int nConfidence;	// 人脸分数
            public int nTrackID;		// 追踪ID
        };

        //区域结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_MONITORREGION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_POLYGON_POINT, ArraySubType = UnmanagedType.U4)]
            public uint[] point;              //多边形点坐标(高16位为Y, 低16位为X)

            public Int16 pointNum;			//有效点数
            public ZLNET_IVA_AREA_TYPE regionType;			//区域类型
        };

        //视频通道模式配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_CHANNEL_CONFIG
        {
            public int size;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_VIDEOBLEND_MODE[] blendMode;	            //视频叠加模式

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL, ArraySubType = UnmanagedType.I4)]
            public int[] videoMode;				//逻辑通道和物理通道的映射关系(已不用)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL / 2, ArraySubType = UnmanagedType.I4)]
            public int[] asscEnabel;			    //关联分析使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL / 2, ArraySubType = UnmanagedType.I4)]
            public int[] faceCompare;			//人脸连续对比

            public int videoPinMode;			//模拟视频通道输出掩码
        };

        //报警信息图片
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARMINFO_PIC
        {
            public uint picMode;	//0:实时图片 1：预录图片
            public uint logicChn;	//逻辑通道号
            public uint dataLen;	//数据长度
            public IntPtr data;		//数据
        };

        //智能报警共用部分
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_EVENT
        {
            public uint id;				// 日志ID
            public ZLNET_DEVTIME time;		    // 日期
            public UInt16 alarmType;		// 报警类型(ZLNET_IVA_ALARM_TYPE)
            public byte logicChn;		// 产生报警的通道
            public byte picNum;   		// 图片张数
            public ZLNET_DEVTIME stTime;	        // 联动录像开始时间
            public ZLNET_DEVTIME endTime;	    // 联动录像结束时间
            public uint driveno;		// 磁盘号(老设备, 磁盘号和起始簇号都为0)
            public uint startcluster;	// 起始簇号
            public uint bAlarmDisapper;	// 报警消失 0结束 1开始

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserve;		// 保留
        };

        //ATM报警事件详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_DETAIL
        {
            public uint rectValidNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_ATMALARM_RECT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_RECTINFO[] rect;           // 区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserve;        //保留
        };

        //ATM报警上传日志+区域信息+图片
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_ALARMINFO
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_ATM_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //人数统计报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_HDCRECT
        {
            public ZLNET_IVA_HDCTTYPE type;
            public ZLNET_RECT rect;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;
        };

        //报警信息类型
        public enum ZLNET_IVA_ALARMINFO_TYPE
        {
            ZLNET_IVA_ALARMINFO_NULL = 0,
            ZLNET_IVA_ALARMINFO_PICTURE = 1,    //图片
            ZLNET_IVA_ALARMINFO_VIDEO = 2,	    //视频
        };

        // 报警联动配置子项
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARM_ASSCONFIG
        {
            public int size;
            public int bVoice;					//语音提示
            public int bAlarmOutEn;			//报警输出
            public int dwAlarmOut;				//报警输出通道掩码
            public int iAOLatch;				//报警输出延时
            public int iRecLatch;				//报警录像延时

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL)]
            public byte[] asschn;                //物理通道关联动作，值为报警信息类型(ZLNET_IVA_ALARMINFO_TYPE)组合

            public int bFtp;					//是否上传FTP
            public int bEmail;					//是否上传Emil
        };

        // 外部报警配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_GPI_ASSCONFIG
        {
            public int enable;			//使能
            public int polarity;		//极性
            public ZLNET_IVA_ALARM_ASSCONFIG assc;	        //联动项
        };

        // 报警录像配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARM_RECORD
        {
            public Int16 pretime;			//报警前录像时间(秒)
            public Int16 aftertime;			//报警后录像时间(秒)
        };

        // 星期时间段
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_WEEK_SECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] sec;
        };

        // 工作表信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_WORKSHEET
        {
            public int nInterval;	//音频播放间隔
            public ZLNET_IVA_WEEK_SECTION chnR;	    //时间段
        };

        //人脸区域结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_FACEAREA
        {
            public int maxsize;		//检测最大像素
            public int minsize;		//检测最小像素
            public int left;
            public int top;
            public int right;
            public int bottom;
        };

        //人脸检测区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_ALARMAREA_FACE
        {
            public int size;
            public int logicChn;			//逻辑通道号
            public int faceAreaNum;		//有效区域数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_FACE_AREA, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ATM_FACEAREA[] faceArea;
        };

        //ATM检测区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_DETECTAREA
        {
            public int size;
            public int logicChn;				//逻辑通道号
            public int alarmAreaNum;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_ATM_TOTAL, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_MONITORREGION[] detectArea;	            //区域数组
        };

        //ATM配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_PARAM
        {
            public int size;
            public int waittime;				//等待报警时间
            public int updatebk;				//更新背景时间
            public int camerablocked;			//摄像头遮挡报警时间
            public int atmcamerathreold;		//ATM摄像头遮挡阀值
            public int operatorlong;			//长时间不操作时间
            public int gradientline;			//梯度线检测灵敏度
            public int monitorarea;			//活动区域检测灵敏度
        };

        //ATM异常人脸参数设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_ARNORMAL_FACE_PARAM
        {
            public int size;
            public int enable;					//使能
            public int holdtime;				//遮挡持续时间
            public int tracktime;				//最大跟踪时间
            public int forebg;					//前景最小像素差阀值
            public int tagminarea;				//物体最小面积阀值
            public int stillperfect;			//完全静止时间阀值
            public int stillness;				//人静止不动的最长时间阀值
            public int face;					//人脸检测阀值
            public int facedetect;				//人脸检测敏感系数
            public int alarm;					//持续报警
            public int score;					//分数阀值
        };

        //视频颜色结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_VIDEOCOLOR
        {
            public ZLNET_COLOR_CFG dstColor;       // 画面颜色属性
            public int iEnable;        //时间段使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5, ArraySubType = UnmanagedType.I4)]
            public int[] Res;            //预留
        };

        //ATM人脸视频颜色参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_CONFIG_VIDEOCOLOR
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = N_COLOR_SECTION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_VIDEOCOLOR[] dstVideoColor;      //视频颜色结构
        };

        // ATM报警查询日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_LOG
        {
            public uint size; 	 //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;  //基本信息
            public ZLNET_IVA_ATM_DETAIL IVSDetail; //详细信息
        };

        //智能报警使能
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARM_ENABLE
        {
            public int size;
            public int nType;			//设备类型
            public int nSubType;
            public int nAlarmEnable;	//ATM按位参看ZLNET_IVA_ATM_ALARM_ENABLE_MASK 
            //周界参看ZLNET_IVA_BZS_ALARM_ENABLE_MASK 
            //自助银行参看ZLNET_IVA_SSB_ALARM_ENABLE_MASK 
            //人脸参看ZLNET_IVA_FACE_ALARM_ENABLE_MASK
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DEV_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szDevSerialNo;	                    //序列号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VER_SOFTWARE)]
            public string szSoftWareVersion;	                //软件版本号

            public uint dwSoftwareBuildDate;				//软件BUILD
            public byte byVideoCaptureNum;					//视频口In数量
            public byte byVideoOutNum;						//视频口Out数量
            public byte byAudioCaptureNum;					//音频口In数量
            public byte byAudioOutNum;						//音频口Out数量
            public byte byAlarmInNum;						//报警In口数
            public byte byAlarmOutNum;						//报警Out口数
            public byte byTalkInChanNum;					//对讲口In数量
            public byte byTalkOutChanNum;					//对讲口Out数量
            public byte byNetIONum;							//网络口数
            public byte byComIONum;							//串口数量
            public byte byLPTIONum;							//并口数量
            public byte byVideoStandard;					//视频制式:0-PAL,1-NTSC
        };

        // 自动维护配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_AUTOMAINTAIN
        {
            public byte byAutoRebootDay;		// 自动重启；0：从不, 1：每天，2：每星期日，3：每星期一，......
            public byte byAutoRebootTime;		// 0：0:00，1：1:00，......23：23:00
        };

        // 注册IP网络配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_REGISTIP
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string ip;				// IP

            public int port;			// 端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string domainName;	    // dvr域名
        };

        // 注册IP网络配置列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_REGISTIP_LIST
        {
            public int validNum;		//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_REGIST_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_REGISTIP[] hostIP;
        };

        // 在线用户信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_USER_ONLINE
        {
            public int id;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string ip;		// IP

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_LENGTH_EX)]
            public string name;	// 用户名称
        };

        // 在线用户信息列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_USER_ONLINE_LIST
        {
            public int validNum;		//有效个数
            public ZLNET_IVA_ONLINE_OPRATE opt;			// 操作类型
            public int blockTime;		// 屏蔽时间（当操作类型为ZLNET_IVA_ONLINE_BLOCK的时候有效）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_ONLINE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_USER_ONLINE[] online;
        };

        // 智能设备上传信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ZLNET_IVA_UPLOAD
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string szDomainName;	// 设备域名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string szIP;			// 设备IP地址

            public int nPort;			//设备端口号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szSerial;		//设备序列号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_ALARM_OCCUR_TIME_LEN)]
            public string szOccurTime;	//上传时间
        };

        //ATM算法调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ARITHMETIC_DEBUG_ITEM
        {
            public int size;			//结构体大小
            public int bDebugInfo;		//调试信息
            public int bTargetFrame;	//目标框
            public int bRuleFrame;		//规则框
        };

        //算法调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ARITHMETIC_DEBUG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_ARITHMETIC_DEBUG_LEN, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ARITHMETIC_DEBUG_ITEM[] arithDebug;
        };

        //配置OSD
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_CHANNELNAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHAN_NAME_LEN)]
            public string szName;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_OSD_CONFIG
        {
            public int size;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL, ArraySubType = UnmanagedType.I4)]
            public int[] bTimeDisplay;		//是否显示时间OSD，物理通道为准

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL, ArraySubType = UnmanagedType.I4)]
            public int[] bChannelDisplay;	//是否显示通道OSD，物理通道为准

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_CHANNELNAME[] szChannelName;	    //通道名称，物理通道为准
        };

        //音频上传信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_AUDIO_UPLOAD_INFO
        {
            public int atmAlarmType;	//ATM报警类型
            public int channel;		//通道号
        };

        //音频上传信息列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_AUDIO_UPLOAD_INFO
        {
            public int nCount;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_AUDIO_UPLOAD_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_AUDIO_UPLOAD_INFO[] pAudioInfo;
        };

        //智能视频报警调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARM_DEBUG
        {
            public int nATMWarns;       //已经报警的数量
            public int nATMBlocks;      //面板堵塞计数
            public int nProbeBlocks;    //人脸堵塞计数
            public int nFaceTrackID;    //人脸跟踪最新ID
            public byte bATMProbe;		 //人脸视频中检测到人员
            public byte bATMMoving;      //面板视频中检测到人员
            public byte bATMHands;       //人员操作ATM机
        };

        //车辆检测区域和车辆屏蔽区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_REGION
        {
            public int size;
            public int areaNum;			//有效区域数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_LICENSE_PLATE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_MONITORREGION[] detectArea;	        //区域数组
        };

        //OSD车牌参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_OSD_LICENSE_PALTE_PARAM
        {
            public int size;						//结构体大小
            public int superimposedType;			//叠加方式
            public int superimposedX;				//叠加坐标x(像素)
            public int superimposedY;				//叠加坐标Y(像素)
            public int superimposedSize;			//叠加显示尺寸
            public int superimposedTime;			//叠加停留时间
        };

        //车牌参数配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PLATEID_PARAM
        {
            public int size;						//结构体大小
            public int IVSPlateIDSpringType;		//触发模式   0  视频模式  1  串口模式
            public int nMinPlateWidth;				//检测的最小车牌宽度，以像素为单位
            public int nMaxPlateWidth;				//检测的最大车牌宽度，以像素为单位
            public int nConfigFlag;				//车牌检测设置,按位参见ZLNET_IVA_LICENSE_PLATE_TYPE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.I4)]
            public int[] nLocalProvince;			    //本省车牌设置

            public float fSlantAngle;				//倾斜角度
        };

        //车牌报警上传(日志+区域)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PLATEID_DETAIL
        {
            public int bAlarm;					//车辆是否逆行

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string byLicense;				//车牌号字符形式表示

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] byCharScore;	        //每个车牌号的分数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARMRECT[] rcCharPos;		        //每个字符的位置

            public int nCharNum;			    //车牌字符数
            public ZLNET_IVA_PLATEID_COLOR nColor;		            //车牌颜色
            public ZLNET_IVA_PLATEID_TYPE nType;		            //车牌类型
            public int nConfidence;	        //车牌检测分数
            public int nBright;		        //亮度
            public ZLNET_IVA_PLATEID_DRIVE nDirection;	            //车辆方向
            public ZLNET_IVA_AREA_TYPE nWhy;		            //检测区域类型 0：无区域 8:车辆检测区域 9:车辆屏蔽区域
            public ZLNET_ALARMRECT rcLocation;	            //车牌位置

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] res;
        };

        //车牌报警上传日志+区域信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PLATEID_ALARMINFO
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_PLATEID_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //车牌查询日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PLATEID_LOG
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_PLATEID_DETAIL IVSDetail;      //详细信息
        };

        public enum ZLNET_HDCTTYPE
        {
            HDCT_IN = 0,
            HDCT_OUT
        };

        //逆向行驶报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PLATEID_ALARM
        {
            public int size;							//结构体大小
            public int nEnable;						//报警使能
            public int nDirection;						//报警触发方向,按位参看ZLNET_IVA_REVERSE_DRIVE_SET
            public int nMinScore;						//报警上传最小分数
        };

        //人数统计报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HDCRECT
        {
            public ZLNET_HDCTTYPE type;
            public ZLNET_ALARMRECT rect;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public int[] nReserved;
        };

        //人员统计配置参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_STAFF_COUNT_CONFIG
        {
            public int size;						//结构体大小
            public int nWidth;                     //检测区域宽度
            public int nHeight;                    //检测区域高度
            public int nObjWidth;                  //检测宽度
            public ZLNET_IVA_POINT ptStart;				    //区域起始点
            public ZLNET_IVA_POINT ptEnd;					    //区域终点
            public ZLNET_IVA_POINT ptDirection;			    //方向点
            public int nPassFrames;				//目标运动速度
            public int nMutiObjWidth;				//多目标宽度
            public int nMutiObjWidthEdge;         	//边缘宽度
            public int nThreshBackDiff;			//背景差阈值
            public int nThreshFrameDiff;			//帧间差阈值
            public int bStartPtLabel;              //Start端抑制
            public int bEndPtLabel;                //End端抑制
            public int nHalfObjW;                  //抑制宽度
        };

        //人员统计详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_STAFFCOUNT_DETAIL
        {
            public int numRegion;          //区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_HDCRECT[] region;             //区域信息

            public uint totalInCount;		//从设备启动到当前时间总共进入的人数
            public uint totalOutCount;		//从设备启动到当前时间总共离开的人数
            public int flag;   			// 标记，如果设备或算法重启，该标记将发生变化,-1表示该参数无效
            public int nInCount; 	        //进入人数
            public int nOutCount; 	        //离开人数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14, ArraySubType = UnmanagedType.I4)]
            public int[] reserve;
        };

        //人员统计日志信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_STAFFCOUNT_LOG
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_STAFFCOUNT_DETAIL IVSDetail;      //详细信息
        };

        //人员统计上传日志+区域信息+图片
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ALARMINFO_STAFFCOUNT
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_STAFFCOUNT_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //人数统计算法调试结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_STAFF_ARITH_DEBUG
        {
            public int numRegion;      //区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_HDCRECT[] region;         //区域信息

            public int nInCount; 	    //进入人数
            public int nOutCount; 	    //离开人数
        };

        //人数统计多人报警参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_STAFF_MULTIUSERPARAM
        {
            public int nSize;
            public int nNum;        //多人报警下限

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;
        };

        //周界防范参数设置

        //算法区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_REGION
        {
            public int size;
            public int areaNum;	    //有效区域数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_BZS_PROCESS_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_MONITORREGION[] detectArea;	    //区域数组
        };

        //算法基本设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_BASIC_SETTIINGS
        {
            public int nSize;						//结构体大小
            public int nWidth;					    //检测区域宽度
            public int nHeight;					//检测区域高度
            public int nForegroundTh;				//前景差阈值

            public ZLNET_IVA_BZS_REGION pPolygonNoProc;				//处理区域(1)

            public int nObjHeight;					//高度标尺
            public int bImgTransform;				//是否校正图像

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
            public float[] fTransformParam;			//校正图像参数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
            public float[] fTransformParamInv;			//校正图像反转参数
        };

        //功能参数设置

        //算法参数设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_ALGORITHM_PARAM
        {
            public int nSize;							//结构体大小
            public int nCmd;							//0忽略 !0重启算法

            /*丢包参数设置*/
            public int nMinSizeWidthHeight;			//物体最小宽度和高度
            public int nMaxRectArea;					//物体最大外包面积
            public int nMinForegroundArea;				//最小占有前景像素点数
            public int nThresholdTime;					//持续多长时间报警

            /*徘徊参数设置*/
            public int nThresholdBlockCntLingering;	//总的移动距离
            public int nStayingFrameTh;				//总的逗留时间

            /*多人聚集参数设置*/
            public int nThresholdMultiPeoPersonCnt;	//报警人数
            public int nThresholdMultiPeoFGPercent;	//前景面积百分比
            public int nWarningIntervalFrmsMultiPeo;	//两次报警间隔
            public int nThresholdMultiPeoFrmCnt;		//确认报警阈值

            /*剧烈运动检测*/
            public int nTHresholdFastMove;				//灵敏度（1~100）
            public int nWarningIntervalFrmsFastMove;	//两次报警间隔
        };

        //摄像机异常参数设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_CAMERA_ABNORMAL_PARAM
        {
            public int nSize;					//结构体大小
            public int bDetectBright;			//亮度异常开关
            public int bDetectNoSignal;		//信号丢失开关
            public int bDetectBlock;			//视频遮挡开关
            public int bDetectColor;			//色彩异常开关
            public int bDetectBlur;			//画面模糊开关
            public int bDetectNoise;			//图像噪声开关

            public int nBrightSensitivity;		//亮度异常灵敏度
            public int nNoSignalSensitivity;	//信号丢失灵敏度
            public int nBlockSensitivity;		//视频遮挡灵敏度
            public int nColorSensitivity;		//色彩异常灵敏度
            public int nBlurSensitivity;		//画面模糊灵敏度
            public int nNoiseSensitivity;		//图像噪声灵敏度

            public int nAlarmDurationTh;		//报警持续时间阈值
            public int nBrightTh;				//镜头遮挡亮度阈值
        };

        //报警规则设置
        //区域及盗移
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_AREA_DETECT
        {
            public int nSize;					// 结构体大小
            public int bEnable;				// 使能
            public int nSerial;				// 区域序号
            public int nRegionMask;     		// 区域类型掩码，参看ZLNET_IVA_BZS_AREA_ALARM_MASK
            public ZLNET_IVA_MONITORREGION pynPos;			        // 区域位置
            public int nFramesConfirmEnter;  	// 进入区域时间
            public int nFramesConfirmLeave;	// 离开区域时间
            public int nFramesConfirmTouch;	// 触及区域时间
            public int nFramesConfirmObjMove;	// 盗移动区域时间
            public int nFramesConfirmLinger;	// 徘徊时间
            public int nFramesConfirmAppear;	// 出现时间
            public int nFramesConfirmDisappear;// 消失时间
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chMemo;				    // 备注
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_AREA_DETECT_PARAM_PARAM
        {
            public int nSize;			// 结构体大小
            public int nValidNum;		// 有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_BZS_RULE_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_AREA_DETECT[] areaDetect;
        };

        //单线规则
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_CROSS_0NE_LINE
        {
            public int nSize;					        // 结构体大小
            public int bEnable;					    // 使能
            public int nSerial;					    // 区域序号
            public int nLineMask;   				    // 跨线使能掩码，参看ZLNET_IVA_BZS_CROSS_LINE_MASK
            public ZLNET_IVA_POINT ptStart;					    // 跨线起始点
            public ZLNET_IVA_POINT ptEnd;					        // 跨线终点
            public ZLNET_IVA_POINT ptDriection;				    // 跨线方向点(双向传正向点)
            public int nFramesConfirmCrossOneWay;      // 单向跨线确认时长
            public int nFramesConfirmCrossTwoWay;      // 双向跨线时长
            public int nFramesConfirmTouchOneWay;      // 正向触线时间
            public int nFramesConfirmTouchTwoWay;      // 反向触线时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chMemo;				            // 备注
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_CROSS_0NE_LINE_PARAM
        {
            public int nSize;				// 结构体大小
            public int nValidNum;			// 有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_BZS_RULE_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_CROSS_0NE_LINE[] oneLine;
        };

        //双线规则
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_CROSS_TWO_LINE
        {
            public int nSize;					// 结构体大小
            public int bEnable;				// 使能
            public int nSerial;				// 区域序号
            public ZLNET_IVA_POINT ptPredictStart;			// 预测双线起始点
            public ZLNET_IVA_POINT ptPredictEnd;			// 预测双线终点
            public ZLNET_IVA_POINT ptPredictDirection;		// 预测方向点
            public ZLNET_IVA_POINT ptDecideStart;			// 确认双线起始点
            public ZLNET_IVA_POINT ptDecideEnd;			// 确认双线终点
            public ZLNET_IVA_POINT ptDecideDirection;		// 确认双方向点
            public int nFramesConfirmClimb;	// 跨线时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string chMemo;				    // 备注
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_CROSS_TWO_LINE_PARAM
        {
            public int nSize;			// 结构体大小
            public int nValidNum;		// 有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_BZS_RULE_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_CROSS_TWO_LINE[] twoLine;
        };

        //自助银行

        //区域结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_REGION
        {
            public int size;
            public int areaNum;			//有效区域数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_SSB_AREA, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_MONITORREGION[] detectArea;	        //区域数组
        };

        //自助厅功能配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_HALL_FUNC
        {
            public int nSize;							//结构体大小
            public int nWidth;						    //检测区域宽度
            public int nHeight;						//检测区域高度
            public int nForegroundTh;					//前景差阈值
            public ZLNET_IVA_SSB_REGION PolygonNoProc;				    //处理区域(1) + 屏蔽区域(9) + 操作区域(10)
            public int nObjHeight;						//高度标尺
            public int bImgTransform;					//是否校正图像

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
            public float[] fTransformParam;				//校正图像参数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9, ArraySubType = UnmanagedType.R4)]
            public float[] fTransformParamInv;				//校正图像反转参数
        };

        //自助厅异常检测参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_ABNORMAL_PARAM
        {
            public int nSize;
            public int nCmd;					// 0、忽略 1、算法重启

            // 遗留物参数
            public int nMinSizeWidthHeight;	//包的最小大小（高度或者宽度）
            public int nMaxRectArea;			//物体最大外包矩形面积
            public int nMinForegroundArea;		//最小占有前景像素点个数
            public int nThresholdTime;			//持续多长时间报警（秒）

            // 徘徊参数
            public int nTotaolDisLingering;	//徘徊移动的距离
            public int nTotalStayingTime;		//总的逗留时间
            public int nTotalStayInterval;		//逗留时间的间隔

            // 多人参数
            public int nGatherNum;				//聚集人数
            public int nWarningInterval;		//两次聚集的间隔时间
            public int nTotalMultiPeoTime;		//总的聚集时间

            // 人员倒地参数
            public int nTotalFellTime;		    //总的倒下时间

            // 尾随取款
            public int nStatAtmSideTime;	    //停留在ATM附近的持续时间
            public int nIntervalAlarm;		    //两次报警的间隔

            // 禁止区域
            public int nInForbiddenAreaTime;   //进入禁止区域的持续时间

            // 打架事件进入相关
            public int nTotalFightingTime;	    //打架持续时间
            public int nIntervalFighting;	    //两次打架报警间隔
            public int nFightThInFrame;		//帧内判定报警的阈值,越小越容易报100 (0-256)
            public int nFightThInFramePixel;   //越小越容易报，报警等级2(1/2/3/4)
            public int bBottomRule;		    //是否采用底部约束，用于图像下方为进入区域的情况，默认为1
            public int bHeightChangeRule;	    //是否采用高度变化约束：要求物体的高度有起伏变化，如果物体充满图像，该约束置为0，默认为1
            public int nFrameGrayChangeTh;	    //帧间变化灰度阈值30(1-250)
            public int bUnused;			    //0

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7, ArraySubType = UnmanagedType.I4)]
            public int[] reserved;
        };

        //摄像头异常检测参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_CAMERE_ABNORMAL
        {
            public int nSize;					//参数大小
            public int bDetectBright;			//亮度异常 使能
            public int bDetectNoSignal;		//信号丢失 使能
            public int bDetectBlock;			//视频遮挡 使能
            public int bDetectColor;			//色彩异常 使能
            public int bDetectBlur;			//画面模糊 使能
            public int bDetectNoise;			//图像噪声 使能

            public int nBrightSensitivity;		//亮度异常 灵敏度
            public int nNoSignalSensitivity;	//信号丢失 灵敏度
            public int nBlockSensitivity;		//视频遮挡 灵敏度
            public int nColorSensitivity;		//色彩异常 灵敏度
            public int nBlurSensitivity;		//画面模糊 灵敏度
            public int nNoiseSensitivity;		//图像噪声 灵敏度

            public int nAlarmDurationTh;		//报警持续时间
            public int nBrightTh;				//镜头遮挡亮度阈值
        };

        //加钞间算法参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_ROOM_PARAM
        {
            public int nSize;			    //结构体大小
            public ZLNET_IVA_SSB_REGION PolygonNoProc;	    //处理区域（1） + 禁止区域（9）
            public int nThFg;				//前景阈值，15为推荐值
            public int nThArea;			//移动的区域占总区域的百分之几，25为推荐值
            public int nWarningInterval;   //报警间隔，15s*帧率为推荐值
            public int nNoProcess;		    //禁止区域个数
        };

        //SSB报警事件详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_DETAIL
        {
            public uint alarmNo;	    //区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_SSBALARM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_RECTINFO[] alarmRect;      // 区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserve;        //保留
        }; //报警信息结构体

        //SSB报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_ALARMINFO
        {
            public uint size;       //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;   //基本信息
            public ZLNET_IVA_SSB_DETAIL IVSDetail;  //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	    // 图片数据
        };

        //SSB查询日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_LOG
        {
            public uint size; 	    //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;   //基本信息
            public ZLNET_IVA_SSB_DETAIL IVSDetail;  //详细信息
        };

        // ATM/SSB混合型报警日志
        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ATMSSBLOG
        {
            [FieldOffset(0)]
            public ZLNET_IVA_ATM_DETAIL ATMDetail;
            [FieldOffset(0)]
            public ZLNET_IVA_SSB_DETAIL SSBDetail;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_SSB_LOG
        {
            public uint size; 	    //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;   //基本信息
            public UNION_ATMSSBLOG unLog;
        };

        //ATM/SSB混合型报警信息
        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_ATM_SSB_INFO
        {
            [FieldOffset(0)]
            public ZLNET_IVA_ATM_DETAIL ATMDetail;	//ATM日志详细信息
            [FieldOffset(0)]
            public ZLNET_IVA_SSB_DETAIL SSBDetail;	//SSB日志详细信息
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_ATM_SSB_ALARMINFO
        {
            public uint size;           //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public UNION_ATM_SSB_INFO atmssbinfo;     //ATM、SSB日志详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //BZS报警事件详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_DETAIL
        {
            public uint alarmNo;	    //区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_RECTINFO[] alarmRect;      // 区域

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string strMemo;        //区域说明
        };

        //BZS报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_ALARMINFO
        {
            public uint size;           //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_BZS_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //BZS查询日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_LOG
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_BZS_DETAIL IVSDetail;      //详细信息
        };

        //SSB跟踪信息的结构体：可以叠加跟踪框
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_TRACKEDINFO
        {
            public ZLNET_ALARMRECT rcObjectPos;	//在这一帧中，跟踪物体的位置（矩形：left,right,top,buttom）
            public int nTrackID;		//跟踪物体ID
            public int nType;			// 0:消失 1:显示
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_SSB_ARITH_DEBUG
        {
            public uint DebugNo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_NUM_SSB_TRACKEDINFO, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_SSB_TRACKEDINFO[] DebugInfo;
        };

        //BZS跟踪信息的结构体：可以叠加跟踪框
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_TRACKEDINFO
        {
            public ZLNET_ALARMRECT rcObjectPos;	//在这一帧中，跟踪物体的位置（矩形：left,right,top,buttom）
            public int nTrackID;		//跟踪物体ID
            public int nType;			// 0:消失 1:显示
        };

        //BZS算法调试信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_ARITH_DEBUG
        {
            public uint DebugNo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_NUM_SSB_TRACKEDINFO, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_TRACKEDINFO[] DebugInfo;
        };

        //新BZS算法调试信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_ARITH_DEBUG_EX
        {
            public uint DebugNo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_NUM_SSB_TRACKEDINFO_EX, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_TRACKEDINFO[] DebugInfo;
        };

        //BZS轨迹跟踪元素
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_TRACK
        {
            public uint nTrackID;   //跟踪物体ID
            public UInt16 nPosX;	    //x坐标
            public UInt16 nPosY;	    //y坐标  当nPosX和nPosY都为0的时候代表一个物体轨迹跟踪结束
        };

        //BZS轨迹跟踪
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BZS_TRACK_INFO
        {
            public uint nTrackNum;          //有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = MAX_TRACK_COUNT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_BZS_TRACK[] stTrackInfo;        //BZS轨迹跟踪元素
        };

        // 智能报警查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_QUERY_CONDITION
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string szCondition1;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] szRes;
        };

        //背景更新
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_BACKGROUND_UPDATE
        {
            public int nSize;				//结构体大小
            public int nBackgroundUpdate;	//背景更新命令，按位参看ZLNET_IVA_BACKGROUND_UPDATE_MASK

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.I4)]
            public int[] nReserved;		    //保留
        };

        //设备能力获取
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_EN
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLENT_DEVICE_ENABLE_STR_LEN)]
            public string en;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVICE_ENABLE
        {
            public int nSize;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType;			//设备类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DEVICE_ENABLE_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_EN[] szEn;               //主要能力(支持64项)

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_DEVICE_ENABLE_NUM, ArraySubType = UnmanagedType.U4)]
            public uint[] dwEnMask;			//主要能力掩码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
            public Byte[] bResverd;			//预留
        };

        //智能人脸

        //区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_AREA
        {
            public int nMinFace;	//检测最小像素
            public int nMaxFace;	//检测最大像素
            public ZLNET_ALARMRECT area;		//矩形区域
        };

        //人脸检测结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_TRACK_INFO
        {
            public ZLNET_ALARMRECT position;		//检测区域
            public int nConfidence;	//检测分数，分数越高画质越清晰
            public int nTrackID;		//检测ID
        };

        //人脸报警事件详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_DETAIL
        {
            public uint alarmNo;	    //区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_FACEALARM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_FACE_TRACK_INFO[] alarmRect;      // 区域

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] reserve;        //保留
        };

        //人脸报警事件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_ALARMINFO
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_FACE_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //人脸报警日志信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_LOG
        {
            public uint size; 	        //结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       //基本信息
            public ZLNET_IVA_FACE_DETAIL IVSDetail;      //详细信息
        };

        //检测区域参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_AREA_PARAM
        {
            public int nSize;		    //大小
            public int nValidNum;	    //有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_FACE_AREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_FACE_AREA[] faceArea;	    //区域个数

            public int nNoProcNum;		//屏蔽区域个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_FACE_SHIELDED_AREA_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARMRECT[] noProcArea;
        };

        //人脸检测参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_DETECT_PARAM
        {
            public int nSize;			//大小
            public int nChannel;		//通道
            public int nIntervalTime;	//抓拍间隔
            public ZLNET_IVA_FACE_CAPTURE_MODE nModeType;		//捕获模式 参看ZLNET_IVA_FACE_CAPTURE_MODE
            public int nScore;			//检测结果最低分数(低于此分数的结果将不被上传)
        };

        //人脸叠加参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_OVERLAY_PARAM
        {
            public int nSize;			//大小
            public int nChannel;       //通道
            public int nOverlayTime;	//叠加停留时间
            public ZLNET_IVA_FACE_OVERLAY_MODE nOverlayMode;	//叠加方式 参看ZLNET_IVA_FACE_OVERLAY_MODE
            public ZLNET_ALARMRECT position;		//叠加区域
        };

        //多人脸叠加参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_OVERLAY_PARAM_EX
        {
            public int nSize;			    //大小
            public int nChannel;           //通道
            public int nOverlayTime;	    //叠加停留时间
            public int nAlarmRect;		    //叠加区域个数
            public ZLNET_IVA_FACE_OVERLAY_MODE nOverlayMode;	    //叠加方式 参看ZLNET_IVA_FACE_OVERLAY_MODE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_FACE_ALARMRECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARMRECT[] position;	        //叠加区域数组
        };

        //485叠加参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_485_OVERLAY_PARAM
        {
            public int nSize;				//大小
            public int nChannel;			//通道
            public int nOverlayChannel;	//485叠加通道
            public ZLNET_IVA_485_OVERLAY_MODE nOverlayMode;		//叠加方式
            public ZLNET_ALARMRECT position;			//叠加区域
        };

        //人脸算法调试结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_FACE_ARITH_DEBUG
        {
            public uint nTrackInfo;		//个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_FACE_TRACKEDINFO, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_FACE_TRACK_INFO[] trackInfo;      //调试结果
        };

        //DVR、NVR智能报警详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_DVR_PLATE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string plate;      //车牌

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
            public byte[] res;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_DVR_DETAIL
        {
            [FieldOffset(0)]
            public STRUCT_DVR_PLATE dvrPlate;

            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte res;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DVR_DETAIL
        {
            public uint alarmNo;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_NUM_REGION, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_RECTINFO[] alarmRect;     // 区域

            //根据不同的报警类型，有不同的参数
            public UNION_DVR_DETAIL unDvrDetail;
        };

        //DVR、NVR智能报警
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DVR_ALARMINFO
        {
            public uint size; 	    //结构体大小
            public ZLNET_IVA_EVENT IVAEvent;	//基本事件信息
            public ZLNET_IVA_DVR_DETAIL IVADetail;  //报警详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	    // 图片数据
        };

        //DVR、NVR智能报警日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DVR_LOG
        {
            public uint size; 	    //结构体大小
            public ZLNET_IVA_EVENT IVAEvent;	//基本事件信息
            public ZLNET_IVA_DVR_DETAIL IVADetail;  //报警详细信息
        };

        // 车位报警信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PARKING_DETAIL
        {
            public uint ParkingState;		// 车位状态

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string ParkRuleName;	    // 对应的车位规则名字

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] res;			    // 保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PARKING_ALARMINFO
        {
            public uint size;		    // 结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       // 基本信息
            public ZLNET_IVA_PARKING_DETAIL IVSDetail;      //详细信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVA_MAX_CHANNEL * 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_ALARMINFO_PIC[] pic;	        // 图片数据
        };

        //车位报警日志
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_PARKING_LOG
        {
            public uint size;			// 结构体大小
            public ZLNET_IVA_EVENT IVSEvent;       // 基本信息
            public ZLNET_IVA_PARKING_DETAIL IVSDetail;      // 详细信息
        };

        //单个服务器连接信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REV_LINK_INFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string ip;		        //连接的服务器地址

            public int port;			//服务器端口
            public int linkcount;		//连接次数 0: 断开 0xffffffff: 一直连接, 直到成功为止

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I4)]
            public int[] res;		    //预留
        };

        // 服务器连接信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REV_LINK
        {
            public int validcount;		//有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_REV_LIST - 1, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_REV_LINK_INFO[] info;           //连接信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I4)]
            public int[] res;		    //预留
        };

        //反向连接服务器信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REVSERVERINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IPADDR_LEN)]
            public string ServerIp;	    //服务器IP

            public int ServerPort;
            public int enable;         //标识IP使能
        };

        //主动注册服务器
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONFIG_REG_SERVER
        {
            public int enable;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string deviceID;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_REV_LIST, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_REVSERVERINFO[] serverInfo;
        };

        // 设备通知信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REV_LINK_RET
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DOMAIN_NAME_LEN)]
            public string ip;	        //连接的服务器地址

            public int port;		//端口号
            public int ret;		//连接返回结果 0:成功 -1:超过尝试连接次数 -2:设备断开 -3:设备连接达到最大值

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20, ArraySubType = UnmanagedType.I4)]
            public int[] res;	    //预留
        };

        //IPCP详细信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_EXTERN_INFO
        {
            public int nChn;		    //通道数量
            public IntPtr szSerial;	    //序列号
            public IntPtr szUserName;	    //IPCP 用户名
            public IntPtr szPWD;		    //IPCP 密码
        };

        //穿网服务配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_P2P_SERVICE
        {
            public int bEnable;			//穿网功能  0:关闭 1:开启

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_P2P_DEVICE_ID_LEN)]
            public string szDeviceID;	        //设备ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_P2P_PASSWORD_LEN)]
            public string szPassword;	        //控制密码

            public int nLocalPort;		    //本地端口
            public int nConnectState;		//连接状态 0：已连接 1：无法连接到Internet 2：无法连接到云服务器
            public int nTransferPlan;		//网络传输QOS
            public int bAccountReuse;		//账号复用
        };

        //NVR修改搜索得到的设备IP错误类型
        public enum ZLNET_ModifyConfigCMD
        {
            ZLNET_MOFIFY_SUCCESS = 0,
            ZLNET_MODIFY_SAVE_FAILED,
            ZLNET_MODIFY_VALID_FAILED,
            ZLNET_MODIFY_NOT_SUPPORT,
            ZLNET_MODIFY_NO_POWER,
            //以下为网络通道错误码
            ZLNET_MIXED_ERROR = 50,			//未知错误
            ZLNET_MIXED_NO_SUPPORT,			//该协议不支持
            ZLNET_MIXED_INVALID_PARAM,		//无效参数
            ZLNET_MIXED_TIMEOUT,			//设备处理超时
            ZLNET_MIXED_NET_FAILED,			//网络错误
            ZLNET_MIXED_USER_PWD_FAILED,	//用户名密码错误
            ZLNET_MIXED_BUSY,				//系统忙
        };

        // 智能人脸设备通道分析模式
        public enum ZLNET_IVA_DEV_ANALYSIS
        {
            ZLNET_IVA_DEV_ANALYSIS_NULL = 0,
            ZLNET_IVA_DEV_ANALYSIS_LOCAL,		// 本地分析模式
            ZLNET_IVA_DEV_ANALYSIS_NET,			// 网络分析模式
        };

        //////////////////////////////////////////////////////////////////////////
        //算法调试相关

        //ATM面板调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVADEBUG_ATMPANEL
        {
            public int nATMWarns;        //已经报警的数量 
            public int nATMBlocks;       //面板堵塞计数 
            public int nProbeBlocks;     //人脸堵塞计数
            public int nFaceTrackID;     //人脸跟踪最新ID

            public byte bATMProbe;       //人脸视频中检测到人员
            public byte bATMMoving;     //面板视频中检测到人员
            public byte bATMHands;       //人员操作ATM机
            public byte bATMDebugEnable;       //调试使能
        };

        //ATM人脸调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVADEBUG_ATMFACE
        {
            public byte bFaceCheckMove;     // 是否有人：1表示人脸通道检测到人员，0表示人脸通道未检测到人员；
            public byte bFaceStay;     // 运动状态：1表示人脸通道有运动变化，0表示人脸通道没有运动变化。

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] szRes;
        };

        //防护舱调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVADEBUG_TANK
        {
            public int nTankHeads;   // 人头计数：用数字表示算法检测到的人头数量，数值为1/2/3/4/5
            public int nHead1Id;     // 人员站位1：算法检测到的人员1的站位信息(6*8中的第几格）
            public int nHead2Id;     // 人员站位2：算法检测到的人员2的站位信息(6*8中的第几格）
            public int nMovingChecks;  // 运动激烈程度：舱内人员运动幅度激烈程度的数值，用整数表示，范围为0~100。
        };

        //周界调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVADEBUG_DISTRICT
        {
            public byte bDistrictDebugEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] szRes;
            public int nLineCrossNums;    //人员跨线计数
        };

        //人头统计调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVADEBUG_HEADCNT
        {
            public byte bDebugEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] szRes;

            public int nLineCrossNums;      //里面有多少人
            public int nforwordNums;        //算法初始后的正向总人数
            public int nbackwordNums;       //算法初始后的反向总人数
        };

        //调试信息类型
        public enum ZLNET_ENUM_IVADEBUG_TYPE
        {
            ZLNET_ENUM_IVADEBUG_ATMPANEL = 0,
            ZLNET_ENUM_IVADEBUG_ATMFACE,
            ZLNET_ENUM_IVADEBUG_TANK,
            ZLNET_ENUM_IVADEBUG_DISTRICT,
            ZLNET_ENUM_IVADEBUG_HEADCNT,
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_DEBUGINFO
        {
            [FieldOffset(0)]
            public ZLNET_IVADEBUG_ATMPANEL stAtmPannel;	//nType==ZLNET_ENUM_IVADEBUG_ATMPANEL

            [FieldOffset(0)]
            public ZLNET_IVADEBUG_ATMFACE stAtmFace;		//nType==ZLNET_ENUM_IVADEBUG_ATMFACE

            [FieldOffset(0)]
            public ZLNET_IVADEBUG_TANK stTank;			//nType==ZLNET_ENUM_IVADEBUG_TANK

            [FieldOffset(0)]
            public ZLNET_IVADEBUG_DISTRICT stDistrict;		//nType==ZLNET_ENUM_IVADEBUG_DISTRICT

            [FieldOffset(0)]
            public ZLNET_IVADEBUG_HEADCNT stHeadCnt;		//nType==ZLNET_ENUM_IVADEBUG_HEADCNT

            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            public byte[] szUnion;
        };

        //算法调试
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DEBUG_INFO
        {
            ZLNET_ENUM_IVADEBUG_TYPE nType;	//根据不同的类型，取union中的不同信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] szRes;				//预留

            public UNION_DEBUGINFO u;
        };

        /////////////////////////////////台湾设备相关结构体/////////////////////////////////////////
        // Hdmi 时间段表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_FILENAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string name;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HDMI_ITEM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_HDMI_FILE_COUNT, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_FILENAME filename;
            public int start_hour;
            public int start_min;
            public int stop_hour;
            public int stop_min;
        };

        // Hdmi 时间段表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HDMI_TABLE
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_HDMI_ITEM_COUNT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_HDMI_ITEM[] hdmi_item;
        };

        // 强制插播结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HDMI_PLAY
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string filename;
            public int delay_sec;
        };

        // 播放进度结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_HDMI_PROGRESS
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string filename;

            public float progress;
        };

        // 卡号叠加结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CARD_OVERLAY
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_CARD_OVERLAY_COUNT, ArraySubType = UnmanagedType.I4)]
            public int[] cardOverlay;
        };

        public enum ZLNET_IVA_ALGORITHM_TYPE	//智能设备通道算法类型
        {
            ZLNET_IVA_ALGORITHM_NULL = -1,
            ZLNET_IVA_ALGORITHM_BZS = 0,		//周界算法
            ZLNET_IVA_ALGORITHM_SSB,			//自助银行算法
            ZLNET_IVA_ALGORITHM_FACE,			//人脸算法
            ZLNET_IVA_ALGORITHM_ATM,			//ATM算法
            ZLNET_IVA_ALGORITHM_STAFFCOUNT,		//人数统计算法
            ZLNET_IVA_ALGORITHM_PLATEID,		//车牌算法
        };

        // 设备通道模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DEV_CHANNEL_MODE
        {
            public int nChannelNo;			// 通道号
            public ZLNET_IVA_ALGORITHM_TYPE algorithmType;		// 通道的算法
            public ZLNET_IVA_DEV_ANALYSIS analysisMode;		// 通道的分析模式

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] reverse;			// 预留
        };

        // 设备通道模式集合
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DEV_CHANNEL_MODE_SET
        {
            public int nValid;			// 有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_IVA_DEV_CHANNEL_MODE[] modeSet;
        };

        // 通用算法配置参数(扩展时在后面添加参数，修改对应转换类)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALGORITHM_CONFIG
        {
            public int nVoteRadius;    /*!< 粒度，r * r半径内的像素结果相同 */
            public int nObjWidth;		/*!< 连通域阈值，目标至少拥有的宽度 */
            public int nObjHeight;		/*!< 连通域阈值，目标至少拥有的高度 */
            public int nObjPix;		/*!< 连通域阈值，目标至少拥有的像素数 */
            public int nForegroundTh;  /*!< 判断为背景分布的阈值，最高的有效值为1024，推荐使用默认值 */
            public int nVoteThrd;      /*!< 基于块判别时，前景背景的阈值 */

            public int nLearningRate;	/*!< 背景吸收速率 8 1,16 */
            public int nAreaThrd;		/*!< 目标前景百分比 60 0,100 */
            public int nWaitThrd;		/*!< 目标消失时间 20 0,30 */
            public int nDistThrd;		/*!< 目标追踪距离 100 0,400 */

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
            public byte[] reversed;		// 预留
        };

        //凯聪智云信息结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_KAICONG_CLOUD_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string UserName;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string PassWord;
        };

        //中星微VISS服务结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VISS_CONFIG
        {
            public int bEnable;              //使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
            public string chVissIP;             //Viss服务IP;

            public int nVissPort;            //Viss服务端口号;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string chVissDevID;          //Viss服务ID;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string chVissPsw;            //Viss服务密码
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PUSH_CONFIG
        {
            public int nEnable;				//消息推送使能
            public int nPicEnable;				//图片附件使能
            public int nInterval;				//时间间隔 0,1,2=60s，90s，120s

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_PUSH_TYPE_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] nLevel;	                //推送类型的级别，0,1,2

            public uint dwTypeEnable;		    //推送类型使能，按位控制
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PUSH_SERVER_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_TOKEN_LEN)]
            public string devToken;		//设备令牌

            public int nMsgRet;						//测试推送返回值
            public ZLNET_PUSH_CONFIG PushCfg;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SECURITY_CONFIG
        {
            public byte bClientEnable;
            public byte bRTSPEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] Reserved;
        };

        //通道码流类型状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_STREAM_STATE
        {
            public int nStreamState;		//0:主码流 1：辅码流
            public int bModify;			//状态是否改变

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //保留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CHANNEL_STREAM_STATE
        {
            public int nSize;				//结构体大小
            public int nChannelNum;		//通道个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_STREAM_STATE[] stream;
        };

        //////////////////////////////////////////////////////////////////////////
        // 查询类型
        public enum ZLNET_SYS_ABILITY
        {
            ZLNET_ABILITY_WATERMARK_CFG = 17,            // 水印配置能力
            ZLNET_ABILITY_WIRELESS_CFG = 18,             // wireless配置能力
            ZLNET_ABILITY_DEVALL_INFO = 26,              // 设备的能力列表
            ZLNET_ABILITY_CARD_QUERY = 0x0100,           // 卡号查询能力
            ZLNET_ABILITY_MULTIPLAY = 0x0101,            // 多画面预览能力
            ZLNET_ABILITY_QUICK_QUERY_CFG = 0x0102,      // 快速查询配置能力
            ZLNET_ABILITY_INFRARED = 0x0121,             // 无线报警能力
            ZLNET_ABILITY_TRIGGER_MODE = 0x0131,         // 报警输出触发方式能力
            ZLNET_ABILITY_DISK_SUBAREA = 0x0141,         // 网络硬盘分区能力
            ZLNET_ABILITY_DSP_CFG = 0x0151,              // 查询DSP能力
            ZLNET_ABILITY_STREAM_MEDIA = 0x0161,         // 查询SIP,RTSP能力
        };

        // 设备支持功能列表
        public enum ZLNET_SYS_ABILITY_EX
        {
            ZLNET_EN_FTP = 0,                       // FTP 按位，1：传送录像文件 2：传送抓图文件
            ZLNET_EN_SMTP,                          // SMTP 按位，1：报警传送文本邮件 2：报警传送图片
            ZLNET_EN_NTP,                           // NTP 按位：1：调整系统时间
            ZLNET_EN_AUTO_MAINTAIN,                 // 自动维护 按位：1：重启 2：关闭 3:删除文件
            ZLNET_EN_VIDEO_COVER,                   // 区域遮挡 按位：1：多区域遮挡
            ZLNET_EN_AUTO_REGISTER,                 // 主动注册 按位：1：注册后sdk主动登陆
            ZLNET_EN_ZLCP,                          // DHCP 按位：1：ZLCP
            ZLNET_EN_UPNP,                          // UPNP 按位：1：UPNP
            ZLNET_EN_COMM_SNIFFER,                  // 串口抓包 按位：1:CommATM
            ZLNET_EN_NET_SNIFFER,                   // 网络抓包 按位： 1：NetSniffer
            ZLNET_EN_BURN,                          // 刻录功能 按位：1：查询刻录状态
            ZLNET_EN_VIDEO_MATRIX,                  // 视频矩阵 按位：1：是否支持视频矩阵
            ZLNET_EN_AUDIO_DETECT,                  // 音频检测 按位：1：是否支持音频检测
            ZLNET_EN_STORAGE_STATION,               // 存储位置 按位：1：Ftp服务器(Ips) 2：SBM 3：NFS 16：DISK 17：U盘
            ZLNET_EN_IPSSEARCH,                     // IPS存储查询 按位：1：IPS存储查询
            ZLNET_EN_SNAP,                          // 抓图 按位：1：分辨率2：帧率3：抓图方式4：抓图文件格式5：图画质量
            ZLNET_EN_DEFAULTNIC,                    // 支持默认网卡查询 按位 1：支持
            ZLNET_EN_SHOWQUALITY,                   // CBR模式下显示画质配置项 按位 1:支持
            ZLNET_EN_CONFIG_IMEXPORT,               // 配置导入导出功能能力 按位 1:支持
            ZLNET_EN_LOG,                           // 是否支持分页方式的日志查询 按位 1：支持
            ZLNET_EN_SCHEDULE,                      // 录像设置的一些能力 按位 1:冗余 2:预录 3:录像时间段
            ZLNET_EN_NETWORK_TYPE,                  // 网络类型按位表示 1:以态网 2:无线局域 3:CDMA/GPRS
            ZLNET_EN_MARK_IMPORTANTRECORD,          // 标识重要录像 按位:1：设置重要录像标识
            ZLNET_EN_ACFCONTROL,                    // 活动帧率控制 按位：1：支持活动帧率控制
            ZLNET_EN_MULTIASSIOPTION,               // 多路辅码流 按位：1：支持三路辅码流
            ZLNET_EN_DAVINCIMODULE,                 // 组件化模块 按位：1，时间表分开处理 2:标准I帧间隔设置
            ZLNET_EN_GPS,                           // GPS功能 按位：1：Gps定位功能
            ZLNET_EN_MULTIETHERNET,                 // 支持多网卡查询 按位 1：支持
            ZLNET_EN_LOGIN_ATTRIBUTE,               // Login属性 按位：1：支持Login属性查询
            ZLNET_EN_RECORD_GENERAL,                // 录像相关 按位：1，普通录像；2：报警录像；3：动态检测录像；4：本地存储；5：远程存储；6：冗余存储；7：本地紧急存储
            ZLNET_EN_JSON_CONFIG,                   // Json格式配置:按位：1支持Json格式
            ZLNET_EN_EMAIL,                         // EMAIL功能 : 按位：1:支持SendInterval
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEV_ENABLE_INFO
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512, ArraySubType = UnmanagedType.U4)]
            public uint[] IsFucEnable;        // 功能列表能力集,下标对应上述的枚举值,按位表示子功能
        };

        // 卡号查询能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CARD_QUERY_EN
        {
            public byte IsCardQueryEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] iRev;
        };

        // wireless能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WIRELESS_EN
        {
            public byte IsWirelessEnable;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] iRev;
        };

        // 图象水印能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WATERMAKE_EN
        {
            public byte isSupportWM;        // 1 支持；0 不支持
            public byte supportWhat;        // 0：文字水印；1：图片水印；2：同时支持文字水印和图片水印

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] reserved;
        };

        // 多画面预览能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MULTIPLAY_EN
        {
            public int nEnable;            // 1 支持；0 不支持
            public uint dwMultiPlayMask;    // 多画面预览掩码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
            public byte[] reserved;           // 保留
        };

        // 无线报警能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WIRELESS_ALARM_INFO
        {
            public int bSupport;           // 是否支持
            public int nAlarmInCount;      // 输入个数
            public int nAlarmOutCount;     // 输出个数
            public int nRemoteAddrCount;   // 遥控器个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] reserved;
        };

        // 网络硬盘分区能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISK_SUBAREA_EN
        {
            public int bSupported;         // 是否支持网络硬盘分区
            public int nSupportNum;        // 支持分区的数目

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bReserved;          // 保留字节
        };

        // DSP能力查询，当DSP能力算法标识为2时使用。
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DSP_CFG_ITEM
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bMainFrame;     // 以分辨率枚举值(CAPTURE_SIZE)为索引,主码流分辨率对应支持的最大帧率,如果不支持此分辨率,则值为0.

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] bExtraFrame_1;  // 辅码流1,使用同bMainFrame

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] bReserved;      // 预留给辅码流2和3.
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DSP_CFG
        {
            public int nItemNum;               // DH_DSP_CFG_ITEM的有效个数,等于通道数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DSP_CFG_ITEM[] stuDspCfgItem;          // 主码流的信息

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] bReserved;              // 保留
        };

        //////////////////////////////////////////////////////////////////////////
        // 快速查询配置能力结构体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_QUICK_QUERY_CFG_EN
        {
            public byte IsQuickQueryEnable;                  // 1是设备支持配置命令快速返回，请设置配置时间足够长以保证窄带下配置的正常读取。建议设置60S

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public byte[] iRev;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_STREAM_MEDIA_EN
        {
            public int nStreamType;    // 0,无 1,SIP 2,RTSP

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] bReserved;      // 保留
        };


        /************************************************************************
         ** 新二代协议相关定义
         ***********************************************************************/
        public const int ZLNET_IVS_MAX_NAME_LEN = 32;                       // 通用名字字符串长度
        public const int ZLNET_IVS_MAX_SOURCE_LEN = 100;                    // 通用来源名称长度
        public const int ZLNET_IVS_MAX_ADDRESS_LEN = 100;                   // 地址名称长度
        public const int ZLNET_IVS_MAX_GROUP_LEN = 100;                     // 分组名称长度
        public const int ZLNET_IVS_MAX_INDEX_LEN = 32;                      // 报警序号长度
        public const int ZLNET_IVS_MAX_SUBALARM_LEN = 64;                   // 报警子类型长度
        public const int ZLNET_IVS_MAX_NOTE_LEN = 128;                      // 报警备注长度
        public const int ZLNET_IVS_MAX_POINT_NUM = 24;                      // 区域顶点个数上限
        public const int ZLNET_IVS_MAX_OBJECT_NUM = 32;                     // 物体个数上限
        public const int ZLNET_IVS_MAX_LINE_NUM = 32;                       // 折线个数上限
        public const int ZLNET_IVS_MAX_INFO_NUM = 8;                        // 通用信息最大个数
        //public const int ZLNET_IVS_MAX_ALGORITHM = 4;                       // 最大算法数
        public const int ZLNET_MAX_STRLEN_512 = 512;                        // 通用字符串长度512
        public const int ZLNET_MAX_PICTYPE = 16;                            //
        public const int ZLNET_MAX_ALARMCAPS = 256;                         // 
        public const int ZLNET_IVS_MAX_RULE_NUM = 32;                       // 同一规则类型最多规则框数

        //F6主命令类型 ZLNET_GetF6DevConfig用
        public enum ZLNET_F6_MAINCOMMAND
        {
            ZLNET_VIDEOANALYSEGLOBAL = 0,				//全景配置
            ZLNET_VIDEOANALYSEMODULE,					//模块（算法）配置
            ZLNET_VIDEOANALYSERULE,						//规则配置
        };

        //智能设备算法规则类型 ZLNET_GetF6DevConfig用
        public enum ZLNET_F6_IVARULE
        {
            ZLNET_RULE_TRAFFICTOLLGATE = 0,				// 交通卡口，新的字段，实现规则分离，该字段对应的事件名称仍为TrafficJunction
            ZLNET_RULE_TRAFFICRUNREDLIGHT,				// 交通闯红灯
            ZLNET_RULE_TRAFFICRUNYELLOWLIGHT,			// 交通闯黄灯
            ZLNET_RULE_TRAFFICOVERLINE,					// 压线
            ZLNET_RULE_TRAFFICOVERYELLOWLINE,			// 压黄线
            ZLNET_RULE_TRAFFICRETROGRADE,				// 逆行
            ZLNET_RULE_TRAFFICTURNLEFT,					// 违章左转
            ZLNET_RULE_TRAFFICTURNRIGHT,				// 违章右转
            ZLNET_RULE_TRAFFICU_TURN,					// 违章掉头
            ZLNET_RULE_TRAFFICCROSSLANE,				// 违章变道
            ZLNET_RULE_TRAFFICPARKING,					// 违章停车
            ZLNET_RULE_TRAFFICJAM,						// 交通拥堵(流量过大)
            ZLNET_RULE_TRAFFICIDLE,						// 交通空闲
            ZLNET_RULE_TRAFFICWAITINGAREA,				// 违章驶入待行区
            ZLNET_RULE_TRAFFICUNDERSPEED,				// 欠速
            ZLNET_RULE_TRAFFICOVERSPEED,				// 超速
            ZLNET_RULE_TRAFFICWRONGROUTE,				// 不按车道行驶
            ZLNET_RULE_TRAFFICYELLOWINROUTE,			// 黄牌占道
            ZLNET_RULE_TRAFFICVEHICLEINROUTE,			// 有车占道
            ZLNET_RULE_TRAFFICCONTROL,					// 交通管制
            ZLNET_RULE_TRAFFICOBJECTALARM,				// 指定类型抓拍
            ZLNET_RULE_TRAFFICACCIDENT,					// 交通事故
            ZLNET_RULE_TRAFFICSTAY,						// 交通停留/滞留
            ZLNET_RULE_TRAFFICPEDESTRAINPRIORITY,		// 斑马线行人优先
            ZLNET_RULE_TRAFFICPEDESTRAIN,				// 交通行人事件
            ZLNET_RULE_TRAFFICTHROW,					// 交通抛洒物品事件
            ZLNET_RULE_TRAFFICVEHICLEINBUSROUTE,		// 违章占道
            ZLNET_RULE_TRAFFICBACKING,					// 违章倒车
            ZLNET_RULE_TRAFFICOVERSTOPLINE,				// 压停止线
            ZLNET_RULE_TRAFFICPARKINGONYELLOWBOX,		// 黄网格线抓拍

            // 规则类型 非交通场景时的规则类型
            ZLNET_RULE_CROSSLINEDETECTION,				// 警戒线
            ZLNET_RULE_CROSSFENCEDETECTION,				// 穿越围栏
            ZLNET_RULE_CROSSREGIONDETECTION,			// 警戒区
            ZLNET_RULE_PASTEDETECTION,					// ATM贴条
            ZLNET_RULE_LEFTDETECTION,					// 物品遗留
            ZLNET_RULE_PRESERVATION,					// 物品保全
            ZLNET_RULE_TAKENAWAYDETECTION,				// 物品搬移
            ZLNET_RULE_STAYDETECTION,					// 停留/滞留
            ZLNET_RULE_PARKINGDETECTION,				// 非法停车
            ZLNET_RULE_WANDERDETECTION,					// 徘徊
            ZLNET_RULE_MOVEDETECTION,					// 运动
            ZLNET_RULE_TAILDETECTION,					// 尾随
            ZLNET_RULE_RIOTERDETECTION,					// 聚集
            ZLNET_RULE_FIGHTDETECTION,					// 打架
            ZLNET_RULE_RETROGRADEDETECTION,				// 逆行
            ZLNET_RULE_FIREDETECTION,					// 火焰
            ZLNET_RULE_SMOKEDETECTION,					// 烟雾
            ZLNET_RULE_NUMBERSTAT,						// 数量统计
            ZLNET_RULE_VIDEOABNORMALDETECTION,			// 视频异常
            ZLNET_RULE_PRISONERRISEDETECTION,			// 看守所囚犯起身检测
            ZLNET_RULE_FACEDETECTION,					// 人脸检测
            ZLNET_RULE_FACERECOGNITION,					// 人脸识别
            ZLNET_RULE_DENSITYDETECTION,				// 密集度检测
            ZLNET_RULE_QUEUEDETECTION,					// 排队检测
            ZLNET_RULE_CLIMBDETECTION,					// 攀高检测
            ZLNET_RULE_LEAVEDETECTION,					// 离岗检测
            ZLNET_RULE_TRAFFICPARKINGSPACEPARKING,		// 车位有车
            ZLNET_RULE_TRAFFICPARKINGSPACENOPARKING,	// 车位无车
            ZLNET_RULE_VQDS_BLUR,						// 视频质量检测-模糊
            ZLNET_RULE_VQDS_COLOR,						// 视频质量检测-偏色
            ZLNET_RULE_VQDS_COVER,						// 视频质量检测-遮挡
            ZLNET_RULE_VQDS_SHIFT,						// 视频质量检测-镜头偏移
            ZLNET_RULE_VQDS_LOSS,						// 视频质量检测-视频丢失
            ZLNET_RULE_FLOWSTAT,						// 人数统计
        };

        //报警类型
        public enum ZLNET_F6ALARM_TYPE
        {
            ZLNET_F6ALARM_INVALID = 0,               //无效值，不代表任何报警类型

            //常规报警
            ZLNET_F6ALARM_MOTION = 1,                //动检
            ZLNET_F6ALARM_BLOCK,                     //遮挡,
            ZLNET_F6ALARM_VIDEOLOST,                 //视频丢失
            ZLNET_F6ALARM_ALARMIN,                   //报警输入(开关量）
            ZLNET_F6ALARM_ANALOG_ALARMIN,            //模拟量输入--NTR
            ZLNET_F6ALARM_SMARTSENSOR_ALARM,         //智能传感器报警--NTR

            //智能报警
            ZLNET_F6ALARM_FACE_DETECTION = 100,      //人脸抓拍--人脸

            ZLNET_F6ALARM_CROSSLINE_DETECTION,       //绊线入侵--周界
            ZLNET_F6ALARM_CROSSFENCE_DETECTION,      //翻越围栏--周界
            ZLNET_F6ALARM_CROSSREGION_DETECTION,     //区域入侵--周界

            //ZLNET_F6ALARM_VIDEOABNORMAL_DETECTION,   //视频异常--弃用

            ZLNET_F6ALARM_FLOW_STAT = 105,            //流量统计--人数统计
            ZLNET_F6ALARM_NUMBER_STAT,                //数量统计--周界

            ZLNET_F6ALARM_PASTE_DETECTION,            //贴条--弃用
            ZLNET_F6ALARM_LEFT_DETECTION,             //物品遗留--周界
            ZLNET_F6ALARM_TAKEAWAY_DETECTION,         //物品搬移--周界
            ZLNET_F6ALARM_PRESERVATION,               //物品保全--弃用
            ZLNET_F6ALARM_STAY_DETECTION,             //停留事件--弃用
            ZLNET_F6ALARM_WANDER_DETECTION,           //徘徊检测--周界
            ZLNET_F6ALARM_PARKING_DETECTION,          //非法停车--卡口
            ZLNET_F6ALARM_MOVE_DETECTION,             //移动事件--弃用
            ZLNET_F6ALARM_TAIL_DETECTION,             //尾随--弃用
            ZLNET_F6ALARM_RUN_DETECTION,              //异常奔跑--弃用
            ZLNET_F6ALARM_RETROGRADE_DETECTION,       //逆行检测--周界
            ZLNET_F6ALARM_RIOTER_DETECTION,           //聚众--弃用
            ZLNET_F6ALARM_DENSITY_DETECTION,          //密度检测--周界
            ZLNET_F6ALARM_HDCT_DENSITY = 122,         //密度检测--人数统计
            ZLNET_F6ALARM_HDCT_HUMAN_NUMBER,          //人数异常--人数统计
            ZLNET_F6ALARM_HDCT_TRAIL,                 //人员尾随--人数统计

            /*ZLNET_F6ALARM_FIGHT_DETECTION,            //斗殴--弃用
            ZLNET_F6ALARM_FIRE_DETECTION,             //火警--弃用
            ZLNET_F6ALARM_ELECTROSPARK_DETECTION,     //电火花--弃用
            ZLNET_F6ALARM_SMOKE_DETECTION,            //烟雾--弃用
            ZLNET_F6ALARM_PRISONERRISE_DETECTION,     //看守所囚犯起身事件--弃用
            ZLNET_F6ALARM_QUEUE_DETECTION,            //排队检测事件--弃用
            ZLNET_F6ALARM_CLIMB_DETECTION,            //攀爬--弃用
            ZLNET_F6ALARM_LEAVE_DETECTION,            //离开--弃用*/

            ZLNET_F6ALARM_OBJECT_DETECTION = 128,     //物品检测--通用

            ZLNET_F6ALARM_PARK_GATEWAY,               //停车场出入口事件--卡口
            ZLNET_F6ALARM_PARK_SPACE,                 //车位检测--卡口
            ZLNET_F6ALARM_PLATE_DETECION,             //车牌检测--车牌
            ZLNET_F6ALARM_ABNORMAL_FACE,              //异常人脸--通用
            ZLNET_F6ALARM_FACE_MATCH,                 //人脸比中--通用
            ZLNET_F6ALARM_FACE_UNKNOWN,               //陌生人脸--通用

            ZLNET_F6ALARM_VQD_DARK = 150,	          //亮度异常过暗
            ZLNET_F6ALARM_VQD_LIGHT,                  //亮度异常过亮
            ZLNET_F6ALARM_VQD_BLUR,                   //清晰度异常
            ZLNET_F6ALARM_VQD_NOISE,                  //雪花噪声异常
            ZLNET_F6ALARM_VQD_STRIATION,              //条纹噪声异常
            ZLNET_F6ALARM_VQD_JITTER,                 //抖动异常
            ZLNET_F6ALARM_VQD_FROZEN,                 //冻结异常
            ZLNET_F6ALARM_VQD_COVER,                  //遮挡异常
            ZLNET_F6ALARM_VQD_LOSS,                   //信号缺失异常
            ZLNET_F6ALARM_VQD_SCENE,                  //场景变换异常
            ZLNET_F6ALARM_VQD_CAMMOVE,                //相机移动异常
            ZLNET_F6ALARM_VQD_PTZERR,                 //ptz控制异常
            ZLNET_F6ALARM_VQD_UNBALANCE,              //偏色异常

            ZLNET_F6ALARM_SSB_TRAIL = 200,            //尾随取款
            ZLNET_F6ALARM_SSB_HOVER,                  //人员徘徊
            ZLNET_F6ALARM_SSB_FELL,                   //人员倒地
            ZLNET_F6ALARM_SSB_GATHER,                 //多人聚集
            ZLNET_F6ALARM_SSB_REMNANTS,               //遗留物
            ZLNET_F6ALARM_SSB_FORBIDDEN,              //禁止进入--弃用
            ZLNET_F6ALARM_SSB_FIGHT,                  //行为过激
            ZLNET_F6ALARM_SSB_INVADE,                 //加钞间入侵
            ZLNET_F6ALARM_SSB_SUSPICIOUS_TRAIL,       //疑似尾随
            ZLNET_F6ALARM_SSB_HIJACK,                 //人员挟持
            ZLNET_F6ALARM_SSB_HUMAN_NUMBER,           //加钞间人数异常

            ZLNET_F6ALARM_ATM_PANELPASTE = 250,       //检测区异物
            ZLNET_F6ALARM_ATM_KEYBOARD,               //键盘区异常
            ZLNET_F6ALARM_ATM_CARDPORT,               //插卡口异常
            ZLNET_F6ALARM_ATM_KEYMASK,                //防护罩异常
            ZLNET_F6ALARM_ATM_ENTER,                  //人员进入
            ZLNET_F6ALARM_ATM_LEAVE,                  //人员离开
            ZLNET_F6ALARM_ATM_STAY,	                  //人员长时间操作
            ZLNET_F6ALARM_ATM_FACECAPTURE,            //人脸捕获(ATM)
            ZLNET_F6ALARM_ATM_FACEABNORMAL,           //异常人脸(ATM)
            ZLNET_F6ALARM_ATM_SMASH,                  //物品打砸
            ZLNET_F6ALARM_ATM_TANKDOWN,               //舱内人员倒地
            ZLNET_F6ALARM_ATM_BAGGAGE,                //舱内遗留物
            ZLNET_F6ALARM_ATM_GATHER,                 //舱内多人
            ZLNET_F6ALARM_ATM_MULTIFACE,              //多人脸检测
            ZLNET_F6ALARM_ATM_FIGHT,                  //舱内打架
            ZLNET_F6ALARM_ATM_HIJACK,                 //舱内劫持
            ZLNET_F6ALARM_ATM_INVADE,                 //舱内强行推入
            ZLNET_F6ALARM_ATM_FIRE,                   //舱内火焰检测
            ZLNET_F6ALARM_ATM_FAKEKEYBOARD,           //假键盘
            ZLNET_F6ALARM_ATM_FAKECARDREADER,         //假读卡器
            ZLNET_F6ALARM_ATM_PHONEFRAUD,             //电话诈骗
        };

        // 时间
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_TIME_EX
        {
            public uint dwYear;           // 年
            public uint dwMonth;          // 月
            public uint dwDay;            // 日
            public uint dwHour;           // 时
            public uint dwMinute;         // 分
            public uint dwSecond;         // 秒
            public uint dwMilliSecond;    // 毫秒
        };

        // RGBA颜色
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RGBA
        {
            public byte R;
            public byte G;
            public byte B;
            public byte A;	//透明度
        };

        // 方向枚举
        public enum ZLNET_E_DIRECTION
        {
            ZLNET_E_Direction_LeftToRight,
            ZLNET_E_Direction_RightToLeft,
            ZLNET_E_Direction_Both
        };

        // 位置枚举
        public enum ZLNET_E_POSITION
        {
            ZLNET_E_Position_Center = 0,
            ZLNET_E_Position_LeftCenter,
            ZLNET_E_Position_TopCenter,
            ZLNET_E_Position_RightCenter,
            ZLNET_E_Position_BottomCenter
        };

        // 点坐标
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_POINT
        {
            public int x;
            public int y;
        };

        // 线
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LINE
        {
            public int nPointNum;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_POINT[] pointList;
        };

        // 区域
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REGION
        {
            public int nPointNum;       //pointList有效数量
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_POINT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_POINT[] pointList;
        }

        // 物体
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_OBJECT
        {
            public int nId;                //物体ID
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szType;             //物体类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSubType;          //物体子类型

            public int nConfidence;		//置信度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 220)]
            public byte[] szRes;
        };

        //智能报警警戒线细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_CROSSLINE_DETECTION
        {
            public ZLNET_LINE stuDetectLine;           //规则检测线
            public int nStatResult;             //统计结果（针对流量和密度检测）
            public int nDirection;              //0.LeftToRight 1.RightToLeft
        };

        //智能报警围栏细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_CROSSFENCE_DETECTION
        {
            public ZLNET_LINE stuUpstairsLine;                //规则上检测线
            public ZLNET_LINE studownstairsLine;              //规则下检测线
            public int nDirection;                     //0.LeftToRight 1.RightToLeft
        };

        //智能报警警戒区域细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_CROSSREGION_DETECTION
        {
            public int nMovement;            // 检测动作: 0.穿越Cross 1.Appear出现  2.Disappear消失 3.Inside在区域内
            public int nDirection;	          // 检测方向（检测动作为0时有效）: 0.进入Enter, 1.离开Leave, 2.Both
        };

        //智能报警视频异常细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_VIDEOABNORMAL_DETECTION
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szFaultDetail;  // 详细信息

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szDescription;  // 故障描述
        };

        //智能报警流量统计细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_FLOW_STAT
        {
            public int nForward;            //正向（相对于规则箭头）的人的个数
            public int nBackward;          //反向的人的个数
            public int nUpperLimit;        //设置的上限
        };

        //车牌信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PLATE_INFO
        {
            public ZLNET_RECT stRect;             //位置

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szLicense;          //车牌号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPlateType;        //车牌类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPlateColor;       //车牌颜色 为空代表无相关数据

            public int nColorType;         //颜色类型 0:未知，请参考szPlateColor,1:蓝色,2:黄色,3:白色,4:黑色,5:红色,6:绿色

            public int nBright;            //车牌亮度 0:未知， 1-100
            public int nDirection;         //运动方向 0:未知,1:左,2:右,3:上,4:下
            public int nConfidence;        //车牌检测分数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;              //预留
        };

        //异常奔跑细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_RUN_DETECTION
        {
            public int nSpeed;                    //奔跑速度
            public int nTriggerSpeed;             //触发速度
            //type奔跑类型用报警子类型表示
        };

        //智能报警逆行细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_RETROGRADE_DETECTION
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_POINT[] Direction;      //两个方向点
        };

        //密度检测细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_DENSITY_DETECTION
        {
            public int nDensity;                   //密度
        };

        //智能报警数量统计事件细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_NUMBER_STAT
        {
            public int nNumber;            //区域内物体个数
            public int nEnteredNumber;     //进入区域或出入口内的物体个数
            public int nExitedNumber;      //出来区域或出入口外物体的个数
            public int nUpperLimit;        //设置的个数上限
        };

        //停车场出入口事件细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_PARK_GATEWAY
        {
            public ZLNET_PLATE_INFO plateInfo;          //车牌

            public int firstColor;         //车辆主色 0:未知,1:蓝色,2:黄色,3:白色,4:黑色,5:红色
            public int secondColor;        //车辆次色
            public float firstRate;          //主色比例
            public float secondRate;         //次色比例

            public int lane;               //车道号
            public float speed;              //车速 KM/H

            public int shutter;            //快门值
            public int gain;               //增益值
            public int flashLight;         //0闪光灯关闭， 1闪光灯开启

            public int triggerType;        //触发类型 0模拟触发 1视频触发 2串口触发 3 IO触发 4其他触发 5 抓拍照片
            public int triggerID;          //触发ID
        };

        //车位检测细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_PARK_SPACE
        {
            public int nSpaceNumber;         //车位号
            public int nStatus;              //车位状态, 0空闲 1占用 2预定
        };

        //停车位车牌检测细节参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_PLATE_DETECTION
        {
            public int nSpaceNumber;          //车位号
            public ZLNET_PLATE_INFO plateInfo;             //车牌信息

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szCarColor;            //车辆颜色 为空代表无相关数据

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szLogo;                //车辆LOGO 为空代表无相关数据
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_MATCH_RESULT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIndex;              //事件索引（事件唯一标识）

            public int nChannel;                //匹配分数 0-100

            public ZLNET_TIME stDetectTime;     //检测时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;            //人员所在的组ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupName;          //人员所在的组名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPersonID;           //人员ID,程序内部使用，只能获取，不能修改

            public ZLNET_FACE_PERSONINFO stPersonInfo;       //人员基础信息
            public int nMatchRate;         //匹配分数 0-100
            public ZLNET_FACE_FACEIMAGE stImage;            //比中图片（库图）
            public ZLNET_PICTURE_LINKINFO stPictureSrc;       //抓拍图片

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            public byte[] szRes;//预留
        };

        //物联网网关相关报警详细参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DETAIL_IOT_STAT
        {
            public int nStat;		//具体报警类型 0未知 1超过阈值上限 2低于阈值下限 3定值触发 4传感器断线
            public int nSensorID;		//传感器ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorType;	    //传感器类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;     //传感器名称

            //详细传感参数
            public int nValueNum;		//valuePair个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_MEASURING_VALUE[] valuePair;	    //详细传感参数
        };

        // 网络类型
        public enum ZLNET_ENUM_VALUETYPE
        {
            ZLNET_VT_INVALID = -1,					// 无效
            ZLNET_VT_INT = 0,							// 整型
            ZLNET_VT_DOUBLE,						// 浮点
            ZLNET_VT_STRING,							// 字符串
            ZLNET_VT_DATETIME,						// 日期时间（年月日时分秒）
            ZLNET_VT_TIME,								// 时间（时分秒）
        };

        //键值对
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MEASURING_VALUE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPointID;	        //测点ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPointName;	    //测点名称

            public ZLNET_ENUM_VALUETYPE nValueType;	    //值类型,按类型取下面不同的值
            public int nValue;		        //整型值，nValueType == ZLNET_VT_INT
            public float fValue;		        //浮点值，nValueType == ZLNET_VT_DOUBLE

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szValue;	            //字符串值，nValueType == ZLNET_VT_STRING

            public ZLNET_TIME_EX stTimeValue;       //时间值，年月日为0时只表示时分秒，nValueType == ZLNET_VT_DATETIME || ZLNET_VT_TIME

            public ZLNET_TIME_EX stTime;                //数据采集时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szValueUnit;        //测点值单位(ZLNET_SetMeasuringValue时无需填写）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;                 //预留
        };

        //通道类型
        public enum ZLNET_CHANNEL_TYPE
        {
            ZLNET_CT_UNKNOWN = -1,
            ZLNET_CT_VIDEO = 0,		        //视频通道
            ZLNET_CT_AUDIO,			        //音频通道
            ZLNET_CT_ALARMIN,		        //外部输入
            ZLNET_CT_ALARMOUT,		    //输出控制

            ZLNET_CT_NET_VIDEO,		    //网络(相对NVR本地而言）视频通道
            ZLNET_CT_NET_AUDIO,		    //网络(相对NVR本地而言）音频通道
            ZLNET_CT_NET_ALARMIN,	    //网络(相对NVR本地而言）外部输入
            ZLNET_CT_NET_ALARMOUT,	//网络(相对NVR本地而言）输出控制

            ZLNET_CT_ANALOG_ALARMIN,	    //模拟量输入
            ZLNET_CT_485,                               //485
            ZLNET_CT_232,                               //232
            ZLNET_CT_RJ45,			                    //RJ45
        };

        //报警图片类型
        public enum ZLNET_PICTURE_SRC_TYPE
        {
            ZLNET_PT_NONE = 0,      //无图片
            ZLNET_PT_SMALL,         //小缩略图
            ZLNET_PT_BIG,           //大缩略图
            ZLNET_PT_ORIGINAL,      //全尺寸原图
        };

        //报警视频信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEO_LINKINFO
        {
            public int nChannel;           //通道号
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadKey;	    //录像下载标识，下载时要用

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;               //预留
        };

        //报警图片信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PICTURE_LINKINFO
        {
            public int nChannel;           //图片通道号
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadKey;		//下载标识，下载时要用

            public int nSnapTime;			//抓图时间在报警前多少秒，例如0表示报警图，5表示报警前5秒的图
            public ZLNET_PICTURE_SRC_TYPE nType;              //抓图类型

            public int nSequence;			//序号,与ZLNET_NEWF6_ALARM_PICTURE::nSequence对应
            public int nCutOut;			//是否是抠图
            public ZLNET_RECT stRect;             //抠图相对原图的位置，nCutOut == 1时有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 26, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;               //预留
        };

        //报警订阅(新二代协议设备)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_SUBSCRIBE
        {
            public int bNeedVideo;             //1订阅报警视频 0不订阅报警视频

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_PICTYPE, ArraySubType = UnmanagedType.I4)]
            public ZLNET_PICTURE_SRC_TYPE[] nPicType;               //报警通道的抓图类型,可订阅多种类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_PICTYPE, ArraySubType = UnmanagedType.I4)]
            public ZLNET_PICTURE_SRC_TYPE[] nLinkType;              //联动的其它通道的抓图类型,可订阅多种类型     

            public int bByChannel;             //是否指定通道号，TRUE时nChannel有效，FALSE时订阅所以通道
            public int nChannel;               //指定通道号，与bByChannel配合使用

            public int bByType;                //是否指定报警类型，TRUE时nTypes有效，FALSE时订阅所有类型
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I4)]
            public ZLNET_F6ALARM_TYPE[] nTypes;                 //指定报警类型，与bByType配合使用

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;                   //预留
        };

        //报警
        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_F6_ALARM_DETAIL
        {
            [FieldOffset(0)]
            public ZLNET_DETAIL_CROSSLINE_DETECTION crosslineDetection;         // 警戒线
            [FieldOffset(0)]
            public ZLNET_DETAIL_CROSSFENCE_DETECTION crossfenceDetection;       // 翻越围栏
            [FieldOffset(0)]
            public ZLNET_DETAIL_CROSSREGION_DETECTION crossregionDetection;     // 警戒区
            [FieldOffset(0)]
            public ZLNET_DETAIL_VIDEOABNORMAL_DETECTION videoAbnormalDetection; // 视频异常
            [FieldOffset(0)]
            public ZLNET_DETAIL_FLOW_STAT flowStat;                             // 流量统计
            //[FieldOffset(0)]
            //public ZLNET_DETAIL_RUN_DETECTION runDetection;                   // 非法奔跑
            [FieldOffset(0)]
            public ZLNET_DETAIL_RETROGRADE_DETECTION retrogradeDetection;       // 逆行
            [FieldOffset(0)]
            public ZLNET_DETAIL_DENSITY_DETECTION densityDetection;             // 稠密度
            [FieldOffset(0)]
            public ZLNET_DETAIL_NUMBER_STAT numberStat;                         // 数量统计
            [FieldOffset(0)]
            public ZLNET_DETAIL_PARK_GATEWAY parkGatway;                        // 停车场出入口事件
            [FieldOffset(0)]
            public ZLNET_DETAIL_PARK_SPACE parkSpace;                           // 车位检测
            [FieldOffset(0)]
            public ZLNET_DETAIL_PLATE_DETECTION plateDetection;                 // 车牌检测
            [FieldOffset(0)]
            public ZLNET_FACE_MATCH_RESULT faceMatch;                           // 人脸比对
            [FieldOffset(0)]
            public ZLNET_DETAIL_IOT_STAT iotStat;                               // 物联网网关报警
            [FieldOffset(0)]
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024 * 8)]
            public byte[] res;                                                  //union最大大小
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEWF6_ALARM
        {
            public int nChannel;                  //通道
            public ZLNET_CHANNEL_TYPE nChannelType;              //通道类型

            public int nAction;                   //1 开关性事件开始, 0 开关性事件结束, 2 脉冲性事件, 3 持续事件
            public ZLNET_F6ALARM_TYPE nAlarmType;                //报警类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_SUBALARM_LEN)]
            public string szSubAlarmType;            //子报警类型，没有则为空
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NOTE_LEN)]
            public string szNote;                    //备注或名称，没有则为空
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_INDEX_LEN)]
            public string szIndex;                   //事件索引（事件唯一标识）
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadID;		        //事件下载ID（ZLNET_F6_QueryAlarm时才会有）
            public int nEventNumber;              //事件编号

            public ZLNET_TIME_EX stAlarmTime;               //事件触发时间
            public ZLNET_TIME_EX stStartTime;               //事件视频开始时间
            public int nEventVideoLatch;          //事件视频时长 （秒）

            //联动相关
            public int nVideoNum;                                      //视频联动的数量
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEO_LINKINFO[] stVideoSrc;                //报警视频信息列表

            public int nSnapCount;                                     //图片联动数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_PICTURE_LINKINFO[] stPictureSrc;              //报警图片信息列表

            //事件组相关
            public int nGroupID;                  //事件组ID
            public int nCountInGroup;             //一个事件组内的抓拍张数
            public int nIndexInGroup;             //一个事件组内的抓拍序号
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_SOURCE_LEN)]
            public string szSource;                  //事件源设备唯一标识，字段不存在或空表示本地设备
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szMachineName;             //机器名称
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_ADDRESS_LEN)]
            public string szMachineAddress;          //机器地址名称
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_GROUP_LEN)]
            public string szMachineGroup;            //机器分组名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_INDEX_LEN)]
            public string szTriggerCode;             //触发码
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 992)]
            public byte[] szRes;                     //保留字段

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024 * 8)] //详细信息，依据不同的nAlarmType，取union中的不同参数
            public byte[] res;

            //public UNION_F6_ALARM_DETAIL    unDetail;                 //详细信息，依据不同的nAlarmType，取union中的不同参数

            //物体信息
            public int nObjectsNum;               //objects的数量
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_OBJECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ALARM_OBJECT[] objects;                   //检测物体

            public int nTracksNum;                 //轨迹数量
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_LINE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_LINE[] stuTrackLines;             //表示物体形心的运动轨迹

            public ZLNET_REGION stuDetectRegion;           //报警区域
        };

        //报警视频(一包数据不代表完整视频，应用应当自己组装多包数据）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEWF6_ALARM_VIDEO
        {
            public IntPtr pBuf;             //数据 NULL表示结束
            public int nBufLen;             //数据长度 0表示结束

            public int bRealtime;          //1实时 0历史

            public int nChannel;           //通道号

            //以下两个字段用于在不同的情况下与报警做对应
            //实时情况下，一份视频可能同时对应多个报警，所以用timeStamp来区分
            //而历史报警下载是针对某个报警单独进行的，所以用szIndex直接对应报警
            public ZLNET_TIME_EX timeStamp;          //帧时间，仅bRealtime == 1时有效，年月日时分秒

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_INDEX_LEN)]
            public string szIndex;            //事件索引,仅bRealtime == 0时有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;               //保留字段
        };

        //报警图片（完整一张）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NEWF6_ALARM_PICTURE
        {
            public IntPtr pBuf;
            public int nBufLen;

            public int bRealtime;              //1实时 0历史
            public int nChannel;               //通道号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_INDEX_LEN)]
            public string szIndex;                //事件索引（事件唯一标识）

            public int nSnapTime;              //抓图时间在报警前多少秒，例如0表示报警图，5表示报警前5秒的图
            public ZLNET_PICTURE_SRC_TYPE nType;                  //抓图类型
            public int nSequence;              //图片编号，用于同一事件有多张图片的情况
            public int bFinished;              //本条报警的图片回调完成

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;                   //保留字段
        };

        //新协议，查历史事件记录参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_QUERYALARM_PARAM
        {
            public int nChannel;		//通道号，-1表示查询所有通道
            public int nAlarmType;		//事件类型，参考ZLNET_F6ALARM_TYPE，-1表示查询所有类型
            public ZLNET_TIME stBegin;		//开始时间
            public ZLNET_TIME stEnd;		    //结束时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;		    //预留
        };

        //新协议，下载报警视频参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DOWNALARM_VIDEO_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadID;		//事件下载ID，对应某报警，见ZLNET_NEWF6_ALARM::szDownloadID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadKey;		//下载标识，对应报警的具体一条视频，见ZLNET_VIDEO_LINKINFO::szDownloadKey

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;	            //预留
        };

        //新协议，下载报警图片参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DOWNALARM_PIC_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadID;		//事件下载ID，对应某报警，见ZLNET_NEWF6_ALARM::szDownloadID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szDownloadKey;      //下载标识，对应报警的具体一张图片，见ZLNET_PICTURE_LINKINFO::szDownloadKey

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;	            //预留
        };

        //新二代协议设备报警能力
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_ALARMCAP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_ALARMCAPS, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_F6ALARM_TYPE[] alarmcap;
        }

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_CAPBILITIES
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM_EX, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_ALARMCAP[] nCaps;	    //每个通道支持哪些报警类型

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//预留
        };

        //新二代协议设备总能力
        public enum ZLNET_F6_SUPPORT
        {
            ZLNET_F6_SUPPORT_REALPLAY = 0,  //二代实时视频
            ZLNET_F6_SUPPORT_PLAYBACK,      //二代回放
            ZLNET_F6_SUPPORT_IVA,           //智能分析
            ZLNET_F6_SUPPORT_EVENT,         //事件管理
            ZLNET_F6_SUPPORT_COMM,          //串口
            ZLNET_F6_SUPPORT_NET,			//网络应用
            ZLNET_F6_SUPPORT_FACEMATCH,		//人脸比对
            ZLNET_F6_SUPPORT_MAX = 256,
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_F6_CAPBILITIES
        {
            public int nEnable;		//总能力，0表示此设备不支持任何新二代协议，1时bCaps才有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = (int)ZLNET_F6_SUPPORT.ZLNET_F6_SUPPORT_MAX)]
            public byte[] bCaps;	        //支持的具体能力,与ZLNET_F6_SUPPORT配合使用
            //例如bCaps[ZLNET_F6_SUPPORT_MEDIA] == 1表示支持ZLNET_F6_SUPPORT_REALPLAY

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		    //预留
        };

        //算法版本
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALGORITHM_VERSION
        {
            public int nMajor;			//主版本
            public int nMinor;			//次版本
            public int nRev;			//修订号
            public int nSVN;			//SVN号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szModuleName;	//算法模块名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VER_SOFTWARE)]
            public string szBuildDate;	//build date

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] szReserve;	    //预留;
        };

        //新二代协议设备-报警模拟参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SIMULATE_ALARM_PARAM
        {
            public int nChannel;		//通道号
            public ZLNET_F6ALARM_TYPE nType;
            public int nIndex;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szReserve;		//预留
        };

        //IVA算法调试选项
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_IVA_DEBUG_OPTION
        {
            public int nPrintDebugFlag;	    //算法内部打印等级	0~5
            public int nImageDebugType;	    //算法内部抓图模式	0：不抓图 1：抓一次图 2：定时抓图
            public int nImageIntervalTime;	    //算法内部抓图时间间隔	0~200秒
            public int nImageDebugBufferNums;	//一帧图像的内部图像张数	1~10
            public int nMode;				    //算法检测模式	不同的设备有不同的意义，对人员计数设备是0：人头 1：肩宽


            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 63, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			        //预留
        };

        //////////////////////////////编码参数配置///////////////////////////////
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_VIDEO_JUMP
        {
            public int nJumpMode;	    //0不跳帧 1.一倍 2.两倍 3.四倍 4.HIS模式
            public int nBase;	        //base 层的周期	取值范围：大于0
            public int nEnhance;	    //enhance 层的周期	取值范围：[0, 255]。
            public int bEnablePred;	        //base 层的帧是否被base 层其他帧用作参考。	为FALSE 时，base 层的所有帧都参考IDR 帧。在虚拟I 帧使能时必须为TRUE。
            public int bVirtualIEnable;	    //是否插入虚拟I 帧，虚拟I 帧本质上是个参考IDR帧的P 帧，用于解决误码恢复、随机播放问题
            public int nVirtualIInterval;	    //虚拟I帧间隔	取值范围：大于等于1
            public int nVirtualIQpDelta;	    //虚拟I帧相对于普通P帧的QpDelta，正数表示虚拟I帧QP 减少。	取值范围：[-10, 10]
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_VIDEO_CFG
        {
            public int bEnable;
            public ZLNET_DSP_COMPILE_TYPE nCompression;	        //视频压缩格式
            public ZLNET_CAPTURE_SIZE stResolution;	        //分辨率

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szCustomResolutionName;	//默认分辨率名称,一般不要更改

            public int nBitRateControl;    //码流控制模式	0-"CBR"-固定码流 1-"VBR"-可变码流
            public int nBitRate;	        //码流(kbps)
            public int nSize;	            //编码后文件大小(bytes)	只支持图片码流，固定码流模式下有效
            public float nFPS;	            //帧率 <1.0表示多秒一帧，比如0.3333表示3秒一帧，0.2~30.0，根据帧率反向换成成一帧的秒数时，需要做四舍五入处理。
            public int nGOP;	            //I帧间隔	1-100，比如50表示每49个B帧或P帧，设置一个I帧。
            public int nQualityRange;	    //图像质量取值范围 支持：6、100，默认为6
            public int nQuality;	        //图像质量,只有在可变码流下才起作用。	取值1 - QualityRange，值越大，图像质量越好。
            public int nPack;	            //打包模式 0-DHAV,1-PS
            public int nProfile;	        //H.264’265编码Profile 0-"Baseline", 1-"Main", 2-"Extended", 3-"High"
            public int nAudioChnCnt;	    //nAudioChannels元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_CHANNUM, ArraySubType = UnmanagedType.I4)]
            public int[] nAudioChannels;    //音频立体声通道,表示该视频通道关联的音频通道

            public ZLNET_RECT stRegion;   //视频编码区域,若为空表示取值整个采集视野
            public ZLENT_ENCODE_VIDEO_JUMP stJump;	    //跳帧设置

        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_AUDIO_CFG
        {
            public int bEnable;        //使能
            public ZLNET_DSP_AUDIO_TYPE nCompression;   //音频压缩格式
            public int nMode;          //编码模式 不同编码类型定义不同：
                                       /*
                                       "AMR": 码流模式
                                       0: 4.75kbps,
                                       1: 5.15 kbps,
                                       2: 5.9 kbps,
                                       3: 6.7 kbps,
                                       4: 7.4 kbps,
                                       5: 7.95 kbps,
                                       6: 10.2 kbps,
                                       7: 12.2 kbps, 
                                       G.726和G.726ASF定义如下：
                                       0: 16Kbps,
                                       1: 24Kbps,
                                       2: 32Kbps,
                                       3: 40Kbps,
                                       */
            public int nFrequency;      //采样频率	
            public int nDepth;          //采样深度	
            public int nPacketPeriod;   //打包周期,单位ms，0表示使用默认周期
            public int nPack;           //打包模式 0-DHAV,1-PS

        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_AV_CFG
        {
            public ZLENT_ENCODE_VIDEO_CFG stVideo;
            public ZLENT_ENCODE_AUDIO_CFG stAudio;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_SNAP_CFG
        {
            public int bEnable;        //抓图使能
            public int nCompression;   //图片格式 0-JPEG 1-BMP 动检编码和报警编码不支持设置
                                       //“Width” : 720,	图片宽度	动检编码和报警编码不支持设置
                                       //“Height” : 576,	图片高度	
            public float nFPS;           //抓图速率 0-表示非定时抓图,小于1说明帧率低于1
            public int nQuality;       //图片质量 取值1 – 6，值越大，图片质量越好。

        };

        //通道编码配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLENT_ENCODE_CFG
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public ZLENT_ENCODE_AV_CFG[] stAV;       //音视频参数，下标0-主码流 1-子码流1 2-子码流2

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public ZLENT_ENCODE_SNAP_CFG[] stSnap;     //抓图参数，下标0-普通抓图 1-动检抓图 2-报警抓图
        };

        ///////////////出入口相机///////////////////
        //车辆类型
        public enum ZLNET_VEHICLE_TYPE
        {
            ZLNET_VEHICLE_Unknown = 0,
            ZLNET_VEHICLE_LargeCar = 1,
            ZLNET_VEHICLE_MicroCar,
            ZLNET_VEHICLE_EmbassyCar,
            ZLNET_VEHICLE_MarginalCar,
            ZLNET_VEHICLE_AreaoutCar,

            ZLNET_VEHICLE_ForeignCar,
            ZLNET_VEHICLE_DualTriWheelMotorcycle,
            ZLNET_VEHICLE_LightMotorcycle,
            ZLNET_VEHICLE_EmbassyMotorcycle,
            ZLNET_VEHICLE_MarginalMotorcycle,

            ZLNET_VEHICLE_AreaoutMotorcycle,
            ZLNET_VEHICLE_ForeignMotorcycle,
            ZLNET_VEHICLE_FarmTransmitCar,
            ZLNET_VEHICLE_Tractor,
            ZLNET_VEHICLE_Trailer,

            ZLNET_VEHICLE_CoachCar,
            ZLNET_VEHICLE_CoachMotorcycle,
            ZLNET_VEHICLE_TrialCar,
            ZLNET_VEHICLE_TrialMotorcycle,
            ZLNET_VEHICLE_TemporaryEntryCar,

            ZLNET_VEHICLE_TemporaryEntryMotorcycle,
            ZLNET_VEHICLE_TemporarySteerCar,
        };

        //颜色
        public enum ZLNET_ENUM_COLOR
        {
            ZLNET_COLOR_Unknown = 0,
            ZLNET_COLOR_White = 1,
            ZLNET_COLOR_Gray,
            ZLNET_COLOR_Yellow,
            ZLNET_COLOR_Pink,
            ZLNET_COLOR_Red,
            ZLNET_COLOR_Purple,
            ZLNET_COLOR_Green,
            ZLNET_COLOR_Blue,
            ZLNET_COLOR_Brown,
            ZLNET_COLOR_Black,
            ZLNET_COLOR_Other,
        };

        // 出入口相机内部黑白名单
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GATEWAY_CAMERA_RECORD
        {
            public int nRecNo;				//编号，新增时不用填写，设备会自动生成
            public ZLNET_TIME stCreateTime;	    //创建时间，仅查询时有效

            public int nControlType;		//控制类型，设备目前不支持, 0：OverdueNoCheck，1：BrigandageCar，2：CausetroubleEscape，3：Breaking，4：Other
            public ZLNET_TIME stBeginTime;		//使能开始时间
            public ZLNET_TIME stEndTime;		    //使能结束时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szOwner;	        //车主姓名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPlateNo;          //车牌号

            public int nPlateColor;	    //车牌颜色 0:蓝底白字 1:黄底 2:黑底
            public int nPlateType;		    //车牌类型 0:PersonalCar 1:OfficialCar 2: WarCar

            public ZLNET_ENUM_COLOR nVehicleColor;	    //车辆颜色 参考 ZLNET_ENUM_COLOR
            public ZLNET_VEHICLE_TYPE nVehicleType;	    //车辆类型 参考 ZLNET_VEHICLE_TYPE

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;	            //预留
        };

        // 出入口相机内部黑白名单查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GATEWAY_CAMERA_QUERY
        {
            public int nCondition;	        // 0：查询全部  1：按车牌号查询 2：按编号查询

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPlateNo;          //nCondition == 1时用于指定车牌号，支持模糊查询

            public int nRecNo;	            //nCondition == 2时用于指定编号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;	            //预留
        };

        // 出入口相机工作参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GATEWAY_CAMERA_WORKMODE
        {
            public int nDirection;	            //进出方向 0：入口 1：出口
            public int nMode;		            //工作模式 0：主控 1：辅助
            public int nTTSEnable;	            //语音播报使能 0 1
            public int nVerifyEnable;	        //车牌模糊验证使能 0 1
            public int nVerifyMode;	        //验证模式 0：仅对车牌验证 1：车牌和RFID验证 2：车牌或RFID验证

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRLEN_512)]
            public string szIdleLED;	            //LED显示内容（空闲时）

            public int nIdleLEDColor;			//字幕颜色(空闲时) 0：红色 1：绿色 2：黄色

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRLEN_512)]
            public string szPassLED;	            //LED显示内容（通过）

            public int nPassLEDColor;			//字幕颜色(通过) 0：红色 1：绿色 2：黄色

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRLEN_512)]
            public string szBanLED;	            //LED显示内容（禁止通行）

            public int nBanLEDColor;			//字幕颜色(禁止通行) 0：红色 1：绿色 2：黄色
            public int nAllowTempVehicle;		//允许临时车辆通行 0：不允许 1：允许

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1020)]
            public byte[] szRes;				    //预留
        };

        //蛮牛穿网设备查询
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_SERIALNO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szSerialno;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_UDX_DEVLIST
        {
            public int nNumber;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_UDX_DEV, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_SERIALNO[] dev;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LINK_TITILE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szTitle;  // 标题文本

            public ZLNET_POINT Point;      // 标题左上角坐标
            public int nWidth;
            public int nHight;
            public uint frontColor; //前景颜色
            public uint backColor;  //背景颜色

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LINK_LIGHT
        {
            public int nChannel;
            public uint backColor;      //颜色
            public int nBlink;			//灯光闪烁频率,0代表不闪烁，单位毫秒

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] szRes;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LINK_PTZ
        {
            public int nChannel;
            public int nType;       // 0无联动 1联动预置点 2联动轮巡 3联动巡航
            public int nValue;	    // 联动取值分别对应预置点号，巡航号等等

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;
        };

        //检测动作
        public enum ZLNET_ENUM_DETECT_ACTION
        {
            ZLNET_E_APPEAR = 0,		//出现
            ZLNET_E_DISAPPEAR,		//消失
            ZLNET_E_INSIDE,			//在区域内
            ZLNET_E_CROSS,			//穿越区域
        };

        //短信设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CONTACT_INFO
        {
            public int bEnable;			//使能开关
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szNumber;		// 联系号码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;		    // 名称
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SHORTMSG_CFG
        {
            public int bEnable;             //总使能开关
            public int nInterval;           //发送间隔
            public int nCount;		        //stInfo有效数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CONTACT_INFO[] stInfo;     //联系人
        };

        public const int ZLNET_MAX_LINK_NUM = 16;                   // 最大联动通道数

        // 报警联动配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_HANDLER_CONFIG
        {
            public int nDejitter;				        // 重复报警时间间隔，单位为秒
            public int nAlarmHoldTime;			// 预警保持时间(前端触发报警持续此时间后才视为产生报警）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_N_WEEKS, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_REC_TSECT[] stuTimeSection;           // 布防时间表

            //--杂项使能--
            public int bRebootEnable;           // 重启使能
            public int bTipEnable;				// 本地消息框提示
            public int bMessageEnable;      // 短信发送使能(具体的联系人使用ZLNET_SHORTMSG_CFG配置）
            public int bEventCenter;            // 上传到事件中心
            public int bBeepEnable;         // 蜂鸣
            public int bLogEnable;              // 是否记录日志
            public int bMMSEnable;			// 发送彩信使能

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;                  // 预留

            //--录像相关--
            public int bRecordEnable;           // 录像使能
            public int nRecordChnNum;			// arrRecordChn的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] arrRecordChn;          // 录像通道号列表

            public int nRecordLatch;            // 录像延时时间(秒)

            //--视频叠加--
            public int bVideoTitleEnable;       //是否叠加视频标题
            public int nVideoTitleNum;			// stVideoTitle的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_LINK_TITILE[] stVideoTitle;           //视频叠加标题

            //--报警输出相关--
            public int bAlarmOutEn;         // 报警输出使能
            public int nAlarmOutChnNum;     // arrAlarmOutChn的有效元素个数


            public int[] arrAlarmOutChn;            // 报警输出通道列表

            public int nAlarmOutLatch;          // 报警输出延时时间(秒)

            public int bExAlarmOutEn;           // 扩展报警输出使能
            public int nExAlarmOutChnNum;		// arrExAlarmOut的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] arrExAlarmOut;         // 扩展报警输出通道列表

            //--云台联动相关--
            public int bPtzLinkEn;              // 云台联动使能
            public int nPtzLinkDelay;           // 云台联动延迟 0~10秒，无此字段时默认值为0
            public int nPtzLinkNum;			// stuPtzLink的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_LINK_PTZ[] stuPtzLink;             // 云台联动项

            //--联动抓图相关--
            public int bSnapshotEn;         // 联动抓图使能
            public int nSnapChnNum;			// arrSnapshot的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] arrSnapshot;           // 联动抓图通道列表

            public int nSnapshotPeriod;     // 连拍周期(秒)
            public int nSnapshotTimes;          // 连拍次数
            public int bSnapshotTitleEnable;    // 是否叠加图片标题
            public int nSnapTitleNum;			// stSnapTitle的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_LINK_TITILE[] stSnapTitle;            //叠加图片标题

            //--灯光相关--
            //public int bFlashEnable;	// 是否使能补光灯
            //public int nFlashLatch;	// 补光灯延时时间（秒）
            //public int nVideoInMode;	// 联动视频配置模式 0-白天；1-晚上；2-普通
            //public int bLightEnable;	// 灯光使能
            //public int nLightNum;		// arrLight的有效元素个数

            //[MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.Struct)]
            //public ZLNET_LINK_LIGHT[] arrLight; //灯光列表

            //--矩阵输出--
            public int bMatrixEnable;           //矩阵输出使能
            public int nMatrixChnNum;	        // arrMatrixChannels的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] arrMatrixChannels;     // 矩阵输出通道列表

            //--邮件--
            public int bMailEnable;         // 发送邮件，如果有图片，作为附件
            public int nMailAttachmentType; // 邮件附件类型0 video, 1 picture
            public int nMailMaxSize;            // 邮件文件大小上限，单位KB
            public int nMailMaxTimeLength;      // 邮件最大录像时间长度，单位秒，对video有效

            //--语音--
            public int bVoiceEnable;            // 语音提示
            public int nVoiceChnNum;			// arrVoiceChannel的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_LINK_NUM, ArraySubType = UnmanagedType.I4)]
            public int[] arrVoiceChannel;	        // 联动语音提示通道列表

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string szAudioFileName;		// 联动语音文件路径,为空播放默认报警联动音

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I4)]
            public int[] nRes2;		            // 预留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_OBJECT_NAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szObjectType;		// 规则名称,不同规则不能重名
        }

        // 规则通用属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GENERAL_RULE_CONFIG
        {
            public int bRuleEnable;								// 规则使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szRuleName;       // 规则名称,不同规则不能重名

            public int nDetectID;           // 规则ID / 区域ID
            public int nReportInterval;	// 上报间隔, 单位：秒

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSceneType;  // 应用场景,详见"支持的场景列表"

            public int nObjTypeNum;	// 相应物体类型个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_OBJECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_OBJECT_NAME[] szObjTypeList;  // 相应物体类型列表

            public int nPtzPresetId;	// 云台预置点编号	0~65535

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;			// 保留字段
        };

        // 校准框
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CALIBRATEBOXS
        {
            // 校准框
            public ZLNET_POINT pointCenter; // 校准框中心点坐标 计量方式2时使用
            public float dRatio;			// 相对基准校准框的比率,比如1表示基准框大小，0.5表示基准框大小的一半

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] szRes;			// 保留字段
        };

        // 过滤校准
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RULE_FILTER_CONFIG
        {
            // 目标过滤
            public int bFilterEnable;       // 是否启用规则自身目标过滤（部分规则可能无法启用）
            public int nMeasureMode;        // 计量方式 0:图像尺寸过滤 1:实际尺寸过滤(米) 2:归一化图像尺寸过滤
            public int nFilterType;     // 过滤类型:0:"ByLength",1:"ByWidthHeight",2:"ByArea"
            public float dMinWidth;         // 物体最小宽
            public float dMinHight;         // 物体最小高
            public float dMaxWidth;         // 物体最大宽
            public float dMaxHight;         // 物体最大高

            // 校准框
            public int nCalibrateBoxsNum;	// 校准框数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_CALIBRATEBOXS[] stuCalibrateBoxs;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;			    // 保留字段
        };

        //跨线规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CROSSLINE_RULE_CONFIG
        {
            public int nDirection;          // 检测方向:0:由左至右;1:由右至左;2:两者都可以
            public ZLNET_LINE stuDetectLine;        // 警戒线

            public int nPositionNum;		// nTriggerPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] nTriggerPosition;	// 触发报警位置:0:Center;1:LeftCenter;2:TopCenter;3:RightCenter;4:BottomCenter

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //围栏规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CROSSFENCE_RULE_CONFIG
        {
            public int nDirection;			// 检测方向:0:由左至右;1:由右至左;2:两者都可以
            public ZLNET_LINE stUpstairsLine;		// 围栏上面的一条线
            public ZLNET_LINE stDownstairsLine;	// 围栏上面的一条线

            public int nPositionNum;		// nTriggerPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] nTriggerPosition;	// 触发报警位置

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //警戒区规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_CROSSREGION_RULE_CONFIG
        {
            public int nDirection;                  // 检测方向:0:Enter;1:Leave;2:Both
            public ZLNET_REGION stDetectRegion;             // 警戒区

            public int nActionNum;					//支持的检测动作个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_ENUM_DETECT_ACTION[] arrActionList;                //检测动作列表

            public int nMinTargets;             // 最小目标个数,Action为"Inside"有效
            public int nMaxTargets;             // 最大目标个数,Action为"Inside"有效
            public int nMinDuration;                // 最短持续时间,Action为"Inside"有效，单位：秒

            public int nAppearReportInterval;       // 出现报告间隔
            public int nDisappearReportInterval;    // 消失报告间隔
            public int nEnterReportInterval;        // 入侵报告间隔
            public int nLeaveReportInterval;        // 离开报告间隔

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;						// 保留字段
        };

        //物品遗留 物品盗移规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ASSET_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;         // 检测区域

            public int nPositionNum;			// nTriggerPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] nTriggerPosition;     // 触发报警位置

            public int nMinDuration;            // 最短持续时间	单位：秒，0~65535
            public int nMinHightRation;		// 最小报警高度比例 4-16

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;					// 保留字段
        };

        //车牌 车位 规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_PLATE_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;         // 检测区域

            public int nPositionNum;			// nTriggerPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] nTriggerPosition;     // 触发报警位置

            public int nMinDuration;            // 最短持续时间	单位：秒，0~65535
            public int nParkNum;				// 车位号

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;					// 保留字段
        };

        //徘徊规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_WANDER_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;         // 检测区域

            public int nPositionNum;			// nTriggerPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] nTriggerPosition;     // 触发报警位置

            public int nMinDuration;            // 最短持续时间	单位：秒，0~65535
            public int nTriggerTargetsNumber;   // 触发报警的人数
            public int nTotalStayingInterval;   // 徘徊时间	单位：秒，0～40
            public int nTotalDistance;			// 徘徊移动距离 单位：身位，5～50

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				    // 保留字段
        };

        //数量统计(周界) 流量统计(人员计数) 规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_COUNT_RULE_CONFIG
        {
            public int nType;               // 统计类型 0：区域 1：线
            public int nUpperLimit;     // 上限 单位：个，1~65535
            public int nDirection;          // 检测方向:0:由左至右;1:由右至左;2:两者都可以
            public ZLNET_REGION stDetectRegion;     // 检测区
            public ZLNET_LINE stDetectLine;		// 检测线	

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;			    // 保留字段
        };

        //逆行规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RETROGRADE_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;     // 检测区域

            public int nPositionNum;		// arrPosition有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_INFO_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_E_POSITION[] arrPosition;      // 触发报警位置

            public ZLNET_LINE stDirectionLine;  // 正常行驶方向, 按照此方向行驶是正向，反过来是逆行

            public int nSensitivity;        // 灵敏度，取值1-10，值越小灵敏度越低
            public int nRetrogradeRange;	// 逆行距离约束

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //VQD规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VQD_RULE_CONFIG
        {
            public int nTimeInterval;       // 报警时间间隔(分) 0-200
            public int nThreshold;			// 阈值 0-10 越大越不灵敏

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //通用单区域规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_REGION_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;     // 检测区
            public int nSensitivity;        // 灵敏度，取值300-1500，值越小灵敏度越低
            public int nMinDuration;		// 最短持续时间	单位：秒，0~5000

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //通用人脸相关规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;     // 检测区
            public int nFaceNum;			// szFaceList有效个数
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_OBJECT_NUM, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_OBJECT_NAME[] szFaceList;	        // 相应人脸类型列表

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //多人聚集规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_GATHER_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;     // 检测区
            public int nMinDuration;        // 最短持续时间	单位：秒，0~60
            public ZLNET_REGION stMinRegion;        // 最小聚集区域
            public int nTriggerNumber;      // 触发报警的聚集人数	2～6
            public int nSensitivity;	    // 灵敏度	取值1-10

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;				// 保留字段
        };

        //行为过激 人员挟持 规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIOLENCE_RULE_CONFIG
        {
            public ZLNET_REGION stDetectRegion;     // 检测区
            public int nMode;               // 检测模式 0视频 1音频 2音视频联合检测
            public int nMinDuration;        // 最短持续时间	单位：秒，0~60
            public int nSensitivity;		// 灵敏度	取值1-10

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;			    // 保留字段
        };

        //加钞间运动入侵 规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_INVADE_RULE_CONFIG
        {
            public int nWarningInterval;                // 报警间隔  0～100
            public int nMinSizeArea;					// 最小检测面积所占比  1～100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;					// 保留字段
        };

        //报警规则框
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_RULE_LINE_REGION
        {
            public ZLNET_GENERAL_RULE_CONFIG stGeneral; // 基本参数
            public ZLNET_ALARM_HANDLER_CONFIG stHandler;    // 联动
            public ZLNET_RULE_FILTER_CONFIG stFilter;   // 目标过滤

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            public byte[] szRes;      //预留

            public ZLNET_F6ALARM_TYPE nType;		// 报警规则类型

            //szUnion依据nType不同,取下面不同的结构体
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
            public byte[] szUnion;	    //报警规则

            //ZLNET_REGION_RULE_CONFIG		    stSingleRegion;	//nType == ZLNET_F6ALARM_SSB_TRAIL || ZLNET_F6ALARM_SSB_FELL || ZLNET_F6ALARM_DENSITY_DETECTION
            //                                                  //|| ZLNET_F6ALARM_ATM_PANELPASTE <= nType <= ZLNET_F6ALARM_ATM_STAY

            //ZLNET_VQD_RULE_CONFIG			    stVQD;			//ZLNET_F6ALARM_VQD_DARK <= nType <= ZLNET_F6ALARM_VQD_UNBALANCE

            //ZLNET_FACE_RULE_CONFIG			stFace;			//nType == ZLNET_F6ALARM_FACE_DETECTION || ZLNET_F6ALARM_ATM_FACECAPTURE 
            //                                                  //|| ZLNET_F6ALARM_ABNORMAL_FACE || ZLNET_F6ALARM_ATM_FACEABNORMAL

            //ZLNET_PLATE_RULE_CONFIG           stPlate;        //nType == ZLNET_F6ALARM_PARK_SPACE || ZLNET_F6ALARM_PLATE_DETECION

            //ZLNET_CROSSLINE_RULE_CONFIG		stCrossLine;	//nType == ZLNET_F6ALARM_CROSSLINE_DETECTION
            //ZLNET_CROSSFENCE_RULE_CONFIG	    stCrossFence;	//nType == ZLNET_F6ALARM_CROSSFENCE_DETECTION
            //ZLNET_CROSSREGION_RULE_CONFIG	    stCrossRegion;	//nType == ZLNET_F6ALARM_CROSSREGION_DETECTION
            //ZLNET_ASSET_RULE_CONFIG			stAsset;		//nType == ZLNET_F6ALARM_LEFT_DETECTION || ZLNET_F6ALARM_TAKEAWAY_DETECTION || ZLNET_F6ALARM_SSB_REMNANTS
            //ZLNET_WANDER_RULE_CONFIG		    stWander;		//nType == ZLNET_F6ALARM_WANDER_DETECTION || ZLNET_F6ALARM_SSB_HOVER
            //ZLNET_COUNT_RULE_CONFIG			stCount;		//nType == ZLNET_F6ALARM_NUMBER_STAT || ZLNET_F6ALARM_FLOW_STAT
            //ZLNET_RETROGRADE_RULE_CONFIG	    stRetrograde;	//nType == ZLNET_F6ALARM_RETROGRADE_DETECTION
            //ZLNET_GATHER_RULE_CONFIG          stGathter;      //nType == ZLNET_F6ALARM_SSB_GATHER
            //ZLNET_VIOLENCE_RULE_CONFIG        stViolence;     //nType == ZLNET_F6ALARM_SSB_FIGHT || ZLNET_F6ALARM_SSB_HIJACK
            //ZLNET_INVADE_RULE_CONFIG          stInvade;       //nType == ZLNET_F6ALARM_SSB_INVADE
        };

        //报警规则配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARM_RULE_CONFIG
        {
            public int nChannel;    // 通道号

            public int nRuleNum;	// 数组stRules的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_IVS_MAX_RULE_NUM, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_RULE_LINE_REGION[] stRules;	// 规则框

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//预留
        };

        //视频前端临时参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOIN_TMP_CFG
        {
            public int nAntiFlicker;            //防闪烁模式  0-Outdoor, 1-50Hz防闪烁, 2-60Hz防闪烁
            public int nDelog;                  //透雾能力范围	0-关闭，1-弱，2-中，3-强
            public int nExposureMode;           //曝光模式     nExposureSpeed为0时有效，取值：0-默认自动，1-增益优先，2-快门优先，3-50hz防闪烁，4-60HZ防闪烁，5-光圈优先，6-手动调节，7-高度优先，8-低亮优先
            public float nExposureValue1;       //自动曝光时间下限或者手动曝光自定义时间 0.1ms~80ms
            public float nExposureValue2;       //自动曝光时间上限 nExposureValue1~80ms
            public int nGainMin;                //增益下限  0~100
            public int nGainMax;				//增益上限	nGainMin~100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//预留
        };

        //视频前端详细参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOIN_DETAIL_CFG
        {
            public int nAutoSyncPhase;              //自动相位调节	0否，1是
            public int nSyncPhaseMode;              //是否外同步相位 0内同步，1外同步
            public float nExternalSyncPhase;            //外部同步信号相位  0~360°

            public int nAntiFlicker;                //防闪烁模式  0-Outdoor, 1-50Hz防闪烁, 2-60Hz防闪烁
            public int nMirror;                 //是否开启画面镜像功能
            public int nFlip;                       //是否开启画面翻转功能
            public int nRotate90;                   //旋转标志  0-不旋转，1-顺时针90°, 2-逆时针90°
            public int nDelog;                      //透雾能力范围	0-关闭，1-弱，2-中，3-强
            public int nColorMode;                  //色彩模式	0-标准，1-自然，2-艳丽
            public int nImageMode;                  //图像模式	0-通透模式，1-真实模式
            public int nCompansation;

            //宽动态
            public int nWideDynamicRange;           //宽动态范围 0-关闭，1~100-为真实范围值
            public int nGlareInhibition;            //强光抑制	0-关闭， 1~100为范围值
            public int nWideDynamicRangeMode;       //宽动态模式 0：默认。1：强制打开。2：自动调节。

            public int nBacklight;                  //背光补偿等级  0-关闭 1-启用 2-指定区域背光补偿
            public ZLNET_RECT stBacklightRegion;            //背光补偿区域

            public int nDayNightColor;              //黑白彩切换  0-总是彩色，1-光敏电阻切换，2-Sensor感光切换, 3-总是黑白，
                                                    //4-根据外部IO进行切换, 5-根据光敏阈值切换, 6-混合切换（彩转黑用模式2，黑转彩模式1）
            public int nDayNightColorDelay;     //颜色切换换延时时间  0~60s
            public int nPhotoresistorNight2DayThreshold;    //光敏电阻黑转彩阈值	0~100
            public int nPhotoresistorDay2NightThreshold;    //光敏电阻彩转黑阈值	0~100
            public int nSenosorNight2DayThreshold;  //Sensor感光黑转彩阈值	0~100
            public int nSensorDay2NightThreshold;   //Sensor感光彩转黑阈值	0~100
            public int nMixedDay2NightThreshold;    //混合模式彩转黑阈值	0~100

            public int nIrisAuto;                   //自动光圈	0-关闭 1-启用
            public int nApertureSensitivity;        //自动光圈灵敏度  0-100

            //曝光
            public int nExposureSpeed;              //曝光速度等级 取值范围取决于设备能力集：0-自动曝光; 1~n-1-手动曝光等级; n-带时间上下限的自动曝光; n+1-自定义时间手动曝光
            public int nExposureMode;               //曝光模式     nExposureSpeed为0时有效，取值：0-默认自动，1-增益优先，2-快门优先，
                                                    //3-50hz防闪烁，4-60HZ防闪烁，5-光圈优先，6-手动调节，7-高度优先，8-低亮优先
            public float nExposureValue1;           //自动曝光时间下限或者手动曝光自定义时间 0.1ms~80ms
            public float nExposureValue2;           //自动曝光时间上限 nExposureValue1~80ms

            //白平衡
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHANNEL_MODE_MAX_NUM)]
            public string szWhiteBalance;   //白平衡模式 字符串"Disable", "Auto", "Custom", "Sunny", "Cloudy", "Home", "Office", "Night", 
                                            //"HighColorTemperature", "LowColorTemperature", "AutoColorTemperature", "CustomColorTemperature", "Indoor", "Outdoor", "ATW", "Manual","ManualDatum","Lock"

            public ZLNET_RECT stWhiteBalanceDatumRect;      //ManualDataum模式时的白平衡区域
            public int nColorTemperatureLevel;              //色温等级调节，白平衡为"CustomColorTemperature"模式下有效 0~255
            public int nColorTemperatureLevel2;         //色温等级调节2，白平衡为"CustomColorTemperature"模式下有效 0~255
            public int nGainRed;        //红色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGainGreen;      //绿色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGainBlue;       //蓝色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGainMin;        //增益下限  0~100
            public int nGainMax;        //增益上限	nGainMin~100
            public int nGain;           //增益调节  0~100
            public int nGainAuto;       //自动增益
            public int nDigitalGain;    //数字增益  0~100

            //SmartIr
            public int nSmartIrMode;        //SmartIr工作模式  0-手动模式，1-自动模式。
            public int nSmartIrLevel;       //手动模式，SmartIrType单灯模式下，smartIr的强度  0-100
            public int nDSmartIrNearLevel;  //手动模式，SmartIrType双灯模式下，近灯smartIr的强度  0-100
            public int nDSmartIrFarLevel;   //手动模式，SmartIrType双灯模式下，远灯smartIr的强度  0-100

            public ZLNET_VIDEOIN_TMP_CFG stTmp;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//预留
        };

        //视频前端爆闪灯参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOIN_FLASHLIGHT_CFG
        {
            public int nMode;               //工作模式  0-禁止闪光，1-始终闪光，2-自动闪光
            public int nValue;              //闪光灯时间  nValue * 64 us  0~15
            public int nPreValue;           //亮度预设值，环境亮度低于此值，闪光灯开始工作  0~100
            public int nPole;               //触发模式  0-低电平 1-高电平 2-上升沿 3-下降沿
            public int nDutyCycle;          //占空比  0~100
            public int nFrequencyMultiple;  //倍频  0~10
            public int nDelayTime;			//延时闪时间  单位us，负数表示提前闪光

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;			    //预留
        };

        //视频前端抓图参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOIN_SNAPSHOT_CONFIG
        {
            //曝光
            public int nExposureSpeed;              //曝光速度等级 取值范围取决于设备能力集：0-自动曝光; 1~n-1-手动曝光等级; n-带时间上下限的自动曝光; n+1-自定义时间手动曝光
            public float nExposureValue1;           //自动曝光时间下限或者手动曝光自定义时间 0.1ms~80ms
            public float nExposureValue2;           //自动曝光时间上限 nExposureValue1~80ms

            //白平衡
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_CHANNEL_MODE_MAX_NUM)]
            public string szWhiteBalance;           //白平衡模式 字符串"Disable", "Auto", "Custom", "Sunny", "Cloudy", "Home", "Office", "Night", 
                                                    //"HighColorTemperature", "LowColorTemperature", "AutoColorTemperature", "CustomColorTemperature", "Indoor", "Outdoor", "ATW", "Manual","ManualDatum","Lock"

            public int nColorTemperatureLevel;      //色温等级调节，白平衡为"CustomColorTemperature"模式下有效 0~255
            public int nGainRed;                    //红色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGainGreen;                  //绿色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGainBlue;                   //蓝色增益调节，白平衡为"Custom"模式下有效  0~100
            public int nGain;                       //增益调节  0~100
            public int nGainAuto;		            //自动增益
        };

        //视频前端参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOIN_CONFIG
        {
            public int nSwitchMode;     //切换模式	0-总是使用白天配置；1-根据亮度切换；2-根据时间切换；3-总是使用夜晚配置；4-总是使用普通配置

            //nSwitchMode == 2 根据时间切换时的时间
            public int nSunriseHour;
            public int nSunriseMinute;
            public int nSunriseSecond;
            public int nSunsetHour;
            public int nSunsetMinute;
            public int nSunsetSecond;

            //nSwitchMode == 1 根据亮度切换时的亮度阈值
            public int nBrightnessThreshold;    //亮度阈值，小于该亮度时切换到夜晚  0~100

            //各个模式的详细配置
            public ZLNET_VIDEOIN_DETAIL_CFG stModeNormal;   //普通配置
            public ZLNET_VIDEOIN_DETAIL_CFG stModeDay;      //白天配置
            public ZLNET_VIDEOIN_DETAIL_CFG stModeNight;    //夜晚配置
            public ZLNET_VIDEOIN_DETAIL_CFG stRes;          //预留

            //爆闪灯配置
            public int nFlashNum;		//stFlash有效数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOIN_FLASHLIGHT_CFG[] stFlash;

            //抓图参数
            public ZLNET_VIDEOIN_SNAPSHOT_CONFIG stSnapShot;

            //杂项
            public int nDoubleExposure;     //双快门  0-不启用，1-双快门全帧率，即图像和视频只有快门参数不同，2-双快门半帧率，即图像和视频快门及白平衡参数均不同
            public int nFocusMode;              //聚焦模式  0-关闭，1-辅助聚焦，2-自动聚焦
            public ZLNET_RECT stFocusRect;			//聚焦区域 [0, 0, 8191, 8191],

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string szSignalFormat;           //输入信号模式	"Inside", "BT656", "720p","1080p", "1080i", "1080sF"

            public int nInfraRed;               //是否支持红外补偿

            //畸变矫正配置
            public int nLdcMode;            //0：关闭  1：手动开启模式
            public int nLdcRatio;           //矫正强度  0~100
            public float nLdcXoffset;       //中心X偏移量  -1.00~1.00
            public float nLdcYoffset;		//中心Y偏移量  -1.00~1.00

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;		//预留
        };

        // ---- 物联网网关相关 ----
        public enum ZLNET_ENUM_SENSOR_TYPE
        {
            ZLNET_ENUM_SENSOR_UNKNOWN = 0,      //未知
            ZLNET_ENUM_SENSOR_CAMERA,               //摄像头
            ZLNET_ENUM_SENSOR_DO,                       //开关量输出
            ZLNET_ENUM_SENSOR_DI,                           //开关量输入
            ZLNET_ENUM_SENSOR_AI,                           //模拟量输入
            ZLNET_ENUM_SENSOR_SMARTSENSOR,      //智能传感器
            ZLNET_ENUM_SENSOR_TRANSPARENT,	    //数据透传
        };

        //智能传感器配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SMARTSENSOR_CONFIG
        {
            public int nEnable;	    //使能 0不使能  1使能
            public int nRefreshInterval;		//刷新时间间隔（单位为秒）

            public ZLNET_CHANNEL_TYPE nChannelType;			//接口类型
            public int nChannel;		//通道号（对于不同的传感器，通道号有不同的意义）

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;	        //名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorType;	        //传感器类型,例如"ModbusTH"

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szProtocol;	        //协议类型,例如"THProtocol"温湿度协议

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szFactory;	        //传感器厂商

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szModel;          //传感器型号

            public int nValueNum;	    //value个数

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;	                //nChannelType == ZLNET_CT_RJ45 时的IP地址

            public int nPort;	            //nChannelType == ZLNET_CT_RJ45 时的端口
            public int nAddr;		    //nChannelType==ZLNET_CT_485||ZLNET_CT_232时的串口地址

            public int nStorageInterval;       //设备本地存储间隔（单位为毫秒，0表示不存储，应大于等于nRefreshInterval）

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2044)]
            public byte[] szRes;              //预留
        };

        //模拟量输入(AI)配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ANALOG_CONFIG
        {
            public int nEnable;            //使能 0不使能 1使能，对于AI/DI双模接口，使能为AI将自动导致DI变为不使能
            public int nRefreshInterval;   //刷新时间间隔，秒

            public int nChannel;           //通道号(指物理接口号）
            public int nPrecision;         //数据精度，小数点后几位

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;       //名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorMethod;     //废弃字段，暂时保留

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szAnalogType;	    //模拟量类型，详见开发手册，"Temperature"温度、"Humidity"湿度、"WindSpeed"风速

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szValueUnit;	    //单位

            //物理连线
            public int nChannelType;       //输入类型 0电流输入 1电压输入
            public int nSignalHigh;        //上限
            public int nSignalLow;         //下限

            //测点值上报范围（例如-10到90度）
            public int nRangeHigh;         //上限
            public int nRangeLow;          //下限

            //防区
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szDefenceAreaType;  //防区类型"Intime"即时防区、"Delay"延时防区、"Fullday"24小时防区

            public int nDefence;           //防区是否使能，0旁路 1使能
            public int nDisableDelay;      //延时撤防时间
            public int nEnableDelay;       //延时布防时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;              //预留
        };

        //开关量输入(DI)配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMIN_CONFIG
        {
            public int nEnable;            //使能 0不使能 1使能，对于AI/DI双模接口，使能为DI将自动导致AI变为不使能
            public int nChannel;            //通道号(指物理接口号）
            public int nChannelType;       //0常开 1常闭
            public int nPole;              //极性，0高有效，1低有效，具体表现为传感器接地or电源，与nChannelType组合使用

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;	    //名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorMethod;	//废弃字段，暂时保留

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szAlarminType;	//输入类型，详见开发手册，"AlarmButton"报警按钮、"ShockSensor"震动、"DoorMagnetism"门磁开关

            //防区
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szDefenceAreaType;    //防区类型"Intime"即时防区、"Delay"延时防区、"Fullday"24小时防区

            public int nDefence;       //防区是否使能，0旁路 1使能
            public int nDisableDelay;  //延时撤防时间
            public int nEnableDelay;   //延时布防时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;        //预留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_TIME_AUTO_TRIG
        {
            public int nHour;	//定时时间，时
            public int nMin;	    //定时时间，分
            public int nSec;	    //定时时间，秒

            public int nDurationTime;//触发持续时间，单位秒
        };

        //开关量输出(DO)配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_ALARMOUT_CONFIG
        {
            public int nEnable;            //使能 0不使能  1使能
            public int nChannel;           //通道号(指物理接口号）
            public int nChannelType;       //0常开 1常闭

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;	    //名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szAlarmoutType; 	//输出类型，由于输出设备为纯线路接出，所以此处一般是用户自行随意填写

            public int nOutMode;           //报警输出模式 0-自动报警，1-强制报警，2-关闭报警
            public int nManualDurationTime;    //手动控制输出持续时间，秒,0表示一直持续不自动复位

            //定时触发相关配置
            public int nTimeTrig;          //定时触发使能 0不使能  1使能
            public int nTimeNumber;	     //stTrig有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_TIME_AUTO_TRIG[] stTrig; //最多支持16个时间点

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;//预留
        };

        //物联网网关能力
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_CAPBILITY
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szProtocol;	        //协议类型,例如"THProtocol"温湿度协议

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szFactory;	        //传感器厂商

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szModel;          //传感器型号

            public ZLNET_ENUM_SENSOR_TYPE nMainSensorType;    //传感器大类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorType;	        //传感器详细类型,与nMainSensorType有关联关系，详见开发手册

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.I4)]
            public ZLNET_CHANNEL_TYPE[] nChannelType;              //接口类型列表
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_CAPS
        {
            public int nCapsNum;       //stCaps有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SENSOR_CAPBILITY[] stCaps;
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct STRUCT_POINT_NAME
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;
        }

        //取传感器列表
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_DEVICE
        {
            public int nSensorID;		        //传感器ID，是传感器的唯一标识符

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorName;	        //名称

            public int nPointCounts;		    //下辖测点数量
            public int nSubDeviceNum;		//下辖子设备数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] szSubDevice;	            // 子设备列表

            public ZLNET_CHANNEL_TYPE nChannelType;			//物理通道类型
            public int nChannel;	                //通道号（对于不同的传感器，通道号有不同的意义）

            public ZLNET_ENUM_SENSOR_TYPE nMainSensorType;    //传感器大类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szSensorType;	        //传感器详细类型,与nMainType有关联关系，详见开发手册

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
            public byte[] szRes;
        };

        //传感器及测点报警状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_POINT_STAT
        {
            public int nStat;   //具体报警类型 0未知 1超过阈值上限 2低于阈值下限 3定值触发 4传感器断线
            public ZLNET_MEASURING_VALUE valuePair;		//详细传感参数
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_STATE
        {
            public int nSensorID;	    //传感器ID，是传感器的唯一标识符
            public int nState;          //0离线 1在线

            //以下为该传感器下报警的测点(注意，不含未报警测点）
            public int nAlarmPointNumber;   //报警的测点数量，即pointState数组的有效元素个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SENSOR_POINT_STAT[] pointState;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] szRes;           //预留
        };

        //测点数据结构查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MEASURINGPOINT_QUERY
        {
            public int nSensorID;	            //测点所属的传感器ID

            public int bSpecifyName;	        //是否指定测点名称,支持模糊查找

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] szPointName;	            // 指定要查询的测点名称（支持模糊查找）,bSpecifyName==1时有效

            public int bSpecifyIndex;	        //是否指定测点序号,例如某传感器下辖100个测点，则序号为0-99
            public int nMinIndex;	            //序号范围，bSpecifyIndex==1时有效
            public int nMaxIndex;	            //序号范围，bSpecifyIndex==1时有效

            public int bSpecifySubDevice;		//是否指定子设备

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] szSubDevice;	            // 指定子设备,bSpecifySubDevice==1时有效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;                      //预留
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DISCRETE_VALUE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szValue;              //为了通用性考虑，统一存入szValue中，结合ZLNET_MEASURING_POINT.nValueType即可正确判断

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
            public string szDescription;    //针对此值的描述
        };

        //测点数据结构
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MEASURING_POINT
        {
            public int nSensorID;	         //测点所属的传感器ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPointID;	            //测点ID，具备唯一性

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szCustomID;	        //用户自定义的测点ID，一般用于第三方对接

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPointName;        //测点名称

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szValueUnit;	         //测点值单位

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NOTE_LEN)]
            public string szDescription;	         //测点描述

            public int nRWMode;                 //测点读写模式 1只读 2只写 3读写
            public ZLNET_ENUM_VALUETYPE nValueType;                //测点值类型
            public int nRangeType;              //取值范围类型 0不限制 1比特（bit，标识取值范围只有0和1） 2连续 3离散

            //nRangeType == 2 时的连续范围
            public float nMinValue;                 //连续范围的最小值
            public float nMaxValue;                //连续范围的最大值

            //nRangeType == 3 时的离散描述
            public int nDiscreteNumber;              //stDiscrete个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DISCRETE_VALUE[] stDiscrete;	            // 离散值描述

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;                    //预留
        };

        //传感器报警联动组
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_EVENT_HANDLER_GROUP
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szHandleName;         //联动组名，相当于本联动配置的ID

            public int bEnable;				    //使能
            public ZLNET_ALARM_HANDLER_CONFIG stHandler;	  //联动
        };

        //传感器报警联动配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSORPOINT_ALARM_CONFIG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPointID;                  //测点ID,隶属于传感器

            //连续性测点的连续范围（不在范围内则报警）
            public float nMinValue;                         //连续范围的最小值
            public float nMaxValue;                         //连续范围的最大值

            //离散型测点的离散描述（在范围内则报警）
            public int nDiscreteNumber;                //stDiscrete个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_DISCRETE_VALUE[] stDiscrete;     //离散值描述
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSORDEV_ALARM_CONFIG
        {
            public int bSensorState;       //传感器断在线报警使能
        };

        [StructLayout(LayoutKind.Explicit)]
        public struct UNION_SENSOR_ALARM_CONFIG
        {
            [FieldOffset(0)]
            public ZLNET_SENSORPOINT_ALARM_CONFIG pointConfig;	    // 测点报警配置

            [FieldOffset(0)]
            public ZLNET_SENSORDEV_ALARM_CONFIG devConfig;			// 传感器本身的配置
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SENSOR_ALARM_CONFIG
        {
            public int nSensorID;            //传感器ID，是传感器的唯一标识符
            public int bEnable;				 //使能

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szHandleName;     //联动组名

            public int nConfigType;        //配置类型，0时使用下方union的pointConfig作为测点报警配置， 1时使用下方union的devConfig
            public UNION_SENSOR_ALARM_CONFIG unSensorAlarmcfg;
        };

        //传感器【实时】测点值查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MEASURING_VALUE_QUERY
        {
            public int nSensorID;	         //测点所属的传感器ID

            public int nMethod;            //预留

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] szPointID;	            // 要查询的测点ID，一次可查询多个，也可只查一个

            public int nPointIDNum;          //szPointID有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;                    //预留
        };

        //传感器【历史】测点值查询条件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_MEASURING_HISTORY_QUERY
        {
            public int nSensorID;		 //测点所属的传感器ID

            public ZLNET_TIME_EX stBegin;       //开始时间
            public ZLNET_TIME_EX stEnd;          //结束时间

            public int nMethod;		    //0按测点ID查询 1按测点名称查询（支持模糊查找）

            //以下nMethod == 0时有效
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] szPointNameOrID;	            //根据nMethod填入测点名称或ID，nKeyNum为实际填写个数

            public int nKeyNum;		                    //szPointNameOrID有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;		    //预留
        };

        //传感器实时数据订阅参数
        public struct ZLNET_SUBSCRIBE_SENSOR
        {
            public int nSensorID;
            public int nPointIDNum;		//listPointID有效个数,为0时表示订阅本传感器下所有测点

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.Struct)]
            public STRUCT_POINT_NAME[] listPointID;	//指定测点，最多32个
        };

        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_SUBSCRIBE_SENSORDATA
        {
            public int nTimeval;               //上报间隔,毫秒，为0时设备数据变化才报，大于0时为有效间隔

            public int bSpecifySensor;     //是否指定传感器，指定时listSensorID有效,不指定则订阅全部

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_SUBSCRIBE_SENSOR[] listSensorID;           //预留

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;		            //预留
        };
        // ---- 物联网网关相关 END ----


        //////////////////////////////////////////////////////////////////////////
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VERSION_INFO_V30
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VERSION_LEN)]
            public string szSoftVersion;        // 软件版本 "4.1.1.1.R"

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VERSION_LEN)]
            public string szSoftBuildDate;      // 软件发布时间 "2016-12-06"

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VERSION_LEN)]
            public string szWebVersion;         // WEB版本 "3.0.0.3"

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VERSION_LEN)]
            public string szWebBuildDate;       // WEB发布时间 "2016-12-01"

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_VERSION_LEN)]
            public string szHardVersion;        // 硬件版本 "1.0"

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1808)]
            public byte[] szRes;                // 预留
        }

        /////////////////////////////////ZLNET_Login_V30//////////////////////////
        // ZLNET_Login_V30登录模式
        public enum ZLNET_ENUM_LOGIN_MODE
        {
            //以下方式IP填IP地址或者域名
            ZLNET_LOGINMODE_TCP = 0,        // TCP (建议使用）
            ZLNET_LOGINMODE_TCP_MULTICAST,  // TCP登录 + 组播视频
            ZLNET_LOGINMODE_TCP_UDP,        // TCP登录 + UDP视频
            ZLNET_LOGINMODE_TCP_SINGLE,     // TCP单链接

            //以下方式IP填序列号（UUID）
            ZLNET_LOGINMODE_REVERSE = 10,   // 反向注册
            ZLNET_LOGINMODE_REVERSE_SINGLE, // 反向注册单链接
            ZLNET_LOGINMODE_VVNAT,          // VVNAT穿网
            ZLNET_LOGINMODE_VVNAT_SINGLE,   // VVNAT穿网单链接
            ZLNET_LOGINMODE_UDX_SINGLE,		// UDX穿网单链接 (UDX只提供单链接模式)
        };

        // ZLNET_Login_V30错误码
        public enum ZLNET_ENUM_LOGIN_ERROR
        {
            ZLNET_LOGINERR_SUCCESS = 0,     // 成功
            ZLNET_LOGINERR_PASSWORD,        // 密码不正确
            ZLNET_LOGINERR_USER,            // 帐户不存在
            ZLNET_LOGINERR_TIMEOUT,         // 等待登录返回超时
            ZLNET_LOGINERR_RELOGGIN,        // 帐号已登录，请检查是否使用了不复用的帐号
            ZLNET_LOGINERR_LOCKED,          // 帐号已被锁定，密码连续错一定次数导致
            ZLNET_LOGINERR_BLACKLIST,       // 帐号已被列为黑名单
            ZLNET_LOGINERR_BUSY,            // 资源不足，系统忙，常见于设备登录用户过多

            ZLNET_LOGINERR_SUBCONNECT,      // 登录设备成功，但无法创建子链接，请检查网络状况或设备资源
            ZLNET_LOGINERR_CONNECT,         // 网络连接失败

            ZLNET_LOGINERR_PARAM,           // 登录接口传入的参数有误
            ZLNET_LOGINERR_IPORDOMAIN,      // IP或域名无效

            ZLNET_LOGINERR_SERIAL = 12,     // 序列号格式错误

            ZLNET_LOGINERR_UNKNOWN,			// 未知错误
        };

        // ZLNET_Login_V30错误码
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_LOGIN_ERROR
        {
            public ZLNET_ENUM_LOGIN_ERROR nError;		// 登录失败时的错误码

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MEMO_LENGTH)]
            public string szError;                  // 与错误码对应的字符串

            public int nLeftTry;                    // 密码不正确的剩余尝试次数，-1表示未知
            public int nLockSeconds;	        // 帐号被锁定的剩余锁定秒数，-1表示未知

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;	    //预留
        };

        // ZLNET_Login_V30对应的设备信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_DEVICEINFO_V30
        {
            public int nDevType;			// 此字段无效，请使用szDevType和szDevType2

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType;			// 设备型号(与设备WEB页上的一致）

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szSerialNumber;	    // 生产序列号

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_SERIALNO_LEN)]
            public string szUUID;               // UUID

            public int nChannelNum;     // 视频通道总数

            //以下参数可能不准确
            public int nLocalChannel;      // 本地视频通道数
            public int nNetChannel;        // 网络视频通道数

            public int nDiskNum;            // 硬盘数
            public int nAlarmInNum;     // 报警输入口数
            public int nAlarmOutNum;		// 报警输出口数
            public int nAudioInNum;     // 音频输入口数
            public int nNetIONum;           // 网络口数
            public int nUsbIONum;           // USB口数量
            public int nComIONum;           // 串口数量
            public int nLPTIONum;			// 并口数量

            public int nDefaultVideoStandard;      // 默认视频制式 0未知 1PAL 2NTSC

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szLanguage;         // 默认语言

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType2;         // 设备型号2

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szCPU;              // CPU

            //以上参数可能不准确
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 39, ArraySubType = UnmanagedType.I4)]
            public int[] nRes1;	        //预留1

            public ZLNET_VERSION_INFO_V30 stVersion;        //版本信息及其他附加信息
            public ZLNET_DEVICE_ENABLE stEnable;        //能力集
            public ZLNET_F6_CAPBILITIES stF6Cap;	    //新二代协议能力集

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes2;	        //预留2
        };

        // ZLNET_Login_V30登录参数，不使用的参数请务必置0
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)] // 4字节对齐
        public struct ZLNET_LOGIN_PARAM
        {
            public ZLNET_ENUM_LOGIN_MODE nLoginMode;        // 登录模式

            public int bAsync;              // 【暂不支持】是否异步登录,登录接口会立即返回,根据回调判断是否成功 【暂不支持】
            fZLLoginCallBack cb;                    // 【暂不支持】异步登录回调
            public IntPtr dwUser;			// 【暂不支持】异步回调用户参数

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;         // IP或域名或序列号，依nLoginMode区分，详见ZLNET_ENUM_LOGIN_MODE

            public int nPort;           // 端口
            public int nReserved;	    //预留

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_NAME_64)]
            public string szUser;	        // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_USER_PSW_64)]
            public string szPass;	        // 密码

            public int nSpecialProtocol;    // 特殊协议

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64, ArraySubType = UnmanagedType.I4)]
            public int[] nRes;	        //预留
        };


        ///////////////////////////////分布式NVD//////////////////////////////////
        public const int ZLNET_MAX_NVD_NODE = 64;
        public const int ZLNET_MAX_NVD_VIDEOOUT = 128;
        public const int ZLNET_MAX_NVD_WINDOW = 128;
        public const int ZLNET_MAX_NVD_SCREEN = 32;
        public const int ZLNET_MAX_NVD_OUTMODES = 16;
        public const int ZLNET_MAX_NVD_SCENE = 8;
        public const int ZLNET_MAX_NVD_VIDEOLIST = 48;

        //解码器节点搜索结果
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_SEARCH_RESULT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MACADDR_LEN)]
            public string szMAC;	        // MAC地址，字母大写

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;	            // 设备IP

            public int nPort;              // 设备端口
            public int nWebPort;       // 设备WEB端口

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_DEV_TYPE_LEN)]
            public string szDevType;	     // 设备类型，如果是NVD且未被添加成子节点，后缀为master

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		    //预留
        }

        //NVD节点
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_NODE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;	        // 设备IP

            public int nPort;              // 设备端口,ZLNET_NVD_SetDevIp时无效
            public int nWebPort;       // 设备WEB端口,ZLNET_NVD_SetDevIp时无效

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string szUser;	        // 用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_NAME_LEN)]
            public string szPass;	        // 密码

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		    //预留
        }

        //NVD主控
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_PARENT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;	        // 设备IP

            public int nPort;              // 设备端口
            public int nWebPort;       // 设备WEB端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		    //预留
        }

        //NVD子节点状态
        public enum ZLNET_NVD_NODE_ERROR
        {
            ZLNET_NVDNODE_NOERROR = 0,  //正常,无错误
            ZLNET_NVDNODE_UNKNOWN,      //未知错误
            ZLNET_NVDNODE_NETERROR,     //网络错误
            ZLNET_NVDNODE_USERPW,       //用户名或密码错误
            ZLNET_NVDNODE_NOTNVD,       //不是NVD
            ZLNET_NVDNODE_IPEXIST,      //节点已经存在
            ZLNET_NVDNODE_INOTHER,		//已被其它主控管理
        };

        //NVD节点状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_NODE_STATE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DEV_ID_LEN)]
            public string szNodeID;	    // 节点ID

            public ZLNET_NVD_NODE_ERROR nState;		    //节点状态

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_IP_LEN)]
            public string szIP;	            // 设备IP

            public int nPort;              // 设备端口
            public int nWebPort;       // 设备WEB端口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
            public byte[] szRes;		        //预留
        }

        //NVD主控上已添加的所有节点状态
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_ALLNODE_STATE
        {
            public int nNum;       // 节点数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_NODE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_NODE_STATE[] stStates;
        }

        //画面颜色属性
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOOUT_COLOR
        {
            public int nBrightness;       // 亮度；0-100
            public int nContrast;          // 对比度；0-100
            public int nSaturation;       // 饱和度；0-100
            public int nHue;                 // 色度；0-100
            public int nGainEn;            // 增益使能
            public int nGain;                // 增益；0-100
            public int nSharpness;       // 锐度；0-100

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] res;		        //预留
        }

        //视频输出模式
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_VIDEOOUT_MODE
        {
            public int nWidth;         // 水平分辨率
            public int nHeight;        // 垂直分辨率
            public int nBPP;            // 颜色深度	16表示16位色，32表示32位色，依此类推
            public int nRefreshRate;         // 刷新频率	60表示60HZ
            public int nScan;          // 输出扫描模式 0:逐行，1:隔行

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] res;		        //预留
        }

        //背景设置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_BACKGROUND
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_PATH_STOR)]
            public string szPicPath;	    // 背景图，空表示用背景颜色

            public ZLNET_RGBA stColor;         // 背景色

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] res;		        //预留
        }

        //NVD显示输出(物理屏)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIDEOOUT
        {
            public int nCurState;         // 当前状态，仅获取时有效 0：获取不到状态，一般是可用 1：可用 2：未接入

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DEV_ID_LEN)]
            public string szMonitorID;	    // 物理屏ID，不可修改

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szName;	            // 视频输出名称

            public ZLNET_RECT rcMargin;              // 边界，像素为单位
            public ZLNET_VIDEOOUT_COLOR stColor;                // 颜色配置
            public ZLNET_NVD_BACKGROUND stBack;                   // 背景，如果本屏已经在一个虚拟屏组中，此设置无效
            public ZLNET_VIDEOOUT_MODE stMode;                 // 当前输出模式，支持的输出模式见stSupportedModes

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_OUTMODES, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_VIDEOOUT_MODE[] stSupportedModes;        // 支持的所有输出模式，获取时有效，设置时忽略

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] res;		        //预留
        }

        //NVD显示输出(物理屏)配置
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIDEOOUT_CFG
        {
            public int nNumber;         // stMonitors有效数量,即显示器个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_VIDEOOUT[] stMonitors;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] res;		        //预留
        }

        //虚拟屏绑定显示输出(物理屏)
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_BIND_VIDEOOUT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DEV_ID_LEN)]
            public string szMonitorID;	    // 物理屏ID

            public ZLNET_RECT stMonitors;     // 显示器在虚拟屏中的比例坐标。如整屏只有一个显示器，则为[0,0,8192,8192]

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] res;		        //预留
        }

        //NVD虚拟屏（一个虚拟屏由1个或多个VideoOut拼接）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIRTUAL_SCREEN
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_DEV_ID_LEN)]
            public string szScreenID;	    // 虚拟屏ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szName;

            public ZLNET_RECT stRect;             // 虚拟屏在电视墙中的比例坐标。如整墙只有一个虚拟屏，则为[0,0,8192,8192]
            public ZLNET_NVD_BACKGROUND stBack;           // 背景设置
            public int nBindNum;       // stVideoOut有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_VIDEOOUT, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_BIND_VIDEOOUT[] stVideoOut;      // 绑定的物理输出

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;		        //预留
        }

        //NVD电视墙(一个电视墙有1个或多个虚拟拼接屏）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_MATRIX_CFG
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRING_LEN)]
            public string szName;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;		        //预留

            public int nVirtualNumber;       // stScreen有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_SCREEN, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_VIRTUAL_SCREEN[] stScreen;      // 虚拟屏
        }

        //NVD上墙视频
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIDEO_INFO
        {
            public ZLNET_PROTOCOL_TYPE nProtocol;      // 接入协议

            //当nProtocol == ZLNET_PROTOCOL_TYPE_LOCAL时不需填写以下4个字段
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szIP;               // 码流源的设备IP，当接入协议为RTSP时为RTSP URL

            public int nPort;            // 码流源的设备端口，当接入协议为RTSP时无效

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szUser;           // 码流源的用户名

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_URL_LEN)]
            public string szPasswd;       // 码流源的密码

            public int nChannel;                 // 码流源的通道号,当接入协议为RTSP时无效
            public int nStreamType;           // 0自动-优先主码流；1辅码流1；2辅码流2； (暂不支持强制主码流）
            public int nPlayTime;                // 播放时间，秒，限定范围[5,1200]，超出[5,1200]范围将被自动设为10

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szReserve;		        //预留
        }

        //NVD视频源队列
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIDEO_SRC
        {
            public int nVideoNum;          // 数组videoInfo的有效元素数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_VIDEOLIST, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_VIDEO_INFO[] videoInfo;              //播放队列，n个码流源，当只有一个时就一直播放这一个

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] szRes;		        //预留
        }

        //NVD窗口
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_VIRTUAL_WINDOW
        {
            public int nWndIndex;          // 窗口号
            public int nPriority;              // 优先级
            public int nZOrder;              // 窗口Z序，值大的在上面，值一样后创建的窗口在上面
            public ZLNET_RECT stPosition;            // 窗口在屏幕中的位置
            public ZLNET_NVD_VIDEO_SRC videos;                 // 视频

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		        //预留
        }

        //NVD上墙场景
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_NVD_SCENE
        {
            public int nInterval;              // 本场景的播放时间，秒，限定范围[5,1200]，超出[5,1200]范围将被自动设为600,只有一个场景时忽略
            public int nWindowNum;     // stWindows有效数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_WINDOW, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_VIRTUAL_WINDOW[] stWindows;              // 窗口

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		        //预留
        }

        //NVD监视计划
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)] // 4字节对齐
        public struct ZLNET_NVD_PLAN
        {
            //计划类型 0：立即执行
            //1：一次性计划，nStartTime和nStopTime分别填开始和结束UTC时间 
            //2：每周执行，nStartTime和nStopTime分别填开始和结束相对于周日0秒的秒数
            //3：每日执行，nStartTime和nStopTime分别填开始和结束相对于当天0秒的秒数
            public int nPlanType;
            public Int64 nStartTime;
            public Int64 nStopTime;
            public int nSceneNum;           // 数组stScenes的有效元素数量

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = ZLNET_MAX_NVD_SCENE, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_NVD_SCENE[] stScenes;              // 场景

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
            public byte[] szRes;		        //预留
        }

        ////////////////////////////////人脸比对相关//////////////////////////////

        //人员分组
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_GROUP
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;      //组ID,只能获取,不能修改,新建时为空即可

            public int nPersonNum;     //组内人数,只能获取,不能修改,新建时填0即可

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;         //组名字

            public int nThreshold;     //报警触发阈值0-100

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRLEN_512)]
            public string szRemarks;      //备注

            public int bBindAllChannel;    //是否关联所有视频通道

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] bChannelBind;       //关联视频通道，bBindAllChannel==0时有效，例如bChannelBind[11]=1，表示关联11号通道

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;          //预留
        };

        //人脸图信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_FACEIMAGE
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szImageID;      //图片ID，程序内部使用，只能获取，不能修改

            public ZLNET_RECT stRect;         //人脸区域

            public int nAge;           //年龄（算法根据图片识别的大致年龄）
            public int nMoustache;     //胡子（算法根据图片识别的大致情况） 0未知 1无 2有 3有且是络腮胡 4有且是膏药胡
            public ZLNET_ENUM_COLOR nSkinColor;     //肤色（算法根据图片识别的大致情况）注意仅ZLNET_ENUM_COLOR中的部分值有效

            public ZLNET_TIME stTime;         //最后更新时间

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes;          //预留
        };

        //人员基础信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_PERSONINFO
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;     //姓名

            public int nSex;       //性别，0未知（未设置） 1男 2女
            public int nAge;       //年龄，0未知（未设置）

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDType;   //证件类型

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDNumber; //证件号,与szIDType配合使用

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NOTE_LEN)]
            public string szAddress;  //住址

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_MAX_STRLEN_512)]
            public string szRemarks;  //备注

            public int nThreshold; //报警触发阈值0-100，为0表示用group里的

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;      //预留
        };

        //人员信息（一个人员含数张人脸图）
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_PERSON
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;      //人员所在的组ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPersonID;     //人员ID,程序内部使用，只能获取，不能修改

            public ZLNET_FACE_PERSONINFO stInfo;     //人员基础信息

            public int nImageCount;    //人脸图数量,stImage有效个数

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8, ArraySubType = UnmanagedType.Struct)]
            public ZLNET_FACE_FACEIMAGE[] stImage;    //人脸图

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;          //预留
        };

        //获取人员信息条件参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_PERSON_COND
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;      //组ID，为空则不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szPersonID;      //人员ID，为空则不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;         //姓名，为空则不指定

            public int nSex;           //性别， 0不指定 1男 2女
            public int nAgeRangeLow;   //年龄范围，低值，0表示不指定
            public int nAgeRangeHigh;  //年龄范围，高值，0表示不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDType;       //证件类型，为空则不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDNumber;     //证件号，与szIDType配合使用，为空则不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NOTE_LEN)]
            public string szAddress;      //住址，为空则不指定

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
            public byte[] szRes;          //预留
        };

        //搜索人脸比对历史事件
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_SEARCH_COND
        {
            public int nResultType;    //结果类型，0比中事件 1陌生人事件(此时结果中没有人员信息) 2全部

            public int nChannel;       //通道号,-1表示不指定搜索通道
            public ZLNET_TIME stBegin;        //起始时间
            public ZLNET_TIME stEnd;          //结束时间

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szName;         //姓名，为空则不指定

            public int nSex;           //性别， 0不指定 1男 2女
            public int nAgeRangeLow;   //年龄范围，低值，-1表示不指定
            public int nAgeRangeHigh;  //年龄范围，高值，-1表示不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDType;       //证件类型，为空则不指定

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szIDNumber;     //证件号，与szIDType配合使用，为空则不指定

            public int nMoustache;     //算法检测到的胡子类型 0不指定 1无 2有 3有且是络腮胡 4有且是膏药胡
            public ZLNET_ENUM_COLOR nSkinColor;     //算法检测到的肤色，0不指定，注意仅ZLNET_ENUM_COLOR中的部分值有效
            public int nDetectAgeLow;      //算法检测到的年龄范围，低值，0表示不指定
            public int nDetectAgeHigh;     //算法检测到的年龄范围，高值，0表示不指定
            public int nDetectSex;     //算法检测到的性别，0不指定 1男 2女
            public int nGlassType;     //算法检测到的眼镜，0不指定 1无 2有

            public IntPtr pPicBuf;        //图片数据或路径
            public int nBufLen;        //数据长度

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
            public byte[] szRes2;         //预留
        };

        //人脸库导入导出参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_TRANSPORT_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;   //目标组ID，导入(上传)会覆盖组内原有数据，导出不会影响原有数据

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szPath;     //文件路径，导入(上传)时必填，导出时选填

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;      //预留
        };

        //人脸批量添加参数
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_FACE_BATCH_ADD_PARAM
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = ZLNET_IVS_MAX_NAME_LEN)]
            public string szGroupID;      //目标组ID

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szPath;         //文件夹路径

            public int nNameMode;      //人员命名模式：0按图片文件名 1按子文件夹名称
            public int nThreshold;     //报警触发阈值0-100，为0表示用group里的

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public byte[] szRes;          //预留
        };

        // 叠加类型
        public enum ZLNET_OVERLAY_TYPE
        {
            ZLNET_OVERLAY_INVALID = 0,                    //未知

            ZLNET_OVERLAY_CARD,                           //卡号

            ZLNET_OVERLAY_LINE = 100,                     //线（起始，100-199均是线）

            ZLNET_OVERLAY_REGION = 200,                   //框（起始，以下均是框）

            //报警区域
            ZLNET_OVERLAY_ALARM_FACENORMAL = 201,         //人脸捕获

            ZLNET_OVERLAY_ALARM_ATMPASTE = 210,           //ATM面板贴条
            ZLNET_OVERLAY_ALARM_ATMKEYBOARD,              //ATM面板键盘
            ZLNET_OVERLAY_ALARM_ATMCARDPORT,              //ATM面板插卡口
            ZLNET_OVERLAY_ALARM_ATMKEYMASK,               //ATM面板键盘罩
            ZLNET_OVERLAY_ALARM_ATMFACE,                  //ATM人脸捕获
            ZLNET_OVERLAY_ALARM_ATMFACEUNNOMAL,           //ATM异常人脸

            ZLNET_OVERLAY_ALARM_SSBOBJDROPPED = 251,      //自助厅物品遗留
            ZLNET_OVERLAY_ALARM_SSBLIEDOWN,               //自助厅人员倒地
            ZLNET_OVERLAY_ALARM_SSBFOLLOW,                //自助厅人员尾随
            ZLNET_OVERLAY_ALARM_SSBLINGER,                //自助厅人员徘徊
            ZLNET_OVERLAY_ALARM_SSBGATHERING,             //自助厅人员聚集
            ZLNET_OVERLAY_ALARM_SSBMULTIPEOPLE,           //自助厅人员疑似尾随
            ZLNET_OVERLAY_ALARM_SSBFIGHTING,              //自助银行行为过激
            ZLNET_OVERLAY_ALARM_SSBHIJACKING,             //自助银行劫持

            ZLNET_OVERLAY_ALARM_BZSMOVEINTO = 301,        //周界区域入侵
            ZLNET_OVERLAY_ALARM_BZSOBJECTMOVE,            //周界物品盗移
            ZLNET_OVERLAY_ALARM_BZSRETROGRADE,            //周界逆行
            ZLNET_OVERLAY_ALARM_BZSDENSITY,               //周界密度
            ZLNET_OVERLAY_ALARM_BZSOBJDROPPED,            //周界物品遗留
            ZLNET_OVERLAY_ALARM_BZSCROSSLINE,             //周界单线
            ZLNET_OVERLAY_ALARM_BZSCROSSFENCE,            //周界双线

            ZLNET_OVERLAY_ALARM_HDCTDENSITY = 351,        //人数统计密度
            ZLNET_OVERLAY_ALARM_HDCTCOUNTIN,              //人数正向跨线计数
            ZLNET_OVERLAY_ALARM_HDCTCOUNTOUT,             //人数反向跨线计数

            //跟踪区域
            ZLNET_OVERLAY_TRACE_BZSHUMAN = 400,           //周界人体
            ZLNET_OVERLAY_TRACE_FACE,                     //人脸
            ZLNET_OVERLAY_TRACE_HEAD,                     //人头
            ZLNET_OVERLAY_TRACE_ATMFACE,                  //ATM人脸
            ZLNET_OVERLAY_TRACE_SSBHUMAN,                 //自助厅人体
        };

        //叠加物体信息
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct ZLNET_OVERLAY_OBJECT
        {
            public ZLNET_OVERLAY_TYPE nType;          //不同的nType取union中的不同叠加信息
            public ZLNET_RGBA stColor;        //图形颜色
            public int nDirection;     //线的方向,仅对stLine有效，0-左到右，1-右到左，2-双向，3-无方向
            public int nTrackid;       //人脸跟踪ID,仅在nType==ZLNET_OVERLAY_ALARM_ATMFACE_NOMAL 下生效

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] szRes;          //预留

            //依据nType不同，szUnion取下面不同结构体
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
            public byte[] szUnion;        //预留

            //public ZLNET_LINE           stLine;         //线   ZLNET_OVERLAY_LINE <= nType < ZLNET_OVERLAY_REGION
            //public ZLNET_REGION         stRegion;       //区域 ZLNET_OVERLAY_REGION <= nType
        };

        #endregion
        ///////////////////////////////////////////////////
        //回调定义
        #region << Callback function prototype >>
        // 心跳回调
        public delegate int fZLIDVRHeatBeat(int loginHandle, string ip, string serial, IntPtr userData);

        // 断线回调
        public delegate void fZLDisConnect(int loginHandle, string pchDVRIP, int nDVRPort, IntPtr dwUser);

        // 网络连接恢复回调函数原形
        public delegate void fZLHaveReConnect(int lLoginID, string pchDVRIP, int nDVRPort, IntPtr dwUser);

        // 动态子连接断开回调函数原形
        public delegate void fZLSubDisConnect(ZLNET_INTERFACE_TYPE emInterfaceType, int bOnline, int lOperateHandle, int lLoginID, IntPtr dwUser);

        // 实时监视数据回调函数原形
        public delegate void fZLRealDataCallBack(int lRealHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr dwUser);

        // 实时监视数据回调函数原形--扩展
        public delegate void fZLRealDataCallBackEx(int lRealHandle, UInt32 dwDataType, IntPtr pBuf, UInt32 dwBufSize, IntPtr param, IntPtr dwUser);

        // 抓图回调函数原形
        public delegate void fZLSnapRev(int loginHandle, IntPtr pBuf, UInt32 RevLen, UInt32 EncodeType, UInt32 CmdSerial, IntPtr dwUser);

        // 报警回调
        public delegate int fF6AlarmUpCallback(int loginHandle, ref ZLNET_NEWF6_ALARM pAlarm, IntPtr userData);

        // 报警视频回调
        public delegate int fF6AlarmVideoCallback(int loginHandle, ref ZLNET_NEWF6_ALARM_VIDEO pAlarm, IntPtr userData);

        // 报警图片回调
        public delegate int fF6AlarmPictureCallback(int loginHandle, ref ZLNET_NEWF6_ALARM_PICTURE pAlarm, IntPtr userData);

        // 控制器信号回调
        public delegate void fZLTunnelCallBack(int lLoginID, int lTunnelID, IntPtr pBuf, UInt32 dwBufSize, IntPtr dwUser);

        // 语音对讲的音频数据回调
        public delegate void pfZLAudioDataCallBack(int lTalkHandle, IntPtr pDataBuf, UInt32 dwBufSize, Byte byAudioFlag, IntPtr dwUser);

        // 回放/下载进度回调
        public delegate void fZLDownLoadPosCallBack(int lPlayHandle, UInt32 dwTotalSize, UInt32 dwDownLoadSize, IntPtr dwUser);

        // 按时间回放进度回调函数原形
        public delegate void fZLTimeDownLoadPosCallBack(int lPlayHandle, UInt32 dwTotalSize, UInt32 dwDownLoadSize, int index, ZLNET_RECORDFILE_INFO recordfileinfo, IntPtr dwUser);

        // NVR搜索设备回调
        public delegate void fZLNVRSearch(int lLoginID, ref ZLNET_NVR_SEARCHINFO Info, IntPtr dwUserData);

        // 前端操作回调
        public delegate void fZLFrontEndOperateCallback(int lLoginID, ref ZLNET_FRONT_END_OPERATE_RESULT Info, IntPtr dwUserData);

        //UDX服务器数据回调
        public delegate void fOnUdxMessage(string pSerial, IntPtr pData, uint nLen, IntPtr dwUser);

        //物联网网关数据回调，nSensorID为传感器ID，pBuf为值数组，nValueNumber为元素个数，回调返回后内存即删除，外部使用需拷贝
        //pBuf对应结构体ZLNET_MEASURING_VALUE
        public delegate void fZLSensorDataCallback(int lLoginID, int nSensorID, IntPtr pBuf, int nValueNumber, IntPtr userData);

        // 屏幕叠加回调函数原形
        public delegate void fZLDrawCallBack(int lLoginID, int lPlayHandle, IntPtr hDC, IntPtr dwUser);

        // 回放数据回调函数原形，因为历史原因，请务必return 1, pBuffer视不同的dwDataType对应不同的参数，详见开发手册
        public delegate int fZLDataCallBack(int lPlayHandle, UInt32 dwDataType, IntPtr pBuffer, UInt32 dwBufSize, IntPtr dwUser);

        // 消息回调函数原形
        public delegate int fZLMessCallBack(int lCommand, int lLoginID, IntPtr pBuf, UInt32 dwBufLen, string pchDVRIP, int nDVRPort, IntPtr dwUser);

        // 侦听服务器回调函数原形
        // 反向注册的返回信息pParam指向一个ZLNET_EXTERN_INFO的结构体(SDK内部命名为AFK_EXTERN_INFO)
        public delegate int fZLServiceCallBack(int lHandle, string pIp, UInt16 wPort, int lCommand, IntPtr pParam, UInt32 dwParamLen, IntPtr dwUserData);

        // 透明串口回调函数原形
        //pBuffer对应字符数组
        public delegate void fZLTransComCallBack(int lLoginID, int lTransComChannel, IntPtr pBuffer, UInt32 dwBufSize, IntPtr dwUser);

        // 升级设备程序回调函数原形
        public delegate void fZLUpgradeCallBack(int lLoginID, int lUpgradechannel, int nTotalSize, int nSendSize, IntPtr dwUser);

        // GPS信息订阅回调
        public delegate void fZLGPSRev(int lLoginID, ZLNET_GPS_Info GpsInfo, IntPtr dwUserData);

        //ATM报警调试回调函数
        public delegate void fZLAlarmDebugRevCallback(int ILongID, int nATMIndex, ZLNET_IVA_ALARM_DEBUG Debug, IntPtr dwuser);

        //SSB报警调试回调函数
        public delegate void fZLAlarmDebugSSBRevCallback(int ILongID, int nSSBIndex, ZLNET_IVA_SSB_ARITH_DEBUG Debug, IntPtr dwuser);

        //BZS报警调试回调函数
        public delegate void fZLAlarmDebugBZSRevCallback(int ILongID, int nBZSIndex, ZLNET_IVA_BZS_ARITH_DEBUG Debug, IntPtr dwuser);
        public delegate void fZLAlarmDebugBZSRevCallbackEx(int ILongID, int nBZSIndex, ZLNET_IVA_BZS_ARITH_DEBUG_EX Debug, IntPtr dwuser);

        //人脸报警调试回调函数
        public delegate void fZLAlarmDebugFaceRevCallback(int ILongID, int nFaceIndex, ZLNET_IVA_FACE_ARITH_DEBUG Debug, IntPtr dwuser);

        //人数统计报警调试回调函数
        public delegate void fZLAlarmDebugStaffRevCallback(int ILongID, int nSCIndex, ZLNET_IVA_STAFF_ARITH_DEBUG Debug, IntPtr dwuser);

        //通用报警调试回调函数
        public delegate void fZLIVADebugInfoCallback(int ILongID, int nBZSIndex, ref ZLNET_IVA_DEBUG_INFO pInfo, IntPtr pReserved/*预留*/, IntPtr dwuser);

        //BZS跟踪轨迹信息
        public delegate void fZLBZSTrackInfoCallback(int ILongID, int nBZSIndex, ZLNET_IVA_BZS_TRACK_INFO Debug, IntPtr dwuser);

        // 文件传输回调
        public delegate void fZLTransFileCallBack(int lHandle, int nTransType, int nState, int nSendSize, int nTotalSize, IntPtr dwUser);

        //上传文件进度回调函数
        public delegate void fUploadFilePosCallBack(int lUploadHandle, UInt32 dwTotalSize, UInt32 dwCurSize, IntPtr dwUser);

        //下载文件回调函数
        public delegate void fDownLoadFileCallBack(int lDownHandle, IntPtr pBuffer, UInt32 dwBufSize, UInt32 dwTotalSize, UInt32 dwCurSize, IntPtr dwUser);

        //智能ATM报警日志、图片回调函数
        public delegate int fIdvrAlarmUpATMCallback(int loginHandle, ref ZLNET_IVA_ATM_ALARMINFO info, IntPtr userData);

        //智能人数统计信息、图片回调函数
        public delegate int fIdvrAlarmUpStaffCountCallback(int loginHandle, ref ZLNET_IVA_ALARMINFO_STAFFCOUNT info, IntPtr userData);

        //智能车牌信息上传回调函数
        public delegate int fIdvrAlarmUpPlateIdCallback(int loginHandle, ref ZLNET_IVA_PLATEID_ALARMINFO info, IntPtr userData);

        //智能SSB报警
        public delegate int fIdvrAlarmUpSSBCallback(int loginHandle, ref ZLNET_IVA_SSB_ALARMINFO info, IntPtr userData);

        //智能ATM/SSB混合型报警
        public delegate int fIdvrAlarmUpAtmSsbCallback(int loginHandle, ref ZLNET_IVA_ATM_SSB_ALARMINFO info, IntPtr userData);

        //智能BZS报警
        public delegate int fIdvrAlarmUpBZSCallback(int loginHandle, ref ZLNET_IVA_BZS_ALARMINFO info, IntPtr userData);

        //智能人脸报警
        public delegate int fIdvrAlarmUpFaceCallback(int loginHandle, ref ZLNET_IVA_FACE_ALARMINFO info, IntPtr userData);

        //智能车位报警
        public delegate int fIdvrAlarmUpParkingCallback(int loginHandle, ref ZLNET_IVA_PARKING_ALARMINFO info, IntPtr userData);

        //DVR、NVR智能报警
        public delegate int fDvrIvaAlarmCallback(int loginHandle, ref ZLNET_IVA_DVR_ALARMINFO info, IntPtr userData);

        //智能报警视频接收回调函数
        public delegate int fIdvrAlarmUpVideoCallback(int loginHandle, UInt32 id, ZLNET_TIME Time, ZLNET_IVA_ALARMVIDEOTYPE type, int chn, IntPtr videoBuf, UInt32 videoBufLen, IntPtr userData);

        //智能报警历史数据下载回调
        public delegate int fIdvrAlarmDownloadCallback(int loginHandle, UInt32 id, int channel, ZLNET_IVA_DOWNLOAD_TYPE type, ZLNET_IVA_DOWNLOAD_STATE state, IntPtr pBuf, UInt32 bufLen, IntPtr userData);

        //反向注册通知信息回调
        public delegate void fZLRevLink(int lLoginID, ref ZLNET_REV_LINK_RET Info, IntPtr dwUserData);

        // 消息回调函数原形
        public delegate int fP2PStateCallBack(string uuid, int nState, IntPtr dwUser);

        //新协议历史报警视频下载回调，dwTotal视频总大小，dwCur当前已经接收大小
        public delegate int fF6DownVideoCallback(int loginHandle, ref ZLNET_NEWF6_ALARM_VIDEO pAlarm, UInt32 dwTotal, UInt32 dwCur, IntPtr userData);

        //异步登录回调，注意根据pErr判断登录是否成功
        public delegate void fZLLoginCallBack(int lLoginID, ref ZLNET_LOGIN_ERROR pErr, ref ZLNET_DEVICEINFO_V30 pDeviceInfo, IntPtr dwUser);

        #endregion

        //接口
        #region << Interface >>
        // 初始化
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Init",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Init(fZLDisConnect cbDisConnect, IntPtr dwUser);

        // 初始化(增加穿网服务器)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_InitEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_InitEx(fZLDisConnect cbDisConnect, IntPtr dwUser, string server, int port = 0);

        // 设置心跳回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetHeartBeatCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetHeartBeatCallBack(fZLIDVRHeatBeat cbHeartBeat, IntPtr dwUser);

        // 清理
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Cleanup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_Cleanup();

        // 设置断线重连成功回调函数，设置后SDK内部断线自动重连
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetAutoReconnect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetAutoReconnect(fZLHaveReConnect cbAutoConnect, IntPtr dwUser);

        // 设置动态子连接断线回调函数，目前SVR设备的监视和回放是短连接的。
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSubconnCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetSubconnCallBack(fZLSubDisConnect cbSubDisConnect, IntPtr dwUser);

        // 返回函数执行失败代码
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetLastError",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 ZLNET_GetLastError();

        // 设置连接设备超时时间和尝试次数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetConnectTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetConnectTime(int nWaitTime, int nTryTimes);

        // 设置登陆网络环境
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetworkParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetNetworkParam(ref ZLNET_PARAM pNetParam);

        // 获取SDK的版本信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetSDKVersion",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern UInt32 ZLNET_GetSDKVersion();

        // 
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SDKSwitch",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SDKSwitch(ref ZLNET_SDK_SWITCH_PARAM pParam);

        // 登录设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Login",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Login(string pchDVRIP, UInt16 wDVRPort, string pchUserName, string pchPassword, ref ZLNET_DEVICEINFO lpDeviceInfo, ref int error);

        // 登录扩展接口
        //nSpecCap取值：0:TCP 2:反向链接,只建立主链接 3:组播 4:UDP 6:TCP单链接,设备不支持则自动全链接 7:SSL加密 8:反向链接,建立所有连接 
        //				9:VV穿网，多链接模式，pchDVRIP为uuid，端口忽略，穿网服务器地址必须在ZLNET_InitEx初始化 
        //				10:VV穿网单链接模式(暂不支持）
        //				11:蛮牛穿网单链接模式，pCapParam为uuid，端口忽略，需先调用ZLNET_SetUdxServer
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_LoginEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_LoginEx(string pchDVRIP, UInt16 wDVRPort, string pchUserName, string pchPassword, int nSpecCap, IntPtr pCapParam, ref ZLNET_DEVICEINFO info, ref int error);

        // 登录扩展V30
        // 输入参数 : pParam      - 登录参数，不可为NULL
        //            nTimeout    - 超时时间，毫秒，为0或负数时内部自动设为5000
        // 输出参数 ：pError      - 失败时返回错误原因，可为NULL
        //            pDeviceInfo - 成功时返回设备基本信息，可为NULL
        // 返回值 ：  LONG        - 0表示失败,大于0成功,不会有负值返回
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Login_V30",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Login_V30(ref ZLNET_LOGIN_PARAM pParam, ref ZLNET_LOGIN_ERROR pError, ref ZLNET_DEVICEINFO_V30 pDeviceInfo, int nTimeout = 5000);

        // 登出
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Logout",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Logout(int lLoginID);

        // 
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetIPByDDNSID",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetIPByDDNSID(string szServerIp, int nServerPort, string ddnsID, string szRetIP, ref IntPtr pHttpPort, ref IntPtr pTcpPort, ref IntPtr pErrorCode);

        // 通过设备名字或者设备序列号向DDNS服务器查询设备IP
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDVRIPByResolveSvr",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_GetDVRIPByResolveSvr(string pchDVRIP, UInt16 wDVRPort, IntPtr sDVRName, UInt16 wDVRNameLen, ref byte sDVRSerialNumber, UInt16 wDVRSerialLen, ref IntPtr sGetIP);

        // 设置蛮牛穿网服务器IP
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetUdxServer",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetUdxServer(string pIp, UInt16 wPort, int nRes = 0);

        // 
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetUdxDeviceList",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetUdxDeviceList(ref ZLNET_UDX_DEVLIST pList, int timeout = 5000);

        // 
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_UdxGetDevState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_UdxGetDevState(string pSerial, int timeout = 5000);

        // 蛮牛特殊通信接口，项目专用
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_UdxSetMsgCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_UdxSetMsgCallback(fOnUdxMessage cb, IntPtr dwUser);

        // 蛮牛特殊通信接口，项目专用
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_UdxSendMsg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_UdxSendMsg(string pSerial, IntPtr pData, uint nLen);

        // 开始实时监视
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RealPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RealPlay(int lLoginID, int nChannelID, IntPtr hWnd);

        // 开始实时监视--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RealPlayEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RealPlayEx(int lLoginID, int nChannelID, IntPtr hWnd, ZLNET_REALPLAYTYPE rType = ZLNET_REALPLAYTYPE.ZLNET_RType_Realplay);

        // 多画面实时预览
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_MultiPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_MultiPlay(int lLoginID, IntPtr hWnd);

        // 停止多画面实时预览
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopMultiPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopMultiPlay(int lMultiHandle);

        // 抓图；hPlayHandle为监视或回放句柄
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CapturePicture",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CapturePicture(int hPlayHandle, string pchPicFileName);

        // 设置实时监视数据回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetRealDataCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetRealDataCallBack(int lRealHandle, fZLRealDataCallBack cbRealData, IntPtr dwUser);

        // 设置实时视频回调--扩展, dwFlag为ZLNET_MEDIA_TYPE_FLAG的组合
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetRealDataCallBackEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetRealDataCallBackEx(int lLoginID, fZLRealDataCallBackEx cbRealData, IntPtr dwUser, UInt32 dwFlag);

        // 设置图象流畅性
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AdjustFluency",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_AdjustFluency(int lRealHandle, int nLevel);

        // 保存数据为文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SaveRealData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SaveRealData(int nPlayID, string path);

        // 结束保存数据为文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopSaveRealData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopSaveRealData(int nPlayID);

        // 设置图像属性
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ZLSetVideoEffect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ZLSetVideoEffect(int lPlayHandle, byte nBrightness, byte nContrast, byte nHue, byte nSaturation);

        // 获取图像属性
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ZLGetVideoEffect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ZLGetVideoEffect(int lPlayHandle, ref byte nBrightness, ref byte nContrast, ref byte nHue, ref byte nSaturation);

        // 设置屏幕叠加回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RigisterDrawFun",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_RigisterDrawFun(fZLDrawCallBack cbDraw, IntPtr dwUser);

        // 打开声音
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_OpenSound",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_OpenSound(int nPlayID);

        // 设置音量，nVolume范围：0~100
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetVolume",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetVolume(int nPlayID, int nVolume);

        // 关闭声音
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CloseSound",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CloseSound();

        // 停止实时预览
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopRealPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopRealPlay(int lRealHandle);

        // 停止实时预览--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopRealPlayEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopRealPlayEx(int lPlayHandle);

        // 通用云台控制
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PTZControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PTZControl(int lLoginID, int nChannelID, UInt32 dwPTZCommand, UInt32 dwStep, int dwStop);

        // 智领云台控制
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ZLPTZControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ZLPTZControl(int lLoginID, int nChannelID, UInt32 dwPTZCommand, byte param1, byte param2, byte param3, int dwStop);

        // 智领云台控制扩展接口，支持三维快速定位
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ZLPTZControlEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ZLPTZControlEx(int lLoginID, int nChannelID, UInt32 dwPTZCommand, int lParam1, int lParam2, int lParam3, int dwStop);

        // 查询时间段内是否有录像文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryRecordTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryRecordTime(int lLoginID, int nChannelId, int nRecordFileType, ref ZLNET_TIME tmStart, ref ZLNET_TIME tmEnd, string pchCardid, ref int bResult, int waittime = 1000);

        // 查询时间段内的所有录像文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryRecordFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryRecordFile(int lLoginID, int nChannelId, int nRecordFileType,
            ref ZLNET_TIME tmStart, ref ZLNET_TIME tmEnd, string pchCardid, IntPtr nriFileinfo,
            int maxlen, ref int filecount, int waittime = 1000, int bTime = 0);

        // 查询最早录像时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryFurthestRecordTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryFurthestRecordTime(int lLoginID, int nRecordFileType, string pchCardid, ref ZLNET_FURTHEST_RECORD_TIME pFurthrestTime, int nWaitTime);

        // 开始查找录像文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FindFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FindFile(int lLoginID, int nChannelId, int nRecordFileType, string cardid, ref ZLNET_TIME time_start, ref ZLNET_TIME time_end, int bTime, int waittime);

        // 查找录像文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FindNextFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FindNextFile(int lFindHandle, ref ZLNET_RECORDFILE_INFO lpFindData);

        // 结束录像文件查找
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FindClose",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FindClose(int lFindHandle);

        // 查录像文件扩展（推荐使用此函数查录像）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryRecordFileEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体ZLNET_RECORDFILE_INFO
        public static extern int ZLNET_QueryRecordFileEx(int lLoginID, ref ZLNET_QUERY_RECORD_PARAM param, IntPtr pBuf, int nBufLen, ref int pRetCount, int waittime = 3000);

        // 按文件方式回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByRecordFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByRecordFile(int lLoginID, ref ZLNET_RECORDFILE_INFO lpRecordFile, IntPtr hWnd,
            fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData);

        // 按文件方式回放--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByRecordFileEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByRecordFileEx(int lLoginID, ref ZLNET_RECORDFILE_INFO lpRecordFile, IntPtr hWnd, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwPosUser, fZLDataCallBack fDownLoadDataCallBack, IntPtr dwDataUser);

        // 按文件方式回放--扩展版本3
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByRecordFileV3",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByRecordFileV3(int lLoginID, ref ZLNET_RECORDFILE_INFO lpRecordFile, IntPtr hWnd, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwPosUser, fZLDataCallBack fDownLoadDataCallBack, ref ZLNET_RECORDFILE_EXTERN lpRecordFileExtern, IntPtr dwDataUser);

        // 按时间方式回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByTime(int lLoginID, int nChannelID, ref ZLNET_TIME lpStartTime,
            ref ZLNET_TIME lpStopTime, IntPtr hWnd, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwPosUser);

        // 按时间方式回放--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByTimeEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByTimeEx(int lLoginID, int nChannelID, ref ZLNET_TIME lpStartTime, ref ZLNET_TIME lpStopTime, IntPtr hWnd, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwPosUser, fZLDataCallBack fDownLoadDataCallBack, IntPtr dwDataUser);

        // 按时间方式回放--V3
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PlayBackByTimeV3",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PlayBackByTimeV3(int lLoginID, ref ZLNET_PLAY_BY_TIME_PARAM param, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwPosUser, fZLDataCallBack fDownLoadDataCallBack, IntPtr dwDataUser);

        // 定位录像回放起始点
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SeekPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SeekPlayBack(int lPlayHandle, uint offsettime, uint offsetbyte);

        // 暂停或恢复录像回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_PausePlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_PausePlayBack(int lPlayHandle, int bPause);

        // 快进录像回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FastPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FastPlayBack(int lPlayHandle);

        // 慢进录像回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SlowPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SlowPlayBack(int lPlayHandle);

        // 步进录像回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StepPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StepPlayBack(int lPlayHandle, int bStop);

        // 设置回放帧速
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetFramePlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetFramePlayBack(int lPlayHandle, int framerate);

        // 获取回放帧速
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Logout",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetFramePlayBack(int lPlayHandle, ref int fileframerate, ref int playframerate);

        // 恢复正常回放速度
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NormalPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NormalPlayBack(int lPlayHandle);

        // 获取回放OSD时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPlayBackOsdTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPlayBackOsdTime(int lPlayHandle, ref ZLNET_TIME lpOsdTime, ref ZLNET_TIME lpStartTime, ref ZLNET_TIME lpEndTime);

        // 停止录像回放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopPlayBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopPlayBack(int lPlayHandle);

        // 下载录像文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DownloadByRecordFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DownloadByRecordFile(int lLoginID, ref ZLNET_RECORDFILE_INFO lpRecordFile, string sSavedFileName, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData);

        // 下载录像文件 扩展版本-增加文件偏移量
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DownloadByRecordFileEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DownloadByRecordFileEx(int lLoginID, ref ZLNET_RECORDFILE_INFO lpRecordFile, string sSavedFileName, fZLDownLoadPosCallBack cbDownLoadPos, ref ZLNET_RECORDFILE_EXTERN lpRecordFileExtern, IntPtr dwUserData);

        // 设置下载文件模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDownloadFileMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDownloadFileMode(int lLoginID, ZLNET_DOWNLOADFILE_MODE eMode);

        // 通过时间下载录像
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DownloadByTimeEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DownloadByTimeEx(int lLoginID, ref ZLNET_DOWN_BY_TIME_PARAM lpParam,
            fZLTimeDownLoadPosCallBack cbTimeDownLoadPos, IntPtr dwUserData);

        // 查询录像下载进度
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDownloadPos",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDownloadPos(int lFileHandle, ref int nTotalSize, ref int nDownLoadSize);

        // 停止录像下载
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopDownload",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopDownload(int lFileHandle);

        // 设置报警回调函数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDVRMessCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDVRMessCallBack(fZLMessCallBack cbMessage, IntPtr dwUser);

        // 设置报警回调扩展函数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDVRMessCallBackEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDVRMessCallBackEx(int ID, fZLMessCallBack cbMessage, IntPtr dwUser, int bAdd = 1);

        // 向设备订阅报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartListen",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartListen(int lLoginID);

        // 向设备订阅报警--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartListenEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartListenEx(int lLoginID);

        // 报警信息控制，在ZLNET_StartListenEx之前调用有效
        // HIWORD(dwInfoMask)：0全部订阅 1仅报警信息 2信息+图片 3信息+视频	注意：目前设备可能不支持
        // LOWORD(dwInfoMask) : 1报警视频主码流 2报警视频辅码流
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribleAlarmInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribleAlarmInfo(int lLoginID, UInt32 dwInfoMask);

        // 停止订阅报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopListen",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopListen(int lLoginID);

        // 主动注册功能，启动服务；nTimeout参数已无效
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ListenServer",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ListenServer(string ip, UInt16 port, int nTimeout, fZLServiceCallBack cbListen, IntPtr dwUserData);

        // 停止服务
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopListenServer",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopListenServer(int lServerHandle);

        // 响应设备的注册请求
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ResponseDevReg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ResponseDevReg(string devSerial, string ip, UInt16 port, int bAccept);

        // 报警上传功能，启动服务；dwTimeOut参数已无效
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartService",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartService(UInt16 wPort, string pIp, fZLServiceCallBack pfscb, UInt32 dwTimeOut, IntPtr dwUserData);

        // 停止服务
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopService",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopService(int lHandle);

        // 设置语音对讲模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDeviceMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDeviceMode(int lLoginID, ZLNET_USEDEV_MODE emType, IntPtr pValue);

        // 打开语音对讲
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartTalkEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartTalkEx(int lLoginID, pfZLAudioDataCallBack pfcb, IntPtr dwUser);

        // 打开语音对讲，支持通道对讲
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartTalkV3",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartTalkV3(int lLoginID, int nChannel, pfZLAudioDataCallBack pfcb, IntPtr dwUser);

        // 开始PC端录音
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RecordStart",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RecordStart();

        // 结束PC端录音
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RecordStop",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RecordStop();

        // 发送语音数据到设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_TalkSendData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_TalkSendData(int lTalkHandle, IntPtr pSendBuf, UInt32 dwBufSize);

        // 解码音频数据
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AudioDec",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_AudioDec(IntPtr pAudioDataBuf, UInt32 dwBufSize);

        // 设置语音对讲的音量,wVolume范围：0~100
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetAudioClientVolume",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetAudioClientVolume(int lTalkHandle, UInt32 wVolume);

        // 停止语音对讲
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopTalkEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopTalkEx(int lTalkHandle);

        // 添加设备到广播组
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AudioBroadcastAddDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_AudioBroadcastAddDev(int lLoginID);

        // 从广播组中删除设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AudioBroadcastDelDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_AudioBroadcastDelDev(int lLoginID);

        // 音频编码--数据编码
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AudioEncode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_AudioEncode(int lTalkHandle, IntPtr lpInBuf, ref UInt32 lpInLen, IntPtr lpOutBuf, ref UInt32 lpOutLen);

        // 音频编码--音频数据->智领格式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_AudioFormatZL",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_AudioFormatZL(IntPtr lpInBuf, ref UInt32 lpInLen, IntPtr lpOutBuf, ref UInt32 lpOutLen, ZLNET_AUDIO_FORMAT aft);

        // 音频编码--完成退出
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ReleaseAudioEncode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ReleaseAudioEncode();

        // 查询设备日志
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryLog",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryLog(int lLoginID, IntPtr pLogBuffer, int maxlen, ref int nLogBufferlen, int waittime = 3000);

        // 查询设备日志，以分页方式查询
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryDeviceLog",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryDeviceLog(int lLoginID, ref ZLNET_QUERY_DEVICE_LOG_PARAM pQueryParam, IntPtr pLogBuffer, int nLogBufferLen, ref int pRecLogNum, int waittime = 3000);

        // 查道通道录像状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryRecordState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryRecordState(int lLoginID, IntPtr pRSBuffer, int maxlen, ref int nRSBufferlen, int waittime = 1000);

        // 查询设备状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryDevState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryDevState(int lLoginID, int nType, IntPtr pBuf,
            int nBufLen, ref int pRetLen, int waittime = 1000);

        // 查询系统能力信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySystemInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QuerySystemInfo(int lLoginID, int nSystemType, IntPtr pSysInfoBuffer, int maxlen, ref int nSysInfolen, int waittime = 1000);

        // 获取通道码流
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetStatiscFlux",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetStatiscFlux(int lLoginID, int lPlayHandle);

        // 获取云台信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPtzOptAttr",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPtzOptAttr(int lLoginID, UInt32 dwProtocolIndex, IntPtr lpOutBuffer, UInt32 dwBufLen, ref UInt32 lpBytesReturned, int waittime = 500);

        // 重启设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RebootDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RebootDev(int lLoginID);

        // 关闭设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ShutDownDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ShutDownDev(int lLoginID);

        //设备控制
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ControlDevice",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ControlDevice(int lLoginID, ZLNET_CtrlType type, IntPtr param, int waittime = 1000);

        //设置通道录像状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetupRecordState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetupRecordState(int lLoginID, IntPtr pRSBuffer, int nRSBufferlen);

        // 查询IO状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryIOControlState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryIOControlState(int lLoginID, ZLNET_IOTYPE emType, IntPtr pState, int maxlen, ref int nIOCount, int waittime = 1000);

        // IO控制
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IOControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IOControl(int lLoginID, ZLNET_IOTYPE emType, IntPtr pState, int maxlen);

        // 强制I帧；nChannelID：通道号，nSubChannel：码流类型(0：主，1：子码流1)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_MakeKeyFrame",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_MakeKeyFrame(int lLoginID, int nChannelID, int nSubChannel = 0);

        // 刷新动态数据(定制化功能）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_RefreshInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_RefreshInfo(int lLoginID, int nChannelID, ZLNET_REFRESH_TYPE nType, int nRes/*预留*/, IntPtr pData/*nType不同有不同的结构*/, int nDataLen, int waittime = 2000);

        // 查询用户信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryUserInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryUserInfo(int lLoginID, ref ZLNET_USER_MANAGE_INFO info, int waittime = 1000);

        // 查询用户信息--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryUserInfoEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryUserInfoEx(int lLoginID, ref ZLNET_USER_MANAGE_INFO_EX info, int waittime = 1000);

        // 操作设备用户
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_OperateUserInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_OperateUserInfo(int lLoginID, int nOperateType, IntPtr opParam, IntPtr subParam, int waittime = 1000);

        // 操作设备用户--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_OperateUserInfoEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_OperateUserInfoEx(int lLoginID, int nOperateType, IntPtr opParam, IntPtr subParam, int waittime = 1000);

        // 创建透明串口通道
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CreateTransComChannel",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CreateTransComChannel(int lLoginID, int TransComType, uint baudrate, uint databits, uint stopbits, uint parity, fZLTransComCallBack cbTransCom, IntPtr dwUser);

        // 创建透明串口通道扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CreateTransComChannelV30",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CreateTransComChannelV30(int lLoginID, ref ZLNET_CreateTransComParams pParams, fZLTransComCallBack cbTransCom, IntPtr dwUser);

        // 透明串口发送数据
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SendTransComData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SendTransComData(int lTransComChannel, byte[] pBuffer, UInt32 dwBufSize);

        // 释放通明串口通道
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DestroyTransComChannel",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DestroyTransComChannel(int lTransComChannel);

        // 查询透明串口状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryTransComParams",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryTransComParams(int lLoginID, int TransComType, ref ZLNET_COMM_STATE pCommState, int nWaitTime = 500);

        // 开始升级设备程序
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartUpgrade",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartUpgrade(int lLoginID, string pchFileName, fZLUpgradeCallBack cbUpgrade, IntPtr dwUser);

        // 开始升级设备程序--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StartUpgradeEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StartUpgradeEx(int lLoginID, ZLNET_UPGRADE_TYPE emType, string pchFileName, fZLUpgradeCallBack cbUpgrade, IntPtr dwUser);

        // 发送数据
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SendUpgrade",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SendUpgrade(int lUpgradeID);

        // 结束升级设备程序
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopUpgrade",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopUpgrade(int lUpgradeID);

        // 查询配置信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDevConfig(int lLoginID, UInt32 dwCommand, int lChannel,
            IntPtr lpOutBuffer, UInt32 dwOutBufferSize, ref UInt32 lpBytesReturned, int waittime = 1500);

        // 设置配置信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDevConfig(int lLoginID, UInt32 dwCommand, int lChannel,
            IntPtr lpInBuffer, UInt32 dwInBufferSize, int waittime = 1500);

        // 查询配置信息扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDevConfigEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDevConfigEx(int lLoginID, UInt32 dwCommand, UInt32 dwSubCommand,
            int lChannel, IntPtr lpOutBuffer, UInt32 dwOutBufferSize, ref UInt32 lpBytesReturned, int waittime = 1500);

        // 设置配置信息扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDevConfigEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDevConfigEx(int lLoginID, UInt32 dwCommand, UInt32 dwSubCommand,
            int lChannel, IntPtr lpInBuffer, UInt32 dwInBufferSize, int waittime = 1500);

        // 新配置接口，查询配置信息(Json格式)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNewDevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNewDevConfig(int lLoginID, string szCommand, IntPtr szOutBuffer, UInt32 dwOutBufferSize, ref int error, int waittime = 1500);

        // 新配置接口，设置配置信息(Json格式)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNewDevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNewDevConfig(int lLoginID, IntPtr szInBuffer, UInt32 dwInBufferSize, ref int error, ref int restart, int waittime = 1500);

        // 查询设备通道名称
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryChannelName",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryChannelName(int lLoginID, IntPtr pChannelName, int maxlen, ref int nChannelCount, int waittime = 1000);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryChannelNameEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryChannelNameEx(int lLoginID, ref ZLNET_CHANNEL_NAME_CFG pCfg, int waittime = 3000);

        // 设置设备通道名称
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetupChannelName",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetupChannelName(int lLoginID, IntPtr pbuf, int nbuflen);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetupChannelNameEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetupChannelNameEx(int lLoginID, ref ZLNET_CHANNEL_NAME_CFG pCfg, int waittime = 3000);

        // 设置设备通道字符叠加
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetupChannelOsdString",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //struOsdString对应结构体ZLNET_CHANNEL_OSDSTRING
        public static extern int ZLNET_SetupChannelOsdString(int lLoginID, int nChannelNo, IntPtr struOsdString, int nbuflen);

        // 查询设备当前时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryDeviceTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryDeviceTime(int lLoginID, ref ZLNET_TIME pDeviceTime, int waittime = 1000);

        // 设置设备当前时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetupDeviceTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetupDeviceTime(int lLoginID, ref ZLNET_TIME pDeviceTime);

        // 设置设备限制码流
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetMaxFlux",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetMaxFlux(int lLoginID, UInt16 wFlux);

        //导入配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ImportConfigFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ImportConfigFile(int lLoginID, ZLNET_CONFIG_FILE_TYPE emConfigFileType,
            string szFileName, fZLDownLoadPosCallBack cbUploadPos, IntPtr dwUserData, UInt32 param = 0);

        //停止导入配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopImportCfgFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopImportCfgFile(int lImportHandle);

        //导出配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ExportConfigFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ExportConfigFile(int lLoginID, ZLNET_CONFIG_FILE_TYPE emConfigFileType,
            string szSavedFilePath, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData);

        //停止导出配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopExportCfgFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopExportCfgFile(int lExportHandle);

        // 打开透传管道, 返回管道句柄lTunnelID
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_OpenTunnel",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_OpenTunnel(int lLoginID, int nType, fZLTunnelCallBack cbData, IntPtr dwUser);

        // 透传管道发数据
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_TunnelSend",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_TunnelSend(int lTunnelID, IntPtr pBuf, int nBufLen);

        // 关闭透传管道
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CloseTunnel",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CloseTunnel(int lTunnelID);

        // 搜索局域网内IPC、NVS等设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SearchDevices",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SearchDevices(IntPtr szBuf, int nBufLen, ref int pRetLen, UInt32 dwSearchTime);

        // 搜索局域网内IPC、NVS、IVA等设备扩展接口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SearchDevicesEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SearchDevicesEx(IntPtr szBuf, int nBufLen, ref int pRetLen, UInt32 dwSearchTime, ZLNET_SEARCH_MODE eMode);

        // 跨网段修改设备信息(对应ZlNET_OVERNET_COMMAND命令，进行登录 查询 修改操作，登录后只可可修改一次)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDvrConfigOverNet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDvrConfigOverNet(ZlNET_OVERNET_COMMAND dwCommand, IntPtr lpInData, int nInDataLen, IntPtr lpOutData, int nOutDataLen, ref int nError);

        // 平台接入接口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPlatFormInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPlatFormInfo(int lLoginID, UInt32 dwCommand, int nSubCommand, int nParam, IntPtr lpOutBuffer, UInt32 dwOutBufferSize, ref UInt32 lpBytesReturned, int waittime = 500);

        // 平台接入接口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPlatFormInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPlatFormInfo(int lLoginID, UInt32 dwCommand, int nSubCommand, int nParam, IntPtr lpInBuffer, UInt32 dwInBufferSize, int waittime = 500);

        // 设置抓图回调函数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSnapRevCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetSnapRevCallBack(fZLSnapRev OnSnapRevMessage, IntPtr dwUser);

        // 抓图请求,要先调用ZLNET_SetSnapRevCallBack
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SnapPicture",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SnapPicture(int lLoginID, ZLNET_SNAP_PARAMS par);

        // 设置GPS订阅回调函数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSubcribeGPSCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetSubcribeGPSCallBack(fZLGPSRev OnGPSMessage, IntPtr dwUser);

        // GPS信息订阅
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SubcribeGPS",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SubcribeGPS(int lLoginID, int bStart, int KeepTime, int InterTime);

        //////////////////////////////////////////////////////////////////////////
        //以下接口逐渐废弃，请使用ZLNET_IVA_SubcribeDebugInfo和ZLNET_IVA_SetDebugInfoCallBack
        //将于2018年6月删除以下接口
        // 订阅智能报警调试
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeAlarmDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeAlarmDebug(int lLoginID, int nATMIndex, int bStart);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeAlarmSSBDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeAlarmSSBDebug(int lLoginID, int nSSBIndex, int bStart);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeAlarmBZSDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeAlarmBZSDebug(int lLoginID, int nBZSIndex, int bStart);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeAlarmFaceDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeAlarmFaceDebug(int lLoginID, int nFaceIndex, int bStart);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeAlarmStaffDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeAlarmStaffDebug(int lLoginID, int nSCIndex, int bStart);

        // 设置智能报警调试回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmDebugCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmDebugCallBack(fZLAlarmDebugRevCallback cbDebugRec, IntPtr dwUser);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmSSBDebugCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmSSBDebugCallBack(fZLAlarmDebugSSBRevCallback cbDebugRec, IntPtr dwUser);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmBZSDebugCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmBZSDebugCallBack(fZLAlarmDebugBZSRevCallback cbDebugRec, IntPtr dwUser);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmBZSDebugCallBackEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmBZSDebugCallBackEx(fZLAlarmDebugBZSRevCallbackEx cbDebugRec, IntPtr dwUser);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmFaceDebugCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmFaceDebugCallBack(fZLAlarmDebugFaceRevCallback cbDebugRec, IntPtr dwUser);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSubcribeAlarmStaffDebugCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSubcribeAlarmStaffDebugCallBack(fZLAlarmDebugStaffRevCallback cbDebugRec, IntPtr dwUser);

        // 轨迹跟踪回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSTrackInfoCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetBZSTrackInfoCallBack(int lLoginID, fZLBZSTrackInfoCallback cbTrackInfo, IntPtr dwUser);

        //以上接口逐渐废弃，请使用ZLNET_IVA_SubcribeDebugInfo和ZLNET_IVA_SetDebugInfoCallBack
        //////////////////////////////////////////////////////////////////////////

        //订阅智能报警调试
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SubcribeDebugInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SubcribeDebugInfo(int lLoginID, int nChannel, int bStart);

        //设置智能报警调试回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetDebugInfoCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetDebugInfoCallBack(fZLIVADebugInfoCallback cb, IntPtr dwUser);

        // 获取解码器能力
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_GetCapbility",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_GetCapbility(int lLoginID, ref ZLNET_DECODER_CAP pCap);

        // 获取显示屏分辨率
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_GetResolution",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_GetResolution(int lLoginID, int lScreen, ref ZLNET_RESOLUTION pBuf);

        // 设置解码器分割模式，lScreen为屏幕号
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_SetMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_SetMode(int lLoginID, int lScreen, ref ZLNET_DECODER_MODE pMode);

        // 获取解码器分割模式，lScreen为屏幕号
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_GetMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_GetMode(int lLoginID, int lScreen, ref ZLNET_DECODER_MODE pMode);

        // 单窗口解码上墙，lScreen为屏幕号
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_StartPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_StartPlay(int lLoginID, int lScreen, ref ZLNET_DEC_VIDEO_WINDOW pWnd);

        // 多窗口解码上墙, lScreen为屏号
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_StartMultiPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_StartMultiPlay(int lLoginID, int lScreen, ref ZLNET_DEC_VIDEO_SCREEN pScreen);

        // 停止解码器，lScreen为屏幕号, -1代表所有屏幕，lWnd为窗口号，-1代表所有窗口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_StopPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_StopPlay(int lLoginID, int lScreen, int lWnd);

        // 获取上墙状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DEC_GetPlayState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DEC_GetPlayState(int lLoginID, int lScreen, int lWnd, ref ZLNET_DEC_VIDEO_WINDOW pWnd);

        // 查询设备日志--扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryLogEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryLogEx(int lLoginID, ZLNET_LOG_QUERY_TYPE logType, IntPtr pLogBuffer,
            int maxlen, ref int nLogBufferlen, IntPtr reserved, int waittime = 3000);

        // 文件上传接口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FileTransmit",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FileTransmit(int lLoginID, int nTransType, IntPtr szInBuf, int nInBufLen, fZLTransFileCallBack cbTransFile, IntPtr dwUserData, int waittime);

        // 上传音频文件(WAV格式)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_UploadAudio",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_UploadAudio(int lLoginID, int nAlarmType, int nSubType, IntPtr szPath, int nPathLen, fUploadFilePosCallBack cbUploadPos, IntPtr dwUserData);

        // 停止上传
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopUploadAudio",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopUploadAudio(int lUploadHandle);

        // 获取NVR通道信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_GetChannelInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_GetChannelInfo(int lLoginID, ref ZLNET_NVR_CHANNEL NetConfig);

        // 获取网络当前通道个数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_GetCurNetChannelInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_GetCurNetChannelInfo(int lLoginID, ref ZLNET_NVR_CHANNEL_INFO_EX curChannelInfo);

        // 设置NVR网络通道配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_SetNetConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_SetNetConfig(int lLoginID, ref ZLNET_NVR_CONFIG_NET NetConfig);

        // 获取NVR网络通道配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_GetNetConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_GetNetConfig(int lLoginID, ref ZLNET_NVR_CONFIG_NET NetConfig);

        // 获取网络通道云台协议
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_GetNetPtzParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_GetNetPtzParam(int lLoginID, ref ZLNET_NVR_NET_PTZ_PARAM NetPtzParam, int nChannel);

        //设置设备搜索回调函数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_SetSearchCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_NVR_SetSearchCallBack(fZLNVRSearch cbSearchMessage, IntPtr dwUser);

        //设备搜索命令
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVR_Search",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVR_Search(int lLoginID, int bStart, int protocol);

        // 主动注册IP服务地址
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_RegistDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_RegistDev(int loginHandle, ref ZLNET_IVA_REGISTIP stuHost);

        // 获取已注册IP地址列表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetRegistDevList",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetRegistDevList(int loginHandle, ref ZLNET_IVA_REGISTIP_LIST hostList);

        // 设置已注册IP地址列表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetRegistDevList",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetRegistDevList(int loginHandle, ref ZLNET_IVA_REGISTIP_LIST delHostList);

        // 设置日志存储模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetLogMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetLogMode(int lLoginID, ZLNET_IVA_LOG_MODE logMode);

        // 获取日志存储模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetLogMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetLogMode(int lLoginID, ref ZLNET_IVA_LOG_MODE logMode);

        // 获取ATM/SSB混合型设备模式，建议使用ZLNET_IVA_GetDevChannelMode
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAtmSsbMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAtmSsbMode(int lLoginID, ref ZLNET_IVA_ATM_SSB_MODE mode);

        // 设置ATM/SSB混合型设备模式，建议使用ZLNET_IVA_SetDevChannelMode
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAtmSsbMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAtmSsbMode(int lLoginID, ZLNET_IVA_ATM_SSB_MODE mode);

        // 获取设备通道混合模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetDevChannelMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetDevChannelMode(int lLoginID, ref ZLNET_IVA_DEV_CHANNEL_MODE_SET ChannelMode);

        // 设置设备通道混合模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetDevChannelMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetDevChannelMode(int lLoginID, ref ZLNET_IVA_DEV_CHANNEL_MODE_SET pChannelMode);

        // 获取报警录像配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAlarmRecord",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAlarmRecord(int lLoginID, ref ZLNET_IVA_ALARM_RECORD config);

        // 设置报警录像配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAlarmRecord",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAlarmRecord(int lLoginID, ZLNET_IVA_ALARM_RECORD config);

        // 设置视频通道模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetVideoMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetVideoMode(int lLoginID, ref ZLNET_IVA_CHANNEL_CONFIG cfg);

        // 获取视频通道模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetVideoMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetVideoMode(int lLoginID, ref ZLNET_IVA_CHANNEL_CONFIG chnCfg);

        // 设置报警联动
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAlarmAssc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAlarmAssc(int lLoginID, int nAlarmTpye, ref ZLNET_IVA_ALARM_ASSCONFIG alarmCfg, int emIndex = 0);

        // 获取报警联动
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAlarmAssc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAlarmAssc(int lLoginID, int nAlarmType, ref ZLNET_IVA_ALARM_ASSCONFIG alarmCfg, int emIndex = 0);

        // 设置报警工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetWorkSheet(int lLoginID, int nAlarmType, ref ZLNET_IVA_WEEK_SECTION alarmWorksheet, int emIndex = 0);

        // 获取报警工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetWorkSheet(int lLoginID, int alarmType, ref ZLNET_IVA_WEEK_SECTION alarmWorksheet, int emIndex);

        // 设置外部报警联动
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetGpiAssc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetGpiAssc(int lLoginID, ref ZLNET_IVA_GPI_ASSCONFIG alarmCfg, int chn);

        // 获取外部报警联动
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetGpiAssc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetGpiAssc(long lLoginID, ref ZLNET_IVA_GPI_ASSCONFIG alarmCfg, int chn);

        // 设置外部报警工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetGpiWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetGpiWorkSheet(long lLoginID, ref ZLNET_IVA_WEEK_SECTION alarmWorksheet, int chn);

        // 获取外部报警工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetGpiWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetGpiWorkSheet(long lLoginID, ref ZLNET_IVA_WEEK_SECTION alarmWorksheet, int chn);

        // 设置ATM人脸检测区域参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetATMAreaFaceParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetATMAreaFaceParm(int lLoginID, ref ZLNET_IVA_ATM_ALARMAREA_FACE alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取ATM人脸检测区域参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetATMAreaFaceParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetATMAreaFaceParm(int lLoginID, ref ZLNET_IVA_ATM_ALARMAREA_FACE alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 设置ATM报警区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetATMAlarmAreaParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetATMAlarmAreaParm(long lLoginID, ref ZLNET_IVA_ATM_DETECTAREA alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取ATM报警区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetATMAlarmAreaParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetATMAlarmAreaParm(long lLoginID, ref ZLNET_IVA_ATM_DETECTAREA alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 设置ATM配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetATMParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetATMParm(int lLoginID, ref ZLNET_IVA_ATM_PARAM alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取ATM配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetATMParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetATMParm(int lLoginID, ref ZLNET_IVA_ATM_PARAM alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 设置ATM异常人脸配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetATMArnomalFaceParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetATMArnomalFaceParm(int lLoginID, ref ZLNET_IVA_ATM_ARNORMAL_FACE_PARAM alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取ATM异常人脸配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetATMArnomalFaceParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetATMArnomalFaceParm(int lLoginID, ref ZLNET_IVA_ATM_ARNORMAL_FACE_PARAM alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 设置ATM人脸视频颜色参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetATMFaceColorParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetATMFaceColorParm(int lLoginID, ref ZLNET_IVA_ATM_CONFIG_VIDEOCOLOR alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取ATM人脸视频颜色参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetATMFaceColorParm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetATMFaceColorParm(int lLoginID, ref ZLNET_IVA_ATM_CONFIG_VIDEOCOLOR alarmParm, ZLNET_IVA_ATM_INDEX emIndex = ZLNET_IVA_ATM_INDEX.ZLNET_IVA_ATM1);

        // 获取在线用户
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetOnlineConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetOnlineConfig(int lLoginID, ref ZLNET_IVA_USER_ONLINE_LIST onlineCfg);

        // 设置在线用户
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetOnlineConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetOnlineConfig(int lLoginID, ref ZLNET_IVA_USER_ONLINE_LIST onlineCfg);

        // 获取白名单
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetIPFilterCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetIPFilterCfg(int lLoginID, ref ZLNET_DEV_IPIFILTER_CFG IPFilterCfg);

        // 设置白名单
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetIPFilterCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetIPFilterCfg(int lLoginID, ref ZLNET_DEV_IPIFILTER_CFG IPFilterCfg);

        // 获取算法调试
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetArithmeticDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetArithmeticDebug(int lLoginID, ref ZLNET_IVA_ARITHMETIC_DEBUG arithDebug);

        // 设置算法调试
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetArithmeticDebug",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetArithmeticDebug(int lLoginID, ref ZLNET_IVA_ARITHMETIC_DEBUG arithDebug);

        // 获取音频上传信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAudioUploadInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAudioUploadInfo(int lLoginID, ref ZLNET_IVA_AUDIO_UPLOAD_INFO audioInfo);

        // 获取车辆检测区域和车辆屏蔽区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetLicensePlateRegion",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetLicensePlateRegion(int lLoginID, ref ZLNET_IVA_REGION licensePlateRegion);

        // 设置车辆检测区域和车辆屏蔽区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetLicensePlateRegion",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetLicensePlateRegion(int lLoginID, ref ZLNET_IVA_REGION licensePlateRegion);

        // 获取OSD及车牌配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetOsdLicensePlateConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetOsdLicensePlateConfig(int lLoginID, ref ZLNET_IVA_OSD_LICENSE_PALTE_PARAM osdLicensePlateParam);

        // 设置OSD及车牌配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetOsdLicensePlateConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetOsdLicensePlateConfig(int lLoginID, ref ZLNET_IVA_OSD_LICENSE_PALTE_PARAM osdLicensePlateParam);

        // 获取车牌配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetLicensePlateConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetLicensePlateConfig(int lLoginID, ref ZLNET_IVA_PLATEID_PARAM liscensePlateParam);

        // 设置车牌配置参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetLicensePlateConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetLicensePlateConfig(int lLoginID, ref ZLNET_IVA_PLATEID_PARAM liscensePlateParam);

        // 获取车牌报警参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetLicensePlateAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetLicensePlateAlarm(int lLoginID, ref ZLNET_IVA_PLATEID_ALARM liscensePlateParam);

        // 设置车牌报警参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetLicensePlateAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetLicensePlateAlarm(int lLoginID, ref ZLNET_IVA_PLATEID_ALARM liscensePlateParam);

        // 触发(一次)车牌检测
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetLicensePlateDetect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetLicensePlateDetect(int lLoginID, int nChn);

        // 获取人员检测参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetStaffCountConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetStaffCountConfig(int lLoginID, ref ZLNET_IVA_STAFF_COUNT_CONFIG staffCountConfig);

        // 设置人员检测参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetStaffCountConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetStaffCountConfig(int lLoginID, ref ZLNET_IVA_STAFF_COUNT_CONFIG staffCountConfig);

        // 获取人员检测参数-扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetStaffCountConfigEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetStaffCountConfigEx(int lLoginID, ref ZLNET_IVA_STAFF_COUNT_CONFIG staffCountConfig, int nChannel);

        // 设置人员检测参数-扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetStaffCountConfigEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetStaffCountConfigEx(int lLoginID, ref ZLNET_IVA_STAFF_COUNT_CONFIG staffCountConfig, int nChannel);

        // 获取周界基本参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSBasicSet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSBasicSet(int lLoginID, ref ZLNET_IVA_BZS_BASIC_SETTIINGS bzsBasic);

        // 设置周界基本参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSBasicSet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSBasicSet(int lLoginID, ref ZLNET_IVA_BZS_BASIC_SETTIINGS bzsBasic);

        // 获取周界算法参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSAlgorithm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSAlgorithm(int lLoginID, ref ZLNET_IVA_BZS_ALGORITHM_PARAM bzsAlgorithm);

        // 设置周界算法参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSAlgorithm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSAlgorithm(int lLoginID, ref ZLNET_IVA_BZS_ALGORITHM_PARAM bzsAlgorithm);

        // 获取周界相机异常参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSCameraAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSCameraAbnormal(int lLoginID, ref ZLNET_IVA_BZS_CAMERA_ABNORMAL_PARAM bzsCameraAbnormal);

        // 设置周界相机异常参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSCameraAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSCameraAbnormal(int lLoginID, ref ZLNET_IVA_BZS_CAMERA_ABNORMAL_PARAM bzsCameraAbnormal);

        // 获取周界单线规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSOneLineAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSOneLineAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_CROSS_0NE_LINE_PARAM oneLineRule);

        // 设置周界单线规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSOneLineAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSOneLineAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_CROSS_0NE_LINE_PARAM oneLineRule);

        // 获取周界双线规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSTwoLineAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSTwoLineAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_CROSS_TWO_LINE_PARAM bzsTwoLineRule);

        // 设置周界双线规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSTwoLineAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSTwoLineAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_CROSS_TWO_LINE_PARAM bzsTwoLineRule);

        // 获取周界区域规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSAreaAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSAreaAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_AREA_DETECT_PARAM_PARAM bzsAreaRule);

        // 设置周界区域规则
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSAreaAlarmRule",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSAreaAlarmRule(int lLoginID, ref ZLNET_IVA_BZS_AREA_DETECT_PARAM_PARAM bzsAreaRule);

        // 获取周界基本参数V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSBasicSetV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSBasicSetV2(int lLoginID, ref ZLNET_IVA_BZS_BASIC_SETTIINGS bzsBasic, int nChannel);

        // 设置周界基本参数-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSBasicSetV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSBasicSetV2(int lLoginID, ref ZLNET_IVA_BZS_BASIC_SETTIINGS bzsBasic, int nChannel);

        // 获取周界算法参数-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSAlgorithmV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSAlgorithmV2(int lLoginID, ref ZLNET_IVA_BZS_ALGORITHM_PARAM bzsAlgorithm, int nChannel);

        // 设置周界算法参数-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSAlgorithmV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSAlgorithmV2(int lLoginID, ref ZLNET_IVA_BZS_ALGORITHM_PARAM bzsAlgorithm, int nChannel);

        // 获取周界相机异常参数-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSCameraAbnormalV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSCameraAbnormalV2(int lLoginID, ref ZLNET_IVA_BZS_CAMERA_ABNORMAL_PARAM bzsCameraAbnormal, int nChannel);

        // 设置周界相机异常参数-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSCameraAbnormalV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSCameraAbnormalV2(int lLoginID, ref ZLNET_IVA_BZS_CAMERA_ABNORMAL_PARAM bzsCameraAbnormal, int nChannel);

        //获取周界单线规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSOneLineAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSOneLineAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_CROSS_0NE_LINE_PARAM oneLineRule, int nChannel);

        //设置周界单线规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSOneLineAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSOneLineAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_CROSS_0NE_LINE_PARAM oneLineRule, int nChannel);

        //获取周界双线规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSTwoLineAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSTwoLineAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_CROSS_TWO_LINE_PARAM bzsTwoLineRule, int nChannel);

        //设置周界双线规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSTwoLineAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSTwoLineAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_CROSS_TWO_LINE_PARAM bzsTwoLineRule, int nChannel);

        //获取周界区域规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetBZSAreaAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetBZSAreaAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_AREA_DETECT_PARAM_PARAM bzsAreaRule, int nChannel);

        //设置周界区域规则-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBZSAreaAlarmRuleV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBZSAreaAlarmRuleV2(int lLoginID, ref ZLNET_IVA_BZS_AREA_DETECT_PARAM_PARAM bzsAreaRule, int nChannel);

        // 获取报警使能，ATM/SSB混合模式，nChn=0表示ATM，nChn=1表示SSB
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAlarmEnable",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAlarmEnable(int lLoginID, ref ZLNET_IVA_ALARM_ENABLE AlarmEnable, int nChn);

        // 设置报警使能，ATM/SSB混合模式，nChn=0表示ATM，nChn=1表示SSB
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAlarmEnable",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAlarmEnable(int lLoginID, ref ZLNET_IVA_ALARM_ENABLE AlarmEnable, int nChn);

        // 获取SSB自助厅参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetSSBHallFunc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetSSBHallFunc(int lLoginID, ref ZLNET_IVA_SSB_HALL_FUNC ssbHallFunc, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 设置SSB自助厅参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSSBHallFunc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetSSBHallFunc(int lLoginID, ref ZLNET_IVA_SSB_HALL_FUNC pSsbHallFunc, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 获取SSB自助厅异常参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetSSBHallAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetSSBHallAbnormal(int lLoginID, ref ZLNET_IVA_SSB_ABNORMAL_PARAM ssbAbnormal, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 设置SSB自助厅异常参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSSBHallAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetSSBHallAbnormal(int lLoginID, ref ZLNET_IVA_SSB_ABNORMAL_PARAM pSsbAbnormal, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 获取SSB摄像头异常参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetSSBCameraAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetSSBCameraAbnormal(int lLoginID, ref ZLNET_IVA_SSB_CAMERE_ABNORMAL ssbCameraAbnormal, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 设置SSB摄像头异常参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSSBCameraAbnormal",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetSSBCameraAbnormal(int lLoginID, ref ZLNET_IVA_SSB_CAMERE_ABNORMAL pSsbCameraAbnormal, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 获取SSB加钞间参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetSSBRoomFunc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetSSBRoomFunc(int lLoginID, ref ZLNET_IVA_SSB_ROOM_PARAM ssbRoomParam, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 设置SSB加钞间参数，ATM/SSB混合模式，ssbIndex传1
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSSBRoomFunc",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetSSBRoomFunc(int lLoginID, ref ZLNET_IVA_SSB_ROOM_PARAM pSsbRoomParam, ZLNET_IVA_SSB_INDEX_NEW ssbIndex = ZLNET_IVA_SSB_INDEX_NEW.ZLNET_IVA_SSB1);

        // 算法重启
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBackgroundUpdate",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBackgroundUpdate(int lLoginID, ref ZLNET_IVA_BACKGROUND_UPDATE pBackgroundUpdate);

        // 算法重启-V2
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetBackgroundUpdateV2",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetBackgroundUpdateV2(int lLoginID, ref ZLNET_IVA_BACKGROUND_UPDATE pBackgroundUpdate, int nChannel);

        // 获取人脸检测区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetFaceArea",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetFaceArea(int lLoginID, ref ZLNET_IVA_FACE_AREA_PARAM Param, int nIndex = -1);

        // 设置人脸检测区域
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetFaceArea",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetFaceArea(int lLoginID, ref ZLNET_IVA_FACE_AREA_PARAM pParam, int nIndex = -1);

        // 获取人脸检测参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetFaceDetect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetFaceDetect(int lLoginID, ref ZLNET_IVA_FACE_DETECT_PARAM Param, int nIndex = -1);

        // 设置人脸检测参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetFaceDetect",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetFaceDetect(int lLoginID, ref ZLNET_IVA_FACE_DETECT_PARAM pParam, int nIndex = -1);

        // 获取人脸叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetFaceOverlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetFaceOverlay(int lLoginID, ref ZLNET_IVA_FACE_OVERLAY_PARAM Param, int nIndex = -1);

        // 设置人脸叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetFaceOverlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetFaceOverlay(int lLoginID, ref ZLNET_IVA_FACE_OVERLAY_PARAM pParam, int nIndex = -1);

        // 获取多个人脸叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetFaceOverlayEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetFaceOverlayEx(int lLoginID, ref ZLNET_IVA_FACE_OVERLAY_PARAM_EX Param, int nIndex = -1);

        // 设置多个人脸叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetFaceOverlayEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetFaceOverlayEx(int lLoginID, ref ZLNET_IVA_FACE_OVERLAY_PARAM_EX pSsbRoomParam, int nIndex = -1);

        // 获取485叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_Get485Overlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_Get485Overlay(int lLoginID, ref ZLNET_IVA_485_OVERLAY_PARAM overlayParam, int nIndex = -1);

        // 设置485叠加参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_Set485Overlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_Set485Overlay(int lLoginID, ref ZLNET_IVA_485_OVERLAY_PARAM pOverlayParam, int nIndex = -1);

        // 模拟报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SimulateAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SimulateAlarm(int lLoginID, int alarmType, int nChn);

        // 设置抓图回调函数(jpg)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetSnapRevCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_IVA_SetSnapRevCallBack(fZLSnapRev cbSnapRev, IntPtr dwUser, UInt32 CmdSerial = 0, int bAdd = 1);

        // 停止下载智能报警文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_StopDownload",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_StopDownload(int lLoginID);

        // 订阅ATM报警信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmATMIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmATMIDVR(int lLoginID, fIdvrAlarmUpATMCallback cbDataCallback, IntPtr dwUser);

        // 订阅人员统计信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmStaffCountIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmStaffCountIDVR(int lLoginID, fIdvrAlarmUpStaffCountCallback cbDataCallback, IntPtr dwUser);

        // 订阅车牌信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmPlateIdIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmPlateIdIDVR(int lLoginID, fIdvrAlarmUpPlateIdCallback cbDataCallback, IntPtr dwUser);

        // 订阅自助银行信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmSSBIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmSSBIDVR(int lLoginID, fIdvrAlarmUpSSBCallback cbDataCallback, IntPtr dwUser);

        // 订阅ATM自助银行混合型信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmAtmSsbIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmAtmSsbIDVR(int lLoginID, fIdvrAlarmUpAtmSsbCallback cbDataCallback, IntPtr dwUser);

        // 订阅周界报警信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmBZSIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmBZSIDVR(int lLoginID, fIdvrAlarmUpBZSCallback cbDataCallback, IntPtr dwUser);

        // 订阅人脸报警信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmFaceIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmFaceIDVR(int lLoginID, fIdvrAlarmUpFaceCallback cbDataCallback, IntPtr dwUser);

        // 订阅车位报警信息回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmParkingIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmParkingIDVR(int lLoginID, fIdvrAlarmUpParkingCallback cbDataCallback, IntPtr dwUser);

        // 订阅DVR\NVR智能报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ListenAlarmIvaDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ListenAlarmIvaDVR(int lLoginID, fDvrIvaAlarmCallback cbDataCallback, IntPtr dwUser);

        // 若订阅智能报警信息回调时传入登录句柄为0，使用本接口启动报警监听
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_StartListen",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_StartListen(int lLoginID);

        // 订阅智能报警视频上传
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAlarmUpVideoIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAlarmUpVideoIDVR(int lLoginID, fIdvrAlarmUpVideoCallback cbDataCallback, IntPtr dwUser);

        // G4\G5设备查询历史智能报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_QueryRecordFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_QueryRecordFile(int lLoginID, int nChannelId, ref ZLNET_TIME tmStart, ref ZLNET_TIME tmEnd,
                                                     int idBeg, int idEnd, IntPtr itemInfo, int maxlen, ref int itemCount, int waittime = 1000,
                                                     ZLNET_IVA_LOG_SEARCH_MODE mode = ZLNET_IVA_LOG_SEARCH_MODE.ZLNET_IVA_SEARCHMODE_DATE, ZLNET_DEVICE_TYPE eDevType = ZLNET_DEVICE_TYPE.ZLNET_IVA_ATM);

        // DVR\NVR设备查询历史智能报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_DVR_QueryRecordFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体ZLNET_IVA_DVR_LOG
        public static extern int ZLNET_IVA_DVR_QueryRecordFile(int lLoginID, int nChannelId, ref ZLNET_TIME tmStart, ref ZLNET_TIME tmEnd,
                                                     IntPtr pBuf, int maxLogNumber, ref int pRetLogNumber, ref ZLNET_IVA_QUERY_CONDITION pCondition);

        // 下载智能报警文件(仅老设备支持)，推荐使用ZLNET_IVA_DownloadFileEx
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_DownloadFileIDVR",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_DownloadFileIDVR(int lLoginID, int id, string szDirPath, ZLNET_IVA_LOG_DOWNLOAD_MODE mode, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData, ZLNET_DEVICE_TYPE eType = ZLNET_DEVICE_TYPE.ZLNET_IVA_ATM);

        // 下载智能报警文件(新协议)，推荐使用ZLNET_IVA_DownloadFileEx
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_DownloadFile",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_DownloadFile(int lLoginID, string szDirPath, ref ZLNET_IVA_EVENT struDownloadParm, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData);

        // 下载智能报警文件扩展,同时兼容新老设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_DownloadFileEx",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_DownloadFileEx(int lLoginID, string szDirPath, ref ZLNET_IVA_EVENT struDownloadParm, fIdvrAlarmDownloadCallback cbData, fZLDownLoadPosCallBack cbDownLoadPos, IntPtr dwUserData, ref ZLNET_IVA_DOWN_PARAM param);

        // 触发用户音频播放 emAudio 音频序号  nInterval播放间隔 单位s   未使用
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_StartAudioPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_StartAudioPlay(int lLoginID, int nAlarmType, int nInterval = 0, int nAudioIndex = 0);

        // 关闭用户音频播放
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_StopAudioPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_StopAudioPlay(int lLoginID, int nAlarmType, int nAudioIndex = 0);

        // 设置音频工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetAudioWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetAudioWorkSheet(int lLoginID, int nAlarmType, ref ZLNET_IVA_WORKSHEET pAudioWorksheet, int nAudioIndex = 0);

        // 获取音频工作表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetAudioWorkSheet",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetAudioWorkSheet(int lLoginID, int nAlarmType, ref ZLNET_IVA_WORKSHEET audioWorksheet, int nAudioIndex = 0);

        // 重置设备参数（1为人数统计清除算法中的总人数）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_ResetDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_ResetDev(int lLoginID, int nChn, int nCommand = 1);

        // 设置人数统计多人报警参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetMultiUserParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetMultiUserParam(int lLoginID, ref ZLNET_IVA_STAFF_MULTIUSERPARAM pMultiParam, int nSCIndex);

        // 获取人数统计多人报警参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetMultiUserParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetMultiUserParam(int lLoginID, ref ZLNET_IVA_STAFF_MULTIUSERPARAM multiParam, int nSCIndex);

        // 设定通用算法信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetAlgorithmConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetAlgorithmConfig(int lLoginID, ref ZLNET_ALGORITHM_CONFIG pConfig, int nChn = -1);

        // 获取通用算法信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetAlgorithmConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetAlgorithmConfig(int lLoginID, ref ZLNET_ALGORITHM_CONFIG config, int nChn = -1);

        // 获取设备能力信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Dev_Enable",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Dev_Enable(int lLoginID, ref ZLNET_DEVICE_ENABLE devEnable);

        //获取通道编码能力(配置通道编码时应当参考此能力）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetEncodeCaps",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetEncodeCaps(long lLoginID, ref ZLNET_DEVICE_ENABLE devEnable);

        // 获取NVR通道模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Nvr_GetChannelMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Nvr_GetChannelMode(int lLoginID, ref ZLNET_NVR_CHANNEL_MODE_SUPPORT chMode);

        // 设置NVR通道模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Nvr_SetChannelMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Nvr_SetChannelMode(int lLoginID, ref ZLNET_NVR_CHANNEL_MODE_SUPPORT pChMode);

        // 获取NVR网络通道状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Nvr_GetNvrChnState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Nvr_GetNvrChnState(int lLoginID, ref ZLNET_NVR_STATE_NET chnState);

        //获取NVR网络通道状态扩展
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChnState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChnState(int lLoginID, ref ZLNET_NET_CHN_STATE pState);

        // 获取IPC视频参数配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_HDIPC_GetVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_HDIPC_GetVideoParam(int lLoginID, ref ZLNET_VIDEO_PARAM videoParam);

        // 设置IPC视频参数配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_HDIPC_SetVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_HDIPC_SetVideoParam(int lLoginID, ref ZLNET_VIDEO_PARAM pVideoParam);

        // 获取网络通道视频参数配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetVideoParam(int lLoginID, ref ZLNET_CHANNEL_VIDEO_PARAM videoParam);

        // 设置网络通道视频参数配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetVideoParam(int lLoginID, ref ZLNET_CHANNEL_VIDEO_PARAM pVideoParam);

        // 获取UPNP连接状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetUpnpState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetUpnpState(int lLoginID, ref ZLNET_NET_UPNP_STATE upnpState);

        // 获取RTSP配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetRtspCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetRtspCfg(int lLoginID, ref ZLNET_DEV_RTSP_CONFIG rtspCfg);

        // 获取wifi使能
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetWifiEnable",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetWifiEnable(int lLoginID, ref ZLNET_WIFI_ENABLE wifiEnable);

        // 设置wifi使能
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetWifiEnable",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetWifiEnable(int lLoginID, ref ZLNET_WIFI_ENABLE pWifiEnable);

        // 获取wifi连接方式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetWifiConnType",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetWifiConnType(int lLoginID, ref ZLNET_WIFI_CONNECTION_TYPE wifiType);

        // 设置wifi连接方式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetWifiConnType",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetWifiConnType(int lLoginID, ref ZLNET_WIFI_CONNECTION_TYPE pWifiType);

        // 获取wifi参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetWifiCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetWifiCfg(int lLoginID, ref ZLNET_DEV_WIFI_CFG wifiCfg);

        // 设置wifi参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetWifiCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetWifiCfg(int lLoginID, ref ZLNET_DEV_WIFI_CFG pWifiCfg);

        // 扫描路由网点信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ScanWifiNetwork",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ScanWifiNetwork(int lLoginID, ref ZLNETl_WIFI_NETWORK_INFO networkInfo);

        // DDNS注册
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_DdnsRegister",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_DdnsRegister(int lLoginID, ref ZLNET_DDNS_REGISTER_INFO pDdnsRegisterInfo);

        // 获取DDNS状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDdnsState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDdnsState(int lLoginID, ref ZLNET_DDNS_STATE ddnsState);

        // 获取默认图像颜色
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDefaultColor",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDefaultColor(int lLoginID, ref ZLNET_COLOR_CFG defColor);

        // 获取云台模拟控制配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPtzSimulationCtrlCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPtzSimulationCtrlCfg(int lLoginID, ref ZLNET_485_SIMULATION_CTRL_CFG ptzSimulation);

        // 设置云台模拟控制配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPtzSimulationCtrlCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPtzSimulationCtrlCfg(int lLoginID, ref ZLNET_485_SIMULATION_CTRL_CFG pPtzSimulation);

        // 获取球机视频参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetDomeCameraVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetDomeCameraVideoParam(int lLoginID, ref ZLNET_DOME_CAMERA_VIDEO_PARAM videoParam);

        // 设置球机视频参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetDomeCameraVideoParam",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetDomeCameraVideoParam(int lLoginID, ref ZLNET_DOME_CAMERA_VIDEO_PARAM pVideoParam);

        // 侦听反向连接信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ListenRevLink",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ListenRevLink(int lLoginID, fZLRevLink cbRevLink, IntPtr dwUser);

        // 停止侦听反向连接信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopRevLink",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopRevLink(int lLoginID);

        // 设置反向连接服务器信息(注意: 要侦听返回信息的话, 一定要在ZLNET_ListenRevLink之后调用)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetRevLink",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetRevLink(int lLoginID, ref ZLNET_REV_LINK networkInfo);

        // 配置反向链接设备启动时配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetRvLinkConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetRvLinkConfig(int lLoginID, ref ZLNET_CONFIG_REG_SERVER networkInfo);

        // 获取反向链接设备启动时配置文件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetRvLinkConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetRvLinkConfig(int lLoginID, ref ZLNET_CONFIG_REG_SERVER networkInfo);

        // 获取AEV配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetAebGbCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetAebGbCfg(int lLoginID, ref ZLNET_AEB_GB_PROTOCOL aebGbCfg);

        // 设置AEV配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetAebGbCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetAebGbCfg(int lLoginID, ref ZLNET_AEB_GB_PROTOCOL pAebGbCfg);

        // 获取康联网络配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetKonlanNetCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetKonlanNetCfg(int lLoginID, ref ZLNET_KONLAN_NET_CONFIG konlanCfg);

        // 设置康联网络配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetKonlanNetCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetKonlanNetCfg(int lLoginID, ref ZLNET_KONLAN_NET_CONFIG pKonlanCfg);

        // 获取串口类型
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetComType",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetComType(int lLoginID, ref ZLNET_COM_TYPE comType);

        // 设置串口类型
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetComType",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetComType(int lLoginID, ref ZLNET_COM_TYPE pComType);

        // 获取通道录像状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetChannelRecordState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetChannelRecordState(int lLoginID, ref ZLNET_CHANNEL_RECORD_STATE recordState);

        // 获取网络通道外部报警配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChExternalAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChExternalAlarm(int lLoginID, ref ZLNET_NET_CHANNEL_EXTERNAL_ALARM_CFG externalAlarm);

        // 设置网络通道报警配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetChExternalAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNetChExternalAlarm(int lLoginID, ref ZLNET_NET_CHANNEL_EXTERNAL_ALARM_CFG pExternalAlarm);

        // 获取网络通道权限
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChPrivileges",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChPrivileges(int lLoginID, ref ZLNET_NVR_PROANDDEV_ABILITY_PRIVILEGES privileges, int nChannel, int nType);

        // 获取所有网络通道编码配置的支持范围
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChCaptureOption",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChCaptureOption(int lLoginID, ref ZLNET_NET_CHANNEL_CAPTURE_OPTION captureOption, int nType);

        // 获取所有网络通道编码配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChCaptureFormat",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChCaptureFormat(int lLoginID, ref ZLNET_NET_CHANNEL_CAPTURE_FORMAT captureFormat, int nType);

        // 设置所有网络通道编码配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetChCaptureFormat",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNetChCaptureFormat(int lLoginID, ref ZLNET_NET_CHANNEL_CAPTURE_FORMAT pCaptureFormat, int nType);

        // 获取所有网络通道编码配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChName",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChName(int lLoginID, ref ZLNET_NET_CHANNEL_NAME netChannelName);

        // 设置所有网络通道编码配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetChName",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNetChName(int lLoginID, ref ZLNET_NET_CHANNEL_NAME pNetChannelName);

        // 获取所有网络通道抓图配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetChSnap",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetChSnap(int lLoginID, ref ZLNET_NET_CHANNEL_SNAP netChannelName);

        // 设置所有网络通道抓图配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetChSnap",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNetChSnap(int lLoginID, ref ZLNET_NET_CHANNEL_SNAP pNetChannelName);

        // 获取搜索到的设备IP信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetSearchedOutDevIP",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetSearchedOutDevIP(int lLoginID, ref ZLNET_NVR_MIXED_DEV_NETCFG mixedDevCfg, ref int pError);

        // 设置搜索到的设备IP信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSearchedOutDevIP",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetSearchedOutDevIP(int lLoginID, ref ZLNET_NVR_MIXED_DEV_NETCFG pMixedDevCfg, ref int pError);

        // 获取上海地标配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetShtyCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetShtyCfg(int lLoginID, ref ZLNET_CONFIG_SHTY cfgShty);

        // 设置上海地标配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetShtyCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetShtyCfg(int lLoginID, ref ZLNET_CONFIG_SHTY pCfgShty);

        // 上海地标上传信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ShtyUpload",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ShtyUpload(int lLoginID, ref ZLNET_SHTY_UPLOAD pShtyUpload);

        // 设置云台控制方式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPtzControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPtzControl(int lLoginID, ref ZLNET_PTZ_CONTROL pPtzCtrl);

        // 获取云台控制方式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPtzControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPtzControl(int lLoginID, ref ZLNET_PTZ_CONTROL ptzCtrl);

        // 订阅IPC前端操作
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetFrontEndOperate",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetFrontEndOperate(int lLoginID, int bStart, int nOperateType, int waittime = 1500);

        // 设置IPC前端操作回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetFrontEndOperateCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_SetFrontEndOperateCallback(fZLFrontEndOperateCallback cbFrontEndOperateRec, IntPtr dwUser);

        // 前端操作
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FrontEndOperate",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FrontEndOperate(int lLoginID, ref ZLNET_FRONT_END_OPERATE pFrontEndOperate);

        // 获取云台配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPtzConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPtzConfig(int lLoginID, ref ZLNET_PTZ_CONFIG ptzConfig);

        // 设置云台配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPtzConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPtzConfig(int lLoginID, ref ZLNET_PTZ_CONFIG pPtzConfig);

        //获取手机推送配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPhonePushCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPhonePushCfg(int lLoginID, ref ZLNET_PHONE_PUSH_CONFIG phonePushCfg);

        // 设置手机推送配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPhonePushCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPhonePushCfg(int lLoginID, ref ZLNET_PHONE_PUSH_CONFIG pPhonePushCfg);

        // 获取3G配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Get3GCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Get3GCfg(int lLoginID, ref ZLNET_3G_CONFIG cfg);

        // 设置3G配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Set3GCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Set3GCfg(int lLoginID, ref ZLNET_3G_CONFIG p3GCfg);

        // 获取备份设备信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetBackupDevInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetBackupDevInfo(int lLoginID, ref ZLNET_BACKUP_DEVICE_LIST cfg);

        // 备份录像
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_BackupRecords",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_BackupRecords(int lLoginID, ref ZLNET_BACKUP_RECORD_FILE pCfg);

        // 备份操作
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_BackupOperate",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_BackupOperate(int lLoginID, ref ZLNET_BACKUP_OPERATE cfg);

        // 获取穿网设备是否在线
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetP2PDevState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetP2PDevState(string uuid, IntPtr ip, int nBuf);

        // 侦听穿网设备在线状态, 调用一次增加一台设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_P2PListen",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_P2PListen(string uuid);

        // 设置穿网状态回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_P2PSetStateCallBack",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern void ZLNET_P2PSetStateCallBack(fP2PStateCallBack cbMessage, IntPtr dwUser, UInt32 nTime = 5000);

        // 停止订阅穿网状态, uuid为空停止所有. 如果uuid不存在则返回false. bExit为TRUE, 表示彻底关闭查询线程, 需要等待线程退出才可返回
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_P2PStopListen",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_P2PStopListen(string uuid, int bExit = 0);

        // 获取NVR协议排序
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetProtocolSort",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetProtocolSort(int lLoginID, ref ZLNET_NVR_PROTOCOL_SORT protocolSort);

        // 获取穿网服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetP2PSeviceCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetP2PSeviceCfg(int lLoginID, ref ZLNET_P2P_SERVICE P2PService);

        // 设置穿网服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetP2PSeviceCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetP2PSeviceCfg(int lLoginID, ref ZLNET_P2P_SERVICE pP2PService);

        // 获取穿网网络状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetP2PNetState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetP2PNetState(int lLoginID, int lPlayHandle, ref int nNetState, ref int bProxy);

        // 获取网卡模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetCardMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetCardMode(int lLoginID, ref ZLNET_NET_CARD_MODE netCardMode);

        // 设置网卡模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetNetCardMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetNetCardMode(int lLoginID, ref ZLNET_NET_CARD_MODE pNetCardMode);

        // 获取使用当前IP和配置IP
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetNetCardIPInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetNetCardIPInfo(int lLoginID, ref ZLNET_NET_CARD_IP_INFO netCardIPInfo);

        // 获取康联无线报警配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetKLWirelessArming",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetKLWirelessArming(int lLoginID, ref ZLNET_KL_WIRELESS_ARMING wirelessArming);

        // 设置康联无线报警配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetKLWirelessArming",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetKLWirelessArming(int lLoginID, ref ZLNET_KL_WIRELESS_ARMING pWirelessArming);

        //获取云存储绑定信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetCloudBind",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetCloudBind(int lLoginID, ref ZLNET_CLOUD_STORAGE_BIND cloudBind, ZLNET_CLOUD_STORAGE_BIND_TYPE type);

        //上传绑定结果
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_UploadCloudBind",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_UploadCloudBind(int lLoginID, ref ZLNET_CLOUD_STORAGE_BIND pCloudBind);

        //获取云存储视频检测信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetCloudAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetCloudAlarm(int lLoginID, ref ZLNET_CLOUD_STORAGE_ALARM cloudAlarm);

        //设置云存储视频检测信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetCloudAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetCloudAlarm(int lLoginID, ref ZLNET_CLOUD_STORAGE_ALARM pCloudAlarm);

        // 获取通道对讲信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_ChannelTalkInfo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_ChannelTalkInfo(int lLoginID, int nChannel, ref ZLNET_DEV_TALKFORMAT_LIST talkList);

        // 获取智能设备分析模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_GetDevAnalysisMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_GetDevAnalysisMode(int lLoginID, ref ZLNET_IVA_DEV_ANALYSIS mode);

        // 设定智能设备分析模式
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_IVA_SetDevAnalysisMode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_IVA_SetDevAnalysisMode(int lLoginID, ZLNET_IVA_DEV_ANALYSIS mode);

        /////////////////////////////////台湾设备相关接口/////////////////////////////////////////
        // 获取Hdmi播放顺序时段
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHdmiPlayTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHdmiPlayTime(int lLoginID, ref ZLNET_HDMI_TABLE hdmiTable);

        // 设置Hdmi播放顺序时段
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetHdmiPlayTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetHdmiPlayTime(int lLoginID, ref ZLNET_HDMI_TABLE pHdmiTable);

        // 强制插播
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Hdmi_ForcePlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Hdmi_ForcePlay(int lLoginID, ref ZLNET_HDMI_PLAY pHdmiPlay);

        // 查询当前DVR播放进度
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryPlayProgress",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryPlayProgress(int lLoginID, ref ZLNET_HDMI_PROGRESS hdmiProgress);

        // 插入卡号 1表示插卡 2表示退卡
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Insert_Card",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Insert_Card(int lLoginID, string pCardNo, int nStatus);

        // 系统设备升级
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_Firmware_Upgrade",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_Firmware_Upgrade(int lLoginID, string filename);

        // 插卡前，退卡后的时间设定 单位：秒
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetCardOperatorTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetCardOperatorTime(int lLoginID, int nBeforPushCard, int nAfterPopCard);

        // 插卡前，退卡后的时间取得
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetCardOperatorTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetCardOperatorTime(int lLoginID, ref int pBeforPushCard, ref int pAfterPopCard);

        // 预估剩余存储天数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_CalculateLeftRecordingTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_CalculateLeftRecordingTime(int lLoginID, ref int pRecordDaysLimit);

        // 设定存储时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetRecordingTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetRecordingTime(int lLoginID, int nRecordDaysLimit, int nChannelCount);

        // 取得存储时间
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetRecordingTime",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetRecordingTime(int lLoginID, ref int pRecordDaysLimit, ref int pChannelCount);

        // 卡号叠加设定
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetCardOverlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetCardOverlay(int lLoginID, ref ZLNET_CARD_OVERLAY pCardOverlay);

        // 卡号叠加取得
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetCardOverlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetCardOverlay(int lLoginID, ref ZLNET_CARD_OVERLAY cardOverlay);

        // 获取韩国无线报警模块信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHGWireless",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHGWireless(int lLoginID, ref ZLNET_HANGUO_WIRELESS pWireless);

        // 设置韩国无线报警模块信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetHGWireless",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetHGWireless(int lLoginID, ref ZLNET_HANGUO_WIRELESS pWireless);

        // 获取韩国无线报警模块状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHGWirelessState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHGWirelessState(int lLoginID, ref ZLNET_HANGUO_WIRELESS_STATE pWirelessState);

        // 设置韩国无线报警模块通道配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetHGWirelessChannel",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetHGWirelessChannel(int lLoginID, ref ZLNET_HANGUO_WIRELESS_CHANNEL pWirelessChannel);

        // 获取SDI接入信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetSdiState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetSdiState(int lLoginID, ref ZLNET_SDI_ACCESS_VIDEO_STATE pSdiState);

        // 获取凯聪云服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetKaiCongCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetKaiCongCfg(int lLoginID, ref ZLNET_KAICONG_CLOUD_CONFIG pKaiCongCfg);

        // 设置凯聪云服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetKaiCongCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetKaiCongCfg(int lLoginID, ref ZLNET_KAICONG_CLOUD_CONFIG pKaiCongCfg);

        // 获取VISS服务信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetVissCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetVissCfg(int lLoginID, ref ZLNET_VISS_CONFIG pVissCfg);

        // 设置VISS服务信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetVissCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetVissCfg(int lLoginID, ref ZLNET_VISS_CONFIG pVissCfg);

        // 获取推送服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetPushCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetPushCfg(int lLoginID, ref ZLNET_PUSH_CONFIG pPushConfig);

        // 设置推送服务配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetPushCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetPushCfg(int lLoginID, ref ZLNET_PUSH_CONFIG pPushConfig);

        // 获取安全中心配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetSecurityCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetSecurityCfg(int lLoginID, ref ZLNET_SECURITY_CONFIG pSecurityCfg);

        // 设置安全中心配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSecurityCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetSecurityCfg(int lLoginID, ref ZLNET_SECURITY_CONFIG pSecurityCfg);

        // 获取所有网络通道码流状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetChannelStreamState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetChannelStreamState(int lLoginID, ref ZLNET_CHANNEL_STREAM_STATE streamState);

        // 设置所有网络通道码流状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetChannelStreamState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetChannelStreamState(int lLoginID, ref ZLNET_CHANNEL_STREAM_STATE pStreamState);

        ///////////////////////////////////////////////////////新二代协议///////////////////////////////////////////////////////

        // 查询F6信息/能力(Json格式） 命令参考ZLNET_F6_MAINCOMMAND
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetF6DevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetF6DevConfig(int lLoginID, UInt32 dwCommand, UInt32 dwSubCommand, int lChannel, IntPtr lpOutBuffer, UInt32 dwOutBufferSize, ref UInt32 lpBytesReturned, int waittime = 1500);

        // 设置F6信息(Json格式）命令参考ZLNET_F6_MAINCOMMAND
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetF6DevConfig",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetF6DevConfig(int lLoginID, UInt32 dwCommand, UInt32 dwSubCommand, int lChannel, IntPtr lpInBuffer, UInt32 dwInBufferSize, int waittime = 1500);

        // 报警订阅
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_ListenAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_ListenAlarm(int lLoginID, ref ZLNET_ALARM_SUBSCRIBE param);

        // 取消订阅
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_StopListenAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_StopListenAlarm(int lLoginID);

        // 设置新协议智能设备报警回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_SetAlarmUpCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_SetAlarmUpCallback(int lLoginID, fF6AlarmUpCallback cbDataCallback, IntPtr dwUser);

        // 设置新协议智能设备报警视频回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_SetAlarmVideoCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_SetAlarmVideoCallback(int lLoginID, fF6AlarmVideoCallback cbDataCallback, IntPtr dwUser);

        // 设置新协议智能设备报警图片回调
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_SetAlarmPictureCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_SetAlarmPictureCallback(int lLoginID, fF6AlarmPictureCallback cbDataCallback, IntPtr dwUser);

        // 查询新协议报警(nMaxCount和nRetCount均指条数）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_QueryAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体ZLNET_NEWF6_ALARM
        public static extern int ZLNET_F6_QueryAlarm(int lLoginID, ref ZLNET_QUERYALARM_PARAM param, IntPtr pBuf, int nMaxCount, ref int nRetCount, int nTimeOut = 5000);

        // 下载新协议报警视频(数据回调fF6DownVideoCallback）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_DownloadAlarmVideo",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_DownloadAlarmVideo(int lLoginID, ref ZLNET_DOWNALARM_VIDEO_PARAM param, fF6DownVideoCallback cbDataCallback, IntPtr dwUser);

        // 下载新协议报警图片(数据回调fF6AlarmPictureCallback）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_DownloadAlarmPicture",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_DownloadAlarmPicture(int lLoginID, ref ZLNET_DOWNALARM_PIC_PARAM param, fF6AlarmPictureCallback cbDataCallback, IntPtr dwUser);

        // 查询新协议设备能力
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_GetGlobalCaps",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_GetGlobalCaps(int lLoginID, ref ZLNET_F6_CAPBILITIES pCaps, int nTimeOut = 2000);

        // 查询报警能力,nChannel == -1 表示查询全部通道
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_GetAlarmCaps",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_GetAlarmCaps(int lLoginID, int nChannel, ref ZLNET_ALARM_CAPBILITIES pCaps, int nTimeOut = 3000);

        // 查询算法版本（针对智能设备）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_GetAlgoVersion",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pVer对应结构体ZLNET_ALGORITHM_VERSION
        public static extern int ZLNET_F6_GetAlgoVersion(int lLoginID, IntPtr pVer, int nVerNum, ref int nRetNum, int nTimeOut = 3000);

        // 模拟报警
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_SimulateAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_SimulateAlarm(int lLoginID, ref ZLNET_SIMULATE_ALARM_PARAM pParam, int nTimeOut = 3000);

        // 解析报警图片中的叠加信息
        //pData[in]:     图片路径或图片数据均可，接口内部会自行识别
        //nDataLen[in]:  pData长度
        //pObj[in]:      缓存，不能为NULL，建议pObj = new ZLNET_OVERLAY_OBJECT[nBufNum]
        //nBufNum[in]:  pObj最大个数，建议32个
        //nRetNum[out]:  实际返回的pObj个数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetOverlayObject",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetOverlayObject(IntPtr pData, int nDataLen, ZLNET_OVERLAY_OBJECT[] pObj, int nBufNum, ref int nRetNum);

        // 获取算法调试内部参数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_GetAlgoDebugOption",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_GetAlgoDebugOption(int lLoginID, int nChannel, ref ZLNET_IVA_DEBUG_OPTION pParam, int nTimeOut = 3000);

        // 设置算法调试内部参数，nChannel = -1 表示设置所有通道，pParam = NULL 表示复位设备默认配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_SetAlgoDebugOption",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_SetAlgoDebugOption(int lLoginID, int nChannel, ref ZLNET_IVA_DEBUG_OPTION pParam, int nTimeOut = 3000);

        // 出入口相机黑白名单操作, nListType：0黑名单 1白名单，nOperateType: 0新增 1修改 2删除(pRecord为NULL表示删除全部）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_OperateGatewayList",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_OperateGatewayList(int lLoginID, int nListType, int nOperateType, ref ZLNET_GATEWAY_CAMERA_RECORD pRecord, int nTimeOut = 3000);

        // 出入口相机黑白名单查询, nListType：0黑名单 1白名单, pQuery：查询条件, pResult：用于存放查询结果，nMaxCount：结果最大条数, nRetCount: 返回条数
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_F6_QueryGatewayList",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_F6_QueryGatewayList(int lLoginID, int nListType, ref ZLNET_GATEWAY_CAMERA_QUERY pQuery, ref ZLNET_GATEWAY_CAMERA_RECORD pResult, int nMaxCount, ref int nRetCount, int nTimeOut = 3000);

        ///////////////////////////////////////物联网网关///////////////////////////////////

        //能力查询
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetSensorCaps",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetSensorCaps(int lLoginID, ref ZLNET_SENSOR_CAPS pBuf, int nTimeOut = 3000);

        //物联网网关获取传感器列表，未使能的传感器将取不到
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySensorDevice",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_SENSOR_DEVICE
        public static extern int ZLNET_QuerySensorDevice(int lLoginID, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        //物联网网关获取传感器列表(扩展）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySensorDeviceBegin",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QuerySensorDeviceBegin(int lLoginID, int nTimeOut = 3000);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySensorDeviceNext",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_SENSOR_DEVICE
        public static extern int ZLNET_QuerySensorDeviceNext(int lHandle, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySensorDeviceEnd",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QuerySensorDeviceEnd(int lHandle);

        //物联网网关获取传感器状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QuerySensorState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QuerySensorState(int lLoginID, int nSensorID, ref ZLNET_SENSOR_STATE pBuf, int nTimeOut = 3000);

        //物联网网关获取测点列表
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryMeasuringPoint",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_MEASURING_POINT
        public static extern int ZLNET_QueryMeasuringPoint(int lLoginID, ref ZLNET_MEASURINGPOINT_QUERY pParam, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        //物联网网关获取测点列表(扩展）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryMeasuringPointBegin",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryMeasuringPointBegin(int lLoginID, ref ZLNET_MEASURINGPOINT_QUERY pParam, int nTimeOut = 3000);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryMeasuringPointNext",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_MEASURING_POINT
        public static extern int ZLNET_QueryMeasuringPointNext(int lHandle, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_QueryMeasuringPointEnd",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_QueryMeasuringPointEnd(int lHandle);

        //物联网网关获取测值
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetMeasuringValue",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_MEASURING_VALUE
        public static extern int ZLNET_GetMeasuringValue(int lLoginID, ref ZLNET_MEASURING_VALUE_QUERY pParam, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        //物联网网关写测值（针对可写型测点）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetMeasuringValue",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetMeasuringValue(int lLoginID, int nSensorID, ref ZLNET_MEASURING_VALUE pValue, int nTimeOut = 3000);

        //物联网网关取测点历史数据
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHistoryMeasuringValue",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_MEASURING_VALUE
        public static extern int ZLNET_GetHistoryMeasuringValue(int lLoginID, ref ZLNET_MEASURING_HISTORY_QUERY pParam, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        //物联网网关取测点历史事件
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHistoryMeasuringAlarm",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体为ZLNET_NEWF6_ALARM
        public static extern int ZLNET_GetHistoryMeasuringAlarm(int lLoginID, ref ZLNET_MEASURING_HISTORY_QUERY pParam, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3500);

        //-----------------------物联网网关取测点历史数据或事件扩展-----------------------

        //func:开始查询
        //lLoginID[in]:设备登录句柄
        //nType[in]:0查数据 1查事件
        //pParam[in]:参数，不能为NULL
        //return:LONG 查询句柄 <=0 为失败
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHistoryMeasuringBegin",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHistoryMeasuringBegin(int lLoginID, int nType, ref ZLNET_MEASURING_HISTORY_QUERY pParam, int nTimeOut = 3000);

        //func:查询数据
        //lHandle[in]:查询句柄,ZLNET_GetHistoryMeasuringBegin的返回值
        //pBuf[in]:查数据时为ZLNET_MEASURING_VALUE指针，查事件时为ZLNET_NEWF6_ALARM指针
        //nBufNum[in]:pBuf指向的BUF个数，注意是结构体个数不是长度
        //nRetNum[out]:返回个数，nRetNum < nBufNum时表明已经查完
        //return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHistoryMeasuringNext",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHistoryMeasuringNext(int lHandle, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeOut = 3000);

        //func:结束查询
        //lHandle[in]:查询句柄,ZLNET_GetHistoryMeasuringBegin的返回值
        //return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_GetHistoryMeasuringEnd",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_GetHistoryMeasuringEnd(int lHandle);

        //-----------------------物联网网关实时数据订阅-----------------------

        //func:设置回调
        //lLoginID[in]:0设为全局回调 或者填入设备登录句柄，设为该设备的回调；设备回调优先级大于全局回调
        //cb[in]:回调函数，为NULL则置空
        //return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SetSensorDataCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SetSensorDataCallback(int lLoginID, fZLSensorDataCallback cb, IntPtr userData);

        //func:订阅实时数据，同一设备多次订阅叠加生效
        //lLoginID[in]:设备登录句柄
        //pParam[in]:参数
        //return:订阅句柄，用于停止订阅
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_SubscribeSensorData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_SubscribeSensorData(int lLoginID, ref ZLNET_SUBSCRIBE_SENSORDATA pParam);

        //func:取消订阅
        //lLoginID[in]:设备登录句柄
        //lListenHandle[in]:订阅句柄ZLNET_SubscribeSensorData的返回值，填0时取消该设备的所有订阅
        //return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_StopSensorDataCallback",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_StopSensorDataCallback(int lLoginID, int lListenHandle);

        /////////////////////////////////////NVD/////////////////////////////////////

        //----------------------------------NVD节点管理------------------------------
        //通过NVD主控（lLoginID）搜索其它NVD设备
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SearchDev",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pBuf对应结构体ZLNET_NVD_SEARCH_RESULT
        public static extern int ZLNET_NVD_SearchDev(int lLoginID, IntPtr pBuf, int nMaxCount, IntPtr nRetCount, int nTimeOut = 5000);

        //通过NVD主控（lLoginID）修改其它设备（ZLNET_NVD_SearchDev搜到的设备）的IP ,pMac为要修改的设备的MAC地址,pError返回错误码
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetDevIp",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetDevIp(int lLoginID, string pMac, ref ZLNET_NVD_NODE pDev, ref ZLNET_NVD_NODE_ERROR pError, int nTimeOut = 3000);

        //添加节点到NVD主控，pNodeId为返回的节点ID，删改节点时使用，预计长度ZLNET_MAX_DEV_ID_LEN,pError返回错误码
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_AddNode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_AddNode(int lLoginID, ref ZLNET_NVD_NODE pNode, string pNodeId, int nIdBufLen, ref ZLNET_NVD_NODE_ERROR pError, int nTimeOut = 5000);

        //把节点从NVD主控上删除
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_DelNode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_DelNode(int lLoginID, string pNodeId);

        //修改NVD主控上的某个节点
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_ModifyNode",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_ModifyNode(int lLoginID, string pNodeId, ref ZLNET_NVD_NODE pNode);

        //获取NVD主控上所有节点的状态
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetNodeState",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_GetNodeState(int lLoginID, ref ZLNET_NVD_ALLNODE_STATE pState, int nTimeOut = 3000);

        //操作节点的当前主控, lLoginID:节点的登陆句柄，即需要单独登陆节点, nOper:0获取 1设置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_OperateParent",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_OperateParent(int lLoginID, int nOper, ref ZLNET_NVD_PARENT pParent);

        //----------------------------------NVD屏幕拼接------------------------------
        //获取NVD显示输出配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetVideoOutCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_GetVideoOutCfg(int lLoginID, ref ZLNET_NVD_VIDEOOUT_CFG pCfg, int nTimeOut = 3000);

        //设置NVD显示输出配置
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetVideoOutCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetVideoOutCfg(int lLoginID, ref ZLNET_NVD_VIDEOOUT_CFG pCfg, int nTimeOut = 3000);

        //NVD显示输出显示名称，pMonitorID为ZLNET_NVD_GetVideoOutCfg取得，填NULL表示所有
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_VideoOutShowName",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_VideoOutShowName(int lLoginID, string pMonitorID, int bShow);

        //NVD获取虚拟屏(电视墙)配置，nWall为预留字段目前无效
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetMatrixCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_GetMatrixCfg(int lLoginID, int nWall, ref ZLNET_NVD_MATRIX_CFG pCfg, int nTimeOut = 3000);

        //NVD设置虚拟屏(电视墙)，nWall为预留字段目前无效
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetMatrixCfg",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetMatrixCfg(int lLoginID, int nWall, ref ZLNET_NVD_MATRIX_CFG pCfg, int nTimeOut = 3000);

        //----------------------------------NVD上墙控制------------------------------
        //NVD自由开窗,pRect为指定窗口位置，nWnd为返回窗口号,nZorder为返回窗口Z轴序
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_OpenWindow",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_OpenWindow(int lLoginID, string pScreenID, ref ZLNET_RECT pRect, IntPtr nWnd, IntPtr nZorder);

        //NVD单窗口发送视频
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetWindowPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetWindowPlay(int lLoginID, string pScreenID, int nWnd, ref ZLNET_NVD_VIDEO_SRC pSrc);

        //NVD获取某窗口视频
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetWindowPlay",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_GetWindowPlay(int lLoginID, string pScreenID, int nWnd, ref ZLNET_NVD_VIDEO_SRC pSrc);

        //NVD移动窗口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_MoveWindow",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_MoveWindow(int lLoginID, string pScreenID, int nWnd, ref ZLNET_RECT pRect);

        //NVD关闭窗口
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_CloseWindow",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_CloseWindow(int lLoginID, string pScreenID, int nWnd);

        //NVD设置顶层窗
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetTopWindow",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetTopWindow(int lLoginID, string pScreenID, int nWnd);

        //NVD视频上墙,单场景，常用于同步控制
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetScene",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_SetScene(int lLoginID, string pScreenID, ref ZLNET_NVD_SCENE pScene);

        //NVD获取当前场景
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetScene",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_GetScene(int lLoginID, string pScreenID, ref ZLNET_NVD_SCENE pScene);

        //NVD监视计划，多场景轮巡；可一次设置多个计划，pPlan为首地址指针，nPlanNum为个数,为0则清空计划
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_SetPlan",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pPlan对应结构体ZLNET_NVD_PLAN
        public static extern int ZLNET_NVD_SetPlan(int lLoginID, string pScreenID, IntPtr pPlan, int nPlanNum = 1, int nTimeout = 3000);

        //NVD获取监视计划
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_GetPlan",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        //pPlan对应结构体ZLNET_NVD_PLAN
        public static extern int ZLNET_NVD_GetPlan(int lLoginID, string pScreenID, IntPtr pPlan, int nMaxGetNum, IntPtr nRetNum, int nTimeout = 3000);

        //场景切换，常用于计划上墙后手动临时控制, nCmd: 0暂停轮巡 1继续轮巡 2切换至下个场景 3切换至上个场景
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_TourControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_TourControl(int lLoginID, string pScreenID, int nCmd);

        //获取轮巡暂停状态(bPaused)
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_NVD_IsTourPaused",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_NVD_IsTourPaused(int lLoginID, string pScreenID, ref int bPaused);

        /////////////////////////////////////人脸比对/////////////////////////////////////

        //-----------------------------人员组相关-----------------------------
        // 增加组
        // pGroup[in]:要新增的组，szGroupID无效，szName必须填写
        // pGroupID[out]:ID由设备生成后返回,不需要获取可填NULL
        // nBufLen[in]:pGroupID缓存大小
        // return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_AddGroup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_AddGroup(int lLoginID, ref ZLNET_FACE_GROUP pGroup, string pGroupID, int nBufLen = 0, int nTimeout = 5000);

        // 获取所有组信息
        // pBuf[out]:      缓存,数组,例如 pBuf = new ZLNET_FACE_GROUP[nBufNum]
        // nBufNum[in]:    缓存可容纳个数
        // nRetNum[out]:   pBuf或nBufNum为0时用于获取总共有多少个，否则表示本次取到多少个
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_GetAllGroups",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_GetAllGroups(int lLoginID, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeout = 5000);

        // 获取单个组信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_GetGroup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_GetGroup(int lLoginID, string pGroupID, ref ZLNET_FACE_GROUP pBuf, int nTimeout = 5000);

        // 修改组(只能修改名称、阈值、备注）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ModifyGroup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ModifyGroup(int lLoginID, ref ZLNET_FACE_GROUP pGroup, int nTimeout = 5000);

        // 删除组
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_DelGroup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_DelGroup(int lLoginID, string pGroupID);

        //-----------------------------人员信息相关-----------------------------
        // 增加人员基础信息
        // pGroupID[in]:   要加入的组
        // pInfo[in]:      要新增的人员
        // pPersonID[out]: ID由设备生成后返回,不需要获取可填NULL
        // nBufLen[in]:    pPersonID缓存大小
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_AddPerson",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_AddPerson(int lLoginID, string pGroupID, ref ZLNET_FACE_PERSONINFO pInfo, string pPersonID, int nBufLen = 0, int nTimeout = 5000);

        // 修改人员基础信息
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ModifyPerson",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ModifyPerson(int lLoginID, string pPersonID, ref ZLNET_FACE_PERSONINFO pInfo, int nTimeout = 5000);

        // 删除人员（将同时删除其人脸图）
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_DelPerson",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_DelPerson(int lLoginID, string pPersonID);

        // 按指定条件获取人员信息
        // pCond[in]:      条件
        // pBuf[out]:      缓存,数组,例如 pBuf = new ZLNET_FACE_PERSON[nBufNum]
        // nBufNum[in]:    缓存可容纳ZLNET_FACE_PERSON的个数
        // nRetNum[out]: pBuf或nBufNum为0时用于获取总共有多少个，否则表示本次取到多少个
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_GetPersonByCond",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_GetPersonByCond(int lLoginID, ref ZLNET_FACE_PERSON_COND pCond, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeout = 5000);

        // 按分组获取人员信息
        // pGroupID[in]:   组ID
        // nBegin[in]:     起始下标，从0开始，利用此参数实现顺序遍历
        // pBuf[in]:       缓存，数组,例如 pBuf = new ZLNET_FACE_PERSON[nBufNum]
        // nBufNum[in]:    缓存可容纳ZLNET_FACE_PERSON的个数
        // nRetNum[out]: 实际返回个数，当小于nBufNum时说明已经遍历完成
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_GetPersonByGroup",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_GetPersonByGroup(int lLoginID, string pGroupID, int nBegin, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeout = 5000);

        //-----------------------------人脸图相关-----------------------------
        // 增加人脸图
        // pPersonID[in]:  图片对应的人员ID
        // pData[in]:      图片数据或文件路径，JPG格式，建议分辨率720P，大小300KB以下
        // nDataLen[in];   pData的长度
        // pImage[out]:    入库成功返回的一些信息，包含图片ID等，如不需要可填NULL
        // nTimeout[in]:   超时时间，毫秒，由于本接口速度与设备性能相关，建议5000
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_AddFaceImage",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_AddFaceImage(int lLoginID, string pPersonID, IntPtr pData, int nDataLen, ref ZLNET_FACE_FACEIMAGE pImage, int nTimeout = 5000);

        // 获取人脸图
        // pImageID[in]:图片ID
        // pBuf[in]:图片数据缓存
        // nBufLen[in]:缓存大小
        // nRetLen[out]:返回实际大小
        // return:成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_GetFaceImage",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_GetFaceImage(int lLoginID, string pImageID, IntPtr pBuf, int nBufLen, ref int nRetLen);

        // 删除人脸图
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_DelFaceImage",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_DelFaceImage(int lLoginID, string pImageID);

        //-----------------------------批量配置相关-----------------------------

        // 导出(从设备下载)人脸库数据
        // pParam[in]:     参数
        // cbDown[in]:     回调函数
        // return:         导出句柄 <=0 为失败，成功后需调用ZLNET_FACE_ExportControl开始
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ExportData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ExportData(int lLoginID, ref ZLNET_FACE_TRANSPORT_PARAM pParam, fDownLoadFileCallBack cbDown, IntPtr dwUser);

        // 导出数据时的控制
        // nHandle[in]:    导出句柄,ZLNET_FACE_ExportData的返回值
        // nControl[in]:   命令 0停止 1开始
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ExportControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ExportControl(int nHandle, int nControl);

        // 导入(上传到设备)人脸库数据
        // pParam[in]:     参数
        // cbUp[in]:       回调函数
        // return:         导入句柄 <=0 为失败，成功后需调用ZLNET_FACE_ImportControl开始
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ImportData",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ImportData(int lLoginID, ref ZLNET_FACE_TRANSPORT_PARAM pParam, fUploadFilePosCallBack cbUp, IntPtr dwUser);

        // 导入数据时的控制
        // nHandle[in]:    导入句柄,ZLNET_FACE_ImportData的返回值
        // nControl[in]:   命令 0停止 1开始
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ImportControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ImportControl(int nHandle, int nControl);

        // 批量扫描添加
        // pParam[in]:     参数
        // cbUp[in]:       回调函数
        // return:         句柄 <=0 为失败，成功后需调用ZLNET_FACE_BatchAddControl开始
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_BatchAdd",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_BatchAdd(int lLoginID, ref ZLNET_FACE_BATCH_ADD_PARAM pParam, fUploadFilePosCallBack cbUp, IntPtr dwUser);

        // 批量添加的控制
        // nHandle[in]:    操作句柄,ZLNET_FACE_BatchAdd的返回值
        // nControl[in]:   命令 0停止 1开始
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_BatchAddControl",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_BatchAddControl(int nHandle, int nControl);

        //-----------------------------比对搜索相关-----------------------------

        // 搜索比对历史开始
        // pCond[in]:      搜索条件
        // nTimeout[in];   超时时间
        // return:         <=0表示失败，>0为搜索句柄，用于ZLNET_FACE_SearchNext及ZLNET_FACE_SearchEnd
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_SearchBegin",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_SearchBegin(int lLoginID, ref ZLNET_FACE_SEARCH_COND pCond, int nTimeout = 3000);

        // 搜索比对历史
        // lHandle[in]:    搜索句柄,ZLNET_FACE_SearchBegin的返回值
        // pBuf[in]:       结果缓存，数组,例如 pBuf = new ZLNET_FACE_MATCH_RESULT[nBufNum]
        // nBufNum[in]:    pBuf可容纳ZLNET_FACE_MATCH_RESULT的个数
        // nRetNum[out]:   实际返回个数，当小于nBufNum时说明已经取完
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_SearchNext",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_SearchNext(int lHandle, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeout = 6000);

        // 搜索比对历史结束
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_SearchEnd",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_SearchEnd(int lHandle);

        // 以图搜人（手动图片比对）
        // lLoginID[in]:   设备登陆句柄
        // pData[in]:      图片数据
        // nDataLen[in]:   图片数据长度
        // pBuf[out]:      返回比中人员，数组,例如 pBuf = new ZLNET_FACE_PERSON[nBufNum]
        // nBufNum[in]:    pBuf可容纳ZLNET_FACE_PERSON的个数
        // nRetNum[out]:   实际返回个数，0说明未比中
        // return:         成功TRUE 失败FALSE
        [DllImport(ProgConstants.c_strZLVideoFilePath, EntryPoint = "ZLNET_FACE_ImageMatch",
        CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int ZLNET_FACE_ImageMatch(int lLoginID, IntPtr pData, int nDataLen, IntPtr pBuf, int nBufNum, ref int nRetNum, int nTimeout = 3000);

        #endregion
    }
}
