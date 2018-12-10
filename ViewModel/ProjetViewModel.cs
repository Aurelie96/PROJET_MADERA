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
    public class ProjetViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Projet> ChargerProjet()
        {
            List<Projet> lesProjets = new List<Projet>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT nomProjet from Projet");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Projet p = new Projet(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5));
                        lesProjets.Add(p);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesProjets;
        }
        public static Boolean CreerProjet(Projet projet)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Projet" +
                    "(nomProjet, dateProjet, idClient, idCommercial, " +
                    "idDevis) " +
                    "VALUES ('"
                    + projet.nomProjet + "', '"
                    + projet.dateProjet + "', '"
                    + projet.idClient + "', '"
                    + projet.idCommercial + "', '"
                    + projet.idDevis + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierProjet(Projet projet)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Projet idProjet = '" + projet.idProjet + "'," +
                    " nomProjet = '" + projet.nomProjet + "'," +
                    " dateProjet = '" +projet.dateProjet + "'," +
                    " idClient = '" + projet.idClient + "', " +
                    " idCommercial = '" + projet.idCommercial + "', " +
                    " idDevis = '" + projet.idDevis + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerProjet(Projet projet)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Projet WHERE idProjet = "
                    + projet.idProjet + " ;");
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
