using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P26_McKenzieBradley_IDK
{
    public partial class Form1 : Form
    {
        Label[] rainbow = new Label[12];

        public Form1()
        {
            InitializeComponent();
            rainbow[0] = lbl0;
            rainbow[1] = lbl1;
            rainbow[2] = lbl2;
            rainbow[3] = lbl3;
            rainbow[4] = lbl4;
            rainbow[5] = lbl5;
            rainbow[6] = lbl6;
            rainbow[7] = lbl7;
            rainbow[8] = lbl8;
            rainbow[9] = lbl9;
            rainbow[10] = lbl10;
            rainbow[11] = lbl11;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrRainbow_Tick(object sender, EventArgs e)
        {
            for (int r = 0; r <= 11; r++)
            {
                rainbow[r].Left += 25;
                if (rainbow[r].Left >= 330)
                {
                    rainbow[r].Left = 5;
                }
            }
        }
    }
}
