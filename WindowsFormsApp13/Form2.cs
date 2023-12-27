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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr;
            try
            {
                sr = new System.IO.StreamReader(Application.StartupPath + "\\usd.txt",System.Text.Encoding.GetEncoding(1251));
                DateTime dateStart = monthCalendar1.SelectionStart;
                DateTime dateEnd = monthCalendar1.SelectionEnd;
                string st1, st2 = "";
                DateTime date;
                listBox1.Items.Clear();
                while(!sr.EndOfStream) 
                {
                    st1 = sr.ReadLine();
                    date = System.Convert.ToDateTime(st1);
                    st2 = sr.ReadLine();
                    if ((date >= dateStart) && (date <= dateEnd)) { listBox1.Items.Add(st1 + " " + st2); }
                }
                sr.Close();
                if (listBox1.Items.Count == 0) { listBox1.Items.Add("---НЕТ ДАННЫХ!---"); }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Ошибка к доступу файла даннх\n"+exc.ToString(),"Котировки",MessageBoxButtons.OK,MessageBoxIcon.Error);
                button1.Enabled = false;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();
        }
    }
}
