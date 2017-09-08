using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 程序参数
    /// </summary>
    public class ProgParameter
    {
        #region CloundSee(云视通相关参数)
        /// <summary>
        /// 云视通初始化端口
        /// </summary>
        public static int intCloundSee_intLocStartPort = ProgConstants.c_intCloundSee_intLocStartPort;

        /// <summary>
        /// 云视通临时文件存放位置
        /// </summary>
        public static string strCloundSee_TempDicPath = ProgConstants.ro_strCloundSee_TempDicPath;
        #endregion

        #region Ezviz (萤石云相关参数)
        /// <summary>
        /// 萤石云 开放平台认证中心地址
        /// </summary>
        public static string strEzviz__AuthAddr = ProgConstants.c_strEzviz_AuthAddr_Default;
        /// <summary>
        /// 萤石云 开放平台后台地址
        /// </summary>
        public static string strEzviz__PlatForm = ProgConstants.c_strEzviz_PlatForm_Default;
        /// <summary>
        /// 萤石云 APPID
        /// </summary>
        public static string strEzviz__AppID = ProgConstants.c_strEzviz_AppID_Default;
        #endregion
    }
}
