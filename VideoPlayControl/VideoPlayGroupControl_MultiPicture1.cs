using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PublicClassCurrency;
using CommonMethod;
using VideoPlayControl.Controls;

namespace VideoPlayControl
{
    public partial class VideoPlayGroupControl_MultiPicture1 : UserControl
    {

        #region 公用参数
        public Color clrDefaulWindowColor = Color.White;
        public Color clrSelectedWindowColor = Color.Cyan;
        private VideoPlayWindow currentV = null;
        /// <summary>
        /// 当前视频控件
        /// </summary>
        public VideoPlayWindow CurrentV
        {
            get { return currentV; }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (currentV != value)
                {
                    currentV = value;
                    if (SelectedWindowHiglight)
                    {
                        currentV.BackColor = clrSelectedWindowColor;
                    }
                    SelectVideoPlayWindowChanged(null);
                }
            }

        }
        public bool AutoSelectedNextWindow = true;
        public bool SelectedWindowHiglight = true;
        public bool DisplayToolTipInfo = true;

        public VideoPlaySetting CurrentVideoPlaySet = new VideoPlaySetting();

        public int WindowNum
        {
            get
            {
                return dicWin.Count;
            }
            set
            {
                SetWindowNum(value);
            }
        }

        #endregion

        #region 事件委托 
        private event VideoPlayCallbackDelegate videoPlayCallbaclEvent;
        /// <summary>
        /// 视频播放回调事件
        /// </summary>
        public event VideoPlayCallbackDelegate VideoPlayCallbackEvent
        {
            add
            {
                foreach (VideoPlayWindow v in dicWin.Values)
                {
                    v.VideoPlayCallbackEvent += value;
                }
                videoPlayCallbaclEvent += value;
            }
            remove
            {
                foreach (VideoPlayWindow v in dicWin.Values)
                {
                    v.VideoPlayCallbackEvent -= value;
                }
                videoPlayCallbaclEvent += value;
            }
        }

        /// <summary>
        /// 播放窗口状态改变事件
        /// </summary>
        public event PlayWindowStatusChangedDelegate PlayWindowStatusChangedEvent;

        public event SelectVideoPlayWindowChangedDelegate SelectVideoPlayWindowChangedEvent;

        public void SelectVideoPlayWindowChanged(object SelectVideoPlayWindowChangedValue)
        {
            if (SelectVideoPlayWindowChangedEvent != null)
            {
                SelectVideoPlayWindowChangedEvent(this, SelectVideoPlayWindowChangedValue);
            }
        }
        #endregion
        Dictionary<int, VideoPlayWindow> dicWin = new Dictionary<int, VideoPlayWindow>();

        /// <summary>
        /// 0.表示正常状态 
        /// 1.表示最大化状态
        /// </summary>
        private int intPlayWindowsStatus = 0;
        /// <summary>
        /// 0.表示正常状态 
        /// 1.表示最大化状态
        /// </summary>
        public int PlayWindowsStatus
        {
            get { return intPlayWindowsStatus; }
            private set
            {
                if (intPlayWindowsStatus != value)
                {
                    intPlayWindowsStatus = value;
                    if (PlayWindowStatusChangedEvent != null)
                    {
                        PlayWindowStatusChangedEvent(this, null);
                   }
                }
            }
        }

        public bool PlayWindowsMax
        {
            get { return PlayWindowsStatus == 1; }
        }
        public VideoPlayGroupControl_MultiPicture1()
        {
            InitializeComponent();
            if (WindowNum == 0)
            {
                WindowNum = 1;
            }
        }

        private void VideoPlayGroupControl_MultiPicture1_Load(object sender, EventArgs e)
        {
            this.Disposed += VideoPlayGroupControl_MultiPicture1_Disposed;
        }

        private void VideoPlayGroupControl_MultiPicture1_Disposed(object sender, EventArgs e)
        {
            VideoColse_All();
        }



        #region 外部调用接口

