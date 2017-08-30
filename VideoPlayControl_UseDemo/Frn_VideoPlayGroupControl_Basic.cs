using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            videoPlayGroupControls_Basic1.bolAutoPlayVideo = false;
            //videoPlayGroupControls_Basic1.videoPlaySet.VideoRecordEnable = true;
            videoPlayGroupControls_Basic1.videoPlaySet.VideoMonitorEnable = true;
            //videoPlayGroupControls_Basic1.bolDisplaySDKEvent = true;
            //videoPlayGroupControls_Basic1.bolDisPlaySDKState = true;
            //videoPlayGroupControls_Basic1.videoPlaySet.PreSetPosi = 13;
            SDKState.CloundSee_SDKInit();
            Test();
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
            //videoInfo.DVSAddress = "T88384271";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "123";
            videoInfo.PreviewPwd = "";
            videoInfo.DVSType = "sk8504ZW";
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
            videoInfo.VideoType = Enum_VideoType.CloundSee;
            videoInfo.DVSNumber = "000102";
            videoInfo.DVSName = "000102视频";
            //videoInfo.DVSAddress = "X7656498";
            videoInfo.DVSAddress = "X12041891";
            videoInfo.DVSConnectPort = 9101;
            videoInfo.UserName = "admin";
            videoInfo.Password = "12345";
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
            videoPlayGroupControls_Basic1.bolAutoPlayVideo = true;
        }
        
    }
}
