/****************************************************\
*	Copyright (c) 成都华迈通信技术有限公司版权所有	*
*													*
*	文件名称 : hm_sdk.h								*
*	当前版本 : 2.1									*
*	编写目的 : 提供二次开发需要的函数接口之声明		*
*	首次完成日期 : 2013-12-16						*
\****************************************************/
#ifndef __HM_SDK_H__
#define __HM_SDK_H__

typedef const char*			cpchar;
typedef char*				pchar;
typedef void*				pointer;
typedef const void*			cpointer;
typedef signed char			int8;
typedef unsigned char		uint8;
typedef signed short		int16;
typedef unsigned short		uint16;
typedef signed int			int32;
typedef unsigned int		uint32;
typedef long long			int64;
typedef unsigned long long	uint64;
typedef float				real32;
typedef double				real64;
typedef uint32				hm_result;					//	返回错误码类型
typedef pointer				window_handle;				//	窗口句柄，仅在Windows平台下有效
typedef pointer				user_id;					//	登陆设备的返回值
typedef pointer				video_handle;				//	实时视频句柄
typedef pointer				audio_handle;				//	实时音频句柄
typedef pointer				talk_handle;				//	对讲句柄
typedef pointer				alarm_handle;				//	报警句柄
typedef pointer				alarm_host_handle;			//	报警句柄
typedef pointer				record_handle;				//	手动录像句柄
typedef pointer				find_file_handle;			//	录像查找句柄
typedef pointer				playback_handle;			//	录像回放句柄
typedef pointer				get_file_handle;			//	下载录像句柄	
typedef pointer				find_picture_handle;		//	图片查找句柄
typedef pointer				get_picture_handle;			//	下载图片句柄	
typedef pointer				search_wifi_handle;			//	获取wifi信息句柄
typedef pointer				get_online_user_handle;		//	获取在线用户句柄
typedef pointer				upgrade_handle;				//	升级句柄
typedef pointer				server_id;					//	连接平台的返回值
typedef pointer				tree_handle;				//	设备树句柄
typedef pointer				node_handle;				//	设备句柄
typedef pointer				audio_codec_handle;			//	音频编解码句柄
typedef pointer				video_codec_handle;			//	视频解码句柄
typedef pointer				yuv_handle;					//	yuv句柄
typedef pointer				bitmap_handle;				//	位图句柄
typedef pointer				audio_capture_handle;		//	音频数据采集句柄
typedef pointer				audio_player_handle;		//	音频播放句柄
typedef pointer				local_record_handle;		//	本地录像句柄
typedef pointer				local_playback_handle;		//	本地音频句柄
typedef	pointer				lan_device_search_handle;	//	局域网设备搜索句柄
typedef pointer 			push_service_handle;		//	推送服务句柄
typedef pointer				port_handle;				//	端口句柄，仅在Windows平台下有效
typedef pointer				listen_handle;				//	监听句柄，用于设备反向连接
typedef pointer				get_handle;					//	迭代句柄
typedef pointer				user_data;					//	用户数据

#define hm_stdcall
#define hm_cdecl
#define hm_fastcall
#define hm_call

#define OPERATION_TIMEOUT 20000

/****************\
*	错误码定义	*
\****************/
typedef enum _HM_ERROR_CODE
{
	HMEC_OK							= 0,			//	成功

	HMEC_GEN_SDK_INIT				= 0x01000001,	//	SDK初始化失败
	HMEC_GEN_CREATE_HANDLE,							//	创建句柄错误
	HMEC_GEN_PARAM_INVALID,							//	参数无效
	HMEC_GEN_NODE_INVALID,							//	节点无效
	HMEC_GEN_URL_INVALID,							//	URL无效
	HMEC_GEN_FIND_FILE_OVER,						//	文件查询完毕
	HMEC_GEN_VIDEO_PLAYER_INIT,						//	初始化视频播放器失败
	HMEC_GEN_INIT_LISTEN,							//	初始化监听器失败
	HMEC_GEN_START_LISTEN,							//	监听失败
	HMEC_GEN_NOT_SUPPORT,							//	接口不被支持
	HMEC_GEN_INTERNAL,								//	内部错误

	HMEC_ERR_UTIL_INIT				= 0x00A00001,	//	初始化失败
	HMEC_ERR_UTIL_FILE_INVALID,						//	文件无效
	HMEC_ERR_UTIL_FILE_NOT_OPEN,					//	打开文件失败
	HMEC_ERR_UTIL_FILE_READ_FAIL,					//	读取文件失败
	HMEC_ERR_UTIL_FILE_WRITE_FAIL,					//	写入文件失败
	HMEC_ERR_UTIL_FILE_CREATE,						//	创建录像文件失败
	HMEC_ERR_UTIL_RECORD_STOP,						//	停止录像
	HMEC_ERR_UTIL_END_OF_FILE,						//	文件读取完毕
	HMEC_ERR_UTIL_PARAM_INVALID,					//	参数无效
	HMEC_ERR_UTIL_IP_NOT_FOUND,						//	IP未识别
	HMEC_ERR_UTIL_SEND_MODE,						//	错误的发送模式
	HMEC_ERR_UTIL_NOT_SUPPORT_IN_MODE,				//	当前模式下不支持该命令

	HMEC_ERR_PU_UNDEF				= 0x00800001,	//	未定义错误
	HMEC_ERR_PU_BUSY,								//	设备忙
	HMEC_ERR_PU_BAD_PARAM,							//	错误的参数
	HMEC_ERR_PU_BAD_FORMAT,							//	错误的格式
	HMEC_ERR_PU_INTERNAL,							//	内部错误
	HMEC_ERR_PU_UNREG_CMD,							//	不能识别的命令
	HMEC_ERR_PU_MAX_CONNECTION,						//	最大连接数限制
	HMEC_ERR_PU_NOT_LOGIN,							//	未认证
	HMEC_ERR_PU_BAD_USER,							//	错误的用户名
	HMEC_ERR_PU_UNSUPPORT,							//	不支持的参数，比如对讲格式等
	HMEC_ERR_PU_DISK_NOT_EXIST,						//	存储介质不存在
	HMEC_ERR_PU_DISK_FULL,							//	磁盘满
	HMEC_ERR_PU_CHANNEL_USED,						//	通道忙
	HMEC_ERR_PU_CHANNEL_CLOSED,						//	当前通道已关闭
	HMEC_ERR_PU_CHANNEL_ERR,						//	错误的通道号
	HMEC_ERR_PU_OPERATION_ABORT		= 0x00800050,	//	操作中断
	HMEC_ERR_PU_READ_LESS_LENGTH,					//	获取的数据长度太小
	HMEC_OPERATION_TIMEOUT,							//	操作超时
	HMEC_ERR_PU_NONSUPPORT,							//	未能支持的操作或者协议不完整
	HMEC_ERR_PU_SEND_DATA_INVALID,					//	发送数据无效
	HMEC_ERR_PU_NR_ERROR,							//	中转或穿透失败
	HMCE_ERR_PU_GET_STATUS_ERROR,					//	获取报警声音状态失败

	HMEC_ERR_SERVER_NETWORK			= 0x00700001,	//	网络错误
	HMEC_ERR_SERVER_COMMAND,						//	命令错误
	HMEC_ERR_SERVER_USER_OR_PWD,					//	用户名或密码错误
	HMEC_ERR_SERVER_NOT_AUTH,						//	未认证
	HMEC_ERR_SERVER_ALREADY_LOGIN,					//	重复登录
	HMEC_ERR_SERVER_GET_GROUP_LIST,					//	获取分组失败
	HMEC_ERR_SERVER_GET_DEVICE_LIST,				//	获取设备列表失败
	HMCE_ERR_SERVER_GET_DEVICE,						//	获取设备信息失败
	HMEC_ERR_SERVER_GET_SERVER_TIME,				//	获取服务器时间失败
	HMEC_ERR_SERVER_GET_USER_INFO,					//	获取用户信息失败
	HMEC_ERR_SERVER_GET_TRANSFER_INFO,				//	获取中转穿透信息失败
	HMEC_ERR_SERVER_GET_DEVICE_TRANSFER_CONFIG,		//	获取设备中转穿透配置失败
	HMEC_ERR_SERVER_BIND_DEVICE,					//	绑定设备失败
	HMEC_ERR_SERVER_UNBIND_DEVICE,					//	解绑设备失败
	HMEC_ERR_SERVER_DELETE_GROUP,					//	删除分组失败
	HMEC_ERR_SERVER_MOVE_GROUP,						//	移动分组失败
	HMEC_ERR_SERVER_USER_CANCEL,					//	用户取消操作
	HMEC_ERR_SERVER_REGUSR,							//	注册用户失败
	HMEC_ERR_SERVER_MODIFYPWD,						//	修改密码失败
	HMEC_ERR_SERVER_USER_ALREADY_EXIST,				//	用户名已存在
	HMEC_ERR_SERVER_USER_NOT_EXIST,					//	用户名不存在
	HMEC_ERR_SERVER_MOBILE_ERROR,					//	手机号码错误
	HMEC_ERR_SERVER_CAPTCHA_ERROR,					//	验证码错误
	HMEC_ERR_SERVER_CAPTCHA_EXPIRED,				//	验证码已过期
	HMEC_ERR_SERVER_NICKNAME_UESD,					//	昵称已被注册
	HMEC_ERR_SERVER_EMAIL_ERROR,					//	邮箱错误
	HMEC_ERR_SERVER_SM_UNAVAILABLE,					//	短信服务不可用
	HMEC_ERR_SERVER_USER_MOBILE_INCORRECT,			//	用户名手机号不匹配
	HMEC_ERR_SERVER_ERROR_MOBILE,					//	手机号码格式错误
	HMEC_ERR_SERVER_MOBILE_USED,					//	手机号已经被注册
	HMEC_ERR_SERVER_ERROR_PASSWORD,					//	密码格式不正确
	HMEC_ERR_SERVER_USER_EMAIL_INCORRECT,			//	用户名邮箱不匹配
	HMEC_ERR_SERVER_EMAIL_NOT_AUTH,					//	邮箱未认证
	HMEC_ERR_SERVER_EMAIL_SERV_UNAVAILABLE,			//	邮件服务不可用
	HMEC_ERR_SERVER_CANNOT_RESET_PWD,				//	无法用密码找回
	HMEC_ERR_SERVER_NO_GUARD_EMAIL,					//	没有密保邮箱
	HMEC_ERR_SERVER_NO_GUARD_MOBILE,				//	没有密保手机
	HMEC_ERR_SERVER_MOBILE_NOT_AUTH,				//	手机号未认证
	HMEC_ERR_SERVER_INTERNAL,						//	服务器内部错误
	HMEC_ERR_SERVER_SET_PRIVACY,					//	隐私设置失败
	HMEC_ERR_SERVER_GET_VERSION,					//	获取服务器版本失败
	HMEC_ERR_SERVER_UPDATE_PARAM,					//	升级参数错误
	HMEC_ERR_SERVER_UPDATE_HASH,					//	验证码错误
	HMEC_ERR_SERVER_UPDATE_PACKAGE,					//	无升级包
	HMEC_ERR_SERVER_GET_HISTORY_ERROR,				//	获取报警历史信息失败
	HMEC_ERR_SERVER_GET_HISTORY_UNREAD_COUNT_ERROR,	//	获取报警未读条数失败
	HMEC_ERR_SERVER_MARK_ALARM_HISTORY_READ_ERROR,	//	标记已读失败
	HMEC_ERR_SERVER_GET_ALARM_INFO_ERROR,			//	获取报警信息失败
	HMEC_ERR_SERVER_DELETE_ALARM_ERROR,				//	删除报警信息失败
	HMEC_ERR_SERVER_MARK_PARAM_ERROR,				//	参数不正确
	HMEC_ERR_SERVER_MARK_NO_ALARM,					//	没有找到报警
	HMEC_ERR_SERVER_SYS_NOTI_ERROR,					//	获取系统通知信息失败
	HMEC_ERR_SERVER_UPGRADE_USERNAME,				//	升级用户信息失败
	HMEC_ERR_SERVER_MAXERR,

	HMEC_ERR_VIDEO_FIND_DECODER		= 0x00300001,	//	未知解码类型
	HMEC_ERR_VIDEO_ALLOC_CONTEXT,					//	分配上下文失败
	HMEC_ERR_VIDEO_CODEC_OPEN,						//	打开解码器失败
	HMEC_ERR_VIDEO_ALLOC_FRAME,						//	分配存储空间失败
	HMEC_ERR_VIDEO_STATE_DECODING,					//	解码失败
	HMCE_ERR_VIDEO_STATE_ENCODING,					//	编码失败
	HMEC_ERR_VIDEO_PARAM,							//	解码参数错误
	HMEC_ERR_AUDIO_SPEEX_INIT,						//	音频SPEEX编解码库初始化失败
	HMEC_ERR_AUDIO_BUF_LEN			= 0x0030000A,	//	音频传出缓冲区大小不足以存放数据
	HMEC_ERR_AUDIO_FIND_DECODER,					//	音频解码类型错误
	HMEC_ERR_AUDIO_FIND_ENCODER,					//	音频编码类型错误
	HMEC_ERR_AUDIO_CAP_INIT,						//	音频采集初始化失败
	HMEC_ERR_AUDIO_CAP_ALREADY_INIT,				//	音频采集重复初始化
	HMEC_ERR_AUDIO_CAPING			= 0x00300010,	//	采集失败
	HMEC_ERR_AUDIO_PLAYER_CREATE,					//	音频播放器创建失败
	HMEC_ERR_AUDIO_PLAYER_ALREADY_INIT,				//	音频播放器重复初始化
	HMEC_ERR_AUDIO_PLAYER_UNKNOWN_TYPE,				//	未知音频类型
	HMEC_ERR_AUDIO_PLAYER_SET_COOP_LEVEL,			//	设置协作层失败
	HMEC_ERR_AUDIO_PLAYER_CREATE_BUF				//	分配存储空间失败
} HM_ERROR_CODE;

