using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_McKenzieBradley_Creative1
{
    public partial class Form1 : Form
    {
        Label[] wall = new Label[42];
        Label[] blockA = new Label[16];
        Label[] blockB = new Label[16];
        Label[] collect = new Label[10];
        Label[] blue = new Label[5];
        bool[] blueDir = new bool[5];

        double deg;

        int xCenterA;
        int yCenterA;

        int xCenterB;
        int yCenterB;

        public Form1()
        {
            InitializeComponent();

            blockA[0] = lblA0;
            blockA[1] = lblA1;
            blockA[2] = lblA2;
            blockA[3] = lblA3;
            blockA[4] = lblA4;
            blockA[5] = lblA5;
            blockA[6] = lblA6;
            blockA[7] = lblA7;
            blockA[8] = lblA8;
            blockA[9] = lblA9;
            blockA[10] = lblA10;
            blockA[11] = lblA11;
            blockA[12] = lblA12;
            blockA[13] = lblA13;
            blockA[14] = lblA14;
            blockA[15] = lblA15;

            blockB[0] = lblB0;
            blockB[1] = lblB1;
            blockB[2] = lblB2;
            blockB[3] = lblB3;
            blockB[4] = lblB4;
            blockB[5] = lblB5;
            blockB[6] = lblB6;
            blockB[7] = lblB7;
            blockB[8] = lblB8;
            blockB[9] = lblB9;
            blockB[10] = lblB10;
            blockB[11] = lblB11;
            blockB[12] = lblB12;  
            blockB[13] = lblB13;
            blockB[14] = lblB14;
            blockB[15] = lblB15;

            blue[0] = lblBlue2;
            blue[1] = lblBlue1;
            blue[2] = lblBlue0;
            blue[3] = lblBlue3;
            blue[4] = lblBlue4;

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
            wall[30] = lblWall30;
            wall[31] = lblWall31;
            wall[32] = lblWall32;
            wall[33] = lblWall33;
            wall[34] = lblWall34;
            wall[35] = lblWall35;
            wall[36] = lblWall36;
            wall[37] = lblWall37;
            wall[38] = lblWall38;
            wall[39] = lblWall39;
            wall[40] = lblWall40;
            wall[41] = lblWall41;

            collect[0] = lblCollect0;
            collect[1] = lblCollect1;
            collect[2] = lblCollect2;
            collect[3] = lblCollect3;
            collect[4] = lblCollect4;
            collect[5] = lblCollect5;
            collect[6] = lblCollect6;
            collect[7] = lblCollect7;
            collect[8] = lblCollect8;
            collect[9] = lblCollect9;
           
            xCenterA = 272;
            yCenterA = 324;

            xCenterB = 600;
            yCenterB = 324;
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

        private void chkWall()
        {
            for (int i = 0; i <= 41; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(wall[i].Bounds))
                {
                    lblBlock.Top = 327;
                    lblBlock.Left = 441;

                    for (int b = 0; b < 9; b++)
                    {
                        collect[b].Visible = true;
                    }
                }
            }
        }
          
        private void chkBlockA()
        {
            for (int i = 0; i <= 15; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(blockA[i].Bounds) && blockA[i].Visible == true)
                {
                    reset();
                }

            }
        }

        private void chkBlockB()
        {
            for (int i = 0; i <= 15; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(blockB[i].Bounds) && blockB[i].Visible == true)
                {
                    reset();
                }

            }
        }

        private void reset()
        {
            lblBlock.Left = 441;
            lblBlock.Top = 327;
        }

        private void chkDoor()
        {
            for (int i = 0; i < 4; i++)
            {

                if (blue[i].Bounds.IntersectsWith(lblBlock.Bounds))
                {
                    lblBlock.Top = 109;
                    lblBlock.Left = 120;
                }

            }
        }

        private void chkCollect()
        {
            for (int i = 0; i <= 9; i++)
            {

                if (lblBlock.Bounds.IntersectsWith(collect[i].Bounds))
                {
                    collect[i].Visible = false;

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

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            lblBlock.Top -= 2;
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            lblBlock.Top += 2; 
        }

        private void tmrGo_Tick_1(object sender, EventArgs e)
            {
                deg += 0.01;
                if (deg == 360)
                {
                    deg = 0;
                }
                for (int i = 0; i < 15; i += 4)
                {
                    //pink
                    blockA[i].Top = Convert.ToInt16(yCenterA + (Math.Sin(deg + Math.PI * 0.5) * 23 * i));
                    blockA[i].Left = Convert.ToInt16(xCenterA + (Math.Cos(deg + Math.PI * 0.5) * 23 * i));
                    //green
                    blockA[i + 1].Top = Convert.ToInt16(yCenterA + (Math.Sin(deg + Math.PI * 1) * 23 * i));
                    blockA[i + 1].Left = Convert.ToInt16(xCenterA + (Math.Cos(deg + Math.PI * 1) * 23 * i));
                    //blue
                    blockA[i + 2].Top = Convert.ToInt16(yCenterA + (Math.Sin(deg + Math.PI * 1.5) * 23 * i));
                    blockA[i + 2].Left = Convert.ToInt16(xCenterA + (Math.Cos(deg + Math.PI * 1.5) * 23 * i));
                    //purple
                    blockA[i + 3].Top = Convert.ToInt16(yCenterA + (Math.Sin(deg + Math.PI * 2) * 23 * i));
                    blockA[i + 3].Left = Convert.ToInt16(xCenterA + (Math.Cos(deg + Math.PI * 2) * 23 * i));
                }

                {
                    //deg += 0.01;
                    //if (deg == 360)
                    //{
                    //    deg = 0;
                    //}
                    for (int i = 0; i < 15; i += 4)
                    {
                        
                        //pink
                        blockB[i].Top = Convert.ToInt16(yCenterB + (Math.Cos(deg + Math.PI * 0.5) * 23 * i));
                        blockB[i].Left = Convert.ToInt16(xCenterB + (Math.Sin(deg + Math.PI * 0.5) * 23 * i));
                        //green
                        blockB[i + 1].Top = Convert.ToInt16(yCenterB + (Math.Cos(deg + Math.PI * 1) * 23 * i));
                        blockB[i + 1].Left = Convert.ToInt16(xCenterB + (Math.Sin(deg + Math.PI * 1) * 23 * i));
                        //blue
                        blockB[i + 2].Top = Convert.ToInt16(yCenterB + (Math.Cos(deg + Math.PI * 1.5) * 23 * i));
                        blockB[i + 2].Left = Convert.ToInt16(xCenterB + (Math.Sin(deg + Math.PI * 1.5) * 23 * i));
                        //purple
                        blockB[i + 3].Top = Convert.ToInt16(yCenterB + (Math.Cos(deg + Math.PI * 2) * 23 * i));
                        blockB[i + 3].Left = Convert.ToInt16(xCenterB + (Math.Sin(deg + Math.PI * 2) * 23 * i));
                         
                    }
                    chkBlockA();
                    chkBlockB();
                    chkWall();
                    chkCollect();
                    chkDoor();
                }
        }

        private void tmrBlue_Tick(object sender, EventArgs e)
        {
                for (int p = 2; p <= 4; p += 2)
                {
                    if (blueDir[p] == true)
                    {
                        blue[p].Height += 1;
                        if (blue[p].Height >= 86)
                        {
                            blueDir[p] = false;
                        }
                    }
                    else
                    {
                        blue[p].Height -= 1;
                        if (blue[p].Height <= 0)
                        {
                            blueDir[p] = true;
                        }
                    }
                }

                for (int p = 1; p <= 4; p += 2)
                {
                    if (blueDir[p] == true)
                    {
                        blue[p].Height += 1;
                        blue[p].Top -= 1;
                        if (blue[p].Height >= 86)
                        {
                            blueDir[p] = false;
                        }
                    }
                    else
                    {
                        blue[p].Height -= 1;
                        blue[p].Top += 1;
                        if (blue[p].Height <= 0)
                        {
                            blueDir[p] = true;
                        }
                    }
                }
            }
        }
    }
