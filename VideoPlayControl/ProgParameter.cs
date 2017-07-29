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

    }
}
