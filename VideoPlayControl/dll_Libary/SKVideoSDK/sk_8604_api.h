/**
  *************************************************************************
  * @file    sk_8604_api.h
  * @author  Toson.Huaqian
  * @version V1.0.0
  * @date    2014/8/12
  * @brief   
  *************************************************************************
  * @attention
  *
  * <h2><center>&Copyright(c) 2014-2020 Xiamen HuaQian Studio</center></h2>
  *
  *************************************************************************
  */
#define DLLIMPORT	    extern "C" __declspec(dllimport)
#define CD_GUID_LEN				30
#define MAX_DEVICE_INFO_SUM		65535

typedef unsigned char   u8;
typedef unsigned short  u16;
typedef unsigned int    u32;
typedef unsigned long long u64;

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
#define SDK_EVENT_LOST_LINK_ALARM			0x10
#define SDK_EVENT_LOST_LINK_RECOVER			0x11
#define SDK_EVENT_HEART_BEAT				0x0f // 心跳包
#define SDK_EVENT_VIDEO_LOST				0x12 // 视频丢失
#define SDK_EVENT_VIDEO_RECOVER				0x13 // 视频丢失
#define SDK_EVNET_FAST_SNAP_FINE			0x14 // 抓图成功
#define SDK_EVENT_FAST_SNAP_TIMEOUT			0x15 // 抓图失败
#define SDK_EVNET_FAST_SNAP_DONE			0x16 // 
#define SDK_EVENT_TALK_KEY_PRESS			0x17 // 呼叫按钮被按下
#define SDK_EVENT_FQ_KEY_PRESS              0x18
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


/**********************************************************/
//						返回结果定义
/**********************************************************/
#define RET_UNDEFINE_ERR		0	// 未知错误
#define RET_OK					1	// 返回成功
#define RET_EMPTY_EVENT			2	// 空事件
#define RET_NO_FIND_DEVICE		3	// 设备不存在
#define RET_NO_INIT_AUDIO		4	// 未初始化音频设备
#define RET_EMPTY_GUID			5	// 空设备唯一编号
#define RET_DEV_OFF_LINE		6	// 设备掉线
#define RET_OPEN_FILE_FAIL		7	// 打开文件失败
#define RET_NO_ENOUGH_MEM		8	// 内存空间不够
#define RET_CLOSE_ALREADY		9	// 重复关闭
#define RET_INIT_ALREADY		10	// 重复初始化
#define RET_WAIT_TIME_OUT		11	// 操作超时

#define D3D_ERR_CREATE_DEVICE_FAIL						0x01		// 创建DirectX设备失败，请检查显卡驱动是否异常
#define D3D_ERR_CREATE_OFFSCREEN_PLAIN_SURFACE_FAIL		0x02		// 创建DirectX离屏表面失败，请检查显卡驱动是否异常
#define D3D_ERR_GET_BACK_BUFFER_FAIL					0x03        // 获取DirectX缓冲区失败，请检查显卡驱动是否异常
#define D3D_ERR_CREATE_D3D_FAIL							0x04		// 创建DirectX实例失败，请检查计算机是否安装DirectX套件


