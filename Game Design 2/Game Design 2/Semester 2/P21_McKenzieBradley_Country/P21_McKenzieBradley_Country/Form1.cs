using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P21_McKenzieBradley_Country
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIstanbul_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 212;
            lblCity.Top = 175;
            lblIstanbul.ForeColor = Color.Red;
        }

        private void lblIstanbul_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblIstanbul.ForeColor = Color.Black;
        }

        private void lblİzmir_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 136;
            lblCity.Top = 287;
            lblİzmir.ForeColor = Color.Red;
        }

        private void lblİzmir_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblİzmir.ForeColor = Color.Black;
        }

        private void lblAnkara_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 342;
            lblCity.Top = 230;
            lblAnkara.ForeColor = Color.Red;
        }

        private void lblAnkara_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblAnkara.ForeColor = Color.Black;
        }

        private void lblBursa_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 203;
            lblCity.Top = 214;
            lblBursa.ForeColor = Color.Red;
        }

        private void lblBursa_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblBursa.ForeColor = Color.Black;
        }

        private void lblAdana_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 416;
            lblCity.Top = 388;
            lblAdana.ForeColor = Color.Red;
        }

        private void lblAdana_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblAdana.ForeColor = Color.Black;
        }

        private void lblGaziantep_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 471;
            lblCity.Top = 383;
            lblGaziantep.ForeColor = Color.Red;
        }

        private void lblGaziantep_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblGaziantep.ForeColor = Color.Black;
        }

        private void lblKonya_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 335;
            lblCity.Top = 319;
            lblKonya.ForeColor = Color.Red;
        }

        private void lblKonya_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblKonya.ForeColor = Color.Black;
        }

        private void lblAntalya_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 243;
            lblCity.Top = 375;
            lblAntalya.ForeColor = Color.Red;
        }

        private void lblAntalya_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblAntalya.ForeColor = Color.Black;
        }

        private void lblKayseri_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 411;
            lblCity.Top = 292;
            lblKayseri.ForeColor = Color.Red;
        }

        private void lblKayseri_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblKayseri.ForeColor = Color.Black;
        }

        private void lblMersin_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 383;
            lblCity.Top = 389;
            lblMersin.ForeColor = Color.Red;
        }

        private void lblMersin_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblMersin.ForeColor = Color.Black;
        }

        private void lblEskişehir_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 261;
            lblCity.Top = 233;
            lblEskişehir.ForeColor = Color.Red;
        }

        private void lblEskişehir_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblEskişehir.ForeColor = Color.Black;
        }

        private void lblDiyarbakır_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 568;
            lblCity.Top = 337;
            lblDiyarbakır.ForeColor = Color.Red;
        }

        private void lblDiyarbakır_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblDiyarbakır.ForeColor = Color.Black;
        }

        private void lblSamsun_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 423;
            lblCity.Top = 176;
            lblSamsun.ForeColor = Color.Red;
        }

        private void lblSamsun_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblSamsun.ForeColor = Color.Black;
        }

        private void lblDenizli_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 199;
            lblCity.Top = 327;
            lblDenizli.ForeColor = Color.Red;
        }

        private void lblDenizli_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblDenizli.ForeColor = Color.Black;
        }

        private void lblŞanlıurfa_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 533;
            lblCity.Top = 375;
            lblŞanlıurfa.ForeColor = Color.Red;
        }

        private void lblŞanlıurfa_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblŞanlıurfa.ForeColor = Color.Black;
        }

        private void lblMalatya_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 513;
            lblCity.Top = 364;
            lblMalatya.ForeColor = Color.Red;
        }

        private void lblMalatya_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblMalatya.ForeColor = Color.Black;
        }

        private void lblKahramanmaraş_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 464;
            lblCity.Top = 358;
            lblKahramanmaraş.ForeColor = Color.Red;
        }

        private void lblKahramanmaraş_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblKahramanmaraş.ForeColor = Color.Black;
        }

        private void lblErzurum_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 625;
            lblCity.Top = 240;
            lblErzurum.ForeColor = Color.Red;
        }

        private void lblErzurum_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblErzurum.ForeColor = Color.Black;
        }

        private void lblİskenderun_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 447;
            lblCity.Top = 401;
            lblİskenderun.ForeColor = Color.Red;
        }

        private void lblİskenderun_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblİskenderun.ForeColor = Color.Black;
        }

        private void lblSelimiyeMosque_MouseEnter(object sender, EventArgs e)
        {
            lblCity.Visible = true;
            lblCity.Left = 404;
            lblCity.Top = 305;
            lblSelimiyeMosque.ForeColor = Color.Red;
        }

        private void lblSelimiyeMosque_MouseLeave(object sender, EventArgs e)
        {
            lblCity.Visible = false;
            lblSelimiyeMosque.ForeColor = Color.Black;
        }
    }
}
