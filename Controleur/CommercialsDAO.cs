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
    public class CommercialsDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Commercial> chargerCommercial()
        {
            List<Commercial> lesCommercials = new List<Commercial>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT idCommercial," +
                    "nomCommercial," +
                    "prenomCommercial," +
                    "loginCommercial," +
                    "motDePasseCommercial from Commercial");
                while (reader.Read())
                {
                    Commercial c = new Commercial(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4));
                    lesCommercials.Add(c);
                }
                reader.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesCommercials;
        }

        public static Boolean ExisteCommercial(string login, string pwd)
        {
            Boolean exist = false;
            try
            {
                MySqlDataReader mySqlDataReader;
                mySqlDataReader = connexion.execRead("SELECT nomCommercial, prenomCommercial from Commercial WHERE loginCommercial = '" + login + "' AND motDePasseCommercial = '" + pwd + "'");
                exist = mySqlDataReader.HasRows;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return exist;
        }

        public static string GetInfosCommercial(string login, string pwd)
        {
            string infos = String.Empty;
            if (ExisteCommercial(login, pwd))
            {
                MySqlDataReader dataReader;
                dataReader = connexion.execRead("SELECT nomCommercial, prenomCommercial from Commercial WHERE loginCommercial='" + login + "' AND motDePasseCommercial='" + pwd + "'");
                while(dataReader.Read())
                {
                    infos = dataReader.GetString(0).ToUpper() + " " + dataReader.GetString(1);
                }
            }
            return infos;
        }

        public static Boolean CreerCommercial(Commercial commercial)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Commercial" +
                    "(nomCommercial, prenomCommercial, loginCommercial, motDePasseCommercial) " +
                    "VALUES ('"
                    + commercial.nomCommercial + "', '"
                    + commercial.prenomCommercial + "', '"
                    + commercial.loginCommercial + "', '"
                    + commercial.motDePasseCommercial + "');");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierCommercial(Commercial commercial)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Commercial SET " +
                    " nomCommercial = '" + commercial.nomCommercial + "'," +
                    " prenomCommercial = '" + commercial.prenomCommercial + "', " +
                    " loginCommercial = '" + commercial.loginCommercial + "', " +
                    " motDePasseCommercial = '" + commercial.motDePasseCommercial + "' " +
                    " WHERE idCommercial = '" + commercial.idCommercial + "';");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerCommercial(Commercial commercial)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Commercial WHERE idCommercial = "
                    + commercial.idCommercial + " ;");
                test = true;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static int IdCommercial(String Nom)
        {
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT idCommercial FROM Commercial " +
                    $"WHERE nomCommercial = '{Nom}'");
                reader.Read();
                Commercial LeCommercial = new Commercial(reader.GetInt32(0));
                reader.Close();
                return LeCommercial.idCommercial;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Commercial CommercialError = new Commercial(0);
                return CommercialError.idCommercial;
            }
        }
    }
}
