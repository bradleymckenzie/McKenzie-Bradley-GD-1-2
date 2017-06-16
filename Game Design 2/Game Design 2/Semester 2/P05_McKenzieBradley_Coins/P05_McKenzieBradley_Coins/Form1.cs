using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05_McKenzieBradley_Coins
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int penny;
            int nickel;
            int dime;
            int quarter;
            int halfdooler;
            int dooler;
            double total;

            penny = int.Parse(txtPenny.Text) * 1;
            nickel = int.Parse(txtNickel.Text) * 5;
            dime = int.Parse(txtDime.Text) * 10;
            quarter = int.Parse(txtQuarter.Text) * 25;
            halfdooler = int.Parse(txtHalfDooler.Text) * 50;
            dooler = int.Parse(txtDooler.Text) * 100;
            total = (penny + nickel + dime + quarter + halfdooler + dooler) / 100.0;

            lblTotal.Text = "$" + total.ToString();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtPenny.Text = "";
            txtNickel.Text = "";
            txtDime.Text = "";
            txtQuarter.Text = "";
            txtHalfDooler.Text = "";
            txtDooler.Text = "";
            lblTotal.Text = "";
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
