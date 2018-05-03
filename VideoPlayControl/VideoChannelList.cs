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
    /// <summary>
    /// 视频通道列表
    /// </summary>
    public partial class VideoChannelList : UserControl
    {
        #region 全局变量
        /// <summary>
        /// 当前视频信息
        /// </summary>
        public VideoInfo CurrentVideoInfo;

        /// <summary>
        /// 按钮列表
        /// </summary>
        public List<Button> lstbtns;

        /// <summary>
        /// 初始按钮位置 X
        /// </summary>
        int intbtnStartX = 1;

        /// <summary>
        /// 初始按钮位置 Y
        /// </summary>
        int intbtnStartY = 1;

        bool bolChannelButtonLoadEnd = false;
        #endregion
        #region 控件自定义属性
        /// <summary>
        /// Main背景颜色
        /// </summary>
        private Color clrBackColor = SystemColors.ControlDark;
        [Description("主体背景颜色"), Category("自定义属性")]
        public Color ClrBackColor
        {
            get { return clrBackColor; }
            set
            {
                clrBackColor = value;
                pnlMain.BackColor = clrBackColor;
            }
        }

        /// <summary>
        /// 通道按钮默认背景颜色
        /// </summary>
        private Color clrChannelButtonDefaultColor = Control.DefaultBackColor;
        [Description("通道按钮选中背景颜色"), Category("自定义属性")]
        public Color ClrChannelButtonDefaultColor
        {
            get { return clrChannelButtonDefaultColor; }
            set
            {
                clrChannelButtonDefaultColor = value;
            }
        }
        /// <summary>
        /// 通道按选中背景颜色
        /// </summary>
        private Color clrChannelButonSelectedColor = Color.Red;
        [Description("通道按钮选中背景颜色"), Category("自定义属性")]
        public Color ClrChannelButtonSelectedColor
        {
            get { return clrChannelButonSelectedColor; }
            set
            {
                clrChannelButonSelectedColor = value;
            }
        }

        /// <summary>
        /// 通道按钮列数
        /// </summary>
        private int intChannelButtonColumn = 2;
        [Description("通道按钮列数"), Category("自定义属性")]
        public int ChannelButtonColumn
        {
            get { return intChannelButtonColumn; }
            set
            {
                intChannelButtonColumn = value;
            }
        }


        /// <summary>
        /// 默认按钮宽度 60
        /// </summary>
        private int intChannelButtonWidth = 60;
        [Description("通道按钮宽度"), Category("自定义属性")]
        public int ChannelButtonWidth
        {
            get { return intChannelButtonWidth; }
            set
            {
                intChannelButtonWidth = value;
            }
        }


        /// <summary>
        /// 默认按钮高度 30
        /// </summary>
        private int intChannelButtonHeight = 30;
        [Description("通道按钮高度"), Category("自定义属性")]
        public int ChannelButtonHeight
        {
            get { return intChannelButtonHeight; }
            set
            {
                intChannelButtonHeight = value;
            }
        }



        /// <summary>
        /// 自动适应按钮尺寸
        /// </summary>
        public bool bolAutoSetBtnSize = false;
        [Description("通道按钮高度"), Category("自定义属性")]
        public bool AutoSetChannelButtonSize
        {
            get { return bolAutoSetBtnSize; }
            set
            {
                bolAutoSetBtnSize = value;
            }
        }
        #endregion
        #region 事件委托
        public delegate void ButtonChannel_ClickDelegate(object sender, Button btnChannel);

        public event ButtonChannel_ClickDelegate ButtonChannel_ClickEvent;

        private void ButtonChannel_Click(Button btnChannel)
        {
            if (ButtonChannel_ClickEvent != null)
            {
                ButtonChannel_ClickEvent(this, btnChannel);
            }
        }
        public void TEST()
        {
            if (ButtonChannel_ClickEvent != null)
            {
                Delegate[] dels = ButtonChannel_ClickEvent.GetInvocationList();
                foreach (Delegate d in dels)
                {
                    object delObj = d.GetType().GetProperty("Method").GetValue(d, null);
                    string funcName = (string)delObj.GetType().GetProperty("Name").GetValue(delObj, null);
                    //Debug.Print(funcName);
                    ButtonChannel_ClickEvent -= d as ButtonChannel_ClickDelegate;
                }
            }
        }
        #endregion 


        /// <summary>
        /// 视频通道列表名称
        /// </summary>
        public VideoChannelList()
        {
            InitializeComponent();
            lstbtns = new List<Button>();
        }

        private void VideoChannelList_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 设置视频信息
        /// </summary>
        /// <param name="videoInfo"></param>
        public void Init_SetVideoInfo(VideoInfo videoInfo)
        {
            CurrentVideoInfo = videoInfo;
            SetVideoInfoCameraInfo();

        }

        #region 初始化
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {


        }
        #endregion

        #region 公用事件
        /// <summary>
        /// 按钮背景颜色重置
        /// </summary>
        public void ButtonListBackColorReset()
        {
            foreach (Button btn in lstbtns)
            {
                btn.BackColor = clrChannelButtonDefaultColor;
            }
        }

        /// <summary>
        /// 获取选中按钮数量
        /// </summary>
        /// <returns></returns>
        public int GetSelectedButtonCount()
        {
            int intResult = 0;
            foreach (Button btn in lstbtns)
            {
                if (btn.BackColor == clrChannelButonSelectedColor)
                {
                    intResult++;
                }
            }
            return intResult;
        }
        #endregion

        /// <summary>
        /// 设置摄像头信息按钮
        /// </summary>
        public void SetVideoInfoCameraInfo()
        {
            bolChannelButtonLoadEnd = false;
            int intCol = 0;
            int intRow = 0;
            CalculationToButonSize();
            for (int i = lstbtns.Count - 1; i >= 0; i--)
            {
                lstbtns[i].Dispose();
            }
            lstbtns.Clear();
            ttip.RemoveAll();
            if (CurrentVideoInfo != null)
            {
                foreach (KeyValuePair<int, CameraInfo> kv in CurrentVideoInfo.Cameras)
                {
                    //1(x:2 y:27)  2(x:66 y=27)
                    //3(x:2,y:63)  4(x:66 y=63)
                    Button btn = new Button();
                    btn.Name = "btn" + kv.Value.Channel.ToString();
                    btn.Location = new Point(intbtnStartX + (intChannelButtonWidth * intCol), intbtnStartY + (intChannelButtonHeight * intRow));
                    btn.Size = new Size(intChannelButtonWidth, intChannelButtonHeight);
                    //btn.Text = "通道" + kv.Value.Channel.ToString();
                    btn.Text = kv.Value.CameraName.ToString();
                    btn.BackColor = Control.DefaultBackColor;
                    pnlMain.Controls.Add(btn);
                    btn.Tag = kv.Value;
                    btn.Click += btnCameraInfo_Click;
                    lstbtns.Add(btn);
                    ttip.SetToolTip(btn, kv.Value.CameraName);
                    intCol++;
                    if (intCol >= intChannelButtonColumn)
                    {
                        intCol = 0;
                        intRow++;
                    }
                }
            }

            bolChannelButtonLoadEnd = true;
        }

        public bool RefreshChannelButton()
        {
            bool bolResult = false;
            int intCol = 0;
            int intRow = 0;
            CalculationToButonSize();
            foreach (Button btn in lstbtns)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "_" + btn.Text);
                btn.Location = new Point(intbtnStartX + (intChannelButtonWidth * intCol), intbtnStartY + (intChannelButtonHeight * intRow));
                btn.Size = new Size(intChannelButtonWidth, intChannelButtonHeight);
                intCol++;
                if (intCol >= intChannelButtonColumn)
                {
                    intCol = 0;
                    intRow++;

                }
            }
            return bolResult;
        }
        public void CalculationToButonSize()
        {
            int Temp_intRowCount = CurrentVideoInfo.Cameras.Count / intChannelButtonColumn;
            if (CurrentVideoInfo.Cameras.Count % intChannelButtonColumn != 0)
            {
                //存在余数 
                Temp_intRowCount++;
            }
            #region 宽度
            if ((!bolAutoSetBtnSize)&&(Temp_intRowCount * intChannelButtonHeight) > pnlMain.Height)
            {
                //预留滚动条
                intChannelButtonWidth = (this.pnlMain.Width - 21) / intChannelButtonColumn;
            }
            else
            {
                intChannelButtonWidth = (this.pnlMain.Width - 1) / intChannelButtonColumn;
            }
            #endregion

            #region 高度
            if (bolAutoSetBtnSize)
            {
                //自动设置高度
                intChannelButtonHeight = (this.pnlMain.Height / Temp_intRowCount - 1);
            }

            #endregion

        }

        /// <summary>
        /// 按钮事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCameraInfo_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CameraInfo camerInfo = (CameraInfo)btn.Tag;
            ButtonChannel_Click(btn);
        }

        private void VideoChannelList_SizeChanged(object sender, EventArgs e)
        {
            if (bolChannelButtonLoadEnd)
            {
                //加载完成后才进行触发
                RefreshChannelButton();
            }
        }
    }
}
