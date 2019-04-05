using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double adjacent = 0, oppose = 0;

            Double.TryParse(txtCote1.Text, out adjacent);   //conversion du texte en double
            Double.TryParse(txtCote2.Text, out oppose);     //conversion du texte en double

            if (txtCote1.Text=="" || txtCote2.Text=="" || adjacent <= 0 || oppose <= 0) // si les champs sont vides ou les valeurs sont plus petites que zero
            {
                lblResultPerim.Text = "";
                lblResultHypo.Text = "";
                MessageBox.Show("Veriviez que les champs sont non-vide et les chiffres sont superieur a zero");
            }
            else
            {
                double hypothenise = Hypothenise(adjacent, oppose);    // calcul de l'hypothenus du triangle
                double perimetre = hypothenise + adjacent + oppose;    // calcule de la perimetre du triangle
                lblResultHypo.Text = hypothenise.ToString();
                lblResultPerim.Text = perimetre.ToString();
            }             
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        static double Hypothenise(double x, double y)  // la fonction qui calcule l'hypothenus d'un triangle
        {
            double SommeDesCarres = (x * x) + (y * y);
            double resultat = Math.Sqrt(SommeDesCarres);
            return resultat;
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            lblResultHypo.Text = "";
            lblResultPerim.Text = "";
            txtCote1.Text = "";
            txtCote2.Text = "";
        }
    }
}
