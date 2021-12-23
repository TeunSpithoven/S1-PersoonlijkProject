using EigenProject.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EigenProject
{
    public partial class FormBetalen : Form
    {
        int geldTotaal;
        int geldInleg;
        Form formWinkelen;
        private int v;

        public FormBetalen(int geldTotaal, Form formWinkelen)
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(geldTotaal);
            pictureBox1.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            this.formWinkelen = formWinkelen;
        }

        public int wisselgeld(int geldtotaal, int geldInleg)
        {
            int Wisselgeld;
            Wisselgeld = geldInleg - geldtotaal;
            return Wisselgeld;
        }

        private void watBijPinnen()
        {
            numericUpDown1.Visible = false;
            label4.Visible = false;
            labelWisselgeld.Visible = false;
            label5.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void watBijContant()
        {
            geldTotaal = Convert.ToInt32(textBox1.Text);
            label5.Visible = true;
            numericUpDown1.Visible = true;
            label4.Visible = true;
            labelWisselgeld.Visible = true;
            numericUpDown1.Minimum = Convert.ToDecimal(textBox1.Text);
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton n = (RadioButton)sender;

            // wat te doen bij pinnen?
            if (n.Name == "radioButton1")
            {
                watBijPinnen();
            }

            //wat te doen bij contant?
            else if (n.Name == "radioButton2")
            {
                watBijContant();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            geldInleg = Convert.ToInt32(numericUpDown1.Value);
            labelWisselgeld.Text = Convert.ToString(wisselgeld(geldTotaal, geldInleg));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void FormBetalen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void FormBetalen_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.background;
            pictureBox1.Image = Resources.atos_yomani__1009x1024;
            pictureBox2.Image = Resources.kisspng_cash_register_point_of_sale_sales_barcode_scanners_er_42_m_cash_register_netnest_australia_5b6fac4240b676_7498655015340452502651;
        }
    }
}
