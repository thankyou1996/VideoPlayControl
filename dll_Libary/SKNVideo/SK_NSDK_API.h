#pragma once

#ifdef _WIN32
#define DLLIMPORT       extern "C" __declspec(dllimport)
#elif (defined linux)
#include <stdio.h>
#include <unistd.h>

typedef void* HWND;
#define DLLIMPORT      __attribute__((visibility("default")))
#define CALLBACK
#endif


#define TALK_MODE_LISTEN        0x01 // 客户端监听 -> 设备上行码流
#define TALK_MODE_SPEAK         0x02 // 客户端喊话 -> 客户下行码流
#define TALK_MODE_FULL          (TALK_MODE_LISTEN | TALK_MODE_SPEAK)
#define MAX_DEVICE_INFO_SUM		65535
#define CD_GUID_LEN				30

/**********************************************************/
//						事件定义
/**********************************************************/
#define SDK_EVENT_CALL_KEY_PRESS			0x01 // 呼叫按钮被按下
#define SDK_EVENT_BAT_LOW					0x02 // 电池欠压
#define SDK_EVENT_BAT_HIGH					0x03 // 电池过压
#define SDK_EVENT_AC_COME					0x04 // 市电来电
#define SDK_EVENT_AC_LOSE					0x05 // 市电掉电
#define SDK_EVENT_PWR_ON					0x06 // 本机启动
#define SDK_EVENT_CALL_START				0x07 // 呼叫开始
#define SDK_EVENT_CALL_END					0x08 // 呼叫结束
#define SDK_EVENT_CALL_FAIL					0x09 // 呼叫失败
#define SDK_EVENT_DURE_CORE_ERR				0x0a // 防区模块故障
#define SDK_EVENT_3G_LOST					0x0b // 3G信号丢失
#define SDK_EVENT_CALL_GO_ON				0x0c // 呼叫继续
#define SDK_EVENT_FC_ALARM					0x0d // 面板被拆
#define SDK_EVENT_FC_RECOVER				0x0e // 面板被拆恢复
#define SDK_EVENT_HEART_BEAT				0x0f // 心跳包
#define SDK_EVENT_LOST_LINK_ALARM			0x10
#define SDK_EVENT_LOST_LINK_RECOVER			0x11
#define SDK_EVENT_VIDEO_LOST				0x12 // 视频丢失
#define SDK_EVENT_VIDEO_RECOVER				0x13 // 视频丢失
#define SDK_EVNET_FAST_SNAP_FINE			0x14 // 抓图成功
#define SDK_EVENT_FAST_SNAP_TIMEOUT			0x15 // 抓图失败
#define SDK_EVNET_FAST_SNAP_DONE			0x16 // 
#define SDK_EVENT_TALK_KEY_PRESS			0x17 // 呼叫按钮被按下
#define SDK_EVENT_FQ_KEY_PRESS              0x18
#define SDK_EVENT_READ_FINGER_TEMPLATE		0x19 // 指纹模板上传
#define SDK_EVENT_PASSTHROUGH				0x1b // 透传事件给服务器和客户端
#define SDK_EVENT_REMOTE_UPGRADE			0x20
#define SDK_EVENT_DEVICE_VERISON			0x21
#define SDK_EVENT_GET_RECORD_MAP            0x22 // 获取录像映射表
#define SDK_EVENT_REMOTE_UPGRADE_OK			0x23
#define SDK_EVENT_POWER_UP_OK				0x24
#define SDK_EVENT_STD_ERR                   0x25 // 标准错误
#define SDK_EVENT_FINGER_PRESS				0x26
#define SDK_EVENT_FINGER_REBOOT				0x27
#define SDK_EVENT_ECL_MAIN_EVENT            0x28 // 门锁事件
#define SDK_EVENT_CARD_SWAP_EVENT			0x29
#define SDK_EVENT_NET_SWITCH_CHANGE			0x2a
#define SDK_EVNET_NET_LAN_FAULT				0x2b
#define SDK_EVNET_NET_LAN_RECOVER			0x2c
#define SDK_EVENT_CARD_LIST_UPDATE			0x2d
#define SDK_EVENT_DOOR_STATES				0x2e
#define SDK_EVENT_DOUBLE_FINGER_PRESS		0x2f

#define SDK_EVENT_MOTION_DECT				0x40
#define SDK_EVENT_HDD_ERR					0x41
#define SDK_EVENT_HDD_REC					0x42

#define SDK_EVENT_REVIDEO_POST_DONE			0x43
#define SDK_EVENT_FQ_ALARM                  0x44
#define SDK_EVENT_ATD		                0x45
#define SDK_EVENT_ILLEGAL_OPEN_DOOR			0x97
#define SDK_EVENT_DOOR_OPEN_TIMOUT			0x98
#define SDK_EVENT_TALK_KEY_RELEASE			0x99


/* 精简版设备信息 */
typedef struct
{
	/// 设备临时分配ID号
	unsigned int		client_id;
	/// 设备全球唯一标识码
	unsigned char		guid[CD_GUID_LEN];
	/// 设备是否在线
	unsigned char		online;
	/// 设备是否交换信息完毕，处于可用状态
	unsigned char		ready;
	int					last_online_time;
}client_info_lite;