#define MSG_CB_NEW_DEVICE_ONLINE		1 // 新设备上线
#define MSG_CB_DEVICE_LOST_CONN			2 // 设备掉线
#define MSG_CB_NEW_CLIENT_ONLINE		3 // 客户端上线
#define MSG_CB_CLIENT_LOST_CONN			4 // 客户端掉线
#define MSG_CB_RE_VIDEO_READY			5 // 预录像获取完毕
#define MSG_CB_RE_VIDEO_FIAL			6 // 预录像获取失败
#define MSG_CB_PICTURE_READY			7 // 图片获取完毕
#define MSG_CB_PICTURE_FAIL				8 // 图片获取完毕
#define MSG_CB_DETECT_CONFLICT_DEVICE	9 // 检测到设备地址冲突
#define MSG_CB_DETECT_CONFLICT_CLIENT	10// 检测到客户端地址冲突
#define MSG_CB_SYSTEM_INIT_FAIL			11// 系统初始化失败
#define MSG_CB_NEW_DEVICE_EVENT			12// 新的设备事件上传
#define	MSG_CB_LOST_DATA_VIDEO			13// 太长时间没有接收到视频数据，可能通道被关闭
#define MSG_CB_LOST_DATA_AUDIO			14// 太长时间没有接收到音频数据，可能通道被关闭
#define MSG_CB_NO_EXIST_DEVICE			15// 设备不存在
#define MSG_CB_NO_EXIST_CLIENT			16// 客户端不存在
#define MSG_CB_NO_DEFINE_CLIENT			17// 被拒绝客户端
#define MSG_CB_REC_VIDEO_DONE			18// 录像文件完成
#define MSG_CB_REC_AUDIO_DONE			19// 录音文件完成
#define MSG_CB_REC_VIDEO_START			20// 录像开始
#define MSG_CB_REC_AUDIO_START			21// 录音开始
#define MSG_CB_RT_VIDEO_START			22// 开始实时码流播放
#define MSG_CB_RT_VIDEO_END				23// 停止实时码流
#define MSG_CB_RT_AUDIO_START			24// 开始播放语音
#define MSG_CB_RT_AUDIO_END				25// 停止播放语音
#define MSG_CB_RT_VIDEO_CLOSE_TIMEOUT	26// 超时关闭实时码流
#define MSG_CB_RT_AUDIO_CLOSE_TIMEOUT	27// 超时关闭语音对讲
#define MSG_CB_RT_REC_AUDIO_FIAL		28// 语音录制失败
#define MSG_CB_RT_REC_VIDEO_FAIL		29// 录像文件失败
#define MSG_CB_RT_CLIENT_RE_OPEN		30// 同一个客户端多次打开音频或者打开同一个通道
#define MSG_CB_RT_DEVICE_RE_OPEN		31// 同一个设备被多个客户端同时打开语音
#define MSG_CB_REC_VIDEO_GO_START		32// 准备录像
#define MSG_CB_GET_REC_LIST_OK			33// 列表获取完毕
#define MSG_CB_GET_REC_LIST_FAIL		34// 列表获取失败
#define MSG_CB_UPDATE_DB_FAIL			35
#define MSG_CB_NETWORDK_WARNING			36
#define MSG_CB_D3D_ERROR				37 // 硬件渲染错误
#define MSG_CB_AV_PB_STOP				38 // 录像回放结束
#define MSG_CB_GET_RECORD_MAP			39 // 获取录像文件映射
#define MSG_CB_ROUTE_CHANGE				40 // 设备路由发生改变
#define MSG_CB_CONFIG_GSET				41 // 参数设定和获取
#define MSG_CB_PCM_DATA					42 // 设备音频LPCM数据裸流
#define MSG_CB_DEVICE_HB				43
#define MSG_CB_DEVICE_GPS_LOC			44
#define MSG_CB_DEVICE_CELL_LOC			45
#define MSG_CB_DEVICE_DISK_INFO			46
#define MSG_CB_DEVICE_VALID_PANNEL		47
#define MSG_CB_DEVICE_CAM_OFFLINE		48
#define MSG_CB_AV_DL_STOP				49
#define MSG_CB_PASSTHROUGH_PROTO		50 // 透传协议结果

/* 精简版设备信息 */
typedef struct
{
	/// 设备临时分配ID号
	u32		client_id;
	/// 设备全球唯一标识码
	u8		guid[CD_GUID_LEN];
	/// 设备是否在线
	u8		online;
	/// 设备是否交换信息完毕，处于可用状态
	u8		ready;
	int		last_online_time;
}client_info_lite;

/* 精简版设备信息列表 */
typedef struct
{
	/// 设备信息结构体列表
	client_info_lite	client_info[MAX_DEVICE_INFO_SUM];
	/// 设备在线个数
	u32			client_online;
	/// 总的在线设备个数，包含了未在线个数
	u32			client_all;
}client_info_all;

/* 健全版设备具体信息 */
typedef struct
{
	u32		client_id;			/// 设备临时分配ID号
	u8		guid[CD_GUID_LEN]; 	/// 设备全球唯一标识码
	u8		online;				/// 设备是否在线
	u8		ready;				/// 设备是否交换信息完毕，处于可用状态

	u32		ser1_ip;			/// 服务器1IP
	u16		ser1_c_port;		/// 服务器1命令端口
	u16		ser1_v_port;		/// 服务器1视频端口
	u16		ser1_a_port;		/// 服务器1语音端口

	u32		ser2_ip;			/// 服务器1IP
	u16		ser2_c_port;		/// 服务器1命令端口
	u16		ser2_v_port;		/// 服务器1视频端口
	u16		ser2_a_port;		/// 服务器1语音端口

	u8		hb_interver;		/// 心跳包发送间隔
	u8		send_prefer;		/// 服务器发送优先选择
	u16		max_bitrate;		/// 最大码流波特率
	u8		static_encode;		/// 静态码率变化最小评估值
	u8		dynamic_encode;		/// 动态码率变化最大评估值
	u8		encode_size;		/// 上传码流图像大小
	u16		up_video_delay;		/// 上传延迟
	u8		encode_type;		/// 上传码率类型
	u8		up_midium;			/// 上传通道选择
	u16		up_overtime;		/// 码流上传超时时间
	u8		descript_name[40];	/// 设备描述符		
	int		last_online_time;	/// 设备最后上线时间
}client_info_complete;

