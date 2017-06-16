using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P22_McKenzieBradley_CountryGame
{
    public partial class Form1 : Form
    {
        String[] cities = new String[20];
        int total;
        int wrong;
        int correct;
        int percent;

        public Form1()
        {
            InitializeComponent();
            cities[0] = "Istanbul";
            cities[1] = "Ankara";
            cities[2] = "Izmir";
            cities[3] = "Bursa";
            cities[4] = "Adana";
            cities[5] = "Gaziantep";
            cities[6] = "Konya";
            cities[7] = "Antalya";
            cities[8] = "Kayseri";
            cities[9] = "Mersin";
            cities[10] = "Eskişehir";
            cities[11] = "Diyarbakır";
            cities[12] = "Samsun";
            cities[13] = "Denizli";
            cities[14] = "Şanlıurfa";
            cities[15] = "Malatya";
            cities[16] = "Kahramanmaraş";
            cities[17] = "Erzurum";
            cities[18] = "İskenderun";
            cities[19] = "Selimiye Mosque";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            getCity();
            total = 0;
            wrong = 0;
            percent = 0;
            correct = 0;
            lblTotal.Text = total.ToString("#0");
            lblCorrect.Text = correct.ToString("#0");
            lblWrong.Text = wrong.ToString("#0");
            lblPercent.Text = percent.ToString("#0.0");
        }

        private void getCity()
        {
           int c;
           Random r = new Random();
           c = r.Next(20);
           lblCity.Text = cities[c];
        }

        private void chkCity(string s)
        {
            if(lblCity.Text == s)
	        {
	            correct += 1;
	        }
	        else
	        {
	            wrong += 1;
	        }

            total += 1;

            if(correct > 0 && wrong > 0)
	        {
	            percent = (correct * 100 / total);
            }
            else if (correct > 0 && wrong == 0)
            {
                percent = 100;
            }
            else
            {
                percent = 0;
            }
            lblTotal.Text = total.ToString("#0");
            lblCorrect.Text = correct.ToString("#0");
            lblWrong.Text = wrong.ToString("#0");
            lblPercent.Text = percent.ToString("#0.0");
            getCity();
        }

        private void lblIstanbul_Click(object sender, EventArgs e)
        {
            chkCity(lblIstanbul.Text);
        }

        private void lblBursa_Click(object sender, EventArgs e)
        {
            chkCity(lblBursa.Text);
        }

        private void lblİzmir_Click(object sender, EventArgs e)
        {
            chkCity(lblİzmir.Text);
        }

        private void lblEskişehir_Click(object sender, EventArgs e)
        {
            chkCity(lblEskişehir.Text);
        }

        private void lblDenizli_Click(object sender, EventArgs e)
        {
            chkCity(lblDenizli.Text);
        }

        private void lblAntalya_Click(object sender, EventArgs e)
        {
            chkCity(lblAntalya.Text);
        }

        private void lblKonya_Click(object sender, EventArgs e)
        {
            chkCity(lblKonya.Text);
        }

        private void lblMersin_Click(object sender, EventArgs e)
        {
            chkCity(lblMersin.Text);
        }

        private void lblAdana_Click(object sender, EventArgs e)
        {
            chkCity(lblAdana.Text);
        }

        private void lblGaziantep_Click(object sender, EventArgs e)
        {
            chkCity(lblGaziantep.Text);
        }

        private void lblİskenderun_Click(object sender, EventArgs e)
        {
            chkCity(lblİskenderun.Text);
        }

        private void lblSelimiyeMosque_Click(object sender, EventArgs e)
        {
            chkCity(lblSelimiyeMosque.Text);
        }

        private void lblKayseri_Click(object sender, EventArgs e)
        {
            chkCity(lblKayseri.Text);
        }

        private void lblAnkara_Click(object sender, EventArgs e)
        {
            chkCity(lblAnkara.Text);
        }

        private void lblSamsun_Click(object sender, EventArgs e)
        {
            chkCity(lblSamsun.Text);
        }

        private void lblDiyarbakır_Click(object sender, EventArgs e)
        {
            chkCity(lblDiyarbakır.Text);
        }

        private void lblŞanlıurfa_Click(object sender, EventArgs e)
        {
            chkCity(lblŞanlıurfa.Text);
        }

        private void lblMalatya_Click(object sender, EventArgs e)
        {
            chkCity(lblMalatya.Text);
        }

        private void lblKahramanmaraş_Click(object sender, EventArgs e)
        {
            chkCity(lblKahramanmaraş.Text);
        }

        private void lblErzurum_Click(object sender, EventArgs e)
        {
            chkCity(lblErzurum.Text);
        }
    }
}
