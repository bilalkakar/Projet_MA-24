﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            double adjacent = 0, oppose = 0;

            bool conversionAdj = Double.TryParse(txtAdjacent.Text, out adjacent);   //conversion du texte en double
            bool conversionOpp = Double.TryParse(txtOppose.Text, out oppose);     //conversion du texte en double

            if(conversionAdj == false || conversionOpp == false || txtAdjacent.Text == "" || txtOppose.Text == "" || adjacent <= 0 || oppose <= 0)
            {
                lblResultPerim.Text = "";
                lblResultHypo.Text = "";
                MessageBox.Show("Verifiez que les champs sont non-vide et les chiffres sont valides et superieurs a zero");
                txtAdjacent.Text = "";
                txtOppose.Text = "";
            }
            else
            {
                double hypothenise = Hypothenise(adjacent, oppose);    // calcul de l'hypothenus du triangle
                double perimetre = perim(adjacent,oppose,hypothenise);    // calcule de la perimetre du triangle
                double air = aire(adjacent,oppose);
                lblResultHypo.Text = hypothenise.ToString();
                lblResultPerim.Text = perimetre.ToString();
                lblResultAir.Text = air.ToString();
            }             
        }


        static double Hypothenise(double x, double y)  // la fonction qui calcule l'hypothenus d'un triangle et retourne un double
        {
            double SommeDesCarres = (x * x) + (y * y);
            double resultat = Math.Sqrt(SommeDesCarres);
            return resultat;
        }

        static double  perim(double a, double o, double h)  // la fonction calcule le perimetre d'un griangle et retourne un double
        {
            double result = a + o + h;
            return result;
        }
        static double aire(double c, double d)     // la fonction calcul l'aire d'un triangle rectangle et retourne un double 
        {
            double air = 0.5 * c * d;
            return air;
        }

        private void cmdButton_Click(object sender, EventArgs e)
        {
            // Quand j'appuis sur le bouton "Reset", il va effacer les resultats et va vider les champs saisis

            lblResultHypo.Text = "";                
            lblResultPerim.Text = "";
            lblResultAir.Text = "";
            txtAdjacent.Text = "";
            txtOppose.Text = "";
        }

    }
}