typedef struct
{
	u8      guid[CD_GUID_LEN];
	u8      length;
	u8      event_code;
	u32     time;
	u8      event_data[10];
}st_event;

/**
  * ***********************************************************************
  * @brief	初始化整个SDK,需要在所有函数调用之前使用
  *			
  *	@param  ipaddr: 需要绑定的本机的网卡地址，用于防止多网卡冲突
  *	                @arg NULL           可以绑定任意网卡
  *	                @arg 4字节网卡地址  绑定指定网卡
  *	                
  *	@param  port:  绑定的本机端口
  *
  * @retval void   返回为空
  * 
  * @attention     该函数会绑定端口，所以在运行该函数之前需要注意是否会有
  *                同样的程序未关闭，如果未关闭则无法再次调用该程序。
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_open(char	*ipaddr, 
				 int	cport, 
				 int	vport, 
				 int	aport ,
				 char	*record_directory , 
				 u8		*ret_val);

/**
  * ***********************************************************************
  * @brief	设置网页存放路径(全路径必须为英文)
  *			
  * @retval void 返回为空
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_default_html_path(const char *path);

/**
  * ***********************************************************************
  * @brief	关闭SDK
  *			
  * @retval void 返回为空
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_close(void);

/**
  * ***********************************************************************
  * @brief	设定网络传输参数
  *			
  *	@param  client_no:  设备序列号
  *	
  *	@param  channel:    设备视频通道号
  *	                    @arg 默认为0通道，后期可兼容多通道
  *	                    
  *	@param  state:      开启或关闭通道
  *	                    @arg 1 开启RVC模块
  *	                    @arg 0 关闭RVC模块
  *	                    
  *	@param  ip1:        主服务器IP地址
  *	@param  c_port1:    主服务器命令传输端口
  *	@param  s_port1:    主服务器视频流传输端口
  *	@param  a_port1:    主服务器语音流传输端口
  *	
  *	@param  ip2:        备份服务器IP地址
  *	@param  c_port2:    备份服务器命令传输端口
  *	@param  s_port2:    备份服务器视频流传输端口
  *	@param  a_port2:    主服务器语音流传输端口
  *	
  *	@param  cgrp_prior: 当前优先传输的地址
  *	                    @arg 1：优先传输主服务器
  *	                    @arg 2: 优先传输备份服务器
  *	                    
  *	@param  interval:   与服务器链路维持包发送间隔
  *	                    @arg x: 单位为秒
  *
  * @retval void        返回为空
  * 
  * @attention:         该初始化函数需要在设备已经在线的情况下，并且可以获取到设备
  *                     的具体信息的情况下，进行调用，否则该函数无法生效
  *                     设置主服务器地址后如果地址与之前保存的不一致，会在下次重启生效
  *              
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_set_net_transfer_info(char *guid,
								  u8   channel,
								  u8   state,
								  char *ip1,
								  u16  c_port1,
								  u16  s_port1,
								  u16  a_port1,
								  char *ip2,
								  u16  c_port2,
								  u16  s_port2,
								  u16  a_port2,
								  u8   cgrp_prior,
								  u8   interval,
								  u8   *ret_val);
/**
  * ***********************************************************************
  * @brief	    	        设定远端设备视频编码信息
  *			
  *	@param  client_no:      设备序列号
  *	
  *	@param  channel:        设备视频通道号
  *	                        @arg 默认为0通道，后期可兼容多通道
  *	                        
  *	@param  state:          开启或关闭通道
  *	                        @arg 1 开启RVC模块
  *	                        @arg 0 关闭RVC模块
  *	                        
  *	@param  maxrate:        最大码流波特率
  *	                        @arg 2-1024：单位为Kbps
  *	                    
  *	@param  s_rate:         动态码率变化最大评估值
  *	                        @arg 1-51：推荐值为10
  *	                        
  *	@param  d_rate:         静态码率变化最小评估值
  *	                        @arg 1-51：推荐值为35
  *	                        
  *	@param  photo_size:     上传码流图像大小,图像越小，码率同等情况下
  *	                        图像就越清晰
  *	                        @arg 1：D1分辨率大小
  *	                        @arg 2：CIF分辨率大小
  *	                        @arg 3：QCIF分辨率大小
  *	                        
  *	@param  upload_delay:   上传延迟
  *	                        @ x：单位为毫秒，在该毫秒之后开始上传视频默认为0
  *	                        
  *	@param  rate_type:      上传码率类型
  *	                        @arg 1：VBR，动态码率自适应
  *	                        @arg 2：CBR，静态码率
  *	                        
  *	@param  trans_media:    上传通道选择
  *	                        @arg 1：3G上网卡，为选配，无此卡自动切换
  *	                        @arg 2：有线网卡，默认为该选项
  *	                        
  *	@param  overtime:       码流上传超时时间
  *	                        @arg 10-300：最大支持300秒持续码流传输
  *
  * @retval void            返回为空
  * ***********************************************************************
  */
