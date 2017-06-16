using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08_McKenzieBradley_Rotate
{
    public partial class Form1 : Form
    { 
        Label[] wall = new Label[30];
        Label[] block = new Label[24];
        Label[] collect = new Label[8];
        double deg;
        int xCenter;
        int yCenter;
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

            wall[0] = lblWall0;
            wall[1] = lblWall1;
            wall[2] = lblWall2;
            wall[3] = lblWall3;
            wall[4] = lblWall4;
            wall[5] = lblWall5;
            wall[6] = lblWall6;
            wall[7] = lblWall7;
            wall[8] = lblWall8;
            wall[9] = lblWall9;
            wall[10] = lblWall10;
            wall[11] = lblWall11;
            wall[12] = lblWall12;
            wall[13] = lblWall13;
            wall[14] = lblWall14;
            wall[15] = lblWall15;
            wall[16] = lblWall16;
            wall[17] = lblWall17;
            wall[18] = lblWall18;
            wall[19] = lblWall19;
            wall[20] = lblWall20;
            wall[21] = lblWall21;
            wall[22] = lblWall22;
            wall[23] = lblWall23;
            wall[24] = lblWall24;
            wall[25] = lblWall25;
            wall[26] = lblWall26;
            wall[27] = lblWall27;
            wall[28] = lblWall28;
            wall[29] = lblWall29;

            collect[0] = lblCollect0;
            collect[1] = lblCollect1;
            collect[2] = lblCollect2;
            collect[3] = lblCollect3;
            collect[4] = lblCollect4;
            collect[5] = lblCollect5;
            collect[6] = lblCollect6;
            collect[7] = lblCollect7;

            xCenter = 337;
            yCenter = 327;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            lblBlock.Left -= 2;

        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            lblBlock.Left += 2;
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            lblBlock.Top += 2;
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            lblBlock.Top -= 2;
        }

        private void chkWall()
        {
            for (int i = 0; i <= 29; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(wall[i].Bounds))
                {
                    lblBlock.Top = 327;
                    lblBlock.Left = 337;

                    for (int b = 0; b < 7; b++)
                    {
                        collect[b].Visible = true;
                    }
                }

            }
        }

        private void chkBlock()
        {
            for (int i = 0; i <= 23; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(block[i].Bounds) && block[i].Visible == true)
                {
                    reset();
                }

            }
        }

        private void reset()
        {
            lblBlock.Left = xCenter;
            lblBlock.Top= yCenter;
        }
        
        private void chkCollect()
        {
            for (int i = 0; i <= 7; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(collect[i].Bounds))
                {
                    collect[i].Visible = false;

                }
            }
        }
        private void tmrGo_Tick(object sender, EventArgs e)
        {
            deg += 0.01;
            if (deg == 360)
            {
                deg = 0;
            }
            for (int i = 0; i <= 23; i+= 4)
            {
                //pink
                block[i].Top = Convert.ToInt16(yCenter + (Math.Sin(deg + Math.PI * 0.5) * 15 * i));
                block[i].Left = Convert.ToInt16(xCenter + (Math.Cos(deg + Math.PI * 0.5) * 15 * i));
                //green
                block[i + 1].Top = Convert.ToInt16(yCenter + (Math.Sin(deg + Math.PI * 1) * 15 * i));
                block[i + 1].Left = Convert.ToInt16(xCenter + (Math.Cos(deg + Math.PI * 1) * 15 * i));
                //blue
                block[i + 2].Top = Convert.ToInt16(yCenter + (Math.Sin(deg + Math.PI * 1.5) * 15 * i));
                block[i + 2].Left = Convert.ToInt16(xCenter + (Math.Cos(deg + Math.PI * 1.5) * 15 * i));
                //purple
                block[i + 3].Top = Convert.ToInt16(yCenter + (Math.Sin(deg + Math.PI * 2) * 15 * i));
                block[i + 3].Left = Convert.ToInt16(xCenter + (Math.Cos(deg + Math.PI * 2) * 15 * i));
            }
            chkBlock();
            chkWall();
            chkCollect();
        }
        
    }
}
