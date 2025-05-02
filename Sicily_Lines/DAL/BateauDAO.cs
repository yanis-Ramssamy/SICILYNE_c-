using MySql.Data.MySqlClient;
using Sicily_Lines.Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sicily_Lines.DAL
{
    internal class BateauDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilynes";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static List<Bateau> getBateau()
        {
            List<Bateau> lc = new List<Bateau>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from bateau");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Bateau e;
                while (reader.Read())
                {
                    int idBateau = (int)reader.GetValue(0);
                    string nomBateau = (string)reader.GetValue(1);
                    int longueur = (int)reader.GetValue(2);
                    int largeur = (int)reader.GetValue(3);
                    int vitesse = (int)reader.GetValue(4);
                    e = new Bateau(idBateau, nomBateau, longueur, largeur, vitesse);
                    lc.Add(e);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return (lc);
            }
            catch (Exception bat)
            {
                throw (bat);
            }
        }
    }
}
