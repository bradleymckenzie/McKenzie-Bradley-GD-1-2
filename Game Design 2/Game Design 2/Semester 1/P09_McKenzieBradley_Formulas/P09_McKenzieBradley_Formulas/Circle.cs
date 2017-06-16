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
    public partial class Circle : Form
    {
        public Circle()
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
            txtRadius.Text = "";
            lblCircumference.Text = "";
            lblArea.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double r;
            double c;
            double a;

            r = Double.Parse(txtRadius.Text);

            c =  2 * r * 3.14;
            a = (r * r) * 3 ;

            lblCircumference.Text = c.ToString();
            lblArea.Text = a.ToString();
        }
    }
}
