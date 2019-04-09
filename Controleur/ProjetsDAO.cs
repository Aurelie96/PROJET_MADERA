using Madera.Data;
using Madera.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Controleur
{
    public class ProjetsDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Projet> ChargerProjet()
        {
            List<Projet> lesProjets = new List<Projet>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT p.idProjet, p.nomProjet, p.dateProjet, cl.nomClient, " +
                    "co.nomCommercial, d.nomDevis FROM projet p, client cl, commercial co, " +
                    "devis d WHERE p.idClient = cl.idClient AND p.idCommercial = co.idCommercial " +
                    "AND p.idDevis = d.idDevis;");
                while (reader.Read())
                {
                    Projet p = new Projet(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetDateTime(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5));
                    lesProjets.Add(p);
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
                connexion.execWrite("INSERT INTO Devis" +
                    "(nomDevis, dateDevis, quantiteDevis, uniteDevis, " +
                    "prixHTDevis, prixTTDevis, margeCommercialDevis, margeEntrepriseDevis," +
                    "idEtat) " +
                    "VALUES ('" +
                    "Devis_"+ projet.nomProjet + "_"+ projet.nomClient +"', '"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "'," +
                    " NULL, NULL, NULL, NULL, NULL, NULL, '1');");
                int devis = DevisDAO.IdDevis("Devis_" + projet.nomProjet + "_" + projet.nomClient);
                connexion.execWrite("INSERT INTO Projet" +
                    "(nomProjet, dateProjet, idClient, idCommercial, " +
                    "idDevis) " +
                    "VALUES ('"
                    + projet.nomProjet + "', '"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '"
                    + projet.idClient + "', '"
                    + projet.idCommercial + "', '"
                    + devis + "');");
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
                connexion.execWrite("UPDATE Projet SET " +
                    " nomProjet = '" + projet.nomProjet + "'," +
                    " idClient = '" + projet.idClient + "', " +
                    " idCommercial = '" + projet.idCommercial + "', " +
                    " idDevis = '" + projet.idDevis + "' " +
                    " WHERE idProjet = '" + projet.idProjet + "' ;");
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
        public static Projet RemplirInfoProjet(String Nom)
        {
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    " p.idProjet, " +
                    " p.nomProjet, " +
                    " p.dateProjet, " +
                    " cl.nomClient, " +
                    " co.nomCommercial, " +
                    " d.nomDevis " +
                    "FROM projet p, client cl, commercial co, devis d " +
                    "WHERE p.idClient = cl.idClient " +
                    "AND p.idCommercial = co.idCommercial " +
                    "AND p.idDevis = d.idDevis " +
                    $"AND p.nomProjet = '{Nom}'");
                reader.Read();
                Projet LeProjet = new Projet(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetDateTime(2),
                reader.GetString(3),
                reader.GetString(4),
                reader.GetString(5));
                reader.Close();
                return LeProjet;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Projet ProjetError = new Projet(0);
                return ProjetError;
            }
        }
        public static List<Projet> RechercherProjet(String nom)
        {
            List<Projet> LesProjets = new List<Projet>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    " p.idProjet, " +
                    " p.nomProjet, " +
                    " p.dateProjet, " +
                    " cl.nomClient, " +
                    " co.nomCommercial, " +
                    " d.nomDevis " +
                    "FROM projet p, client cl, commercial co, devis d " +
                    "WHERE p.idClient = cl.idClient " +
                    "AND p.idCommercial = co.idCommercial " +
                    "AND p.idDevis = d.idDevis " +
                    $"AND p.nomProjet LIKE '%{nom}%'");
                while (reader.Read())
                {
                    Projet LeProjet = new Projet(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetDateTime(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5));
                    LesProjets.Add(LeProjet);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesProjets;
        }
    }
}
