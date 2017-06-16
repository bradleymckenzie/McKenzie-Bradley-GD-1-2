using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_McKenzieBradley_Dominos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            tmrRight5.Enabled = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            tmrLeft0.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrRight0.Enabled = false;
            tmrRight1.Enabled = false;
            tmrRight2.Enabled = false;
            tmrRight3.Enabled = false;
            tmrRight4.Enabled = false;
            tmrRight5.Enabled = false;

            tmrLeft0.Enabled = false;
            tmrLeft1.Enabled = false;
            tmrLeft2.Enabled = false;
            tmrLeft3.Enabled = false;
            tmrLeft4.Enabled = false;
            tmrLeft5.Enabled = false;

        }

        private void tmrRight0_Tick(object sender, EventArgs e)
        {
            lbl0.Left -= 4;

            if (lbl0.Left < 19)
            {
                tmrRight0.Enabled = false;
            }
        }

        private void tmrRight1_Tick(object sender, EventArgs e)
        {
            lbl1.Left -= 4;

            if (lbl1.Bounds.IntersectsWith(lbl0.Bounds))
            {
                tmrRight1.Enabled = false;
                tmrRight0.Enabled = true;
            }
        }

        private void tmrRight2_Tick(object sender, EventArgs e)
        {
            lbl2.Left -= 4;

            if (lbl2.Bounds.IntersectsWith(lbl1.Bounds))
            {
                tmrRight2.Enabled = false;
                tmrRight1.Enabled = true;
            }
        }

        private void tmrRight3_Tick(object sender, EventArgs e)
        {
            lbl3.Left -= 4;

            if (lbl3.Bounds.IntersectsWith(lbl2.Bounds))
            {
                tmrRight3.Enabled = false;
                tmrRight2.Enabled = true;
            }
        }

        private void tmrRight4_Tick(object sender, EventArgs e)
        {
            lbl4.Left -= 4;

            if (lbl4.Bounds.IntersectsWith(lbl3.Bounds))
            {
                tmrRight4.Enabled = false;
                tmrRight3.Enabled = true;
            }
        }

        private void tmrRight5_Tick(object sender, EventArgs e)
        {
            lbl5.Left -= 4;

            if (lbl5.Bounds.IntersectsWith(lbl4.Bounds))
            {
                tmrRight5.Enabled = false;
                tmrRight4.Enabled = true;
            }
        }

        private void tmrLeft5_Tick(object sender, EventArgs e)
        {
            lbl5.Left += 4;

            if (lbl5.Left > 232)
            {
                tmrLeft5.Enabled = false;
            }
        }

        private void tmrLeft4_Tick(object sender, EventArgs e)
        {
            lbl4.Left += 4;

            if (lbl4.Bounds.IntersectsWith(lbl5.Bounds))
            {
                tmrLeft4.Enabled = false;
                tmrLeft5.Enabled = true;
            }
        }

        private void tmrLeft3_Tick(object sender, EventArgs e)
        {
            lbl3.Left += 4;

            if (lbl3.Bounds.IntersectsWith(lbl4.Bounds))
            {
                tmrLeft3.Enabled = false;
                tmrLeft4.Enabled = true;
            }
        }

        private void tmrLeft2_Tick(object sender, EventArgs e)
        {
            lbl2.Left += 4;

            if (lbl2.Bounds.IntersectsWith(lbl3.Bounds))
            {
                tmrLeft2.Enabled = false;
                tmrLeft3.Enabled = true;
            }
        }

        private void tmrLeft1_Tick(object sender, EventArgs e)
        {
            lbl1.Left += 4;

            if (lbl1.Bounds.IntersectsWith(lbl2.Bounds))
            {
                tmrLeft1.Enabled = false;
                tmrLeft2.Enabled = true;
            }
        }

        private void tmrLeft0_Tick(object sender, EventArgs e)
        {
            lbl0.Left += 4;

            if (lbl0.Bounds.IntersectsWith(lbl1.Bounds))
            {
                tmrLeft0.Enabled = false;
                tmrLeft1.Enabled = true;
            }
        }
    }
}
