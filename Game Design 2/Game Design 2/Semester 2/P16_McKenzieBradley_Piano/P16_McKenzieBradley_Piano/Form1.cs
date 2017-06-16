using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P16_McKenzieBradley_Piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            lblC1.BackColor = Color.White;
            lblD1.BackColor = Color.White;
            lblE1.BackColor = Color.White;
            lblF1.BackColor = Color.White;
            lblG1.BackColor = Color.White;
            lblA1.BackColor = Color.White;
            lblB1.BackColor = Color.White;
            lblC2.BackColor = Color.White;
            lblD2.BackColor = Color.White;
            lblE2.BackColor = Color.White;
            lblF2.BackColor = Color.White;
            lblG2.BackColor = Color.White;
            lblA2.BackColor = Color.White;
            lblB2.BackColor = Color.White;

            lblC31.BackColor = ColorTranslator.FromHtml("#222222");
            lblD31.BackColor = ColorTranslator.FromHtml("#222222");
            lblF31.BackColor = ColorTranslator.FromHtml("#222222");
            lblG31.BackColor = ColorTranslator.FromHtml("#222222");
            lblA31.BackColor = ColorTranslator.FromHtml("#222222");
            lblC32.BackColor = ColorTranslator.FromHtml("#222222");
            lblD32.BackColor = ColorTranslator.FromHtml("#222222");
            lblF32.BackColor = ColorTranslator.FromHtml("#222222");
            lblG32.BackColor = ColorTranslator.FromHtml("#222222");
            lblA32.BackColor = ColorTranslator.FromHtml("#222222");

        }

        private void btnA_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblC1.BackColor = Color.GreenYellow;
            lblD1.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
        }

        private void btnB_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblB1.BackColor = Color.GreenYellow;
            lblD32.BackColor = Color.GreenYellow;
            lblF32.BackColor = Color.GreenYellow;
        }

        private void btnC_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblC1.BackColor = Color.GreenYellow;
            lblE1.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
        }

        private void btnD_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblD1.BackColor = Color.GreenYellow;
            lblF31.BackColor = Color.GreenYellow;
            lblA1.BackColor = Color.GreenYellow;
        }

        private void btnE_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblE1.BackColor = Color.GreenYellow;
            lblG31.BackColor = Color.GreenYellow;
            lblB1.BackColor = Color.GreenYellow;
        }

        private void btnF_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblF1.BackColor = Color.GreenYellow;
            lblA1.BackColor = Color.GreenYellow;
            lblC2.BackColor = Color.GreenYellow;
        }

        private void btnG_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblG1.BackColor = Color.GreenYellow;
            lblB1.BackColor = Color.GreenYellow;
            lblD2.BackColor = Color.GreenYellow;
        }

        private void btnAm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblA1.BackColor = Color.GreenYellow;
            lblC2.BackColor = Color.GreenYellow;
            lblE2.BackColor = Color.GreenYellow;
        }

        private void btnBm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblB2.BackColor = Color.GreenYellow;
            lblD1.BackColor = Color.GreenYellow;
            lblG31.BackColor = Color.GreenYellow;
        }

        private void btnCm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblC1.BackColor = Color.GreenYellow;
            lblD31.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
        }

        private void btnDm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblD1.BackColor = Color.GreenYellow;
            lblF1.BackColor = Color.GreenYellow;
            lblA1.BackColor = Color.GreenYellow;
        }

        private void btnEm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblE1.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
            lblB1.BackColor = Color.GreenYellow;
        }

        private void btnFm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblF1.BackColor = Color.GreenYellow;
            lblG31.BackColor = Color.GreenYellow;
            lblC2.BackColor = Color.GreenYellow;
        }

        private void btnGm_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblG1.BackColor = Color.GreenYellow;
            lblA31.BackColor = Color.GreenYellow;
            lblD2.BackColor = Color.GreenYellow;
        }

        private void btnA7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblB2.BackColor = Color.GreenYellow;
            lblC31.BackColor = Color.GreenYellow;
            lblE1.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
        }

        private void btnB7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblB2.BackColor = Color.GreenYellow;
            lblD31.BackColor = Color.GreenYellow;
            lblF31.BackColor = Color.GreenYellow;
            lblA31.BackColor = Color.GreenYellow;
        }

        private void btnC7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblC1.BackColor = Color.GreenYellow;
            lblE1.BackColor = Color.GreenYellow;
            lblG1.BackColor = Color.GreenYellow;
            lblA31.BackColor = Color.GreenYellow;
        }

        private void btnD7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblD1.BackColor = Color.GreenYellow;
            lblF31.BackColor = Color.GreenYellow;
            lblA1.BackColor = Color.GreenYellow;
            lblC2.BackColor = Color.GreenYellow;
        }

        private void btnE7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblE1.BackColor = Color.GreenYellow;
            lblG31.BackColor = Color.GreenYellow;
            lblB1.BackColor = Color.GreenYellow;
            lblD2.BackColor = Color.GreenYellow;
        }

        private void btnF7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblF1.BackColor = Color.GreenYellow;
            lblA1.BackColor = Color.GreenYellow;
            lblC2.BackColor = Color.GreenYellow;
            lblD32.BackColor = Color.GreenYellow;
        }

        private void btnG7_CheckedChanged(object sender, EventArgs e)
        {
            reset();
            lblG1.BackColor = Color.GreenYellow;
            lblB1.BackColor = Color.GreenYellow;
            lblD2.BackColor = Color.GreenYellow;
            lblF2.BackColor = Color.GreenYellow;
        }  
    }
}
