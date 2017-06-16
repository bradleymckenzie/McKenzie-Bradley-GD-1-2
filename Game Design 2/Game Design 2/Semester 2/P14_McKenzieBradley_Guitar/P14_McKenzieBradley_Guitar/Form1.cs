using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_McKenzieBradley_Guitar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            shp0.Visible = false;
            shp1.Visible = false;
            shp2.Visible = false;
            shp3.Visible = false;
            shp4.Visible = false;
            shp5.Visible = false;
            shp6.Visible = false;
            shp7.Visible = false;
            shp8.Visible = false;
            shp9.Visible = false;
            shp10.Visible = false;
            shp11.Visible = false;
            shp12.Visible = false;
            shp13.Visible = false;
            shp14.Visible = false;
            shp15.Visible = false;
            shp16.Visible = false;
            shp17.Visible = false;
            shp18.Visible = false;
            shp19.Visible = false;
            shp20.Visible = false;
            shp21.Visible = false;
            shp22.Visible = false;
            shp23.Visible = false;
            shp24.Visible = false;
            shp25.Visible = false;
            shp26.Visible = false;
            shp27.Visible = false;
            shp28.Visible = false;
            shp29.Visible = false;
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            Clear();
            shp1.Visible = true;
            shp5.Visible = true;
            shp14.Visible = true;
            shp15.Visible = true;
            shp16.Visible = true;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            Clear();
            shp13.Visible = true;
            shp17.Visible = true;
            shp26.Visible = true;
            shp27.Visible = true;
            shp28.Visible = true;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Clear();
            shp3.Visible = true;
            shp10.Visible = true;
            shp13.Visible = true;
            shp19.Visible = true;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            Clear();
            shp2.Visible = true;
            shp15.Visible = true;
            shp17.Visible = true;
            shp22.Visible = true;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            Clear();
            shp0.Visible = true;
            shp4.Visible = true;
            shp5.Visible = true;
            shp9.Visible = true;
            shp13.Visible = true;
            shp14.Visible = true;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            Clear();
            shp6.Visible = true;
            shp10.Visible = true;
            shp11.Visible = true;
            shp15.Visible = true;
            shp19.Visible = true;
            shp20.Visible = true;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            Clear();
            shp2.Visible = true;
            shp3.Visible = true;
            shp4.Visible = true;
            shp13.Visible = true;
            shp18.Visible = true;
            shp23.Visible = true;
        }

        private void btnAm_Click(object sender, EventArgs e)
        {
            Clear();
            shp1.Visible = true;
            shp5.Visible = true;
            shp10.Visible = true;
            shp14.Visible = true;
            shp15.Visible = true;
        }

        private void btnBm_Click(object sender, EventArgs e)
        {
            Clear();
            shp13.Visible = true;
            shp17.Visible = true;
            shp22.Visible = true;
            shp26.Visible = true;
            shp27.Visible = true;
        }

        private void btnCm_Click(object sender, EventArgs e)
        {
            Clear();
            shp7.Visible = true;
            shp11.Visible = true;
            shp16.Visible = true;
            shp20.Visible = true;
            shp21.Visible = true;
        }

        private void btnDm_Click(object sender, EventArgs e)
        {
            Clear();
            shp11.Visible = true;
            shp15.Visible = true;
            shp22.Visible = true;
        }

        private void btnEm_Click(object sender, EventArgs e)
        {
            Clear();
            shp0.Visible = true;
            shp3.Visible = true;
            shp4.Visible = true;
            shp5.Visible = true;
        }

        private void btnFm_Click(object sender, EventArgs e)
        {
            Clear();
            shp6.Visible = true;
            shp9.Visible = true;
            shp10.Visible = true;
            shp11.Visible = true;
        }

        private void btnGm_Click(object sender, EventArgs e)
        {
            Clear();
            shp6.Visible = true;
            shp9.Visible = true;
            shp10.Visible = true;
            shp11.Visible = true;
            shp19.Visible = true;
            shp20.Visible = true;
        }

        private void btnA7_Click(object sender, EventArgs e)
        {
            Clear();
            shp1.Visible = true;
            shp2.Visible = true;
            shp5.Visible = true;
            shp16.Visible = true;
            shp14.Visible = true;
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            Clear();
            shp13.Visible = true;
            shp17.Visible = true;
            shp26.Visible = true;
            shp28.Visible = true;
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            Clear();
            shp5.Visible = true;
            shp10.Visible = true;
            shp14.Visible = true;
            shp19.Visible = true;
            shp21.Visible = true;
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            Clear();
            shp2.Visible = true;
            shp10.Visible = true;
            shp15.Visible = true;
            shp17.Visible = true;
        }

        private void btnE7_Click(object sender, EventArgs e)
        {
            Clear();
            shp0.Visible = true;
            shp2.Visible = true;
            shp4.Visible = true;
            shp5.Visible = true;
            shp9.Visible = true;
            shp13.Visible = true;
        }

        private void btnF7_Click(object sender, EventArgs e)
        {
            Clear();
            shp7.Visible = true;
            shp10.Visible = true;
            shp11.Visible = true;
            shp15.Visible = true;
            shp19.Visible = true;
        }

        private void btnG7_Click(object sender, EventArgs e)
        {
            Clear();
            shp13.Visible = true;
            shp17.Visible = true;
            shp26.Visible = true;
            shp28.Visible = true;
        }

        
    }
}
