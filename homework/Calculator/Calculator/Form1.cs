using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public double ans = 0;
        public double temp = 0;
        public bool pressed = false;
        public bool positive = true;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "C" || button.Text == "CE")
            {
                pressed = true;
                positive = true;
                label1.Text = "0";
                label1.Location = new Point(297, label1.Location.Y);

                if (button.Text == "C")
                {
                    temp = 0;
                    pressed = false;
                    label2.Text = "0 +";
                    label2.Location = new Point(310, label2.Location.Y);
                }
            }
            else if (button.Text == "⌫")
            {
                if (pressed == true)
                {
                    if (label1.Text.Length > 1)
                    {
                        if (label1.Text.Substring(label1.Text.Length - 1) == ".")
                        {
                            label1.Location = new Point(label1.Location.X + 14, label1.Location.Y);
                        }
                        else
                        {
                            label1.Location = new Point(label1.Location.X + 28, label1.Location.Y);
                        }

                        label1.Text = label1.Text.Remove(label1.Text.Length - 1);

                        if (label1.Text.Length == 1 && label1.Text.Substring(0, 1) == "-")
                        {
                            pressed = true;
                            positive = true;
                            label1.Text = "0";
                            label1.Location = new Point(297, label1.Location.Y);
                        }
                    }
                    else
                    {
                        pressed = true;
                        label1.Text = "0";
                    }
                }
            }
            else if (button.Text == "＋" || button.Text == "－" || button.Text == "×" || button.Text == "÷" || button.Text == "=")
            {
                if (pressed == false)
                {

                }
                else if (label2.Text.Substring(label2.Text.Length - 1) == "+")
                {
                    temp += ans;
                }
                else if (label2.Text.Substring(label2.Text.Length - 1) == "-")
                {
                    temp -= ans;
                }
                else if ((label2.Text.Substring(label2.Text.Length - 1) == "*"))
                {
                    temp *= ans;
                }
                else if ((label2.Text.Substring(label2.Text.Length - 1) == "/"))
                {
                    temp /= ans;
                }
                else
                {
                    temp = ans;
                }

                pressed = false;
                positive = true;
                label1.Text = "0";
                label1.Location = new Point(297, label1.Location.Y);

                for (int i = 0; i < temp.ToString().Length; i++)
                {
                    if (label1.Text == "0")
                    {
                        label1.Text = temp.ToString().Substring(i, 1);
                    }
                    else
                    {
                        label1.Text += temp.ToString().Substring(i, 1);

                        if (temp.ToString().Substring(i, 1) == ".")
                        {
                            label1.Location = new Point(label1.Location.X - 14, label1.Location.Y);
                        }
                        else if (temp.ToString().Substring(i, 1) == "E")
                        {
                            label1.Location = new Point(label1.Location.X - 38, label1.Location.Y);
                        }
                        else
                        {
                            label1.Location = new Point(label1.Location.X - 28, label1.Location.Y);
                        }
                    }
                }

                if (label1.Text.Substring(0, 1) == ".")
                {
                    label1.Text = "0" + label1.Text;
                    label1.Location = new Point(label1.Location.X - 14, label1.Location.Y);
                }
                else if (label1.Text.Substring(0, 1) == "-")
                {
                    label1.Location = new Point(label1.Location.X + 9, label1.Location.Y);

                    if (label1.Text.Substring(label1.Text.Length - 1) == "∞")
                    {
                        label1.Location = new Point(label1.Location.X - 32, label1.Location.Y);
                    }
                }
                else if (label1.Text.Substring(0, 1) == "∞")
                {
                    label1.Location = new Point(label1.Location.X - 32, label1.Location.Y);
                }
                else if (label1.Text.Substring(0, 1) == "非")
                {
                    label1.Location = new Point(label1.Location.X - 96, label1.Location.Y);
                }

                label2.Text = "0";
                label2.Location = new Point(310, label2.Location.Y);

                for (int i = 0; i < temp.ToString().Length; i++)
                {
                    if (label2.Text == "0")
                    {
                        label2.Text = temp.ToString().Substring(i, 1);
                    }
                    else
                    {
                        label2.Text += temp.ToString().Substring(i, 1);

                        if (temp.ToString().Substring(i, 1) == ".")
                        {
                            label2.Location = new Point(label2.Location.X - 6, label2.Location.Y);
                        }
                        else if (temp.ToString().Substring(i, 1) == "E")
                        {
                            label2.Location = new Point(label2.Location.X - 16, label2.Location.Y);
                        }
                        else
                        {
                            label2.Location = new Point(label2.Location.X - 11, label2.Location.Y);
                        }
                    }
                }

                if (label2.Text.Substring(0, 1) == ".")
                {
                    label2.Text = "0" + label2.Text;
                    label2.Location = new Point(label2.Location.X - 11, label2.Location.Y);
                }
                else if (label2.Text.Substring(0, 1) == "-")
                {
                    label2.Location = new Point(label2.Location.X + 3, label2.Location.Y);

                    if (label2.Text.Substring(label2.Text.Length - 1) == "∞")
                    {
                        label2.Location = new Point(label2.Location.X - 13, label2.Location.Y);
                    }
                }
                else if (label2.Text.Substring(0, 1) == "∞")
                {
                    label2.Location = new Point(label2.Location.X - 13, label2.Location.Y);
                }
                else if (label2.Text.Substring(0, 1) == "非")
                {
                    label2.Location = new Point(label2.Location.X - 39, label2.Location.Y);
                }

                if (button.Text == "＋")
                {
                    label2.Text += " +";
                }
                else if (button.Text == "－")
                {
                    label2.Text += " -";
                }
                else if (button.Text == "×")
                {
                    label2.Text += " *";
                }
                else if (button.Text == "÷")
                {
                    label2.Text += " /";
                }
                else
                {
                    label2.Text += " =";
                }
            }
            else if (button.Text == "＋/－")
            {
                if (label1.Text != "0" && label1.Text != "0." && pressed == true)
                {
                    if (positive == true)
                    {
                        label1.Text = "-" + label1.Text;
                        label1.Location = new Point(label1.Location.X - 19, label1.Location.Y);
                        positive = false;
                    }
                    else
                    {
                        label1.Text = label1.Text.Remove(0, 1);
                        label1.Location = new Point(label1.Location.X + 19, label1.Location.Y);
                        positive = true;
                    }
                }
            }
            else if (button.Text == ".")
            {
                if (pressed == false)
                {
                    label1.Text = "0.";
                    label1.Location = new Point(283, label1.Location.Y);
                    pressed = true;
                }
                else if (label1.Text.IndexOf(".") == -1)
                {
                    label1.Text = label1.Text + ".";
                    label1.Location = new Point(label1.Location.X - 14, label1.Location.Y);
                }
            }
            else
            {
                if (pressed == false)
                {
                    label1.Text = button.Text;
                    label1.Location = new Point(297, label1.Location.Y);
                    pressed = true;
                }
                else
                {
                    if (label1.Text == "0")
                    {
                        label1.Text = button.Text;
                    }
                    else
                    {
                        label1.Text = label1.Text + button.Text;
                        label1.Location = new Point(label1.Location.X - 28, label1.Location.Y);
                    }
                }
            }

            if (label1.Text.Substring(0, 1) != "非")
            {
                ans = double.Parse(label1.Text);
            }

            if (label2.Text.Substring(label2.Text.Length - 1) == "=" && pressed == true)
            {
                temp = 0;
                label2.Text = "0 +";
                label2.Location = new Point(310, label2.Location.Y);
            }
        }
    }
}
