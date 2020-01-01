using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using VideoPlayControl.SDKInterface;
using static VideoPlayControl.SDKInterface.SDK_ZHSRSDK;

namespace VideoPlayControl.VideoEnvironment
{
    /// <summary>
    /// 珠海三润
    /// </summary>
    public class VideoEnvironment_ZHSR
    {

        public static Enum_SDKState EnvironmentState = Enum_SDKState.SDK_Null;

        /// <summary>
        /// 连接号
        /// </summary>
        public static int Session = -1;

        public static string User_Guid = "";
        /// <summary>
        /// 初始化
        /// </summary>
        public static void Init(string SerIp, int SerPort, string UserName, string PassWord)
        {
            SDK_ZHSRSDK.func_Cb_Cli = Win_sta_core_func_Cb_Cli;//设置消息回调
            string appPath = System.Environment.CurrentDirectory; //获取路径
            SDK_ZHSRSDK.win_sta_pre_init(appPath, SDK_ZHSRSDK.func_Cb_Cli); //初始化
            int back = SDK_ZHSRSDK.win_sta_init(SerIp, SerPort, UserName, PassWord);
            SDK_ZHSRSDK.win_sta_ctrl_usr_dec_play(1);
            if (back <= 0)
            {
                //登录失败
                EnvironmentState = Enum_SDKState.SDK_InitFail;
            }
            else
            {
                Session = back;
                EnvironmentState = Enum_SDKState.SDK_Init;
            }
        }


        /// <summary>
        /// 珠海三润信息回调
        /// </summary>
        /// <param name="messageID"></param>
        /// <param name="data"></param>
        public delegate void ZHSR_Main_Callback_Delegate(string messageID, Dictionary<string, string> data);


        public static event ZHSR_Main_Callback_Delegate ZHSR_Main_Callback_Event;

        private static void ZHSR_Main_Callback(string messageID, Dictionary<string, string> data)
        {
            if (ZHSR_Main_Callback_Event != null)
            {
                ZHSR_Main_Callback_Event(messageID, data);
            }
        }


        /// <summary>
        /// 消息回调
        /// </summary>
        /// <param name="sess_client"></param>
        /// <param name="usr_data"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="value2"></param>
        private static void Win_sta_core_func_Cb_Cli(int sess_client, ulong usr_data, string type, string key, string value, string value2)
        {
            if (key == "xml")
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(value);
                XmlElement rootElem = xmlDocument.DocumentElement;   //获取根节点  
                string usr_guid = rootElem.GetAttribute("usr_guid"); //用户Guid
                Dictionary<string, string> data = new Dictionary<string, string>();
                switch (type)
                {
                    case Main_Callback_Type.usr_login_ret:
                        User_Guid = usr_guid;
                        //usr_login_ret(rootElem);
                        break;

                    case Main_Callback_Type.monitor_tsk_status:
                        string caller_guid = rootElem.GetAttribute("caller_guid"); //用户Guid
                        if (User_Guid == caller_guid) //判断是否是当前用户
                        {
                            data = monitor_tsk_status(rootElem);
                            ZHSR_Main_Callback(type, data);
                        }
                        break;
                    case Main_Callback_Type.tk_tsk_status:
                        caller_guid = rootElem.GetAttribute("caller_guid"); //用户Guid
                        if (User_Guid == caller_guid) //判断是否是当前用户
                        {
                            data = tk_tsk_status(rootElem);
                            ZHSR_Main_Callback(type, data);
                        }
                        break;
                }
            }
            string strInfo = string.Format("client:{0},usr:{1},type:{2},key:{3},value:{4},value2:{5}", sess_client, usr_data, type, key, value, value2);
            Console.WriteLine(strInfo);
        }


        private static void usr_login_ret(XmlElement rootElem)
        {
            User_Guid = rootElem.GetAttribute("usr_guid");
        }

        private static Dictionary<string,string> monitor_tsk_status(XmlElement rootElem)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            {
                string status = rootElem.GetAttribute("status"); //获取状态
                string callee_guid = rootElem.GetAttribute("callee_guid"); //设备Guid
                string tsk_guid = rootElem.GetAttribute("tsk_guid"); //会话号
                data["status"] = status;
                data["callee_guid"] = callee_guid;
                data["tsk_guid"] = tsk_guid;
            }
            return data;
        }

        private static Dictionary<string, string> tk_tsk_status(XmlElement rootElem)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            {
                string status = rootElem.GetAttribute("status"); //获取状态
                string callee_guid = rootElem.GetAttribute("callee_guid"); //设备Guid
                string tsk_guid = rootElem.GetAttribute("tsk_guid"); //会话号
                data["status"] = status;
                data["callee_guid"] = callee_guid;
                data["tsk_guid"] = tsk_guid;
            }
            return data;

        }


        private static void Gettype(string strtype, XmlDocument xmlDocument)
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            switch (strtype)
            {
                case "usr_login_ret":
                    {
                        //服务器连接的xml解析
                        //usr_login_ret(xmlDocument);
                        //InsertView();
                    }
                    break;
                case "start_monitor_ret":
                    {
                        //监视监听失败
                    }
                    break;
                case "monitor_tsk_status":
                    {
                        XmlElement rootElem = xmlDocument.DocumentElement;   //获取根节点  
                        string caller_guid = rootElem.GetAttribute("caller_guid"); //用户Guid
                        //任务状态xml解析
                        //monitor_tsk_status(xmlDocument);
                        //InsertView();

                    }
                    break;
                case "exec_manual_tsk_ret":
                    {
                        //喊话任务xml解析
                        //                        < root ord = "exec_manual_tsk_ret" sess = "0" ret = "ok"
                        //                          tsk_guid = "{ECDA53E7-DE16-4B82-B95F-12F802AA7BBA}"
                        //                          tsk_src_type = "4" />
                        //ret =”ok / failed” 成功或失败
                    }
                    break;
                case "bc_usr_tsk_status":
                    {
                        //喊话任务成功xml解析
                        //bc_usr_tsk_status(xmlDocument);
                        //InsertView();

                    }
                    break;
                case "usr_call_req_ret":
                    {
                        //用户呼出任务xml解析
                        //                        < root ord = "usr_call_req_ret" sess = "0"
                        //                          callee_guid = "{0968AFF8-93EC-427B-8E80-C3DD48C541FC}"
                        //                          status = "0" />
                    }
                    break;
                case "tk_tsk_status":
                    {
                        //用户呼出任务成功xml解析
                        //tk_tsk_status(xmlDocument);
                    }
                    break;
                case "usr_call_req":
                    {
                        //用户接听xml解析,当其它用户呼叫本用户时，会收到呼叫请求的回调通知
                    }
                    break;
                case "usr_status_batch":
                    {
                        //usr_status_batch(xmlDocument);
                        //InsertView();

                    }
                    break;
                case "alarm_event":
                    {
                        //报警事件
                        //alarm_event(xmlDocument);
                        //InsertView();

                    }
                    break;
                default:
                    break;
            }
            ZHSR_Main_Callback(strtype, data);
        }

        /// <summary>
        /// 释放
        /// </summary>
        public void Release()
        {

        }


    }
}
