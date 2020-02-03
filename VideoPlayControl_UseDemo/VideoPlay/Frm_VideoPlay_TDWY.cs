using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl.SDKInterface;
using static VideoPlayControl.SDKInterface.SDK_TDWYSDK;

namespace VideoPlayControl_UseDemo.VideoPlay
{
    public partial class Frm_VideoPlay_TDWY : Form
    {
        public Frm_VideoPlay_TDWY()
        {
            InitializeComponent();
        }

        VideoInfo CurrentVideoInfo = TestDataSource.TDWYDataSource.GetData1();
        int m_iLogonId;
        int m_iConnectId = -1;
        private void Frm_VideoPlay_TDWY_Load(object sender, EventArgs e)
        {
            //VideoPlayControl.VideoEnvironment.VideoEnvironment_TDWY.Init();
            //VideoPlayControl.VideoEnvironment.VideoEnvironment_TDWY.MAIN_NOTIFYEvent -= VideoEnvironment_TDWY_MAIN_NOTIFYEvent;
            //VideoPlayControl.VideoEnvironment.VideoEnvironment_TDWY.MAIN_NOTIFYEvent += VideoEnvironment_TDWY_MAIN_NOTIFYEvent;
            SDK_TDWYSDK.NetClient_Startup_V4(0, 0, 0);
            SDK_TDWYSDK.NetClient_SetMSGHandleEx(NetSDKMsg.WM_MAIN_MESSAGE, this.Handle, NetSDKMsg.MSG_PARACHG, NetSDKMsg.MSG_ALARM);
        }
        //重写消息处理函数，以处理自定义消息
        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            //WM_MAIN_MESSAGE为自定义的系统消息
            if (m.Msg == NetSDKMsg.WM_MAIN_MESSAGE)
            {
                //自定义消息处理函数
                this.OnNetSDKMsg(m.WParam, m.LParam);
            }
            //默认消息处理函数
            base.DefWndProc(ref m);
        }


        public void OnNetSDKMsg(IntPtr wParam, IntPtr lParam)
        {
            //wParam的低16位是消息的类型；
            int iMsgType = wParam.ToInt32() & 0xFFFF;
            switch (iMsgType)
            {
                case NetSDKMsg.WCM_LOGON_NOTIFY:
                    {
                        Int32 iStatus = wParam.ToInt32() >> 16;
                        if (NetSDKMsg.LOGON_SUCCESS == iStatus)
                        {
                            MessageBox.Show("logon success!");
                            m_iLogonId = (Int32)lParam;

                            //初始化通道列表                         
                            Int32 iChanNum = 0;
                            SDK_TDWYSDK.NetClient_GetChannelNum(m_iLogonId, ref iChanNum);
                            //cboChanList.Items.Clear();
                            //for (Int32 i = 0; i < iChanNum; ++i)
                            //{
                            //    cboChanList.Items.Add((i + 1).ToString());
                            //}
                            //if (cboChanList.Items.Count > 0)
                            //{
                            //    cboChanList.SelectedIndex = 0;
                            //}
                            //btnLogon.Text = "Logoff";

                            ////登录成功后获取NTP信息
                            GetNtpInfo();
                        }
                        else
                        {
                            MessageBox.Show("logon failed, reason " + iStatus);
                        }
                    }
                    break;
                case NetSDKMsg.WCM_VIDEO_HEAD_EX:
                    {
                        //视频头消息来了，开始播放视频
                        SDK_TDWYSDK.NetClient_StopPlay(m_iConnectId);
                        SDK_TDWYSDK.RECT rect = new SDK_TDWYSDK.RECT();
                        SDK_TDWYSDK.NetClient_StartPlay(m_iConnectId, pictureBox1.Handle, rect, 0);
                    }
                    break;
                default:
                    break;
            }
        }


        public struct NTPInfo
        {
            public int iSize;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public char[] cServerAddress;

            public int iServerPort;
            public int iIntervalHour;
            public int iIntervalSec;
        }
        public void GetNtpInfo()
        {
            if (m_iLogonId < 0)
            {
                MessageBox.Show("Please logon device first!");
                return;
            }

            //获取NTP参数
            NTPInfo tInfo = new NTPInfo();
            tInfo.iSize = Marshal.SizeOf(tInfo);
            tInfo.cServerAddress = new char[32];

            int iOut = 0;
            IntPtr intptr = Marshal.AllocCoTaskMem(tInfo.iSize);
            Marshal.StructureToPtr(tInfo, intptr, true);
            //SDK_TDWYSDK.NetClient_GetDevConfig(m_iLogonId, NetSDKCmd.NET_CLIENT_NTP_INFO, 0, intptr, tInfo.iSize, ref iOut);
            tInfo = (NTPInfo)Marshal.PtrToStructure(intptr, typeof(NTPInfo));
            Marshal.FreeHGlobal(intptr);

            //
            string strServer = new string(tInfo.cServerAddress, 0, tInfo.cServerAddress.Length);
            strServer = strServer.Trim("\0".ToCharArray());
            //textNTPServer.Text = strServer;
            //textNTPPort.Text = tInfo.iServerPort.ToString();
            //if (tInfo.iIntervalSec <= 0)
            //{
            //    textNTPInterval.Text = (tInfo.iIntervalHour * 60).ToString();
            //}
            //else
            //{
            //    textNTPInterval.Text = (tInfo.iIntervalSec / 60).ToString();
            //}
        }

