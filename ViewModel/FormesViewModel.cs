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
    class FormesViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Forme> ChargerForme()
        {
            List<Forme> lesFormes = new List<Forme>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT labelForme from Forme");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Forme f = new Forme(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetFloat(2),
                            reader.GetFloat(3),
                            reader.GetFloat(4));
                        lesFormes.Add(f);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesFormes;
        }
        public static Boolean CreerForme(Forme forme)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Forme" +
                    "(labelForme, longeurForme, largeurForme, prixHT) " +
                    "VALUES ('"
                    + forme.labelForme + "', '"
                    + forme.longueurForme + "', '"
                    + forme.largeurForme + "', '"
                    + forme.prixHTForme + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierForme(Forme forme)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Forme idForme = '" + forme.idForme + "'," +
                    " labelForme = '" + forme.labelForme + "'," +
                    " longeurForme = '" + forme.longueurForme + "'," +
                    " largeurForme = '" + forme.largeurForme + "'," +
                    " prixHT = '" + forme.prixHTForme + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerForme(Forme forme)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Forme WHERE idForme = "
                    + forme.idForme + " ;");
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
