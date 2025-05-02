using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.Modele
{
    internal class Traversee
    {
        private int idTraverse;
        private Bateau bateau;
        private Liaison liaison;
        private string dateTraverse;
        private string heure;

        public Traversee(int idTraverse, Bateau bateau, Liaison liaison, string dateTraverse, string heure)
        {
            this.idTraverse = idTraverse;
            this.bateau = bateau;
            this.liaison = liaison;
            this.dateTraverse = dateTraverse;
            this.heure = heure;
        }

        public int IdTraverse { get => idTraverse; set => idTraverse = value; }
        public string DateTraverse { get => dateTraverse; set => dateTraverse = value; }
        public string Heure { get => heure; set => heure = value; }
        internal Bateau Bateau { get => bateau; set => bateau = value; }
        internal Liaison Liaison { get => liaison; set => liaison = value; }

        public string Description
        {
            get => "Id traversée: "+this.idTraverse+", Bateau: "+this.bateau.NomBateau+", date traversée: "+this.dateTraverse+", heure traversée: "+this.heure;
        }
    }
}
