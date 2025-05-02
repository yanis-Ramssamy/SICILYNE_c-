using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.Modele
{
    internal class Bateau
    {
        private int idBateau;
        private string nomBateau;
        private int longueur;
        private int largeur;
        private int vitesse;

        public Bateau(int idBateau, string nomBateau, int longueur, int largeur, int vitesse)
        {
            this.idBateau = idBateau;
            this.nomBateau = nomBateau;
            this.longueur = longueur;
            this.largeur = largeur;
            this.vitesse = vitesse;
        }

        public int IdBateau { get => idBateau; set => idBateau = value; }
        public string NomBateau { get => nomBateau; set => nomBateau = value; }
        public int Longueur { get => longueur; set => longueur = value; }
        public int Largeur { get => largeur; set => largeur = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }

        public string Description
        {
            get => "" + this.nomBateau + " L" + this.longueur + "m l" + this.largeur+"m "+this.vitesse+"Km/h";
        }
    }
}
