using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmExtendedControlTest());
            //Application.Run(new Frm_VideoRecordListTest());
            //Application.Run(new FrmHikTest());
            //Application.Run(new FrmTest());
            //Application.Run(new Frn_VideoPlayGroupControl_Basic());
            //Application.Run(new FrmVideoInfoList());
            Application.Run(new FrmMain());
            //Application.Run(new Form1());
            //Application.Run(new Frm_VideoPlayGroupControls_PTZAndTalk());
            //Application.Run(new Frm_VideoPlayGroupControls_PTZAndTalk());
            //Application.Run(new Frm_Temp_TestVideoPlay());
            //Application.Run(new Frm_Temp_TestAxis());
            //Application.Run(new Frm_VideoPlaybackWindow());
        }
    }
}
