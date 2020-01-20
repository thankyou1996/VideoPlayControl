using PublicClassCurrency;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo.ControlTest
{
    public partial class Frm_VideoPlayWindowPTZ_Test : Form
    {
        public Frm_VideoPlayWindowPTZ_Test()
        {
            InitializeComponent();
        }

        private void Frm_VideoPlayWindowPTZ_Test_Load(object sender, EventArgs e)
        {
            VideoInfo vInfo = TestDataSource.SKDataSource.GetSKData1();
            videoPlayWindow_PTZ1.Init_VideoInfo(vInfo);
        }
    }
}
