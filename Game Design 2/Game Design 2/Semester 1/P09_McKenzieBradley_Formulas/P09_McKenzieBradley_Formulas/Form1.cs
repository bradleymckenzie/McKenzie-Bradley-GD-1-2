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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void lblCircle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            this.Hide();
            circle.Show();
        }

        private void lblRectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            this.Hide();
            rectangle.Show();
        }

        private void lblSquare_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            this.Hide();
            square.Show();
        }

        private void lblTriange_Click(object sender, EventArgs e)
        {
            Triangle triangle = new Triangle();
            this.Hide();
            triangle.Show();
        }

        private void lblParallelogram_Click_1(object sender, EventArgs e)
        {
            Paraellelogram parallelogram = new Paraellelogram();
            this.Hide();
            parallelogram.Show();
        }
    }
}
