using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sicily_Lines.Modele;

namespace Sicily_Lines.DAL
{
    internal class LiaisonDAO
    {
        private static string provider = "localhost";

        private static string dataBase = "sicilynes";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;

        public static void updateLiaison(Liaison e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("update liaison set duree= '" + e.Duree + "' where id_liaison = " + e.Id_liaison);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception liai)
            {
                throw (liai);
            }
        }
        public static List<Liaison> getLiaisons(Secteur secteur)
        {
            List<Liaison> lc = new List<Liaison>();
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("SELECT ID_LIAISON,IDPORT_DEPART,portDepart.NOM,liaison.ID_SECTEUR,secteur.LIBELLE,IDPORT_ARRIVEE,portArrivee.NOM,DUREE " +
                    "FROM liaison INNER JOIN secteur INNER JOIN port portDepart INNER JOIN port portArrivee " +
                    "ON liaison.ID_SECTEUR=secteur.ID_SECTEUR AND liaison.IDPORT_DEPART=portDepart.IDPORT AND liaison.IDPORT_ARRIVEE=portArrivee.IDPORT " +
                    "where liaison.ID_SECTEUR="+secteur.Id_secteur);
                MySqlDataReader reader = Ocom.ExecuteReader();
                Liaison e;
                while (reader.Read())
                {
                    Port port_dep = new Port((int)reader.GetValue(1), (string)reader.GetValue(2));
                    Port port_arr = new Port((int)reader.GetValue(5), (string)reader.GetValue(6));
                    Secteur secteur_liai = new Secteur((int)reader.GetValue(3), (string)reader.GetValue(4));
                    int id = (int)reader.GetValue(0);
                    string duree = (string)reader.GetValue(7);
                    e = new Liaison(id, port_dep, secteur_liai, port_arr, duree);
                    lc.Add(e);
                }
                reader.Close();
                maConnexionSql.closeConnection();
                return (lc);
            }
            catch (Exception liai)
            {
                throw (liai);
            }
        }
        public static void suppLiaison(Liaison e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Delete from liaison where id_liaison = " + e.Id_liaison);
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception liai)
            {
                throw (liai);
            }
        }
        public static void addLiaison(Liaison e)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();
                Ocom = maConnexionSql.reqExec("Insert Into liaison Values ("+e.Id_liaison+ ","+e.Idport_depart.Id_port+ ","+e.Id_secteur.Id_secteur+ ","+e.Idport_arrive.Id_port+ ",'"+e.Duree+"')");
                int i = Ocom.ExecuteNonQuery();
                maConnexionSql.closeConnection();
            }
            catch (Exception liai)
            {
                throw (liai);
            }
        }
    }
}
