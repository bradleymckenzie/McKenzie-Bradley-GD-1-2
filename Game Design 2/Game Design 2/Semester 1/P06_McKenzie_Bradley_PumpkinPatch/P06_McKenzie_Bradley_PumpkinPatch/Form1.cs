using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06_McKenzie_Bradley_PumpkinPatch
{
    public partial class Form1 : Form
    {
        PictureBox[] pumpkin = new PictureBox[10];

        double seconds = 0.0;

        public Form1()
        {
            InitializeComponent();

            pumpkin[0] = pic0;
            pumpkin[1] = pic1;
            pumpkin[2] = pic2;
            pumpkin[3] = pic3;
            pumpkin[4] = pic4;
            pumpkin[5] = pic5;
            pumpkin[6] = pic6;
            pumpkin[7] = pic7;
            pumpkin[8] = pic8;
            pumpkin[9] = pic9;
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            picGhost.Left -= 2;
            if (picGhost.Left < -50) picGhost.Left = this.Width;
            chkPumpkin();
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            picGhost.Left += 2;
            if (picGhost.Left > this.Width) picGhost.Left = -50;
            chkPumpkin();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            picGhost.Top += 2;
            if (picGhost.Top > this.Width) picGhost.Top = -50;
            chkPumpkin();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            picGhost.Top -= 2;
            if (picGhost.Top < -50) picGhost.Top= this.Width;
            chkPumpkin();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = true;
            }
            if (e.KeyValue == 38)
            {
                tmrDown.Enabled = true;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = true;
            }
            if (e.KeyValue == 40)
            {
                tmrUp.Enabled = true;
            }
            if (e.KeyValue == 32)
            {
                Random r = new Random();
                for (int i = 0; i < 10; i++)
                {
                    pumpkin[i].Left = r.Next(this.Width) - 75;
                    pumpkin[i].Top = r.Next(this.Height) - 75;
                    pumpkin[i].Visible = false;

                }
                    tmrTime.Enabled = true;
                    seconds = 0.0;
                    lblBegin.Visible = false;
				    lblTime.Text = String.Format("{0:0.0}" , seconds);
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
                tmrDown.Enabled = false;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = false;
            }
            if (e.KeyValue == 40)
            {
                tmrUp.Enabled = false;
            }
        }


        private void chkPumpkin()
        {
            for (int i = 0; i < 10; i++)
            {

                if (picGhost.Bounds.IntersectsWith(pumpkin[i].Bounds))
                {
                    pumpkin[i].Visible = true;
                }
               
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            seconds += 0.1;
            lblTime.Text = String.Format("{0:0.0}" , seconds);
        }
    }
}