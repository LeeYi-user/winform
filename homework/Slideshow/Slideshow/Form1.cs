using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slideshow
{
    public partial class Form1 : Form
    {
        public int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(ofd.FileName);

                if (timer1.Enabled == false)
                {
                    listBox1.SetSelected(listBox1.Items.Count - 1, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                try
                {
                    int number = listBox1.SelectedIndex;
                    listBox1.Items.RemoveAt(number);

                    try
                    {
                        listBox1.SetSelected(number, true);
                    }
                    catch
                    {
                        try
                        {
                            listBox1.SetSelected(number - 1, true);
                        }
                        catch
                        {

                        }
                    }
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Please stop first");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                listBox1.Items.Clear();
                pictureBox1.Image = null;
            }
            else
            {
                MessageBox.Show("Please stop first");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            index = listBox1.SelectedIndex;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (radioButton1.Checked == true)
                {
                    index++;

                    if (index >= listBox1.Items.Count)
                    {
                        index = 0;
                    }
                }
                else
                {
                    Random random = new Random();
                    index = random.Next(listBox1.Items.Count);
                }

                listBox1.SetSelected(index, true);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                pictureBox1.Image = null;
            }
            else
            {
                Bitmap bitmap = new Bitmap(listBox1.Items[listBox1.SelectedIndex].ToString());
                pictureBox1.Image = bitmap;
            }
        }
    }
}
