using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SKN_Player
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
            //if(args.Length != 0)
            //{
            //    Application.Run(new Form1(args[0]));
            //}
            //else
            //{
            //    Application.Run(new Form1());
            //}
            Application.Run(new DownloadVideo.Form1());
        }
    }
}
