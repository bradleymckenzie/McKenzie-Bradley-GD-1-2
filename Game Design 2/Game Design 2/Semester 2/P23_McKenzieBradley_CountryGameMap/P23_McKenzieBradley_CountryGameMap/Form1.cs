using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P23_McKenzieBradley_CountryGameMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = true;
            }
            if (e.KeyValue == 38)
            {
                tmrUp.Enabled = true;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = true;
            }
            if (e.KeyValue == 40)
            {
                tmrDown.Enabled = true;
            }
            if (e.KeyValue == 32)
            {
                
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 37)
            {
                tmrLeft.Enabled = false;
            }
            if (e.KeyValue == 38)
            {
                tmrUp.Enabled = false;
            }
            if (e.KeyValue == 39)
            {
                tmrRight.Enabled = false;
            }
            if (e.KeyValue == 40)
            {
                tmrDown.Enabled = false;
            }
            if (e.KeyValue == 32)
            {
               
            }
        }

        private void tmrRight_Tick(object sender, EventArgs e)
        {
            lblJetLarge.Left += 2;

            if (lblJetLarge.Left > 487)
            {
                lblJetLarge.Left = 487;
            }
            setJet();
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            lblJetLarge.Top += 2;

            if (lblJetLarge.Top > 487)
            {
                lblJetLarge.Top = 487;
            }
            setJet();
        }

        private void tmrLeft_Tick(object sender, EventArgs e)
        {
            lblJetLarge.Left -= 2;

            if (lblJetLarge.Left < 0)
            {
                lblJetLarge.Left = 0;
            }
            setJet();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            lblJetLarge.Top -= 2;

            if (lblJetLarge.Top < 0)
            {
                lblJetLarge.Top = 0;
            }
            setJet();
        }
        private void setJet()
        {
            lblJetSmall.Top = picMapSmall.Top + (lblJetLarge.Top / 5);
            lblJetSmall.Left = picMapSmall.Left + (lblJetLarge.Left / 5);
        }
    }
}
