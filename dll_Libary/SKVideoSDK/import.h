#define DLLIMPORT	extern "C" __declspec(dllimport)
#define DESCRIPTION_LEN 18

typedef unsigned char   u8;
typedef unsigned short  u16;
typedef unsigned int    u32;

typedef struct
{
	int channel_1;
	int channel_2;
	int channel_3;
	int channel_4;
	int channel_5;
	int channel_6;
	int channel_7;
	int channel_8;
	int channel_9;
	int channel_10;
	int channel_11;
	int channel_12;
	int channel_13;
	int channel_14;
	int channel_15;
	int channel_16;
}st_multi_talk;

/**
  * ***********************************************************************
  * @brief	初始化客户端
  *			
  *	@param  guid:			客户端唯一标识码
  *	@param  server_ip:		服务器地址
  *	@param  server_c_port:	服务器控制端口
  *	@param  server_v_port:	服务器视频端口
  *	@param  server_a_port:	服务器语音端口
  *
  * @retval int:			统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_init_client(char	*guid,
					   char	*server_ip,
					   u16	server_c_port,
					   u16	server_v_port,
					   u16	server_a_port,
					   char	*record_directory);
/**
  * ***********************************************************************
  * @brief	发起与设备的对讲请求
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  channel:		对讲通道
  *	@param  mode:			对讲模式,1，全双工，2，喊话，3，监听
  *	@param  enable_record:	是否允许录像 
  *	@param  max_mbyte:		最大录像的大小，MB计数
  *	@param  max_min:		最大的录像时间，分钟计数
  *	@param  rec_file_path:	需要在服务器存储的文件名
  *
  * @retval int:			统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_start_talk(char		*guid,
					  int		channel,
					  int		mode,
					  int		enable_record,
					  int		max_mbyte,
					  int		max_min,
					  char		*rec_file_path
					  );

/**
  * ***********************************************************************
  * @brief	发起与设备的多面板对讲请求
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  channel:		对讲通道结构体
  *	@param  mode:			对讲模式,1，全双工，2，监听，3，喊话
  *	@param  enable_record:	是否允许录像 
  *	@param  max_mbyte:		最大录像的大小，MB计数
  *	@param  max_min:		最大的录像时间，分钟计数
  *	@param  rec_file_path:	需要在服务器存储的文件名
  *
  * @retval int:			统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_start_multi_talk(char*			guid,
							st_multi_talk*	channel,
							int				mode,
							int				enable_record,
							int				max_mbyte,
							int				max_min,
							char*			rec_file_path
							);


/**
  * ***********************************************************************
  * @brief	停止与设备的实时对讲
  *			
  *	@param  guid:	设备唯一标识码
  *
  * @retval int:	统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT int p_sdkc_stop_talk(char *guid);

/**
  * ***********************************************************************
  * @brief	停止与所有设备的对讲
  *			
  *	@param  guid:	设备唯一标识码
  *
  * @retval int:	统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT int p_sdkc_stop_talk_all(void);

/**
  * ***********************************************************************
  * @brief	对设备发起实时视频请求
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  channel:		设备视频通道号
  *	@param  handle:			播放窗口句柄
  *	@param  enable_record:	是否允许录像 
  *	@param  max_mbyte:		最大录像的大小，MB计数
  *	@param  max_min:		最大的录像时间，分钟计数
  *	@param  rec_file_path:	需要在服务器存储的文件名
  *
  * @retval int:			统一结果
  * 
  * @attention	文件名只允许用英文目录，防止在传输过程中由于编码转化导致的
  *				各种问题。
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_start_rt_video(char	*guid, 
						  u8	channel,
						  HWND  handle,
						  u8	enable_record,
						  u32	max_mbyte,
						  u32	max_min,
						  char	*rec_file_path);

DLLIMPORT
int p_sdkc_start_rt_video_ex(char	*guid, 
						  u8	channel,
						  HWND  handle,
						  u8	enable_record,
						  u32	max_mbyte,
						  u32	max_min,
						  u8    use_main_stream,
						  char	*rec_file_path);

/**
  * ***********************************************************************
  * @brief	停止与设备的实时视频播放
  *			
  *	@param  guid:		设备唯一标识码
  *	@param  channel:	视频通道号
  *	@param  handle:		视频句柄
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_stop_rt_video(char	*guid, 
						 u8		channel,
						 HWND	handle);
/**
  * ***********************************************************************
  * @brief	设定视频通道跳帧模式
  *			
  *	@param  guid:		设备唯一标识码
  *	@param  channel:	视频通道号
  *	@param  mode:		跳帧模式
  *						@arg 1: 1倍跳帧模式
  *						@arg 2: 2倍跳帧模式
  *						@arg 5: 4倍跳帧模式
  *
  * @retval int:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_set_video_ref_mode(char	*guid, 
							  int	channel,
							  int	mode);
/**
  * ***********************************************************************
  * @brief	查看客户端是否在线
  *			
  *
  * @retval int: 0，客户端不在线，1，客户端在线
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_get_online();

/**
  * ***********************************************************************
  * @brief	
  *
  * @retval void:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
void p_sdkc_exit_client();

/**
  * ***********************************************************************
  * @brief	
  *			
  * @retval void:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_open_console(void);

/**
  * ***********************************************************************
  * @brief	
  *			
  * @retval void:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_close_console(void);

/**
  * ***********************************************************************
  * @brief	使能客户端硬件渲染
  *
  * @retval int: 返回始终为TRUE
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_enable_hw_render();

/**
  * ***********************************************************************
  * @brief	关闭客户端硬件渲染
  *
  * @retval int: 返回始终为TRUE
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_disable_hw_render();


/**
  * ***********************************************************************
  * @brief	注册消息回调句柄
  *			
  *	@param  func: 回调函数指针
  *
  * @retval void: 返回未空
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_reg_msg_callback(void *func);

/**
  * ***********************************************************************
  * @brief	录像设备回放函数
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  u32 start_ts:	视频开始时间戳
  *	@param  HWND handle:	窗口句柄
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_start_playback_av(char	*guid, 
							 u8		channel,
							 u32	start_ts,
							 HWND	handle);

/**
  * ***********************************************************************
  * @brief  停止录像设备回放函数
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  HWND handle:	窗口句柄
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_stop_playback_av(char	*guid, 
							u8		channel,
							HWND	handle);


/**
  * ***********************************************************************
  * @brief	
  *			
  *	@param  char * guid:
  *	@param  int vertical_direct:
  *	@param  int vertical_speed:
  *	@param  int horizon_direct:
  *	@param  int horizon_speed:
  *
  * @retval DLLEXPORT
int:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_device_moto_control(char *guid, 
							   int vertical_direct, 
							   int vertical_speed,
							   int horizon_direct,
							   int horizon_speed);

/**
  * ***********************************************************************
  * @brief	获取录像映射
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  int start_ts:	视频开始时间戳
  *	@param  int stop_ts:	视频结束时间戳
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_get_record_time_map(char	*guid, 
							   u8	channel,
							   int	start_ts,
							   int	stop_ts);

/**
  * ***********************************************************************
  * @brief	获取录像映射
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  int start_ts:	视频开始时间戳
  *	@param  int stop_ts:	视频结束时间戳
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_get_revideo_data(char	*guid, 
							u8		channel,
							char	*url);

/**
  * ***********************************************************************
  * @brief	设置回放速度
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  int play_speed:	视频回放速度(0.125X: 125, 0.25X: 250, 0.5X: 500)
  *	                                    (1X: 1000, 2X: 2000, 4X: 4000, 8X: 8000)
  *	@param  int control:	视频回放控制(0: pause, 1: play)
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_set_pb_speed(char	*guid, 
                        u8	channel,
                        int	play_speed,
                        int	control);

/**
  * ***********************************************************************
  * @brief	设定视频服务器的语音视频端口
  *			
  *	@param  av_port:	视频语音端口
  *
  * @retval int:		统一结果
  *
  * @attention	:		需要在调用初始化客户端的函数之前调用该函数
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_set_server_av_port(int av_port);

DLLIMPORT
int p_sdkc_set_render(HWND  handle, int enable);

/**
  * ***********************************************************************
  * @brief	设置网络摄像头PTZ连续移动
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *	@param  int x_speed:	x方向速度
  *	@param  int y_speed:	y方向速度
  *	@param  int z_speed:	缩放速度
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_onvif_ptz_continue_move(char	*guid, 
                               u8	channel,
                               int	x_speed,
                               int	y_speed,
                               int	z_speed);

/**
  * ***********************************************************************
  * @brief	设置网络摄像头PTZ停止
  *			
  *	@param  char * guid:	设备GUID
  *	@param  u8 channel:		设备视频通道号
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_onvif_ptz_stop(char	*guid, 
                               u8	channel);
/**
  * ***********************************************************************
  * @brief	设置音频播放的放大值
  *			
  *	@param  int:		播放音量预放大值, 取值0~50
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_set_out_pre_amp(int amp);

DLLIMPORT
int p_sdkc_request_download_video(char *guid, u8 channel, int start_ts, int stop_ts, char *save_path);

DLLIMPORT
int p_sdkc_cancel_download_video(char *guid);


/**
  * ***********************************************************************
  * @brief	设置录像下载回调接口
  *			
  *	@param  int:		
  *
  * @retval int:		统一结果
  * 
  * @attention     当返回的时间戳是0x00的时候，即录像下载结束, 时间戳0x00的这一帧不为录像数据
  *					当调用cancel取消录像下载时，需要在外面主动关闭文件，回调的码流即刻关闭
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_reg_dl_video_data_callback(void *func);

DLLIMPORT
void p_vsdk_reg_rt_video_data_callback(void *func);

DLLIMPORT
void p_vsdk_temp_disable_rt_pb_audio(int disable);

DLLIMPORT
int p_sdkc_get_set_dev_config(char *guid,
							  char *cfg_file,
							  char *cfg_name,
							  char *cfg_val);

DLLIMPORT
int p_sdkc_dev_passthrough(char* dev_guid, char *cmd);

DLLIMPORT
int p_sdkc_get_dev_cam_info(char* dev_guid);

DLLIMPORT
int p_sdkc_get_dev_net_spd(char* dev_guid);

DLLIMPORT
int p_sdkc_set_dev_cam_osd(char *guid, 
							int  channel, 
							char* osd_utf8_base64);

DLLIMPORT
int p_sdkc_sip_invite(char* guid);
