using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marquee
{
    public partial class Form1 : Form
    {
        public int x, y, dir = 0, big = 1;

        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox3;
            label1.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "現在時間";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval--;
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval++;
            }
            catch
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = false;
            label1.Text = "現在時間";
            label1.Location = new Point(6, 3);
            label1.ForeColor = Color.FromArgb(0, 0, 0);
            label1.Font = new Font(label1.Font.FontFamily, 18);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (radioButton1.Checked == true)
            {
                if (dir != 1 && dir != 3)
                {
                    dir = 1;
                }

                if (dir == 1)
                {
                    x = 5;
                }
                else
                {
                    x = -5;
                }

                if (label1.Location.X + x > 456 || label1.Location.X + x < 0)
                {
                    dir += 2;
                }
                else
                {
                    label1.Location = new Point(label1.Location.X + x, label1.Location.Y);
                }
            }
            else if (radioButton2.Checked == true)
            {
                if (dir != 0 && dir != 2)
                {
                    dir = 0;
                }

                if (dir == 0)
                {
                    y = -5;
                }
                else
                {
                    y = 5;
                }

                if (label1.Location.Y + y > 290 || label1.Location.Y + y < 0)
                {
                    dir += 2;
                }
                else
                {
                    label1.Location = new Point(label1.Location.X, label1.Location.Y + y);
                }
            }
            else if (radioButton3.Checked == true)
            {
                if (dir > 3)
                {
                    dir = 0;
                }

                if (dir == 0)
                {
                    x = 0;
                    y = -5;
                }
                else if (dir == 1)
                {
                    x = 5;
                    y = 0;
                }
                else if (dir == 2)
                {
                    x = 0;
                    y = 5;
                }
                else
                {
                    x = -5;
                    y = 0;
                }

                if (label1.Location.X + x > 456 || label1.Location.X + x < 0 || label1.Location.Y + y > 290 || label1.Location.Y + y < 0)
                {
                    dir++;
                }
                else
                {
                    label1.Location = new Point(label1.Location.X + x, label1.Location.Y + y);
                }
            }
            else if (radioButton4.Checked == true)
            {
                x = rand.Next(0, 679 - label1.Size.Width);
                y = rand.Next(0, 315 - label1.Size.Height);
                label1.Location = new Point(x, y);
            }
            else if (radioButton5.Checked == true)
            {
                if (x != 5 && x != -5)
                {
                    x = 5;
                }

                if (y != 5 && y != -5)
                {
                    y = -5;
                }

                if (label1.Location.X + x > 456 || label1.Location.X + x < 0)
                {
                    x *= -1;
                }

                if (label1.Location.Y + y > 290 || label1.Location.Y + y < 0)
                {
                    y *= -1;
                }

                label1.Location = new Point(label1.Location.X + x, label1.Location.Y + y);
            }

            if (checkBox1.Checked == true)
            {
                if (big == 1)
                {
                    label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size + 1);
                }
                else
                {
                    label1.Font = new Font(label1.Font.FontFamily, label1.Font.Size - 1);
                }

                if (label1.Font.Size >= 27)
                {
                    big = 0;
                }

                if (label1.Font.Size <= 9)
                {
                    big = 1;
                }
            }

            if (checkBox2.Checked == true)
            {
                label1.ForeColor = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            }

            label1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
