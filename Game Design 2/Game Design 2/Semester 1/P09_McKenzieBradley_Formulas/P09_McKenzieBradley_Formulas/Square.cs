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
    public partial class Square : Form
    {
        public Square()
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
            txtLength.Text = "";
            lblPerimeter.Text = "";
            lblArea.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double l;
            double p;
            double a;


            l = Double.Parse(txtLength.Text);


            p = (l * 4);
            a = l * l;

            lblPerimeter.Text = p.ToString();
            lblArea.Text = a.ToString();
        }
    }
}
