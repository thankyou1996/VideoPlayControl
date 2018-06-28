using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PublicClassCurrency;

namespace VideoSDKTest
{
    /// <summary>
    /// 20120729 电子标签录像回放窗口(针对海康远程回放录像) 
    /// </summary>
    public partial class FrmRecordPlay : Form
    {
        private int m_lUserID;// 登录设备返回值
        private string _strDvrIP, _strDvrUserName, _strDvrPassword;
        private int _iChannel;//播放通道号
        private ushort _uDvrPort;
        private int iFindfileHandle, m_lPlayHandle;//文件查找句柄 录像回放句柄
        private string _Stime, _Etime;//录像开始时间 结束时间
        private bool _bytime=false;//按时间播放
        private string _EventType;//20150504 事件类型
        private string _AlarmTime;//20150504 报警时间
        private string _LockType;//20150504 门禁类型
        private string _BranchName;//20150504 网点名称
        private string _BranchNO;//20150504 网点编号
        private string _RecordCount;//20150504 记录总数

        private DateTime sTime, eTime;

        public FrmRecordPlay()
        {
            InitializeComponent();
        }
        public FrmRecordPlay(string[] args)
        {
            InitializeComponent();
            _strDvrIP = args[0];
            _uDvrPort = ushort.Parse(args[1]);
            _strDvrUserName = args[2];
            _strDvrPassword = args[3];
            _iChannel = Convert.ToInt32(args[4]);

            _Stime = args[5];
            _Etime = args[6];
            //20150514
            _BranchNO = args[7];
            _LockType = args[8];
            _AlarmTime = args[9];
            _EventType = args[10];
            TimeSpan ts = DateTime.Parse(_Etime) - DateTime.Parse(_Stime);
            totalTime = Convert.ToInt32( ts.TotalSeconds);

            sTime = DateTime.Parse(_Stime);
            eTime = DateTime.Parse(_Etime);
            //20150504
            try
            {
                label6.Text = _EventType.ToString();
            }
            catch
            {
            }
            try
            {
                labelAlarmTime.Text = _AlarmTime.ToString();
            }
            catch
            {
            }
            try
            {
                switch(_LockType)
                {
                    case "10":
                        labelDoor.Text = "网点平台";
                        break;
                    case "21":
                        labelDoor.Text = "防尾随门-外门";
                        break;
                    case "22":
                        labelDoor.Text = "业务库";
                        break;
                    case "23":
                        labelDoor.Text = "加钞间";
                        break;
                    case "24":
                        labelDoor.Text = "隔离门";
                        break;
                    case "25":
                        labelDoor.Text = "防尾随门-内门";
                        break;
                    case "31":
                        labelDoor.Text = "110检测模块";
                        break;
                    case "41":
                        labelDoor.Text = "视频分析";
                        break;
                }
            }
            catch
            {
            }
            
            string strSql;
            strSql = "select 主机编号,用户名称 from 报警基本信息 where 主机编号='" + _BranchNO + "'";
            //DataTable dt = 数据库操作.ClassDataAccess.Exec_Query(strSql);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    _BranchName = dt.Rows[0][1].ToString();
            //}

            //try
            //{
            //    labelBranch.Text = _BranchName.ToString();
            //}
            //catch
            //{
            //}

            //strSql = "select count(*) from T_TeleTagWatchRecord where BranchNO='" + _BranchNO + "' and AlarmTime='"+ _AlarmTime +"' and AlarmContent='"+ _EventType +"'";
            //dt = 数据库操作.ClassDataAccess.Exec_Query(strSql);
            //if (dt != null && dt.Rows.Count > 0)
            //{
            //    labelInspectRecord.Text = dt.Rows[0][0].ToString();
            //}
            dateTimePicker1.Value =DateTime.Parse(_Stime);
            dateTimePicker2.Value =DateTime.Parse(_Stime);
            dateTimePicker3.Value =DateTime.Parse(_Etime);
            dateTimePicker4.Value =DateTime.Parse(_Etime);
        }
       
