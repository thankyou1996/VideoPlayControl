using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class Frm_VideoRecordListTest : Form
    {
        public Frm_VideoRecordListTest()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //string strTempFilePath = "C:\\SHIKE_Video\\0002\\20170808172630";
            string strTempFilePath = @"C:\SHIKE_Video\0006\20181108113346";

            videoRecordList1.Init_SetCurrentFolderPath(strTempFilePath);
            videoRecordList1.ButtonVideoRecord_ClickEvent -= Test;
            videoRecordList1.ButtonVideoRecord_ClickEvent += Test;
        }

        public void Test(object sender)
        {
            Button btn = (Button)sender;
            string str = btn.Tag.ToString();
            MessageBox.Show(str);
        }
    }
}
