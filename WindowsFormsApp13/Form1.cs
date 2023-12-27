using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kurs;
            DateTime date;
            date = dateTimePicker1.Value;
            kurs = System.Convert.ToDouble(textBox1.Text);
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.StartupPath + "\\usd.txt");
            System.IO.StreamWriter sw;
            if (fi.Exists) { sw = fi.AppendText(); }
            else sw = fi.CreateText();
            sw.WriteLine(date.ToShortDateString());
            sw.WriteLine(kurs.ToString("N"));
            sw.Close();
            button1.Enabled = false;
            textBox1.Enabled = false;

        }
    }
}
