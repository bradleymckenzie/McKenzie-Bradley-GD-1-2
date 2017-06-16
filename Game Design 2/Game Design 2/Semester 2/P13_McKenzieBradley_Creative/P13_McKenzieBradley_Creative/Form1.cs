using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_McKenzieBradley_Creative
{
    public partial class Form1 : Form
    {
        PictureBox[] cars = new PictureBox[8];
        int[] speed = new int[8];
        Random r = new Random();
        Label[] line = new Label[15];

        public Form1()
        {
            InitializeComponent();

            cars[0] = picCar0;
            cars[1] = picCar1;
            cars[2] = picCar2;
            cars[3] = picCar3;
            cars[4] = picCar4;
            cars[5] = picCar5;
            cars[6] = picCar6;
            cars[7] = picCar7;

            line[0] = lbl0;
            line[1] = lbl1;
            line[2] = lbl2;
            line[3] = lbl3;
            line[4] = lbl4;
            line[5] = lbl5;
            line[6] = lbl6;
            line[7] = lbl7;
            line[8] = lbl8;
            line[9] = lbl9;
            line[10] = lbl10;
            line[11] = lbl11;
            line[12] = lbl12;
            line[13] = lbl13;
            line[14] = lbl14;

            for (int i = 0; i < 8; i++)
            {
                speed[i] = r.Next(3) + 3;
            }
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            picRacecar.Left += 5;
            chkCrash();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            picRacecar.Left -= 5;
            chkCrash();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                {
                    if (e.KeyValue == 37)
                    {
                        tmrLeft.Enabled = true;
                        chkCrash();
                    }
                    if (e.KeyValue == 39)
                    {
                        tmrRight.Enabled = true;
                        chkCrash();
                    }
                    if (e.KeyValue == 32)
                    {
                        reset();
                    }

                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyValue == 37)
                {
                    tmrLeft.Enabled = false;
                }
                if (e.KeyValue == 39)
                {
                    tmrRight.Enabled = false;
                }
            }
        }

        private void tmrCars_Tick(object sender, EventArgs e)
        {

            for (int i = 0; i < 8; i++)
            {
                cars[i].Top += speed[i];
                if (cars[i].Top > this.Height)
                {
                    cars[i].Top = -r.Next(this.Height);
                    speed[i] = r.Next(3) + 3;
                }
            }
            chkOverLap();
        }

        private void reset()
        {
            for (int i = 0; i < 8; i++)
            {

                if (cars[i].Bounds.IntersectsWith(picRacecar.Bounds))
                {
                    tmrLine.Enabled = true;
                    tmrCars.Enabled = true;

                    cars[0].Top = 9;
                    cars[0].Left = 21;
                    cars[1].Top = 9;
                    cars[1].Left = 21;
                    cars[2].Top = 9;
                    cars[2].Left = 21;
                    cars[3].Top = 9;
                    cars[3].Left = 21;

                    cars[4].Top = 9;
                    cars[4].Left = 89;
                    cars[5].Top = 9;
                    cars[5].Left = 89;
                    cars[6].Top = 9;
                    cars[6].Left = 89;
                    cars[7].Top = 9;
                    cars[7].Left = 89;

                    picRacecar.Top = 495;
                    picRacecar.Left = 56;

                }
            }
        }
        private void chkCrash()
        {
            for (int i = 0; i < 8; i++)
            {

                if (cars[i].Bounds.IntersectsWith(picRacecar.Bounds))
                {
                    tmrLeft.Enabled = false;
                    tmrRight.Enabled = false;
                    tmrLine.Enabled = false;
                    tmrCars.Enabled = false;
                }

            }
        }

        private void tmrLine_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                line[i].Top += 10;
                if (line[i].Top > this.Height)
                {
                    line[i].Top = 0;
                    line[i].Left = 67;
                }
            }
        }

        private void chkOverLap()
        {

            for (int i = 0; i < 7; i++)
            {
                for (int j = 1; j < 8; j++)
                {
                    if (i != j)
                    {
                        if (cars[i].Bounds.IntersectsWith(cars[j].Bounds) && cars[i].Top < cars[j].Top)
                        {
                            cars[j].Top = cars[i].Top + 51;
                        }
                        else if(cars[i].Bounds.IntersectsWith(cars[j].Bounds) && cars[i].Top > cars[j].Top)
                        {
                            cars[i].Top = cars[j].Top + 51;
                        }
                    }
                }
            }
        }
    }
}