// 视频数据类型
typedef enum _VIDEO_ENCODE
{
	HME_VE_H264		= 1,
	HME_VE_MPEG4	= 2,
	HME_VE_H265		= 4,
} VIDEO_ENCODE;

// 音频数据类型
typedef enum _AUDIO_ENCODE
{
	HME_AE_NONE = -1,
	HME_AE_PCMS8 = 0,
	HME_AE_ARM,
	HME_AE_SPEEX,
	HME_AE_ADPCM,
	HME_AE_AAC,
	HME_AE_G711A,
	HME_AE_G711U,
} AUDIO_ENCODE;

typedef enum _ALARM_DEVICE_TYPE
{
	HME_ADT_VIDEO_DEV			=	0x00000001,	//	视频设备
	HME_ADT_GPIO_DEV			=	0x00000002,	//	GPIO设备
	HME_ADT_STORGE_DEV			=	0x00000004,	//	存储设备
	HME_ADT_REMOTECTRL_DEV		=	0x00000008,	//	遥控
	HME_ADT_MAGNETOMETER_DEV	=	0x00000010,	//	门磁
	HME_ADT_INFRARED_DEV		=	0x00000020,	//	红外
	HME_ADT_SMOKE_DEV			=	0x00000040,	//	烟感
	HME_ADT_COAL_DEV			=	0x00000080,	//	煤感
	HME_ADT_WATER_DEV			=	0x00000100,	//	水浸
	HME_ADT_QUAKE_DEV			=	0x00000200,	//	震动
	HME_ADT_PC_CLIENT			=	0x00000400,	//	PC客户端
	HME_ADT_PHONE_CLIENT		=	0x00000800,	//	手机客户端
	HME_ADT_WEB_PLUGIN			=	0x00001000,	//	网页插件 
	HME_ADT_KEEP_NIGHT_WATCH	=	0x00002000,	//	巡更
	HME_ADT_GUARDBAIL			=	0x00004000,	//	护栏
	HME_ADT_BOUNDARY			=	0x00008000,	//	周界
	HME_ADT_DANGER_BUTTON		=	0x00010000,	//	紧急按钮
	HME_ADT_PLATFORM_SERVER		=	0x00020000	//	平台服务器
} ALARM_DEVICE_TYPE;

typedef enum _ALARM_TYPE
{
	HME_AT_SENSOR				=	0x00000001,	//	传感器常规报警
	HME_AT_MOTION				=	0x00000002,	//	移动侦测
	HME_AT_VIDEO_OCCUSION		=	0x00000004,	//	视频遮挡
	HME_AT_VIDEO_LOSS			=	0x00000008,	//	视频丢失
	HME_AT_SD_FULL				=	0x00000010,	//	SD卡满
	HME_AT_SD_ERROR				=	0x00000020,	//	SD卡错误
	HME_AT_SD_NOTEXIST			=	0x00000040,	//	SD卡不存在
	HME_AT_ARM					=	0x00000080,	//	布防
	HME_AT_DISARM				=	0x00000100,	//	撤防
	HME_AT_EMERGENCY			=	0x00000200,	//	紧急
	HME_AT_POWER_LOW			=	0x00000400,	//	电量过低
	HME_AT_SENSOR_LOSS_HEART	=	0x00000800,	//	传感器心跳丢失
	HME_AT_SENSOR_REMOVED		=	0x00001000,	//	传感器拆除
	HME_AT_POWER_RESUME			=	0x00002000	//	电压恢复
} ALARM_TYPE;

//	打开视频
typedef enum _CODE_STREAM
{
	HME_CS_NONE		= -1,
	HME_CS_ULTRA_HD = 0,
	HME_CS_MAJOR	= 1,
	HME_CS_MINOR	= 2,
} CODE_STREAM;

typedef enum _VIDEO_STREAM
{
	HME_VS_NONE			= 0,
	HME_VS_REAL			= 1,
	HME_VS_PRERECORD	= 2
} VIDEO_STREAM;

//	云台控制命令
typedef enum _PTZ_COMMAND
{
	HME_PC_NONE			= 0,
	HME_PC_UP			= 1,	//	上转
	HME_PC_LEFT			= 2,	//	左转
	HME_PC_DOWN			= 3,	//	下转
	HME_PC_RIGHT		= 4,	//	右转
	HME_PC_FOCUSUP		= 7,	//	调焦 : 增
	HME_PC_FOCUSDOWN	= 8,	//	调焦 : 减
	HME_PC_ZOOMIN		= 9,	//	放大
	HME_PC_ZOOMOUT		= 10,	//	缩小
	HME_PC_APTSMALL		= 11,	//	光圈 : 减小
	HME_PC_APTBIG		= 12,	//	光圈 : 增大
	HME_PC_LIGHTON		= 13,	//	灯光开
	HME_PC_LIGHTOFF		= 14	//	灯光关
} PTZ_COMMAND;

typedef enum _PTZ_INTERVAL
{
	HME_PI_NONE		= 0,
	HME_PI_LR	    = 5,	//	左右巡航
	HME_PI_END		= 6,	//	停止巡航
	HME_PI_UDLR		= 19,	//	上下左右巡航
	HME_PI_UD	    = 20	//	上下巡航
} PTZ_INTERVAL;

// 节点类型
typedef enum _NODE_TYPE_INFO
{
	HME_NT_NONE = 0,
	HME_NT_DEVICE,		// 设备节点
	HME_NT_DVS,			// DVS节点
	HME_NT_GROUP,		// 分组节点
	HME_NT_CHANNEL		// 通道节点
} NODE_TYPE_INFO;

typedef enum _SEARCH_MODE
{
	HME_SM_NONE				= 0,
	HME_SM_BEG_AND_END_TIME	= 1,	
	HME_SM_MONTH			= 2,
} SEARCH_MODE;


//	录像查询，可以组合
typedef enum _VIDEO_RECORD
{
	HME_VR_NONE			= 0,
	HME_VR_HANDLER		= 1,
	HME_VR_ALARMTYPE	= 2,
	HME_VR_TIMER		= 4,
} VIDEO_RECORD;

typedef enum _REMOTE_PLAYBACK_MODE
{
	HME_PBM_NONE		= 0,
	HME_PBM_NAME_TIME	= 1,	//	根据文件名和文件播放时间回放
	HME_PBM_START_END	= 2,	//	从开始时间处开始回放到结束时间处为止
	HME_PBM_ALARM_KEY	= 3,	//	根据报警key搜索文件回放
	HME_PBM_DOWNLOAD    = 4,    //  下载远程录像不限速
} REMOTE_PLAYBACK_MODE;

//	图片相关操作
typedef enum _PIC_CAP_TYPE
{
	HME_PCT_NONE		= 0,
	HME_PCT_HANDLER		= 1,
	HME_PCT_ALARMTYPE	= 2,
	HME_PCT_TIMER		= 4,
} PIC_CAP_TYPE;

typedef enum _PIC_DOWNLOAD_MODE
{
	HME_PDM_NONE			= 0,
	HME_PDM_FILENAME		= 1,
	HME_PDM_START_END_TIME	= 2,
	HME_PDM_KEY				= 3
} PIC_DOWNLOAD_MODE;

typedef enum _RAW_FRAME_TYPE
{
	HME_RFT_P		= 0,
	HME_RFT_I		= 1,
	HME_RFT_AUDIO	= 2,
	HME_RFT_H265_P  = 0x20,
	HME_RFT_H265_I	= 0x21,
	HME_RFT_PCM		= 5,
	HME_RFT_SPEEX	= 6,
	HME_RFT_AAC		= 7,
	HME_RFT_ARM		= 8,
	HME_RFT_ADPCM	= 0xA,
	HME_RFT_G711A	= 0xB,
	HME_RFT_G711U	= 0xC,	
	HME_RFT_INFO	= 9, 
} RAW_FRAME_TYPE;

typedef enum _BITMAP_FORMAT
{
	HME_BF_NONE = 0,
	HME_BF_RGB32,
	HME_BF_BGR32,
	HME_BF_RGBA32,
	HME_BF_RGB16_565
} BITMAP_FORMAT;

//	用户管理
typedef enum _USER_ROLE
{
	HME_UR_MANAGER	=	3,	//	管理者
	HME_UR_OPERATOR	=	2,	//	操作者
	HME_UR_OBSERVER	=	1,	//	观察者
	HME_UR_VISITOR  =   0	//  访客
} USER_ROLE;

//	回放模式
typedef enum _PB_MODE
{
	HME_PM_NONE		= 0,
	HME_PM_ACTIVE	= 1,	//	主动模式
	HME_PM_PASSIVE	= 2		//	被动模式
} PB_MODE;

//	回放速率
typedef enum _PLAYBACK_RATE
{
	HME_PBR_NONE	= 0,	//	无效值
	HME_PBR_1X		= 1,	//	原始倍速
	HME_PBR_2X		= 2,	//	2倍速
	HME_PBR_4X		= 4,	//	4倍速
	HME_PBR_8X		= 8,	//	8倍速
	HME_PBR_S2X		= -2,	//	1/2倍速
	HME_PBR_S4X		= -4,	//	1/4倍速
	HME_PBR_S8X		= -8	//	1/8倍速
} PLAYBACK_RATE;

