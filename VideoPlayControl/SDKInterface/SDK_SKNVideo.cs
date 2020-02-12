using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using PublicClassCurrency;
using System.IO;

namespace VideoPlayControl.SDKInterface
{
    /// <summary>
    /// SK8604SDK
    /// </summary>
    public class SDK_SKNVideo
    {


        #region 接口定义

        #region 通用接口

        public delegate void CallBack(int msg_id, string msg_info, int arg1, int arg2, IntPtr data1, int data1_len, IntPtr data2, int data2_len);

        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_ALL_regeist_msg_callback(CallBack callback);



        #endregion


        #region 服务器端接口
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_SERVER_init(int sdk_port, string sdk_xml_cfg_full_path, string default_save_file_dir);

        /// <summary>
        /// 根据GUID判断设备是否在线
        /// </summary>
        /// <param name="device_guid"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_SERVER_get_device_online(string device_guid);


        #endregion
        /**初始化客户端SDK
          * ***********************************************************************
          * @param  server_addr:            目标服务器字符串地址, "127.0.0.1"
          * @param  server_port:            目标服务器端口
          * @param  client_guid:            本客户端端口
          * @param  sdk_xml_cfg_full_path:  SDK配置文件存储路径
          * @param  default_save_dir:       SDK存储文件根路径 比如录像 抓图
          *
          * @retval int: 详见返回列表
          *
          * @attention  : none
          * ***********************************************************************
         */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_init(string server_addr,int server_port,string client_guid,string sdk_xml_cfg_full_path,string default_save_dir);

        /**初始化客户端SDK
          * 打开调试窗口
         */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_ALL_open_console();
        /**打开设备实时视频通道
          * ***********************************************************************
          * @param  device_guid:        设备GUID
          * @param  video_channel:      设备视频通道，从1开始到32
          * @param  video_channel_sub:  设备视频通道码流类型，1:主码流，2:子码流
          * @param  handle:             视频播放句柄
          * @param  client_record_path: 在客户端的录像地址，相对地址，如无需录像，则填 0x00/NULL
          * @param  server_record_path: 在服务器的录像地址，相对地址，如无需录像，则填 0x00/NULL
          *
          * @retval int: 详见返回列表
          * 
          * @attention  : none
          * 示例：SDK_NSK_CLIENT_open_rt_video( 设备GUID, 9, 1, HWND, "\\TEST\\test.h264", "\\TEST\\test.h264" );
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_open_rt_video(string device_guid,int video_channel,int video_channel_sub,IntPtr handle,string client_record_path,string server_record_path);
        
        /**关闭设备实时视频通道
          * ***********************************************************************
          * @param device_guid:        设备GUID
         * @param  video_channel:      设备视频通道，从1开始到32
         * @param  video_channel_sub:  设备视频通道码流类型，1:主码流，2:子码流
         *
         * @retval int: 详见返回列表
         *
         * @attention  : none
         ************************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_close_rt_video(IntPtr handle);

        /**从设备获取指定文件
          * ***********************************************************************
          * @param  dev_guid:       设备GUID
          * @param  save_server:    是否文件也在服务器保存
          * @param  dev_path:       设备文件路径
          * @param  save_path:      保存文件相对路径
          *
          * @retval int: 详见返回列表
          *
          * @attention  : none
          * 
          * 获取录像文件列表/获取录像映射表 示例：
          * SDK_NSK_CLIENT_get_file(设备GUID, FALSE, "/hdd/map_md5/FILE_MAP_09", "TEST\\FILE_MAP_09");
          * 
          * 获取录像文件 示例：
          * SDK_NSK_CLIENT_get_file(设备GUID, FALSE, "/hdd/normal/VHS_ch09_61-5737338A0736-3232_1537935738.h264", "TEST\\VHS_ch09_61-5737338A0736-3232_1537935738.h264");
          * 
          * 获取预录像文件 示例：
          * SDK_NSK_CLIENT_get_file(设备GUID, FALSE, "REVIDEO_CHNN_9",  "TEST\\VHS_ch09_61-5737338A0736-3232_REVIDEO.h264");
          * 
          * 远程抓图 示例：
          * SDK_NSK_CLIENT_get_file(设备GUID, FALSE, "SNAP_PIC_9",  "TEST\\SNAP.JPEG");
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_get_file(string dev_guid, bool save_server, string dev_path, string save_path);

        /**传送指定文件到设备上 用于远程升级
          * ***********************************************************************
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
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_get_file();

        /**开启当前客户端的指定设备对讲
          * ***********************************************************************
          * @param  dev_guid:           设备GUID
          * @param  chnn:               对讲面板通道号
          * @param  talk_mode:          对讲模式 1:监听  2：喊话  3：全双工
          * @param  client_record_path: 在客户端的录像地址，相对地址，如无需录像，则填 0x00/NULL
          * @param  server_record_path: 在服务器的录像地址，相对地址，如无需录像，则填 0x00/NULL
          *
          * @retval int: 详见返回列表
          *
          * @attention  : none
          * 
          * // 与设备进行全双工对讲，并打开所有的对讲面板通道 示例：
          SDK_NSK_CLIENT_start_talk( 设备GUID, 0xff, TALK_MODE_FULL, "\\TEST\\test.g711", "\\TEST\\test.g711" );
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_start_talk(string dev_guid,int chnn, int talk_mode,string client_record_path,string server_record_path);


        /**关闭当前客户端的指定设备对讲
          * ***********************************************************************
          * @param  dev_guid: 设备GUID
          *
          * @retval int: 详见返回列表
          *
          * @attention  : none
          * ***********************************************************************
          */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_close_talk(string dev_guid);

