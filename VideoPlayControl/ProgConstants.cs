using System;
using System.Collections.Generic;
using System.Text;

namespace VideoPlayControl
{
    /// <summary>
    /// 程序公用参数
    /// </summary>
    public class ProgConstants
    {
        #region SDK 文件路径
        /// <summary>
        /// 中维(云视通)SDK
        /// </summary>
        public const string c_strCloundSeeSDKFilePath = "\\JCSDK\\JCSDK.dll";


        #endregion

        #region SDK默认参数

        #region CloundSee

        /// <summary>
        /// 云视通默认初始化 端口
        /// </summary>
        public const int c_intCloundSee_intLocStartPort = -1;

        /// <summary>
        /// 云视通默认临时文件存放位置
        /// </summary>
        public static readonly string ro_strCloundSee_TempDicPath = Environment.CurrentDirectory + "\\CloundSeeTempFile";

        /// <summary>
        /// 云视通默认录像文件存放地址
        /// </summary>
        public static readonly string ro_strCloundSee_RecDicPath = Environment.CurrentDirectory + "\\CloundSeeRecFile";
        #endregion

        #endregion

    }
}
