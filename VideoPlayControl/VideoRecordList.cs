using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VideoPlayControl
{
    public partial class VideoRecordList : UserControl
    {
        public string strCurrentFolderPath = "";
        
        public VideoRecordList()
        {
            InitializeComponent();
        }
        #region 事件委托
        public delegate void ButtonVideoRecord_ClickDelegate(object sender);

        public event ButtonVideoRecord_ClickDelegate ButtonVideoRecord_ClickEvent;

        private void ButtonVideoRecord_Click(object sender)
        {
            if (ButtonVideoRecord_ClickEvent != null)
            {
                ButtonVideoRecord_ClickEvent(sender);
            }
        }
        #endregion


        private void VideoRecordList_Load(object sender, EventArgs e)
        {
            //Test();
        }

        /// <summary>
        /// 初始化_设置文件路径
        /// </summary>
        /// <param name="strFileDir"></param>
        public void Init_SetCurrentFolderPath(string strFileDir)
        {
            strCurrentFolderPath = strFileDir;
            if (Directory.Exists(strCurrentFolderPath))
            {
                GetRecordFiles();
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetRecordFiles()
        {
            this.Controls.Clear();
            //return;
            if (!string.IsNullOrEmpty(strCurrentFolderPath))
            {
                string[] strsReocrdFilePath = Directory.GetFileSystemEntries(strCurrentFolderPath);
                
                List<string> lststrResult = GetEffeciveFile(strsReocrdFilePath);
                int intFileIndex = lststrResult.Count;
                string strFileName = "";
                foreach (string s in lststrResult)
                {
                    Panel pnl = new Panel();
                    pnl.BackColor = System.Drawing.SystemColors.Control;
                    pnl.BorderStyle = BorderStyle.FixedSingle;
                    pnl.Dock = System.Windows.Forms.DockStyle.Top;
                    pnl.Location = new System.Drawing.Point(0, 0);
                    pnl.Name = "pnl" + intFileIndex;
                    pnl.Size = new System.Drawing.Size(420, 30);
                    pnl.TabIndex = 0;

                    strFileName = s.Substring(s.LastIndexOf("\\") + 1);
                    Button btn = new Button();
                    btn.Dock = DockStyle.Fill;
                    btn.Text = (intFileIndex) + "." + strFileName;
                    btn.Name = "btn" + intFileIndex;
                    btn.Tag = s;
                    btn.TextAlign = ContentAlignment.MiddleLeft;
                    btn.Click += ButtonVideoRecord_Click;
                    pnl.Controls.Add(btn);
                    this.Controls.Add(pnl);
                    intFileIndex--;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strsReocrdFilePath"></param>
        /// <returns></returns>
        public List<string> GetEffeciveFile(string[] strsReocrdFilePath)
        {
            List<string> lststrResult = new List<string>();

            foreach (string s in strsReocrdFilePath)
            {
                if (
                    s.ToLower().EndsWith(".mp4")||
                    s.ToLower().EndsWith(".avi")||
                    s.ToLower().EndsWith(".bin")        //180128 安讯士录像文件后缀
                    ||s.ToLower().EndsWith("08.h264")     //180409 雄迈
                    )
                {
                    lststrResult.Add(s);
                }
            }
            return lststrResult;
        }



        #region  控件事件

        /// <summary>
        /// 视频记录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonVideoRecord_Click(object sender, EventArgs e)
        {
            ButtonVideoRecord_Click(sender);
        }

        #endregion


        public void Test()
        {
            for (int i = 0; i < 20; i++)
            {
                Panel pnl = new Panel();
                pnl.BackColor = System.Drawing.SystemColors.Control;
                pnl.BorderStyle = BorderStyle.FixedSingle;
                pnl.Dock = System.Windows.Forms.DockStyle.Top;
                pnl.Location = new System.Drawing.Point(0, 0);
                pnl.Name = "panel1";
                pnl.Size = new System.Drawing.Size(420, 30);
                pnl.TabIndex = 0;

                Button btn = new Button();
                btn.Dock = DockStyle.Fill;
                btn.Text = i.ToString();
                btn.Name = "btn" + i;
                btn.TextAlign = ContentAlignment.MiddleLeft;
                pnl.Controls.Add(btn);
                this.Controls.Add(pnl);
            }
        }
    }
}
