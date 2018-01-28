using Newtonsoft.Json;
using PublicClassCurrency;
using SKVideoRecordConvert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoRecordPlayer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //args = new string[] { @"G:\上班汇总\Working\维护项目\公用项目\VideoPlayControl\VideoPlayControl\VideoPlayControl\VideoPlayControl_UseDemo\bin\Debug\AxisRecord\000601_00_20180127085739_06.bin" };
            Application.Run(StartFormCreator(args));
        }
        static Form StartFormCreator(string[] args)
        {
            if (args != null && args.Length >= 1)
            {
                string Temp_strValue = args[0];
                if (!string.IsNullOrEmpty(Temp_strValue))
                {
                    VideoRecordInfo v = SK3000VideoRecordConvert.GetVideoRecordInfo_ByFileName(Temp_strValue);
                    return new FrmMain(v);
                }
            }
            return new FrmMain();
        }


        
    }
}
