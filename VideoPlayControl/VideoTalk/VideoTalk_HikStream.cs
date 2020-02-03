using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using PublicClassCurrency;
using VideoPlayControl.VideoBasicClass;

namespace VideoPlayControl.VideoTalk
{
    /*
     * 主要流程：
     * 开始：
     * 1.初始化多方通话服务端
     * 2.设置多方通话回调
     * 3.开始多方通话服务
     * 4.初始化海康SDK
     * 5.登录海康设备
     * 6.启动海康语音转发
     * 
     * 结束：
     * 1.关闭海康语音转发
     * 2.注销用户登录
     * 3.释放海康SDK
     * 4.关闭多方通话
     * 5.释放多方通话
     */
    public class VideoTalk_HikStream : IVideoTalk
    {
        public VideoInfo CurrentVideoInfo { get; set; }
        public VideoTalkChannelInfo CurrentTalkChannel { get; set; }
        private Enum_TalkStatus currentTalkStatus;
        public Enum_TalkStatus CurrentTalkStatus
        {
            get
            {
                return currentTalkStatus;
            }
            set
            {
                if (currentTalkStatus != value)
                {
                    currentTalkStatus = value;
                    TalkStausChanged(null);
                }
            }
        }

        public event TalkStausChangedDelegate TalkStausChangedEvent;
        public event StartTalkingDelegate StartTalkingEvent;
        public event StartTalkedDelegate StartTalkedEvent;
        public event StopTalkedDelegate StopTalkedEvent;

        /// <summary>
        /// 语音连接返回值
        /// </summary>
        int lVoiceComHandle = 0;

        /// <summary>
        /// 用户登录ID(海康设备)
        /// </summary>
        int m_lUserID;

        /// <summary>
        /// 海康设备信息
        /// </summary>
        public SDK_HikClientSDK.NET_DVR_DEVICEINFO_V30 DeviceInfo;

        /// <summary>
        /// 回调函数，必须是全局变量
        /// </summary>
        SDK_HikClientSDK.VOICEDATACALLBACKV30 VoiceData = new SDK_HikClientSDK.VOICEDATACALLBACKV30(VoiceDataCallBack);//语音转发回调

        /// <summary>
        /// 转发给客户端的数据
        /// </summary>
        static List<byte> listbyte = new List<byte>();


        private SDK_TalkManagerSDK.STATUS_TYPE m_Status;
        /// <summary>
        /// 工作状态
        /// </summary>
        public SDK_TalkManagerSDK.STATUS_TYPE Status
        {
            get { return m_Status; }
        }


        private TalkSetting currentTalkSetting = new TalkSetting();

        /// <summary>
        /// 时刻设备对讲设置
        /// </summary>
        public TalkSetting CurrentTalkSetting
        {
            get { return currentTalkSetting; }
            set { currentTalkSetting = value; }
        }

        public object Tag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// 转发给海康设备的数据
        /// </summary>
        List<byte> listByteCH = new List<byte>();


        public bool SetVideoTalkInfo(VideoInfo videoInfo, VideoTalkChannelInfo talkChannel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)
            {
                StopTalk();
            }
            CurrentVideoInfo = videoInfo;
            CurrentTalkChannel = talkChannel;
            return bolResult;
        }

        public bool StartTalking(object StartTalkingValue)
        {
            bool bolResult = false;
            if (StartTalkingEvent != null)
            {
                StartTalkingEvent(this, StartTalkingValue);
            }
            return bolResult;
        }

        public bool StartTlak(Enum_TalkModel talkModel)
        {
            bool bolResult = false;
            if (CurrentTalkStatus != Enum_TalkStatus.Null)  //处于对讲中 先关闭
            {
                StopTalk();
            }
            //多方通话服务端开启
            if (m_Status == SDK_TalkManagerSDK.STATUS_TYPE.Stopped)
            {
                if (SDK_TalkManagerSDK.Init())//初始化多方通话服务端
                {
                    m_Status = SDK_TalkManagerSDK.STATUS_TYPE.Running;
                }
            }

            SDK_TalkManagerSDK.RegistCallback(RegistCallback); //设置回调

            if (SDK_TalkManagerSDK.Start("0.0.0.0", 8081))  // 本地IP和端口  启动多方通话服务端
            {
                //多方通话服务端启动成功
                if (SDK_HikClientSDK.NET_DVR_Init()) //初始化海康SDK
                {
                    //海康SDK初始化成功 -> 登录设备
                    m_lUserID = SDK_HikClientSDK.NET_DVR_Login_V30(CurrentVideoInfo.DVSAddress, CurrentVideoInfo.DVSConnectPort, CurrentVideoInfo.UserName, CurrentVideoInfo.Password, ref DeviceInfo);
                    if (m_lUserID < 0)
                    {
                        //登录失败
                        bolResult = false;
                    }
                    else
                    {
                        //登录成功 -> 启动海康语音转发
                        lVoiceComHandle = SDK_HikClientSDK.NET_DVR_StartVoiceCom_MR_V30(m_lUserID, (uint)CurrentTalkChannel.VideoTalkChannel, VoiceData, IntPtr.Zero); //启动语音转发
                        if (lVoiceComHandle < 0)
                        {
                            //启动转发失败
                            bolResult = false;
                        }
                        else
                        {
                            //启动转发成功
                            bolResult = true;
                        }
                    }
                }
                else
                {
                    //海康SDK初始化失败
                    bolResult = false;
                }
            }
            else
            {
                //多方通话服务端初始化失败
                bolResult = false;
            }




            return bolResult;
        }

