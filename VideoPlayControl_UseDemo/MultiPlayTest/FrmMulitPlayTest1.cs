using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VideoPlayControl;

namespace VideoPlayControl_UseDemo.MultiPlayTest
{
    public partial class FrmMulitPlayTest1 : Form
    {
        public FrmMulitPlayTest1()
        {
            InitializeComponent();

            //videoPlayGroupControl_MultiPicture11.Disposed += VideoPlayGroupControl_MultiPicture11_Disposed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VideoInfo v1 = TestDataSource.DaHuaSource.GetDaHuaData1();
            VideoInfo v2 = TestDataSource.HikDataSource.GetHikData1();
            VideoInfo v3 = TestDataSource.EzvizDataSource.GetEzvizInfo10();
            List<VideoInfo> lstV = new List<VideoInfo>();

            //时刻前四路
            //v1.Cameras = new Dictionary<int, CameraInfo>();
            //for (int i = 0; i < 4; i++)
            //{
            //    CameraInfo c = new CameraInfo();
            //    c.CameraName = "摄像头" + (i);
            //    c.Channel = i;
            //    //c.DVSAddress = "E322213C04245";
            //    c.DVSType = "SK8616";
            //    c.DVSNumber = "000501";
            //    v1.Cameras[c.Channel] = c;
            //}

            //智诺前2路
            v2.Cameras = new Dictionary<int, CameraInfo>();
            for (int i = 1; i < 3; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8616";
                c.DVSNumber = "000501";
                v2.Cameras[c.Channel] = c;
            }
            //萤石 6  
            v3.Cameras = new Dictionary<int, CameraInfo>();
            for (int i = 6; i < 7; i++)
            {
                CameraInfo c = new CameraInfo();
                c.CameraName = "摄像头" + (i);
                c.Channel = i;
                //c.DVSAddress = "E322213C04245";
                c.DVSType = "SK8605HM";
                c.DVSNumber = "000501";
                v3.Cameras[c.Channel] = c;
            }
            lstV.Add(v3);
            lstV.Add(v1);
            lstV.Add(v2);
            videoPlayGroupControl_MultiPicture11.SetVideoPlaySet(GetVideoPlaySet());
            videoPlayGroupControl_MultiPicture11.SetPlayVideoInfo(lstV);
        }

        private void VideoPlayGroupControl_MultiPicture11_Disposed(object sender, EventArgs e)
        {
            Console.WriteLine("Control Close");
            //throw new NotImplementedException();
        }

        public VideoPlaySetting GetVideoPlaySet()
        {
            VideoPlaySetting result = new VideoPlaySetting
            {
                TimeOutVideoCloseSecond = 10,
                TimeOutVideoRecordCloseSecond = 10,
            };
            return result;
        }

        private void FrmMulitPlayTest1_Load(object sender, EventArgs e)
        {

        }
    }
}
