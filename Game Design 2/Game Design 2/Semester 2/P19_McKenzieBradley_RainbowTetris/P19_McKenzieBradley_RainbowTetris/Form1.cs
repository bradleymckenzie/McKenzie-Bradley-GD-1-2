using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P19_McKenzieBradley_RainbowTetris
{
    public partial class Form1 : Form
    {
        Label[] boxes = new Label[6];

        public Form1()
        {
            InitializeComponent();

            boxes[0] = lbl0;
            boxes[1] = lbl1;
            boxes[2] = lbl2;
            boxes[3] = lbl3;
            boxes[4] = lbl4;
            boxes[5] = lbl5;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyValue == 37)
                {
                lblBox.Left = lblBox.Left - 25;
                }
                if (e.KeyValue == 39)
                {
                lblBox.Left = lblBox.Left + 25;
                }
                if (e.KeyValue == 40)
                {
                lblBox.Top = 225;
                checkBoxColors();
                }
                if (e.KeyValue == 32)
                {
                    lblTime.Text = "30";
                    lblScore.Text = "0";
                    tmrFall.Enabled = true;
                    tmrGo.Enabled = true;
                    lblBox.Top = 25;
                    lblBox.Left = 125;
                    lblBox.Visible = true;
                    lblBegin.Visible = false;
                }
            }
        }

        private void colorChange()
        {
            int x;
            Random r = new Random();
            for(int c = 0; c <= 5; c++)
            {
                x = r.Next(6);
                lblBox.BackColor = boxes[x].BackColor;
            }
        }

        private void checkBoxColors()
        {
            if (lblBox.Top == 225)
            {
                for (int i = 0; i <= 5; i++)
                {
                    if (lblBox.Left == boxes[i].Left && lblBox.Top == boxes[i].Top)
                    {
                        lblScore.Text = (int.Parse(lblScore.Text) + 1).ToString();
                    }
                }
                lblBox.Left = 125;
                lblBox.Top = 25;
                colorChange();
            }
        }

        private void tmrGo_Tick(object sender, EventArgs e)
        {
            if(int.Parse(lblTime.Text) > 0)
            {
                lblTime.Text = (int.Parse(lblTime.Text) - 1).ToString();
            }
            else
            {
                tmrGo.Enabled = false;
                tmrFall.Enabled = false;
            }
        }

        private void tmrFall_Tick(object sender, EventArgs e)
        {
            lblBox.Top += 25;
            checkBoxColors();
        }
    }
}
