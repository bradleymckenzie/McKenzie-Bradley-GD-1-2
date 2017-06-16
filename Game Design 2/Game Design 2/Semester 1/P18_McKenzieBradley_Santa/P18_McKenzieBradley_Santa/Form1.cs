using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P18_McKenzieBradley_Santa
{
    public partial class form : Form
    {
        PictureBox[] santaright = new PictureBox[6];
        int run;

        PictureBox[] santaleft = new PictureBox[6];

        PictureBox[] lights = new PictureBox[5];

        public form()
        {
            InitializeComponent();

            santaright[0] = pic0;
            santaright[1] = pic1;
            santaright[2] = pic2;
            santaright[3] = pic3;
            santaright[4] = pic4;
            santaright[5] = pic5;

            santaleft[0] = pic6;
            santaleft[1] = pic7;
            santaleft[2] = pic8;
            santaleft[3] = pic9;
            santaleft[4] = pic10;
            santaleft[5] = pic11;

            lights[0] = piclights0;
            lights[1] = piclights1;
            lights[2] = piclights2;
            lights[3] = piclights3;
            lights[4] = piclights4;
        }

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = true;
                tmrLightsLeft.Enabled = true;

            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = true;
                tmrLightsRight.Enabled = true;
            }

        }

        private void form_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = false;
                tmrLightsLeft.Enabled = false;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = false;
                tmrLightsRight.Enabled = false;
            }

        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            run += 1;
            if (run > 5)
            {
                run = 0;
            }
            picSanta.Image = santaright[run].Image;

        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            run += 1;
            if (run > 5)
            {
                run = 0;
            }
            picSanta.Image = santaleft[run].Image;

        }

        private void tmrLightsRight_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lights[i].Left -= 3;
                if (lights[i].Left < -185 && i > 0)
                {
                    lights[i].Left = lights[i-1].Left + 185;
                }
                else if (lights[i].Left < -185 && i == 0)
                {
                    lights[i].Left = lights[4].Left + 185;
                }
            }
        }
        private void tmrLightsLeft_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                lights[i].Left += 3;
                if (lights[i].Left > this.Width && i < 4)
                {
                    lights[i].Left = lights[i + 1].Left - 180;
                }
                else if (lights[i].Left > this.Width && i == 4)
                {
                    lights[i].Left = lights[0].Left - 180;
                }
            }
        }
    }
}