using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point temp = new Point(label1.Location.X, label1.Location.Y);

            label1.Location = label4.Location;
            label4.Location = label3.Location;
            label3.Location = label2.Location;
            label2.Location = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point temp = new Point(label1.Location.X, label1.Location.Y);

            label1.Location = label2.Location;
            label2.Location = label3.Location;
            label3.Location = label4.Location;
            label4.Location = temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, 2);

            if (num == 0)
            {
                Point temp = new Point(label1.Location.X, label1.Location.Y);

                label1.Location = label4.Location;
                label4.Location = label3.Location;
                label3.Location = label2.Location;
                label2.Location = temp;
            }
            else
            {
                Point temp = new Point(label1.Location.X, label1.Location.Y);

                label1.Location = label2.Location;
                label2.Location = label3.Location;
                label3.Location = label4.Location;
                label4.Location = temp;
            }
        }
    }
}