typedef enum _LAN_SEARCH_MODE
{
	HME_LSM_NONE	= 0,	//	无效值
	HME_LSM_BC		= 1,	//	广播搜索
	HME_LSM_MC		= 2		//	多播搜索
} LAN_SEARCH_MODE;

typedef enum _UPDATE_TYPE
{
	HME_UT_BOOTLOADER = 1,
	HME_UT_KERNEL,
	HME_UT_ROOTFS
} UPDATE_TYPE;

typedef enum _DISPLAY_MODE
{
	HME_DM_NONE = 0,
	HME_DM_DX,				//	DX模式显示
	HME_DM_VFW				//	VFW模式显示
} DISPLAY_MODE;

typedef enum _PIC_QUALITY
{
	HME_PQ_HIGH = 1,		//	高画质
	HME_PQ_LOW				//	低画质
} PIC_QUALITY;

typedef enum _DEV_PRIVACY
{
	HME_DP_NONE = -1,	//	无效值
	HME_DP_OFF  = 0,	//	隐私保护关
	HME_DP_ON			//	隐私保护开
} DEV_PRIVACY;

typedef enum _MATCH_SENSOR_RESULT
{
	MSR_UNKNOWN_RESULT,
	MSR_SUCCUSS,
	MSR_NOT_LEARN_MOD,
	MSR_NO_SENSOR	
} MATCH_SENSOR_RESULT;

//	客户端类型
typedef enum _CLIENT_TYPE
{
	CT_MOBILE	= 0,	//	移动
	CT_PC		= 1,	//	PC
	CT_PLUGIN	= 2,	//	插件
	CT_PLAT		= 3,	//	平台
	CT_PU		= 10	//	设备
} CLIENT_TYPE;

//	连接模式，支持与操作
typedef enum _CONNECT_MODE
{
	CM_DIR		= 1,	//	仅直连
	CM_NAT		= 2,	//	仅穿透
	CM_RLY		= 4,	//	仅中转
	CM_DEF		= 7		//	默认（直连、穿透和中转同时连接）
} CONNECT_MODE;

//	连接优先级
typedef enum _CONNECT_PRI
{
	CPI_DIR	= 1,		//	直连优先
	CPI_NAT	= 2,		//	穿透优先
	CPI_RLY	= 3,		//	中转优先
	CPI_DEF	= 4			//	默认优先级（直连 = 穿透 > 中转）
} CONNECT_PRI;

#pragma pack(push)
#pragma pack(1)

typedef void (hm_call * cb_pu_net) (user_data data, hm_result result, uint32 connect_type);
typedef struct _FRAME_INFO
{
	uint16	channel;			//	通道号 0、1、2…
	uint16	data_type;			//	流类型 1-实时 2-预录 3-回放
	uint16	stream_type;		//	码流类型 1-主码流 2-次码流 3-三码流
	uint16	frame_type;			//	帧类型 0-P帧(H264) 1-I帧(H264) 0x20-P帧(H265) 0x21-I帧(H265) 3-参数变化帧 5-PCM音频帧 6-SPEEX音频帧 7-AAC音频帧 9-信息帧
	uint64	absolute_timestamp;	//	时间戳，单位毫秒
} FRAME_INFO, *P_FRAME_INFO;

typedef struct _FRAME_DATA
{
	FRAME_INFO frame_info;
	uint32     frame_len;		//	数据流长度
	cpointer   frame_stream;	//	数据
} FRAME_DATA, *P_FRAME_DATA;

//	DVS通道能力，单个设备（对应1个通道，通道号为0）
typedef struct _CHANNEL_CAPACITY
{
	char	channel_name[260];			//	通道名称
	char	video_name[260];			//	视频名称
	bool	video_support;				//	视频支持
	bool	audio_support;				//	音频支持
	bool	talk_support;				//	对讲支持
	bool	ptz_support;				//	云台支持
	AUDIO_ENCODE audio_code_type;		//	音频编码
	int32	audio_sample;				//	采样率
	int32	audio_channel;				//	声道
} CHANNEL_CAPACITY, *P_CHANNEL_CAPACITY;

// 设备信息
typedef struct _DEVICE_INFO
{
	char	dev_name[260];		//	设备名称
	char	dev_type[64];		//	设备类型
	char	sn[14];				//	设备SN号
	int32	total_channel;		//	通道总数
	int32	alram_in_count;		//	报警输入通道数
	int32	alarm_out_count;	//	报警输出通道数
	int32	sensor_count;		//	传感器数量
	int32   support_third_stream; // 0:老设备 1:新设备支持三码流 2:新设备不支持三码流
	P_CHANNEL_CAPACITY  channel_capacity[64];	//	DVS通道能力，单个设备（对应1个通道，通道号为0）
} DEVICE_INFO, *P_DEVICE_INFO;

typedef void (hm_call * cb_pu_data) (user_data data, P_FRAME_DATA frame, hm_result result);
typedef struct _OPEN_VIDEO_PARAM
{
	uint32		 channel;
	CODE_STREAM  cs_type;
	VIDEO_STREAM vs_type;
	cb_pu_data   cb_data;
	window_handle wnd;
	user_data	 data;
} OPEN_VIDEO_PARAM, *P_OPEN_VIDEO_PARAM;

typedef struct _OPEN_VIDEO_RES
{
	uint32 channel;
	VIDEO_ENCODE encode_type;
	int32 image_width;
	int32 image_height;
	int32 fps;
	int64 basetime;
} OPEN_VIDEO_RES, *P_OPEN_VIDEO_RES;

//	打开音频输入参数
typedef struct _OPEN_AUDIO_PARAM
{
	uint32 channel;
	cb_pu_data cb_data;
	user_data  data;
} OPEN_AUDIO_PARAM, *P_OPEN_AUDIO_PARAM;

//	打开音频响应
typedef struct _OPEN_AUDIO_RES
{
	uint32			channel;
	AUDIO_ENCODE	audio_type;
	int32			sample;
	int32			audio_channel;
} OPEN_AUDIO_RES, *P_OPEN_AUDIO_RES;

//	打开对讲输入参数
typedef struct _OPEN_TALK_PARAM
{
	uint32			channel;
	AUDIO_ENCODE	audio_type;
	int32			sample;
	int32			audio_channel;
} OPEN_TALK_PARAM, *P_OPEN_TALK_PARAM;

//	手动抓取图片输入参数
typedef struct _REMOTE_CAPTURE_PIC_PARAM
{
	uint32 channel;
} REMOTE_CAPTURE_PIC_PARAM, *P_REMOTE_CAPTURE_PIC_PARAM;

//	报警信息
typedef struct _ALARM_INFO
{
	int32	alarm_dev_type;
	int32	alarm_type; 
	int32	channel;
	int32	area_id;
	char	key[512];
	char	sn[14];
	char	dev_name[260];
	char	happen_time[25];
	char	content[1024];
	char	expand[1024];
	char	hash[32];
} ALARM_INFO, *P_ALARM_INFO;

// OSD 信息
typedef struct _OSD_INFO
{
	int32	position_x;
	int32   position_y; 
	cpchar  font_name;
	int32   font_heigth; 
	int32   font_width;
	int32   text_color;
	cpchar	context;
	bool    isShow;
} OSD_INFO, *P_OSD_INFO;

typedef void (hm_call * cb_pu_alarm) (user_data data, P_ALARM_INFO alarm_info, hm_result result);
typedef	struct OPEN_ALARM_PARAM_
{
	cb_pu_alarm cb_alarm;
	user_data	data;
} OPEN_ALARM_PARAM, *P_OPEN_ALARM_PARAM;

//	防区信息
typedef	struct AREA_INFO_PARAM_
{
	char	area_name[260];
	uint32	area_id;
	uint32	emergency;
	uint32	channel;
} AREA_INFO_PARAM, *P_AREA_INFO_PARAM;

//	传感器信息
typedef	struct SENSOR_INFO_PARAM_
{
	char	sensor_name[260];
	char	sensor_id[260];
	char	sensor_type[260];
	char	area_id[260];
} SENSOR_INFO_PARAM, *P_SENSOR_INFO_PARAM;

//	获取配对到的传感器回应
typedef struct MATCH_SENSOR_RES_
{
	MATCH_SENSOR_RESULT  result;
	char	sensor_id[260];
	char	sensor_type[260];
} MATCH_SENSOR_RES, *P_MATCH_SENSOR_RES;

//  wifi搜索
typedef struct _WIFI_INFO
{
	char	ssid_name[260];	//	wifi名称
	uint8	wifi_mode;
	uint8	is_encrypt;		//	是否加密 
	uint8	encrypt_type;	//	加密类型：1(WEP64)、2(WEP128)、3(TKIP)、4(AES)	
	uint8	key_type;		//	密码类型：0(16进制)、1(ASICC)
} WIFI_INFO, *P_WIFI_INFO;

typedef void (hm_call * cb_pu_wifi) (user_data data,  WIFI_INFO wifi_info);
typedef struct _QUERY_WIFI_PARAM
{
	cb_pu_wifi	cb_wifi;
	user_data	data;
} QUERY_WIFI_PARAM, *P_QUERY_WIFI_PARAM;

typedef struct _FIND_FILE_PARAM
{
	uint32			channel;
	int32			record_type;		//	录像类型 1-手动录像 2-报警录像 4-定时录像，允许按位或
	SEARCH_MODE		search_mode;		//	查询方式 1-根据开始时间，结束时间查找对应文件 2-根据SearchTime按月查询，SearchTime(查询时间)格式为"2012-08"
	char			start_time[25];		//	时间格式形如"2009-09-29 13:50:32"
	char			end_time[25];		//	同上
	char			search_month[10];
} FIND_FILE_PARAM, *P_FIND_FILE_PARAM;

typedef struct _FIND_FILE_DATA
{
	char			start_time[25];
	char			end_time[25];
	char			file_name[260];
	VIDEO_RECORD	record_type;
} FIND_FILE_DATA, *P_FIND_FILE_DATA;

typedef struct _DELETE_RECORD_FILE_PARAM
{
	int32	channel;
	char	file_name[260];
} DELETE_RECORD_FILE_PARAM, *P_DELETE_RECORD_FILE_PARAM;

//	视频回放信息
typedef void (hm_call * cb_pu_playback_data) (user_data data, bool over, P_FRAME_DATA frame, hm_result);
typedef struct _PLAYBACK_PARAM
{
	uint32			channel;
	REMOTE_PLAYBACK_MODE play_mode;
	char			file_name[260];
	uint64			play_time;
	uint64			start_time;
	uint64			end_time;
	char			key[512];
	int32			frame_type;
	cb_pu_playback_data	cb_data;
	window_handle	wnd;
	user_data		data;
} PLAYBACK_PARAM, *P_PLAYBACK_PARAM;

typedef struct _PLAYBACK_RES
{
	uint32	video_format;
	uint32	video_fps;
	uint32	video_width;
	uint32	video_height;
	int32	audio_format;
	uint32	audio_channel;
	uint32	audio_sample;
	uint64	continuous_time;
} PLAYBACK_RES, *P_PLAYBACK_RES;

// 录像下载请求
typedef void (hm_call * cb_pu_download_file)(user_data data, cpointer file_data, uint32 len, hm_result result);
typedef struct _GET_FILE_PARAM
{
	uint32	channel;
	char	file_name[260];
	int32	offset;
	cb_pu_download_file cb_data;
	user_data	data;
} GET_FILE_PARAM, *P_GET_FILE_PARAM;

