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
//						�¼�����
/**********************************************************/
#define SDK_EVENT_CALL_KEY_PRESS			0x01 // ���а�ť������
#define SDK_EVENT_BAT_LOW					0x02 // ���Ƿѹ
#define SDK_EVENT_BAT_HIGH					0x03 // ��ع�ѹ
#define SDK_EVENT_AC_COME					0x04 // �е�����
#define SDK_EVENT_AC_LOSE					0x05 // �е����
#define SDK_EVENT_PWR_ON					0x06 // ��������
#define SDK_EVENT_CALL_START				0x07 // ���п�ʼ
#define SDK_EVENT_CALL_END					0x08 // ���н���
#define SDK_EVENT_CALL_FAIL					0x09 // ����ʧ��
#define SDK_EVENT_DURE_CORE_ERR				0x0a // ����ģ�����
#define SDK_EVENT_3G_LOST					0x0b // 3G�źŶ�ʧ
#define SDK_EVENT_CALL_GO_ON				0x0c // ���м���
#define SDK_EVENT_FC_ALARM					0x0d // ��屻��
#define SDK_EVENT_FC_RECOVER				0x0e // ��屻��ָ�
#define SDK_EVENT_HEART_BEAT				0x0f // ������
#define SDK_EVENT_LOST_LINK_ALARM			0x10
#define SDK_EVENT_LOST_LINK_RECOVER			0x11
#define SDK_EVENT_VIDEO_LOST				0x12 // ��Ƶ��ʧ
#define SDK_EVENT_VIDEO_RECOVER				0x13 // ��Ƶ��ʧ
#define SDK_EVNET_FAST_SNAP_FINE			0x14 // ץͼ�ɹ�
#define SDK_EVENT_FAST_SNAP_TIMEOUT			0x15 // ץͼʧ��
#define SDK_EVNET_FAST_SNAP_DONE			0x16 // 
#define SDK_EVENT_TALK_KEY_PRESS			0x17 // ���а�ť������
#define SDK_EVENT_FQ_KEY_PRESS              0x18
#define SDK_EVENT_PASSTHROUGH				0x1b // ͸���¼����������Ϳͻ���
#define SDK_EVENT_REMOTE_UPGRADE			0x20
#define SDK_EVENT_DEVICE_VERISON			0x21
#define SDK_EVENT_GET_RECORD_MAP            0x22 // ��ȡ¼��ӳ���
#define SDK_EVENT_REMOTE_UPGRADE_OK			0x23
#define SDK_EVENT_POWER_UP_OK				0x24
#define SDK_EVENT_STD_ERR                   0x25 // ��׼����
#define SDK_EVENT_FINGER_PRESS				0x26
#define SDK_EVENT_FINGER_REBOOT				0x27
#define SDK_EVENT_ECL_MAIN_EVENT            0x28 // �����¼�
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

/**********************************************************/
//						���ؽ������
/**********************************************************/
#define RET_UNDEFINE_ERR		0	// δ֪����
#define RET_OK					1	// ���سɹ�
#define RET_EMPTY_EVENT			2	// ���¼�
#define RET_NO_FIND_DEVICE		3	// �豸������
#define RET_NO_INIT_AUDIO		4	// δ��ʼ����Ƶ�豸
#define RET_EMPTY_GUID			5	// ���豸Ψһ���
#define RET_DEV_OFF_LINE		6	// �豸����
#define RET_OPEN_FILE_FAIL		7	// ���ļ�ʧ��
#define RET_NO_ENOUGH_MEM		8	// �ڴ�ռ䲻��
#define RET_CLOSE_ALREADY		9	// �ظ��ر�
#define RET_INIT_ALREADY		10	// �ظ���ʼ��
#define RET_WAIT_TIME_OUT		11	// ������ʱ

#define D3D_ERR_CREATE_DEVICE_FAIL						0x01		// ����DirectX�豸ʧ�ܣ������Կ������Ƿ��쳣
#define D3D_ERR_CREATE_OFFSCREEN_PLAIN_SURFACE_FAIL		0x02		// ����DirectX��������ʧ�ܣ������Կ������Ƿ��쳣
#define D3D_ERR_GET_BACK_BUFFER_FAIL					0x03        // ��ȡDirectX������ʧ�ܣ������Կ������Ƿ��쳣
#define D3D_ERR_CREATE_D3D_FAIL							0x04		// ����DirectXʵ��ʧ�ܣ����������Ƿ�װDirectX�׼�


#define MSG_CB_NEW_DEVICE_ONLINE		1 // ���豸����
#define MSG_CB_DEVICE_LOST_CONN			2 // �豸����
#define MSG_CB_NEW_CLIENT_ONLINE		3 // �ͻ�������
#define MSG_CB_CLIENT_LOST_CONN			4 // �ͻ��˵���
#define MSG_CB_RE_VIDEO_READY			5 // Ԥ¼���ȡ���
#define MSG_CB_RE_VIDEO_FIAL			6 // Ԥ¼���ȡʧ��
#define MSG_CB_PICTURE_READY			7 // ͼƬ��ȡ���
#define MSG_CB_PICTURE_FAIL				8 // ͼƬ��ȡ���
#define MSG_CB_DETECT_CONFLICT_DEVICE	9 // ��⵽�豸��ַ��ͻ
#define MSG_CB_DETECT_CONFLICT_CLIENT	10// ��⵽�ͻ��˵�ַ��ͻ
#define MSG_CB_SYSTEM_INIT_FAIL			11// ϵͳ��ʼ��ʧ��
#define MSG_CB_NEW_DEVICE_EVENT			12// �µ��豸�¼��ϴ�
#define	MSG_CB_LOST_DATA_VIDEO			13// ̫��ʱ��û�н��յ���Ƶ���ݣ�����ͨ�����ر�
#define MSG_CB_LOST_DATA_AUDIO			14// ̫��ʱ��û�н��յ���Ƶ���ݣ�����ͨ�����ر�
#define MSG_CB_NO_EXIST_DEVICE			15// �豸������
#define MSG_CB_NO_EXIST_CLIENT			16// �ͻ��˲�����
#define MSG_CB_NO_DEFINE_CLIENT			17// ���ܾ��ͻ���
#define MSG_CB_REC_VIDEO_DONE			18// ¼���ļ����
#define MSG_CB_REC_AUDIO_DONE			19// ¼���ļ����
#define MSG_CB_REC_VIDEO_START			20// ¼��ʼ
#define MSG_CB_REC_AUDIO_START			21// ¼����ʼ
#define MSG_CB_RT_VIDEO_START			22// ��ʼʵʱ��������
#define MSG_CB_RT_VIDEO_END				23// ֹͣʵʱ����
#define MSG_CB_RT_AUDIO_START			24// ��ʼ��������
#define MSG_CB_RT_AUDIO_END				25// ֹͣ��������
#define MSG_CB_RT_VIDEO_CLOSE_TIMEOUT	26// ��ʱ�ر�ʵʱ����
#define MSG_CB_RT_AUDIO_CLOSE_TIMEOUT	27// ��ʱ�ر������Խ�
#define MSG_CB_RT_REC_AUDIO_FIAL		28// ����¼��ʧ��
#define MSG_CB_RT_REC_VIDEO_FAIL		29// ¼���ļ�ʧ��
#define MSG_CB_RT_CLIENT_RE_OPEN		30// ͬһ���ͻ��˶�δ���Ƶ���ߴ�ͬһ��ͨ��
#define MSG_CB_RT_DEVICE_RE_OPEN		31// ͬһ���豸������ͻ���ͬʱ������
#define MSG_CB_REC_VIDEO_GO_START		32// ׼��¼��
#define MSG_CB_GET_REC_LIST_OK			33// �б��ȡ���
#define MSG_CB_GET_REC_LIST_FAIL		34// �б��ȡʧ��
#define MSG_CB_UPDATE_DB_FAIL			35
#define MSG_CB_NETWORDK_WARNING			36
#define MSG_CB_D3D_ERROR				37 // Ӳ����Ⱦ����
#define MSG_CB_AV_PB_STOP				38 // ¼��طŽ���
#define MSG_CB_GET_RECORD_MAP			39 // ��ȡ¼���ļ�ӳ��
#define MSG_CB_ROUTE_CHANGE				40 // �豸·�ɷ����ı�
#define MSG_CB_CONFIG_GSET				41 // �����趨�ͻ�ȡ
#define MSG_CB_PCM_DATA					42 // �豸��ƵLPCM��������
#define MSG_CB_DEVICE_HB				43
#define MSG_CB_DEVICE_GPS_LOC			44
#define MSG_CB_DEVICE_CELL_LOC			45
#define MSG_CB_DEVICE_DISK_INFO			46
#define MSG_CB_DEVICE_VALID_PANNEL		47
#define MSG_CB_DEVICE_CAM_OFFLINE		48
#define MSG_CB_AV_DL_STOP				49
#define MSG_CB_PASSTHROUGH_PROTO		50 // ͸��Э����

/* ������豸��Ϣ */
typedef struct
{
	/// �豸��ʱ����ID��
	u32		client_id;
	/// �豸ȫ��Ψһ��ʶ��
	u8		guid[CD_GUID_LEN];
	/// �豸�Ƿ�����
	u8		online;
	/// �豸�Ƿ񽻻���Ϣ��ϣ����ڿ���״̬
	u8		ready;
	int		last_online_time;
#if 0
	u16		port;
	char	addr[20];
#endif
}client_info_lite;

/* ������豸��Ϣ�б� */
typedef struct
{
	/// �豸��Ϣ�ṹ���б�
	client_info_lite	client_info[MAX_DEVICE_INFO_SUM];
	/// �豸���߸���
	u32			client_online;
	/// �ܵ������豸������������δ���߸���
	u32			client_all;
}client_info_all;