/* 精简版设备信息列表 */
typedef struct
{
	/// 设备信息结构体列表
	client_info_lite	client_info[MAX_DEVICE_INFO_SUM];
	/// 设备在线个数
	unsigned int		client_online;
	/// 总的在线设备个数，包含了未在线个数
	unsigned int		client_all;
}client_info_all;

typedef void(CALLBACK *p_msg_callback)(int      msg_id,
									   const char *msg_info,  
                                       int      arg1,
                                       int      arg2,
                                       void     *data1,  
                                       int      data1_len,  
                                       void     *data2, 
                                       int      data2_len);

typedef void(CALLBACK *p_rt_video_callback)(const char* guid,
									   int		chnn,
									   int		sub_chn,
									   int		encode_type,  
									   int		timestamp,  
									   int		length, 
									   void*	data);


/**
  * ***********************************************************************
  * @brief  客户端和服务器通用注册回调函数
  *         
  * @param  msg_callback: 回调函数接口指针
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_ALL_regeist_msg_callback(p_msg_callback msg_callback);

/**
  * ***********************************************************************
  * @brief	打开调试窗口
  *
  * @retval void:  返回为空
  *
  * @attention     无
  * ***********************************************************************
  */
DLLIMPORT
void SDK_NSK_ALL_open_console(void);

/**
  * ***********************************************************************
  * @brief	关闭调试窗口
  *
  * @retval void:  返回为空
  *
  * @attention     无
  * ***********************************************************************
  */
DLLIMPORT
void SDK_NSK_ALL_close_console(void);

/*******************************************************************************
**               ____  _____ ______     _______ ____  
**              / ___|| ____|  _ \ \   / / ____|  _ \
**              \___ \|  _| | |_) \ \ / /|  _| | |_) |
**               ___) | |___|  _ < \ V / | |___|  _ < 
**              |____/|_____|_| \_\ \_/  |_____|_| \_\
**  
*******************************************************************************/

/**
  * ***********************************************************************
  * @brief  初始化服务器SDK
  *         
  * @param  sdk_port:               本地监听端口，默认为48624
  * @param  sdk_xml_cfg_full_path:  SDK配置文件存储路径
  * @param  default_save_file_dir:  SDK存储文件根路径
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_init(int sdk_port, const char *sdk_xml_cfg_full_path, const char *default_save_file_dir);

/**
  * ***********************************************************************
  * @brief  反初始化服务器SDK
  *         
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_deinit(void);

/**
  * ***********************************************************************
  * @brief	获取连接到服务器的设备是否处于在线状态
  *			
  * @param  device_guid:        设备GUID
  *
  * @retval int: @arg -1 : 设备不存在
  *              @arg  0 : 设备不在线
  *              @arg  1 : 设备在线
  * @confirm	: 
  * @attention	: 如果无需判断设备是否曾经连接过服务器，则忽略-1，当成0即可
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_get_device_online(char *device_guid);

/**
  * ***********************************************************************
  * @brief	获取连接到服务器的所有设备状态
  *			
  * @param  device_guid:        设备数组
  *
  * @confirm	: 
  * @attention	: 
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_get_device_info_all(client_info_all* info_array);

/**
  * ***********************************************************************
  * @brief	设置码流超时(实时视频,回放视频,对讲)
  *			
  * @param  device_guid:        设备数组
  *
  * @confirm	: 
  * @attention	: 
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_set_stream_timeout(int timeout);

/*******************************************************************************
**                    ____ _     ___ _____ _   _ _____
**                   / ___| |   |_ _| ____| \ | |_   _|
**                  | |   | |    | ||  _| |  \| | | |
**                  | |___| |___ | || |___| |\  | | |
**                   \____|_____|___|_____|_| \_| |_|
**
*******************************************************************************/

