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
  * @brief	��ʼ���ͻ���
  *			
  *	@param  guid:			�ͻ���Ψһ��ʶ��
  *	@param  server_ip:		��������ַ
  *	@param  server_c_port:	���������ƶ˿�
  *	@param  server_v_port:	��������Ƶ�˿�
  *	@param  server_a_port:	�����������˿�
  *
  * @retval int:			ͳһ���
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
  * @brief	�������豸�ĶԽ�����
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  channel:		�Խ�ͨ��
  *	@param  mode:			�Խ�ģʽ,1��ȫ˫����2��������3������
  *	@param  enable_record:	�Ƿ�����¼�� 
  *	@param  max_mbyte:		���¼��Ĵ�С��MB����
  *	@param  max_min:		����¼��ʱ�䣬���Ӽ���
  *	@param  rec_file_path:	��Ҫ�ڷ������洢���ļ���
  *
  * @retval int:			ͳһ���
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
  * @brief	�������豸�Ķ����Խ�����
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  channel:		�Խ�ͨ���ṹ��
  *	@param  mode:			�Խ�ģʽ,1��ȫ˫����2��������3������
  *	@param  enable_record:	�Ƿ�����¼�� 
  *	@param  max_mbyte:		���¼��Ĵ�С��MB����
  *	@param  max_min:		����¼��ʱ�䣬���Ӽ���
  *	@param  rec_file_path:	��Ҫ�ڷ������洢���ļ���
  *
  * @retval int:			ͳһ���
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
  * @brief	ֹͣ���豸��ʵʱ�Խ�
  *			
  *	@param  guid:	�豸Ψһ��ʶ��
  *
  * @retval int:	ͳһ���
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT int p_sdkc_stop_talk(char *guid);

/**
  * ***********************************************************************
  * @brief	ֹͣ�������豸�ĶԽ�
  *			
  *	@param  guid:	�豸Ψһ��ʶ��
  *
  * @retval int:	ͳһ���
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT int p_sdkc_stop_talk_all(void);

/**
  * ***********************************************************************
  * @brief	���豸����ʵʱ��Ƶ����
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  channel:		�豸��Ƶͨ����
  *	@param  handle:			���Ŵ��ھ��
  *	@param  enable_record:	�Ƿ�����¼�� 
  *	@param  max_mbyte:		���¼��Ĵ�С��MB����
  *	@param  max_min:		����¼��ʱ�䣬���Ӽ���
  *	@param  rec_file_path:	��Ҫ�ڷ������洢���ļ���
  *
  * @retval int:			ͳһ���
  * 
  * @attention	�ļ���ֻ������Ӣ��Ŀ¼����ֹ�ڴ�����������ڱ���ת�����µ�
  *				�������⡣
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
  * @brief	ֹͣ���豸��ʵʱ��Ƶ����
  *			
  *	@param  guid:		�豸Ψһ��ʶ��
  *	@param  channel:	��Ƶͨ����
  *	@param  handle:		��Ƶ���
  *
  * @retval int:		ͳһ���
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
  * @brief	�趨��Ƶͨ����֡ģʽ
  *			
  *	@param  guid:		�豸Ψһ��ʶ��
  *	@param  channel:	��Ƶͨ����
  *	@param  mode:		��֡ģʽ
  *						@arg 1: 1����֡ģʽ
  *						@arg 2: 2����֡ģʽ
  *						@arg 5: 4����֡ģʽ
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
  * @brief	�鿴�ͻ����Ƿ�����
  *			
  *
  * @retval int: 0���ͻ��˲����ߣ�1���ͻ�������
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
  * @brief	ʹ�ܿͻ���Ӳ����Ⱦ
  *
  * @retval int: ����ʼ��ΪTRUE
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_enable_hw_render();

/**
  * ***********************************************************************
  * @brief	�رտͻ���Ӳ����Ⱦ
  *
  * @retval int: ����ʼ��ΪTRUE
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_disable_hw_render();


/**
  * ***********************************************************************
  * @brief	ע����Ϣ�ص����
  *			
  *	@param  func: �ص�����ָ��
  *
  * @retval void: ����δ��
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_sdkc_reg_msg_callback(void *func);

/**
  * ***********************************************************************
  * @brief	¼���豸�طź���
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  u32 start_ts:	��Ƶ��ʼʱ���
  *	@param  HWND handle:	���ھ��
  *
  * @retval int:		ͳһ���
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
  * @brief  ֹͣ¼���豸�طź���
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  HWND handle:	���ھ��
  *
  * @retval int:		ͳһ���
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
  * @brief	��ȡ¼��ӳ��
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  int start_ts:	��Ƶ��ʼʱ���
  *	@param  int stop_ts:	��Ƶ����ʱ���
  *
  * @retval int:		ͳһ���
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
  * @brief	��ȡ¼��ӳ��
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  int start_ts:	��Ƶ��ʼʱ���
  *	@param  int stop_ts:	��Ƶ����ʱ���
  *
  * @retval int:		ͳһ���
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
  * @brief	���ûط��ٶ�
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  int play_speed:	��Ƶ�ط��ٶ�(0.125X: 125, 0.25X: 250, 0.5X: 500)
  *	                                    (1X: 1000, 2X: 2000, 4X: 4000, 8X: 8000)
  *	@param  int control:	��Ƶ�طſ���(0: pause, 1: play)
  *
  * @retval int:		ͳһ���
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
  * @brief	�趨��Ƶ��������������Ƶ�˿�
  *			
  *	@param  av_port:	��Ƶ�����˿�
  *
  * @retval int:		ͳһ���
  *
  * @attention	:		��Ҫ�ڵ��ó�ʼ���ͻ��˵ĺ���֮ǰ���øú���
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_set_server_av_port(int av_port);

DLLIMPORT
int p_sdkc_set_render(HWND  handle, int enable);

/**
  * ***********************************************************************
  * @brief	������������ͷPTZ�����ƶ�
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *	@param  int x_speed:	x�����ٶ�
  *	@param  int y_speed:	y�����ٶ�
  *	@param  int z_speed:	�����ٶ�
  *
  * @retval int:		ͳһ���
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
  * @brief	������������ͷPTZֹͣ
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  u8 channel:		�豸��Ƶͨ����
  *
  * @retval int:		ͳһ���
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_sdkc_onvif_ptz_stop(char	*guid, 
                               u8	channel);
/**
  * ***********************************************************************
  * @brief	������Ƶ���ŵķŴ�ֵ
  *			
  *	@param  int:		��������Ԥ�Ŵ�ֵ, ȡֵ0~50
  *
  * @retval int:		ͳһ���
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
  * @brief	����¼�����ػص��ӿ�
  *			
  *	@param  int:		
  *
  * @retval int:		ͳһ���
  * 
  * @attention     �����ص�ʱ�����0x00��ʱ�򣬼�¼�����ؽ���, ʱ���0x00����һ֡��Ϊ¼������
  *					������cancelȡ��¼������ʱ����Ҫ�����������ر��ļ����ص����������̹ر�
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