DLLIMPORT void 
p_vsdk_set_video_encode_info(char *guid, 
                             u8   channel, 
                             u8   state, 
                             u16  maxrate, 
                             u8   s_rate, 
                             u8   d_rate, 
                             u8   photo_size, 
                             u16  upload_delay, 
                             u8   rate_type, 
                             u8   trans_media, 
                             u16  overtime, 
                             u8   *ret_val);
/**
  * ***********************************************************************
  * @brief	设定报警前录像时长
  *			
  *	@param  client_no:  设备序列号
  *	
  *	@param  channel:    设备视频通道号
  *	                    @arg 默认为0通道，后期可兼容多通道
  *	                    
  *	@param  vedio_time: 录像时长，默认为10s
  *
  * @retval DLLIMPORT void 
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_set_revideo_time(char *guid, 
							 int channel, 
							 u8 vedio_time, 
							 u8 *ret_val);
/**
  * ***********************************************************************
  * @brief	获取报警前数据
  *			
  *	@param  client_no:  设备序列号
  *	
  *	@param  channel:    设备视频通道号
  *                     @arg 默认为0通道，后期可兼容多通道
  *                     
  *	@param  vdo_data:   报警前数据指针，内部申请，需要手工释放
  *	@param  vdo_len:    报警钱数据长度
  *	@param  file_path:  报警前录像保存路径，用于后期回放使用 
  *	
  *	@param  ret_val:    函数执行结果
  *
  * @retval void        返回为空
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_video_redata(char *guid,
							 int  channel,
							 char * vdo_data, 
							 u32  * vdo_len, 
							 char * file_path,
							 u8   * ret_val);
/**
  * ***********************************************************************
  * @brief	获取所有的设备个数
  *			
  *	@param  client_sum: 设备个数
  *
  * @retval void        返回为空
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_client_sum(int * client_sum,
						   u8  * ret_val);


/**
  * ***********************************************************************
  * @brief	查询指定设备序列号是否在线
  *			
  *	@param  guid:		设备唯一标识码
  *
  * @retval bool:		返回设备是否在线
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
bool p_vsdk_get_device_online(char * guid);
/**
  * ***********************************************************************
  * @brief	获取单个设备信息
  *			
  *	@param  client_NO:  设备序列号
  *	@param  info:       设备信息
  *
  * @retval void        返回为空
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_device_info_one(char					*guid,
								client_info_complete	* info,
								u8						* ret_val);
/**
  * ***********************************************************************
  * @brief	获取所有的设备信息
  *			
  *	@param  info_array: 设备信息列表
  *
  * @retval void        返回为空
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_device_info_all(client_info_all   *info_array);
/**
  * ***********************************************************************
  * @brief	启用视频回播功能
  *			
  *	@param  path:       回播视频文件路径
  *	@param  handle:     重绘控件句柄 
  *	@param  ret_val:    函数执行结果 
  *
  * @retval void        返回为空 
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_play(char    *path,
						  void    *handle,
						  u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	停止视频回播
  *			
  *	@param  handle:     重绘控件句柄
  *	@param  ret_val:    函数执行结果
  *
  * @retval void        返回为空
  * 
  * @attention          在调用该函数之前，请在调用控件销毁之后，
  *                     如果用同一个控件前后播放不一样的码流，请先销毁
  *                     码流播放流程，避免控件出现重绘冲突。                     
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_stop(void    *handle,
						  u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	暂停视频回播
  *			
  *	@param  handle:     重绘控件句柄
  *	@param  ret_val:    函数执行结果
  *
  * @retval void        返回为空 
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_pause(void    *handle,
						   u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	获取回播视频播放时长
  *			
  *	@param  path:   回播视频文件路径
  *	@param  handle: 重绘控件句柄
  *	@param  time:   播放时长，单位为秒数
  *
  * @retval void    返回为空 
  * 
  * @attention      在调用该函数之前，请确保文件为h264码流视频
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_playback_time(char    *path,
							  void    *handle,
							  u32     *time);
/**
  * ***********************************************************************
  * @brief	
  *			
  *	@param  : 
  *
  * @retval DLLIMPORT void 
  * ***********************************************************************
  */
