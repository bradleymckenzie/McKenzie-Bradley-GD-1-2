using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P08_McKenzieBradley_Salary
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
            txtHours.Text = " ";
            txtPay.Text = " ";
            lblGross.Text = " ";
            lblFederal.Text = " ";
            lblState.Text = " ";
            lblUnion.Text = " ";
            lblHealthcare.Text = " ";
            lblSS.Text = " ";
            lblNet.Text = " ";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hours;
            double pay;
            double gross;
            double federal;
            double state;
            double union;
            double health;
            double ss;
            double net;

            hours = Double.Parse(txtHours.Text);
            pay = Double.Parse(txtPay.Text);
            gross = hours * pay;
            federal = gross * 0.17;
            state = gross * 0.11;
            union = gross * 0.008;
            health = gross * 0.2;
            ss = gross * 0.08;
            net = gross - (federal + state + union + health + ss);

            lblGross.Text = gross.ToString();
            lblFederal.Text = federal.ToString();
            lblState.Text = state.ToString();
            lblUnion.Text = union.ToString();
            lblHealthcare.Text = health.ToString();
            lblSS.Text = ss.ToString();
            lblGross.Text = gross.ToString();
            lblFederal.Text = federal.ToString();
            lblNet.Text = net.ToString();
        }
    }
}
