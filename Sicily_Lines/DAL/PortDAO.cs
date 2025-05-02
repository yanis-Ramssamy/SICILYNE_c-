using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sicily_Lines.Modele;

namespace Sicily_Lines.DAL
{
    internal class PortDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilynes";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static List<Port> getPorts()
        {
            List<Port> lc = new List<Port>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select * from port");
                MySqlDataReader reader = Ocom.ExecuteReader();
                Port e;
                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    String Nom = (String)reader.GetValue(1);
                    e = new Port(id, Nom);
                    lc.Add(e);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return (lc);
            }
            catch (Exception port)
            {
                throw (port);
            }
        }
    }
}
