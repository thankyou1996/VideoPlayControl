using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_Temp_TestVideoPlay : Form
    {
        public Frm_Temp_TestVideoPlay()
        {
            InitializeComponent();
        }

        #region 测试公用方法
        #region 公用变量
        IntPtr intptrServer = IntPtr.Zero;
        IntPtr intptrTree = IntPtr.Zero;
        IntPtr iRootNode = IntPtr.Zero;
        IntPtr iNode = IntPtr.Zero;
        IntPtr iDev = IntPtr.Zero;
        IntPtr iOpenVideo = IntPtr.Zero;
        SDK_HuaMai.OPEN_VIDEO_RES videoRes;
        int intCount = 0;
        IntPtr iPort = IntPtr.Zero;
        #endregion

        public void Init()
        {
            //MessageBox.Show(VideoPlayControl.ProgConstants.c_strHuaMaiSDKFilePath);
            //ProgConstants.c_strHuaMaiSDKFilePath = Environment.CurrentDirectory + ProgConstants.c_strHuaMaiSDKFilePath;
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            //NODE_TYPE_INFO typeInfo = NODE_TYPE_INFO.HME_NT_NODE;
            string strDevUrl = "";
            #region 基本信息初始化
            Temp_iResult = SDK_HuaMai.hm_sdk_init();
            SDK_HuaMai._LOGIN_SERVER_INFO loginInfo = new SDK_HuaMai._LOGIN_SERVER_INFO();
            loginInfo.ip = "huamaiyun.com";
            loginInfo.port = 80;
            //loginInfo.user = u.GetString(Encoding.Unicode.GetBytes("商丘市视频联网报警中心"));   //成功
            //loginInfo.password = "2299579";
            //loginInfo.user = Encoding.UTF8.GetString(Encoding.Unicode.GetBytes("商丘市视频联网报警中心"));   //成功
            //loginInfo.password = "2299579";
            loginInfo.user = "test1996";
            loginInfo.password = "123456";
            loginInfo.plat_type = "pc";
            loginInfo.hard_ver = "Pentium4";
            loginInfo.soft_ver = "v1.1.0.1789";
            IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(SDK_HuaMai._LOGIN_SERVER_INFO)));
            Marshal.StructureToPtr(loginInfo, iServerInfo, false);
            Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
            #endregion
            Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
            Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
            Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);
            Temp_iResult = SDK_HuaMai.hm_server_get_root(intptrTree, ref iRootNode);
            Temp_iResult = SDK_HuaMai.hm_server_get_children_count(iRootNode, ref intCount);
        }


        public bool GetNode_ByIndex(IntPtr iSourceNodo, int intindex)
        {
            UInt32 Temp_iResult = 0;
            Temp_iResult = SDK_HuaMai.hm_server_get_child_at(iSourceNodo, intindex, ref iNode);
            return Temp_iResult == 0;
        }

        public bool GetNode_BySN(string strSN)
        {
            UInt32 iResult = 0;
            iResult = SDK_HuaMai.hm_server_find_device_by_sn(intptrTree, strSN, ref iNode);
            if (iResult == Convert.ToUInt32(0) && iNode != IntPtr.Zero)
            {
                return true;
            }
            return false;
        }
        int intCountttt = 0;
        private void OnRecvRealTimeVideo(IntPtr iUser, IntPtr iFrmae, UInt32 err)
        {

            //intCountttt++;
            //if (intCountttt > 100)
            //{
            //    return;
            //}
            if (err != Convert.ToUInt32(0))
            {
                return;
            }
            if (iPort == IntPtr.Zero)
            {
                string x = "1";
                return;
            }
            var result = Marshal.PtrToStructure(iFrmae, typeof(SDK_HuaMai._FRAME_DATA));
            SDK_HuaMai._FRAME_DATA A = (SDK_HuaMai._FRAME_DATA)result;
            //int intx = (int)A.frame_len;
            SDK_HuaMai._RAW_FRAME_TYPE xx = (SDK_HuaMai._RAW_FRAME_TYPE)A.frame_info.frame_type;
            if (A.frame_len < 10)
            {
                string zzz = "1";
            }
            switch (xx)
            {
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_P:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_I:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_H265_P:
                case SDK_HuaMai._RAW_FRAME_TYPE.HME_RFT_H265_I:
                    try
                    {
                        SDK_HuaMai.hm_video_display_input_data(iPort, A.frame_stream, A.frame_len, true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    break;
                default:
                    //不做操作
                    break;
            }
        }

        public bool LoginDev()
        {
            UInt32 iResult = 0;
            SDK_HuaMai._CONNECT_INFO config = new SDK_HuaMai._CONNECT_INFO();
            config.ct = SDK_HuaMai.CLIENT_TYPE.CT_PC;
            config.cp = SDK_HuaMai.CONNECT_PRI.CPI_DEF;
            config.cm = SDK_HuaMai.CONNECT_MODE.CM_DEF;
            iResult = SDK_HuaMai.hm_pu_login_ex(iNode, ref config, ref iDev);
            if (iResult == Convert.ToUInt32(0))
            {
                return true;
            }
            return false;
        }
        private static SDK_HuaMai.cb_pu_data callback = null;
        public bool OpenRealVideo()
        {
            UInt32 iResult = 0;
            SDK_HuaMai._OPEN_VIDEO_PARAM para = new SDK_HuaMai._OPEN_VIDEO_PARAM();
            para.channel = 0;
            para.cs_type = SDK_HuaMai.CODE_STREAM.HMS_CS_MAJOR;
            IntPtr iUserData = Marshal.StringToHGlobalAnsi("hongdongcheng");
            para.data = iUserData;
            para.vs_type = SDK_HuaMai.VIDEO_STREAM.HMS_VS_REAL;
            para.iWnd = pictureBox1.Handle;
            //callback = new ;
            para.cb_data = new SDK_HuaMai.cb_pu_data(OnRecvRealTimeVideo);
            iResult = SDK_HuaMai.hm_pu_open_video(iDev, ref para, ref iOpenVideo);
            if (iResult == Convert.ToUInt32(0))
            {
                return true;
            }
            return false;
        }

        public bool StartVideo()
        {
            UInt32 iResult = 0;
            videoRes = new SDK_HuaMai.OPEN_VIDEO_RES();
            iResult = SDK_HuaMai.hm_pu_start_video(iOpenVideo, ref videoRes);
            if (Convert.ToUInt32(0) == iResult)
            {
                return true;
            }
            return false;
        }

        public void Release()
        {
            UInt32 Temp_iResult = 0;
            Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
            Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
        }
        #endregion

        private void Frm_Temp_TestVideoPlay_Load(object sender, EventArgs e)
        {
            UInt32 iResult = 0;
            Init();
            s = pictureBox1.Size;
        }
        Size s;


        private void Frm_Temp_TestVideoPlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Release();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            UInt32 iResult = 0;
            if (!GetNode_BySN("E322213C04245"))
            {
                Release();
                return;
            }
            if (!LoginDev())
            {
                Release();
                return;
            }
            if (!OpenRealVideo())
            {
                Release();
                return;
            }
            if (!StartVideo())
            {
                Release();
            }
            SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //IntPtr iWnd = pictureBox1.Handle;
            iResult = SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
            iResult = SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
            listBox1.Items.Add(iPort.ToString());
            intCountt = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }
        int intCountt = 0;
        bool bolFlag = true;
        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {

            intCountt++;
            label1.Text = "SizeChanged" + intCountt.ToString();
            return;
            Size Temp_s = pictureBox1.Size;
            if (Math.Abs(s.Width - Temp_s.Width) > 100 || Math.Abs(s.Height - Temp_s.Height) > 100)
            {
                s = Temp_s;
                SDK_HuaMai.hm_video_display_close_port(iPort);
                SDK_HuaMai.hm_pu_stop_video(iOpenVideo);
                SDK_HuaMai.hm_pu_close_video(iOpenVideo);
                SDK_HuaMai.hm_pu_logout(iDev);
                pictureBox1.BackColor = Color.Black;
                if (!GetNode_BySN("E322213C04245"))
                {
                    Release();
                    return;
                }
                if (!LoginDev())
                {
                    Release();
                    return;
                }
                if (!OpenRealVideo())
                {
                    Release();
                    return;
                }
                if (!StartVideo())
                {
                    Release();
                }
                SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
                disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
                disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
                //IntPtr iWnd = pictureBox1.Handle;
                iPort = IntPtr.Zero;
                SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
                SDK_HuaMai.hm_video_display_start(iPort, videoRes.image_width, videoRes.image_height, videoRes.fps);
                intCountt = 0;
                listBox1.Items.Add(iPort.ToString());
            }
            return;

            if (bolFlag)
            {
                bolFlag = false;
                SDK_HuaMai.hm_video_display_stop(iPort);
                SDK_HuaMai.hm_video_display_close_port(iPort);
                //StartOpenVideo();
                SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
                disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
                disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
                ////IntPtr iWnd = pictureBox1.Handle;
                SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
                SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
                bolFlag = true;
            }

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Frm_Temp_TestVideoPlay_SizeChanged(object sender, EventArgs e)
        {
            //SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
            //this.Refresh();
        }
        bool bolFlagg = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //UInt32 iResult = 0;
            //intCountt++;
            //bolFlagg = !bolFlagg;
            //if (bolFlagg)
            //{
            //    this.Text = intCountt.ToString();
            //    if (!GetNode_BySN("E322213C04245"))
            //    {
            //        Release();
            //        return;
            //    }
            //    if (!LoginDev())
            //    {
            //        Release();
            //        return;
            //    }
            //    if (!OpenRealVideo())
            //    {
            //        Release();
            //        return;
            //    }
            //    if (!StartVideo())
            //    {
            //        Release();
            //    }
            //    SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            //    disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            //    disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //    //IntPtr iWnd = pictureBox1.Handle;
            //    iPort = IntPtr.Zero;
            //    iResult = SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
            //    iResult = SDK_HuaMai.hm_video_display_start(iPort, videoRes.image_width, videoRes.image_height, videoRes.fps);
            //    intCountt = 0;
            //    listBox1.Items.Add(iPort.ToString());
            //}
            //else
            //{
            //    SDK_HuaMai.hm_video_display_close_port(iPort);
            //    SDK_HuaMai.hm_pu_stop_video(iOpenVideo);
            //    SDK_HuaMai.hm_pu_close_video(iOpenVideo);
            //    SDK_HuaMai.hm_pu_logout(iDev);
            //}
            



            //return;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }
        
        int intCountResize = 0;
        private void Frm_Temp_TestVideoPlay_Resize(object sender, EventArgs e)
        {
            intCountResize++;
            label1.Text = intCountResize.ToString();
        }
        int intCountRegionChanged = 0;
        private void Frm_Temp_TestVideoPlay_RegionChanged(object sender, EventArgs e)
        {
            
        }
        int intCountResizeBegin = 0;
        private void Frm_Temp_TestVideoPlay_ResizeBegin(object sender, EventArgs e)
        {
            return;
            SDK_HuaMai.hm_video_display_close_port(iPort);
            iPort = IntPtr.Zero;
            SDK_HuaMai.hm_pu_stop_video(iOpenVideo);
            SDK_HuaMai.hm_pu_close_video(iOpenVideo);
            SDK_HuaMai.hm_pu_logout(iDev);
            return;
            //SDK_HuaMai.hm_video_display_stop(iPort);
            intCountResizeBegin++;
            label3.Text = intCountResizeBegin.ToString();
            
        }
        int intCountResizeEnd = 0;
        private void Frm_Temp_TestVideoPlay_ResizeEnd(object sender, EventArgs e)
        {
            return;
            intCountResizeEnd++;
            label4.Text = intCountResizeEnd.ToString();
            if (!GetNode_BySN("E322213C04245"))
            {
                Release();
                return;
            }
            if (!LoginDev())
            {
                Release();
                return;
            }
            if (!OpenRealVideo())
            {
                Release();
                return;
            }
            if (!StartVideo())
            {
                Release();
            }
            SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
            disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
            disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
            //IntPtr iWnd = pictureBox1.Handle;
            iPort = IntPtr.Zero;
            SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
            SDK_HuaMai.hm_video_display_start(iPort, 0, 0, 25);
            listBox1.Items.Add(iPort.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SDK_HuaMai.hm_video_display_close_port(iPort);
            iPort = IntPtr.Zero;
            SDK_HuaMai.hm_pu_stop_video(iOpenVideo);
            SDK_HuaMai.hm_pu_close_video(iOpenVideo);
            SDK_HuaMai.hm_pu_logout(iDev);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UInt32 iResult = 0;
            intCountt++;
            bolFlagg = true;
            if (bolFlag)
            {
                this.Text = intCountt.ToString();
                if (!GetNode_BySN("E322213C04245"))
                {
                    Release();
                    return;
                }
                if (!LoginDev())
                {
                    Release();
                    return;
                }
                if (!OpenRealVideo())
                {
                    Release();
                    return;
                }
                if (!StartVideo())
                {
                    Release();
                }
                SDK_HuaMai.DISPLAY_OPTION disp_op = new SDK_HuaMai.DISPLAY_OPTION();
                disp_op.dm = SDK_HuaMai.DISPLAY_MODE.HME_DM_DX;
                disp_op.pq = SDK_HuaMai.PIC_QUALITY.HME_PQ_HIGHT;
                //IntPtr iWnd = pictureBox1.Handle;
                iResult = SDK_HuaMai.hm_video_display_open_port(pictureBox1.Handle, ref disp_op, ref iPort);
                iResult = SDK_HuaMai.hm_video_display_start(iPort, videoRes.image_width, videoRes.image_height, videoRes.fps);
                intCountt = 0;
            }
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            intCountRegionChanged++;
            label2.Text = "pictureBox1_Paint" + intCountRegionChanged.ToString();
        }
    }
}
