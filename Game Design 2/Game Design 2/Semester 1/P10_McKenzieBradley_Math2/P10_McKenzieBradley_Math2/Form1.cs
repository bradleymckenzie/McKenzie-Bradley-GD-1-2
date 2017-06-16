using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_McKenzieBradley_Math2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = " ";
            lblAV.Text = " ";
            lblHV.Text = " ";
            lblSR.Text = " ";
            lblSquare.Text = " ";
            lblCube.Text = " ";
            lblEven.Text = " ";
            lblPositive.Text = " ";
            lblNegative.Text = " ";
            lblSin.Text = " ";
            lblCos.Text = " ";
            lblTangent.Text = " ";
            lblOdd.Text = " ";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double number;

            number = Double.Parse(txtNumber.Text);

	
            //Absolute  Value
            lblAV.Text = Math.Abs(number).ToString();
            //Half Value
            lblHV.Text = halfValue(number).ToString();
            //Square Root
            lblSR.Text = Math.Sqrt(number).ToString();
            //Square
            lblSquare.Text = Math.Pow(number, 2).ToString();
            //Cube
            lblCube.Text = Math.Pow(number, 3).ToString();
            //Even
            lblEven.Text = isOddEven(number).ToString();
            //Positive
            lblPositive.Text = isPosNeg(number).ToString();
            //Negative
            lblNegative.Text = isPosNeg(number).ToString();
            //Sine
            lblSin.Text = Math.Sin(number).ToString();
            //Cosine
            lblCos.Text = Math.Cos(number).ToString();
            //Tangent
            lblTangent.Text = Math.Tan(number).ToString();
            //Odd
            lblOdd.Text = isOddEven(number).ToString();
        }
            double halfValue(double n)
            {
                return n / 2.0;
            }


           string isOddEven(double n)
		    {
			if(n % 2 == 0)
			{
			return "YES";
			}
			else
			{
			return "NO";
			}
		}
            string isPosNeg(double n)
			{
			if (n > 0)
			{
			return "YES";
			}
			else if (n < 0)
			{
                return "NO";
            }
            else
            {
			return "NEUTRAL";
			}
       }
    }
}