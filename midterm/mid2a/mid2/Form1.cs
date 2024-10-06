using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid2
{
    public partial class Form1 : Form
    {
        double x, y;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x = double.Parse(textBox1.Text);
                y = double.Parse(textBox2.Text) * Math.Pow(x, 10) - double.Parse(textBox3.Text) * Math.Pow(x, 5) + double.Parse(textBox4.Text) * x;

                MessageBox.Show(y.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
