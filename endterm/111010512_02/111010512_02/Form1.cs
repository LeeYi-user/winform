using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111010512_02
{
    public partial class Form1 : Form
    {
        public int price, total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Braised Pork on Rice")
            {
                price = 40;
            }
            else if (comboBox1.Text == "Oyster Omelette")
            {
                price = 50;
            }
            else if (comboBox1.Text == "Taiwanese Meatballs")
            {
                price = 45;
            }
            else if (comboBox1.Text == "Spring Rolls")
            {
                price = 55;
            }
            else if (comboBox1.Text == "Deep-fried Sandwich")
            {
                price = 30;
            }
            else
            {
                return;
            }

            total += price;
            label1.Text = "Total: " + total.ToString();
            listBox1.Items.Add(comboBox1.Text + " (" + price.ToString() + ")");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                price = int.Parse(listBox1.Items[listBox1.SelectedIndex].ToString().Substring(listBox1.Items[listBox1.SelectedIndex].ToString().Length - 3, 2));
                total -= price;
                label1.Text = "Total: " + total.ToString();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                pictureBox1.Image = null;
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total = 0;
            label1.Text = "Total: 0";
            listBox1.Items.Clear();
            pictureBox1.Image = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("image/" + comboBox1.Items[comboBox1.SelectedIndex].ToString() + ".jpg");
            pictureBox1.Image = bitmap;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Bitmap bitmap = new Bitmap("image/" + listBox1.Items[listBox1.SelectedIndex].ToString().Substring(0, listBox1.Items[listBox1.SelectedIndex].ToString().Length - 5) + ".jpg");
                pictureBox1.Image = bitmap;
            }
            catch
            {

            }
        }
    }
}
