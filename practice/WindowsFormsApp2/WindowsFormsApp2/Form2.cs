using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private Form Form1;

        public Form2(Form Form1)
        {
            InitializeComponent();
            this.Form1 = Form1;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.Show();
        }
    }
}
