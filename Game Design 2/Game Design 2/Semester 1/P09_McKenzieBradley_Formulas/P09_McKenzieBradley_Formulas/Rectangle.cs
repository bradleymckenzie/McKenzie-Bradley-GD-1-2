﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_McKenzieBradley_Formulas
{
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLength.Text = "";
            txtWidth.Text = "";
            lblPerimeter.Text = "";
            lblArea.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double w;
            double l;
            double p;
            double a;
            

            l = Double.Parse(txtLength.Text);
            w = Double.Parse(txtWidth.Text);


            p = (w * 2) + (l * 2);
            a = w * l;

            lblPerimeter.Text = p.ToString();
            lblArea.Text = a.ToString();
        }
    }
}