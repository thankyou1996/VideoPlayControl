using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using VideoPlayControl_RemotePlayback;

namespace SKVideoRemotePlayer
{
    public partial class FrmRecordQuery : Form
    {
        public FrmRecordQuery()
        {
            InitializeComponent();
        }
        private void BtnQuery_Click(object sender, EventArgs e)
        {
            List<RemotePlaybackFileInfo> result = Getttt(dateTimePicker1.Value, dateTimePicker2.Value);
            DataTable dt = new DataTable();
              dt.Columns.Add("HostName");
              dt.Columns.Add("StartTime");
              dt.Columns.Add("EndTime");
              dt.Columns.Add("Filelength");
              dt.Columns.Add("Timelength");
              dt.Columns.Add("Writeok");
              dt.Columns.Add("download");
                        
            foreach (var RemotePlaybackFileInfo in result)
            {
                DataRow dr = dt.NewRow();
                dr["HostName"] = RemotePlaybackFileInfo.FileName;
                dr["StartTime"] = RemotePlaybackFileInfo.StartTime;
                if (RemotePlaybackFileInfo.WriteOK)
                {
                    dr["EndTime"] = RemotePlaybackFileInfo.EndTime;
                }
                else
                {
                    dr["EndTime"] = " ";
                }
                if (RemotePlaybackFileInfo.WriteOK)
                {
                    double s = RemotePlaybackFileInfo.FileLength / 1024.0 / 1024.0;
                    string str1 = String.Format("{0:F}", s);
                    dr["Filelength"] = str1 + "M";
                    TimeSpan ts = RemotePlaybackFileInfo.EndTime - RemotePlaybackFileInfo.StartTime;
                    string r = Regex.Replace(ts.ToString(), @"\.\d+$", string.Empty);
                    ts = TimeSpan.Parse(r);
                    dr["Timelength"] = ts;
                }
                else
                {
                    dr["Timelength"] = " ";
                }
                
                if (RemotePlaybackFileInfo.WriteOK)
                {
                    dr["Writeok"] =   "写入完全";
                }
                else
                {
                    dr["Writeok"] = "未写入完全";
                }
                dr["download"] = "未下载";
                dt.Rows.Add(dr);

            }
             dgvTalkRecord.DataSource = dt;
            
        }


        public List<RemotePlaybackFileInfo> Getttt(DateTime timStart ,DateTime timEnd)
        {
            List<RemotePlaybackFileInfo> result = new List<RemotePlaybackFileInfo>();
            List<RemotePlaybackFileInfo> Temp_result = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(GetPath(1));
            foreach (var RemotePlaybackFileInfo in Temp_result)
            {
                if(RemotePlaybackFileInfo.EndTime <= dateTimePicker2.Value && RemotePlaybackFileInfo.StartTime >= dateTimePicker1.Value)
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

        public string GetPath(int inChannel)
        {
            string str = "";
            str = "C:/Users/yibin/Desktop/FILE_MAP_09";
            return str;
        }
    

        private void FrmRecordQuery_Load(object sender, EventArgs e)
        {

        }

        
    }
}
