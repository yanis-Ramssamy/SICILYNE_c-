using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sicily_Lines.Modele;

namespace Sicily_Lines.DAL
{
    internal class SecteurDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilynes";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static List<Secteur> getSecteurs()
        {
            List<Secteur> lc = new List<Secteur>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from secteur");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Secteur e;
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string libelle = (string)reader.GetValue(1);
                    e = new Secteur(id, libelle);
                    lc.Add(e);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return (lc);
            }
            catch (Exception sect)
            {
                throw (sect);
            }
        }
    }
}
