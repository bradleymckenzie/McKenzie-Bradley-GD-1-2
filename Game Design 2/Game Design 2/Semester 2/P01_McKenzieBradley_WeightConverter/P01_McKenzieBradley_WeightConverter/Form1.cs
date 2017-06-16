using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_McKenzieBradley_WeightConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int pounds;
            double ounces;
            double grams;
            double kilograms;
            double tons;

            pounds = int.Parse(txtPounds.Text);
            ounces = pounds * 16;
            grams = pounds * 453.6;
            kilograms = pounds * 0.4536;
            tons = pounds * 0.0005;

            lblOunces.Text = ounces.ToString();
            lblGrams.Text = grams.ToString();
            lblKilograms.Text = kilograms.ToString();
            lblTons.Text = tons.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPounds.Text = "";
            lblOunces.Text = "";
            lblGrams.Text = "";
            lblKilograms.Text = "";
            lblTons.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