        public struct NET_DVR_TIME
        {
            public uint dwYear;  //年
            public uint dwMonth;  //月
            public uint dwDay;  //日
            public uint dwHour;  //时
            public uint dwMinute;  //分
            public uint dwSecond;  //秒
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_DEVICEINFO_V30
        {
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 48, ArraySubType = UnmanagedType.I1)]
            public byte[] sSerialNumber;            //序列号
            public byte byAlarmInPortNum;           //报警输入个数
            public byte byAlarmOutPortNum;          //报警输出个数
            public byte byDiskNum;                  //硬盘个数
            public byte byDVRType;                  //设备类型, 1:DVR 2:ATM DVR 3:DVS ......
            public byte byChanNum;                  //模拟通道个数
            public byte byStartChan;                //起始通道号,例如DVS-1,DVR - 1
            public byte byAudioChanNum;             //语音通道数
            public byte byIPChanNum;                //最大数字通道个数  
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes1;                   //保留
        }
        [StructLayoutAttribute(LayoutKind.Sequential)]
        public struct NET_DVR_FILECOND
        {
            public int lChannel;//通道号
            public uint dwFileType;//录象文件类型（根据dwUseCardNo参数是否带卡号查找分为两类）：
            //不带卡号查找时类型：0xff－全部，0－定时录像，1-移动侦测，2－报警触发，3-报警触发或移动侦测，4-报警触发和移动侦测，5-命令触发，6-手动录像，7-智能录像，10-PIR报警，11-无线报警，12-呼救报警，13-PIR|无线报警|呼救报警
            //带卡号查找时类型：0xff－全部，0－定时录像，1—移动侦测，2－接近报警，3－出钞报警，4－进钞报警，5—命令触发，6－手动录像，7－震动报警，8-环境报警，9-智能报警，10-PIR报警，11-无线报警，12-呼救报警，13-PIR|无线报警|呼救报警 
            public uint dwIsLocked;//是否锁定：0-未锁定文件，1-锁定文件，0xff表示所有文件（包括锁定和未锁定）
            public uint dwUseCardNo;//是否带卡号查找
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] sCardNumber;//卡号，ATM机按卡号查找时若卡号为空，则
            public NET_DVR_TIME struStartTime;//开始时间
            public NET_DVR_TIME struStopTime;//结束时间
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_FIND_DATA
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
            public string sFileName;
            public NET_DVR_TIME struStartTime;
            public NET_DVR_TIME struStopTime;
            public uint dwFileSize;
        }
        public struct LPNET_DVR_VOD_PARA
        {
            public uint dwSize;
            public NET_DVR_STREAM_INFO struIDInfo;
            public NET_DVR_TIME struBeginTime;
            public NET_DVR_TIME struEndTime;
            public IntPtr hWnd;
            public byte byDrawFrame;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;//保留，置为0 byRes[31];
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct NET_DVR_STREAM_INFO
        {
            public uint dwSize;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32, ArraySubType = UnmanagedType.I1)]
            public byte[] byID;//保留，置为0 byRes[31];
            public uint dwChannel;
            [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31, ArraySubType = UnmanagedType.I1)]
            public byte[] byRes;
        }
        // 初始化
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Init();
        // 释放资源
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Cleanup();
        // 登录设备
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern Int32 NET_DVR_Login_V30(string sDVRIP, Int32 wDVRPort, string sUserName, string sPassword, ref NET_DVR_DEVICEINFO_V30 lpDeviceInfo);
        // 注销设备
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_Logout_V30(Int32 lUserID);
        // 录像文件查找定位V30接口
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile_V30(int lUserID, ref NET_DVR_FILECOND pFindCond);
        // 录像文件查找
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindNextFile(int lFindHandle, ref NET_DVR_FIND_DATA lpFindData);
        // 录像文件查找定位
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_FindFile(int lUserID, int lChannel, uint dwFileType, ref NET_DVR_TIME lpStartTime, ref NET_DVR_TIME lpStopTime);
        // 停止查找
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_FindClose(int lFindHandle);
        // 设备错误返回值
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern uint NET_DVR_GetLastError();
        // 播放录像文件
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime(int lUserID, int lChannel, ref  NET_DVR_TIME lpStartTime, ref  NET_DVR_TIME lpStopTime, IntPtr hWnd);
        // 录像回放
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByTime_V40(int lUserID, ref LPNET_DVR_VOD_PARA pVodPara);
        // 录像文件回放控制
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_PlayBackControl(int lPlayHandle, uint dwControlCode, uint dwInValue, ref int lpOutValue);
        // 录像文件回放控制
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern bool NET_DVR_StopPlayBack(int lPlayHandle);
        // 按文件名播放
        [DllImport("HIkVideoSDK\\HCNetSDK.dll")]
        public static extern int NET_DVR_PlayBackByName(int lUserID, string sPlayBackFileName, IntPtr hWnd);

        private void FrmRecordPlay_Load(object sender, EventArgs e)
        {
            VideoInfo v = TestDataSource.TestDataSource.GetHikData1();
            CheckForIllegalCrossThreadCalls = false;
            bool bolResult= NET_DVR_Init();//初始化SDK 
            NET_DVR_DEVICEINFO_V30 DeviceInfo = new NET_DVR_DEVICEINFO_V30();
            //登录设备
            m_lUserID = NET_DVR_Login_V30(v.DVSAddress, v.DVSConnectPort, v.UserName, v.Password, ref DeviceInfo);
            if (m_lUserID < 0)
            {
                //int iError=NET_DVR_GetLastError();//错误返回值
                MessageBox.Show("设备登录失败,请检查网络或者参数是否错误！");
                return;
            }

            sTime = DateTime.Now.AddDays(-1);
            NET_DVR_TIME Stime = new NET_DVR_TIME();

            Stime.dwYear = uint.Parse(sTime.Year.ToString());
            Stime.dwMonth = uint.Parse(sTime.Month.ToString());
            Stime.dwDay = uint.Parse(sTime.Day.ToString());
            Stime.dwHour = uint.Parse(sTime.Hour.ToString());
            Stime.dwMinute = uint.Parse(sTime.Minute.ToString());
            Stime.dwSecond = uint.Parse(sTime.Second.ToString());
            eTime = DateTime.Now.AddDays(1);
            NET_DVR_TIME Etime = new NET_DVR_TIME();
            Etime.dwYear = uint.Parse(eTime.Year.ToString());
            Etime.dwMonth = uint.Parse(eTime.Month.ToString());
            Etime.dwDay = uint.Parse(eTime.Day.ToString());
            Etime.dwHour = uint.Parse(eTime.Hour.ToString());
            Etime.dwMinute = uint.Parse(eTime.Minute.ToString());
            Etime.dwSecond = uint.Parse(eTime.Second.ToString());
            iFindfileHandle = NET_DVR_FindFile(m_lUserID, _iChannel, 0xff, ref Stime, ref Etime);

            if (iFindfileHandle == -1)
            {
                MessageBox.Show("没有电子标签录像文件,请注意");
                return;
            }
            else
            { 

            }
            NET_DVR_FIND_DATA FindNextFile = new NET_DVR_FIND_DATA();
        Label_017C:
            switch (NET_DVR_FindNextFile(this.iFindfileHandle, ref FindNextFile))
            {
                case 1000:
                    {
                        string[] str={FindNextFile.sFileName.ToString() + ".mp4",FindNextFile.dwFileSize.ToString() + "MB"};
                        AddListViewItem(lvFlieList, str, Color.Black, Color.White);
                        goto Label_017C;
                    }
                case 1002:
                    System.Threading.Thread.Sleep(5);
                    goto Label_017C;
            }
            NET_DVR_FindClose(this.iFindfileHandle);
            m_lPlayHandle = NET_DVR_PlayBackByTime(m_lUserID, _iChannel, ref Stime, ref Etime, pBPlay.Handle);
            if (m_lPlayHandle == -1)
            {
                MessageBox.Show("录像文件回放失败！");
            }
            int lpOutValue = -1;
            // 录像文件播放
            if (!NET_DVR_PlayBackControl(m_lPlayHandle, 1, 0, ref lpOutValue))
            {
                MessageBox.Show("文件播放失败！");
            }
            // 返回文件的总时间
            //NET_DVR_PlayBackControl(m_lPlayHandle, 17, 0, ref totalTime);
            _bytime = true;
        }
        public static void AddListViewItem(ListView listview, string[] strmsg, Color forecolor, Color backcolor)
        {
            try
            {
                listview.View = View.Details;
                ListViewItem item = new ListViewItem();
                item.ForeColor = forecolor;
                item.BackColor = backcolor;
                item.Text = strmsg[0];
                int mTime = 0;
                if (listview.Columns.Count < strmsg.Length)
                {
                    mTime = listview.Columns.Count;
                }
                else
                {
                    mTime = strmsg.Length;
                }
                for (int i = 1; i < mTime; i++)
                {
                    item.SubItems.Add(strmsg[i]);
                }
                //传递的字符串数组小与列表个数的时候补空
                if (strmsg.Length < listview.Columns.Count)
                {
                    for (int j = strmsg.Length; j < listview.Columns.Count; j++)
                    {
                        //不足补充空
                        item.SubItems.Add("");
                    }
                }
                listview.Items.Add(item);
            }
            catch
            { }
        }
        private void FrmRecordPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_lUserID >= 0)
            {
                if (m_lPlayHandle >= 0)
                {
                    if (NET_DVR_StopPlayBack(m_lPlayHandle))
                    {
                        MessageBox.Show("停止播放成功！");
                    }
                }
                if (NET_DVR_Logout_V30(m_lUserID))
                {
                    //MessageBox.Show("退出登录成功");
                }
            }
            if (NET_DVR_Cleanup())
            {
                //MessageBox.Show("释放资源成功");
            }
        }
        private bool Replay = false;
        int lpOutValue = -1;
        int totalTime = 0;
        // 开始播放
        private void btnPlayStart_Click(object sender, EventArgs e)
        {
            if (Replay == false)
            {
                if (!NET_DVR_PlayBackControl(m_lPlayHandle, 1, 0, ref lpOutValue))
                { 
                }
            }
            if (Replay == true)
            {
                if (!NET_DVR_PlayBackControl(m_lPlayHandle, 4, 0, ref lpOutValue))
                { 
                }
            }
        }
        // 暂停播放
        private void btnPlayPause_Click(object sender, EventArgs e)
        {       
            if (!NET_DVR_PlayBackControl(m_lPlayHandle, 3, 0, ref lpOutValue))
            { 
            }
            Replay = true;
        }
        // 文件快放
        private void btnFast_Click(object sender, EventArgs e)
        {
            if (!NET_DVR_PlayBackControl(m_lPlayHandle, 5, 0, ref lpOutValue))
            { 
            }
        }
        // 文件慢放
        private void btnPlaySlow_Click(object sender, EventArgs e)
        { 
            if (!NET_DVR_PlayBackControl(m_lPlayHandle, 6, 0, ref lpOutValue))
            { 
            }
        }
        private void timStep_Tick(object sender, EventArgs e)
        {
            if (m_lPlayHandle >= 0)
            {
                int icurent = -1;
                // 返回当前播放时间
                NET_DVR_PlayBackControl(m_lPlayHandle, 14, 0, ref icurent);
                if (_bytime == true)
                {
                    label1.Text = icurent.ToString() + "/" + totalTime.ToString();
                }
                else
                {
                    label1.Text = icurent.ToString() + "/" + totalTime.ToString();
                }
            }
        }
        // 停止播放
        private void btnPlayRestart_Click(object sender, EventArgs e)
        {
            if (m_lPlayHandle >= 0)
            {
                NET_DVR_StopPlayBack(m_lPlayHandle);
            }
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("通道"))
            {
                MessageBox.Show("请选择通道号再进行查询！");
                return;
            }


            NET_DVR_TIME Stime = new NET_DVR_TIME();


            Stime.dwYear = uint.Parse(dateTimePicker1.Value.Year.ToString());
            Stime.dwMonth = uint.Parse(dateTimePicker1.Value.Month.ToString());
            Stime.dwDay = uint.Parse(dateTimePicker1.Value.Day.ToString());
            Stime.dwHour = uint.Parse(dateTimePicker2.Value.Hour.ToString());
            Stime.dwMinute = uint.Parse(dateTimePicker2.Value.Minute.ToString());
            Stime.dwSecond = uint.Parse(dateTimePicker2.Value.Second.ToString());

            NET_DVR_TIME Etime = new NET_DVR_TIME();
            Etime.dwYear = uint.Parse(dateTimePicker3.Value.Year.ToString());
            Etime.dwMonth = uint.Parse(dateTimePicker3.Value.Month.ToString());
            Etime.dwDay = uint.Parse(dateTimePicker3.Value.Day.ToString());
            Etime.dwHour = uint.Parse(dateTimePicker4.Value.Hour.ToString());
            Etime.dwMinute = uint.Parse(dateTimePicker4.Value.Minute.ToString());
            Etime.dwSecond = uint.Parse(dateTimePicker4.Value.Second.ToString());
            iFindfileHandle = NET_DVR_FindFile(m_lUserID, Convert.ToInt32(comboBox1.Text), 0xff, ref Stime, ref Etime);
            if (iFindfileHandle == -1)
            {
                MessageBox.Show("没有电子标签录像文件,请注意");
                return;
            }
            else
            {
                lvFlieList.Items.Clear();
            }
            NET_DVR_FIND_DATA FindNextFile = new NET_DVR_FIND_DATA();
        Label_017C:
            switch (NET_DVR_FindNextFile(this.iFindfileHandle, ref FindNextFile))
            {
                case 1000:
                    {
                        string[] str ={ FindNextFile.sFileName.ToString() + ".mp4", FindNextFile.dwFileSize.ToString() + "MB" };
                        AddListViewItem(lvFlieList, str, Color.Black, Color.White);
                        goto Label_017C;
                    }
                case 1002:
                    System.Threading.Thread.Sleep(5);
                    goto Label_017C;
            }
            NET_DVR_FindClose(this.iFindfileHandle);
        } 
        // 双击按文件名播放
        private void lvFlieList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (m_lPlayHandle >= 0)
            {
                // 先停止播放
                NET_DVR_StopPlayBack(m_lPlayHandle);
                m_lPlayHandle = NET_DVR_PlayBackByName(m_lUserID, lvFlieList.SelectedItems[0].SubItems[0].Text.Replace(".mp4", ""), pBPlay.Handle);
                label1.Text = "1/100";
                int lpOutValue = -1;
                // 录像文件播放
                if (!NET_DVR_PlayBackControl(m_lPlayHandle, 1, 0, ref lpOutValue))
                {
                    MessageBox.Show("文件播放失败！");
                }
                // 返回文件的总时间
                NET_DVR_PlayBackControl(m_lPlayHandle, 17, 0, ref totalTime);
                _bytime = false;//按文件播放
            }
        }

        private void labelInspectRecord_Click(object sender, EventArgs e)
        {
            
        } 
    }
}