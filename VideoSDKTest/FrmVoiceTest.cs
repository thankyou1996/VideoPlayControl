using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static VideoSDKTest.SDK_HikClientSDK;

namespace VideoSDKTest
{
    public partial class FrmVoiceTest : Form
    {
        #region 全局变量
        int _intDVRHwd;
        int intRet;

        public VideoInfo CurrentVideoInfo;

        public CameraInfo CurrentCameraInfo;
        IntPtr ei;
        #endregion


        public FrmVoiceTest()
        {
            InitializeComponent();
        }
        private void FrmVoiceTest_Load(object sender, EventArgs e)
        {
            Init();
        }

        public void Init()
        {
            bool bolResult = NET_DVR_Init();
            ei = NET_DVR_InitG722Encoder();
            CurrentVideoInfo = TestDataSource.TestDataSource.GetHikDVSData1();
            foreach (CameraInfo c in CurrentVideoInfo.Cameras.Values)
            {
                CurrentCameraInfo = c;
                break;
            }

        }

        /// <summary>
        /// 海康视频播放
        /// </summary>
        public void HikDVR_VideoPlay()
        {
            NET_DVR_DEVICEINFO_V30 dev = new NET_DVR_DEVICEINFO_V30();

            _intDVRHwd = NET_DVR_Login_V30(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref dev);
            if (_intDVRHwd < 0)
            {
                //登陆失败
                return;
            }
            return;

            NET_DVR_PREVIEWINFO lpPreviewInfo = new NET_DVR_PREVIEWINFO();
            lpPreviewInfo.hPlayWnd = pictureBox1.Handle;//预览窗口
            lpPreviewInfo.lChannel = CurrentCameraInfo.Channel;
            lpPreviewInfo.dwStreamType = 0;//码流类型：0-主码流，1-子码流，2-码流3，3-码流4，以此类推
            lpPreviewInfo.dwLinkMode = 0;//连接方式：0- TCP方式，1- UDP方式，2- 多播方式，3- RTP方式，4-RTP/RTSP，5-RSTP/HTTP 
            lpPreviewInfo.bBlocked = true; //0- 非阻塞取流，1- 阻塞取流


            //NET_DVR_CLIENTINFO cli = new NET_DVR_CLIENTINFO();
            //cli.lLinkMode = 0;// 设置连接方式  /*  最高位(31)为 0 表示主码流，为 1 表示子码流，0－30 位表示码流连接方式：0：TCP方式,1：UDP 方式,2：多播方式,3 - RTP方式，4—音视频分开 */ 
            //cli.lChannel = channel + 32;
            //cli.hPlayWnd = playHandle;

            // 开始播放视频
            //Thread.Sleep(50);
            IntPtr pUser = new IntPtr();
            REALDATACALLBACK RealData = new REALDATACALLBACK(RealDataCallBack);//预览实时流回调函数

            //intRet = NET_DVR_RealPlay_V30(_intDVRHwd, ref cli, null, pUser, 1);//130814
            intRet = NET_DVR_RealPlay_V40(_intDVRHwd, ref lpPreviewInfo, null, pUser);//140521
            //intRet = NET_DVR_RealPlay(_intDVRHwd, ref cli);//130814
            NET_DVR_OpenSound(intRet);//140609
            if (intRet < 0)
            {
                return;
            }
        }

        public void HikDVR_VideoPlay2()
        {
            fLoginResultCallBack f = new fLoginResultCallBack(LoginResultCallBack);
            NET_DVR_USER_LOGIN_INFO pLoginInfo = new NET_DVR_USER_LOGIN_INFO();
            pLoginInfo.sDeviceAddress = "192.168.5.162";
            pLoginInfo.byRes1 = 0x00;
            pLoginInfo.wPort = 8000;
            pLoginInfo.sUserName = "admin";
            pLoginInfo.sPassword = "sk123456";
            pLoginInfo.cbLoginResult = f;
            pLoginInfo.pUser = IntPtr.Zero;
            pLoginInfo.bUseAsynLogin = false;
            pLoginInfo.byRes2 = new byte[128];
            NET_DVR_DEVICEINFO_V40 lpDeviceInfo = new NET_DVR_DEVICEINFO_V40();
            _intDVRHwd = NET_DVR_Login_V40(ref pLoginInfo, ref lpDeviceInfo);
        }
        public void LoginResultCallBack(int lUserID, int dwResult, NET_DVR_DEVICEINFO_V30 lpDeviceInfo, IntPtr pUser)
        {
            Console.WriteLine("LoginResultCallBack");
        }

