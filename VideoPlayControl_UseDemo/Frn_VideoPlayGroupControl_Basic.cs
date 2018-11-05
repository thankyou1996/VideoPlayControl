using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo
{
    public partial class Frn_VideoPlayGroupControl_Basic : Form
    {
        public Frn_VideoPlayGroupControl_Basic()
        {
            InitializeComponent();
        }

        private void Frn_VideoPlayGroupControl_Basic_Load(object sender, EventArgs e)
        {
            VideoPlayControl.ProgParameter.strEzviz__AppID = "5b97c1d157474f96b8d4c75b936a0057";
            VideoPlayControl.ProgParameter.strEzviz_AppSecret = "4318d0cc4c43ca156052ba688bc9006a";
            videoPlayGroupControls_Basic1.bolAutoPlayVideo = true;
            videoPlayGroupControls_Basic1.videoPlaySet.VideoRecordEnable = true;
            videoPlayGroupControls_Basic1.videoPlaySet.VideoMonitorEnable = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.VideoRecordFilePath = "C:\\SHIKE_Video\\4603\\20170925094530";
            //videoPlayGroupControls_Basic1.bolDisplaySDKEvent = true;
            //videoPlayGroupControls_Basic1.bolDisPlaySDKState = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.PreSetPosi = 13;
            SDKState.CloundSee_SDKInit();
            SDKState.Ezviz_SDKInit();
            SDKState.SKVideoSDKInit("hdc1", "192.168.2.19");
            SetTestData_ZWVideoAndSKTalk();
        }

        public void Test()
        {
            //X5014851
            //X6937816
            //X7438372
            //X5796224
            //X4659975
            //X6227077
            //X6944415
            //X7325728
            //X12041891
            //X7635198
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            //dicVideoInfos=


            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "000101视频";
            videoInfo.DVSAddress = "X5014851";
            //videoInfo.DVSAddress = "720274352";
            //videoInfo.DVSAddress = "532446995";
            //videoInfo.DVSAddress = "797085722";
            //videoInfo.DVSAddress = "607669776";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "JHESSY";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK85016YS";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "000102视频";
            //videoInfo.DVSAddress = "X7656498";
            videoInfo.DVSAddress = "X15987";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "12345";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000103";
            videoInfo.DVSName = "000103视频";
            //videoInfo.DVSAddress = "X6392641";
            //videoInfo.DVSAddress = "X7591643";
            videoInfo.DVSConnectPort = 9010;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "123456";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000104";
            videoInfo.DVSName = "000104视频";
            //videoInfo.DVSAddress = "X12042037";
            videoInfo.DVSAddress = "X6392641";
            videoInfo.DVSConnectPort = 9010;
            videoInfo.UserName = "admin";
            videoInfo.Password = "123";
            videoInfo.PreviewPwd = "12345";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 5;
            camerasInfo = new CameraInfo();
            for (int i = 0; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;

            videoPlayGroupControls_Basic1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_Basic1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_Basic1.Init_VideoInfoSet(dicVideoInfos);
        }

        #region 测试数据

        public void SetTestData_ZWVideoAndSKTalk()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "ZW视频";
            videoInfo.DVSAddress = "X5014851";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "JHESSY";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK8501ZW";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 8;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;


            videoInfo = new VideoInfo();
            videoInfo.VideoType = Enum_VideoType.SKVideo;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "SK519V";
            videoInfo.DVSType = "SK519V";
            videoInfo.DVSAddress = "71-00F51F012D0C-2830";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
            videoInfo.PreviewPwd = "";
            videoInfo.IntercomEnable = true;
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            videoPlayGroupControls_Basic1.bolPreViewPwdVerify = false;
            videoPlayGroupControls_Basic1.PreViewPwdVerifyEvent += PreViewPwdVerify;
            videoPlayGroupControls_Basic1.Init_VideoInfoSet(dicVideoInfos);
        }

        #endregion


        public bool PreViewPwdVerify(object sender, string strVideoID)
        {
            VideoPlayGroupControls_Basic v = (VideoPlayGroupControls_Basic)sender;
            if (v.dicCurrentVideoInfos[strVideoID].PreviewPwd == "123456")
            {
                return true;
            }
            return false;
        }

        private void Frn_VideoPlayGroupControl_Basic_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoPlayGroupControls_Basic1.ControlClose();
        }

        private void Frn_VideoPlayGroupControl_Basic_Move(object sender, EventArgs e)
        {
            videoPlayGroupControls_Basic1.ControlMove();
        }


        private void btnVideoPlay_Click(object sender, EventArgs e)
        {
            string strVideoID = txtVideoID.Text;
            int strCameraID = Convert.ToInt32(txtCameraID.Text);
            videoPlayGroupControls_Basic1.VideoPlay(strVideoID, strCameraID);
            videoPlayGroupControls_Basic1.bolAutoPlayVideo = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test();
            string strVideoID = txtVideoID.Text;
            int strCameraID = Convert.ToInt32(txtCameraID.Text);
            videoPlayGroupControls_Basic1.VideoPlay(strVideoID, strCameraID);
        }

        private void btnSDKReInit_Click(object sender, EventArgs e)
        {
            SDKState.ColundSee_SDKRelease();
            SDKState.CloundSee_SDKInit();
        }

        private void btnTestData1_Click(object sender, EventArgs e)
        {
            TestData1();
        }
        /// <summary>
        /// 萤石数据
        /// </summary>
        public void TestData1()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.Ezviz;
            videoInfo.DVSNumber = "000101";
            videoInfo.DVSName = "000101视频";
            videoInfo.DVSAddress = "756217914";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK85016YS";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            videoPlayGroupControls_Basic1.Init_VideoInfoSet(dicVideoInfos);
            videoPlayGroupControls_Basic1.VideoPlay("000101", 5);
        }

        private void btnTestData2_Click(object sender, EventArgs e)
        {
            TestData2();
        }

        /// <summary>
        /// 云视通数据
        /// </summary>
        public void TestData2()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000201";
            videoInfo.DVSName = "000201视频";
            videoInfo.DVSAddress = "X5014851";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK8516ZW";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            videoPlayGroupControls_Basic1.Init_VideoInfoSet(dicVideoInfos);
            videoPlayGroupControls_Basic1.VideoPlay("000201", 2);
        }

        private void btnTestData3_Click(object sender, EventArgs e)
        {
            TestData3();
        }

        /// <summary>
        /// 萤石数据
        /// </summary>
        public void TestData3()
        {
            Dictionary<string, VideoInfo> dicVideoInfos = new Dictionary<string, VideoInfo>();
            VideoInfo videoInfo = new VideoInfo();
            CameraInfo camerasInfo = new CameraInfo();
            videoInfo.VideoType = Enum_VideoType.Ezviz;
            videoInfo.DVSNumber = "000301";
            videoInfo.DVSName = "000301视频";
            videoInfo.DVSAddress = "720274352";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "SK85016YS";
            videoInfo.Cameras = new Dictionary<int, CameraInfo>();
            videoInfo.DVSChannelNum = 16;
            camerasInfo = new CameraInfo();
            for (int i = 1; i < videoInfo.DVSChannelNum; i++)
            {
                camerasInfo = new CameraInfo();
                camerasInfo.Channel = i;
                camerasInfo.CameraName = "摄像机" + (i + 1);
                videoInfo.Cameras[i] = camerasInfo;
            }
            dicVideoInfos[videoInfo.DVSNumber] = videoInfo;
            videoPlayGroupControls_Basic1.Init_VideoInfoSet(dicVideoInfos);
            videoPlayGroupControls_Basic1.VideoPlay("000301", 1);
        }
    }
}
