using Madera.Data;
using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Madera.VueModele
{
    public class PlanViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Plan> ChargerPlan()
        {
            List<Plan> lesPlans = new List<Plan>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT nomPlan from Plan");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Plan p = new Plan(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetDateTime(2),
                            reader.GetInt32(3),
                            reader.GetInt32(4),
                            reader.GetInt32(5),
                            reader.GetInt32(6),
                            reader.GetInt32(7),
                            reader.GetInt32(8));
                        lesPlans.Add(p);
                    }
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesPlans;
        }
        public static Boolean CreerPlan(Plan plan)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Plan" +
                    "(nomPlan, datePlan, idProjet, idModule, " +
                    "idSol, idCouverture, idForme, idGamme) " +
                    "VALUES ('"
                    + plan.nomPlan + "', '"
                    + plan.datePlan + "', '"
                    + plan.idProjet + "', '"
                    + plan.idModule + "', '"
                    + plan.idSol + "', '"
                    + plan.idCouverture + "', '"
                    + plan.idForme + "', '"
                    + plan.idGamme + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierPlan(Plan plan)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Module idPlan = '" + plan.idPlan + "'," +
                    " nomPlan = '" + plan.nomPlan + "'," +
                    " datePlan = '" + plan.datePlan + "'," +
                    " idProjet = '" + plan.idProjet + "'," +
                    " idModule = '" + plan.idModule + "'," +
                    " idSol = '" + plan.idSol + "'," +
                    " idCouverture = '" + plan.idCouverture + "'," +
                    " idForme = '" + plan.idForme + "'," +
                    " idGamme = '" + plan.idGamme + "' ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerPlan(Plan plan)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Plan WHERE idPlan = "
                    + plan.idPlan + " ;");
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
