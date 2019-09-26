#pragma once

#define DLLIMPORT       extern "C" __declspec(dllimport)


#define TALK_MODE_LISTEN        0x01 // 客户端监听 -> 设备上行码流
#define TALK_MODE_SPEAK         0x02 // 客户端喊话 -> 客户下行码流
#define TALK_MODE_FULL          (TALK_MODE_LISTEN | TALK_MODE_SPEAK)
#define MAX_DEVICE_INFO_SUM		65535
#define CD_GUID_LEN				30

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
									   char     *msg_info,  
                                       int      arg1,
                                       int      arg2,
                                       void     *data1,  
                                       int      data1_len,  
                                       void     *data2, 
                                       int      data2_len);


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
int SDK_NSK_SERVER_get_devcie_online(char *device_guid);


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
  * @param  file_path:      位于设备源文件路径，相对地址
  * @param  store_path:     在客户端的的存储路径，相对地址
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
int SDK_NSK_CLIENT_reboot_device(const char *dev_guid);

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