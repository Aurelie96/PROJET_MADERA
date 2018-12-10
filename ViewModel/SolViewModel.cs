using Madera.Data;
using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    class SolViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Sol> ChargerSol()
        {
            List<Sol> lesSols = new List<Sol>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT typeSol from Sol");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Sol s = new Sol(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetFloat(2));
                        lesSols.Add(s);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesSols;
        }
        public static Boolean CreerSol(Sol sol)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Sol" +
                    "(typeSol, prixHTSol) " +
                    "VALUES ('"
                    + sol.typeSol + "', '"
                    + sol.prixHTSol + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierSol(Sol sol)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Sol idSol = '" + sol.idSol + "'," +
                    " typeSol = '" + sol.typeSol + "'," +
                    " prixHTSol = '" + sol.prixHTSol + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerSol(Sol sol)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Sol WHERE idSol = "
                    + sol.idSol + " ;");
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
