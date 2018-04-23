using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void skinnedStandardButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            skinnedStandardButton1.UseSkins = checkBox1.Checked;
        }
    }
}