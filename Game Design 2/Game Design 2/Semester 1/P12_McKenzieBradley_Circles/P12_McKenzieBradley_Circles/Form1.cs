using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P12_McKenzieBradley_Circles
{
    public partial class Form1 : Form
    {
        
        Pen myPen = new Pen(Color.Red, 5);
        int x1;
        int xSize = 100;
        int y1;
        int ySize = 100;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            Pen penRed = new Pen(Color.Red, 5);
            myPen = penRed;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            Pen penBlue = new Pen(Color.Blue, 5);
            myPen = penBlue;

        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            Pen penGreen = new Pen(Color.Green, 5);
            myPen = penGreen;
        }

        private void btnOrange_Click(object sender, EventArgs e)
        {
            Pen penOrange = new Pen(Color.Orange, 5);
            myPen = penOrange;
        }

        private void btnPurple_Click(object sender, EventArgs e)
        {
            Pen penPurple = new Pen(Color.Purple, 5);
            myPen = penPurple;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();

            x1 = e.X - (xSize / 2);
            y1 = e.Y - (ySize / 2);

            g.DrawEllipse(myPen, x1, y1, xSize, ySize);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xSize = 50;
            ySize = 50;
        }

        private void miToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xSize = 100;
            ySize = 100;
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xSize = 200;
            ySize = 200;
        }
    }
}
