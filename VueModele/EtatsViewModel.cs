using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    public class EtatsViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Etat> ChargerEtat()
        {
            List<Etat> lesEtats = new List<Etat>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT libelleEtat from Etat");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Etat e = new Etat(
                            reader.GetInt32(0),
                            reader.GetString(1));
                        lesEtats.Add(e);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesEtats;
        }
        public static Boolean CreerEtat(Etat etat)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Etat" +
                    "(libelleEtat) " +
                    "VALUES ('"
                    + etat.libelleEtat + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierEtat(Etat etat)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Etat idEtat = '" + etat.idEtat + "'," +
                    " libelleEtat = '" + etat.libelleEtat + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerEtat(Etat etat)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Etat WHERE idEtat = "
                    + etat.idEtat + " ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
    }
}
