using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P11_McKenzieBradley_ID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnKing_Click(object sender, EventArgs e)
        {

            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen penBlack = new Pen(Color.Black, 10);
            Pen penRed = new Pen(Color.Red, 6);


             //K
             g.DrawLine(penBlack, 100, 100, 100, 200);
             g.DrawLine(penBlack, 150, 100, 100, 150);
             g.DrawLine(penBlack, 100, 150, 150, 200);

             //I
             g.DrawLine(penBlack, 200, 100, 250, 100);
             g.DrawLine(penBlack, 225, 100, 225, 200);
             g.DrawLine(penBlack, 200, 200, 250, 200);

             //N
             g.DrawLine(penBlack, 300, 100, 300, 200);
             g.DrawLine(penBlack, 300, 100, 350, 200);
             g.DrawLine(penBlack, 350, 200, 350, 100);

             //G
             g.DrawLine(penBlack, 450, 120, 450, 100);
             g.DrawLine(penBlack, 450, 100, 400, 100);
             g.DrawLine(penBlack, 400, 100, 400, 200);
             g.DrawLine(penBlack, 400, 200, 450, 200);
             g.DrawLine(penBlack, 450, 200, 450, 150);
             g.DrawLine(penBlack, 450, 200, 425, 150);


            //K
            g.DrawLine(penRed, 100, 100, 100, 200);
            g.DrawLine(penRed, 150, 100, 100, 150);
            g.DrawLine(penRed, 100, 150, 150, 200);

            //I
            g.DrawLine(penRed, 200, 100, 250, 100);
            g.DrawLine(penRed, 225, 100, 225, 200);
            g.DrawLine(penRed, 200, 200, 250, 200);

            //N
            g.DrawLine(penRed, 300, 100, 300, 200);
            g.DrawLine(penRed, 300, 100, 350, 200);
            g.DrawLine(penRed, 350, 200, 350, 100);

            //G
            g.DrawLine(penRed, 450, 120, 450, 100);
            g.DrawLine(penRed, 450, 100, 400, 100);
            g.DrawLine(penRed, 400, 100, 400, 200);
            g.DrawLine(penRed, 400, 200, 450, 200);
            g.DrawLine(penRed, 450, 200, 450, 150);
            g.DrawLine(penRed, 450, 200, 425, 150);
            
        }

        private void btnID_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen penRed = new Pen(Color.Red, 6);
            Pen penBlack = new Pen(Color.Black, 10);

            //2
            g.DrawLine(penBlack, 100, 100, 100, 150);
            g.DrawLine(penBlack, 50, 100, 100, 100);
            g.DrawLine(penBlack, 50, 150, 100, 150);
            g.DrawLine(penBlack, 50, 150, 50, 200);
            g.DrawLine(penBlack, 50, 200, 100, 200);

            //8
            g.DrawLine(penBlack, 150, 100, 150, 200);
            g.DrawLine(penBlack, 200, 100, 200, 200);
            g.DrawLine(penBlack, 150, 100, 200, 100);
            g.DrawLine(penBlack, 150, 150, 200, 150);
            g.DrawLine(penBlack, 150, 200, 200, 200);

            //1
            g.DrawLine(penBlack, 250, 200, 300, 200);
            g.DrawLine(penBlack, 275, 100, 275, 200);
            g.DrawLine(penBlack, 250, 100, 275, 100);

            //4
            g.DrawLine(penBlack, 350, 100, 350, 150);
            g.DrawLine(penBlack, 400, 100, 400, 200);
            g.DrawLine(penBlack, 350, 150, 400, 150);

            //9
            g.DrawLine(penBlack, 450, 100, 450, 150);
            g.DrawLine(penBlack, 500, 100, 500, 200);
            g.DrawLine(penBlack, 450, 100, 500, 100);
            g.DrawLine(penBlack, 450, 150, 500, 150);

            //4
            g.DrawLine(penBlack, 600, 100, 600, 200);
            g.DrawLine(penBlack, 550, 150, 600, 150);
            g.DrawLine(penBlack, 550, 100, 550, 150);


            //2 
            g.DrawLine(penRed, 100, 100, 100, 150);
            g.DrawLine(penRed, 50, 100, 100, 100);
            g.DrawLine(penRed, 50, 150, 100, 150);
            g.DrawLine(penRed, 50, 150, 50, 200);
            g.DrawLine(penRed, 50, 200, 100, 200);

            //8
            g.DrawLine(penRed, 150, 100, 150, 200);
            g.DrawLine(penRed, 200, 100, 200, 200);
            g.DrawLine(penRed, 150, 100, 200, 100);
            g.DrawLine(penRed, 150, 150, 200, 150);
            g.DrawLine(penRed, 150, 200, 200, 200);

            //1
            g.DrawLine(penRed, 250, 200, 300, 200);
            g.DrawLine(penRed, 275, 100, 275, 200);
            g.DrawLine(penRed, 250, 100, 275, 100);

            //4
            g.DrawLine(penRed, 350, 100, 350, 150);
            g.DrawLine(penRed, 400, 100, 400, 200);
            g.DrawLine(penRed, 350, 150, 400, 150);

            //9
            g.DrawLine(penRed, 450, 100, 450, 150);
            g.DrawLine(penRed, 500, 100, 500, 200);
            g.DrawLine(penRed, 450, 100, 500, 100);
            g.DrawLine(penRed, 450, 150, 500, 150);

            //4
            g.DrawLine(penRed, 600, 100, 600, 200);
            g.DrawLine(penRed, 550, 150, 600, 150);
            g.DrawLine(penRed, 550, 100, 550, 150);



           
        }

        private void btnTriangles_Click(object sender, EventArgs e)
        {
            this.Refresh();
            Graphics g = this.CreateGraphics();
            Pen penRed = new Pen(Color.Red, 3);
            Pen penBlack = new Pen(Color.Black, 10);

            //Obtuse
            g.DrawLine(penRed, 50, 100, 100, 150);
            g.DrawLine(penRed, 50, 100, 150, 150);
            g.DrawLine(penRed, 100, 150, 150, 150);

            //Right
            g.DrawLine(penRed, 200, 100, 200, 150);
            g.DrawLine(penRed, 200, 150, 250, 150);
            g.DrawLine(penRed, 200, 100, 250, 150);

            //Equilteral
            g.DrawLine(penRed, 300, 150, 350, 150);
            g.DrawLine(penRed, 325, 100, 350, 150);
            g.DrawLine(penRed, 325, 100, 300, 150);

            //Isocelles
            g.DrawLine(penRed, 400, 175, 450, 175);
            g.DrawLine(penRed, 400, 175, 425, 100);
            g.DrawLine(penRed, 450, 175, 425, 100);

            //Scalene
            g.DrawLine(penRed, 500, 150, 525, 100);
            g.DrawLine(penRed, 500, 150, 575, 150);
            g.DrawLine(penRed, 525, 100, 575, 150);
        }
    }
}
