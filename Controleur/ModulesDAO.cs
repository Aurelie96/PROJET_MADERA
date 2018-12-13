using Madera.Data;
using Madera.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Madera.Controleur
{
    public class ModulesDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Module> ChargerModule()
        {
            List<Module> lesModules = new List<Module>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT nomModule from Module");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Module m = new Module(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetFloat(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8));
                        lesModules.Add(m);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesModules;
        }
        public static Boolean CreerModule(Module module)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Module" +
                    "(nomModule, prixHTModule, nbSectionModule, coordonneeDebutXModule, " +
                    "coordonneeDebutYModule, coordonneeFinXModule, coordonneeFinYModule," +
                    "idSectionModule) " +
                    "VALUES ('"
                    + module.nomModule + "', '"
                    + module.prixHTModule + "', '"
                    + module.nbSectionModule + "', '"
                    + module.coordonneeDebutXModule + "', '"
                    + module.coordonneeDebutYModule + "', '"
                    + module.coordonneeFinXModule + "', '"
                    + module.coordonneeFinYModule + "', '"
                    + module.idSectionModule + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierModule(Module module)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Module idModule = '" + module.idModule + "'," +
                    " nomModule = '" + module.nomModule + "'," +
                    " prixHTModule = '" + module.prixHTModule + "'," +
                    " nbSectionModule = '" + module.nbSectionModule + "'," +
                    " coordonneeDebutXModule = '" + module.coordonneeDebutXModule + "'," +
                    " coordonneeDebutYModule = '" + module.coordonneeDebutYModule + "'," +
                    " coordonneeFinXModule = '" + module.coordonneeFinXModule + "'," +
                    " coordonneeFinYModule = '" + module.coordonneeFinYModule + "'," +
                    " idSectionModule = '" + module.idSectionModule + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerModule(Module module)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Module WHERE idModule = "
                    + module.idModule + " ;");
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
