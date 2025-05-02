using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.Modele
{
    internal class Liaison
    {
        private int id_liaison;
        private Port idport_depart;
        private Secteur id_secteur;
        private Port idport_arrive;
        private string duree;

        public int Id_liaison { get => id_liaison; }

        public string Duree { get => duree; set => duree = value; }

        public Liaison(int Unid_liaison, Port depart, Secteur Unid_Secteur, Port arrive, string Uneduree) { 
            this.id_liaison = Unid_liaison;
            this.idport_depart = depart;
            this.id_secteur = Unid_Secteur;
            this.idport_arrive = arrive;
            this.duree = Uneduree;

        }
        public string Description
        {
            get => "Code Liaison : "+this.id_liaison+", Durée : " + this.duree +", Port de départ : " + this.idport_depart.Nom +", Port d'arrivée : "+this.idport_arrive.Nom;
        }
        internal Port Idport_depart { get => idport_depart;}
        internal Secteur Id_secteur { get => id_secteur;}
        internal Port Idport_arrive { get => idport_arrive;}
    }
}
