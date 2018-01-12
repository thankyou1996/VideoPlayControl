using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace VideoPlayControl
{
    public static class SDK_HuaMai
    {
        /// <summary>
        /// SDK初始化
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_sdk_init();


        /// <summary>
        /// SDK反初始化
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_sdk_uninit();

        /// <summary>
        /// SDK平台的登录
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_connect(IntPtr intptrLoginInfo, ref IntPtr intptr, int strErr, int iErrLength);

        /// <summary>
        /// SDK平台的登录
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_connect(ref _LOGIN_SERVER_INFO intptrLoginInfo, ref IntPtr intptr, ref string strErr, int iErrLength);
        /// <summary>
        /// 注销登录
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_disconnect(IntPtr intptrServer);
        /// <summary>
        /// 获取设备列表
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_device_list(IntPtr intptrServer);

        /// <summary>
        /// 获取中转穿透信息
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_transfer_info(IntPtr intptrServer);

        /// <summary>
        /// 获取树列表
        /// </summary>
        /// <param name="intptrServer"></param>
        /// <param name="intpterTree"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_tree(IntPtr intptrServer, ref IntPtr intpterTree);

        /// <summary>
        /// 释放树列表
        /// </summary>
        /// <param name="iTree"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_release_tree(IntPtr iTree);

        /// <summary>
        /// 获取根节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_root(IntPtr iTree, ref IntPtr iRootNode);

        /// <summary>
        /// 获取根节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_children_count(IntPtr iNode, ref int iCount);

        /// <summary>
        /// 根据索引号获取子集节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="iRootNode"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_child_at(IntPtr iParentNode, int iIndex, ref IntPtr iNode);


        /// <summary>
        /// 通过SN号码获取设备节点
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr hm_server_find_device_by_sn(IntPtr iTree, IntPtr IDevSN);

        /// <summary>
        /// 获取节点类型
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_server_get_node_type(IntPtr iNode, ref NODE_TYPE_INFO typeInfo);

        /// <summary>
        /// 获取节点名称
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_server_get_node_name(IntPtr iNode, ref IntPtr iNodeName);

        /// <summary>
        /// 获取设备节点SN码
        /// </summary>
        /// <param name="iTree"></param>
        /// <param name="strSN"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_get_device_sn(IntPtr iNode, ref IntPtr iDevSN);

        /// <summary>
        /// 获取设备节点URL
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_get_device_url(IntPtr iNode, ref IntPtr iDevUrl);

        /// <summary>
        /// 获取设备节点在线状态
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
        public static extern UInt32 hm_server_is_online(IntPtr iNode, ref bool bolOnline);

        /// <summary>
        /// 连接设备_ex
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_pu_login_ex(IntPtr iNode, ref IntPtr iDev);

        /// <summary>
        /// 连接设备_ex
        /// </summary>
        /// <param name="iNode"></param>
        /// <param name="iDevUrl"></param>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern UInt32 hm_pu_login_ex(IntPtr iNode, ref _CONNECT_INFO config, ref IntPtr iDev);

        /// <summary>
        /// 连接设备
        /// </summary>
        /// <returns></returns>
        [DllImport(ProgConstants.c_strHuaMaiSDKFilePath, CallingConvention = CallingConvention.Cdecl)]
        public static extern UInt32 hm_pu_login(string strIP, UInt16 uiPort, string strDeviceSN, string strUserName, string strPwd, out IntPtr intptr);


        #region 结构体
        /// <summary>
        /// 平台登录信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
        public struct _LOGIN_SERVER_INFO
        {
            public string ip;                      //	平台地址
            public UInt16 port;                    //	平台端口
                                                   //[MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(UTF8Marshaler))]
            public string user;                    //	用户名
            public string password;                //	密码
            public string plat_type;               //	系统类型（pc，android，ios）
            public string hard_ver;                //	硬件版本（PC传CPU型号，手机平台传手机型号）
            public string soft_ver;                //	软件版本（如v1.0.0.1001）
            public UInt32 keep_time;               //	连接保持时间
        }
        //typedef struct _LOGIN_SERVER_INFO
        //{
        //    cpchar ip;                      //	平台地址
        //    uint16 port;                    //	平台端口
        //    cpchar user;                    //	用户名
        //    cpchar password;                //	密码
        //    cpchar plat_type;               //	系统类型（pc，android，ios）
        //    cpchar hard_ver;                //	硬件版本（PC传CPU型号，手机平台传手机型号）
        //    cpchar soft_ver;                //	软件版本（如v1.0.0.1001）
        //    uint32 keep_time;               //	连接保持时间
        //}
        //LOGIN_SERVER_INFO, *P_LOGIN_SERVER_INFO;


        /// <summary>
        /// 用户信息
        /// </summary>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct _USER_INFO
        {
            /// <summary>
            /// 用户ID 
            /// </summary>
            public UInt32 id;
            /// <summary>
            /// 用户名称
            /// </summary>
            public string user;                    //	平台端口
                                                   /// <summary>
                                                   /// 用户昵称
                                                   /// </summary>
            public string nick_name;
            /// <summary>
            /// 电话号码
            /// </summary>
            public string tel;
            /// <summary>
            /// 移动电话号码
            /// </summary>
            public string mobile;
            /// <summary>
            /// 用户地址
            /// </summary>
            public string address;
            /// <summary>
            /// 注册时间
            /// </summary>
            public string reg_date;
            /// <summary>
            /// 最后一次登录时间
            /// </summary>
            public UInt32 last_login_date;
            /// <summary>
            /// 邮箱地址
            /// </summary>
            public string email;

            /// <summary>
            /// 邮箱是否可用
            /// </summary>
            public bool email_valid;

            /// <summary>
            /// 用户的设备角色
            /// </summary>
            public UInt32 actor;

            /// <summary>
            /// 角色1
            /// </summary>
            public string roles1;

            /// <summary>
            /// 角色2
            /// </summary>
            public string roles2;

            /// <summary>
            /// 是否使用报警服务
            /// </summary>
            public bool user_alarm_service;

            /// <summary>
            /// 是否使用中转穿透服务
            /// 0表示不适用 其余代表使用
            /// </summary>
            public UInt32 user_transfer_service;

        }

        //typedef struct _USER_INFO
        //{
        //    int32 id;
        //    cpchar name;
        //    cpchar nick_name;
        //    cpchar tel;
        //    cpchar mobile;
        //    cpchar address;
        //    cpchar reg_date;
        //    cpchar last_login_date;
        //    cpchar email;
        //    bool email_valid;
        //    int32 actor;
        //    cpchar role1;
        //    cpchar role2;
        //    bool use_alarm_service;
        //    int32 use_transfer_service;
        //}
        //USER_INFO, *P_USER_INFO;

        /// <summary>
        /// 播放设置信息
        /// </summary>
        public struct _CONNECT_INFO
        {
            /// <summary>
            /// 客户端类型
            /// </summary>
            public CLIENT_TYPE ct;

            /// <summary>
            /// 连接优先级
            /// </summary>
            public CONNECT_PRI cp;

            /// <summary>
            /// 连接模式（CONNECT_MODE）
            /// </summary>
            public CONNECT_MODE cm;
        }

        //typedef struct _CONNECT_INFO
        //{
        //    CLIENT_TYPE ct;     //	客户端类型
        //    CONNECT_PRI cp;     //	连接优先级
        //    int32 cm;           //	连接模式（CONNECT_MODE）
        //}
        //CONNECT_INFO, *P_CONNECT_INFO;
        #endregion

        #region 枚举
        public enum NODE_TYPE_INFO
        {
            /// <summary>
            /// 无效值
            /// </summary>
            HME_NT_NODE=0,

            /// <summary>
            /// 设备节点
            /// </summary>
            HME_NT_DEVICE=1,

            /// <summary>
            /// DVS节点
            /// </summary>
            HME_NT_DVS=2,

            /// <summary>
            /// 分组节点
            /// </summary>
            HME_NT_GROUP=3,

            /// <summary>
            /// 通道节点
            /// </summary>
            HME_NT_CHANNEL=4
        }

        /// <summary>
        /// 客户端类型
        /// </summary>
        public enum CLIENT_TYPE
        {
            /// <summary>
            /// 移动
            /// </summary>
            CT_MOBILE = 0,
            /// <summary>
            /// PC
            /// </summary>
            CT_PC = 1,
            /// <summary>
            /// 插件
            /// </summary>
            CT_PLUGIN = 2,
            /// <summary>
            /// 平台
            /// </summary>
            CT_PLAT = 3,
            /// <summary>
            /// 设备
            /// </summary>
            CT_PU = 10
        }

        /// <summary>
        /// 连接优先级
        /// </summary>
        public enum CONNECT_PRI
        {
            /// <summary>
            /// 直连优先
            /// </summary>
            CPI_DIR = 1,
            /// <summary>
            /// 穿透优先
            /// </summary>
            CPI_NAT = 2,
            /// <summary>
            /// 中转优先
            /// </summary>
            CPI_RLY = 3,
            /// <summary>
            /// 默认优先级（直连 = 穿透 > 中转）
            /// </summary>
            CPI_DEF = 4	
        }

        /// <summary>
        /// 连接模式，支持与操作
        /// </summary>
        public enum CONNECT_MODE
        {
            /// <summary>
            /// 仅直连
            /// </summary>
            CM_DIR = 1,
            /// <summary>
            /// 仅穿透
            /// </summary>
            CM_NAT = 2,

            /// <summary>
            /// 仅中转
            /// </summary>
            CM_RLY = 4,

            /// <summary>
            /// 默认（直连、穿透和中转同时连接）
            /// </summary>
            CM_DEF = 7
        }
        #endregion
        }


}