        /// <summary>
        /// 设置播放窗体为最大化模式
        /// </summary>
        /// <returns></returns>
        public bool SetPlayWindowsMax()
        {
            return SetPlayWindowsMax(CurrentV);
        }
        /// <summary>
        /// 设置播放窗体为最大化模式
        /// </summary>
        /// <param name="vWindows"></param>
        /// <returns></returns>
        public bool SetPlayWindowsMax(VideoPlayWindow vWindows)
        {
            bool bolResult = false;
            int Temp_intRow = tablayMain.GetRow(vWindows);
            int Temp_intColumns = tablayMain.GetColumn(vWindows);
            tablayMain.SuspendLayout();
            #region 移除旧控件 信息
            #endregion
            if (PlayWindowsMax)
            {
                //处于最大化状态，变为等分状态
                SetPlayWindowsAverage();
            }
            else
            {
                tablayMain.RowStyles.Clear();
                tablayMain.ColumnStyles.Clear();
                //处于等分状态，变为最大化
                for (int row = 0; row < tablayMain.RowCount; row++)
                {
                    if (row == Temp_intRow)
                    {
                        tablayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
                    }
                    else
                    {
                        tablayMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 0));
                    }

                }
                for (int col = 0; col < tablayMain.ColumnCount; col++)
                {
                    if (col == Temp_intColumns)
                    {
                        tablayMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                    }
                    else
                    {
                        tablayMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 0));
                    }
                }
                PlayWindowsStatus = 1;
                tablayMain.ResumeLayout();
            }
            return bolResult;
        }


        /// <summary>
        /// 设置播放窗体为等分模式
        /// </summary>
        public void SetPlayWindowsAverage()
        {
            tablayMain.RowStyles.Clear();
            tablayMain.ColumnStyles.Clear();
            for (int row = 0; row < tablayMain.RowCount; row++)
            {
                tablayMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            }
            for (int col = 0; col < tablayMain.ColumnCount; col++)
            {
                tablayMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            }
            PlayWindowsStatus = 0;
            tablayMain.ResumeLayout();
        }

        /// <summary>
        /// 设置Windows界面数量
        /// </summary>
        /// <param name="intNum"></param>
        public bool SetWindowNum(int intNum)
        {
            if (intNum == 0)
            {
                intNum = 1;
            }
            if (this.WindowNum == intNum)
            {
                this.VideoColse_All();
                //处于最大化状态
                if (PlayWindowsMax && this.WindowNum > 1)
                {
                    //重置界面
                    //Row Col重置
                    SetPlayWindowsAverage();
                }
                return true;
            }
            Console.WriteLine("SetWindowNum" + intNum);
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
                            VideoPlayWindow_PTZ videoPlayWindow = new VideoPlayWindow_PTZ();
                            videoPlayWindow.Name = "Video_" + i;
                            videoPlayWindow.Size = new Size(100, 100);
                            videoPlayWindow.Dock = DockStyle.Fill;
                            videoPlayWindow.BackColor = Color.Black;
                            videoPlayWindow.Margin = new Padding(0);
                            videoPlayWindow.Padding = new Padding(1);
                            videoPlayWindow.BackColor = clrDefaulWindowColor;
                            videoPlayWindow.CurrentVideoPlaySet = CurrentVideoPlaySet;  //赋值播放设置
                            videoPlayWindow.VideoPlayCallbackEvent += videoPlayCallbaclEvent;
                            tablayMain.Controls.Add(videoPlayWindow);
                            tablayMain.SetRow(videoPlayWindow, row);
                            tablayMain.SetColumn(videoPlayWindow, col);
                            videoPlayWindow.PicMain.MouseDown += PicMain_MouseDown;
                            videoPlayWindow.PicMain.MouseDoubleClick += PicMain_MouseDoubleClick;
                            dicWin[i] = videoPlayWindow;

                            i++;
                        }
                    }
                    CurrentV = dicWin[0];
                    break;
                default:
                    return false;
            }
            return true;
        }

        private void PicMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SetPlayWindowsMax();
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

        #region 设置视频播放



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
        /// <param name="iChannel"></param>
        /// <returns></returns>
        public bool SetPlayVideoInfo(VideoInfo v, int iChannel)
        {
            CurrentV.CurrentVideoPlaySet = CurrentVideoPlaySet;
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
        public bool SetPlayVideoInfo_Index(VideoInfo v, int iIndex)
        {
            if (!dicWin.ContainsKey(iIndex))
            {
                return false;
            }
            dicWin[iIndex].CurrentVideoPlaySet = CurrentVideoPlaySet;
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
            dicWin[iIndex].CurrentVideoPlaySet = CurrentVideoPlaySet;
            dicWin[iIndex].Init_VideoInfo(v, intChannel);
            dicWin[iIndex].VideoPlay();
            SetToolTipInfo(dicWin[iIndex]);
            return true;
        }


        public void SetPlayInfo(List<CameraInfo> lstCameraInfo)
        {
            SetPlayInfo(lstCameraInfo, CurrentVideoPlaySet);
        }

        public void SetPlayInfo(List<CameraInfo> lstCameraInfo, VideoPlaySetting videoPlaySet)
        {
            int iIndex = 0;
            foreach (CameraInfo cInfo in lstCameraInfo)
            {
                if (iIndex < this.dicWin.Count)
                {
                    Common.Delay_Millisecond(50);
                    this.SetPlayInfo(dicWin[iIndex], cInfo.VideoInfo, cInfo, videoPlaySet);
                }
                iIndex++;
            }
        }


        public void SetPlayInfo(CameraInfo cInfo)
        {
            SetPlayInfo(CurrentV, cInfo.VideoInfo, cInfo, CurrentVideoPlaySet);
        }
        public void SetPlayInfo(CameraInfo cInfo, VideoPlaySetting videoPlaySetting)
        {
            SetPlayInfo(CurrentV, cInfo.VideoInfo, cInfo, videoPlaySetting);
        }

        public void SetPlayInfo(VideoInfo vInfo, CameraInfo cInfo)
        {
            SetPlayInfo(CurrentV, vInfo, cInfo, CurrentVideoPlaySet);
        }

        public void SetPlayInfo(VideoPlayWindow vWindow, VideoInfo vInfo ,CameraInfo cInfo, VideoPlaySetting videoPlaySet)
        {
            vWindow.Init_VideoInfo(vInfo, cInfo, videoPlaySet);
            SetToolTipInfo(vWindow);
            vWindow.VideoPlay();
        }
        #endregion


        #region 视频关闭相关方法
        /// <summary>
        /// 关闭所有视频
        /// </summary>
        public void VideoColse_All()
        {
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                VideoClose(v);
            }
        }
        /// <summary>
        /// 关闭当前视频
        /// </summary>
        public void VideoClose()
        {
            VideoClose(CurrentV);
        }

        /// <summary>
        /// 关闭视频
        /// </summary>
        /// <param name="v"></param>
        public void VideoClose(VideoPlayWindow v )
        {
            v.VideoClose();
            SetToolTipInfo(v, "");
        }



        #endregion

        /// <summary>
        /// 打开声音通道
        /// </summary>
        /// <returns></returns>
        public bool OpenSound()
        {
            bool bolResult = false;
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                v.OpenSound();
            }
            return bolResult;
        }

        /// <summary>
        /// 关闭声音通道
        /// </summary>
        /// <returns></returns>
        public bool CloseSound()
        {
            bool bolResult = false;
            foreach (VideoPlayWindow v in dicWin.Values)
            {
                v.CloseSound();
            }
            return bolResult;
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
                    foreach (VideoPlayWindow vv in dicWin.Values)
                    {
                        vv.BackColor = clrDefaulWindowColor;
                    }
                    CurrentV = v;
                    break;
                }
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

        private void PicMain_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            VideoPlayWindow v = (VideoPlayWindow)p.Parent;
            foreach (VideoPlayWindow vv in dicWin.Values)
            {
                if (vv.Equals(v))
                {
                    CurrentV = v;
                }
                else
                {
                    vv.BackColor = clrDefaulWindowColor;
                }
            }
            Console.WriteLine(v.Name);
        }
    }
}
