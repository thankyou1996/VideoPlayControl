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
                            videoPlayWindow.Margin = new Padding(1);
                            tablayMain.Controls.Add(videoPlayWindow);
                            tablayMain.SetRow(videoPlayWindow, row);
                            tablayMain.SetColumn(videoPlayWindow, col);
                            dicWin[i] = videoPlayWindow;
                            i++;
                        }
                    }
                    

                    break;
                default:
                    return false;
            }
            return true;
        }
    
        /// <summary>
        /// 设置播放信息
        /// </summary>
        /// <param name="v"></param>
        /// <param name="iIndex"></param>
        /// <returns></returns>
        public bool SetPlayVideoInfo(VideoInfo v ,int iIndex)
        {
            if (!dicWin.ContainsKey(iIndex))
            {
                return false;
            }
            dicWin[iIndex].Init_VideoInfo(v);
            dicWin[iIndex].VideoPlay();
            return true;
        }
        #endregion

        private void tablayMain_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            //Pen pp = new Pen(Color.Red);
            //e.Graphics.DrawRectangle(pp, e.CellBounds.X, e.CellBounds.Y, e.CellBounds.X + e.CellBounds.Width - 1, e.CellBounds.Y + e.CellBounds.Height - 1);
        }
    }
}
