﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VideoPlayControl_UseDemo.ControlTest;
using VideoPlayControl_UseDemo.RemoteBackplay;
using VideoPlayControl_UseDemo.ServerTest;
using VideoPlayControl_UseDemo.TalkTest;
using VideoPlayControl_UseDemo.VideoPlay;

namespace VideoPlayControl_UseDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FrmExtendedControlTest());
            //Application.Run(new Frm_VideoRecordListTest());
            //Application.Run(new FrmHikTest());
            //Application.Run(new FrmTest());
            //Application.Run(new Frn_VideoPlayGroupControl_Basic());
            //Application.Run(new FrmVideoInfoList());
            //Application.Run(new FrmMain());
            //Application.Run(new Frm_MulitPicturte());
            //Application.Run(new FrmTalkControlTest());
            //Application.Run(new FrmEzviz());
            //Application.Run(new Frm_VideoTalkControlManyChannel_Test());

            //Application.Run(new Frm_VideoPlayGroupControls_PTZAndTalk());
            //Application.Run(new FrmMain());
            //Application.Run(new FrmSKServerTest());
            //Application.Run(new FrmTalkTest_SK());
            //Application.Run(new Frm_RemoteBackplay());
            //Application.Run(new Frm_RemoteBackplay_ZL());


            //Application.Run(new Frm_VideoPlay_Hik());

            //Application.Run(new FrmSKNVideo_RemoterTest());
            //Application.Run(new FrmSKNServerTest());
            //Application.Run(new Frm_MulitPicturte());
            //Application.Run(new FrmSKVideoSDKTest());
            //Application.Run(new FrmTest());
            //Application.Run(new Form1());
            //Application.Run(new Frm_Temp_TestVideoPlay());
            //Application.Run(new Frm_Temp_TestAxis());
            //Application.Run(new FrmVideoRecordBackplayWindow());


            //Application.Run(new Frm_VideoPlay_TDWY());
            //Application.Run(new FrmMain());
            //Application.Run(new Frm_VideoPlayWindowPTZ_Test());
            Application.Run(new Frm_MulitPicturte());
            

            //Application.Run(new Frm_VideoPlay_HikStream());

        }
    }
}
