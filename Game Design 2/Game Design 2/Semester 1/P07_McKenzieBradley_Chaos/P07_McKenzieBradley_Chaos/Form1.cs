using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace P07_McKenzieBradley_Chaos
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        OvalShape[] shapes = new OvalShape[10];
        int[] speed = new int[10];
        int score;
        

        public Form1()
        {
            InitializeComponent();

            shapes[0] = shp0;
            shapes[1] = shp1;
            shapes[2] = shp2;
            shapes[3] = shp3;
            shapes[4] = shp4;
            shapes[5] = shp5;
            shapes[6] = shp6;
            shapes[7] = shp7;
            shapes[8] = shp8;
            shapes[9] = shp9;

            

            for (int i = 0; i < 10; i++)
            {
                shapes[i].Top = -(this.Width * r.Next(3));
                speed[i] = r.Next(3) + 2;
            }
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                shapes[i].Top += speed[i];

                if (shapes[i].Top > this.Height)
                {
                    shapes[i].Top = -50;
                    speed[i] = r.Next(3) + 2;
                }
            }
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrGo.Enabled = true;
            tmrTimer.Enabled = true;

            for (int i = 0; i < 10; i++)
            {
                shapes[i].Visible = true;
                pbrPlay.Value = 100;
            }
            
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrGo.Enabled = false;
            tmrTimer.Enabled = false;
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                shapes[i].Top = -50;
            }
           score = 0;
           lblScore.Text = score.ToString();
           pbrPlay.Value = 100;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            if (pbrPlay.Value > 1)
            {
                 pbrPlay.Value -= 1;
            }
            else
            {
                tmrGo.Enabled = false;
                tmrTimer.Enabled = false;

            }
        }

       private void hit(int i)
        {
           score += 1;
           lblScore.Text = score.ToString();
           shapes[i].Top = -(this.Width * r.Next(3));
           speed[i] = r.Next(3) + 2;
           
        }
        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.BackColor = Color.Pink;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.BackColor = Color.Gray;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void shp0_MouseEnter(object sender, EventArgs e)
        {
            hit(0);
        }

        private void shp1_MouseEnter(object sender, EventArgs e)
        {
            hit(1);
        }

        private void shp2_MouseEnter(object sender, EventArgs e)
        {
            hit(2);
        }

        private void shp3_MouseEnter(object sender, EventArgs e)
        {
            hit(3);
        }

        private void shp4_MouseEnter(object sender, EventArgs e)
        {
            hit(4);
        }

        private void shp5_MouseEnter(object sender, EventArgs e)
        {
            hit(5);
        }

        private void shp6_MouseEnter(object sender, EventArgs e)
        {
            hit(6);
        }

        private void shp7_MouseEnter(object sender, EventArgs e)
        {
            hit(7);
        }

        private void shp8_MouseEnter(object sender, EventArgs e)
        {
            hit(8);
        }

        private void shp9_MouseEnter(object sender, EventArgs e)
        {
            hit(9);
        }
    }
  }
