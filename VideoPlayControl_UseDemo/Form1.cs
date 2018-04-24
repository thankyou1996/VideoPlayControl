using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl_UseDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine("checkBox1_CheckedChanged_" + checkBox1.Checked.ToString());
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("checkBox1_Click_" + checkBox1.Checked.ToString());
        }
    }
}
