using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int num = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point temp = new Point(label2.Location.X, label2.Location.Y);

            label2.Location = label1.Location;
            label1.Location = label3.Location;
            label3.Location = temp;

            num++;
            label4.Text = num.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point temp = new Point(label2.Location.X, label2.Location.Y);

            label2.Location = label3.Location;
            label3.Location = label1.Location;
            label1.Location = temp;

            num--;
            label4.Text = num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
