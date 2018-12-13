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
    public class SectionsDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Section> ChargerSection()
        {
            List<Section> lesSections = new List<Section>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT labelSection from Section");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Section s = new Section(
                            reader.GetInt32(0),
                            reader.GetString(1));
                        lesSections.Add(s);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesSections;
        }
        public static Boolean CreerSection(Section section)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Section" +
                    "(labelSection) " +
                    "VALUES ('"
                    + section.labelSection + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierSection(Section section)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Section idSection = '" + section.idSection + "'," +
                    " labelSection = '" + section.labelSection + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerSection(Section section)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Section WHERE idSection = "
                    + section.idSection + " ;");
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
