using PublicClassCurrency;
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
using VideoPlayControl.VideoEnvironment;
using VideoPlayControl_RemotePlayback;

namespace SKVideoRemotePlayer
{
    public partial class FrmRecordQuery : Form
    {
        public FrmRecordQuery(ProgPara para)
        {
            InitializeComponent();
            VideoEnvironment_SKN.SKNVideoSDK_Init(para.ServerAddress, para.ServerPort, para.UserName, para.XmlCgfFullPath, para.DefaultSaveDir);
        }


        private void FrmRecordQuery_Load(object sender, EventArgs e)
        {
            Init();
        }
        
        public void Init()
        {            
            VideoInfo vInfo = ProgPara.CurrentProgPara.VideoInfo;            
            DataTable dt = new DataTable();
            dt.Columns.Add("Value");
            dt.Columns.Add("Dsiplay");
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                DataRow dr = dt.NewRow();
                dr["Value"] = cInfo.Channel;
                dr["Dsiplay"] = "通道" + cInfo.Channel;
                dt.Rows.Add(dr);                
            }            
            cmbChannel.ValueMember = "Value";
            cmbChannel.DisplayMember = "Dsiplay";
            cmbChannel.DataSource = dt;
        }


        private void BtnQuery_Click(object sender, EventArgs e)
        {
            int intChannel = Convert.ToInt32(cmbChannel.SelectedValue);            
            CameraInfo cInfo = ProgPara.CurrentProgPara.VideoInfo.Cameras[intChannel];
            List<RemotePlaybackFileInfo> result = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(PubMethod.GetFileMapPath(cInfo),dateTimePicker1.Value, dateTimePicker2.Value);
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
                    double s = RemotePlaybackFileInfo.FileLength / 1024.0 / 1024.0;
                    string str1 = String.Format("{0:F}", s);
                    dr["Filelength"] = str1 + "M";
                    TimeSpan ts = RemotePlaybackFileInfo.EndTime - RemotePlaybackFileInfo.StartTime;
                    string r = Regex.Replace(ts.ToString(), @"\.\d+$", string.Empty);
                    ts = TimeSpan.Parse(r);
                    dr["Timelength"] = ts;
                    dr["Writeok"] = "写入完全";
                }
                else
                {
                    dr["EndTime"] = " ";
                    dr["Timelength"] = " ";
                    dr["Writeok"] = "未写入完全";
                }                           
                dr["download"] = "未下载";
                dt.Rows.Add(dr);
             }
            dgvTalkRecord.DataSource = dt;
            
        }
        
        private void CmbChannel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
