using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P15_McKenzieBradley_KidPix
{
    public partial class Form1 : Form
    {
        string chr;
        SolidBrush myBrush = new SolidBrush(Color.Red);
        Color myColor = (Color.Red);
        Font myFont = new Font("wingdings", 20);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            int x = e.X - 15;
            int y = e.Y - 15;

            g.DrawString(chr, myFont, myBrush, x, y);
        }

        private void btnJet_Click(object sender, EventArgs e)
        {
            chr = btnJet.Text;

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            chr = btnPhone.Text;
        }

        private void btnBomb_Click(object sender, EventArgs e)
        {
            chr = btnBomb.Text;
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            chr = btnPencil.Text;
        }

        private void btnDeadguy_Click(object sender, EventArgs e)
        {
            chr = btnDeadguy.Text;
        }

        private void btnSissors_Click(object sender, EventArgs e)
        {
            chr = btnSissors.Text;
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            chr = btnCross.Text;
        }

        private void btnGlasses_Click(object sender, EventArgs e)
        {
            chr = btnGlasses.Text;
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            chr = btnStar.Text;
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            chr = btnMouse.Text;
        }

        private void btnThumb_Click(object sender, EventArgs e)
        {
            chr = btnThumb.Text;
        }

        private void btnPeace_Click(object sender, EventArgs e)
        {
            chr = btnPeace.Text;
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            chr = btnSun.Text;
        }

        private void btnHand_Click(object sender, EventArgs e)
        {
            chr = btnHand.Text;
        }

        private void btnTear_Click(object sender, EventArgs e)
        {
            chr = btnTear.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chr = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chr = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            chr = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chr = button4.Text;
        }

        private void btnBell_Click(object sender, EventArgs e)
        {
            chr = btnBell.Text;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Green;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
           myBrush.Color = Color.Blue;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            myBrush.Color = Color.Purple;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
                Application.Exit();
            
            if (e.KeyValue == 32) 
                this.Refresh();
        }
    }
}
