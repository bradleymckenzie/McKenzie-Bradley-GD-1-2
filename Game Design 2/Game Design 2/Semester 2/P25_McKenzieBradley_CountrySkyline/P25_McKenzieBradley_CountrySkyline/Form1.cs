using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P25_McKenzieBradley_CountrySkyline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblIstanbul_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 212;
            picSkyline.Top = 175;
            picSkyline.Image = pic1.Image;
            lblIstanbul.ForeColor = Color.Red;
        }

        private void lblIstanbul_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblIstanbul.ForeColor = Color.Black;
        }

        private void lblAnkara_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 342;
            picSkyline.Top = 230; 
            picSkyline.Image = pic2.Image;
            lblAnkara.ForeColor = Color.Red;
        }

        private void lblAnkara_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblAnkara.ForeColor = Color.Black;
        }

        private void lblİzmir_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 136;
            picSkyline.Top = 287;
            picSkyline.Image = pic3.Image;
            lblİzmir.ForeColor = Color.Red;
        }

        private void lblİzmir_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblİzmir.ForeColor = Color.Black;
        }

        private void lblBursa_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 203;
            picSkyline.Top = 214;
            picSkyline.Image = pic4.Image;
            lblBursa.ForeColor = Color.Red;
        }

        private void lblBursa_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblBursa.ForeColor = Color.Black;
        }

        private void lblAdana_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 416;
            picSkyline.Top = 388;
            picSkyline.Image = pic5.Image;
            lblAdana.ForeColor = Color.Red;
        }

        private void lblAdana_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblAdana.ForeColor = Color.Black;
        }

        private void lblGaziantep_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 471;
            picSkyline.Top = 383;
            picSkyline.Image = pic6.Image;
            lblGaziantep.ForeColor = Color.Red;
        }

        private void lblGaziantep_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblGaziantep.ForeColor = Color.Black;
        }

        private void lblKonya_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 335;
            picSkyline.Top = 319;
            picSkyline.Image = pic7.Image;
            lblKonya.ForeColor = Color.Red;
        }

        private void lblKonya_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblKonya.ForeColor = Color.Black;
        }

        private void lblAntalya_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 243;
            picSkyline.Top = 375;
            picSkyline.Image = pic8.Image;
            lblAntalya.ForeColor = Color.Red;
        }

        private void lblAntalya_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblAntalya.ForeColor = Color.Black;
        }

        private void lblKayseri_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 411;
            picSkyline.Top = 292;
            picSkyline.Image = pic9.Image;
            lblKayseri.ForeColor = Color.Red;
        }

        private void lblKayseri_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblKayseri.ForeColor = Color.Black;
        }

        private void lblMersin_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 383;
            picSkyline.Top = 389;
            picSkyline.Image = pic10.Image;
            lblMersin.ForeColor = Color.Red;
        }

        private void lblMersin_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblMersin.ForeColor = Color.Black;
        }

        private void lblEskişehir_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 261;
            picSkyline.Top = 233;
            picSkyline.Image = pic11.Image;
            lblEskişehir.ForeColor = Color.Red;
        }

        private void lblEskişehir_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblEskişehir.ForeColor = Color.Black;
        }

        private void lblDiyarbakır_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 568;
            picSkyline.Top = 337;
            picSkyline.Image = pic12.Image;
            lblDiyarbakır.ForeColor = Color.Red;
        }

        private void lblDiyarbakır_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblDiyarbakır.ForeColor = Color.Black;
        }

        private void lblSamsun_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 423;
            picSkyline.Top = 176;
            picSkyline.Image = pic13.Image;
            lblSamsun.ForeColor = Color.Red;
        }

        private void lblSamsun_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblSamsun.ForeColor = Color.Black;
        }

        private void lblDenizli_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 199;
            picSkyline.Top = 327;
            picSkyline.Image = pic14.Image;
            lblDenizli.ForeColor = Color.Red;
        }

        private void lblDenizli_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblDenizli.ForeColor = Color.Black;
        }

        private void lblŞanlıurfa_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 533;
            picSkyline.Top = 375;
            picSkyline.Image = pic15.Image;
            lblŞanlıurfa.ForeColor = Color.Red;
        }

        private void lblŞanlıurfa_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblŞanlıurfa.ForeColor = Color.Black;
        }

        private void lblMalatya_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 513;
            picSkyline.Top = 364;
            picSkyline.Image = pic16.Image;
            lblMalatya.ForeColor = Color.Red;
        }

        private void lblMalatya_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblMalatya.ForeColor = Color.Black;
        }

        private void lblKahramanmaraş_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 464;
            picSkyline.Top = 358;
            picSkyline.Image = pic17.Image;
            lblKahramanmaraş.ForeColor = Color.Red;
        }

        private void lblKahramanmaraş_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblKahramanmaraş.ForeColor = Color.Black;
        }

        private void lblErzurum_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 625;
            picSkyline.Top = 240;
            picSkyline.Image = pic18.Image;
            lblErzurum.ForeColor = Color.Red;
        }

        private void lblErzurum_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblErzurum.ForeColor = Color.Black;
        }

        private void lblİskenderun_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 447;
            picSkyline.Top = 401;
            picSkyline.Image = pic19.Image;
            lblİskenderun.ForeColor = Color.Red;
        }

        private void lblİskenderun_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblİskenderun.ForeColor = Color.Black;
        }

        private void lblSelimiyeMosque_MouseEnter(object sender, EventArgs e)
        {
            picSkyline.Visible = true;
            picSkyline.Left = 404;
            picSkyline.Top = 305;
            picSkyline.Image = pic20.Image;
            lblSelimiyeMosque.ForeColor = Color.Red;
        }

        private void lblSelimiyeMosque_MouseLeave(object sender, EventArgs e)
        {
            picSkyline.Visible = false;
            lblSelimiyeMosque.ForeColor = Color.Black;
        }
    }
}
