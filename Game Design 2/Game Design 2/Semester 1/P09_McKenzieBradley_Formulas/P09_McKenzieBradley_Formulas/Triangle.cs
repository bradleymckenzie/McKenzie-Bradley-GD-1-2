using System;
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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double b;
            double p;
            double aa;
            double a;
            double c;

            b = Double.Parse(txtBase.Text);
            a = Double.Parse(txtHeight.Text);
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            p = a + b + c;
            aa = (a * b * .5);

            lblPerimeter.Text = p.ToString();
            lblArea.Text = aa.ToString();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtHeight.Text = "";
            lblPerimeter.Text = "";
            lblArea.Text = "";
        }

    }
}
