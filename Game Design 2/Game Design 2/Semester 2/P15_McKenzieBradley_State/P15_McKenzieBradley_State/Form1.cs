using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P15_McKenzieBradley_State
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblApex_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Apex";
            lblPopulation.Text = "42,214";
            picSymbol.Image = picApex.Image;
        }

        private void lblApex_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblWakeForest_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Wake Forest";
            lblPopulation.Text = "34,752";
            picSymbol.Image = picWakeForest.Image;
        }

        private void lblWakeForest_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void picMatthew_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Matthews";
            lblPopulation.Text = "29,384";
            picSymbol.Image = picMatthews.Image;
        }

        private void lblMatthews_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblMorrisville_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Morrisville";
            lblPopulation.Text = "21,932";
            picSymbol.Image = picMorrisville.Image;
        }

        private void lblMorrisville_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblGarner_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Garner";
            lblPopulation.Text = "26,772";
            picSymbol.Image = picGarner.Image;
        }

        private void lblGarner_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblRaleigh_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Raleigh";
            lblPopulation.Text = "431,746";
            picSymbol.Image = picRaleigh.Image;
        }

        private void lblRaleigh_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblZebulon_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Zebulon";
            lblPopulation.Text = "4,591";
            picSymbol.Image = picZebulon.Image;
        }

        private void lblZebulon_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblCary_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Cary";
            lblPopulation.Text = "151,088";
            picSymbol.Image = picCary.Image;
        }

        private void lblCary_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblChapelHill_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Chapel Hill";
            lblPopulation.Text = "59,635";
            picSymbol.Image = picChapelHill.Image;
        }

        private void lblChapelHill_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblDurham_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Durham";
            lblPopulation.Text = "245.475";
            picSymbol.Image = picDurham.Image;
        }

        private void lblDurham_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblHuntersville_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Huntersville";
            lblPopulation.Text = "50,458";
            picSymbol.Image = picHuntersville.Image;
        }

        private void lblHuntersville_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblMintHill_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Mint Hill";
            lblPopulation.Text = "24,543";
            picSymbol.Image = picMintHill.Image;
        }

        private void lblMintHill_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblAsheville_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Asheville";
            lblPopulation.Text = "83,393";
            picSymbol.Image = picAsheville.Image;
        }

        private void lblAsheville_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblCarrboro_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Carrboro";
            lblPopulation.Text = "20,908";
            picSymbol.Image = picCarrboro.Image;
        }

        private void lblCarrboro_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }

        private void lblBurlington_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Text = "Burlington";
            lblPopulation.Text = "51,510";
            picSymbol.Image = picCarrboro.Image;
        }

        private void lblBurlington_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Text = "";
            lblPopulation.Text = "";
            picSymbol.Image = picBlank.Image;
        }
    }
}
