using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using CommonMethod;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControl_MultiPicture1 : UserControl
    {

        #region 公用参数
        public Color clrDefaulWindowColor = Color.White;
        public Color clrSelectedWindowColor = Color.Cyan;
        public VideoPlayWindow CurrentV = null;
        public bool AutoSelectedNextWindow = true;
        public bool SelectedWindowHiglight = true;
        public bool DisplayToolTipInfo = true;

        public VideoPlaySetting CurrentVideoPlaySet = new VideoPlaySetting();

        public int WindowNum
        {
            get { return dicWin.Count; }
        }
        #endregion
        Dictionary<int, VideoPlayWindow> dicWin = new Dictionary<int, VideoPlayWindow>();
        Dictionary<int, VideoInfo> dicVideo = new Dictionary<int, VideoInfo>();
        public VideoPlayGroupControl_MultiPicture1()
        {
            InitializeComponent();
        }

        private void VideoPlayGroupControl_MultiPicture1_Load(object sender, EventArgs e)
        {
            SetWindowNum(4);
        }

        #region 外部调用接口
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intNum"></param>
        public bool SetWindowNum(int intNum)
        {

            if (this.WindowNum == intNum)
            {
                this.VideoColse_All();
                return true;
            }
            switch (intNum)
            {
                case 1:
                case 4:
                case 9:
                case 16:
                    double Temp_dblNum = intNum;
                    int Temp_intRow = Convert.ToInt32(Math.Sqrt(Temp_dblNum));
                    tablayMain.RowCount = Temp_intRow;
                    tablayMain.ColumnCount = Temp_intRow;
                    //清除旧控件信息
                    VideoColse_All();
                    foreach (VideoPlayWindow v in dicWin.Values)
                    {
                        v.VideoClose();
                    }
                    dicWin.Clear();
                    dicVideo.Clear();
                    tablayMain.RowStyles.Clear();
                    tablayMain.ColumnStyles.Clear();
                    tablayMain.Controls.Clear();
                    for (int row = 0; row < Temp_intRow; row++)
                    {
                        tablayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                        tablayMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
                    }
                    int i = 0;
                    for (int row = 0; row < Temp_intRow; row++)
                    {
                        for (int col = 0; col < Temp_intRow; col++)
                        {
                            VideoPlayWindow videoPlayWindow = new VideoPlayWindow();
                            videoPlayWindow.Name = "Video_" + i;
                            videoPlayWindow.Size = new Size(100, 100);
                            videoPlayWindow.Dock = DockStyle.Fill;
                            videoPlayWindow.BackColor = Color.Black;
                            videoPlayWindow.Margin = new Padding(0);
                            videoPlayWindow.Padding = new Padding(1);
                            videoPlayWindow.BackColor = clrDefaulWindowColor;
                            videoPlayWindow.CurrentVideoPlaySet = CurrentVideoPlaySet;  //赋值播放设置
                            tablayMain.Controls.Add(videoPlayWindow);
                            tablayMain.SetRow(videoPlayWindow, row);
                            tablayMain.SetColumn(videoPlayWindow, col);
                            videoPlayWindow.PicMain.Click += videoPlayWindow_PicMain_ClickEvent;
                            dicWin[i] = videoPlayWindow;

                            i++;
                        }
                    }
                    CurrentV = dicWin[0];
                    HighlightVideoWindows(CurrentV);
                    break;
                default:
                    return false;
            }
            return true;
        }

        public bool SetVideoPlaySet(VideoPlaySetting videoPlaySet)
        {
            bool bolResult = false;
            CurrentVideoPlaySet = videoPlaySet;
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                v.CurrentVideoPlaySet = CurrentVideoPlaySet;
            }
            return bolResult;
        }

        public bool SetPlayVideo(VideoPlayWindow window, VideoInfo v)
        {
            bool bolResult = false;
            window.Init_VideoInfo(v);
            window.VideoPlay();
            SetToolTipInfo(window);
            return bolResult;
        }

        public bool SetPlayVideoInfo(VideoInfo v)
        {
            SetPlayVideo(CurrentV, v);
            return true;
        }

        /// <summary>
        /// 设置多个播放视频播放信息 
        /// 1.超出窗口数量则不播放 
        /// </summary>
        /// <param name="lstVideo"></param>
        /// <returns></returns>
        public bool SetPlayVideoInfo(List<VideoInfo> lstVideo)
        {
            int iIndex = 0;
            foreach (VideoInfo info in lstVideo)
            {
                foreach (CameraInfo info2 in info.Cameras.Values)
                {
                    if (iIndex < this.dicWin.Count)
                    {
                        Common.Delay_Millisecond(50);
                        this.SetPlayVideoInfo_Index(info, info2.Channel, iIndex);
                        iIndex++;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="iIndex"></param>
        /// <returns></returns>
        public bool SetPlayVideoInfo(VideoInfo v, int iChannel)
        {
            CurrentV.Init_VideoInfo(v, iChannel);
            CurrentV.VideoPlay();
            SetToolTipInfo(CurrentV);
            return true;
        }


        /// <summary>
        /// 设置播放信息
        /// </summary>
        /// <param name="v"></param>
        /// <param name="iIndex"></param>
        /// <returns></returns>
        public bool SetPlayVideoInfo_Index(VideoInfo v ,int iIndex)
        {
            if (!dicWin.ContainsKey(iIndex))
            {
                return false;
            }
            dicWin[iIndex].Init_VideoInfo(v);
            dicWin[iIndex].VideoPlay();
            SetToolTipInfo(dicWin[iIndex]);
            return true;
        }

        public bool SetPlayVideoInfo_Index(VideoInfo v, int intChannel, int iIndex)
        {
            if (!dicWin.ContainsKey(iIndex))
            {
                return false;
            }
            dicWin[iIndex].Init_VideoInfo(v, intChannel);
            dicWin[iIndex].VideoPlay();
            SetToolTipInfo(dicWin[iIndex]);
            return true;
        }

        public void VideoColse_All()
        {
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                v.VideoClose();
                SetToolTipInfo(v, "");
            }
        }

        #endregion

        #region 公用方法
        public void GetNextWindow()
        {
            if (!AutoSelectedNextWindow)
            {
                return;
            }
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                if (v.VideoPlayState != Enum_VideoPlayState.InPlayState)
                {
                    CurrentV = v;
                    foreach (VideoPlayWindow vv in dicWin.Values)
                    {
                        vv.BackColor = clrDefaulWindowColor;
                    }
                    HighlightVideoWindows(CurrentV);
                    break;
                }
            }
        }

        public void HighlightVideoWindows(VideoPlayWindow v)
        {
            if (SelectedWindowHiglight)
            {
                v.BackColor = clrSelectedWindowColor;
            }
        }

        public void SetToolTipInfo(VideoPlayWindow v)
        {
            if (DisplayToolTipInfo && v.CurrentVideoInfo != null)
            {
                StringBuilder Temp_sbDisplayToopTipInfo = new StringBuilder();
                Temp_sbDisplayToopTipInfo.Append("(" + v.CurrentVideoInfo.DVSNumber + ")");
                Temp_sbDisplayToopTipInfo.Append("" + v.CurrentVideoInfo.DVSName + "");
                Temp_sbDisplayToopTipInfo.Append("_" + v.CurrentCameraInfo.CameraName + "");
                ttip.SetToolTip(v.PicMain, Temp_sbDisplayToopTipInfo.ToString());
                
            }
        }

        public bool SetToolTipInfo(VideoPlayWindow v, string strTip)
        {
            bool bolResult = false;
            ttip.SetToolTip(v.PicMain, strTip);
            return bolResult;
        }

        /// <summary>
        /// 关闭控件
        /// </summary>
        /// <returns></returns>
        public bool ControlClose()
        {
            bool bolResult = false;
            VideoColse_All();
            return bolResult;
        }
        #endregion

        private void videoPlayWindow_PicMain_ClickEvent(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            VideoPlayWindow v = (VideoPlayWindow)p.Parent;
            foreach (VideoPlayWindow vv in dicWin.Values)
            {
                if (vv.Equals(v))
                {
                    CurrentV = v;
                    HighlightVideoWindows(CurrentV);
                }
                else
                {
                    vv.BackColor = clrDefaulWindowColor;
                }
                
            }
            
        }


    }
}
