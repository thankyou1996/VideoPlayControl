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
using static VIdeoPlayControl_UseDemo3.NVSSDK;

namespace VIdeoPlayControl_UseDemo3
{
    public partial class Form1 : Form
    {
        //成员变量
        int m_iLogonId = -1;
        int m_iConnectId = -1;

        int m_iConnChanNo = -1;
        int m_iConnStream = -1;

        public const int STREAM_1ST = 0;
        public const int STREAM_2ND = 1;
        public const int STREAM_3RD = 2;
        public const int FLAG_THREE_STREAM = 256;
        public const int CHANNEL_THREE_STREAM = 254;

        public const int RECORD_TYPE_PS = 0;
        public const int RECORD_TYPE_SDV = 1;

        public const int CAPTURE_TYPE_JPG = 0;
        public const int CAPTURE_TYPE_BMP = 1;

        public const int AUT_BROWSE = 0;
        public const int AUT_BROWSE_CTRL = 1;
        public const int AUT_BROWSE_CTRL_SET = 2;
        public const int AUT_ADMIN = 3;


        public Form1()
        {
            InitializeComponent();
            NVSSDK.NetClient_Startup_V4(0, 0, 0);
            NVSSDK.NetClient_SetMSGHandleEx(NetSDKMsg.WM_MAIN_MESSAGE, this.Handle, NetSDKMsg.MSG_PARACHG, NetSDKMsg.MSG_ALARM);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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


        //连接视频
        private void ConnectVideo(Int32 _iStream)
        {
            if (m_iLogonId < 0)
            {
                MessageBox.Show("Please logon device first!");
                return;
            }
            //断开已有连接
            DisConnectVideo();

            CLIENTINFO tInfo = new CLIENTINFO();
            tInfo.m_iServerID = m_iLogonId;
            tInfo.m_iTimeout = 20;
            tInfo.m_iNetMode = 1;   //默认TCP连接
            tInfo.m_iChannelNo = cboChanList.SelectedIndex;
            tInfo.m_iStreamNO = _iStream;
            if (STREAM_3RD == _iStream)
            {
                tInfo.m_iStreamNO = STREAM_2ND;
                tInfo.m_iFlag = FLAG_THREE_STREAM;
            }
            tInfo.m_cNetFile = new char[255];
            tInfo.m_cRemoteIP = new char[16];
            Array.Copy(textIP.Text.ToCharArray(), tInfo.m_cRemoteIP, textIP.Text.Length);

            //开始接收一路视频数据，接收到数据后MainNotify有消息回调，然后才能播放视频
            UInt32 uiConID = 0;
            int iRet = NVSSDK.NetClient_StartRecv(ref uiConID, ref tInfo, null);
            if (iRet < 0)
            {
                MessageBox.Show("Connect video failed, ret:" + iRet);
                return;
            }
            m_iConnectId = (Int32)uiConID;
            m_iConnChanNo = tInfo.m_iChannelNo;
            m_iConnStream = _iStream;

            //设置原始流回调
            //NVSSDK.NetClient_SetRawFrameCallBack(m_iConnectId, Notify_RawFrame, IntPtr.Zero);
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
                            NVSSDK.NetClient_GetChannelNum(m_iLogonId, ref iChanNum);
                            cboChanList.Items.Clear();
                            for (Int32 i = 0; i < iChanNum; ++i)
                            {
                                cboChanList.Items.Add((i + 1).ToString());
                            }
                            if (cboChanList.Items.Count > 0)
                            {
                                cboChanList.SelectedIndex = 0;
                            }
                            btnLogon.Text = "Logoff";

                            //登录成功后获取NTP信息
                            //GetNtpInfo();
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
                        NVSSDK.NetClient_StopPlay(m_iConnectId);
                        RECT rect = new RECT();
                        NVSSDK.NetClient_StartPlay(m_iConnectId, panelVideoShow.Handle, rect, 0);
                    }
                    break;
                default:
                    break;
            }
        }

        //断开连接
        private void DisConnectVideo()
        {
            //btnRecord.Text = "StartRec";
            //btn3DSet.Text = "Start";
            if (m_iConnectId < 0)
            {
                return;
            }
            //停止录像
            NVSSDK.NetClient_StopCaptureFile(m_iConnectId);

            //断开连接
            NVSSDK.NetClient_StopRecv(m_iConnectId);
            m_iConnectId = -1;
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

        private void btnLogon_Click(object sender, EventArgs e)
        {
            if ("Logon" == btnLogon.Text)   //登陆
            {
                LogonPara tInfo = new LogonPara();
                tInfo.iSize = Marshal.SizeOf(tInfo);
                tInfo.iNvsPort = Int32.Parse(textPort.Text);
                tInfo.cNvsIP = new char[32];
                Array.Copy(textIP.Text.ToCharArray(), tInfo.cNvsIP, textIP.Text.Length);
                tInfo.cUserName = new char[16];
                Array.Copy(textUser.Text.ToCharArray(), tInfo.cUserName, textUser.Text.Length);
                tInfo.cUserPwd = new char[16];
                Array.Copy(textPwd.Text.ToCharArray(), tInfo.cUserPwd, textPwd.Text.Length);

                IntPtr intptr = Marshal.AllocCoTaskMem(tInfo.iSize);
                Marshal.StructureToPtr(tInfo, intptr, true);//false容易造成内存泄漏
                Int32 iLogonId = NVSSDK.NetClient_Logon_V4(0, intptr, tInfo.iSize);
                Marshal.FreeHGlobal(intptr);//释放分配的非托管内存。
                if (iLogonId < 0)
                {
                    MessageBox.Show("logon failed!");
                    return;
                }
            }
            else  //注销
            {
                btnLogon.Text = "Logon";
                if (m_iLogonId < 0)
                {
                    return;
                }

                //断开视频连接
                DisConnectVideo();

                //回复按钮状态

                NVSSDK.NetClient_Logoff(m_iLogonId);
                m_iLogonId = -1;
            }
        }

        private void btnConn1st_Click(object sender, EventArgs e)
        {
            ConnectVideo(STREAM_1ST);
        }

        private void btnConn2nd_Click(object sender, EventArgs e)
        {

            ConnectVideo(STREAM_2ND);
        }
    }
}
