using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P17_McKenzieBradley_Breakout
{
    public partial class Form1 : Form
    {
        bool xDir;
        bool yDir;

        Label[] block = new Label[24];

        public Form1()
        {
            InitializeComponent();

            block[0] = lbl0;
            block[1] = lbl1;
            block[2] = lbl2;
            block[3] = lbl3;
            block[4] = lbl4;
            block[5] = lbl5;
            block[6] = lbl6;
            block[7] = lbl7;
            block[8] = lbl8;
            block[9] = lbl9;
            block[10] = lbl10;
            block[11] = lbl11;
            block[12] = lbl12;
            block[13] = lbl13;
            block[14] = lbl14;
            block[15] = lbl15;
            block[16] = lbl16;
            block[17] = lbl17;
            block[18] = lbl18;
            block[19] = lbl19;
            block[20] = lbl20;
            block[21] = lbl21;
            block[22] = lbl22;
            block[23] = lbl23;
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {
            if (xDir == true)
            {
                lblBall.Left += 3;
                if (lblBall.Left > this.Width - (lblBall.Width + 15))
                {
                    xDir = false;
                }
            }
            else
            {
                lblBall.Left -= 3;
                if (lblBall.Left < 0) xDir = true;
            }

            if (yDir == true)
            {
                lblBall.Top += 5;
                if (lblBall.Top > this.Height - (lblBall.Height + 15))
                {
                    tmrGo.Enabled = false;
                }
            }
            else
            {
                lblBall.Top -= 5;
                if (lblBall.Top < 0)
                {
                    yDir = true;
                }
            }
            checkPaddle();
            checkBlock();
            checkEnd();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            lblPaddle.Left -= 5;
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            lblPaddle.Left += 5;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyValue == 37)
                {
                    tmrLeft.Enabled = true;
                }
                if (e.KeyValue == 39)
                {
                    tmrRight.Enabled = true;
                }
                if (e.KeyValue == 32)
                {
                    reset();
                }

            }
        }

        private void checkPaddle()
        {
            if (lblBall.Bounds.IntersectsWith(lblPaddle.Bounds))
            {
            yDir = false;
            }
        }

        private void checkBlock()
        {
            for (int i = 0; i <= 23; i++)
            {
                if (lblBall.Bounds.IntersectsWith(block[i].Bounds) && (block[i].Visible == true))
                {
                    yDir = true;
                    block[i].Visible = false;
                }
            }
        }

        private void checkEnd() 
        {
          if (lblBall.Top > this.Height)
          {
            tmrGo.Enabled = false;
            }
        }

        private void reset()
        {
            for (int i = 0; i <= 23; i++)
            {
                block[i].Visible = true;
            }
                lblBall.Top = 250;
                tmrGo.Enabled = true;

        }
       
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyValue == 37)
                {
                    tmrLeft.Enabled = false;
                }
                if (e.KeyValue == 39)
                {
                    tmrRight.Enabled = false;
                }
            }
        }
    }
}