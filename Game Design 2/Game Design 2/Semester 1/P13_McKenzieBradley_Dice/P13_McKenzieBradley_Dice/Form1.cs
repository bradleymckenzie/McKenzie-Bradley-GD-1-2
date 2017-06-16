using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_McKenzieBradley_Dice
{
    public partial class Form1 : Form

    {
        int dots;
        int dots2;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penBlack = new Pen(Color.Black, 3);
            Random r = new Random();
            dots = r.Next(6) + 1;


            //Dice 1
            g.DrawRectangle(penBlack, 50, 50, 200, 200);
            g.FillRectangle(Brushes.White, 50, 50, 200, 200);

            if(dots == 3 || dots == 4 || dots == 5 || dots == 6)
            {
                g.DrawEllipse(penBlack, 70, 70, 40, 40); //dot 1
                g.FillEllipse(Brushes.Black, 70, 70, 40, 40); //dot 1
            }

            if(dots == 2 || dots == 4 || dots == 5 || dots == 6)
            {
                g.DrawEllipse(penBlack, 190, 70, 40, 40); //dot 2
                g.FillEllipse(Brushes.Black, 190, 70, 40, 40); //dot 2
            }
             
            if(dots == 6)
            {
               g.DrawEllipse(penBlack, 70, 130, 40, 40); //dot 3
               g.FillEllipse(Brushes.Black, 70, 130, 40, 40); //dot 3
            }

            if(dots == 1 || dots == 3 || dots == 5)
            {
              g.DrawEllipse(penBlack, 130, 130, 40, 40); //dot 4
              g.FillEllipse(Brushes.Black, 130, 130, 40, 40); //dot 4
             }

            if(dots == 6)
            {
              g.DrawEllipse(penBlack, 190, 130, 40, 40); //dot 5
              g.FillEllipse(Brushes.Black, 190, 130, 40, 40); //dot 5
            }

            if(dots == 2 || dots == 4 || dots == 5 || dots == 6)
             {
             g.DrawEllipse(penBlack, 70, 190, 40, 40); //dot 6
             g.FillEllipse(Brushes.Black, 70, 190, 40, 40); //dot 6
             }

            if (dots == 3 || dots == 4 || dots == 5 || dots == 6)
            {
             g.DrawEllipse(penBlack, 190, 190, 40, 40); //dot 7
             g.FillEllipse(Brushes.Black, 190, 190, 40, 40); //dot 7
            }

            dots2 = r.Next(6) + 1;

            //Dice 2
            g.DrawRectangle(penBlack, 300, 50, 200, 200);
            g.FillRectangle(Brushes.White, 300, 50, 200, 200);

            if (dots2 == 3 || dots2 == 4 || dots2 == 5 || dots2 == 6)
            {
                g.DrawEllipse(penBlack, 320, 70, 40, 40); //dot 1
                g.FillEllipse(Brushes.Black, 320, 70, 40, 40); //dot 1
            }

            if (dots2 == 2 || dots2 == 4 || dots2 == 5 || dots2 == 6)
            {
                g.DrawEllipse(penBlack, 440, 70, 40, 40); //dot 2
                g.FillEllipse(Brushes.Black, 440, 70, 40, 40); //dot 2
            }

            if (dots2 == 6)
            {
                g.DrawEllipse(penBlack, 320, 130, 40, 40); //dot 3
                g.FillEllipse(Brushes.Black, 320, 130, 40, 40); //dot 3
            }

            if (dots2 == 1 || dots2 == 3 || dots2 == 5)
            {
                g.DrawEllipse(penBlack, 380, 130, 40, 40); //dot 4
                g.FillEllipse(Brushes.Black, 380, 130, 40, 40); //dot 4
            }

            if (dots2 == 6)
            {
                g.DrawEllipse(penBlack, 440, 130, 40, 40); //dot 5
                g.FillEllipse(Brushes.Black, 440, 130, 40, 40); //dot 5
            }

            if (dots2 == 2 || dots2 == 4 || dots2 == 5 || dots2 == 6)
            {
                g.DrawEllipse(penBlack, 320, 190, 40, 40); //dot 6
                g.FillEllipse(Brushes.Black, 320, 190, 40, 40); //dot 6
            }

            if (dots2 == 3 || dots2 == 4 || dots2 == 5 || dots2 == 6)
            {
                g.DrawEllipse(penBlack, 440, 190, 40, 40); //dot 7
                g.FillEllipse(Brushes.Black, 440, 190, 40, 40); //dot 7
            }
        }
    }
}
