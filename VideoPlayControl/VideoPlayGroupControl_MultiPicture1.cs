using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControl_MultiPicture1 : UserControl
    {

        #region 公用参数
        public Color clrDefaulWindowColor = Color.Black;
        public Color clrSelectedWindowColor = Color.Cyan;
        public VideoPlayWindow CurrentV = null;
        public bool AutoSelectedNextWindow = true;
        public bool SelectedWindowHiglight = true;
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

        }

        #region 外部调用接口
        /// <summary>
        /// 
        /// </summary>
        /// <param name="intNum"></param>
        public bool SetWindowNum(int intNum)
        {
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

        public bool SetPlayVideoInfo(VideoInfo v)
        {
            CurrentV.Init_VideoInfo(v);
            CurrentV.VideoPlay();
            GetNextWindow();
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
            GetNextWindow();
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
            GetNextWindow();
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
            GetNextWindow();
            return true;
        }

        public void VideoColse_All()
        {
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                v.VideoClose();
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
