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
    public class DevisDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Devis> ChargerDevis()
        {
            List<Devis> lesDevis = new List<Devis>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT nomDevis from Devis");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Devis d = new Devis(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetFloat(5),
                            reader.GetFloat(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8),
                            reader.GetInt32(9));
                        lesDevis.Add(d);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesDevis;
        }
        public static Boolean CreerDevis(Devis devis)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Devis" +
                    "(nomDevis, dateDevis, quantiteDevis, uniteDevis," +
                    "prixHTDevis, prixTTCDevis, margeCommercialDevis, margeEntrepriseDevis" +
                    "idEtat) " +
                    "VALUES ('"
                    + devis.nomDevis + "', '"
                    + devis.dateDevis + "', '"
                    + devis.quantiteDevis + "', '"
                    + devis.uniteDevis + "', '"
                    + devis.prixHTDevis + "', '"
                    + devis.prixTTDevis + "', '"
                    + devis.margeCommercialDevis + "', '"
                    + devis.margeEntrepriseDevis + "', '"
                    + devis.idEtat + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierDevis(Devis devis)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Devis idDevis = '" + devis.idDevis + "'," +
                    " nomDevis = '" + devis.nomDevis + "'," +
                    " dateDevis = '" + devis.dateDevis + "', " +
                    " quantiteDevis = '" + devis.quantiteDevis + "', " +
                    " uniteDevis = '" + devis.uniteDevis + "', " +
                    " prixHTDevis = '" + devis.prixHTDevis + "', " +
                    " prixTTCDevis = '" + devis.prixTTDevis + "', " +
                    " margeCommercialDevis = '" + devis.margeCommercialDevis + "', " +
                    " margeEntrepriseDevis = '" + devis.margeEntrepriseDevis + "', " +
                    " idEtat = '" + devis.idEtat + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerDevis(Devis devis)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Devis WHERE idDevis = "
                    + devis.idDevis + " ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static int IdDevis(String Nom)
        {
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT idDevis FROM Devis " +
                    $"WHERE nomDevis = '{Nom}'");
                reader.Read();
                Devis LeDevis = new Devis(reader.GetInt32(0));
                reader.Close();
                return LeDevis.idDevis;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Devis DevisError = new Devis(0);
                return DevisError.idDevis;
            }
        }
    }
}
