using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P16_McKenzieBradley_Snakes
{
    public partial class Form1 : Form
    {
        PictureBox[] snake = new PictureBox[12];
        int body;
        int score; 
        int xFood;
        int yFood;
        int[] xLoc = new int[11];
        int[] yLoc = new int[11];
        bool play = false;
    
        public Form1()
        {
            InitializeComponent();

            snake[0] = pic0;
            snake[1] = pic1;
            snake[2] = pic2;
            snake[3] = pic3;
            snake[4] = pic4;
            snake[5] = pic5;
            snake[6] = pic6;
            snake[7] = pic7;
            snake[8] = pic8;
            snake[9] = pic9;
            snake[10] = pic10;
            snake[11] = pic11;
            body = 1;
            score = 0;
            lblScore.Text = score.ToString();

            for (int i = 0; i < 11; i++)
            {
                xLoc[i] = snake[i].Left;
                yLoc[i] = snake[i].Top;
            }
            xFood = picFood.Left;
            yFood = picFood.Top;
            getBody();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            move("LEFT");
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            move("RIGHT");
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            move("UP");
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            move("DOWN");
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = true;
                tmrRight.Enabled = false;
                tmrUp.Enabled = false;
                tmrDown.Enabled = false;
                pic0.Image = picHeadLeft.Image;
                chkBoundry();
            }
            if (e.KeyValue == 38)
            {
                tmrLeft.Enabled = false;
                tmrRight.Enabled = false;
                tmrUp.Enabled = true;
                tmrDown.Enabled = false;
                pic0.Image = picHeadUp.Image;
                chkBoundry();
            }
            if (e.KeyValue == 39)
            {
                tmrLeft.Enabled = false;
                tmrRight.Enabled = true;
                tmrUp.Enabled = false;
                tmrDown.Enabled = false;
                pic0.Image = picHeadRight.Image;
                chkBoundry();
            }
            if (e.KeyValue == 40)
            {
                tmrLeft.Enabled = false;
                tmrRight.Enabled = false;
                tmrUp.Enabled = false;
                tmrDown.Enabled = true;
                pic0.Image = picHeadDown.Image;
                chkBoundry();
            }
            if (e.KeyValue == 32)
            {
                reset();
            }
        }

        private void reset()
        {
            play = true;
            body = 1;
            lblBegin.Visible = false;
            lblBegin.Text = "Press Space Bar to Begin...";
            score = 0;
            lblScore.Text = score.ToString();

            for (int i = 0; i < 11; i++)
            {
                snake[i].Left = xLoc[i];
                snake[i].Top = yLoc[i];
            }
            picFood.Left = xFood;
            picFood.Top = yFood;
            lblBegin.Visible = false;
            snake[0].Image = picHeadUp.Image;
            snake[2].Image = picTailDown.Image;
            getBody();
        }

        private void move(string dir)
        {
            for (int i = 11; i > 0; i--)
            {
                snake[i].Location = snake[i - 1].Location;
            }

            if (dir.Equals("UP"))
            {
                snake[0].Top -= 50;
            }
            else if (dir.Equals("DOWN"))
            {
                snake[0].Top += 50;
            }
            else if (dir.Equals("LEFT"))
            {
                snake[0].Left -= 50;
            }
            else if (dir.Equals("RIGHT"))
            {
                snake[0].Left += 50;
            }

            if (snake[body - 1].Left > snake[body].Left)
            {
                snake[body].Image = picTailRight.Image;
            }
            else if (snake[body - 1].Left < snake[body].Left)
            {
                snake[body].Image = picTailLeft.Image;
            }
            else if (snake[body - 1].Top > snake[body].Top)
            {
                snake[body].Image = picTailUp.Image;
            }
            else if (snake[body - 1].Top < snake[body].Top)
            {
                snake[body].Image = picTailDown.Image;
            }
            chkFood();
            chkBoundry();
        }

        private void chkFood()
        {
            Random r = new Random();
            if (snake[0].Bounds.IntersectsWith(picFood.Bounds))
            {
                int x = r.Next(12);
                int y = r.Next(10);
                picFood.Left = x * 50;
                picFood.Top = y * 50;
                getBody();
                score += 1000;
                lblScore.Text = score.ToString();
            }
        }

        private void chkBoundry()
        {
            if (snake[0].Left < 0|| snake[0].Left > 715 || snake[0].Top < 50 || snake[0].Top > 737)
            {
                play = false;
                tmrLeft.Enabled = false;
                tmrRight.Enabled = false;
                tmrUp.Enabled = false;
                tmrDown.Enabled = false;
            }
        }

        private void getBody()
        {
            snake[body].Image = picBody.Image;
            body += 1;

            if (body > 11)
            {
                lblBegin.Text = "Congratulations!";
                lblBegin.Visible = true;
                body -= 1;
                play = false;
                tmrLeft.Enabled = false;
                tmrRight.Enabled = false;
                tmrUp.Enabled = false;
                tmrDown.Enabled = false;
            }
            else
            {
                for (int i = 0; i <= 11; i++)
                {
                    if (i <= body)
                        snake[i].Visible = true;
                    else
                        snake[i].Visible = false;
                }
                snake[body].Image = picTailDown.Image;
            }
        }
    }
}
