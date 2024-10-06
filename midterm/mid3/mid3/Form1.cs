using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mid3
{
    public partial class Form1 : Form
    {
        public int A = 0, a = 0, o = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A = 0;
            a = 0;
            o = 0;

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] >= 65 && textBox1.Text[i] <= 90)
                {
                    A++;
                }

                else if (textBox1.Text[i] >= 97 && textBox1.Text[i] <= 122)
                {
                    a++;
                }

                else if (textBox1.Text[i] >= 48 && textBox1.Text[i] <= 57)
                {
                    o++;
                }
            }

            if (textBox1.Text.Length >= 6 && A > 0 && a > 0 && o > 0)
            {
                MessageBox.Show("密碼通過");
            }
            else
            {
                MessageBox.Show("密碼強度不足");
            }
        }
    }
}
