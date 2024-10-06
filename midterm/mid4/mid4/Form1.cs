using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid4
{
    public partial class Form1 : Form
    {
        public int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter < 30)
            {
                label3.ForeColor = Color.Green;
            }

            if (counter >= 30 && counter < 35)
            {
                label3.ForeColor = Color.Black;
            }

            if (counter >= 35 && counter < 40)
            {
                label3.ForeColor = Color.Green;
            }

            if (counter >= 40 && counter < 45)
            {
                label3.ForeColor = Color.Black;
            }

            if (counter >= 45 && counter < 50)
            {
                label3.ForeColor = Color.Green;
            }

            if (counter >= 50 && counter < 55)
            {
                label3.ForeColor = Color.Black;
            }

            if (counter >= 55 && counter < 60)
            {
                label3.ForeColor = Color.Green;
            }

            if (counter >= 60)
            {
                label3.ForeColor = Color.Black;
                label2.ForeColor = Color.Yellow;
            }

            if (counter >= 70)
            {
                label2.ForeColor = Color.Black;
                label1.ForeColor = Color.Red;
            }

            if (counter >= 100)
            {
                label1.ForeColor = Color.Black;
            }

            if (counter >= 105 && counter < 110)
            {
                label1.ForeColor = Color.Red;
            }

            if (counter >= 110 && counter < 115)
            {
                label1.ForeColor = Color.Black;
            }

            if (counter >= 115 && counter < 120)
            {
                label1.ForeColor = Color.Red;
            }

            if (counter >= 120 && counter < 125)
            {
                label1.ForeColor = Color.Black;
            }

            if (counter >= 125 && counter < 130)
            {
                label1.ForeColor = Color.Red;
            }

            if (counter >= 130)
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Yellow;
            }

            if (counter >= 140)
            {
                label2.ForeColor = Color.Black;
                counter = 0;
            }
        }
    }
}
