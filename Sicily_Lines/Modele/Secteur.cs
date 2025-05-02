using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.Modele
{
    internal class Secteur
    {
        private int id_secteur;
        private string libelle;
        
        public int Id_secteur { get => id_secteur; set => id_secteur = value; }

        public string Libelle { get => libelle; set => libelle = value; }

        //constructeur
        public Secteur(int unId_Secteur, string unLibelle)
        {
            this.id_secteur = unId_Secteur;
            this.libelle = unLibelle;
        }

        public Secteur() { }

        // pour afficher la liste des secteurs
        public string Description
        {
            get => this.libelle ;
        }
    }
}