typedef struct _GET_FILE_RES
{
	char	file_name[260];
	uint32	file_size;
	char	md5[33];
} GET_FILE_RES, *P_GET_FILE_RES;

typedef struct _FIND_PICTURE_PARAM
{
	uint32			channel;
	int32			cap_type;
	SEARCH_MODE		search_mode;
	char			search_month[10];
	char			start_time[25];		//	[查询开始时间格式：%04d-%02d-%02d %02d: %02d: %02d，如 2009-09-29 13:50:32]
	char			end_time[25];		//	[查询结束时间格式：%04d-%02d-%02d %02d: %02d: %02d，如 2009-09-29 13:55:32]
} FIND_PICTURE_PARAM, *P_FIND_PICTURE_PARAM;

typedef struct _FIND_PICTURE_DATA
{
	char			file_name[260];
	int64			file_size;
	PIC_CAP_TYPE	cap_type;
	char			cap_time[25];
} FIND_PICTURE_DATA, *P_FIND_PICTURE_DATA;

//	照片删除
typedef struct  _DELETE_PICTURE_PARAM
{
	uint32	channel;
	char	file_name[260];
} DELETE_PICTURE_PARAM, *P_DELETE_PICTURE_PARAM;

//	图片下载
typedef struct _DOWNLOAD_PIC_INFO
{
	uint32	file_serial;
	uint32	file_size;
	uint64	abs_timestamp;
	char	file_name[40];
} DOWNLOAD_PIC_INFO, *P_DOWNLOAD_PIC_INFO;

typedef void (hm_call * cb_pu_download_picture)(user_data, P_DOWNLOAD_PIC_INFO, cpointer, uint32, int32);
typedef struct _GET_PICTURE_PARAM
{
	uint32		channel;
	char		file_name[260];
	PIC_DOWNLOAD_MODE download_mode;
	uint64		start_time;
	uint64		end_time;
	char		key[512];
	cb_pu_download_picture cb_data;
	user_data	data;
} GET_PICTURE_PARAM, *P_GET_PICTURE_PARAM;

typedef struct _GET_PICTURE_RES
{
	uint32 file_count;
} GET_PICTURE_RES, *P_GET_PICTURE_RES;

//	upnp 检测
typedef struct _DETECT_UPNP
{
	uint8	result;
	uint16	port;
	uint8	on_line;
} DETECT_UPNP, *P_DETECT_UPNP;

//	系统信息
typedef struct _NETWORK_INFO
{
	int32	dhcp;
	char	network_card[30];
	char	link_state[4];
	char	ip[20];
	char	mask[20];
	char	gate_way[20];
} NETWORK_INFO, *P_NETWORK_INFO;

typedef struct _PT_SYSTEM_INFO
{
	char sn[14];
	char soft_version[30];
	char hard_version[30];
	P_NETWORK_INFO pei[10];
	char	dns_addr[10][20];
	int32	mode_3g;
	int32	status_3g;
	int32	device_on3g;
	int32	service_3g;
	int32	vendor_3g;
	int32	online_time3g;
	int32	online_count3g;
	int32	upnp;
	int32	ext_port;
	char	plt_url[20];
	uint16	plt_port;
	int32	log_in_ret;
	int32	eddns;
	int32	ddns_status;
	int32	sd_status;
	uint32	sd_size;
	uint32	sd_free_size;
	real64	sd_persent;
	char	time[25];
	char	hd_date[25];
	int32	runtime;
	real64	free_percent;
	int32	check_key;
	int32	region;
	int32	spt_platform;
	int32	ver_limit;
} PT_SYSTEM_INFO, *P_PT_SYSTEM_INFO;

//	升级请求
typedef void (hm_call * cb_pu_upgrade_firm)(user_data data, uint32 flag, hm_result result);
typedef struct _HARD_UPDATE_PARAM
{
	cpchar file_cont;
	uint32 file_size;
	user_data data;
	cb_pu_upgrade_firm cb_firm;
} HARD_UPDATE_PARAM, *P_HARD_UPDATE_PARAM;

//	用户在线信息
typedef struct _ONLINE_USER_DATA
{
	char	user_name[260];
	char	ip[20];
	char	log_time[25];
	uint32	online_time;
} ONLINE_USER_DATA, *P_ONLINE_USER_DATA;

//	视频参数
typedef struct _CONFIG_VIDEO
{
	int32		channel;		//	通道号
	int32		fps;			//	帧率
	int32		bitrate;		//	码流大小，16-4096
	CODE_STREAM	stream_type	;	//	码流类型 0-无效 1-主码流 2-次码流
	char		resolution[20];	//	分辨率 160*120，176*144，176*120，320*240，352*288，352*240，640*480，704*576，704*480，1280*720，1280*960 
} CONFIG_VIDEO, *P_CONFIG_VIDEO;

//	3G配置
typedef struct _CONFIG_3G
{
	int32	mode_3g;		//	3g拨号模式
	int32	service_3g;		//	3g服务商
	int32	offline_mode;	//	断线模式
	int32	time_out;		//	断线时长
	bool	limit_tel_mode;	//	电话号码限制
	char	limittel[20];	//	限制的电话号码
	char	sm_on_cmd[10];	//	上线指令
	char	sm_off_cmd[10];	//	下线指令
} CONFIG_3G, *P_CONFIG_3G;

//	网络
typedef struct _CONFIG_NET
{
	int32	dhcp_mode;				//	配置方式
	char	ip[20];					//	IP地址
	char	mask[20];				//	子网掩码
	char	gateway[20];			//	网关
	char	dns1[20];				//	DNS1
	char	dns2[20];				//	DNS2
	char	device_name[260];		//	主机名
	bool	is_open_wireless;		//	启用无线网络
	int32	wireless_dhcp_mode;		//	配置方式
	char	wireless_ip[20];		//	IP地址
	char	wireless_mask[20];		//	子网掩码
	char	wireless_gateway[20];	//	网关
	uint16  service_port;			//	服务器端口
	uint16	web_port;				//	web端口
	bool	is_open_nat;			//	NAT穿透
} CONFIG_NET, *P_CONFIG_NET;

//	DDNS
typedef struct _CONFIG_DDNS 
{
	bool	enable;			//	是否开启DDNS
	char	service[50];	//	服务商(如www.3322.org/dyndns.com)
	char	url[50];		//	域名
	char	user_name[260];	//	用户名
	char	password[260];	//	密码
} CONFIG_DDNS, *P_CONFIG_DDNS;

//	PPPOE
typedef struct _CONFIG_PPPOE 
{
	bool	is_open_pppoe;	//	开启PPPOE拨号
	char	user_name[260];	//	帐号
	char	password[260];	//	密码
	char	mode[20];		//	拨号方式
} CONFIG_PPPOE, *P_CONFIG_PPPOE;

//	upnp配置
typedef struct _CONFIG_UPNP
{
	int32	upnp_mode;		//	自动映射/手动映射
	int32	port;			//	映射端口号
	char	ip[20];			//	一般不需设置，当有多个外网IP出口时设置
} CONFIG_UPNP, *P_CONFIG_UPNP;

//	wifi配置
typedef struct _CONFIG_WIFI
{
	int32	network_type;		//	工作模式
	int32	auth_mode;			//	安全类型
	int32	encry_type;			//	编码类型
	int32   key_type;
	char	wap_name[260];		//	网络名称
	char	password[260];		//	网络密码
} CONFIG_WIFI, *P_CONFIG_WIFI;

//	视频编码参数设置
typedef struct _CONFIG_VIDEO_ENCODE 
{
	int32		channel;
	bool		enable_main;		//	开启主码流
	bool		enable_smooth_m;	//	开启平滑变动
	int32		fix_bit_m;			//	码率设置0:固定质量、1:固定码率
	int32		quality_m;			//	质量设置
	int32		qmax_m;				//	(0-51)
	int32		qmin_m;				//	(0-51)
	int32		bit_rate_m;			//	码流大小
	int32		width_m;			//	分辨率(width_m * height_m)
	int32		height_m;
	int32		framerate_m;		//	帧率(1-25)
	int32		frame_interval_m;	//	帧间隔(1-120)
	bool		enable_sec;			//	允许次码流
	bool		enable_smooth_s;	//	开启平滑变动
	int32		fix_bit_s;			//	码率设置0:固定质量、1:固定码率
	int32		quality_s;			//	质量设置
	int32		qmax_s;				//	(0-51)
	int32		qmin_s;				//	(0-51)
	int32		bit_rate_s;			//	码流大小
	int32		width_s;			//	分辨率(width_s * height_s)
	int32		height_s;
	int32		framerate_s;		//	帧率(1-25)
	int32		frame_interval_s;	//	帧间隔(1-120)
} CONFIG_VIDEO_ENCODE, *P_CONFIG_VIDEO_ENCODE;

//	音频编码设置
typedef struct _CONFIG_AUDIO_ENCODE
{
	int32	channel;
	bool	enable;				//	开启音频
	bool	enable_vbr;			//	是否开启可变编码率
	bool	enable_denoise;		//	是否开启噪音消除
	real64	volume;				//	音量
	int32	audio_channel;		//	通道
	int32	sample;				//	采样率(8K/16K)
	int32	format;				//	编码格式(speex/pcm)
	int32	quality;			//	编码质量(0-10)
	int32	audio_input;		//	音频输入源
	int32	bit_mode;
} CONFIG_AUDIO_ENCODE, *P_CONFIG_AUDIO_ENCODE;

//	OSD配置结构(nXPos、nYPos取值0-511)
typedef struct _OSD_STRING 
{
	bool		enable;
	int32		x_pos;
	int32		y_pos;
	char		osd_str[70];	//	叠加的字符串，总共不超过32byte的中文或英文
} OSD_STRING, *P_OSD_STRING;

typedef struct _OSD_BITRATE 
{
	bool		enable;
	int32		x_pos;
	int32		y_pos;
} OSD_BITRATE, *P_OSD_BITRATE;

typedef struct _OSD_TIME 
{
	bool		enable;
	int32		time_format;	//	时间格式 0(YY-MM-DD HH:MM:SS)、1(HH:MM:SS YY-MM-DD)
	int32		x_pos;
	int32		y_pos;
} OSD_TIME, *P_OSD_TIME;

typedef struct _CONFIG_OSD
{
	int32		channel;
	int32		front_color;	//	前景色
	int32		back_color;	
	int32		transp;			//	透明度
	OSD_STRING	osd_string1;
	OSD_STRING	osd_string2;
	OSD_BITRATE	osd_bitrate;
	OSD_TIME	osd_time;
} CONFIG_OSD, *P_CONFIG_OSDG;	

//	云台和图像配置
typedef struct _CONFIG_IMAGE_AND_PTZ
{
	int32		channel;
	//	图像参数设置
	int32		brightness;			//	亮度
	int32		contrast;			//	对比度
	int32		saturation;			//	饱和度
	int32		flip;				//	图像翻转
	int32		effects;			//	图像特效
	int32		scene;				//	场景
	bool		enable_night;		//	是否启用夜间模式
	//	云台的一些参数
	char		ptz_protocol[20];	//	云台协议			
	int32		baud_rate;		
	int32		addr;
	int32		reverse;
	int32		inout;
	int32		leftright;
	int32		updown;
} CONFIG_IMAGE_AND_PTZ, *P_CONFIG_IMAGE_AND_PTZ;

//	移动侦测区域配置
typedef struct _MOTION_AREA
{
	bool		enable;
	int32		left_top_x;
	int32		left_top_y;
	int32		right_bottom_x;
	int32		right_bottom_y;
	int32		threshold;
	int32		sensitivity;
} MOTION_AREA, *P_MOTION_AREA;