        /**关闭当前客户端的所有对讲
          * ***********************************************************************
          * @retval int: 详见返回列表
          *
          * @attention  : none
          * ***********************************************************************
          */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_close_all_talk();


        /**获取或设置设备配置
          * ***********************************************************************
          * @param  guid:     设备GUID
          * @param  cfg_file: 配置文件名称
          * @param  cfg_name: 配置文件中配置项名称
          * @param  cfg_val:  配置文件中配置项值，如为获取配置值，则填 0x00/NULL
          *
          * @retval int: 详见返回列表
          *
          * @confirm    : 
          * @attention  : none
          * 
          * // 获取设备配置
                SDK_NSK_CLIENT_gset_config(设备GUID, "/config/set_server.cfg", "SER1ADDR", NULL);
            // 设置设备配置
                SDK_NSK_CLIENT_gset_config(设备GUID, "/config/set_server.cfg", "SER1ADDR", "www.baidu.com");
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_gset_config(string dev_guid,string cfg_file,string cfg_name,string cfg_val);

        /**远程重启设备
          * ***********************************************************************
          * @param  dev_guid:   设备GUID
          *
          * @retval int:        详见返回列表
          *
          * @confirm    : 
          * @attention  : none
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_reboot_device(string dev_guid);

        /**获取当前客户端与服务器在线状态
          * ***********************************************************************
          * @retval int: 0,客户端不在线  1,客户端在线
          *              
          * @confirm    : 
          * @attention  : none
          * ***********************************************************************
        */
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_is_online();


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

        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_dev_delay_alarm(string dev_guid, int chnn, int timout);


        /// <summary>
        /// 设置OSD
        /// </summary>
        /// <param name="dev_guid"></param>
        /// <param name="chnn"></param>
        /// <param name="base64_osd"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_dev_modify_osd(string dev_guid, int chnn, string base64_osd);


        #region 远程录像回放相关
        /// <summary>
        /// 打开视频录像回放接口
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_start_pb_video(string dev_guid, int video_channel, int start_ts, IntPtr handle);

        /// <summary>
        /// 关闭视频录像回放接口
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_stop_pb_video(IntPtr handle);

        #endregion

