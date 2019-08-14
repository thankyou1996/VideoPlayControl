using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SKVideoRemotePlayer
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
            ProgPara para = null;
            if (args != null && args.Length > 0)
            {
                StringBuilder sbInfo = new StringBuilder();
                foreach (string s in args)
                {
                    sbInfo.Append(s);
                    sbInfo.Append(" ");
                }
                sbInfo.Length = sbInfo.Length - 1;
                para = Newtonsoft.Json.JsonConvert.DeserializeObject<ProgPara>(sbInfo.ToString());
                foreach (CameraInfo cInfo in para.VideoInfo.Cameras.Values)
                {
                    cInfo.VideoInfo = para.VideoInfo;
                }

            }
            else

            {
                para = new ProgPara
                {
                    ServerAddress = "192.168.2.19",
                    ServerPort = 48624,
                    UserName = "xhcs1",
                    PlaybackTimeStart = DateTime.Now.AddDays(-1),
                    PlaybackTimeEnd = DateTime.Now.AddDays(1),
                    PlaybackTime = DateTime.Now.AddHours(-1),
                    Channel = 9,
                    VideoInfo = TestDataSource.SKNVideoDatSource.GetSKData1(),
                    DefaultSaveDir = Environment.CurrentDirectory,
                    XmlCgfFullPath = Environment.CurrentDirectory
                };
            }
            Application.Run(new FrmMain(para));
        }
    }
}