typedef struct _CONFIG_MOTION_AREA
{
	int32		channel;
	int32		frame_interval;		//	侦测时间间隔
	int32		sensitivity;		//	侦测灵敏度
	MOTION_AREA	area1;
	MOTION_AREA	area2;
	MOTION_AREA	area3;
} CONFIG_MOTION_AREA, *P_CONFIG_MOTION_AREA;

typedef struct _ARMING_TIME			//	布防(GPIO及移动侦测共用)
{
	char	start_time[25];			//	开始布防时间
	char	end_time[25];			//	结束布防时间
} ARMING_TIME, *P_ARMING_TIME;

typedef struct _ARMING_WEEK_TIME
{
	int32		week_day;			//	周几布防(多个选择采用或运算)
	ARMING_TIME	arming_time[3];		//	每天设置3个布防时段
} ARMING_WEEK_TIME, *P_ARMING_WEEK_TIME;

//	移动侦测时间配置
typedef struct _CONFIG_MOTION_TIME
{
	int32		 channel;
	bool		 enable;
	ARMING_WEEK_TIME  time;
} CONFIG_MOTION_TIME, *P_CONFIG_MOTION_TIME;

typedef struct _CONFIG_GPIO_TIME
{
	int32		channel;
	bool		enable;				//	容许报警
	bool		enable_pin;			//	容许pin信号输入
	int32		elect_level;		//	电平 常开、常闭
	ARMING_WEEK_TIME	time;
} CONFIG_GPIO_TIME, *P_CONFIG_GPIO_TIME;

//	报警策略（设置、获取）
typedef struct _CONFIG_ALARM_POLICY
{
	bool	enable_video_record;	//	联动录相使能
	uint32	record_time_long;		//	录相时间长度

	bool	enable_capture_image;	//	联动抓图使能
	uint32	capture_count;			//	抓拍次数
	uint32	capture_interval_time;	//	抓拍间隔时间

	uint32	enable_gpio_out;		//	报警端口输出
	uint32	gpio_time_long;			//	输出时长
	uint32	elect_level;			//	输出电频（常开、常闭）
	//	ftp
	bool	enable_ftp;				//	是否开启FTP上传
	uint32	ftp_start_time;			//	开始时间（0-24小时）
	uint32	ftp_end_time;			//	结束时间
	uint16	ftp_port;				//	端口号
	uint32	ftp_connect_mode;		//	连接模式（主动、被动）
	char	ftp_user_name[260];		//	用户名
	char	ftp_password[260];		//	用户密码
	char	ftp_ip[20];				//	FTP地址
	char	ftp_dir[260];			//	FTP上传目录
	//	mail
	bool	enable_email;			//	是否开启邮件发送功能
	bool	enable_send_cap;		//	是否开启抓图发送功能
	bool	enabl_email_auth;		//	是否开启服务器密码认证
	uint16	email_port;				//	发送邮件服务器端口
	uint32	email_interval;			//	发送邮件间隔时间
	char	email_from[50];			//	发件人
	char	email_to[50];			//	收件人
	char	email_user[260];		//	发件人用户名
	char	email_password[260];	//	发件人密码
	char	email_server[50];		//	邮件服务器地址
} CONFIG_ALARM_POLICY, *P_CONFIG_ALARM_POLICY;

//	定时录像配置
typedef struct _CONFIG_TIME_RECORD
{
	int32	channel;
	bool	enable;					//	是否开启定时录相
	bool	audio_record;			//	是否录制音频
	int32	check[7][24*4];			//	守时录相时间段
} CONFIG_TIME_RECORD, *P_CONFIG_TIME_RECORD;

typedef struct _USER_MANGER_INFO
{
	char		user_name[260];		//	用户名
	char		user_password[260];	//	密码
	USER_ROLE	user_perm;			//	用户权限
} USER_MANGER_INFO, *P_USER_MANGER_INFO;

typedef struct _CONFIG_USER_MANAGER
{
	bool enable;					//	是否开启用户验证
	USER_MANGER_INFO user_info[10];	//	最多支持设置10个用户
} CONFIG_USER_MANAGER, *P_CONFIG_USER_MANAGER;

//	时间设置
typedef struct _CONFIG_TIME
{
	int32	time_mode;				//	时间设置方式（1 手动设置，2 NTP）
	char	ntp_server[50];			//	NTP服务器
	char	cur_time[25];			//	当前时间
	char	time_zone[20];			//	时区设置
} CONFIG_TIME, *P_CONFIG_TIME;

//	sd卡容量
typedef struct _STORAGE_INFO
{
	uint64		total;				//	总容量
	uint64		free;				//	剩余容量
} STORAGE_INFO, *P_STORAGE_INFO;

//	获取预置位，自动巡航等信息
typedef struct _PREPOINT_INFO
{
	char	prepoint[64][260];		//	预置位
	uint32	cruise[4][16];			//	自动巡航设置点
	uint32	cruise_interval[4];		//	巡航时间间隔
	bool	curise_status;
} PREPOINT_INFO, *P_PREPOINT_INFO;

typedef struct _LOGIN_SERVER_INFO
{
	cpchar ip;						//	平台地址
	uint16 port;					//	平台端口
	cpchar user;					//	用户名
	cpchar password;				//	密码
	cpchar plat_type;				//	系统类型（pc，android，ios）
	cpchar hard_ver;				//	硬件版本（PC传CPU型号，手机平台传手机型号）
	cpchar soft_ver;				//	软件版本（如v1.0.0.1001）
	uint32 keep_time;				//	连接保持时间
} LOGIN_SERVER_INFO, *P_LOGIN_SERVER_INFO;

typedef struct _USER_INFO
{
	int32	id;
	cpchar	name;
	cpchar	nick_name;
	cpchar	tel;
	cpchar	mobile;
	cpchar	address;
	cpchar	reg_date;
	cpchar	last_login_date;
	cpchar  email;
	bool	email_valid;
	int32	actor;
	cpchar  role1;
	cpchar  role2;
	bool	use_alarm_service;
	int32	use_transfer_service;
} USER_INFO, *P_USER_INFO;

typedef struct _UPDATE_INFO
{
	char	pack_name[256];
	char	pack_ver[20];
	int32	importance;
	int32	pack_type;
	bool	force_update;
	char	release_date[20];
	char	release_notes[256];
	char	license[256];
	char	message[256];
	struct FILES
	{
		char file_name[256];
		char download_path[256];
	}* files;
	int32	file_count;
} UPDATE_INFO, *P_UPDATE_INFO;

typedef struct _CHANNEL_INFO
{
	int32	index;
	cpchar	name;
} CHANNEL_INFO, *P_CHANNEL_INFO;

typedef struct _BITMAP_INFO_HEADER
{
	uint32	biSize;
	int32	biWidth;
	int32	biHeight;
	uint16	biPlanes;
	uint16	biBitCount;
	uint32	biCompression;
	uint32	biSizeImage;
	uint32	biXPelsPerMeter;
	uint32	biYPelsPerMeter;
	uint32	biClrUsed;
	uint32	biClrImportant;
} BITMAP_INFO_HEADER, *P_BITMAP_INFO_HEADER;

typedef struct _BITMAP_INFO_HEADER_EX
{
	BITMAP_INFO_HEADER bih;
	uint32 mask[3];
} BITMAP_INFO_HEADER_EX, *P_BITMAP_INFO_HEADER_EX;

typedef struct YUV_PICTURE
{
	uint32	width;		//	图像宽度
	uint32	height;		//	图像高度
	uint32	ystripe;	//	Y通道每扫描行的数据宽度，字节单位
	uint32	ustripe;	//	U通道每扫描行的数据宽度，字节单位
	uint32	vstripe;	//	V通道每扫描行的数据宽度，字节单位
	uint8*	ydata;		//	Y通道数据
	uint8*	udata;		//	U通道数据
	uint8*	vdata;		//	V通道数据
} YUV_PICTURE, *P_YUV_PICTURE;

typedef struct DISPLAY_OPTION
{
	DISPLAY_MODE dm;
	PIC_QUALITY  pq;
} DISPLAY_OPTION, *P_DISPLAY_OPTION;

typedef struct _RAW_FRAME
{
	RAW_FRAME_TYPE	type;		//	数据帧类型
	uint32			time_stamp;	//	时间戳
	uint32			len;		//	数据帧长度
	uint8*			buf;		//	帧数据
	bool			hold;		//	数据帧对象拥有的数据块
} RAW_FRAME, *P_RAW_FRAME;

typedef struct _LOCAL_RECORD_PARAM
{
	char 			file_name[260];		//	录像路径和文件名
	uint32			ver;				//	录像主版本号
	uint32			subver;				//	录像次版本号
	uint64			time_cost;			//	录像时长
	VIDEO_ENCODE	video_fmt;
	uint32 			video_fps;
	uint32 			video_width;		//	视频宽
	uint32			video_height;		//	视频高
	AUDIO_ENCODE	audio_fmt;
	uint32			audio_channel;
	uint32			audio_sample;
	char			device_sn[68];		//	设备sn
	char			device_name[68];	//	设备名
	VIDEO_RECORD	record_type;
} LOCAL_RECORD_PARAM, *P_LOCAL_RECORD_PARAM;

typedef struct _LAN_DEVICE_SEARCH_RES
{
	uint16	port;
	char 	ip_addr[32];
	uint32	channel_count;
	int32	ip_status;
	uint32	update_status;
	char	device_name[64];
	char	device_type[64];
	char	device_sn[64];
	char	mac_addr[20];
	char	wifi_mac_addr[20];
	char	lot[40];
	char	version[40];
	char	murl_addr[40];
	char 	upnp_status[40];
	char	channel_name[260];
	char	device_key[64];
	char 	ip_real_addr[32];
} LAN_DEVICE_SEARCH_RES, *P_LAN_DEVICE_SEARCH_RES;

typedef struct _LAN_DEVICE_RESET_IP
{
	cpchar	device_sn;
	cpchar	conflict_ip;
	cpchar	expect_ip;
	cpchar	expect_mask;
	cpchar	expect_gateway;
} LAN_DEVICE_RESET_IP, *P_LAN_DEVICE_RESET_IP;

typedef void (hm_call * cb_util_lan_device_search) (user_data data, LAN_DEVICE_SEARCH_RES ldsr, hm_result result);
typedef struct _LAN_DEVICE_SEARCH_PARAM_INL
{
	LAN_SEARCH_MODE  search_mode;
	cpchar	host_ip;
	cpchar	host_mask;
	cpchar	host_gateway;
	uint32	auto_search_interval; 
	cb_util_lan_device_search  cb_search;
	user_data data;
} LAN_DEVICE_SEARCH_PARAM, *P_LAN_DEVICE_SEARCH_PARAM;

typedef struct _LAN_CONFIG_SN_INFO
{
	cpchar	device_ip;
	cpchar	device_mac;
	cpchar	device_wifimac;
	cpchar	device_sn;
} LAN_CONFIG_SN_INFO, *P_LAN_CONFIG_SN_INFO;

typedef struct _LAN_CONFIG_LOT_INFO
{
	cpchar	device_ip;
	cpchar	device_mac;
	cpchar	device_wifimac;
	cpchar	lot;
} LAN_CONFIG_LOT_INFO, *P_LAN_CONFIG_LOT_INFO;

typedef struct _LAN_CONFIG_UPDATE_INFO
{
	cpchar	device_ip;
	cpchar	device_mac;
	cpchar	device_wifimac;
	UPDATE_TYPE	update_type;
	cpchar	update_url;
	cpchar	update_md5;
} LAN_CONFIG_UPDATE_INFO, *P_LAN_CONFIG_UPDATE_INFO;

