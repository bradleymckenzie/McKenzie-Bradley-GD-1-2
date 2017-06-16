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
    public partial class Paraellelogram : Form
    {
        public Paraellelogram()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBase.Text = "";
            txtHeight.Text = "";
            lblPerimeter.Text = "";
            lblArea.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double b;
            double h;
            double p;
            double a;

            b = Double.Parse(txtBase.Text);
            h = Double.Parse(txtHeight.Text);


            p = (b * 2) + (h * 2);  
            a = (b * h);

            lblPerimeter.Text = p.ToString();
            lblArea.Text = a.ToString();
        }
    }
}
