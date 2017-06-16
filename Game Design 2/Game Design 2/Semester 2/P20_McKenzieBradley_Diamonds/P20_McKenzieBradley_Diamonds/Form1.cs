using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20_McKenzieBradley_Diamonds
{
    public partial class Form1 : Form
    {
        bool yDir;
        int hits;
        double seconds;
        Label[] blocks = new Label[72];

        public Form1()
        {
            InitializeComponent();

            blocks[0] = lbl0;
            blocks[1] = lbl1;
            blocks[2] = lbl2;
            blocks[3] = lbl3;
            blocks[4] = lbl4;
            blocks[5] = lbl5;
            blocks[6] = lbl6;
            blocks[7] = lbl7;
            blocks[8] = lbl8;
            blocks[9] = lbl9;
            blocks[10] = lbl10;
            blocks[11] = lbl11;
            blocks[12] = lbl12;
            blocks[13] = lbl13;
            blocks[14] = lbl14;
            blocks[15] = lbl15;
            blocks[16] = lbl16;
            blocks[17] = lbl17;
            blocks[18] = lbl18;
            blocks[19] = lbl19;
            blocks[20] = lbl20;
            blocks[21] = lbl21;
            blocks[22] = lbl22;
            blocks[23] = lbl23;
            blocks[24] = lbl24;
            blocks[25] = lbl25;
            blocks[26] = lbl26;
            blocks[27] = lbl27;
            blocks[28] = lbl28;
            blocks[29] = lbl29;
            blocks[30] = lbl30;
            blocks[31] = lbl31;
            blocks[32] = lbl32;
            blocks[33] = lbl33;
            blocks[34] = lbl34;
            blocks[35] = lbl35;
            blocks[36] = lbl36;
            blocks[37] = lbl37;
            blocks[38] = lbl38;
            blocks[39] = lbl39;
            blocks[40] = lbl40;
            blocks[41] = lbl41;
            blocks[42] = lbl42;
            blocks[43] = lbl43;
            blocks[44] = lbl44;
            blocks[45] = lbl45;
            blocks[46] = lbl46;
            blocks[47] = lbl47;
            blocks[48] = lbl48;
            blocks[49] = lbl49;
            blocks[50] = lbl50;
            blocks[51] = lbl51;
            blocks[52] = lbl52;
            blocks[53] = lbl53;
            blocks[54] = lbl54;
            blocks[55] = lbl55;
            blocks[56] = lbl56;
            blocks[57] = lbl57;
            blocks[58] = lbl58;
            blocks[59] = lbl59;
            blocks[60] = lbl50;
            blocks[61] = lbl61;
            blocks[62] = lbl62;
            blocks[63] = lbl63;
            blocks[64] = lbl64;
            blocks[65] = lbl65;
            blocks[66] = lbl66;
            blocks[67] = lbl67;
            blocks[68] = lbl68;
            blocks[69] = lbl69;
            blocks[70] = lbl70;
            blocks[71] = lbl71;

            hits = 0;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
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

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            if (hits >= 0 && hits < 64)
            {
                lblBall.Left += 3;
                if (lblBall.Left > 140)
                {
                    lblBall.Left = 140;
                    lblBall.Left += -3;
                }
            }
            chkDiamond(3);
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            if (hits >= 0 && hits < 64)
            {
                lblBall.Left -= 3;
                if (lblBall.Left < 0)
                {
                    lblBall.Left = 0;
                    lblBall.Left += 3;
                }
            }
            chkDiamond(-3);
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {

            if (yDir == true)
            {
                lblBall.Top += 3;
                if (lblBall.Top > 140)
                {
                    lblBall.Top = 140;
                    yDir = false;
                }
            }
            else
            {
                lblBall.Top -= 3;
                if (lblBall.Top < 0)
                {
                    yDir = true;
                }
            }
            chkHit();
            seconds += 0.01;
            lblSeconds.Text = seconds.ToString("#.00");
        }

        private void chkHit()
        {
            for (int i = 0; i <= 71; i++)
            {
               if (lblBall.Left > blocks[i].Left - lblBall.Width && lblBall.Left < blocks[i].Left + blocks[i].Width && lblBall.Top > blocks[i].Top - lblBall.Height && lblBall.Top < blocks[i].Top + blocks[i].Height && (blocks[i].Visible == true))
                {
                    if (!blocks[i].Equals(""))
                    {
                       blocks[i].Visible = false;
                        hits += 1;
                        if (hits == 64)
                        {
                            tmrGo.Enabled = false;
                        }
                    }
                    if (yDir == true)
                    {
                        yDir = false;
                    }
                    else if (yDir == false)
                    {
                        yDir = true;
                    }
                }
            }
        }

        private void reset()
        {
            for (int i = 0; i <= 71; i++)
            {
                blocks[i].Visible = true;
            }
            lblBall.Top = 70;
            lblBall.Left = 70;
            tmrGo.Enabled = true;
            hits = 0;
            seconds = 0;
            lblSeconds.Text = seconds.ToString("#.00");
        }

        private void chkDiamond(int value)
        {
            for (int i = 0; i <= 71; i++)
            {
                if (lblBall.Bounds.IntersectsWith(blocks[i].Bounds) && blocks[i].Visible == true)
                {
                    if (blocks[i].Text == "t")
                    {
                        lblBall.Left -= value;
                    }
                }
            }
        }
    }
}