        #region 云台控制

        /// <summary>
        /// 远程连续云台控制
        /// </summary>
        /// <param name="dev_guid"></param>
        /// <param name="chnn"></param>
        /// <param name="x_speed"></param>
        /// <param name="y_speed"></param>
        /// <param name="z_speed"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_dev_ovf_ptz_continue_move(string dev_guid, int chnn, int x_speed, int y_speed, int z_speed);


        /// <summary>
        /// 远程停止云台控制
        /// </summary>
        /// <param name="dev_guid"></param>
        /// <param name="chnn"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strSKNVideoSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int SDK_NSK_CLIENT_dev_ovf_ptz_stop(string  dev_guid,int chnn);

        #endregion

        #endregion

        #region 自定义接口

        /// <summary>
        /// 获取本地存储录像映射文件相对路径
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        public static string GetLocalFileMapPath(CameraInfo cInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("/" + cInfo.VideoInfo.DVSAddress + "/");
            sb.Append(GetFileMapName(cInfo));
            return sb.ToString();
        }


        /// <summary>
        /// 获取设备录像映射文件相对路径（设备上路径）
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        public static string GetFileMapPath(CameraInfo cInfo)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("/hdd/map_md5/");
            sb.Append(GetFileMapName(cInfo));
            return sb.ToString();
        }



        /// <summary>
        /// 获取设备录像文件文件名（设备上文件名称）
        /// </summary>
        /// <param name="cInfo"></param>
        /// <returns></returns>
        public static string GetFileMapName(CameraInfo cInfo)
        {
            return "FILE_MAP_" + Convert.ToString(cInfo.Channel).PadLeft(2, '0');
        }

        public static int GetChannelByFileMapPath(string strPath) 
        {
            string Temp_strFileName = Path.GetFileNameWithoutExtension(strPath);
            string Temp_strChannel = Temp_strFileName.Substring(Temp_strFileName.LastIndexOf("_") + 1);
            return Convert.ToInt32(Temp_strChannel);
        }


        public static string GetFilePata_VideoRecord_Remote(VideoInfo vInfo,string strFileName)
        {
            string strResult = "/hdd/normal/" + strFileName;
            return strResult;
        }

