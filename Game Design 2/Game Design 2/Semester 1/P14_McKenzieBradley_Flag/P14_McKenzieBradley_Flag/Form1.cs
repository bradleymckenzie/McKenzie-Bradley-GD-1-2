using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_McKenzieBradley_Flag
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

        private void btnDraw_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen penRed = new Pen(Color.Red, 3);
            Pen penWhite = new Pen(Color.White, 3);
            Pen penBlue = new Pen(Color.Blue, 3);
            Font star = new Font("courier", 32);

            //red and white stripes

            for(int y = 51; y <= 375; y += 25)
            {
                if (y % 2 == 1)
                {
                    g.FillRectangle(Brushes.Red, 50, y, 525, 25);
                }
                else
                {
                    g.FillRectangle(Brushes.White, 50, y, 525, 25);

                    //blue background
                    g.FillRectangle(Brushes.Blue, 50, 50, 200, 175);
                }
            }

           //star field of 30
           
                for(int x = 55; x <= 205; x += 30)
                  {
                   for(int y = 50; y <= 200; y += 35)
                   {
                    g.DrawString("*", star , Brushes.White, x, y);
                   }
                }
            //star field of 20 
       
                for(int x = 70; x <= 190; x += 30)
                  {
                   for (int y = 64; y <= 170; y += 35)
                   {
                    g.DrawString("*", star , Brushes.White, x, y);
                   }
                }
            }
        }
    }
