using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_McKenzieBradley_Animals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBull_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic1.Image;
            lblAnimals.Text = "Bull";
        }

        private void btnCat_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic2.Image;
            lblAnimals.Text = "Cat";
        }

        private void btnChicken_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic3.Image;
            lblAnimals.Text = "Chicken";
        }

        private void btnCow_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic4.Image;
            lblAnimals.Text = "Cow";
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic5.Image;
            lblAnimals.Text = "Dog";
        }

        private void btnDonkey_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic6.Image;
            lblAnimals.Text = "Donkey";
        }

        private void btnDuck_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic7.Image;
            lblAnimals.Text = "Duck";
        }

        private void btnGoat_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic8.Image;
            lblAnimals.Text = "Goat";
        }

        private void btnHorse_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic9.Image;
            lblAnimals.Text = "Horse";
        }

        private void btnPig_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic10.Image;
            lblAnimals.Text = "Pig";
        }

        private void btnSheep_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic11.Image;
            lblAnimals.Text = "Sheep";
        }

        private void btnTurkey_Click(object sender, EventArgs e)
        {
            picAnimals.Image = pic12.Image;
            lblAnimals.Text = "Turkey";
        }
    }
}
