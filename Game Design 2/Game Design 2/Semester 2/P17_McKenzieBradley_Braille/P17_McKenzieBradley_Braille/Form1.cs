using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P17_McKenzieBradley_Braille
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void reset()
        {
            lbl0.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl4.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl4.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            reset();
            lbl1.Visible = true;
            lbl3.Visible = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            reset();
            lbl1.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl3.Visible = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl4.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl4.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            reset();
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            reset();
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl5.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl1.Visible = true;
            lbl2.Visible = true;
            lbl5.Visible = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            reset();
            lbl1.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl5.Visible = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            reset();
            lbl0.Visible = true;
            lbl2.Visible = true;
            lbl4.Visible = true;
            lbl5.Visible = true;
        }
    }
}
