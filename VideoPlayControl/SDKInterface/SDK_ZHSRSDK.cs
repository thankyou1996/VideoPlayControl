using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl.SDKInterface
{
    /// <summary>
    /// 珠海三润
    /// </summary>
    public class SDK_ZHSRSDK
    {

        const string strPath_Dll = "\\ZHSRSDK\\win_sta_core.dll";

        #region 自定义

        /// <summary>
        /// 回调类型说明
        /// </summary>
        public class Main_Callback_Type
        {
            /// <summary>
            /// 用户登录结果
            /// </summary>
            public const string usr_login_ret = "usr_login_ret";

            /// <summary>
            /// 监听任务状态
            /// </summary>
            public const string monitor_tsk_status = "monitor_tsk_status";

            /// <summary>
            /// 对讲状态回调
            /// </summary>
            public const string tk_tsk_status = "tk_tsk_status";
        }

        #endregion

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void func_cb_cli(int sess_client, ulong usr_data, string type, string key, string value, string value2);

        public static func_cb_cli func_Cb_Cli;

        /// <summary>
        /// 预初始化
        /// </summary>
        /// <param name="module_path">当前程序所在路径</param>
        /// <param name="func">接口消息回调</param>
        /// <param name="usr_data">外部自定义参数</param>
        /// <param name="aud_type">默认 0-表示音频采样44.1K，G711编码、1-表示音频采样32K，PCM格式</param>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static void win_sta_pre_init(string module_path, func_cb_cli func, ulong usr_data = 0, int aud_type = 0);

        /// <summary>
        /// 初始化连接服务端
        /// </summary>
        /// <param name="svr_ip">服务端IP地址</param>
        /// <param name="svr_port">服务端端口</param>
        /// <param name="usr_name">客户端用户名</param>
        /// <param name="usr_pwd">用户的密码</param>
        /// <returns>客户端网络连接ID（sess_client）从1开始计数，负数表示错误</returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_init(string svr_ip, int svr_port, string usr_name, string usr_pwd);

        /// <summary>
        /// 请求监视监听其它用户的音视频，
        /// </summary>
        /// <param name="sess_client"></param>
        /// <param name="callee_guid">请求的用户GUID</param>
        /// <param name="ch_idx">音视频通道号</param>
        /// <param name="strm">表示码流类型，主要应用于视频码流, 0,1,2......</param>
        /// <param name="md_tp">媒体类型  1[视频] 2[音频] 3[音视频</param>
        /// <param name="proto">传输协议 1[TCP]2[UDP]3[UDP组播]</param>
        /// <param name="wnd">视频播放窗口句柄</param>
        /// <returns></returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_start_monitor(int sess_client, string callee_guid, int ch_idx, int strm, int md_tp, int proto, int wnd = 0);

        /// <summary>
        /// 停止任务
        /// </summary>
        /// <param name="sess_client"></param>
        /// <param name="tsk_guid"></param>
        /// <returns></returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_stop_task(int sess_client, string tsk_guid);

        /// <summary>
        /// 请求执行手动任务
        /// </summary>
        /// <param name="sess_client">网络连接ID</param>
        /// <param name="md_tp">媒体类型  1[视频] 2[音频]</param>
        /// <param name="trans_proto">传输协议 1[TCP]2[UDP]3[UDP组播]</param>
        /// <param name="list_dst_guid">表示任务的目标用户(用户GUID的形式)</param>
        /// <param name="vol">被喊话的目标设备的播放音量</param>
        /// <param name="flag_usr_data">值false表示由win_sta_core内部采集麦克风数据，true表示由用户调用send_aud_44100_1ch_g711接口，发送数据</param>
        /// <returns></returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_exec_manual_tsk_speak(int sess_client, int md_tp, int trans_proto, string list_dst_guid, int vol, bool flag_usr_data = false);

        /// <summary>
        /// 用户呼叫请求，用于发起呼叫	
        /// </summary>
        /// <param name="sess_client">呼叫的用户GUID</param>
        /// <param name="callee_guid">要呼叫的目标用户或终端的 guid</param>
        /// <param name="ch_idx">音视频通道号 0,1,2......（默认 0）</param>
        /// <param name="strm">表示码流类型，主要应用于视频码流, 0,1,2......（默认 0）</param>
        /// <param name="md_tp">媒体类型 1[视频] 2[音频] 3[音视频]</param>
        /// <param name="proto">传输协议 1[TCP] 2[UDP] 3[UDP 组播]</param>
        /// <param name="wnd">本地进程指定视频播放窗口的句柄</param>
        /// <returns></returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_usr_call_req(int sess_client, string callee_guid, int ch_idx, int strm, int md_tp, int proto, int wnd = 0);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sess_client"></param>
        /// <param name="ch"></param>
        /// <param name="strm"></param>
        /// <param name="tsk_guid">任务GUID,由服务端发到被呼叫端消息usr_call_req中获取</param>
        /// <param name="call_guid"></param>
        /// <param name="status">0表示拒绝、1表示正忙、2表示接通</param>
        /// <param name="wnd"></param>
        /// <returns></returns>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_usr_call_req_ret(int sess_client, int ch, int strm, string tsk_guid, string call_guid, int status, int wnd = 0);


        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static int win_sta_ctrl_usr_dec_play(int arg1);

        /// <summary>
        /// 关闭这个客户端的网络连接
        /// </summary>
        /// <param name="sess_client"></param>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static void win_sta_fini(int sess_client);

        /// <summary>
        /// 关闭所有客户端网络连接
        /// </summary>
        [DllImport(strPath_Dll, CallingConvention = CallingConvention.StdCall)]
        public extern static void win_sta_fini_all();
    }
}