        public static string GetFilePata_VideoRecord_Local(VideoInfo vInfo, string strFileName)
        {
            string strResult = "/" + vInfo.DVSAddress + "/" + strFileName;
            return strResult;
        }
        #endregion
        #region 事件定义
        //#define SDK_EVENT_CALL_KEY_PRESS			0x01 // 呼叫按钮被按下				平时无参数, 接多面板时参数为面板ID(1到16)
        //#define SDK_EVENT_BAT_LOW					0x02 // 电池欠压					无参数
        //#define SDK_EVENT_BAT_HIGH					0x03 // 电池过压					无参数
        //#define SDK_EVENT_AC_COME					0x04 // 市电来电					无参数
        //#define SDK_EVENT_AC_LOSE					0x05 // 市电掉电					无参数
        //#define SDK_EVENT_PWR_ON					0x06 // 本机启动					无参数
        //#define SDK_EVENT_CALL_START				0x07 // 呼叫开始					无参数
        //#define SDK_EVENT_CALL_END					0x08 // 呼叫结束					无参数
        //#define SDK_EVENT_CALL_FAIL					0x09 // 呼叫失败					无参数
        //#define SDK_EVENT_DURE_CORE_ERR				0x0a // 防区模块故障				无参数
        //#define SDK_EVENT_3G_LOST					0x0b // 3G信号丢失					无参数
        //#define SDK_EVENT_CALL_GO_ON				0x0c // 呼叫继续					无参数
        //#define SDK_EVENT_FC_ALARM					0x0d // 面板被拆					无参数
        //#define SDK_EVENT_FC_RECOVER				0x0e // 面板被拆恢复				无参数
        //#define SDK_EVENT_HEART_BEAT				0x0f // 心跳包						无参数
        //#define SDK_EVENT_LOST_LINK_ALARM			0x10 //								无参数
        //#define SDK_EVENT_LOST_LINK_RECOVER			0x11 //								无参数
        //#define SDK_EVENT_VIDEO_LOST				0x12 // 视频丢失					通道号(1-4, 9-16)
        //#define SDK_EVENT_VIDEO_RECOVER				0x13 // 视频恢复					通道号(1-4, 9-16)
        //#define SDK_EVNET_FAST_SNAP_FINE			0x14 // 抓图成功					抓图文件名
        //#define SDK_EVENT_FAST_SNAP_TIMEOUT			0x15 // 抓图失败					无参数
        //#define SDK_EVNET_FAST_SNAP_DONE			0x16 // 							无参数
        //#define SDK_EVENT_TALK_KEY_PRESS			0x17 // 呼叫按钮被按下				无参数
        //#define SDK_EVENT_FQ_KEY_PRESS              0x18 // 							无参数
        //#define SDK_EVENT_READ_FINGER_TEMPLATE		0x19 // 指纹模板上传				指纹模板数据, 末尾两字节为指纹编号
        //#define SDK_EVENT_REMOTE_UPGRADE			0x20 //	远程升级日志				字符串, 远程升级结果
        //#define SDK_EVENT_DEVICE_VERISON			0x21 // 获取设备版本				字符串
        //#define SDK_EVENT_GET_RECORD_MAP            0x22 // 获取录像映射表				字符串
        //#define SDK_EVENT_REMOTE_UPGRADE_OK			0x23 // 升级成功					字符串 设备版本
        //#define SDK_EVENT_POWER_UP_OK				0x24 // 上电成功					字符串 设备guid
        //#define SDK_EVENT_STD_ERR                   0x25 // 标准错误					字符串
        //#define SDK_EVENT_FINGER_PRESS				0x26 // 指纹按压					无效: 00000000, 有效: 字符串, 指纹id和图片id
        //#define SDK_EVENT_FINGER_REBOOT				0x27 // 门禁模块重启				无参数
        //#define SDK_EVENT_ECL_MAIN_EVENT            0x28 // 门锁事件					一个字节
        //#define SDK_EVENT_CARD_SWAP_EVENT			0x29 // 刷卡						字符串: 卡id和图片id
        //#define SDK_EVENT_NET_SWITCH_CHANGE			0x2a // 网络切换					字符串日志
        //#define SDK_EVNET_NET_LAN_FAULT				0x2b // 有线故障					无参数
        //#define SDK_EVNET_NET_LAN_RECOVER			0x2c // 有线恢复					无参数
        //#define SDK_EVENT_CARD_LIST_UPDATE			0x2d // 门卡更新日志				字符串
        //#define SDK_EVENT_DOOR_STATES				0x2e // 门状态						1个字节
        //#define SDK_EVENT_DOUBLE_FINGER_PRESS		0x2f // 第二人指纹按下				无参数

        //#define SDK_EVENT_MOTION_DECT				0x40 // 移动侦测					结构体
        //#define SDK_EVENT_HDD_ERR					0x41 // 硬盘故障					无参数
        //#define SDK_EVENT_HDD_REC					0x42 // 硬盘恢复					无参数

        //#define SDK_EVENT_REVIDEO_POST_DONE			0x43 // 预录像上传成功				预录像文件名
        //#define SDK_EVENT_FQ_ALARM                  0x44 // 防区报警					5字节
        //#define SDK_EVENT_ATD		                0x45 // 电话号码					字符串
        //#define SDK_EVENT_ILLEGAL_OPEN_DOOR			0x97 // 非法开门					无参数
        //#define SDK_EVENT_DOOR_OPEN_TIMOUT			0x98 // 门开超时					无参数
        //#define SDK_EVENT_TALK_KEY_RELEASE			0x99 // 呼叫按钮松开				无参数
        #endregion

    }
}
