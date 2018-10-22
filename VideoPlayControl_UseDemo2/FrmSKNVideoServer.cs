using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo2
{
    public partial class FrmSKNVideoServer : Form
    {
        public FrmSKNVideoServer()
        {
            InitializeComponent();
        }

        private void FrmSKNVideoServer_Load(object sender, EventArgs e)
        {
            VideoPlayControl.SDKInterface.SDK_SKNVideo.SDK_NSK_SERVER_init(48624, "", "C:\\SHIKE_Video_Server");
        }
    }
}