typedef struct _TOKEN_INFO
{
	cpchar	push_addr;
	uint16	port;
	cpchar	usrname;
	int32	device_type;
	cpchar	device_token;
	int32	for_all;
	int32	status;
	cpchar	time_stamp;
	cpchar	start_time;
	cpchar	end_time;
	cpchar	sn;
	cpchar	key;
	cpchar	sound;
} TOKEN_INFO, *P_TOKEN_INFO;

//	推送消息
typedef struct _PUSH_MSG
{
	char	alert[211];
	char	sn[14];
	uint32	channel;
	pchar	rsv;
} PUSH_MSG, *P_PUSH_MSG;

//	报警历史信息
typedef struct _ALARM_HISTORY_INFO
{
	char	m_id[50];
	char	m_image_url[512];
	char	m_content[1024];
	char	m_sn[14];
	char	m_devname[128];
	int32	m_state;
	char	m_date[20];
} ALARM_HISTORY_INFO, *P_ALARM_HISTORY_INFO;

//	系统通知信息
typedef struct _SYS_NOTI_INFO
{
	char	m_id[50];
	char	m_content[1024];
	char	m_title[512];
	char	m_date[20];
} SYS_NOTI_INFO, *P_SYS_NOTI_INFO;

//	回放数据
typedef struct _PLAYBACK_FRAME
{
	int32	ftype;	//	帧类型
	int32	flen;	//	帧长度
	uint64	fstamp;	//	时间戳
	pchar	buf;	//	帧数据，所有权归使用者
	bool	disp;	//	是否显示
} PLAYBACK_FRAME, *P_PLAYBACK_FRAME;

//	查询升级信息
typedef struct _QUERY_UPDATE_INFO
{
	int32	code;			//	授权验证结果：0-无需升级, 1-需要升级, 2-操作失败
	int32	force_update;	//	强制升级固件：0-否, 1-是
	char	desc[128];
	char	time_stamp[25];
	char	hash[128];
	struct FIRMWARE
	{
		char	name[256];
		char	version[128];
		char	devclass[128];
		char	hash[128];
		char	url[128];
		char	release_time[25];
		char	release_note[1024];
	} firmware;
} QUERY_UPDATE_INFO, *P_QUERY_UPDATE_INFO;

//	查询升级进度
typedef struct _QUERY_UPDATE_PROG
{
	int32	status;
	int32	prog;
	int32	err;
} QUERY_UPDATE_PROG, *P_QUERY_UPDATE_PROG;

//	设备信息（含分享信息）
typedef struct _DEVICE_INFO_NEW
{
	cpchar	id;
	cpchar	sn;
	cpchar	dev_name;
	cpchar	uri;
	cpchar	e_uri;
	cpchar	last_update;
	int32	media_type;
	cpchar	channel;
	bool	is_online;
	int32	share;
	int32	upgrade;
	cpchar	model;
	cpchar	hardware;
	cpchar	software;
	cpchar	login_key;
	cpchar	image_url;
	cpchar	desc;
	struct _TAGS
	{
		cpchar tag;
	}* p_tags[1024];
	int32	tag_count;
} DEVICE_INFO_NEW, *P_DEVICE_INFO_NEW;

typedef struct _DEVICE_SHARE
{
	char	id[128];
	char	tag[1024];
	char	desc[1024];
} DEVICE_SHARE, *P_DEVICE_SHARE;

typedef struct _PUSH_ALARM_INFO
{
	char	id[128];
	char	image_url[512];
	char	cont[1024];
	char	sn[14];
	char	dev_name[128];
	int32	state;
	char	data_time[64];
} PUSH_ALARM_INFO, *P_PUSH_ALARM_INFO;

typedef struct _CONNECT_INFO
{
	CLIENT_TYPE ct;		//	客户端类型
	CONNECT_PRI cp;		//	连接优先级
	int32 cm;			//	连接模式（CONNECT_MODE）
} CONNECT_INFO, *P_CONNECT_INFO;


// 中转穿透信息
typedef struct _TRANSFER_INFO
{
	cpchar				nat_server_1;
	int32				nat_server_port1;
	cpchar				nat_server_2;
	int32				nat_server_port2;
	cpchar				relay_server;
	int32				relay_port;
} TRANSFER_INFO,*P_TRANSFER_INFO;

#pragma pack(pop)

typedef void (hm_call * cb_pu_dev_connect)		(user_data data, user_id* uid, cpchar sn);
typedef void (hm_call * cb_audio_capture)		(user_data data, hm_result result, pointer buf, int32 len);
typedef void (hm_call * cb_util_playback)		(user_data data, P_PLAYBACK_FRAME frame);
typedef void (hm_call * cb_util_push_service)	(user_data data, hm_result result, P_PUSH_MSG msg);

