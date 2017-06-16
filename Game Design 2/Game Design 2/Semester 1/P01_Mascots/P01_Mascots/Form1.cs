using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01_Mascots
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnArlington_Click(object sender, EventArgs e)
        {
            txtMascot.Text = " Lion";
            txtColor.Text = " Maroon & Gold";
            picMascot.Image = picArlington.Image;
        }
        private void btnKing_Click(object sender, EventArgs e)
        {
            txtMascot.Text = "Wolves";
            txtColor.Text = "Blue, Scarlet, & Silver";
            picMascot.Image = picKing.Image;
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            txtMascot.Text = "Huskies";
            txtColor.Text = "Blue & Yellow";
            picMascot.Image = picNorth.Image;
        }

        private void btnPoly_Click(object sender, EventArgs e)
        {
            txtMascot.Text = "Bears";
            txtColor.Text = "Green & Orange";
            picMascot.Image = picPoly.Image;
        }

        private void btnRamona_Click(object sender, EventArgs e)
        {
            txtMascot.Text = "Rams";
            txtColor.Text = "Blue & White";
            picMascot.Image = picRamona.Image;
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picNorth_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
