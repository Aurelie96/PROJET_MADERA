using Madera.Modele;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Controlleur
{
    class Clients
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Client> chargerClient()
        {
            List<Client> lesClients = new List<Client>();
            try
            {
                SqlDataReader reader;
                reader = connexion.execRead("SELECT NomClient from Clients");
                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        Client c = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),
                            reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8));
                        lesClients.Add(c);
                    }
                }
                reader.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            return lesClients;
        }
        public static Boolean CreerClient(Client client)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Client" +
                    "(Nom, Prenom, Adresse, CodePostal, Ville," +
                    "Email, Fax, Mobile) " +
                    "VALUES ('"
                    + client.Nom + "', '"
                    + client.Prenom + "', '"
                    + client.Adresse + "', '"
                    + client.CodePostal + "', '"
                    + client.Ville + "', '"
                    + client.Email + "', '"
                    + client.Fax + "', '"
                    + client.Mobile + "');");
                test = true;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierClient(Client client)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Client Id = '" + client.Id + "'," +
                    " Nom = '" + client.Nom + "'," +
                    " Prenom = '" + client.Prenom + "', " +
                    " Adresse = '" + client.Adresse + "', " +
                    " CodePostal = '" + client.CodePostal + "', " +
                    " Ville = '" + client.Ville + "', " +
                    " Email = '" + client.Email + "', " +
                    " Fax = '" + client.Fax + "', " +
                    " Mobile = '" + client.Mobile + "' ;");
                test = true;
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerClient(Client client)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Client WHERE Id = "
                    + client.Id + " ;");
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
