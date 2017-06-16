using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02_McKenzieBradley_Liquids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cups;
            double gallons;
            double quarts;
            double pints;
            double ounces;
            double tables;
            double teas;

            cups = int.Parse(txtCups.Text);
            gallons = cups * .0625;
            quarts = cups * .25;
            pints = cups * .5;
            ounces = cups * 8;
            tables = cups * 16;
            teas = cups * 48;

            lblGallons.Text = gallons.ToString();
            lblQuarts.Text = quarts.ToString();
            lblPints.Text = pints.ToString();
            lblOunces.Text = ounces.ToString();
            lblTableSpoons.Text = tables.ToString();
            lblTeaSpoons.Text = teas.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCups.Text = "";
            lblGallons.Text = "";
            lblQuarts.Text = "";
            lblPints.Text = "";
            lblOunces.Text = "";
            lblTableSpoons.Text = "";
            lblTeaSpoons.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
