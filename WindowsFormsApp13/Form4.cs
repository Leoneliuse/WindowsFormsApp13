using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp13
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr;
            sr = new System.IO.StreamReader(Application.StartupPath + "\\banner.txt", System.Text.Encoding.GetEncoding(1251));
            string st1;
            st1 = sr.ReadLine();
            listBox1.Items.Add (st1);
        }
    }
}
