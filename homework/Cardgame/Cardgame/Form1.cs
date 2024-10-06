using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cardgame
{
    public partial class Form1 : Form
    {
        public int score, timeleft, count, card_num;
        public int[] cards = new int[10];
        public PictureBox card_obj;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap("Images/card.png");
            pictureBox1.Image = bitmap;
            pictureBox2.Image = bitmap;
            pictureBox3.Image = bitmap;
            pictureBox4.Image = bitmap;
            pictureBox5.Image = bitmap;
            pictureBox6.Image = bitmap;
            pictureBox7.Image = bitmap;
            pictureBox8.Image = bitmap;
            pictureBox9.Image = bitmap;
            pictureBox10.Image = bitmap;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;

            if (timer1.Enabled == false)
            {
                score = 0;
                timeleft = 30;
                count = 0;
                button1.Text = "RESET";
                label1.Text = "Score: 0";
                label2.Text = "Time left: 30";
                timer1.Enabled = true;

                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                    cards[i] = (i + 2) / 2;
                }

                for (int i = 0; i < 10; i++)
                {
                    int temp = cards[i], number = random.Next(10);
                    cards[i] = cards[number];
                    cards[number] = temp;
                }
            }
            else
            {
                button1.Text = "PLAY";
                label1.Text = "Score: ";
                label2.Text = "Time left: ";
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft -= 1;
            label2.Text = "Time left: " + timeleft.ToString();

            if (timeleft == 0)
            {
                button1.Text = "AGAIN";
                timer1.Enabled = false;
                MessageBox.Show("You Lose");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                PictureBox pictureBox = sender as PictureBox;
                int number = cards[int.Parse(pictureBox.Name.Substring(10)) - 1];

                if (number == 1)
                {
                    Bitmap bitmap = new Bitmap("Images/antelope.jpg");
                    pictureBox.Image = bitmap;
                }
                else if (number == 2)
                {
                    Bitmap bitmap = new Bitmap("Images/cow.jpg");
                    pictureBox.Image = bitmap;
                }
                else if (number == 3)
                {
                    Bitmap bitmap = new Bitmap("Images/goat.jpg");
                    pictureBox.Image = bitmap;
                }
                else if (number == 4)
                {
                    Bitmap bitmap = new Bitmap("Images/pig.jpg");
                    pictureBox.Image = bitmap;
                }
                else
                {
                    Bitmap bitmap = new Bitmap("Images/tiger.jpg");
                    pictureBox.Image = bitmap;
                }

                count++;

                if (count == 1)
                {
                    card_num = number;
                    card_obj = pictureBox;
                }
                else
                {
                    if (card_num == number)
                    {
                        score += 20;
                        label1.Text = "Score: " + score.ToString();
                        card_obj.Enabled = false;
                        pictureBox.Enabled = false;

                        if (score == 100)
                        {
                            button1.Text = "AGAIN";
                            timer1.Enabled = false;
                            MessageBox.Show("You Win");
                        }
                    }
                    else
                    {
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(500);

                        Bitmap bitmap = new Bitmap("Images/card.png");
                        card_obj.Image = bitmap;
                        pictureBox.Image = bitmap;
                    }

                    count = 0;
                }
            }
        }
    }
}
