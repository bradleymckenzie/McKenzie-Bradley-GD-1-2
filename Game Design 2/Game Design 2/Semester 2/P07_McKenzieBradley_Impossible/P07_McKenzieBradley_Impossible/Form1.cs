using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07_McKenzieBradley_Impossible
{
    public partial class Form1 : Form
    {
        Label[] wall = new Label[8];
        Label[] orange = new Label[10];
        Label[] green = new Label[8];
        Label[] purple = new Label[5];
        bool[] orangeDir = new bool[10];
        bool[] purpleDir = new bool[5];

        public Form1()
        {
            InitializeComponent();

            wall[0] = lbl0;
            wall[1] = lbl1;
            wall[2] = lbl2;
            wall[3] = lbl3;
            wall[4] = lbl4;
            wall[5] = lbl5;
            wall[6] = lbl6;
            wall[7] = lbl7;

            orange[0] = lblOrange0;
            orange[1] = lblOrange1;
            orange[2] = lblOrange2;
            orange[3] = lblOrange3;
            orange[4] = lblOrange4;
            orange[5] = lblOrange5;
            orange[6] = lblOrange6;
            orange[7] = lblOrange7;
            orange[8] = lblOrange8;
            orange[9] = lblOrange9;

            green[0] = lblGreen0;
            green[1] = lblGreen1;
            green[2] = lblGreen2;
            green[3] = lblGreen3;
            green[4] = lblGreen4;
            green[5] = lblGreen5;
            green[6] = lblGreen6;
            green[7] = lblGreen7;

            purple[0] = lblPurple0;
            purple[1] = lblPurple1;
            purple[2] = lblPurple2;
            purple[3] = lblPurple3;
            purple[4] = lblPurple4;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = false;
            }
            if (e.KeyValue == 38)
            {
                tmrUp.Enabled = false;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = false;
            }
            if (e.KeyValue == 40)
            {
                tmrDown.Enabled = false; 
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = true;
            }
            if (e.KeyValue == 38)
            {
                tmrUp.Enabled = true;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = true;
            }
            if (e.KeyValue == 40)
            {
                tmrDown.Enabled = true;
            }
            if (e.KeyValue == 32)
            {
               
            }
        }

        private void tmrOrange_Tick(object sender, EventArgs e)
        {
            for (int o = 0; o <= 9; o++)
            {
                for (int w = 0; w <= 7; w++)
                {
                    if (orangeDir[o] == true)
                    {
                        orange[o].Top += 1;
                        if (orange[o].Bounds.IntersectsWith(wall[w].Bounds))
                        {
                            orangeDir[o] = false;
                        }
                    }
                    else
                    {
                        orange[o].Top -= 1;
                        if (orange[o].Bounds.IntersectsWith(wall[w].Bounds))
                        {
                            orangeDir[o] = true;
                        }
                    }
                }
            }
        }

        private void tmrGreen_Tick(object sender, EventArgs e)
        {
            for (int g = 0; g <= 7; g++)
                {
                  green[g].Left += 1;
                  if (green[g].Left >= 531)
                  {
                      green[g].Left = 168;
                 }
            }
        }

        private void chkWall()
        {
            for (int w = 0; w <= 7; w++)
            {

                if (lblPacman.Bounds.IntersectsWith(wall[w].Bounds))
                {
                    lblPacman.Top = 109;
                    lblPacman.Left = 120;
                }

            }
        }

        private void chkMLG()
        {
            if (lblPacman.Bounds.IntersectsWith(lblMLG.Bounds))
            {
                tmrLeft.Enabled = false;
                tmrRight.Enabled = false;
                tmrDown.Enabled = false;
                tmrUp.Enabled = false;
                tmrOrange.Enabled = false;
                tmrPurple.Enabled = false;
                tmrGreen.Enabled = false;
            }
        }
        private void chkBlock()
        {
            for (int i = 0; i < 9; i++)
            {

                if (orange[i].Bounds.IntersectsWith(lblPacman.Bounds))
                {
                    lblPacman.Top = 109;
                    lblPacman.Left = 120;
                }

            }
            for (int i = 0; i < 8; i++)
            {

                if (green[i].Bounds.IntersectsWith(lblPacman.Bounds))
                {
                    lblPacman.Top = 109;
                    lblPacman.Left = 120;
                }

            }
            for (int i = 0; i < 4; i++)
            {

                if (purple[i].Bounds.IntersectsWith(lblPacman.Bounds))
                {
                    lblPacman.Top = 109;
                    lblPacman.Left = 120;
                }

            }
        }


        private void tmrPurple_Tick(object sender, EventArgs e)
        {
            for (int p = 0; p <= 4; p += 2)
            {
                if (purpleDir[p] == true)
                {
                    purple[p].Height += 1;
                    if (purple[p].Height >= 78)
                    {
                        purpleDir[p] = false;
                    }
                }
                else
                {
                    purple[p].Height -= 1;
                    if (purple[p].Height <= 0)
                    {
                        purpleDir[p] = true;
                    }
                }
            }

            for (int p = 1; p <= 4; p += 2)
            {
                if (purpleDir[p] == true)
                {
                    purple[p].Height += 1;
                    purple[p].Top -= 1;
                    if (purple[p].Height >= 78)
                    {
                        purpleDir[p] = false;
                    }
                }
                else
                {
                    purple[p].Height -= 1;
                    purple[p].Top += 1;
                    if (purple[p].Height <= 0)
                    {
                        purpleDir[p] = true;
                    }
                }
            }
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            lblPacman.Left -= 4;
            chkWall();
            chkBlock();
            chkMLG();
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            lblPacman.Left += 4;
            chkWall();
            chkBlock();
            chkMLG();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            lblPacman.Top -= 4;
            chkWall();
            chkBlock();
            chkMLG();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            lblPacman.Top += 4;
            chkWall();
            chkBlock();
            chkMLG();
        }
    }
}
