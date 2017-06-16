using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_McKenzieBradley_Materials
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCubic.Text = "";

            lblAluminum.Text = "";
            lblBrass.Text = "";
            lblCopper.Text = "";
            lblGasoline.Text = "";
            lblGlass.Text = "";
            lblGold.Text = "";
            lblLead.Text = "";
            lblMagnesium.Text = "";
            lblNickel.Text = "";

            lblOsmium.Text = "";
            lblPine.Text = "";
            lblPlatinum.Text = "";
            lblRock.Text = "";
            lblSand.Text = "";
            lblSilver.Text = "";
            lblSteel.Text = "";
            lblTungsten.Text = "";
            lblWater.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cubicfeet;
            double aluminum;
            double brass;
            double copper;
            double gasoline;
            double glass;
            double gold;
            double lead;
            double magnesium;
            double nickel;
            double osmium;
            double pine;
            double platinum;
            double rock;
            double sand;
            double silver;
            double steel;
            double tungsten;
            double water;

            cubicfeet = int.Parse(txtCubic.Text);
            aluminum = cubicfeet * 165;
            brass = cubicfeet * 535;
            copper = cubicfeet * 560;
            gasoline = cubicfeet * 42;
            glass = cubicfeet * 160;
            gold = cubicfeet * 1204;
            lead = cubicfeet * 710;
            magnesium = cubicfeet * 109;
            nickel = cubicfeet * 541;

            osmium = cubicfeet * 1408;
            pine = cubicfeet * 34;
            platinum = cubicfeet * 1342;
            rock = cubicfeet * 158;
            sand = cubicfeet * 100;
            silver = cubicfeet * 653;
            steel = cubicfeet * 490;
            tungsten = cubicfeet * 1224;
            water = cubicfeet * 62;

            lblAluminum.Text = aluminum.ToString();
            lblBrass.Text = brass.ToString();
            lblCopper.Text = copper.ToString();
            lblGasoline.Text = aluminum.ToString();
            lblGlass.Text = glass.ToString();
            lblGold.Text = gold.ToString();
            lblLead.Text = lead.ToString();
            lblMagnesium.Text = magnesium.ToString();
            lblNickel.Text = nickel.ToString();

            lblOsmium.Text = osmium.ToString();
            lblPine.Text = pine.ToString();
            lblPlatinum.Text = platinum.ToString();
            lblRock.Text = rock.ToString();
            lblSand.Text = sand.ToString();
            lblSilver.Text = silver.ToString();
            lblSteel.Text = steel.ToString();
            lblTungsten.Text = tungsten.ToString();
            lblWater.Text = water.ToString();
        }
    }
}
