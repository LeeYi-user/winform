using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111010512_03
{
    public partial class Form1 : Form
    {
        public Form form;
        public Point point;
        public string format = null;
        
        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                button1.Text = "SAVE";
            }
            else
            {
                panel1.Visible = false;
                button1.Text = "SETTING";
            }
        }

        private void labels_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - point.X;
                form.Top += e.Y - point.Y;
            }
        }

        private void labels_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            format = null;

            if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true)
            {
                label2.Visible = true;

                if (checkBox1.Checked == true)
                {
                    format += "yyyy";

                    if (checkBox2.Checked == true || (checkBox2.Checked == false && checkBox3.Checked == true))
                    {
                        format += "/";
                    }
                }

                if (checkBox2.Checked == true)
                {
                    format += "MM";

                    if (checkBox3.Checked == true)
                    {
                        format += "/";
                    }
                }

                if (checkBox3.Checked == true)
                {
                    format += "dd";
                }

                label2.Text = dateTime.ToString(format);
            }
            else
            {
                label2.Visible = false;
            }

            format = null;

            if (checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                label1.Visible = true;

                if (checkBox4.Checked == true)
                {
                    format += "HH";

                    if (checkBox5.Checked == true || (checkBox5.Checked == false && checkBox6.Checked == true))
                    {
                        format += ":";
                    }
                }

                if (checkBox5.Checked == true)
                {
                    format += "mm";

                    if (checkBox6.Checked == true)
                    {
                        format += ":";
                    }
                }

                if (checkBox6.Checked == true)
                {
                    format += "ss";
                }

                label1.Text = dateTime.ToString(format);
            }
            else
            {
                label1.Visible = false;
            }

            if (radioButton1.Checked == true)
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
            }
            else if (radioButton2.Checked == true)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
            }
            else if (radioButton3.Checked == true)
            {
                label1.ForeColor = Color.Red;
                label2.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
                label2.ForeColor = Color.Blue;
            }
        }
    }
}