/**
  * ***********************************************************************
  * @brief  初始化客户端SDK
  *         
  * @param  server_addr:            目标服务器字符串地址, "127.0.0.1"
  * @param  server_port:            目标服务器端口
  * @param  client_guid:            本客户端端口
  * @param  sdk_xml_cfg_full_path:  SDK配置文件存储路径
  * @param  default_save_dir:       SDK存储文件根路径
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_init(char       *server_addr, 
						int         server_port, 
						char       *client_guid, 
						const char *sdk_xml_cfg_full_path, 
						const char *default_save_dir);

/**
  * ***********************************************************************
  * @brief  反初始化客户端SDK
  *         
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_deinit(void);

/**
  * ***********************************************************************
  * @brief  设置是否使用硬件解码与硬件渲染, 重新打开视频生效
  *         
  * @param  decoder_accel:        硬件解码, 0关闭 1开启
  * @param  render_accel:         硬件渲染, 0关闭 1开启
  *         
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_set_hardware_accel(int decoder_accel,
									int render_accel);

/**
  * ***********************************************************************
  * @brief  打开设备实时视频通道
  *         
  * @param  device_guid:        设备GUID
  * @param  video_channel:      设备视频通道，从0开始到31
  * @param  video_channel_sub:  设备视频通道码流类型，1:主码流，2:子码流
  * @param  client_record_path: 在客户端的录像地址，相对地址，如无需录像，则填 0x00/NULL
  * @param  server_record_path: 在服务器的录像地址，相对地址，如无需录像，则填 0x00/NULL
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT 
int SDK_NSK_CLIENT_open_rt_video(char *device_guid, 
                                 int  video_channel, 
                                 int  video_channel_sub, 
                                 HWND handle,
                                 char *client_record_path,
                                 char *server_record_path);

/**
  * ***********************************************************************
  * @brief  关闭设备实时视频通道
  *         
  * @param  device_guid:        设备GUID
  *	@param  hwnd:				窗口句柄
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_rt_video(HWND hwnd);

/**
  * ***********************************************************************
  * @brief  打开设备录像回放视频通道
  *         
  * @param  device_guid:        设备GUID
  * @param  video_channel:      设备视频通道，从0开始到31
  * @param  start_ts:           设备视频通开始时间戳
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_start_pb_video(const char *device_guid, int chnn, int start_ts, HWND handle);

/**
  * ***********************************************************************
  * @brief  关闭设备录像回放视频通道
  *         
  * @param  device_guid:        设备GUID
  *	@param  handle:				窗口句柄
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_stop_pb_video(HWND handle);

/**
  * ***********************************************************************
  * @brief  传送指定文件到设备上
  *         
  * @param  dev_guid:       设备GUID
  * @param  save_server:    是否文件也在服务器保存
  * @param  file_path:      文件路径
  * @param  store_path:     在设备上的路径，含文件名
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_push_file(const char *dev_guid, 
                             int        save_server, 
                             const char *file_path, 
                             const char *store_path);

/**
  * ***********************************************************************
  * @brief  从设备获取指定文件
  *         
  * @param  dev_guid:       设备GUID
  * @param  save_server:    是否文件也在服务器保存
  * @param  dev_path:       设备文件路径
  * @param  save_path:      保存文件相对路径
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_get_file(const char *dev_guid, 
                            int         save_server, 
                            const char *dev_path, 
                            const char *save_path);

/**
  * ***********************************************************************
  * @brief  传送指定文件到设备上
  *         
  * @param  dev_guid:       设备GUID
  * @param  file_path:      升级包路径
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_device_upgrade(const char* dev_guid, const char* file_path);

/**
  * ***********************************************************************
  * @brief  开启当前客户端的指定设备对讲
  *         
  * @param  dev_guid:           设备GUID
  * @param  chnn:               对讲面板通道号
  * @param  talk_mode:          对讲模式
  * @param  client_record_path: 在客户端的录像地址，相对地址，如无需录像，则填 0x00/NULL
  * @param  server_record_path: 在服务器的录像地址，相对地址，如无需录像，则填 0x00/NULL
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_start_talk(const char *dev_guid, 
                              int        chnn, 
                              int        talk_mode, 
                              char       *client_record_path,
                              char       *server_record_path);

/**
  * ***********************************************************************
  * @brief  关闭当前客户端的指定设备对讲
  *         
  * @param  dev_guid: 设备GUID
  *
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_talk(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  关闭当前客户端的所有对讲
  *         
  * @retval int: 详见返回列表
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_all_talk(void);

/**
  * ***********************************************************************
  * @brief  远程重启设备
  *         
  * @param  dev_guid:   设备GUID
  *
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_reboot(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  获取设备版本
  *         
  * @param  dev_guid:   设备GUID
  *
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : 由回调函数返回
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_get_version(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  远程修改osd
  *         
  * @param  dev_guid:   设备GUID
  *
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_modify_osd(const char* dev_guid, int chnn, const char* base64_osd);

/**
  * ***********************************************************************
  * @brief  手动触发警号并延迟关闭
  *         
  * @param  dev_guid:   设备GUID
  * @param  chnn:		警号通道（1~5)
  * @param  dev_guid:   警号时长(0~5分钟)
  *
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */

DLLIMPORT
int SDK_NSK_CLIENT_dev_delay_alarm(const char* dev_guid, int chnn, int timout);

/**
  * ***********************************************************************
  * @brief  获取当前客户端与服务器在线状态
  *
  * @retval int: 0, 客户端不在线  1,客户端在线
  *              
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_is_online();

/**
  * ***********************************************************************
  * @brief  获取或设置设备配置
  *         
  * @param  guid:     设备GUID
  * @param  cfg_file: 配置文件名称
  * @param  cfg_name: 配置文件中配置项名称
  * @param  cfg_val:  配置文件中配置项值，如为获取配置值，则填 0x00/NULL
  *
  * @retval int: 详见返回列表
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_gset_config(char *guid,
                               char *cfg_file,
                               char *cfg_name,
                               char *cfg_val);

DLLIMPORT
void SDK_NSK_CLIENT_send_open_rt_video(const char* guid, int chnn, int sub_chnn);

DLLIMPORT
void SDK_NSK_CLIENT_send_close_rt_video(const char* guid, int chnn, int sub_chnn);

DLLIMPORT
void SDK_NSK_CLIENT_reg_rt_video_callback(p_rt_video_callback func);