#define HMCAPI
#ifdef __cplusplus
extern "C" {
#endif

/************************************************************************************************/
/*										初始化SDK												*/
/************************************************************************************************/
HMCAPI hm_result hm_sdk_init();
HMCAPI hm_result hm_sdk_uninit();

/************************************************************************************************/
/*										设备相关接口												*/
/************************************************************************************************/
//	登录/登出设备
HMCAPI hm_result hm_pu_login(cpchar ip, uint16 port, cpchar sn, cpchar user, cpchar pwd, CLIENT_TYPE ct, user_id* id);
HMCAPI hm_result hm_pu_login_ex(node_handle handle, P_CONNECT_INFO ci, user_id* id);

//增加hm_pu_login_ex_new接口
//device_info用到4个字段:uri,e_uri,sn,login_key;
//transfer_info用到六个字段
HMCAPI hm_result hm_pu_login_ex_new(P_DEVICE_INFO_NEW device_info,P_TRANSFER_INFO transfer_info, P_CONNECT_INFO ci, user_id* id);
HMCAPI hm_result hm_pu_login_flow_stat(node_handle handle, cpchar url, cpchar user, CLIENT_TYPE ct, user_id* id);
HMCAPI hm_result hm_pu_set_net_cb(user_id id, cb_pu_net cb, user_data data);
HMCAPI hm_result hm_pu_logout(user_id id);
HMCAPI hm_result hm_pu_get_device_info(user_id id, P_DEVICE_INFO device);

//	反向连接
HMCAPI hm_result hm_pu_listen_init(listen_handle* lh);
HMCAPI hm_result hm_pu_listen_set_user_info(listen_handle lh, cpchar* usr, cpchar* pwd, int32 count);
HMCAPI hm_result hm_pu_listen_set_callback(listen_handle lh, cb_pu_dev_connect cb, user_data data);
HMCAPI hm_result hm_pu_listen_open(listen_handle lh, cpchar ip, uint16 port);
HMCAPI hm_result hm_pu_listen_close(listen_handle lh);
HMCAPI hm_result hm_pu_listen_uninit(listen_handle lh);

//	视频
HMCAPI hm_result hm_pu_open_video(user_id id, P_OPEN_VIDEO_PARAM param, video_handle* handle);
HMCAPI hm_result hm_pu_start_video(video_handle handle, P_OPEN_VIDEO_RES res);
HMCAPI hm_result hm_pu_force_iframe(video_handle handle);
HMCAPI hm_result hm_pu_stop_video(video_handle handle);
HMCAPI hm_result hm_pu_close_video(video_handle handle);

//	音频
HMCAPI hm_result hm_pu_open_audio(user_id id, P_OPEN_AUDIO_PARAM param, P_OPEN_AUDIO_RES res, audio_handle* handle);
HMCAPI hm_result hm_pu_start_audio(audio_handle handle);
HMCAPI hm_result hm_pu_stop_audio(audio_handle handle);
HMCAPI hm_result hm_pu_close_audio(audio_handle handle);

//	对讲
HMCAPI hm_result hm_pu_open_talk(user_id id, P_OPEN_TALK_PARAM param, talk_handle* handle);
HMCAPI hm_result hm_pu_send_talk_data(talk_handle handle, P_FRAME_DATA frame);
HMCAPI hm_result hm_pu_start_talk(talk_handle handle);
HMCAPI hm_result hm_pu_stop_talk(talk_handle handle);
HMCAPI hm_result hm_pu_close_talk(talk_handle handle);

//	云台
HMCAPI hm_result hm_pu_ptz_control(user_id id, uint32 channel, PTZ_COMMAND ptz_cmd, int32 speed);
HMCAPI hm_result hm_pu_ptz_focus_up(user_id id, uint32 channel, int32 speed);
HMCAPI hm_result hm_pu_ptz_focus_down(user_id id, uint32 channel, int32 speed);
HMCAPI hm_result hm_pu_ptz_set_preset(user_id id, uint32 channel, uint8 index, cpchar preset_name);
HMCAPI hm_result hm_pu_ptz_clr_preset(user_id id, uint32 channel, uint8 index);
HMCAPI hm_result hm_pu_ptz_goto_preset(user_id id, uint32 channel, uint8 index);
HMCAPI hm_result hm_pu_ptz_cruise(user_id id, PTZ_INTERVAL type, uint32 channel, int32 speed);

//	报警
HMCAPI hm_result hm_pu_open_alarm(user_id id, P_OPEN_ALARM_PARAM param, alarm_handle* handle);
HMCAPI hm_result hm_pu_start_alarm(alarm_handle handle);
HMCAPI hm_result hm_pu_stop_alarm(alarm_handle handle);
HMCAPI hm_result hm_pu_close_alarm(alarm_handle handle);

//	报警声音开关
HMCAPI hm_result hm_pu_enable_alarm_sound(user_id id);
HMCAPI hm_result hm_pu_disable_alarm_sound(user_id id);
HMCAPI hm_result hm_pu_get_alarm_sound_status(user_id id, int32* status);

//	获取布防状态
HMCAPI hm_result hm_pu_get_arming_state(user_id id, bool* state);

//  布防和撤防
HMCAPI hm_result hm_pu_arming_area(user_id id, int32 area_id, cpchar expand);
HMCAPI hm_result hm_pu_disarming_area(user_id id, int32 area_id, cpchar expand);

//	操作防区
HMCAPI hm_result hm_pu_add_area(user_id id, P_AREA_INFO_PARAM param);
HMCAPI hm_result hm_pu_change_area(user_id id, P_AREA_INFO_PARAM param);
HMCAPI hm_result hm_pu_delete_area(user_id id, P_AREA_INFO_PARAM param);

//	操作传感器
HMCAPI hm_result hm_pu_add_sensor(user_id id, P_SENSOR_INFO_PARAM param);
HMCAPI hm_result hm_pu_change_sensor(user_id id, P_SENSOR_INFO_PARAM param);
HMCAPI hm_result hm_pu_delete_sensor(user_id id, P_SENSOR_INFO_PARAM param);

//	报警主机学习
HMCAPI hm_result hm_pu_open_alarm_host(user_id id, cb_pu_alarm cb_alarm, alarm_host_handle* handle);
HMCAPI hm_result hm_pu_start_learn(alarm_host_handle handle);
HMCAPI hm_result hm_pu_stop_learn(alarm_host_handle handle);
HMCAPI hm_result hm_pu_close_alarm_host(alarm_host_handle handle);

//	报警主机配对
HMCAPI hm_result hm_pu_get_match_sensor(user_id user, P_MATCH_SENSOR_RES res);

//	录像与回放
HMCAPI hm_result hm_pu_open_record(user_id id, int32 chn, record_handle* handle);
HMCAPI hm_result hm_pu_start_record(record_handle handle, uint32 channel);
HMCAPI hm_result hm_pu_stop_record(record_handle handle, uint32 channel);
HMCAPI hm_result hm_pu_close_record(record_handle handle);
HMCAPI hm_result hm_pu_find_file(user_id id, P_FIND_FILE_PARAM param, find_file_handle* handle);
HMCAPI hm_result hm_pu_find_next_file(find_file_handle handle, P_FIND_FILE_DATA data);
HMCAPI hm_result hm_pu_close_find_file(find_file_handle handle);
HMCAPI hm_result hm_pu_delete_record_file(user_id id, P_DELETE_RECORD_FILE_PARAM param);
HMCAPI hm_result hm_pu_open_playback(user_id id, P_PLAYBACK_PARAM param, P_PLAYBACK_RES res, playback_handle* handle);
HMCAPI hm_result hm_pu_start_playback(playback_handle handle);
HMCAPI hm_result hm_pu_stop_playback(playback_handle handle);
HMCAPI hm_result hm_pu_pause_playback(playback_handle handle);
HMCAPI hm_result hm_pu_resume_playback(playback_handle handle);
HMCAPI hm_result hm_pu_step_playback(playback_handle handle);
HMCAPI hm_result hm_pu_close_playback(playback_handle handle);

//	视频与图片下载
HMCAPI hm_result hm_pu_open_get_file(user_id id, P_GET_FILE_PARAM param, P_GET_FILE_RES res, get_file_handle* handle);
HMCAPI hm_result hm_pu_start_get_file(get_file_handle handle);
HMCAPI hm_result hm_pu_cancel_get_file(get_file_handle handle);
HMCAPI hm_result hm_pu_close_get_file(get_file_handle handle);
HMCAPI hm_result hm_pu_find_picture(user_id id, P_FIND_PICTURE_PARAM param, find_picture_handle* handle);
HMCAPI hm_result hm_pu_find_next_picture(find_picture_handle handle, P_FIND_PICTURE_DATA data);
HMCAPI hm_result hm_pu_close_find_picture(find_picture_handle handle);
HMCAPI hm_result hm_pu_delete_picture(user_id id, P_DELETE_PICTURE_PARAM param);
HMCAPI hm_result hm_pu_open_get_picture(user_id id, P_GET_PICTURE_PARAM param, P_GET_PICTURE_RES res, get_picture_handle* handle);
HMCAPI hm_result hm_pu_start_get_picture(get_picture_handle handle);
HMCAPI hm_result hm_pu_cancel_get_picture(get_picture_handle handle);
HMCAPI hm_result hm_pu_close_get_picture(get_picture_handle handle);

//	抓图
HMCAPI hm_result hm_pu_remote_capture_pic(user_id id, P_REMOTE_CAPTURE_PIC_PARAM param);

//  升级
HMCAPI hm_result hm_pu_open_upgrade(user_id id, P_HARD_UPDATE_PARAM param, upgrade_handle* handle);
HMCAPI hm_result hm_pu_start_upgrade(upgrade_handle handle);
HMCAPI hm_result hm_pu_send_upgrade_data(upgrade_handle handle, uint32 len, cpointer buf);
HMCAPI hm_result hm_pu_cancel_upgrade(upgrade_handle handle);
HMCAPI hm_result hm_pu_close_upgrade(upgrade_handle handle);
HMCAPI hm_result hm_pu_get_online_user(user_id id, get_online_user_handle* handle);
HMCAPI hm_result hm_pu_get_next_online_user(get_online_user_handle handle, P_ONLINE_USER_DATA data);
HMCAPI hm_result hm_pu_close_get_online_user(get_online_user_handle handle);
HMCAPI hm_result hm_pu_set_wifi_config(user_id user, P_CONFIG_WIFI config);
HMCAPI hm_result hm_pu_get_wifi_config(user_id user, P_CONFIG_WIFI config);
HMCAPI hm_result hm_pu_lock_device(user_id user, uint32 lock);
HMCAPI hm_result hm_pu_protect_privacy(user_id user, DEV_PRIVACY prot);

//  其他
HMCAPI hm_result hm_pu_reboot(user_id id);
HMCAPI hm_result hm_pu_open_search_wifi(user_id id, P_QUERY_WIFI_PARAM param, search_wifi_handle* handle);
HMCAPI hm_result hm_pu_set_wifi_callback(search_wifi_handle handle, cb_pu_wifi cb, user_data data);
HMCAPI hm_result hm_pu_start_search_wifi(search_wifi_handle handle);
HMCAPI hm_result hm_pu_close_search_wifi(search_wifi_handle handle);
HMCAPI hm_result hm_pu_detect_upnp(user_id id, P_DETECT_UPNP upnp);
HMCAPI hm_result hm_pu_format_sd(user_id id, uint8* format_result);
HMCAPI hm_result hm_pu_restore_default_config(user_id id, uint8* restore_result);
HMCAPI hm_result hm_pu_get_system_info(user_id id, P_PT_SYSTEM_INFO system_info);
HMCAPI hm_result hm_pu_get_system_info_opt(user_id id, P_PT_SYSTEM_INFO system_info);
HMCAPI hm_result hm_pu_time_sync(user_id id, uint32 time);
HMCAPI hm_result hm_pu_set_normal_config(user_id user, cpchar cfg);
HMCAPI hm_result hm_pu_get_normal_config(user_id user, cpchar cfg, pchar* msg);

//	获取连接信息
HMCAPI hm_result hm_pu_get_connect_type(user_id id, int32* ct);

//	PU通用协议
HMCAPI hm_result hm_pu_common_command(user_id id, int32 cmdid, cpchar cmdbody, pchar recv_buf, int32 buf_len);

//	设备自动升级
HMCAPI hm_result hm_pu_query_update_info(user_id id, P_QUERY_UPDATE_INFO ui);
HMCAPI hm_result hm_pu_update_start(user_id id);
HMCAPI hm_result hm_pu_update_stop(user_id id);
HMCAPI hm_result hm_pu_query_update_progress(user_id id, P_QUERY_UPDATE_PROG up);

/************************************************************************************************/
/*										平台相关接口												*/
/************************************************************************************************/
//	连接平台
HMCAPI hm_result hm_server_connect(P_LOGIN_SERVER_INFO lsi, server_id* hserver, pchar err, int32 err_len);
HMCAPI hm_result hm_server_disconnect(server_id server);

//	获取分组、设备列表、用户信息、中转穿透信息
HMCAPI hm_result hm_server_get_device_list(server_id server);
HMCAPI hm_result hm_server_get_user_info(server_id server, P_USER_INFO* uinfo);
HMCAPI hm_result hm_server_get_transfer_info(server_id server);
HMCAPI hm_result hm_server_get_time(server_id server, uint64* time);
HMCAPI hm_result hm_server_get_channel_info(node_handle channel, P_CHANNEL_INFO* cinfo);
HMCAPI hm_result hm_server_get_node_type(node_handle node, NODE_TYPE_INFO* tinfo);
HMCAPI hm_result hm_server_get_node_id(node_handle device, int32* id);
HMCAPI hm_result hm_server_get_node_guid(node_handle device, cpchar* guid);
HMCAPI hm_result hm_server_get_parent_id(node_handle device, int32* id);
HMCAPI hm_result hm_server_get_device_sn(node_handle device, cpchar* sn);
HMCAPI hm_result hm_server_get_device_url(node_handle device, cpchar* url);
HMCAPI hm_result hm_server_get_device_power(node_handle device, int64* power);
HMCAPI hm_result hm_server_get_device_image_url(node_handle device, cpchar* url);
HMCAPI hm_result hm_server_get_firmware_version(node_handle device, cpchar* ver);
HMCAPI hm_result hm_server_get_device_upgrade(node_handle device, int32* ug);
HMCAPI hm_result hm_server_get_device_description(node_handle device, cpchar* desc);
HMCAPI hm_result hm_server_get_device_policy(node_handle device, int32* policy);
HMCAPI hm_result hm_server_get_node_name(node_handle node, cpchar* name);
HMCAPI hm_result hm_server_get_last_update(node_handle device, uint64* update);
HMCAPI hm_result hm_server_update_device(server_id server, node_handle device);
HMCAPI hm_result hm_server_bind_device(server_id server, cpchar sn, cpchar pwd, int32* device_id);
HMCAPI hm_result hm_server_unbind_device(server_id server, int32 device_id);
HMCAPI hm_result hm_server_modify_device_name(server_id server, int32 device_id, cpchar new_name);
HMCAPI hm_result hm_server_add_group(server_id server, cpchar usrname, cpchar comment, int32 parent_id);
HMCAPI hm_result hm_server_change_device_group(server_id server, int32 device_id, int32 group_id);
HMCAPI hm_result hm_server_is_online(node_handle device, bool* is_online);
HMCAPI hm_result hm_server_get_share_status(node_handle device, int32* share);
HMCAPI hm_result hm_server_get_online_count(node_handle device, int32* online_cnt, int32* total_cnt);
HMCAPI hm_result hm_server_save_token(server_id server, P_TOKEN_INFO pti);
HMCAPI hm_result hm_server_user_exist(cpchar ip, uint16 port, cpchar usrname, bool* exist);
HMCAPI hm_result hm_server_register_user_with_mobile(cpchar ip, uint16 port, cpchar usrname, cpchar password, cpchar mobile, cpchar captcha);
HMCAPI hm_result hm_server_register_user_by_email(cpchar ip, uint16 port, cpchar usrname, cpchar password, cpchar email);
HMCAPI hm_result hm_server_request_mobile_captcha(cpchar ip, uint16 port, cpchar usrname, cpchar mobile);
HMCAPI hm_result hm_server_request_mobile_auth_captcha(cpchar ip, uint16 port, cpchar usrname, cpchar mobile);
HMCAPI hm_result hm_server_reset_password_by_email(cpchar ip, uint16 port, cpchar usrname, cpchar email);
HMCAPI hm_result hm_server_reset_password_by_mobile(cpchar ip, uint16 port, cpchar usrname, cpchar new_password, cpchar mobile, cpchar captcha);
HMCAPI hm_result hm_server_set_privacy(server_id server, cpchar sn, DEV_PRIVACY dp);
HMCAPI hm_result hm_server_get_privacy(server_id, cpchar sn, DEV_PRIVACY* dp);
HMCAPI hm_result hm_server_get_device_privacy_status(node_handle device, DEV_PRIVACY* dp);
HMCAPI hm_result hm_server_get_session_time_left(server_id server, int32* time);
HMCAPI hm_result hm_server_get_version(server_id server, cpchar* ver);
HMCAPI hm_result hm_server_get_update_info(cpchar ip, uint16 port, int32 ctype, cpchar ver, cpchar os, P_UPDATE_INFO pui);
HMCAPI hm_result hm_server_release_update_info(P_UPDATE_INFO pui);
HMCAPI hm_result hm_server_get_alarm_history(server_id server, cpchar start_time, cpchar end_time, int32 index);
HMCAPI hm_result hm_server_get_alarm_history_unread_count(server_id server, int32* count);
HMCAPI hm_result hm_server_mark_all_history_read(server_id server);
HMCAPI hm_result hm_server_mark_history_read(server_id server, cpchar id);
HMCAPI hm_result hm_server_get_alarm_history_count(server_id server, int32* count);
HMCAPI hm_result hm_server_get_alarm_history_at(server_id server, int32 index, P_ALARM_HISTORY_INFO ahi);
HMCAPI hm_result hm_server_get_system_notification_info(server_id server, cpchar start_time, cpchar end_time);
HMCAPI hm_result hm_server_get_system_notification_count(server_id server, int32* count);
HMCAPI hm_result hm_server_get_system_notification_at(server_id server, int32 index, P_SYS_NOTI_INFO sni);
HMCAPI hm_result hm_server_register_user_by_mobile(cpchar ip, uint16 port, cpchar mobile, cpchar nick_name, cpchar password, cpchar captcha);
HMCAPI hm_result hm_server_nick_name_exists(cpchar ip, uint16 port, cpchar nick_name, bool* exist);
HMCAPI hm_result hm_server_upgrade_user_name(server_id server, cpchar user_name, cpchar captcha);
HMCAPI hm_result hm_server_get_live_device_list(cpchar ip, uint16 port, int32 idx, cpchar tags, bool isOnline, get_handle* handle);
HMCAPI hm_result hm_server_get_live_device_count(get_handle handle, int32* count);
HMCAPI hm_result hm_server_get_live_device_at(get_handle handle, int32 idx, P_DEVICE_INFO_NEW din);
HMCAPI hm_result hm_server_get_live_device_share_status(server_id server, cpchar id, int32* share);
HMCAPI hm_result hm_server_release_get_handle(get_handle handle);
HMCAPI hm_result hm_server_cancel_live_device_share(server_id server, cpchar ids);
HMCAPI hm_result hm_server_update_live_device_share(server_id server, P_DEVICE_SHARE ds, int32 len);
HMCAPI hm_result hm_server_set_live_device(server_id server, P_DEVICE_SHARE ds, int32 len);
HMCAPI hm_result hm_server_feedback(server_id server, cpchar cont, cpchar phone_num, cpchar qq_num);
HMCAPI hm_result hm_server_get_alarm_info(server_id server, cpchar aid, P_PUSH_ALARM_INFO pai);
HMCAPI hm_result hm_server_delete_alarm_history(server_id server, cpchar aid);
HMCAPI hm_result hm_server_get_last_error_describe(server_id server, cpchar* err);

//	用户注册、密码修改
HMCAPI hm_result hm_server_register_user(cpchar ip, uint16 port, cpchar usrname, cpchar pwd);
HMCAPI hm_result hm_server_modify_password(server_id server, cpchar old_pwd, cpchar new_pwd);

//	设备树操作
HMCAPI hm_result hm_server_get_tree(server_id server, tree_handle* htree);
HMCAPI hm_result hm_server_get_root(tree_handle tree, node_handle* node);
HMCAPI hm_result hm_server_find_group_by_id(tree_handle tree, int32 id, node_handle* node);
HMCAPI hm_result hm_server_find_device_by_id(tree_handle tree, int32 id, node_handle* node);
HMCAPI hm_result hm_server_find_device_by_sn(tree_handle tree, cpchar sn, node_handle* node);
HMCAPI hm_result hm_server_release_tree(tree_handle tree);
HMCAPI hm_result hm_server_sort_in_node(tree_handle tree, node_handle node, int32 sm);
HMCAPI hm_result hm_server_filter_in_node(tree_handle tree, node_handle node, cpchar keywords);
HMCAPI hm_result hm_server_get_all_device_count(tree_handle tree, int32* count);
HMCAPI hm_result hm_server_get_all_device_at(tree_handle tree, int32 index, node_handle* node);
HMCAPI hm_result hm_server_get_children_count(node_handle device, int32* count);
HMCAPI hm_result hm_server_get_child_at(node_handle device, int32 index, node_handle* node);
HMCAPI hm_result hm_server_get_parent(node_handle device, node_handle* node);

//	通用接口（resp指针使用完毕后需调用 hm_mem_free 释放）
HMCAPI hm_result hm_server_common_command(server_id server, cpchar method, cpchar cmd, pchar* resp, int32* len);

/************************************************************************************************/
/*									编解码相关接口												*/
/************************************************************************************************/
//	音频编/解码
HMCAPI hm_result hm_audio_init(AUDIO_ENCODE type, audio_codec_handle* haudio);
HMCAPI hm_result hm_audio_decode(audio_codec_handle handle,
								 pointer des, int32* des_len,
								 pointer src, int32 src_len, int32 sample);
HMCAPI hm_result hm_audio_encode(audio_codec_handle handle,
								 pointer des, int32* des_len,
								 pointer src, int32 src_len, int32 sample);
HMCAPI hm_result hm_audio_uninit(audio_codec_handle handle);

//	音频采集接口仅支持Windows平台
HMCAPI hm_result hm_audio_capture_init(audio_capture_handle* handle);
HMCAPI hm_result hm_audio_capture_set_callback(audio_capture_handle handle, cb_audio_capture cb, user_data data);
HMCAPI hm_result hm_audio_capture_start(audio_capture_handle handle);
HMCAPI hm_result hm_audio_capture_stop(audio_capture_handle handle);
HMCAPI hm_result hm_audio_capture_uninit(audio_capture_handle handle);

//	音频播放接口仅支持Windows平台
HMCAPI hm_result hm_audio_player_init(audio_player_handle* handle,
												  window_handle wnd,
												  AUDIO_ENCODE audio_type, int32 sample /*= 8000*/, int32 chn_num /*= 1*/, int32 bitwidth /*= 16*/);
HMCAPI hm_result hm_audio_player_start(audio_player_handle handle);
HMCAPI hm_result hm_audio_player_stop(audio_player_handle handle);
HMCAPI hm_result hm_audio_player_insert_frame(audio_player_handle handle, cpchar buf, int32 len);
HMCAPI hm_result hm_audio_player_uninit(audio_player_handle handle);

//	视频解码
HMCAPI hm_result hm_video_init(VIDEO_ENCODE type, video_codec_handle* hvideo);
HMCAPI hm_result hm_video_decode_yuv(video_codec_handle handle, pointer video_data, int32 video_len, yuv_handle* yuv);
HMCAPI hm_result hm_video_decode_bitmap(video_codec_handle handle, pointer video_data, int32 video_len, BITMAP_FORMAT bf, bitmap_handle* bmp);
HMCAPI hm_result hm_video_encode_yuv420(video_codec_handle handle, cpointer dst, int32* dst_len, pointer src, int32 src_len, int32 width, int32 height, int32 bit_rate);
HMCAPI hm_result hm_video_release_yuv(yuv_handle handle);
HMCAPI hm_result hm_video_release_bitmap(bitmap_handle handle);
HMCAPI hm_result hm_video_yuv_2_rgb(yuv_handle handle, BITMAP_FORMAT bf, bitmap_handle* bmp);
HMCAPI hm_result hm_video_get_yuv_data(yuv_handle handle, P_YUV_PICTURE yuv_pic);
HMCAPI hm_result hm_video_get_bitmap_data(bitmap_handle handle, uint32* len, cpchar* data);
HMCAPI hm_result hm_video_get_bitmap_file_data(bitmap_handle handle, uint32* len, cpchar* data);
HMCAPI hm_result hm_video_get_bitmap_info(bitmap_handle handle, P_BITMAP_INFO_HEADER* hinfo);
HMCAPI hm_result hm_video_reset(video_codec_handle handle);
HMCAPI hm_result hm_video_uninit(video_codec_handle handle);

/************************************************************************************************/
/*									视频显示相关接口												*/
/************************************************************************************************/
//	视频显示（接口不关心数据来源，只负责显示）
HMCAPI hm_result hm_video_display_open_port(window_handle hwnd, P_DISPLAY_OPTION disp_option, port_handle* port);
HMCAPI hm_result hm_video_display_start(port_handle port, int32 vw /*= 0*/, int32 vh /*= 0*/, int32 fps /*= 25*/);
HMCAPI hm_result hm_video_display_input_data(port_handle port, cpointer video_data, int32 len, bool bDisp /*= true*/);
HMCAPI hm_result hm_video_display_stop(port_handle port);
HMCAPI hm_result hm_video_display_get_buffer_size(port_handle port, int32* size);
HMCAPI hm_result hm_video_display_capture(port_handle port, cpchar path, BITMAP_FORMAT bf);
HMCAPI hm_result hm_video_display_close_port(port_handle port);

/************************************************************************************************/
/*									内存释放相关接口												*/
/************************************************************************************************/
//	内存释放
HMCAPI hm_result hm_mem_free(pointer p);

/************************************************************************************************/
/*							本地视频录像/回放/抓图相关接口										*/
/************************************************************************************************/
//	本地录像
HMCAPI hm_result hm_util_local_record_init(P_LOCAL_RECORD_PARAM param, local_record_handle* hrecord);
HMCAPI hm_result hm_util_local_record_write(local_record_handle handle, P_FRAME_DATA frame, uint32* time_cost);
HMCAPI hm_result hm_util_local_record_uninit(local_record_handle hrecord);

//	本地回放（主、被动模式）
HMCAPI hm_result hm_util_local_playback_init(P_LOCAL_RECORD_PARAM param, local_playback_handle* hplayback, PB_MODE pbm);
HMCAPI hm_result hm_util_local_playback_get_one_frame(local_playback_handle hplayback, P_PLAYBACK_FRAME frame);
HMCAPI hm_result hm_util_local_playback_set_callback(local_playback_handle hplayback, cb_util_playback cb, user_data data);
HMCAPI hm_result hm_util_local_playback_start(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_stop(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_pause(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_resume(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_get_rate(local_playback_handle hplayback, PLAYBACK_RATE* rate);
HMCAPI hm_result hm_util_local_playback_set_rate(local_playback_handle hplayback, PLAYBACK_RATE rate);
HMCAPI hm_result hm_util_local_playback_get_position(local_playback_handle hplayback, real64* pos);
HMCAPI hm_result hm_util_local_playback_set_position(local_playback_handle hplayback, real64 pos);
HMCAPI hm_result hm_util_local_playback_step_forward(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_step_backward(local_playback_handle hplayback);
HMCAPI hm_result hm_util_local_playback_uninit(local_playback_handle hplayback);

//	本地抓图
HMCAPI hm_result hm_util_local_capture(cpchar path, yuv_handle handle, BITMAP_FORMAT bf);

/************************************************************************************************/
/*							局域网设备搜索相关接口												*/
/************************************************************************************************/
HMCAPI hm_result hm_util_lan_device_search_init(P_LAN_DEVICE_SEARCH_PARAM param, lan_device_search_handle* handle);
HMCAPI hm_result hm_util_lan_device_search_query(lan_device_search_handle handle);
HMCAPI hm_result hm_util_lan_device_search_reset_ip(lan_device_search_handle handle, P_LAN_DEVICE_RESET_IP param);
HMCAPI hm_result hm_util_lan_device_search_config_sn(lan_device_search_handle handle, P_LAN_CONFIG_SN_INFO sn);
HMCAPI hm_result hm_util_lan_device_search_config_update(lan_device_search_handle handle, P_LAN_CONFIG_UPDATE_INFO info);
HMCAPI hm_result hm_util_lan_device_search_config_lot(lan_device_search_handle handle, P_LAN_CONFIG_LOT_INFO lot);
HMCAPI hm_result hm_util_lan_device_search_uninit(lan_device_search_handle handle);

/************************************************************************************************/
/*							推送相关接口（仅安卓平台）											*/
/************************************************************************************************/
HMCAPI hm_result hm_util_push_service_init(cpchar addr, uint16 port, cpchar token, push_service_handle* handle);
HMCAPI hm_result hm_util_push_service_start(push_service_handle handle);
HMCAPI hm_result hm_util_push_service_set_callback(push_service_handle handle, cb_util_push_service cb, user_data data);
HMCAPI hm_result hm_util_push_service_stop(push_service_handle handle);
HMCAPI hm_result hm_util_push_service_uninit(push_service_handle handle);

#ifdef __cplusplus
}
#endif

#endif	//	__HM_SDK_H__
