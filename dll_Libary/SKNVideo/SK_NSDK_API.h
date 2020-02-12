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


#define TALK_MODE_LISTEN        0x01 // �ͻ��˼��� -> �豸��������
#define TALK_MODE_SPEAK         0x02 // �ͻ��˺��� -> �ͻ���������
#define TALK_MODE_FULL          (TALK_MODE_LISTEN | TALK_MODE_SPEAK)
#define MAX_DEVICE_INFO_SUM		65535
#define CD_GUID_LEN				30

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
#define SDK_EVENT_READ_FINGER_TEMPLATE		0x19 // ָ��ģ���ϴ�
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


/* ������豸��Ϣ */
typedef struct
{
	/// �豸��ʱ����ID��
	unsigned int		client_id;
	/// �豸ȫ��Ψһ��ʶ��
	unsigned char		guid[CD_GUID_LEN];
	/// �豸�Ƿ�����
	unsigned char		online;
	/// �豸�Ƿ񽻻���Ϣ��ϣ����ڿ���״̬
	unsigned char		ready;
	int					last_online_time;
}client_info_lite;

/* ������豸��Ϣ�б� */
typedef struct
{
	/// �豸��Ϣ�ṹ���б�
	client_info_lite	client_info[MAX_DEVICE_INFO_SUM];
	/// �豸���߸���
	unsigned int		client_online;
	/// �ܵ������豸������������δ���߸���
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
  * @brief  �ͻ��˺ͷ�����ͨ��ע��ص�����
  *         
  * @param  msg_callback: �ص������ӿ�ָ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_ALL_regeist_msg_callback(p_msg_callback msg_callback);

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
void SDK_NSK_ALL_open_console(void);

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
  * @brief  ��ʼ��������SDK
  *         
  * @param  sdk_port:               ���ؼ����˿ڣ�Ĭ��Ϊ48624
  * @param  sdk_xml_cfg_full_path:  SDK�����ļ��洢·��
  * @param  default_save_file_dir:  SDK�洢�ļ���·��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_init(int sdk_port, const char *sdk_xml_cfg_full_path, const char *default_save_file_dir);

/**
  * ***********************************************************************
  * @brief  ����ʼ��������SDK
  *         
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_deinit(void);

/**
  * ***********************************************************************
  * @brief	��ȡ���ӵ����������豸�Ƿ�������״̬
  *			
  * @param  device_guid:        �豸GUID
  *
  * @retval int: @arg -1 : �豸������
  *              @arg  0 : �豸������
  *              @arg  1 : �豸����
  * @confirm	: 
  * @attention	: ��������ж��豸�Ƿ��������ӹ��������������-1������0����
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_SERVER_get_device_online(char *device_guid);

/**
  * ***********************************************************************
  * @brief	��ȡ���ӵ��������������豸״̬
  *			
  * @param  device_guid:        �豸����
  *
  * @confirm	: 
  * @attention	: 
  * ***********************************************************************
  */
DLLIMPORT
void p_vsdk_get_device_info_all(client_info_all* info_array);

/**
  * ***********************************************************************
  * @brief	����������ʱ(ʵʱ��Ƶ,�ط���Ƶ,�Խ�)
  *			
  * @param  device_guid:        �豸����
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
  * @brief  ��ʼ���ͻ���SDK
  *         
  * @param  server_addr:            Ŀ��������ַ�����ַ, "127.0.0.1"
  * @param  server_port:            Ŀ��������˿�
  * @param  client_guid:            ���ͻ��˶˿�
  * @param  sdk_xml_cfg_full_path:  SDK�����ļ��洢·��
  * @param  default_save_dir:       SDK�洢�ļ���·��
  *
  * @retval int: ��������б�
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
  * @brief  ����ʼ���ͻ���SDK
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_deinit(void);

/**
  * ***********************************************************************
  * @brief  �����Ƿ�ʹ��Ӳ��������Ӳ����Ⱦ, ���´���Ƶ��Ч
  *         
  * @param  decoder_accel:        Ӳ������, 0�ر� 1����
  * @param  render_accel:         Ӳ����Ⱦ, 0�ر� 1����
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_set_hardware_accel(int decoder_accel,
									int render_accel);

/**
  * ***********************************************************************
  * @brief  ���豸ʵʱ��Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  * @param  video_channel:      �豸��Ƶͨ������0��ʼ��31
  * @param  video_channel_sub:  �豸��Ƶͨ���������ͣ�1:��������2:������
  * @param  client_record_path: �ڿͻ��˵�¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  * @param  server_record_path: �ڷ�������¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  *
  * @retval int: ��������б�
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
  * @brief  �ر��豸ʵʱ��Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  *	@param  hwnd:				���ھ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_rt_video(HWND hwnd);

/**
  * ***********************************************************************
  * @brief  ���豸¼��ط���Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  * @param  video_channel:      �豸��Ƶͨ������0��ʼ��31
  * @param  start_ts:           �豸��Ƶͨ��ʼʱ���
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_start_pb_video(const char *device_guid, int chnn, int start_ts, HWND handle);

/**
  * ***********************************************************************
  * @brief  �ر��豸¼��ط���Ƶͨ��
  *         
  * @param  device_guid:        �豸GUID
  *	@param  handle:				���ھ��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_stop_pb_video(HWND handle);

/**
  * ***********************************************************************
  * @brief  ����ָ���ļ����豸��
  *         
  * @param  dev_guid:       �豸GUID
  * @param  save_server:    �Ƿ��ļ�Ҳ�ڷ���������
  * @param  file_path:      �ļ�·��
  * @param  store_path:     ���豸�ϵ�·�������ļ���
  *
  * @retval int: ��������б�
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
  * @brief  ���豸��ȡָ���ļ�
  *         
  * @param  dev_guid:       �豸GUID
  * @param  save_server:    �Ƿ��ļ�Ҳ�ڷ���������
  * @param  dev_path:       �豸�ļ�·��
  * @param  save_path:      �����ļ����·��
  *
  * @retval int: ��������б�
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
  * @brief  ����ָ���ļ����豸��
  *         
  * @param  dev_guid:       �豸GUID
  * @param  file_path:      ������·��
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_device_upgrade(const char* dev_guid, const char* file_path);

/**
  * ***********************************************************************
  * @brief  ������ǰ�ͻ��˵�ָ���豸�Խ�
  *         
  * @param  dev_guid:           �豸GUID
  * @param  chnn:               �Խ����ͨ����
  * @param  talk_mode:          �Խ�ģʽ
  * @param  client_record_path: �ڿͻ��˵�¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  * @param  server_record_path: �ڷ�������¼���ַ����Ե�ַ��������¼������ 0x00/NULL
  *
  * @retval int: ��������б�
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
  * @brief  �رյ�ǰ�ͻ��˵�ָ���豸�Խ�
  *         
  * @param  dev_guid: �豸GUID
  *
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_talk(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  �رյ�ǰ�ͻ��˵����жԽ�
  *         
  * @retval int: ��������б�
  *
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_close_all_talk(void);

/**
  * ***********************************************************************
  * @brief  Զ�������豸
  *         
  * @param  dev_guid:   �豸GUID
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_reboot(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  ��ȡ�豸�汾
  *         
  * @param  dev_guid:   �豸GUID
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : �ɻص���������
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_get_version(const char *dev_guid);

/**
  * ***********************************************************************
  * @brief  Զ���޸�osd
  *         
  * @param  dev_guid:   �豸GUID
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_dev_modify_osd(const char* dev_guid, int chnn, const char* base64_osd);

/**
  * ***********************************************************************
  * @brief  �ֶ��������Ų��ӳٹر�
  *         
  * @param  dev_guid:   �豸GUID
  * @param  chnn:		����ͨ����1~5)
  * @param  dev_guid:   ����ʱ��(0~5����)
  *
  * @retval int: ��������б�
  *
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */

DLLIMPORT
int SDK_NSK_CLIENT_dev_delay_alarm(const char* dev_guid, int chnn, int timout);

/**
  * ***********************************************************************
  * @brief  ��ȡ��ǰ�ͻ��������������״̬
  *
  * @retval int: 0, �ͻ��˲�����  1,�ͻ�������
  *              
  * @confirm    : 
  * @attention  : none
  * ***********************************************************************
  */
DLLIMPORT
int SDK_NSK_CLIENT_is_online();

/**
  * ***********************************************************************
  * @brief  ��ȡ�������豸����
  *         
  * @param  guid:     �豸GUID
  * @param  cfg_file: �����ļ�����
  * @param  cfg_name: �����ļ�������������
  * @param  cfg_val:  �����ļ���������ֵ����Ϊ��ȡ����ֵ������ 0x00/NULL
  *
  * @retval int: ��������б�
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

