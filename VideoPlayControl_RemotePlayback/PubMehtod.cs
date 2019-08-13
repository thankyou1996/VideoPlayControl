using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using VideoCurrencyModule.RemotePlayback;

namespace VideoPlayControl_RemotePlayback
{
    public class PubMehtod
    {

        /// <summary>
        /// 获取远程回访文件信息
        /// </summary>
        /// <param name="strPath"></param>
        /// <returns></returns>


        public static List<RemoteBackplayFileInfo> GetRemoteBackplayFileInfo_SKN(string strPath)
        {
            List<RemoteBackplayFileInfo> result = new List<RemoteBackplayFileInfo>();
            //    string[] line = File.ReadAllLines(strPath);
            //  Console.WriteLine(line[0]);

            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            StreamReader m_streamReader = new StreamReader(fs);
            m_streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            string strLine = m_streamReader.ReadLine();
            while (strLine != null)
            {
                RemoteBackplayFileInfo ra = PubMehtod.GetRemoteBackplayFileInfo(strLine);
                result.Add(ra);
                strLine = m_streamReader.ReadLine();
            }
            m_streamReader.Close();
            fs.Close();
            return result;
        }



        public static RemoteBackplayFileInfo GetRemoteBackplayFileInfo(string str)
        {
            string[] aa = new string[] { };
            aa = str.Split(' ');
            string name = aa[0];
            string bu = aa[1];
            string ok = aa[2];
            string star = aa[3];
            string end = aa[4];
            string leng = aa[5];
            RemoteBackplayFileInfo r = new RemoteBackplayFileInfo();
            r.FileName = name;
            r.WriteOK = ok == "1";
            r.StartTimeStamp = long.Parse(star);
            r.EndTimeStamp = long.Parse(end);
            r.FileLength = int.Parse(leng);
            return r;
        }

    }
}
