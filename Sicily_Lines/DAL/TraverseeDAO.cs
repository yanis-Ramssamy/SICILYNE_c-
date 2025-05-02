using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sicily_Lines.Modele;

namespace Sicily_Lines.DAL
{
    internal class TraverseeDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilynes";
            

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static void updateTraversee(Traversee e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("update traversee set datetraversee= '" + e.DateTraverse + "', heure= '"+e.Heure+"' where id_traversee = " + e.IdTraverse);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception trav)
            {
                throw (trav);
            }
        }
        public static List<Traversee> getTraversee(Liaison liaison)
        {
            List<Traversee> lc = new List<Traversee>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Select id_traversee,traversee.id_bateau,nombateau,longueur,largeur,vitesse,datetraversee,heure from traversee inner join bateau on traversee.id_bateau=bateau.id_bateau where id_liaison="+liaison.Id_liaison);
                MySqlDataReader reader = Ocom.ExecuteReader();
                Traversee e;
                while (reader.Read())
                {
                    int idTraversee = (int)reader.GetValue(0);
                    Bateau unBateau = new Bateau(
                        (int)reader.GetValue(1),
                        (string)reader.GetValue(2),
                        (int)reader.GetValue(3),
                        (int)reader.GetValue(4),
                        (int)reader.GetValue(5)
                    );
                    string dateTraversee = (string)reader.GetValue(6);
                    string heure = (string)reader.GetValue(7);
                    e = new Traversee(idTraversee,unBateau,liaison,dateTraversee,heure);
                    lc.Add(e);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return (lc);
            }
            catch (Exception trav)
            {
                throw (trav);
            }
        }
        public static void suppTraversee(Traversee e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Delete from traversee where id_traversee = " + e.IdTraverse);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception trav)
            {
                throw (trav);
            }
        }
        public static void addTraversee(Traversee e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Insert Into traversee Values (" + e.IdTraverse + "," + e.Bateau.IdBateau + "," + e.Liaison.Id_liaison + ",'" + e.DateTraverse + "','" + e.Heure + "')");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception trav)
            {
                throw (trav);
            }
        }
    }
}