        private void VideoEnvironment_TDWY_MAIN_NOTIFYEvent(uint _ulLogonID, IntPtr _iWparam, IntPtr _iLParam, int _iUser)
        {
            if (_ulLogonID == m_iLogonId)
            {
                //表示属于当前信息登录信息
                switch (_iWparam.ToInt32())
                {
                    //登陆状态消息 
                    //param1 登陆IP
                    //param2 登陆ID
                    //param3 登陆状态
                    case NetSDKMsg.WCM_LOGON_NOTIFY:
                        Int32 iStatus = _iLParam.ToInt32();
                        if (iStatus == NetSDKMsg.LOGON_SUCCESS)
                        {
                            Console.WriteLine("登录成功");
                        }
                        else
                        {
                            //触发相关时间进行提示
                            Console.WriteLine("登录失败，Status:" + iStatus);
                        }
                        break;
                    case NetSDKMsg.WCM_VIDEO_HEAD:
                        break;
                    case NetSDKMsg.WCM_VIDEO_HEAD_EX:

                        SDK_TDWYSDK.NetClient_StopPlay(m_iConnectId);
                        this.BeginInvoke(new EventHandler(delegate
                        {
                            SDK_TDWYSDK.RECT rect = new SDK_TDWYSDK.RECT() { bottom = 0, left = 0, right = 0, top = 0 };
                            SDK_TDWYSDK.NetClient_StartPlay(m_iConnectId, pictureBox1.Handle, rect, 0);
                        }));
                        break;
                    default:
                        Console.WriteLine("TDWY- MyMAIN_NOTIFY_V4: " + _iWparam.ToInt32());
                        break;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //1、登录
            SDK_TDWYSDK.LogonPara tInfo = new SDK_TDWYSDK.LogonPara();
            tInfo.iSize = Marshal.SizeOf(tInfo);
            tInfo.iNvsPort = CurrentVideoInfo.DVSConnectPort;
            tInfo.cNvsIP = new char[32];
            Array.Copy(CurrentVideoInfo.DVSAddress.ToArray(), tInfo.cNvsIP, CurrentVideoInfo.DVSAddress.Length);
            tInfo.cUserName = new char[16];
            Array.Copy(CurrentVideoInfo.UserName.ToArray(), tInfo.cUserName, CurrentVideoInfo.UserName.Length);
            tInfo.cUserPwd = new char[16];
            Array.Copy(CurrentVideoInfo.Password.ToArray(), tInfo.cUserPwd, CurrentVideoInfo.Password.Length);
            IntPtr intptr = Marshal.AllocCoTaskMem(tInfo.iSize);
            Marshal.StructureToPtr(tInfo, intptr, true);//false容易造成内存泄漏
            int iRet = SDK_TDWYSDK.NetClient_Logon_V4(0, intptr, tInfo.iSize);
            Marshal.FreeHGlobal(intptr);//释放分配的非托管内存。
            m_iLogonId = iRet;
            if (m_iLogonId < 0)
            {
                //登录失败
                iRet = SDK_TDWYSDK.NetClient_Logoff(m_iLogonId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CameraInfo cInfo = CurrentVideoInfo.Cameras.Values.First();

            SDK_TDWYSDK.CLIENTINFO tInfo = new SDK_TDWYSDK.CLIENTINFO
            {
                m_iServerID = m_iLogonId,
                m_iTimeout = 20,
                m_iNetMode = 1,
                m_iChannelNo = cInfo.Channel - 1,
                m_iStreamNO =1,
                m_cNetFile = new char[255],
                m_cRemoteIP = new char[16],
            };
            Array.Copy(CurrentVideoInfo.DVSAddress.ToArray(), tInfo.m_cRemoteIP, CurrentVideoInfo.DVSAddress.Length);
            //开始接收一路视频数据	

            UInt32 uiConID = 0;
            int iRet = SDK_TDWYSDK.NetClient_StartRecv(ref uiConID, ref tInfo, null);

            m_iConnectId = (Int32)uiConID;
        }
    }
}