DLLIMPORT
BOOL p_vsdk_convert_audio(const char *in_wav_file, const char *out_g711_file);

/**
  * ***********************************************************************
  * @brief	远程控制重启机器
  *			
  *	@param  guid:       设备唯一标识码 
  *	@param  delay :		重启延迟
  *	@param  ret_val :	返回结果
  *
  * @retval void        返回为空
  * 
  * @note	
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_reboot(char *guid,u8 delay, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	设定设备具体描述信息，Unicode编码
  *			
  *	@param  guid :		设备唯一标识码
  *	@param  descript :	设备描述信息
  *	@param  ret_val :	返回结果
  *
  * @retval void :		返回结果未空
  * @note	
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_dev_descript(char *guid,u8 *descript, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	远程播放音频文件
  *			
  *	@param  guid :		    设备唯一标识码
  *	@param  audio_index :	音频文件编号
  *	@param  ret_val :	    返回结果
  *
  * @retval void :		返回结果未空
  * @note	
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_remote_play_audio(char *guid,u8 audio_index, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	下载音频文件到设备并播放
  *			
  *	@param  char * guid:	设备GUID
  *	@param  char * url:		音频文件地址
  *
  * @retval int:		统一结果
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_play_remote_audio(char	*guid, 
							 char	*file,
                             char	*url);
/**
  * ***********************************************************************
  * @brief	对设备指定通道进行截图并保存文件
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  snap_count:		抓取图片数据
  *	@param  snap_interver:	抓取图片间隔
  *	@param  channel:		抓图通道号
  *	@param  file1_path:		图像文件1
  *	@param  file2_path:		图像文件2
  *	@param  file3_path:		图像文件3
  *	@param  file4_path:		图像文件4
  *	@param  file5_path:		图像文件5
  *	@param  ret_val:		返回结果
  *
  * @retval void:			返回结果未空
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_snap_picture(char	*guid,
						 u8		snap_count,
						 u16	snap_interver,
						 u8		channel,
						 char	*file1_path,
						 char	*file2_path,
						 char	*file3_path,
						 char	*file4_path,
						 char	*file5_path,
						 u8		*ret_val);

/**
  * ***********************************************************************
  * @brief	
  *			
  *	@param  guid: 
  *	@param  channel: 
  *	@param  http_path: 
  *
  * @retval int:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_fast_snap(char *guid, int channel, int snap_count, char * http_path);

/**
  * ***********************************************************************
  * @brief	增加一个新的客户端
  *			
  *	@param  client_guid: 客户端唯一识别码
  *
  * @retval void: 返回未空
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT  
void p_sdks_add_client(u8 *client_guid);

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
int p_vsdk_reg_msg_callback(void *func);

/**
  * ***********************************************************************
  * @brief	注册服务器端录像视频数据回调函数
  *			
  *	@param  func: 回调函数指针
  *
  * @retval void: 返回未空
  * 
  * @attention 参照 "p_pb_video_data_callback" 函数定义进行func函数类型构成
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_reg_pb_video_data_callback(void *func);

/**
  * ***********************************************************************
  * @brief	注册服务器端实时视频数据回调函数
  *			
  *	@param  func: 回调函数指针
  *
  * @retval void: 返回未空
  * 
  * @attention 参照 "p_rt_video_data_callback" 函数定义进行func函数类型构成  
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_reg_rt_video_data_callback(void *func);

/**
  * ***********************************************************************
  * @brief	设置录像文件路径
  *			
  *	@param  path:	录像文件路径
  *
  * @retval int:	成功返回1 失败返回0
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_record_path(char * path);


/**
  * ***********************************************************************
  * @brief	获取设备录像列表
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  start_time:		录像开始时间
  *	@param  end_time:		录像结束时间
  *	@param  is_alarm_file:	是否为报警录像
  *								@arg 1: 要获取的录像为报警录像
  *								@arg 0: 要获取的录像为普通录像
  *
  * @retval int:			见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_get_record_list(char			*guid,
						   int			channel,	
						   unsigned int	start_time,
						   unsigned int	end_time,
						   int			is_alarm_file);

/**
  * ***********************************************************************
  * @brief	ftp获取设备录像文件
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  path:			需要设备去上传文件名
  *	@param  username:		ftp账户名
  *	@param  password:		ftp密码
  *	@param  ftp_ip_address: ftp服务器地址
  *	@param  ftp_port:		ftp端口
  *	@param  file_name:		设备录像文件名
  *	@param  is_alarm_file:	是否为报警录像
  *								@arg 1: 要获取的录像为报警录像
  *								@arg 0: 要获取的录像为普通录像
  *
  * @retval int:			见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_record_file_ftp(char	*guid,
							   char	*path,
							   char	*username,
							   char	*password,
							   char	*ftp_ip_address,
							   int	ftp_port,
							   char	*file_name,
							   int	is_alarm_file);

/**
  * ***********************************************************************
  * @brief	通过远程ftp设备下载批量升级
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  path:			需要设备去下载的升级文件名
  *	@param  username:		ftp账户名
  *	@param  password:		ftp密码
  *	@param  ftp_ip_address: ftp服务器地址
  *	@param  ftp_port:		ftp端口
  *
  * @retval int:			见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_update_device_ftp(char	*guid,
							 char	*path,
							 char	*username,
							 char	*password,
							 char	*ftp_ip_address,
							 int	ftp_port);

/**
  * ***********************************************************************
  * @brief	获取设备上的指定表的校验和
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  form_type:		表类型
  *								@arg 1: 人员表
  *								@arg 2: 人员组表
  *								@arg 3: 时间组表
  *	@param  cksum:			获取到的校验和
  *
  * @retval int:			见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_dev_db_form_cksum(char	*guid, 
								 int	form_type, 
								 u32	*cksum);

/**
  * ***********************************************************************
  * @brief	更新设备上的指定表的内容
  *			
  *	@param  guid:			设备唯一标识码
  *	@param  form_type:		表类型
  *								@arg 1: 人员表
  *								@arg 2: 人员组表
  *								@arg 3: 时间组表	
  *	@param  form_data:		表的内容
  *	@param  form_dat_len:	表的长度
  *	
  * @retval int:			见返回结果列表:
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_update_dev_db_form(char	*guid, 
							  int	form_type, 
							  char	*form_data,
							  int	form_dat_len);

/**
  * ***********************************************************************
  * @brief	获取设备网络摄像头安装状态
  *			
  *	@param  guid:	设备唯一标识码
  *
  * @retval int:	最多支持16路的数字摄像头安装状态，
  *					0b -16个0- -0000 0000 0000 ihfe dcba-  
  *					a:数字摄像头0的安装状态，1为已添加，2为未添加
  *					b:数字摄像头1的安装状态，1为已添加，2为未添加
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_get_device_net_install_statu(char * guid);


/**
  * ***********************************************************************
  * @brief	获取当前设备路由选择状态
  *			
  *	@param  guid:	设备唯一标识码
  *
  * @retval int:	当前设备路由状态
  *						@arg 1: 只使用3G/4G
  *						@arg 2: 只使用有线
  *						@arg 3: 有线优先，3G/4G作为备份链路
  *						@arg 4: 3G/4G有线，有线作为备份链路
  *
  * @attention	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_route_choose(char * guid);

/**
  * ***********************************************************************
  * @brief	获取当前设备GSM模块信号强度
  *			
  *	@param  guid:	设备唯一标识码
  *
  * @retval int:	信号强度，0-31
  *
  * @attention	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_gsm_signal(char *guid);

/**
  * ***********************************************************************
  * @brief	重新设定设备帐号密码
  *			
  *	@param  guid:	设备唯一标识码 
  *
  * @retval int:	见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_reset_device_password(char *guid);


/**
  * ***********************************************************************
  * @brief	获取设备版本号
  *			
  *	@param  guid:	设备唯一标识码 
  *
  * @retval int: 见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_device_version(char *guid);

/**
  * ***********************************************************************
  * @brief	对设备进行远程升级
  *			
  *	@param  guid:				设备唯一识别码
  *	@param  upgrade_bin_path:	升级文件地址
  *
  * @retval int: 见返回结果列表
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_http_upgrade(char *guid, char *upgrade_bin_path);

/**
  * ***********************************************************************
  * @brief	改变设备的视频传输协议
  *			
  *	@param  guid:				设备唯一识别码
  *	@param  char * tcp_udp:		通讯协议
  *									@arg "TCP":采用TCP传输视频码流
  *									@arg "UDP":采用UDP传输视频码流
  *
  * @retval int: 见返回结果列表
  * 
  * @attention   目前不适用于8604，因为8604只支持UDP画质。
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_transport_protocol(char *guid, char *tcp_udp);

/**
  * ***********************************************************************
  * @brief	改变设备指定通道视频传输质量
  *			
  *	@param  guid:				设备唯一识别码
  *	@param  int channel:		设备视频通道号
  *	@param  char * quality:		视频传输质量
  *									@arg "CIF":  CIF画质
  *									@arg "D1":	 D1画质
  *									@arg "720P": 1280*720画质
  *
  * @retval int:	见返回结果列表
  * 
  * @attention		目前8604不支持720P画质，如果传递该参数进去，则回返回无效。 
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_video_quality(char *guid,int channel, char *quality);

/**
  * ***********************************************************************
  * @brief	远程控制输出防区
  *			
  *	@param  guid:				设备唯一识别码
  *	@param  int out_fq_number:	设备输出防区号码
  *	@param  int val:			输出防区值
  *	@param  int mode:			防区控制模式
  *									@arg 1: 手动模式
  *									@arg 0: 自动模式
  *
  * @retval int:	见返回结果列表
  * 
  * @attention		无
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_control(char *guid, int out_fq_number, int val, int mode);

/**
  * ***********************************************************************
  * @brief	远程控制打开门锁
  *			
  *	@param  guid:	设备唯一识别码
  *
  * @retval int:	见返回结果列表
  * 
  * @attention		无
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_open_door(char *guid);

/**
  * ***********************************************************************
  * @brief	对设备的云台进行水平垂直方向转动控制
  *			
  *	@param  char * guid:			设备唯一识别码
  *	@param  int vertical_direct:	垂直转动方向
  *	@param  int vertical_speed:		垂直转动速度
  *	@param  int horizon_direct:		水平转动方向
  *	@param  int horizon_speed:		水平转动速度
  *
  * @retval int:	见返回结果列表
  * 
  * @attention		无
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_device_moto_control(char *guid, 
							   int vertical_direct, 
							   int vertical_speed,
							   int horizon_direct,
							   int horizon_speed
							   );

/**
  * ***********************************************************************
  * @brief	获取设备录像文件映射表
  *			
  *	@param  char * guid:	设备唯一识别码
  *	@param  int channel:	视频通道号
  *	@param  u32 start_ts:	开始时间戳
  *	@param  u32 stop_ts:	结束时间戳
  *
  * @retval int: 见返回结果列表
  *
  * @attention     无	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_record_time_map(char *guid,
							   int	channel,
							   u32	start_ts,
							   u32	stop_ts);

/**
  * ***********************************************************************
  * @brief	远程设置配置
  *			
  *	@param  char * guid:        设备唯一识别码
  *	@param  char * cfg_file:    配置文件名称
  *	@param  char * cfg_name:    配置参数名称
  *	@param  char * cfg_val:     配置参数
  *
  * @retval int: 见返回结果列表
  *
  * @attention     无	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_set_dev_config(char *guid,
							  char *cfg_file,
							  char *cfg_name,
							  char *cfg_val);

/**
  * ***********************************************************************
  * @brief	对设备的自带数字摄像头进行镜像选项配置
  *			
  *	@param  char * guid:        设备唯一识别码
  *	@param  char * mirroring:	视频镜像选项
  *									@arg "mirror_left_right":	左右镜像
  *									@arg "mirror_up_down":		上下镜像
  *									@arg "mirror_center":		中心镜像
  *									@arg "mirror_none":			不进行镜像
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_dev_install_mirroring(char *guid, char *mirroring);

DLLIMPORT
int p_vsdk_get_dev_door_states(char *guid);

/**
  * ***********************************************************************
  * @brief	通知下位机更新卡列表数据库
  *			
  *	@param[in]  char * guid:	设备唯一识别码
  *	@param[in]  char * http_db:	数据库HTTP地址
  *
  * @retval int:	见返回结果列表
  *
  * @attention		无
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_update_cardlist_db(char *guid, char *http_db);

/**
  * ***********************************************************************
  * @brief	上传设备预录像数据
  *			
  *	@param  char * guid:        设备唯一识别码
  * @param  int    channel:		要上传的通道
  *	@param  char * path:		要上传到的地址
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_revideo_data(char *guid, int channel, char *path);

/**
  * ***********************************************************************
  * @brief	上传设备相关配置以及运行日志
  *			
  *	@param  char * guid:        设备唯一识别码
  *	@param  char * upload_url:	要上传到的地址
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_remote_upload_log(char *guid,char *upload_url, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	获取设备可用面板
  *			
  *	@param  char * guid:        设备唯一识别码
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_valid_talk_pannel(char *guid);

/**
  * ***********************************************************************
  * @brief	获取设备定位信息
  *			
  *	@param  char * guid:        设备唯一识别码
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_gps_info(char *guid);

/**
  * ***********************************************************************
  * @brief	获取基站定位信息
  *			
  *	@param  char * guid:        设备唯一识别码
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_cell_info(char *guid);

/**
  * ***********************************************************************
  * @brief	获取设备磁盘使用信息
  *			
  *	@param  char * guid:        设备唯一识别码
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_disk_info(char *guid);

/**
  * ***********************************************************************
  * @brief	重置tx outx电源
  *			
  *	@param  char * guid:        设备唯一识别码
  *									
  * @retval int:	见返回结果列表
  *
  * @attention		无		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_reset_tx_outx_power(char *guid);

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
void p_vsdk_open_console(void);

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
void p_vsdk_close_console(void);

/**
  * ***********************************************************************
  * @brief	设置服务器视频语音端口
  *
  *	@param  int av_port:  服务器视频语音端口
  * @retval void:  返回为空
  * 
  * @attention     需要在调用初始化服务器的函数之前调用该函数
  * ***********************************************************************
  */
