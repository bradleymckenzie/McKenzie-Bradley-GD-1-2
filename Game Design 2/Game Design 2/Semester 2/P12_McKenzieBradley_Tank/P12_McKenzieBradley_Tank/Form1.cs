using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_McKenzieBradley_Tank
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Z:\P2_GameDesign 2\P12_McKenzieBradley_Tank\P12_McKenzieBradley_Tank\Pop.wav");
        PictureBox[] water = new PictureBox[23];
        PictureBox[] boom = new PictureBox[16];
        PictureBox[] bush = new PictureBox[15];
        Label[] bullet = new Label[20];
        Label[] wall = new Label[14];
        String[] bulletDir = new String[20];
        String tankDir = "North";
        int newWater;
        int exp;
        int bulletItem = -1;
        int hitTree = 1;
        bool play;

        public Form1()
        {
            InitializeComponent();

            water[0] = picWater0;
            water[1] = picWater1;
            water[2] = picWater2;
            water[3] = picWater3;
            water[4] = picWater4;
            water[5] = picWater5;
            water[6] = picWater6;
            water[7] = picWater7;
            water[8] = picWater8;
            water[9] = picWater9;
            water[10] = picWater10;
            water[11] = picWater11;
            water[12] = picWater12;
            water[13] = picWater13;
            water[14] = picWater14;
            water[15] = picWater15;
            water[16] = picWater16;
            water[17] = picWater17;
            water[18] = picWater18;
            water[19] = picWater19;
            water[20] = picWater20;
            water[21] = picWater21;
            water[22] = picWater22;

            bullet[0] = lbl0;
            bullet[1] = lbl1;
            bullet[2] = lbl2;
            bullet[3] = lbl3;
            bullet[4] = lbl4;
            bullet[5] = lbl5;
            bullet[6] = lbl6;
            bullet[7] = lbl7;
            bullet[8] = lbl8;
            bullet[9] = lbl9;
            bullet[10] = lbl10;
            bullet[11] = lbl11;
            bullet[12] = lbl12;
            bullet[13] = lbl13;
            bullet[14] = lbl14;
            bullet[15] = lbl15;
            bullet[16] = lbl16;
            bullet[17] = lbl17;
            bullet[18] = lbl18;
            bullet[19] = lbl19;

            boom[0] = picBoom0;
            boom[1] = picBoom1;
            boom[2] = picBoom2;
            boom[3] = picBoom3;
            boom[4] = picBoom4;
            boom[5] = picBoom5;
            boom[6] = picBoom6;
            boom[7] = picBoom7;
            boom[8] = picBoom8;
            boom[9] = picBoom9;
            boom[10] = picBoom10;
            boom[11] = picBoom11;
            boom[12] = picBoom12;
            boom[13] = picBoom13;
            boom[14] = picBoom14;
            boom[15] = picBoom15;

            bush[0] = lblBush0;
            bush[1] = lblBush1;
            bush[2] = lblBush2;
            bush[3] = lblBush3;
            bush[4] = lblBush4;
            bush[5] = lblBush5;
            bush[6] = lblBush6;
            bush[7] = lblBush7;
            bush[8] = lblBush8;
            bush[9] = lblBush9;
            bush[10] = lblBush10;
            bush[11] = lblBush11;
            bush[12] = lblBush12;
            bush[13] = lblBush13;
            bush[14] = lblBush14;

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
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
            picTankMove.Left += 5;
            }
            chkWall();
            chkTree();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
            picTankMove.Left -= 5;
            }
            chkWall();
            chkTree();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                picTankMove.Top -= 5;
            }
            chkWall();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                picTankMove.Top += 5;
            }
            chkWall();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tankDir = "West";
                tmrLeft.Enabled = true;
                picTankMove.Image = picTankLeft.Image;
            }
            if (e.KeyValue == 38)
            {
                tankDir = "North";
                tmrUp.Enabled = true;
                picTankMove.Image = picTankUp.Image;
            }
            if (e.KeyValue == 39)
            {
                tankDir = "East";
                tmrRight.Enabled = true;
                picTankMove.Image = picTankRight.Image;
            }
            if (e.KeyValue == 40)
            {
                tankDir = "South";
                tmrDown.Enabled = true;
                picTankMove.Image = picTankDown.Image;
            }
            if (e.KeyValue == 32)
            {
                bulletItem += 1;
                if (bulletItem > 19)
                {
                    bulletItem = 0;
                }

                bulletDir[bulletItem] = tankDir;
                bullet[bulletItem].Left = picTankMove.Left + 17;
                bullet[bulletItem].Top = picTankMove.Top + 17;
                bullet[bulletItem].Visible = true;
                play = true;
            }
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

        private void tmrWater_Tick(object sender, EventArgs e)
        {
            newWater += 1;

            for (int i = 0; i <= 22; i++)
            {
                if (newWater == 1)
                {
                    water[i].Image = picWaterA.Image;
                }

                if (newWater == 2)
                {
                    water[i].Image = picWaterB.Image;
                }
            }
            if (newWater >= 2)
            {
                newWater = 0;
            }
        }

        private void tmrGun_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 19; i++)
            {
                if (bulletDir[i] == "North")
                {
                    bullet[i].Top -= 4;
                }
                else if (bulletDir[i] == "South")
                {
                    bullet[i].Top += 4;
                }
                else if (bulletDir[i] == "East")
                {
                    bullet[i].Left += 4;
                }
                else if (bulletDir[i] == "West")
                {
                    bullet[i].Left -= 4;
                }
            }
            chkTree();
        }

        private void chkTree()
        {
            for (int b = 0; b <=19; b++)
            {
                for (int t = 0; t <= 14; t++)
                {
                    if(bullet[b].Bounds.IntersectsWith(bush[t].Bounds) && (bush[t].Visible = true) && (bullet[t].Visible = true))
                    {
                       bullet[b].Visible = false;
                       hitTree = t;
                       tmrBoom.Enabled = true;
                       player.Play();
                    }
                }
            }
        }

        private void chkWall()
        {
            for (int i = 0; i < 13; i++)
            {

                if (wall[i].Bounds.IntersectsWith(picTankMove.Bounds))
                {
                    play = false;
                    tmrRight.Enabled = false;
                    tmrLeft.Enabled = false;
                    tmrUp.Enabled = false;
                    tmrDown.Enabled = false;
                }

            }
        }

        private void tmrBoom_Tick(object sender, EventArgs e)
        {
            bush[hitTree].Image = boom[exp].Image;
            exp += 1;
            if (exp > 15)
            {
                exp = 0;
                bush[hitTree].Visible = false;
                tmrBoom.Enabled = false;
            }
        }
    }
}
