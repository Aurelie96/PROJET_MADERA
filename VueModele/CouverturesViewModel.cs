using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    public class CouverturesViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Couverture> ChargerCouverture()
        {
            List<Couverture> lesCouvertures = new List<Couverture>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT typeCouverture from Couverture");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Couverture c = new Couverture(
                            reader.GetInt32(0), 
                            reader.GetString(1), 
                            reader.GetFloat(2));
                        lesCouvertures.Add(c);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesCouvertures;
        }
        public static Boolean CreerCouverture(Couverture couverture)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Couverture" +
                    "(typeCouverture, prixHTCouverture) " +
                    "VALUES ('"
                    + couverture.typeCouverture + "', '"
                    + couverture.prixHTCouverture + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierCouverture(Couverture couverture)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Couverture idCouverture = '" + couverture.idCouverture + "'," +
                    " typeCouverture = '" + couverture.typeCouverture + "'," +
                    " prixHTCouverture = '" + couverture.prixHTCouverture + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerCouverture(Couverture couverture)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Couverture WHERE idCouverture = "
                    + couverture.idCouverture + " ;");
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
