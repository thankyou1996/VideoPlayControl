using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VideoCurrencyModule.RemotePlayback;

namespace VideoPlayControl_RemotePlayback
{
    public class PubMethod
    {

        public static List<RemotePlaybackFileInfo> GetRemotePlaybackFileInfo_SKN(string strPath, DateTime timStart, DateTime timEnd)
        {
            List<RemotePlaybackFileInfo> result = new List<RemotePlaybackFileInfo>();
            List<RemotePlaybackFileInfo> Temp_result = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(strPath);
            foreach (var RemotePlaybackFileInfo in Temp_result)
            {
                if (RemotePlaybackFileInfo.EndTime <= timEnd && RemotePlaybackFileInfo.StartTime >= timStart)
                {
                    result.Add(RemotePlaybackFileInfo);
                }
                else
                {
                    //
                }

            }
            return result;
        }

        /// <summary>
        /// 获取远程回访文件信息
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>
        public static List<RemotePlaybackFileInfo> GetRemotePlaybackFileInfo_SKN(string strPath)
        {
            List<RemotePlaybackFileInfo> result = new List<RemotePlaybackFileInfo>();
            if ((!File.Exists(strPath)))
            {
                //
            }
            else
            {
                FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
                StreamReader m_streamReader = new StreamReader(fs);
                m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string strLine = m_streamReader.ReadLine();
                while (strLine != null)
                {
                    RemotePlaybackFileInfo ra = PubMethod.GetRemotePlaybackFileInfo(strLine);
                    result.Add(ra);
                    strLine = m_streamReader.ReadLine();
                }
                m_streamReader.Close();
                fs.Close();
            }
            return result;
        }



        public static RemotePlaybackFileInfo GetRemotePlaybackFileInfo(string str)
        {
            string[] aa = new string[] { };
            aa = str.Split(' ');
            string name = aa[0];
            string bu = aa[1];
            string ok = aa[2];
            string star = aa[3];
            string end = aa[4];
            string leng = aa[5];
            RemotePlaybackFileInfo r = new RemotePlaybackFileInfo();
            r.FileName = name;
            r.WriteOK = ok == "1";
            r.StartTimeStamp = long.Parse(star);
            r.EndTimeStamp = long.Parse(end);
            r.FileLength = int.Parse(leng);
            return r;
        }

    }

}
