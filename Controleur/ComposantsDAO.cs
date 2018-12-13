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
    public class ComposantsDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Composant> ChargerComposant()
        {
            List<Composant> lesComposants = new List<Composant>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT nomComposant from Composant");
                while (reader.Read())
                {
                    Composant c = new Composant(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2));
                    lesComposants.Add(c);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesComposants;
        }
        public static Boolean CreerComposant(Composant composant)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Composant" +
                    "(nomComposant, idFamille) " +
                    "VALUES ('"
                    + composant.nomComposant + "', '"
                    + composant.idFamille + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierComposant(Composant composant)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Composant SET " +
                    " nomComposant = '" + composant.nomComposant + "', "
                    + "idFamille = '" + composant.idFamille + "' " +
                    " WHERE idComposant = '" + composant.idComposant + "',;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerComposant(Composant composant)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Composant WHERE idComposant = "
                    + composant.idComposant + " ;");
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
