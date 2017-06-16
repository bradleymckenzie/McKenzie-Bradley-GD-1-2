using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P18_McKenzieBradley_Crane
{
    public partial class Form1 : Form
    {
        bool lift;

        public Form1()
        {
            InitializeComponent();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            if(lblHoist.Top > 50) 
            {
                lblRope1.Height -= 2;
                lblRope2.Height -= 2;
                lblHoist.Top -= 2;
                lblAttachment.Top -= 2;
                lblHook.Top -= 2;
            }
            if (lift == true)
            {
                picCar.Top -= 2;
            }
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            if (lblHook.Top < 622 && lblHook.Bounds.IntersectsWith(picCar.Bounds) == false)
            {
                lblRope1.Height += 2;
                lblRope2.Height += 2;
                lblHoist.Top += 2;
                lblAttachment.Top += 2;
                lblHook.Top += 2;
            }
            if (lift == true)
            {
                picCar.Top += 2;
            }
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            if (lblHoist.Left > 0)
            {
                lblRope1.Left -= 2;
                lblRope2.Left -= 2;
                lblHoist.Left -= 2;
                lblAttachment.Left -= 2;
                lblHook.Left -= 2;
            }
            if (lift == true)
            {
                picCar.Left -= 2;
            }
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            if (lblHoist.Left < 610)
            {
                lblRope1.Left += 2;
                lblRope2.Left += 2;
                lblHoist.Left += 2;
                lblAttachment.Left += 2;
                lblHook.Left += 2;
            }

           if (lift == true)
            {
                picCar.Left += 2;
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
                lift = true;
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
            if (e.KeyValue == 32)
            {
                lift = false;
            }
        }

        private void tmrLift_Tick(object sender, EventArgs e)
        {
            if(lift== false && (picCar.Top < 600))
            {
                picCar.Top += 2;
            }
            if(lblHook.Bounds.IntersectsWith(picCar.Bounds) == false && (picCar.Top < 600))
            {
                picCar.Top += 2;
            }
        }
    }
}
