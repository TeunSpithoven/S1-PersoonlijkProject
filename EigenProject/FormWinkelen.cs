using EigenProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenProject
{
    public partial class FormWinkelen : Form
    {
        //aanmaken variabelen
        String product;
        int geldTotaal;

        public FormWinkelen()
        {
            InitializeComponent();
            geldTotaal = 0;
        }

        int prijslijst(String productNaam)
        {
            int prijs;

            switch (productNaam)
            {
                case "Watermeloen":
                    prijs = 10;
                    break;
                case "Water":
                    prijs = 2;
                    break;
                case "Kalkoen":
                    prijs = 22;
                    break;
                case "Garde":
                    prijs = 2;
                    break;
                case "Theepot":
                    prijs = 60;
                    break;
                case "Friet":
                    prijs = 5;
                    break;
                case "Vis":
                    prijs = 7;
                    break;
                case "Cupcake":
                    prijs = 9;
                    break;
                case "Koffie":
                    prijs = 2;
                    break;
                case "Kokosnoot":
                    prijs = 10;
                    break;
                case "Kaas":
                    prijs = 10;
                    break;
                case "Wortel":
                    prijs = 2;
                    break;
                case "Blikje":
                    prijs = 1;
                    break;
                case "Broccoli":
                    prijs = 3;
                    break;
                case "Eitje":
                    prijs = 2;
                    break;
                case "Bonen":
                    prijs = 1;
                    break;
                case "Avocado":
                    prijs = 5;
                    break;
                case "Appel":
                    prijs = 2;
                    break;
                case "Baguette":
                    prijs = 6;
                    break;
                case "Bacon":
                    prijs = 3;
                    break;
                case "Bosbessen":
                    prijs = 5;
                    break;
                case "Banaan":
                    prijs = 4;
                    break;
                case "Broodmes":
                    prijs = 9;
                    break;
                case "Pasta":
                    prijs = 6;
                    break;
                case "Taart":
                    prijs = 69;
                    break;
                default:
                    prijs = 0;
                    break;
            }
            return prijs;
        }

        private void productSelecteren()
        {
            product = product.Remove(0, 10);
            Winkelwagen.Items.Add(product);
            geldTotaal += prijslijst(product);
            textBox1.Text = geldTotaal.ToString();
        }

        private void knopKlik()
        {
            if (geldTotaal >= 1)
            {
                this.Hide();
                FormBetalen f = new FormBetalen(Convert.ToInt32(textBox1.Text), this);
                f.ShowDialog();
                geldTotaal = 0;
                textBox1.Text = "0";
                Winkelwagen.Items.Clear();
            }
        }

      //voegt product toe aan lijst bij klikken
        private void pictureBoxTaart_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox n = (PictureBox)sender;
            product = n.Name;
            productSelecteren();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            knopKlik();
        }

        private void FormWinkelen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.background;
            // voor de producten
            pictureBoxWatermeloen.Image = Resources.watermelon;
            pictureBoxWater.Image = Resources.water;
            pictureBoxAppel.Image = Resources.apple;
            pictureBoxAvocado.Image = Resources.avocado;
            pictureBoxBacon.Image = Resources.bacon;
            pictureBoxBaguette.Image = Resources.baguette;
            pictureBoxBanaan.Image = Resources.banana;
            pictureBoxBlikje.Image = Resources.can;
            pictureBoxBonen.Image = Resources.beans;
            pictureBoxBosbessen.Image = Resources.blueberries;
            pictureBoxBroccoli.Image = Resources.broccoli;
            pictureBoxBroodmes.Image = Resources.knife;
            pictureBoxCupcake.Image = Resources.cupcake;
            pictureBoxEitje.Image = Resources.egg;
            pictureBoxFriet.Image = Resources.fries;
            pictureBoxGarde.Image = Resources.whisk;
            pictureBoxKaas.Image = Resources.cheese;
            pictureBoxKalkoen.Image = Resources.turkey;
            pictureBoxKoffie.Image = Resources.coffee;
            pictureBoxKokosnoot.Image = Resources.coconut;
            pictureBoxPasta.Image = Resources.pasta;
            pictureBoxTaart.Image = Resources.cake;
            pictureBoxTheepot.Image = Resources.teapot;
            pictureBoxVis.Image = Resources.fish;
            pictureBoxWortel.Image = Resources.carrot;
        }
    }
}
