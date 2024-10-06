using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111010512_01
{
    public partial class Form1 : Form
    {
        public int dir, frame = 1;
        public string link;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name.Substring(6) == "1")
            {
                dir = 1;
            }
            else if (button.Name.Substring(6) == "2")
            {
                dir = 2;
            }
            else if (button.Name.Substring(6) == "3")
            {
                dir = 3;
            }
            else
            {
                dir = 4;
            }

            timer1.Enabled = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            timer1.Enabled = false;

            Bitmap bitmap = new Bitmap("image/stop.png");
            pictureBox1.Image = bitmap;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dir == 1)
            {
                link = "image/character_walking/right0";
            }
            else if (dir == 2)
            {
                link = "image/character_walking/down0";
            }
            else if (dir == 3)
            {
                link = "image/character_walking/left0";
            }
            else
            {
                link = "image/character_walking/up0";
            }

            Bitmap bitmap = new Bitmap(link + frame.ToString() + ".gif");
            pictureBox2.Image = bitmap;

            bitmap = new Bitmap("image/happy_0" + frame.ToString() + ".png");
            pictureBox1.Image = bitmap;

            if (frame == 4)
            {
                frame = 1;
            }
            else
            {
                frame++;
            }
        }
    }
}
