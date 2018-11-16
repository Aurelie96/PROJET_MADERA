using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    public class ObjectifModuleViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<ObjectifModule> ChargerObjectifModule()
        {
            List<ObjectifModule> lesObjectifModules = new List<ObjectifModule>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT labelObjectifModule from ObjectifModule");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        ObjectifModule om = new ObjectifModule(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetFloat(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5));
                        lesObjectifModules.Add(om);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesObjectifModules;
        }
        public static Boolean CreerObjectifModule(ObjectifModule objectifModule)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO ObjectifModule" +
                    "(labelObjectifModule, prixObjectifModule, idForme, " +
                    "idComposant, idModule) " +
                    "VALUES ('"
                    + objectifModule.labelObjectifModule + "', '"
                    + objectifModule.prixObjectifModule + "', '"
                    + objectifModule.idForme + "', '"
                    + objectifModule.idComposant + "', '"
                    + objectifModule.idModule + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierObjectifModule(ObjectifModule objectifModule)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE ObjectifModule idObjectifModule = '" + objectifModule.idObjectifModule + "'," +
                    " labelObjectifModule = '" + objectifModule.labelObjectifModule + "', "+
                    " prixObjectifModule = '" + objectifModule.prixObjectifModule + "', "+
                    " idForme = '" + objectifModule.idForme + "', "+
                    " idComposant = '" + objectifModule.idComposant + "', "
                    + "idModule = '" + objectifModule.idModule + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerComposant(ObjectifModule objectifModule)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM ObjectifModule WHERE idObjectifModule = "
                    + objectifModule.idObjectifModule + " ;");
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
