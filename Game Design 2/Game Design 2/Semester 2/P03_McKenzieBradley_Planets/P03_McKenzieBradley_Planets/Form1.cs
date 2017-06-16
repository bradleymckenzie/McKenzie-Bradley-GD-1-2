using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_McKenzieBradley_Planets
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int earth;
            double sun;
            double mercury;
            double venus;
            double mars;
            double jupiter;
            double saturn;
            double uranus;
            double neptune;
            double pluto;
            double moon;

            earth = int.Parse(txtWeight.Text);
            sun = earth * 27.072;
            mercury = earth * 0.378;
            venus = earth * 0.907;
            mars = earth * 0.377;
            jupiter = earth * 2.364;
            saturn = earth * 0.916;
            uranus = earth * 0.889;
            neptune = earth * 1.125;
            pluto = earth * 0.067;
            moon = earth * 0.166;

            lblSun.Text = sun.ToString();
            lblMercury.Text = mercury.ToString();
            lblVenus.Text = venus.ToString();
            lblMars.Text = mars.ToString();
            lblJupiter.Text = jupiter.ToString();
            lblSaturn.Text = saturn.ToString();
            lblUranus.Text = uranus.ToString();
            lblNeptune.Text = neptune.ToString();
            lblPluto.Text = pluto.ToString();
            lblMoon.Text = moon.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblSun.Text = "";
            lblMercury.Text = "";
            lblVenus.Text = "";
            lblMars.Text = "";
            lblJupiter.Text = "";
            lblSaturn.Text = "";
            lblUranus.Text = "";
            lblNeptune.Text = "";
            lblPluto.Text = "";
            lblMoon.Text = "";
            
        }
    }
}