        public void RealDataCallBack(Int32 lRealHandle, UInt32 dwDataType, ref byte pBuffer, UInt32 dwBufSize, IntPtr pUser)
        {

        }
        List<byte> Temp_b = new List<byte>();
        int intIndex = 1;
        private void MyRealDataCallBack(string pRecvDataBuffer, uint dwBufSize, IntPtr pUser)
        {
            //Temp_b.AddRange(pRecvDataBuffer);
            Console.WriteLine("MyRealDataCallBackIndex：" + intIndex);
            Console.WriteLine("MyRealDataCallBackSize：" + dwBufSize);
            Console.WriteLine("MyRealDataCallBackContent：" + pRecvDataBuffer);

            intIndex++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HikDVR_VideoPlay();
            //NET_DVR_StartVoiceCom_V30(1,1,1)
        }


        private void button2_Click(object sender, EventArgs e)
        {
            VoiceCallBack = new VOICEAUDIOSTART(MyRealDataCallBack);
            bool bolResul = NET_DVR_ClientAudioStart_V30(VoiceCallBack, IntPtr.Zero);
        }
        VOICEAUDIOSTART VoiceCallBack;

        private void button3_Click(object sender, EventArgs e)
        {
            bool bolResult = NET_DVR_ClientAudioStop();
            Thread.Sleep(5000);
            //byte[] Temp_byt = Temp_b.Take(320).ToArray();
            //byte[] bresult = new byte[160];
            List<byte> result = new List<byte>();

            byte resultB = 0x00;
            for (int i = 0; i < Temp_b.Count; i++)
            {
                byte b = Temp_b[i];
                bool bol = NET_DVR_EncodeG711Frame(0, ref b, ref resultB);
                //result.Add(Temp_b[i]);
                //result.Add(resultB);
            }





            //Console.WriteLine("EncodeG711：" + strValue);

        }
        int intSound = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            //int lUserID, uint dwVoiceChan, bool bNeedCBNoEncData, VOICEDATACALLBACKV30 fVoiceDataCallBack, IntPtr pUser
            VOICEDATACALLBACKV30 v = new VOICEDATACALLBACKV30(VOICEDATACALLBACKV30);
            intSound = NET_DVR_StartVoiceCom_V30(_intDVRHwd, 1, true, v, IntPtr.Zero);
            //fVoiceDataCallBack v = new fVoiceDataCallBack(VoiceDataCallBack);
            //intSound = NET_DVR_StartVoiceCom_MR(_intDVRHwd, v, 1);
        }
        List<Byte> l = new List<byte>();

        public void VOICEDATACALLBACKV30(int lVoiceComHandle, string pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser)
        {
            Console.WriteLine(dwBufSize.ToString());
            if (byAudioFlag == 0)
            {

                NET_DVR_VoiceComSendData(lVoiceComHandle, pRecvDataBuffer, dwBufSize);
            }
            //NET_DVR_VoiceComSendData(lVoiceComHandle, pRecvDataBuffer, dwBufSize);
            //Console.WriteLine(dwBufSize.ToString());
            //if (byAudioFlag==0)
            //{
            //    NET_DVR_VoiceComSendData(lVoiceComHandle, pRecvDataBuffer, dwBufSize);
            //    Console.WriteLine(dwBufSize.ToString());

            //}

            //if (byAudioFlag == 0)
            //{
            //    FileStream fs = new FileStream(@"demo.txt", FileMode.Append);//初始化文件流
            //    byte[] array = Encoding.Default.GetBytes(pRecvDataBuffer + Environment.NewLine);//给字节数组赋值
            //    fs.Write(array, 0, array.Length);//将字节数组写入文件流
            //    fs.Close();//关闭流
            //}
            //Console.WriteLine(byAudioFlag);
        }
        public void VoiceDataCallBack(int lVoiceComHandle, [MarshalAs(UnmanagedType.LPArray)]  byte[] pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, uint dwUser)
        {
            if (byAudioFlag == 0)
            {

                NET_DVR_VoiceComSendData(lVoiceComHandle, pRecvDataBuffer, dwBufSize);
            }
            //Console.WriteLine(lVoiceComHandle.ToString());

            //Console.WriteLine(dwBufSize.ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool bolResult = NET_DVR_StopVoiceCom(intSound);
            FileStream fs = new FileStream(@"demo.txt", FileMode.Append);//初始化文件流
            byte[] array = l.ToArray();//给字节数组赋值
            fs.Write(array, 0, array.Length);//将字节数组写入文件流
            fs.Close();//关闭流
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"demo.txt", FileMode.Open);//初始化文件流
            byte[] array = new byte[fs.Length];//初始化字节数组
            StreamReader sr = new StreamReader(fs);
            string s;
            Console.WriteLine("StartTime:"+DateTime.Now.ToString());
            while ((s = sr.ReadLine()) != null)
            {
                //byte[] b=end
                //bool bolResult= NET_DVR_VoiceComSendData(intSound, s, 1920);
                Thread.Sleep(10);
            }
            Console.WriteLine("EndTime:" + DateTime.Now.ToString());
            sr.Close();
            fs.Close();
        }
    }
}
