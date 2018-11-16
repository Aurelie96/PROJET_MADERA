using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    class GammeViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Gamme> ChargerGamme()
        {
            List<Gamme> lesGammes = new List<Gamme>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT qualiteHuisserieGamme from Gamme");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Gamme g = new Gamme(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4));
                        lesGammes.Add(g);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesGammes;
        }
        public static Boolean CreerGamme(Gamme gamme)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Gamme" +
                    "(offrePromoGamme, qualiteHuisserieGamme, typeIsolantGamme, typeFinitionGamme) " +
                    "VALUES ('"
                    + gamme.offrePromoGamme + "', '"
                    + gamme.qualiteHuisserieGamme + "', '"
                    + gamme.typeIsolantGamme + "', '"
                    + gamme.typeFinitionGamme + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierGamme(Gamme gamme)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Gamme idGamme = '" + gamme.idGamme + "'," +
                    " offrePromoGamme = '" + gamme.offrePromoGamme + "'," +
                    " qualiteHuisserieGamme = '" + gamme.qualiteHuisserieGamme + "'," +
                    " typeIsolantGamme = '" + gamme.typeIsolantGamme + "'," +
                    " typeFinitionGamme = '" + gamme.typeFinitionGamme + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerGamme(Gamme gamme)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Gamme WHERE idGamme = "
                    + gamme.idGamme + " ;");
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
