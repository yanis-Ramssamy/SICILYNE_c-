using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.Modele
{
    internal class Port
    {
        private int id_port;
        private string nom;

        private List<Liaison> liste_liaison_P = new List<Liaison>();

        public Port(int Unid_port, string Unnom)
        {
            this.id_port = Unid_port;
            this.nom = Unnom;
        }
        public Port()
        {

        }
        public int Id_port { get => id_port; set => id_port = value; }
        public string Nom { get => nom; set => nom = value; }

        public string Description
        {
            get => this.nom;
        }
    }
}
