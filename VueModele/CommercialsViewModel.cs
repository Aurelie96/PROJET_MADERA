using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    public class CommercialsViewModel
    { 
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Commercial> chargerCommercial()
        {
            List<Commercial> lesCommercials = new List<Commercial>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT NomCommercial from Commercials");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Commercial c = new Commercial(
                            reader.GetInt32(0), 
                            reader.GetString(1), 
                            reader.GetString(2), 
                            reader.GetString(3),
                            reader.GetString(4));
                        lesCommercials.Add(c);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesCommercials;
        }
        public static Boolean CreerCommercial(Commercial commercial)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Commercials" +
                    "(Nom, Prenom, Login, Password) " +
                    "VALUES ('"
                    + commercial.Nom + "', '"
                    + commercial.Prenom + "', '"
                    + commercial.Login + "', '"
                    + commercial.Password + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierCommercial(Commercial commercial)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Commercials Id = '" + commercial.Id + "'," +
                    " Nom = '" + commercial.Nom + "'," +
                    " Prenom = '" + commercial.Prenom + "', " +
                    " Login = '" + commercial.Login + "', " +
                    " Password = '" + commercial.Password + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerCommercial(Commercial commercial)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Commercial WHERE Id = "
                    + commercial.Id + " ;");
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