        /// <summary>
        /// 开始对讲
        /// </summary>
        /// <param name="ts"></param>
        /// <returns></returns>
        public virtual bool StartTalk(TalkSetting ts)
        {
            CurrentTalkSetting = ts;
            return StartTlak(ts.TalkMode);
        }

        public bool StopTalk()
        {
            bool bolResult = false;
            if (SDK_HikClientSDK.NET_DVR_StopVoiceCom(lVoiceComHandle)) //关闭语音转发
            {
                //停止转发成功 -> 注销用户
                if (SDK_HikClientSDK.NET_DVR_Logout(m_lUserID)) //注销用户
                {
                    //注销用户成功 -> 释放SDK
                    SDK_HikClientSDK.NET_DVR_Cleanup(); //释放海康SDK

                    //多方通话关闭
                    SDK_TalkManagerSDK.Stop(); //关闭和多方通话客户端转发
                    if (m_Status == SDK_TalkManagerSDK.STATUS_TYPE.Running)
                    {
                        if (SDK_TalkManagerSDK.Dispose()) //释放多方通话服务端SDK
                        {
                            m_Status = SDK_TalkManagerSDK.STATUS_TYPE.Stopped;
                        }
                    }

                    CurrentTalkStatus = Enum_TalkStatus.Null;
                    bolResult = true;
                }
                else
                {
                    //注销用户失败
                    bolResult = false;
                }
            }
            else
            {
                //停止转发失败
                bolResult = false;
            }
            return bolResult;
        }

        public bool TalkStausChanged(object TalkStausChangedValue)
        {
            bool bolResult = false;
            if (TalkStausChangedEvent != null)
            {
                TalkStausChangedEvent(this, TalkStausChangedValue);
            }
            return bolResult;
        }

        /// <summary>
        /// 海康语音转发回调
        /// </summary>
        /// <param name="lVoiceComHandle"></param>
        /// <param name="pRecvDataBuffer">语音数据</param>
        /// <param name="dwBufSize">数据大小</param>
        /// <param name="byAudioFlag"></param>
        /// <param name="pUser"></param>
        public static void VoiceDataCallBack(int lVoiceComHandle, IntPtr pRecvDataBuffer, uint dwBufSize, byte byAudioFlag, System.IntPtr pUser)
        {
            //回调数据是空句柄或数据大小 小于0 或者语音转发句柄小于0 抛弃数据
            if (pRecvDataBuffer == IntPtr.Zero || dwBufSize <= 0 || lVoiceComHandle < 0) 
            {
                return;
            }

            byte[] sString = new byte[dwBufSize]; //新建数组，用于存放回调句柄内数据，大小为语音转发数据的长度

            Marshal.Copy(pRecvDataBuffer, sString, 0, (Int32)dwBufSize); //将句柄数据转存到数据
            
            listbyte.AddRange(sString); //将数据缓存至缓冲区


            if (listbyte.Count >= 640) //
            {
                byte[] sendByte = new byte[640]; //取640字节数据
                Array.Copy(listbyte.ToArray(), 0, sendByte, 0, 640);  //将缓冲区中前640字节赋值到新建数组
                if (!SDK_TalkManagerSDK.Send(sendByte, sendByte.Length)) //发送数据(规定为每次640字节)
                {
                    //MessageBox.Show("发送失败");
                    Console.WriteLine(DateTime.Now + "_音频转发失败");
                }
                listbyte.RemoveRange(0, 640); //将前640字节移除
            }

        }

        private void RegistCallback(IntPtr Buffer, int lenght)
        {
            try
            {

                IntPtr intPtr = Buffer;
                int intlenght = lenght;

                if (intPtr == IntPtr.Zero || intlenght <= 0)
                {
                    return;
                }

                byte[] data = new byte[intlenght];
                Marshal.Copy(intPtr, data, 0, intlenght); //将句柄数据转存至数组


                listByteCH.AddRange(data); //将数组添加至缓冲区

                for (int SendCount = 0; SendCount < 4; SendCount++) //回调数据每次640字节。而海康语音转发SDK每次发送160字节。需要进行数据分割
                {
                    byte[] sendByte = new byte[160]; 
                    if (listByteCH.Count >= 160)
                    {

                        Array.Copy(listByteCH.ToArray(), 0, sendByte, 0, 160); //将缓冲区前160字节赋值到数组
                        if (SDK_HikClientSDK.NET_DVR_VoiceComSendData(lVoiceComHandle, sendByte, (uint)sendByte.Length)) //海康语音转发
                        {
                            System.Threading.Thread.Sleep(1);
                            Console.WriteLine(DateTime.Now + "_音频转发成功:" + 160);
                        }
                        else
                        {
                            //转发失败
                        }
                        listByteCH.RemoveRange(0, 160); //将缓冲区前160字节数据移除
                    }

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //throw;
            }
        }

        public bool StopTalked(object StopTalkedValue)
        {
            throw new NotImplementedException();
        }
    }
}
