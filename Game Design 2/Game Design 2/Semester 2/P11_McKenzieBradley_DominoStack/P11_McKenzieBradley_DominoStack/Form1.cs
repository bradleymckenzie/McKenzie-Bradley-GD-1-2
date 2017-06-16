using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_McKenzieBradley_DominoStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            tmrRight5.Enabled = true;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            tmrLeft0.Enabled = true;
        }

        private void tmrRight0_Tick(object sender, EventArgs e)
        {
            lbl0.Top -= 4;

            lbl0.BackColor = Color.MediumSpringGreen;
            lbl1.BackColor = Color.HotPink;

            if (lbl0.Top < 20)
            {
                tmrRight0.Enabled = false;
                lbl0.BackColor = Color.HotPink;
            }
        }

        private void tmrRight1_Tick(object sender, EventArgs e)
        {
            lbl1.Top -= 4;

            lbl1.BackColor = Color.MediumSpringGreen;
            lbl2.BackColor = Color.HotPink;

            if (lbl1.Bounds.IntersectsWith(lbl0.Bounds))
            {
                tmrRight1.Enabled = false;
                tmrRight0.Enabled = true;            
            }
        }

        private void tmrRight2_Tick(object sender, EventArgs e)
        {
            lbl2.Top -= 4;

            lbl2.BackColor = Color.MediumSpringGreen;
            lbl3.BackColor = Color.HotPink;

            if (lbl2.Bounds.IntersectsWith(lbl1.Bounds))
            {
                tmrRight2.Enabled = false;
                tmrRight1.Enabled = true;
            }
        }

        private void tmrRight3_Tick(object sender, EventArgs e)
        {
            lbl3.Top -= 4;

            lbl3.BackColor = Color.MediumSpringGreen;
            lbl4.BackColor = Color.HotPink;

            if (lbl3.Bounds.IntersectsWith(lbl2.Bounds))
            {
                tmrRight3.Enabled = false;
                tmrRight2.Enabled = true;
            }
        }

        private void tmrRight4_Tick(object sender, EventArgs e)
        {
            lbl4.Top -= 4;

            lbl4.BackColor = Color.MediumSpringGreen;
            lbl5.BackColor = Color.HotPink;

            if (lbl4.Bounds.IntersectsWith(lbl3.Bounds))
            {
                tmrRight4.Enabled = false;
                tmrRight3.Enabled = true;
            }
        }

        private void tmrRight5_Tick(object sender, EventArgs e)
        {
            lbl5.Top -= 4;

            lbl5.BackColor = Color.MediumSpringGreen;
            lbl0.BackColor = Color.HotPink;

            if (lbl5.Bounds.IntersectsWith(lbl4.Bounds))
            {
                tmrRight5.Enabled = false;
                tmrRight4.Enabled = true;
            }
        }

        private void tmrLeft5_Tick(object sender, EventArgs e)
        {
            lbl5.Top += 4;

            lbl5.BackColor = Color.MediumSpringGreen;
            lbl4.BackColor = Color.HotPink;

            if (lbl5.Top > 198)
            {
                tmrLeft5.Enabled = false;
                lbl5.BackColor = Color.HotPink;

            }
        }

        private void tmrLeft4_Tick(object sender, EventArgs e)
        {
            lbl4.Top += 4;

            lbl4.BackColor = Color.MediumSpringGreen;
            lbl3.BackColor = Color.HotPink;

            if (lbl4.Bounds.IntersectsWith(lbl5.Bounds))
            {
                tmrLeft4.Enabled = false;
                tmrLeft5.Enabled = true;
            }
        }

        private void tmrLeft3_Tick(object sender, EventArgs e)
        {
            lbl3.Top += 4;

            lbl3.BackColor = Color.MediumSpringGreen;
            lbl2.BackColor = Color.HotPink;

            if (lbl3.Bounds.IntersectsWith(lbl4.Bounds))
            {
                tmrLeft3.Enabled = false;
                tmrLeft4.Enabled = true;
            }
        }

        private void tmrLeft2_Tick(object sender, EventArgs e)
        {
            lbl2.Top += 4;

            lbl2.BackColor = Color.MediumSpringGreen;
            lbl1.BackColor = Color.HotPink;

            if (lbl2.Bounds.IntersectsWith(lbl3.Bounds))
            {
                tmrLeft2.Enabled = false;
                tmrLeft3.Enabled = true;
            }
        }

        private void tmrLeft1_Tick(object sender, EventArgs e)
        {
            lbl1.Top += 4;

            lbl1.BackColor = Color.MediumSpringGreen;
            lbl0.BackColor = Color.HotPink;

            if (lbl1.Bounds.IntersectsWith(lbl2.Bounds))
            {
                tmrLeft1.Enabled = false;
                tmrLeft2.Enabled = true;
            }
        }

        private void tmrLeft0_Tick(object sender, EventArgs e)
        {
            lbl0.Top += 4;

            lbl0.BackColor = Color.MediumSpringGreen;
           

            if (lbl0.Bounds.IntersectsWith(lbl1.Bounds))
            {
                tmrLeft0.Enabled = false;
                tmrLeft1.Enabled = true;
            }
        }
    }
}
