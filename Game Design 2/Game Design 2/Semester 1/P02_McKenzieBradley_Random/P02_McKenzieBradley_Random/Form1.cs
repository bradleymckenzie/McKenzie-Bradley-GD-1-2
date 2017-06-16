using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_McKenzieBradley_Random
{
    public partial class Form1 : Form
    {   
        int score;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblFace_Click(object sender, EventArgs e)
        {
            if (pbrGame.Value > 0)
            {

                // code for random location of face
                Random r = new Random();
                int x;
                int y;

                x = r.Next(this.Width - lblFace.Width);
                y = r.Next(this.Width - lblFace.Height);


                lblFace.Left = x;
                lblFace.Top = y;

                //code for score
                {
                    score += 1;
                    lblScore.Text = score.ToString();
                }
            }
        }

        private void tmrPlay_Tick(object sender, EventArgs e)
        {
            if (pbrGame.Value > 0)
            {
                pbrGame.Value -= 1;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            pbrGame.Value = 100;
            score = 0;
            lblScore.Text = score.ToString();


            Random r = new Random();
            int x;
            int y;

            x = r.Next(this.Width - lblFace.Width);
            y = r.Next(this.Width - lblFace.Height);


            lblFace.Left = x;
            lblFace.Top = y;
        }
    }
}