/* ��ȫ���豸������Ϣ */
typedef struct
{
	u32		client_id;			/// �豸��ʱ����ID��
	u8		guid[CD_GUID_LEN]; 	/// �豸ȫ��Ψһ��ʶ��
	u8		online;				/// �豸�Ƿ�����
	u8		ready;				/// �豸�Ƿ񽻻���Ϣ��ϣ����ڿ���״̬

	u32		ser1_ip;			/// ������1IP
	u16		ser1_c_port;		/// ������1����˿�
	u16		ser1_v_port;		/// ������1��Ƶ�˿�
	u16		ser1_a_port;		/// ������1�����˿�

	u32		ser2_ip;			/// ������1IP
	u16		ser2_c_port;		/// ������1����˿�
	u16		ser2_v_port;		/// ������1��Ƶ�˿�
	u16		ser2_a_port;		/// ������1�����˿�

	u8		hb_interver;		/// ���������ͼ��
	u8		send_prefer;		/// ��������������ѡ��
	u16		max_bitrate;		/// �������������
	u8		static_encode;		/// ��̬���ʱ仯��С����ֵ
	u8		dynamic_encode;		/// ��̬���ʱ仯�������ֵ
	u8		encode_size;		/// �ϴ�����ͼ���С
	u16		up_video_delay;		/// �ϴ��ӳ�
	u8		encode_type;		/// �ϴ���������
	u8		up_midium;			/// �ϴ�ͨ��ѡ��
	u16		up_overtime;		/// �����ϴ���ʱʱ��
	u8		descript_name[40];	/// �豸������		
	int		last_online_time;	/// �豸�������ʱ��
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
  * @brief	��ʼ������SDK,��Ҫ�����к�������֮ǰʹ��
  *			
  *	@param  ipaddr: ��Ҫ�󶨵ı�����������ַ�����ڷ�ֹ��������ͻ
  *	                @arg NULL           ���԰���������
  *	                @arg 4�ֽ�������ַ  ��ָ������
  *	                
  *	@param  port:  �󶨵ı����˿�
  *
  * @retval void   ����Ϊ��
  * 
  * @attention     �ú�����󶨶˿ڣ����������иú���֮ǰ��Ҫע���Ƿ����
  *                ͬ���ĳ���δ�رգ����δ�ر����޷��ٴε��øó���
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
  * @brief	������ҳ���·��(ȫ·������ΪӢ��)
  *			
  * @retval void ����Ϊ��
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_default_html_path(const char *path);

/**
  * ***********************************************************************
  * @brief	�ر�SDK
  *			
  * @retval void ����Ϊ��
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_close(void);

/**
  * ***********************************************************************
  * @brief	�趨���紫�����
  *			
  *	@param  client_no:  �豸���к�
  *	
  *	@param  channel:    �豸��Ƶͨ����
  *	                    @arg Ĭ��Ϊ0ͨ�������ڿɼ��ݶ�ͨ��
  *	                    
  *	@param  state:      ������ر�ͨ��
  *	                    @arg 1 ����RVCģ��
  *	                    @arg 0 �ر�RVCģ��
  *	                    
  *	@param  ip1:        ��������IP��ַ
  *	@param  c_port1:    �������������˿�
  *	@param  s_port1:    ����������Ƶ������˿�
  *	@param  a_port1:    ������������������˿�
  *	
  *	@param  ip2:        ���ݷ�����IP��ַ
  *	@param  c_port2:    ���ݷ����������˿�
  *	@param  s_port2:    ���ݷ�������Ƶ������˿�
  *	@param  a_port2:    ������������������˿�
  *	
  *	@param  cgrp_prior: ��ǰ���ȴ���ĵ�ַ
  *	                    @arg 1�����ȴ�����������
  *	                    @arg 2: ���ȴ��䱸�ݷ�����
  *	                    
  *	@param  interval:   ���������·ά�ְ����ͼ��
  *	                    @arg x: ��λΪ��
  *
  * @retval void        ����Ϊ��
  * 
  * @attention:         �ó�ʼ��������Ҫ���豸�Ѿ����ߵ�����£����ҿ��Ի�ȡ���豸
  *                     �ľ�����Ϣ������£����е��ã�����ú����޷���Ч
  *                     ��������������ַ�������ַ��֮ǰ����Ĳ�һ�£������´�������Ч
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
  * @brief	    	        �趨Զ���豸��Ƶ������Ϣ
  *			
  *	@param  client_no:      �豸���к�
  *	
  *	@param  channel:        �豸��Ƶͨ����
  *	                        @arg Ĭ��Ϊ0ͨ�������ڿɼ��ݶ�ͨ��
  *	                        
  *	@param  state:          ������ر�ͨ��
  *	                        @arg 1 ����RVCģ��
  *	                        @arg 0 �ر�RVCģ��
  *	                        
  *	@param  maxrate:        �������������
  *	                        @arg 2-1024����λΪKbps
  *	                    
  *	@param  s_rate:         ��̬���ʱ仯�������ֵ
  *	                        @arg 1-51���Ƽ�ֵΪ10
  *	                        
  *	@param  d_rate:         ��̬���ʱ仯��С����ֵ
  *	                        @arg 1-51���Ƽ�ֵΪ35
  *	                        
  *	@param  photo_size:     �ϴ�����ͼ���С,ͼ��ԽС������ͬ�������
  *	                        ͼ���Խ����
  *	                        @arg 1��D1�ֱ��ʴ�С
  *	                        @arg 2��CIF�ֱ��ʴ�С
  *	                        @arg 3��QCIF�ֱ��ʴ�С
  *	                        
  *	@param  upload_delay:   �ϴ��ӳ�
  *	                        @ x����λΪ���룬�ڸú���֮��ʼ�ϴ���ƵĬ��Ϊ0
  *	                        
  *	@param  rate_type:      �ϴ���������
  *	                        @arg 1��VBR����̬��������Ӧ
  *	                        @arg 2��CBR����̬����
  *	                        
  *	@param  trans_media:    �ϴ�ͨ��ѡ��
  *	                        @arg 1��3G��������Ϊѡ�䣬�޴˿��Զ��л�
  *	                        @arg 2������������Ĭ��Ϊ��ѡ��
  *	                        
  *	@param  overtime:       �����ϴ���ʱʱ��
  *	                        @arg 10-300�����֧��300�������������
  *
  * @retval void            ����Ϊ��
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
  * @brief	�趨����ǰ¼��ʱ��
  *			
  *	@param  client_no:  �豸���к�
  *	
  *	@param  channel:    �豸��Ƶͨ����
  *	                    @arg Ĭ��Ϊ0ͨ�������ڿɼ��ݶ�ͨ��
  *	                    
  *	@param  vedio_time: ¼��ʱ����Ĭ��Ϊ10s
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
  * @brief	��ȡ����ǰ����
  *			
  *	@param  client_no:  �豸���к�
  *	
  *	@param  channel:    �豸��Ƶͨ����
  *                     @arg Ĭ��Ϊ0ͨ�������ڿɼ��ݶ�ͨ��
  *                     
  *	@param  vdo_data:   ����ǰ����ָ�룬�ڲ����룬��Ҫ�ֹ��ͷ�
  *	@param  vdo_len:    ����Ǯ���ݳ���
  *	@param  file_path:  ����ǰ¼�񱣴�·�������ں��ڻط�ʹ�� 
  *	
  *	@param  ret_val:    ����ִ�н��
  *
  * @retval void        ����Ϊ��
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
  * @brief	��ȡ���е��豸����
  *			
  *	@param  client_sum: �豸����
  *
  * @retval void        ����Ϊ��
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_client_sum(int * client_sum,
						   u8  * ret_val);


/**
  * ***********************************************************************
  * @brief	��ѯָ���豸���к��Ƿ�����
  *			
  *	@param  guid:		�豸Ψһ��ʶ��
  *
  * @retval bool:		�����豸�Ƿ�����
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
bool p_vsdk_get_device_online(char * guid);
/**
  * ***********************************************************************
  * @brief	��ȡ�����豸��Ϣ
  *			
  *	@param  client_NO:  �豸���к�
  *	@param  info:       �豸��Ϣ
  *
  * @retval void        ����Ϊ��
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_device_info_one(char					*guid,
								client_info_complete	* info,
								u8						* ret_val);
/**
  * ***********************************************************************
  * @brief	��ȡ���е��豸��Ϣ
  *			
  *	@param  info_array: �豸��Ϣ�б�
  *
  * @retval void        ����Ϊ��
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_get_device_info_all(client_info_all   *info_array);
/**
  * ***********************************************************************
  * @brief	������Ƶ�ز�����
  *			
  *	@param  path:       �ز���Ƶ�ļ�·��
  *	@param  handle:     �ػ�ؼ���� 
  *	@param  ret_val:    ����ִ�н�� 
  *
  * @retval void        ����Ϊ�� 
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_play(char    *path,
						  void    *handle,
						  u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	ֹͣ��Ƶ�ز�
  *			
  *	@param  handle:     �ػ�ؼ����
  *	@param  ret_val:    ����ִ�н��
  *
  * @retval void        ����Ϊ��
  * 
  * @attention          �ڵ��øú���֮ǰ�����ڵ��ÿؼ�����֮��
  *                     �����ͬһ���ؼ�ǰ�󲥷Ų�һ������������������
  *                     �����������̣�����ؼ������ػ��ͻ��                     
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_stop(void    *handle,
						  u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	��ͣ��Ƶ�ز�
  *			
  *	@param  handle:     �ػ�ؼ����
  *	@param  ret_val:    ����ִ�н��
  *
  * @retval void        ����Ϊ�� 
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_playback_pause(void    *handle,
						   u8      *ret_val);

/**
  * ***********************************************************************
  * @brief	��ȡ�ز���Ƶ����ʱ��
  *			
  *	@param  path:   �ز���Ƶ�ļ�·��
  *	@param  handle: �ػ�ؼ����
  *	@param  time:   ����ʱ������λΪ����
  *
  * @retval void    ����Ϊ�� 
  * 
  * @attention      �ڵ��øú���֮ǰ����ȷ���ļ�Ϊh264������Ƶ
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
  * @brief	Զ�̿�����������
  *			
  *	@param  guid:       �豸Ψһ��ʶ�� 
  *	@param  delay :		�����ӳ�
  *	@param  ret_val :	���ؽ��
  *
  * @retval void        ����Ϊ��
  * 
  * @note	
  * ***********************************************************************
  */
DLLIMPORT 
void p_vsdk_reboot(char *guid,u8 delay, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	�趨�豸����������Ϣ��Unicode����
  *			
  *	@param  guid :		�豸Ψһ��ʶ��
  *	@param  descript :	�豸������Ϣ
  *	@param  ret_val :	���ؽ��
  *
  * @retval void :		���ؽ��δ��
  * @note	
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_dev_descript(char *guid,u8 *descript, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	Զ�̲�����Ƶ�ļ�
  *			
  *	@param  guid :		    �豸Ψһ��ʶ��
  *	@param  audio_index :	��Ƶ�ļ����
  *	@param  ret_val :	    ���ؽ��
  *
  * @retval void :		���ؽ��δ��
  * @note	
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_remote_play_audio(char *guid,u8 audio_index, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	������Ƶ�ļ����豸������
  *			
  *	@param  char * guid:	�豸GUID
  *	@param  char * url:		��Ƶ�ļ���ַ
  *
  * @retval int:		ͳһ���
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
  * @brief	���豸ָ��ͨ�����н�ͼ�������ļ�
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  snap_count:		ץȡͼƬ����
  *	@param  snap_interver:	ץȡͼƬ���
  *	@param  channel:		ץͼͨ����
  *	@param  file1_path:		ͼ���ļ�1
  *	@param  file2_path:		ͼ���ļ�2
  *	@param  file3_path:		ͼ���ļ�3
  *	@param  file4_path:		ͼ���ļ�4
  *	@param  file5_path:		ͼ���ļ�5
  *	@param  ret_val:		���ؽ��
  *
  * @retval void:			���ؽ��δ��
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
  * @brief	����һ���µĿͻ���
  *			
  *	@param  client_guid: �ͻ���Ψһʶ����
  *
  * @retval void: ����δ��
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT  
void p_sdks_add_client(u8 *client_guid);

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
int p_vsdk_reg_msg_callback(void *func);

/**
  * ***********************************************************************
  * @brief	ע���������¼����Ƶ���ݻص�����
  *			
  *	@param  func: �ص�����ָ��
  *
  * @retval void: ����δ��
  * 
  * @attention ���� "p_pb_video_data_callback" �����������func�������͹���
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_reg_pb_video_data_callback(void *func);

/**
  * ***********************************************************************
  * @brief	ע���������ʵʱ��Ƶ���ݻص�����
  *			
  *	@param  func: �ص�����ָ��
  *
  * @retval void: ����δ��
  * 
  * @attention ���� "p_rt_video_data_callback" �����������func�������͹���  
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_reg_rt_video_data_callback(void *func);

/**
  * ***********************************************************************
  * @brief	����¼���ļ�·��
  *			
  *	@param  path:	¼���ļ�·��
  *
  * @retval int:	�ɹ�����1 ʧ�ܷ���0
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_record_path(char * path);


/**
  * ***********************************************************************
  * @brief	��ȡ�豸¼���б�
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  start_time:		¼��ʼʱ��
  *	@param  end_time:		¼�����ʱ��
  *	@param  is_alarm_file:	�Ƿ�Ϊ����¼��
  *								@arg 1: Ҫ��ȡ��¼��Ϊ����¼��
  *								@arg 0: Ҫ��ȡ��¼��Ϊ��ͨ¼��
  *
  * @retval int:			�����ؽ���б�
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
  * @brief	ftp��ȡ�豸¼���ļ�
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  path:			��Ҫ�豸ȥ�ϴ��ļ���
  *	@param  username:		ftp�˻���
  *	@param  password:		ftp����
  *	@param  ftp_ip_address: ftp��������ַ
  *	@param  ftp_port:		ftp�˿�
  *	@param  file_name:		�豸¼���ļ���
  *	@param  is_alarm_file:	�Ƿ�Ϊ����¼��
  *								@arg 1: Ҫ��ȡ��¼��Ϊ����¼��
  *								@arg 0: Ҫ��ȡ��¼��Ϊ��ͨ¼��
  *
  * @retval int:			�����ؽ���б�
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
  * @brief	ͨ��Զ��ftp�豸������������
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  path:			��Ҫ�豸ȥ���ص������ļ���
  *	@param  username:		ftp�˻���
  *	@param  password:		ftp����
  *	@param  ftp_ip_address: ftp��������ַ
  *	@param  ftp_port:		ftp�˿�
  *
  * @retval int:			�����ؽ���б�
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
  * @brief	��ȡ�豸�ϵ�ָ�����У���
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  form_type:		������
  *								@arg 1: ��Ա��
  *								@arg 2: ��Ա���
  *								@arg 3: ʱ�����
  *	@param  cksum:			��ȡ����У���
  *
  * @retval int:			�����ؽ���б�
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
  * @brief	�����豸�ϵ�ָ���������
  *			
  *	@param  guid:			�豸Ψһ��ʶ��
  *	@param  form_type:		������
  *								@arg 1: ��Ա��
  *								@arg 2: ��Ա���
  *								@arg 3: ʱ�����	
  *	@param  form_data:		�������
  *	@param  form_dat_len:	��ĳ���
  *	
  * @retval int:			�����ؽ���б�:
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
  * @brief	��ȡ�豸��������ͷ��װ״̬
  *			
  *	@param  guid:	�豸Ψһ��ʶ��
  *
  * @retval int:	���֧��16·����������ͷ��װ״̬��
  *					0b -16��0- -0000 0000 0000 ihfe dcba-  
  *					a:��������ͷ0�İ�װ״̬��1Ϊ����ӣ�2Ϊδ���
  *					b:��������ͷ1�İ�װ״̬��1Ϊ����ӣ�2Ϊδ���
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_get_device_net_install_statu(char * guid);


/**
  * ***********************************************************************
  * @brief	��ȡ��ǰ�豸·��ѡ��״̬
  *			
  *	@param  guid:	�豸Ψһ��ʶ��
  *
  * @retval int:	��ǰ�豸·��״̬
  *						@arg 1: ֻʹ��3G/4G
  *						@arg 2: ֻʹ������
  *						@arg 3: �������ȣ�3G/4G��Ϊ������·
  *						@arg 4: 3G/4G���ߣ�������Ϊ������·
  *
  * @attention	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_route_choose(char * guid);

/**
  * ***********************************************************************
  * @brief	��ȡ��ǰ�豸GSMģ���ź�ǿ��
  *			
  *	@param  guid:	�豸Ψһ��ʶ��
  *
  * @retval int:	�ź�ǿ�ȣ�0-31
  *
  * @attention	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_gsm_signal(char *guid);

/**
  * ***********************************************************************
  * @brief	�����趨�豸�ʺ�����
  *			
  *	@param  guid:	�豸Ψһ��ʶ�� 
  *
  * @retval int:	�����ؽ���б�
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_reset_device_password(char *guid);


/**
  * ***********************************************************************
  * @brief	��ȡ�豸�汾��
  *			
  *	@param  guid:	�豸Ψһ��ʶ�� 
  *
  * @retval int: �����ؽ���б�
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_device_version(char *guid);

/**
  * ***********************************************************************
  * @brief	���豸����Զ������
  *			
  *	@param  guid:				�豸Ψһʶ����
  *	@param  upgrade_bin_path:	�����ļ���ַ
  *
  * @retval int: �����ؽ���б�
  * 
  * @attention     
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_http_upgrade(char *guid, char *upgrade_bin_path);

/**
  * ***********************************************************************
  * @brief	�ı��豸����Ƶ����Э��
  *			
  *	@param  guid:				�豸Ψһʶ����
  *	@param  char * tcp_udp:		ͨѶЭ��
  *									@arg "TCP":����TCP������Ƶ����
  *									@arg "UDP":����UDP������Ƶ����
  *
  * @retval int: �����ؽ���б�
  * 
  * @attention   Ŀǰ��������8604����Ϊ8604ֻ֧��UDP���ʡ�
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_transport_protocol(char *guid, char *tcp_udp);

/**
  * ***********************************************************************
  * @brief	�ı��豸ָ��ͨ����Ƶ��������
  *			
  *	@param  guid:				�豸Ψһʶ����
  *	@param  int channel:		�豸��Ƶͨ����
  *	@param  char * quality:		��Ƶ��������
  *									@arg "CIF":  CIF����
  *									@arg "D1":	 D1����
  *									@arg "720P": 1280*720����
  *
  * @retval int:	�����ؽ���б�
  * 
  * @attention		Ŀǰ8604��֧��720P���ʣ�������ݸò�����ȥ����ط�����Ч�� 
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_video_quality(char *guid,int channel, char *quality);

/**
  * ***********************************************************************
  * @brief	Զ�̿����������
  *			
  *	@param  guid:				�豸Ψһʶ����
  *	@param  int out_fq_number:	�豸�����������
  *	@param  int val:			�������ֵ
  *	@param  int mode:			��������ģʽ
  *									@arg 1: �ֶ�ģʽ
  *									@arg 0: �Զ�ģʽ
  *
  * @retval int:	�����ؽ���б�
  * 
  * @attention		��
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_control(char *guid, int out_fq_number, int val, int mode);

/**
  * ***********************************************************************
  * @brief	Զ�̿��ƴ�����
  *			
  *	@param  guid:	�豸Ψһʶ����
  *
  * @retval int:	�����ؽ���б�
  * 
  * @attention		��
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_remote_open_door(char *guid);

/**
  * ***********************************************************************
  * @brief	���豸����̨����ˮƽ��ֱ����ת������
  *			
  *	@param  char * guid:			�豸Ψһʶ����
  *	@param  int vertical_direct:	��ֱת������
  *	@param  int vertical_speed:		��ֱת���ٶ�
  *	@param  int horizon_direct:		ˮƽת������
  *	@param  int horizon_speed:		ˮƽת���ٶ�
  *
  * @retval int:	�����ؽ���б�
  * 
  * @attention		��
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
  * @brief	��ȡ�豸¼���ļ�ӳ���
  *			
  *	@param  char * guid:	�豸Ψһʶ����
  *	@param  int channel:	��Ƶͨ����
  *	@param  u32 start_ts:	��ʼʱ���
  *	@param  u32 stop_ts:	����ʱ���
  *
  * @retval int: �����ؽ���б�
  *
  * @attention     ��	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_record_time_map(char *guid,
							   int	channel,
							   u32	start_ts,
							   u32	stop_ts);

/**
  * ***********************************************************************
  * @brief	Զ����������
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *	@param  char * cfg_file:    �����ļ�����
  *	@param  char * cfg_name:    ���ò�������
  *	@param  char * cfg_val:     ���ò���
  *
  * @retval int: �����ؽ���б�
  *
  * @attention     ��	
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_set_dev_config(char *guid,
							  char *cfg_file,
							  char *cfg_name,
							  char *cfg_val);

/**
  * ***********************************************************************
  * @brief	���豸���Դ���������ͷ���о���ѡ������
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *	@param  char * mirroring:	��Ƶ����ѡ��
  *									@arg "mirror_left_right":	���Ҿ���
  *									@arg "mirror_up_down":		���¾���
  *									@arg "mirror_center":		���ľ���
  *									@arg "mirror_none":			�����о���
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_dev_install_mirroring(char *guid, char *mirroring);

DLLIMPORT
int p_vsdk_get_dev_door_states(char *guid);

/**
  * ***********************************************************************
  * @brief	֪ͨ��λ�����¿��б����ݿ�
  *			
  *	@param[in]  char * guid:	�豸Ψһʶ����
  *	@param[in]  char * http_db:	���ݿ�HTTP��ַ
  *
  * @retval int:	�����ؽ���б�
  *
  * @attention		��
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_update_cardlist_db(char *guid, char *http_db);

/**
  * ***********************************************************************
  * @brief	�ϴ��豸Ԥ¼������
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  * @param  int    channel:		Ҫ�ϴ���ͨ��
  *	@param  char * path:		Ҫ�ϴ����ĵ�ַ
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_revideo_data(char *guid, int channel, char *path);

/**
  * ***********************************************************************
  * @brief	�ϴ��豸��������Լ�������־
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *	@param  char * upload_url:	Ҫ�ϴ����ĵ�ַ
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_remote_upload_log(char *guid,char *upload_url, u8 *ret_val);

/**
  * ***********************************************************************
  * @brief	��ȡ�豸�������
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_valid_talk_pannel(char *guid);

/**
  * ***********************************************************************
  * @brief	��ȡ�豸��λ��Ϣ
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_gps_info(char *guid);

/**
  * ***********************************************************************
  * @brief	��ȡ��վ��λ��Ϣ
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_cell_info(char *guid);

/**
  * ***********************************************************************
  * @brief	��ȡ�豸����ʹ����Ϣ
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_get_disk_info(char *guid);

/**
  * ***********************************************************************
  * @brief	����tx outx��Դ
  *			
  *	@param  char * guid:        �豸Ψһʶ����
  *									
  * @retval int:	�����ؽ���б�
  *
  * @attention		��		
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_reset_tx_outx_power(char *guid);

/**
  * ***********************************************************************
  * @brief	�򿪵��Դ���
  *			
  * @retval void:  ����Ϊ��
  * 
  * @attention     ��
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_open_console(void);

/**
  * ***********************************************************************
  * @brief	�رյ��Դ���
  *
  * @retval void:  ����Ϊ��
  * 
  * @attention     ��
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_close_console(void);

/**
  * ***********************************************************************
  * @brief	���÷�������Ƶ�����˿�
  *
  *	@param  int av_port:  ��������Ƶ�����˿�
  * @retval void:  ����Ϊ��
  * 
  * @attention     ��Ҫ�ڵ��ó�ʼ���������ĺ���֮ǰ���øú���
  * ***********************************************************************
  */
DLLIMPORT
int  p_vsdk_set_av_port(int av_port);

/**
  * ***********************************************************************
  * @brief	����ģʽ��ǿ���޸��豸·��״̬
  *
  *	@param  int route:  ·��״̬,2->eth/wlan only, 3->eth/wlan prefer
  *								1->ppp/4g only,   4->ppp/4g prefer
  * @retval void:  ����Ϊ��
  * 
  * @attention    
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_test_device_route(char *guid, int route);

/**
  * ***********************************************************************
  * @brief  Զ��д��ָ��ģ��
  *			
  *	@param  guid:				Զ��GUID
  *	@param  people_bgein_zero:	�����ţ���0��ʼ
  *	@param  finger_bgein_zero:	ָ�Ʊ�ţ���0��ʼ
  *	@param  tmplate_length:		ģ�峤��
  *	@param  finger_template:	ָ��ģ�壬base64
  *
  * @retval int:				����Ϊ��
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
  * @brief  Զ�̶�ȡָ��ģ��
  *			
  *	@param  guid:				Զ��GUID
  *	@param  people_bgein_zero:	�����ţ���0��ʼ
  *	@param  finger_bgein_zero:	ָ�Ʊ�ţ���0��ʼ
  *
  * @retval int:				����Ϊ��
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
  * @brief  Զ��ɾ��ָ��ģ��
  *			
  *	@param  guid:				Զ��GUID
  *	@param  people_bgein_zero:	�����ţ���0��ʼ
  *	@param  finger_bgein_zero:	ָ�Ʊ�ţ���0��ʼ
  *
  * @retval int:				����Ϊ��
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
  * @brief  ���ú��а�ť��������
  *			
  *	@param  ban_time:	Ҫ���õ�ʱ��
  *	@param  ban_cnt:	������õ���������
  *
  * @retval int:				����Ϊ��
  *
  * @attention	: ���� <= 0�Ĳ��������ر�����
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_call_key_ban(int ban_time, int ban_cnt);

/**
  * ***********************************************************************
  * @brief  �����Ƿ���usb 4g����ģ���Զ�����, ��ʱ��Ч
  *			
  *	@param  en:	��0��ʾ����, 0��ʾ�ر�
  *
  * @retval int:		����Ϊ��
  *
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_usb_4g_auto_ctrl(int en);

/**
  * ***********************************************************************
  * @brief  �Զ�ѡ��usb 4g�ͻ��˴�绰�Խ�
  *			
  *	@param  dev_guid:	�豸GUID
  *	@param  num:		Ҫ�Խ����ֻ��绰����
  *
  * @retval int:		����ΪTRUE, FALSE
  *
  * @attention	:		Ĭ�ϳ�ʱʱ��Ϊ4����
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_usb_4g_auto_dial_talk(char* dev_guid, char *num);

/**
  * ***********************************************************************
  * @brief  �ϴ�ָ��ʱ�䷶Χ�ı���¼��
  *			
  *	@param  start_time:	��ʼʱ���
  *	@param  stop_time:	����ʱ���
  *	@param  upload_url:	�ϴ�·��
  *
  * @retval int:				����Ϊ��
  *
  * @attention	: url�����ϴ���Ŀ¼���ļ������豸�Լ�����,ͨ��: 1~16
				��ʽ: "ARC_ch01_61-385445403930-3736_1527499057.h264"
					ARC_ͨ����_�豸guid_ʱ���.h264
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_upload_alarm_record(char *guid,
								int start_time,
								int stop_time,
								char *upload_url);

/**
  * ***********************************************************************
  * @brief  Զ����������ͷosd
  *			
  *	@param  guid:				Զ��GUID
  *	@param  chnn:				����ͷͨ����[0~3, 8~15]
  *	@param  osd_utf8_base64:	osd, ��base64�����utf8�ַ���
  *
  * @retval int:				����Ϊ��
  *
  * @attention	: none
  * ***********************************************************************
  */
DLLIMPORT 
int p_vsdk_set_cam_osd(char *guid, 
	                   int  channel, 
					   char* osd_utf8_base64);

/**
  * ***********************************************************************
  * @brief  �����Ƿ�رճ�ʱ�ر���������
  *			
  *	@param  disable:	�Ƿ���ó�ʱ�ر���������
  *
  * @retval void:		����Ϊ��
  *
  * @attention	: 0: �򿪳�ʱ�ر���������(Ĭ��)   ����: �رճ�ʱ�ر���������
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_set_auto_close_stream(int disable);

/**
  * ***********************************************************************
  * @brief  �����豸���߳�ʱʱ��
  *			
  *	@param  timeout:	�豸���߳�ʱʱ��(��), ��Χ 10 ~ 65535
  *
  * @retval void:		����ΪTRUE, FALSE
  *
  * @attention	:		Ĭ�ϳ�ʱʱ��Ϊ4����
  * ***********************************************************************
  */
DLLIMPORT
int p_vsdk_set_dev_lost_conn_timeout(int timeout);

DLLIMPORT
int p_vsdk_get_dev_cam_info(char* dev_guid);

DLLIMPORT
int p_vsdk_add_dev_to_dev_talk(char *dev_1_guid,
							   char *dev_2_guid
							   );

DLLIMPORT
int p_vsdk_clear_dev_to_dev_talk(char *dev_guid);

DLLIMPORT
int p_vsdk_get_person_finger_status(char* dev_guid, int person_id);

