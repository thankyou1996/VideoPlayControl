using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using VideoCurrencyModule.RemotePlayback;

namespace DownloadVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, string> myList = new Dictionary<string, string>();
        string IP;
        string Name;
        string PW;
        string strPath= Application.StartupPath;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                myList.Clear();
                IP = txtIP.Text;
                Name = txtname.Text;
                PW = txtpw.Text;
                Thread thread = new Thread(threadPlaylogin);
                thread.IsBackground = true;
                thread.Start();
                Thread.Sleep(500);
                if (state(IP))
                {
                    btnfind.Enabled = true;
                }
                else
                {
                    dataGridView1.Rows.Clear();
                    myList.Clear();
                    MessageBox.Show("登录失败，请重新登录！", "提示");
                }
            }
            catch(Exception ex)
            {
                dataGridView1.Rows.Clear();
                myList.Clear();
                MessageBox.Show("登录失败，请重新登录！", "提示");
                
            }
        }

        private static bool state(string strIP)
        {
            bool bolstate = false;
            string url2 = "http://" + strIP + "/cgi-bin/status2.cgi";
            Dictionary<string, string> valuePairs = new Dictionary<string, string>();
            valuePairs.Add("data", "1600840751277");
            string result = Get(url2, valuePairs);
            if (result.Contains("online"))
            {
                bolstate = true;
            }
            else
            {
                bolstate = false;
            }
            return bolstate;
        }

        private void threadPlaylogin()
        {
            try
            {
                System.GC.Collect();
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = "name=" + Name;
                postData += ("&pass=" + PW);

                byte[] data = encoding.GetBytes(postData);
                string strurl = "http://" + IP + "/cgi-bin/login.cgi";
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(strurl);
                myRequest.ServicePoint.Expect100Continue = false;
                myRequest.Timeout = 500;

                myRequest.Method = "POST";
                myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentLength = data.Length;
                Stream newStream = myRequest.GetRequestStream();
                newStream.Write(data, 0, data.Length);
                newStream.Close();
                myRequest.Abort();
            }
            catch { }
        }
        private void dataGridView(DataGridView dataGridView)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;//211, 223, 240
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(223)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.GridColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowTemplate.Height = 23;
            dataGridView.RowTemplate.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowUserToResizeRows = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicePointManager.DefaultConnectionLimit = Int32.MaxValue;
            dateTimePicker1.Value = DateTime.Now.AddDays(-3);
            dateTimePicker2.Value = Convert.ToDateTime(DateTime.Now.AddDays(1).ToString("D").ToString()).AddSeconds(-1);
            DataTable dt = new DataTable();
            dt.Columns.Add("Value");
            dt.Columns.Add("Dsiplay");
            for (int i = 1; i <= 16; i++)
            {
                DataRow dr = dt.NewRow();
                dr["Value"] = i;
                dr["Dsiplay"] = "通道" + i;
                dt.Rows.Add(dr);
            }            
            cmbChannel.ValueMember = "Value";
            cmbChannel.DisplayMember = "Dsiplay";
            cmbChannel.DataSource = dt;
            cmbChannel.SelectedIndex = 8;
            btnfind.Enabled = false;
            dataGridView(dataGridView1);
        }

        #region 转换时间为unix时间戳
        /// <summary>
        /// 转换时间为unix时间戳
        /// </summary>
        /// <param name="date">需要传递UTC时间,避免时区误差,例:DataTime.UTCNow</param>
        /// <returns></returns>
        public static double ConvertToUnixOfTime(DateTime date)
        {
            DateTime origin = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0));
            TimeSpan diff = date - origin;
            return Math.Floor(diff.TotalSeconds);
        }
        #endregion

        #region 时间戳转换为时间

        public static DateTime StampToDateTime(string timeStamp)
        {
            DateTime dateTimeStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1, 0, 0, 0));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dateTimeStart.Add(toNow);
        }

        #endregion


        /// <summary>
        /// 发送Get请求
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="dic">请求参数定义</param>
        /// <returns></returns>
        public static string Get(string url, Dictionary<string, string> dic)
        {
            System.GC.Collect();
            string result = "";        
            StringBuilder builder = new StringBuilder();
            builder.Append(url);
            if (dic.Count > 0)
            {
                builder.Append("?");
                int i = 0;
                foreach (var item in dic)
                {
                    if (i > 0)
                        builder.Append("&");
                    builder.AppendFormat("{0}={1}", item.Key, item.Value);
                    i++;
                }
            }

            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(builder.ToString());
            req.ContentType = "application/json";
            req.Method = "GET";
            req.Timeout = 500;
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            try
            {
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd().ToString();
                }
            }
            finally
            {                
                resp.Close();
                req.Abort();
                resp = null;
                stream.Close();
            }
            return result;
        }

        private void find()
        {
            dataGridView1.Rows.Clear();
            myList.Clear();
            double timestart = ConvertToUnixOfTime(dateTimePicker1.Value);
            double timeend = ConvertToUnixOfTime(dateTimePicker2.Value);
            string channelIndex = cmbChannel.SelectedValue.ToString();
            string url = "http://" + IP + "/cgi-bin/disk.cgi";
            Dictionary<string, string> valuePairs = new Dictionary<string, string>();
            valuePairs.Add("action", "get_video_list");
            valuePairs.Add("start_ime", timestart.ToString());
            valuePairs.Add("end_time", timeend.ToString());
            valuePairs.Add("get_channel", channelIndex);
            valuePairs.Add("get_type", "/hdd/normal&");
            string result = Get(url, valuePairs);
            string[] sArray = result.Split(new string[] { "<script>" }, StringSplitOptions.None);
            string s = sArray[1].Split('(')[1].Split(new string[] { "0,0,0,0,0" }, StringSplitOptions.None)[0].Replace(" ", "");
            string[] sArray2 = s.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (string strrow in sArray2)
            {
                if (strrow != "")
                {
                    string[] item = strrow.Split(',');
                    myList.Add(item[0], item[1].Replace("h264", "h264&").Replace("\"", ""));
                    double sss = Convert.ToDouble(item[2]) / 1024.0 / 1024.0;
                    string da = String.Format("{0:F}", sss) + "M";
                    dataGridView1.Rows.Add(item[0], item[1].Split('_')[2], "通道：" + channelIndex + "  " + StampToDateTime(item[1].Split('_')[3].Replace(".h264\"", "")).ToString("yyyy-MM-dd HH:mm:ss"), item[3].Split('.')[1].Replace("\"", ""), da, "未下载");
                }
            }
            tolltip();
            if (MessageBox.Show("查询成功！", "提示") == DialogResult.OK)
            {
              
            }
        }
             
        private void tolltip()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToString(dataGridView1.Rows[i].Cells[5].Value) == "已下载")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "未下载")
                                dataGridView1[j, k].ToolTipText = "双击下载文件";
                            else if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "已下载")
                                dataGridView1[j, k].ToolTipText = "双击打开文件";
                            else if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "下载失败")
                                dataGridView1[j, k].ToolTipText = "双击重新下载文件";
                            else
                                dataGridView1[j, k].ToolTipText = "文件下载中";
                        }
                    }
                }
                if (Convert.ToString(dataGridView1.Rows[i].Cells[5].Value) == "未下载")
                {
                    for (int k = 0; k < dataGridView1.Rows.Count; k++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "未下载")
                                dataGridView1[j, k].ToolTipText = "双击下载文件";
                            else if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "已下载")
                                dataGridView1[j, k].ToolTipText = "双击打开文件";
                            else if (Convert.ToString(dataGridView1.Rows[k].Cells[5].Value) == "下载失败")
                                dataGridView1[j, k].ToolTipText = "双击重新下载文件";
                            else
                                dataGridView1[j, k].ToolTipText = "文件下载中";
                        }
                    }
                }
            }
        }

         private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (state(IP))
                {
                    find();                   
                }
                else
                {
                    Thread thread = new Thread(threadPlaylogin);
                    thread.IsBackground = true;
                    thread.Start();
                    Thread.Sleep(500);
                    find();                    
                }
            }
            catch
            {
                dataGridView1.Rows.Clear();
                myList.Clear();
                MessageBox.Show("登录超时，请重新登录！", "提示");
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (state(IP))
            {
                download(rowindex);
            }
            else
            {
                Thread thread = new Thread(threadPlaylogin);
                thread.IsBackground = true;
                thread.Start();
                Thread.Sleep(1000);
                download(rowindex);
            }
        }

        private void download(int rowindex)
        {
            try
            {
                if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "未下载" || dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "下载失败")
                {
                    string index = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                    string strurl = "http://" + IP + "/cgi-bin/download.cgi?";
                    foreach (var item in myList)
                    {
                        if (Convert.ToInt32(item.Key) == Convert.ToInt32(index))
                        {
                            strurl = strurl.Replace("?", "?path=" + item.Value);
                            Thread thread = new Thread(threadPlay);
                            List<string> list = new List<string>();
                            list.Add(index);
                            list.Add(strurl);
                            thread.IsBackground = true;
                            thread.Start(list);
                        }
                    }
                    dataGridView1.SelectedRows[0].Cells[5].Value = "下载中";
                }
                else if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "下载中")
                {
                    return;
                }
                else if (dataGridView1.SelectedRows[0].Cells[5].Value.ToString() == "已下载")
                {
                    System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("Explorer.exe");
                    foreach (var item in myList)
                    {
                        if (dataGridView1.SelectedRows[0].Cells[0].Value.ToString() == item.Key)
                        {
                            psi.Arguments = "/e,/select," + strPath + "\\" + item.Value.Replace("&", "").Replace("/hdd/normal/", "");
                            System.Diagnostics.Process.Start(psi);
                        }
                    }
                }
            }
            catch
            {
                dataGridView1.Rows.Clear();
                myList.Clear();
                MessageBox.Show("登录超时，请重新登录！", "提示");
            }
        }  

        private void threadPlay(object obj)
        {
            List<string> list = obj as List<string>;
            bool bol=HttpDownload(list[1],strPath);
            if (bol)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string aa= dataGridView1.Rows[i].Cells[0].ToString();
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == list[0])
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "已下载";
                    }
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == list[0])
                    {
                        dataGridView1.Rows[i].Cells[5].Value = "下载失败";
                    }
                }
            }
        }

        public static bool HttpDownload(string url,string path)
        {
            try
            {
                string fileName = Path.GetFileName(url);
                string filePath = path + "\\" + fileName.Replace("&","");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                // 设置参数
                HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
                //发送请求并获取相应回应数据
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                Stream responseStream = response.GetResponseStream();
                //创建本地文件写入流
                byte[] bArr = new byte[1024];
                int iTotalSize = 0;
                int size = responseStream.Read(bArr, 0, (int)bArr.Length);
                while (size > 0)
                {
                    iTotalSize += size;
                    fs.Write(bArr, 0, size);
                    size = responseStream.Read(bArr, 0, (int)bArr.Length);
                }
                fs.Close();
                responseStream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tolltip();
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
            string defaultPath = "";
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            //打开的文件夹浏览对话框上的描述  
            dialog.Description = "请选择一个文件夹";
            //是否显示对话框左下角 新建文件夹 按钮，默认为 true  
            dialog.ShowNewFolderButton = false;
            //首次defaultPath为空，按FolderBrowserDialog默认设置（即桌面）选择  
            if (defaultPath != "")
            {
                //设置此次默认目录为上一次选中目录  
                dialog.SelectedPath = defaultPath;
            }
            //按下确定选择的按钮  
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //记录选中的目录  
                defaultPath = dialog.SelectedPath;
            }
            strPath = defaultPath;
            MessageBox.Show("保存成功！","提示");          
        }

        private void Button1_Click_3(object sender, EventArgs e)
        {
            string path = "E://VideoPlayControl-master//VideoPlayControl-master//SKVideoRemotePlayer//bin//Release//63-00F628C45E03-74D4//FILE_MAP_09";
            List<RemotePlaybackFileInfo> Temp_lst = VideoPlayControl_RemotePlayback.PubMethod.GetRemotePlaybackFileInfo_SKN(path,dateTimePicker1.Value, dateTimePicker2.Value);
            remoteBackplayControl1.PositionDateTimeChangedEvent += RemoteBackplayControl1_PositionDateTimeChangedEvent;
        }

        private void RemoteBackplayControl1_PositionDateTimeChangedEvent(object sender, object PositionDateTimeChangedDelegateValue)
        {
            VideoPlayControl_RemotePlayback.RemotePlaybackControl control = (VideoPlayControl_RemotePlayback.RemotePlaybackControl)sender;
        }
   
    }
}
