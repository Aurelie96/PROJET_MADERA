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
    public class ClientsViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Client> ChargerClient()
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
                    "(nomClient, prenomClient, adresseClient, codePostalClient" +
                    ", villeClient, emailClient, faxClient, mobileClient) " +
                    "VALUES ('"
                    + client.nomClient + "', '"
                    + client.prenomClient + "', '"
                    + client.adresseClient + "', '"
                    + client.codePostalClient + "', '"
                    + client.villeClient + "', '"
                    + client.emailClient + "', '"
                    + client.faxClient + "', '"
                    + client.mobileClient + "');");
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
                connexion.execWrite("UPDATE Client idClient = '" + client.idClient + "'," +
                    " nomClient = '" + client.nomClient + "'," +
                    " prenomClient = '" + client.prenomClient + "', " +
                    " adresseClient = '" + client.adresseClient + "', " +
                    " codePostalClient = '" + client.codePostalClient + "', " +
                    " villeClient = '" + client.villeClient + "', " +
                    " emailClient = '" + client.emailClient + "', " +
                    " faxClient = '" + client.faxClient + "', " +
                    " mobileClient = '" + client.mobileClient + "' ;");
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
                connexion.execWrite("DELETE FROM Client WHERE idClient = "
                    + client.idClient + " ;");
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