DLLIMPORT
int  p_vsdk_set_av_port(int av_port);

/**
  * ***********************************************************************
  * @brief	测试模式，强制修改设备路由状态
  *
  *	@param  int route:  路由状态,2->eth/wlan only, 3->eth/wlan prefer
  *								1->ppp/4g only,   4->ppp/4g prefer
  * @retval void:  返回为空
  * 
  * @attention    
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_test_device_route(char *guid, int route);

/**
  * ***********************************************************************
  * @brief  远程写入指纹模板
  *			
  *	@param  guid:				远程GUID
  *	@param  people_bgein_zero:	人物编号，从0开始
  *	@param  finger_bgein_zero:	指纹编号，从0开始
  *	@param  tmplate_length:		模板长度
  *	@param  finger_template:	指纹模板，base64
  *
  * @retval int:				返回为空
  *
  * @attention	: none
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_update_finger_template(char *guid, 
	                              int  people_bgein_zero, 
	                              int  finger_bgein_zero, 
	                              int  tmplate_length, 
	                              char *finger_template
);

/**
  * ***********************************************************************
  * @brief  远程读取指纹模板
  *			
  *	@param  guid:				远程GUID
  *	@param  people_bgein_zero:	人物编号，从0开始
  *	@param  finger_bgein_zero:	指纹编号，从0开始
  *
  * @retval int:				返回为空
  *
  * @attention	: none
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_read_finger_template(char *guid, 
	                            int  people_bgein_zero, 
	                            int  finger_bgein_zero 
);


/**
  * ***********************************************************************
  * @brief  远程删除指纹模板
  *			
  *	@param  guid:				远程GUID
  *	@param  people_bgein_zero:	人物编号，从0开始
  *	@param  finger_bgein_zero:	指纹编号，从0开始
  *
  * @retval int:				返回为空
  *
  * @attention	: none
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_delete_finger_template(char *guid, 
	                              int  people_bgein_zero, 
	                              int  finger_bgein_zero
);

/**
  * ***********************************************************************
  * @brief  设置呼叫按钮连按限制
  *			
  *	@param  ban_time:	要禁用的时长
  *	@param  ban_cnt:	进入禁用的连按次数
  *
  * @retval int:				返回为空
  *
  * @attention	: 给出 <= 0的参数，将关闭限制
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_call_key_ban(int ban_time, int ban_cnt);

/**
  * ***********************************************************************
  * @brief  上传指定时间范围的报警录像
  *			
  *	@param  start_time:	开始时间戳
  *	@param  stop_time:	结束时间戳
  *	@param  upload_url:	上传路径
  *
  * @retval int:				返回为空
  *
  * @attention	: url给出上传的目录，文件名由设备自己决定,通道: 1~16
				格式: "ARC_ch01_61-385445403930-3736_1527499057.h264"
					ARC_通道号_设备guid_时间戳.h264
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_upload_alarm_record(char *guid,
								int start_time,
								int stop_time,
								char *upload_url);

/**
  * ***********************************************************************
  * @brief  设置是否关闭超时关闭码流功能
  *			
  *	@param  disable:	是否禁用超时关闭码流功能
  *
  * @retval void:		返回为空
  *
  * @attention	: 0: 打开超时关闭码流功能(默认)   其它: 关闭超时关闭码流功能
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_auto_close_stream(int disable);

DLLIMPORT
int p_vsdk_add_dev_to_dev_talk(char *dev_1_guid,
							   char *dev_2_guid
							   );

DLLIMPORT
int p_vsdk_clear_dev_to_dev_talk(char *dev_guid);

DLLIMPORT
int p_vsdk_get_person_finger_status(char* dev_guid, int person_id);
