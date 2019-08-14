using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKVideoRemotePlayer
{
    public class Test
    {
        public void ProgStartParaTest()
        {
            ProgStartPara para = new ProgStartPara
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
    }
}
