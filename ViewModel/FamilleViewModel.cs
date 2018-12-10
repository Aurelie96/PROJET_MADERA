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
    public class FamilleViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Famille> ChargerFamille()
        {
            List<Famille> lesFamilles = new List<Famille>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT nomFamille from Famille");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Famille f = new Famille(
                            reader.GetInt32(0),
                            reader.GetString(1));
                        lesFamilles.Add(f);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesFamilles;
        }
        public static Boolean CreerFamille(Famille famille)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Famille" +
                    "(nomFamille) " +
                    "VALUES ('"
                    + famille.nomFamille + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierFamille(Famille famille)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Famille idFamille = '" + famille.idFamille + "'," +
                    " nomFamille = '" + famille.nomFamille + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerFamille(Famille famille)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Famille WHERE idFamille = "
                    + famille.idFamille + " ;");
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
