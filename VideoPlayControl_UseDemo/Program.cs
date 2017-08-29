using System;
using System.Collections.Generic;
using System.Linq;
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
            //Application.Run(new FrmMain());
            Application.Run(new Frn_VideoPlayGroupControl_Basic());
            //Application.Run(new Frn_VideoPlayGroupControl_Basic());
            //Application.Run(new Frm_VideoRecordListTest());
            //Application.Run(new Form1());
            //Application.Run(new Frn_VideoPlayGroupControl_Basic());

        }
    }
}
