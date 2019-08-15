using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SKVideoRemotePlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace SKVideoRemotePlayer.Tests
{
    [TestClass()]
    public class TestTests
    {
        [TestMethod()]
        public void ProgStartParaTestTest()
        {
            ProgPara para = new ProgPara
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

            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            string str = JsonConvert.SerializeObject(para, settings);
            str = CommonMethod.StringEncrypt.Base64Encode(str);
            //ProgPara para1= JsonConvert.DeserializeObject<ProgPara>(str);

            //str = "12345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345123451234512345";
            StartProcess(@"G:\Working\Currency\VideoPlayControl\SKVideoRemotePlayer\bin\Debug", @"G:\Working\Currency\VideoPlayControl\SKVideoRemotePlayer\bin\Debug\SKVideoRemotePlayer.exe", str);
            //z7("123");
            CommonMethod.Common.Delay_Millisecond(3000);
            Assert.AreEqual(str, "123" );
        }


        [DllImport("shell32.dll")]
        private static extern int ShellExecute(IntPtr hwnd, String lpszOp, String lpszFile, String lpszParams, String lpszDir, int FsShowCmd);
        public static bool StartProcess(string dir, string exename, string strOpenFile) //080725
        {
            int r = ShellExecute(IntPtr.Zero, "Open", exename, strOpenFile, dir, 1);

            if (r < 32)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void z7(string cmdstr)
        {
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "SKVideoRemotePlayer.exe";//需要启动的程序名      
            p.StartInfo.Arguments = @"a  -t7z     d:\SMMM_2011103111620.7z  d:\SMMM_2011103111620.bak  -mx=9   ";//启动参数 
            //p.StartInfo.Arguments = ;//启动参数  
            p.Start();//启动    
        }
    }
}