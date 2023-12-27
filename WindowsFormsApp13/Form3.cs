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
    public partial class Form3 : Form
    {
        Graphics g;
        Bitmap baner;
        Rectangle rct;
        public Form3()
        {
            InitializeComponent();
            try { baner = new Bitmap("banner.png"); }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка загрузки файла баннера\n" + exception.ToString(), "Баннер");
                this.Close();
                return;
            }
            g = this.CreateGraphics();
            rct.X = 0; rct.Y = 0; rct.Width = baner.Width; rct.Height = baner.Height;
            timer1.Interval = 50;
            timer1.Enabled = true;

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            rct.X -= 1;
            if (Math.Abs(rct.X) > rct.Width) rct.X += rct.Width;
            for (int i = 0; i <= Convert.ToInt16(this.ClientSize.Width/rct.Width) + 1; i++) { g.DrawImage(baner, rct.X + i * rct.Width, rct.Y); }

        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Y < rct.Y + rct.Height) && (e.Y > rct.Y))
            {
                if (timer1.Enabled != false)
                    timer1.Enabled = false;
            }
            else
            {   if (timer1.Enabled != true)
                    timer1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f5 = new Form4();
            f5.Show();
        }
    }
}
