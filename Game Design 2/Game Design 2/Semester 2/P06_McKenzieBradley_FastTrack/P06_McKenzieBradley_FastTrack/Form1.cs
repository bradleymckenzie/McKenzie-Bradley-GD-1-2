using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_McKenzieBradley_FastTrack
{
    public partial class Form1 : Form
    { 
        Label[] wall = new Label[9];
        double time;
        bool play;

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
            wall[8] = lbl8;
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
            lblCar.Top -= 4;
            }

            chkWall();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                lblCar.Top += 4;
            }
            chkWall();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                lblCar.Left -= 4;
            }
            chkWall();
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            if (play == true)
            {
                lblCar.Left += 4;
            }
            chkWall();
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
                play = true;
                time = 0;
                tmrTime.Enabled = true;
                lblCar.Top = 354;
                lblCar.Left = 381;
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

        private void chkWall()
        {
            for (int i = 0; i < 9; i++)
            {

                if (wall[i].Bounds.IntersectsWith(lblCar.Bounds))
                {
                    play = false;
                    tmrTime.Enabled = false;
                }

            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time += 0.01;
            lblTime.Text = time.ToString("#.00");
            if (lblCar.Bounds.IntersectsWith(lblFinish.Bounds) && time > 3)
            {
                tmrTime.Enabled = false;
                play = false;
            }
        }
    }
}
