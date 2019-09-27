using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;
using VideoPlayControl.VideoEnvironment;

namespace SKVideoRemotePlayer
{
    public partial class FrmRecordQuery : Form
    {
        int type = 1;

        public FrmRecordQuery()
        {
            InitializeComponent();
            //VideoEnvironment_SKN.SKNVideoSDK_Init(para.ServerAddress, para.ServerPort, para.UserName, para.XmlCgfFullPath, para.DefaultSaveDir);
            VideoEnvironment_SKN.DownLoadDoneEvent += VideoEnvironment_SKN_DownLoadDoneEvent;
            VideoEnvironment_SKN.DownLoadProcessEvent += VideoEnvironment_SKN_DownLoadProcessEvent;
        }
        public FrmRecordQuery(ProgPara para)
        {
            InitializeComponent();
            ProgPara.CurrentProgPara = para;
            VideoEnvironment_SKN.SKNVideoSDK_Init(para.ServerAddress, para.ServerPort, para.UserName, para.XmlCgfFullPath, para.DefaultSaveDir);
            VideoEnvironment_SKN.DownLoadDoneEvent += VideoEnvironment_SKN_DownLoadDoneEvent;
            VideoEnvironment_SKN.DownLoadProcessEvent += VideoEnvironment_SKN_DownLoadProcessEvent;
        }
        private void VideoEnvironment_SKN_DownLoadDoneEvent(object sender, object value)
        {
            if (type == 1)
            {
                this.BeginInvoke(new EventHandler(delegate { Query(); }));
            }
            else if (type == 2)
            {
                string s = Convert.ToString(value);
                for (int i = 0; i < dgvTalkRecord.Rows.Count; i++)
                { 
                    if (s.EndsWith(Convert.ToString(dgvTalkRecord.Rows[i].Cells[0].Value)))
                    {
                        dgvTalkRecord.Rows[i].Cells[6].Value = "已下载";
                    }
                }               
            }                 
        }
       
        private void VideoEnvironment_SKN_DownLoadProcessEvent(object sender, VideoEnvironment_SKN.DownLoadProcessValue value)
        {
            for (int j = 0; j < dgvTalkRecord.Rows.Count; j++)
            {
                string name = "";
                name = Convert.ToString(dgvTalkRecord.Rows[j].Cells[0].Value);
                if (value.FilePath.EndsWith(name))
                {
                    Console.WriteLine(value.Percent);
                    for (int i = 0; i < dgvTalkRecord.Rows.Count; i++)
                    {
                        if (Convert.ToString(dgvTalkRecord.Rows[i].Cells[0].Value) == name)
                        {
                            dgvTalkRecord.Rows[i].Cells[6].Value = value.Percent + "%";
                        }
                    }
                }
            }
        }

        public void Query()
        {
            CommonMethod.Common.Delay_Millisecond(100);
            int intChannel = Convert.ToInt32(cmbChannel.SelectedValue);
            CameraInfo cInfo = ProgPara.CurrentProgPara.VideoInfo.Cameras[intChannel];
            List<RemotePlaybackFileInfo> result = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(PubMethod.GetFileMapPath(cInfo), dateTimePicker1.Value, dateTimePicker2.Value);
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
                DirectoryInfo dir = new DirectoryInfo(SKVideoRemotePlayer.ProgPara.VideoDefaultSaveDir);
                FileSystemInfo[] fsinfos = dir.GetFileSystemInfos();
                foreach (FileSystemInfo fsinfo in fsinfos)
                {
                    string x = RemotePlaybackFileInfo.FileName;
                    if (x == fsinfo.Name)
                    {
                        dr["download"] = "已下载";
                        break;
                    }
                    else
                    {
                        dr["download"] = "未下载";
                    }
                }
                dt.Rows.Add(dr);
            }
            dgvTalkRecord.DataSource = dt;
            for (int i = 0; i < dgvTalkRecord.Rows.Count; i++)
            {
                for (int j = 0; j < dgvTalkRecord.Columns.Count; j++)
                {
                    dgvTalkRecord[j, i].ToolTipText = "双击下载文件";
                }
            }
            StartKiller();
        }

        private void FrmRecordQuery_Load(object sender, EventArgs e)
        {
            Init();
        }
        
        public void Init()
        {
            dateTimePicker1.Value = DateTime.Now.AddDays(-3);
            dateTimePicker2.Value = DateTime.Now;
            VideoInfo vInfo = ProgPara.CurrentProgPara.VideoInfo;            
            DataTable dt = new DataTable();
            dt.Columns.Add("Value");
            dt.Columns.Add("Dsiplay");
            foreach (CameraInfo cInfo in vInfo.Cameras.Values)
            {
                DataRow dr = dt.NewRow();
                dr["Value"] = cInfo.Channel;
                dr["Dsiplay"] = cInfo.CameraName;
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
            SKVideoRemotePlayer.PubMethod.DownloadFileMap(cInfo);
            type = 1;
            MessageBox.Show( "正在查询中", "提示");            
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Auto)]
        private extern static IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        public const int WM_CLOSE = 0x10;
        private void StartKiller()
        {
            IntPtr ptr = FindWindow(null, "提示");
            if (ptr != IntPtr.Zero)
            {
                PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            }
        }

        private void DgvTalkRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (Convert.ToString(dgvTalkRecord.Rows[rowindex].Cells[6].Value) == "已下载")
            {
                string x = Convert.ToString(dgvTalkRecord.Rows[rowindex].Cells[0].Value);
                string name = "";
                name = dgvTalkRecord.Rows[rowindex].Cells[0].Value.ToString();
                if (x.EndsWith(name))
                {
                    string a = SKVideoRemotePlayer.ProgPara.VideoDefaultSaveDir;
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                    psi.Arguments = "/e,/select," + a + "\\" + name;
                    System.Diagnostics.Process.Start(psi);
                }
            }
            else
            {
                string name = "";
                name = dgvTalkRecord.Rows[rowindex].Cells[0].Value.ToString();
                SKVideoRemotePlayer.PubMethod.DownloadFile(ProgPara.CurrentProgPara.VideoInfo, name);
                type = 2;
            }        
        }

        private void DgvTalkRecord_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            for (int i = 0; i < dgvTalkRecord.Rows.Count; i++)
            {
                if (Convert.ToString(dgvTalkRecord.Rows[i].Cells[6].Value) == "已下载")
                {
                    dgvTalkRecord.Rows[i].DefaultCellStyle.BackColor = Color.Khaki;
                    for (int k = 0; k < dgvTalkRecord.Rows.Count; k++)
                    {
                        for (int j = 0; j < dgvTalkRecord.Columns.Count; j++)
                        {
                            if (Convert.ToString(dgvTalkRecord.Rows[k].Cells[6].Value) == "未下载")
                                dgvTalkRecord[j, k].ToolTipText = "双击下载文件";
                            else if (Convert.ToString(dgvTalkRecord.Rows[k].Cells[6].Value) == "已下载")
                                dgvTalkRecord[j, k].ToolTipText = "双击打开文件";
                            else
                                dgvTalkRecord[j, k].ToolTipText = "文件下载中";
                        }
                    }
                }
                
            }
        }

        private void FrmRecordQuery_FormClosing(object sender, FormClosingEventArgs e)
        {
            VideoEnvironment_SKN.DownLoadDoneEvent -= VideoEnvironment_SKN_DownLoadDoneEvent;
            VideoEnvironment_SKN.DownLoadProcessEvent -= VideoEnvironment_SKN_DownLoadProcessEvent;
        }
    }   
}
