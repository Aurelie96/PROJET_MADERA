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
    public class ClientsDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Client> ChargerClient()
        {
            List<Client> lesClients = new List<Client>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idClient," +
                    "nomClient," +
                    "prenomClient," +
                    "adresseClient," +
                    "codePostalClient," +
                    "villeClient," +
                    "emailClient," +
                    "faxClient," +
                    "mobileClient from Client");
                while (reader.Read())
                {
                    Client c = new Client(
                        reader.GetInt32(0), 
                        reader.GetString(1), 
                        reader.GetString(2), 
                        reader.GetString(3),
                        reader.GetString(4), 
                        reader.GetString(5), 
                        reader.GetString(6), 
                        reader.GetString(7), 
                        reader.GetString(8));
                    lesClients.Add(c);
                }
                reader.Close();
            }
            catch (SqlException e)
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
                    + client.GetnomClient() + "', '"
                    + client.GetprenomClient() + "', '"
                    + client.GetadresseClient() + "', '"
                    + client.GetcodePostalClient() + "', '"
                    + client.GetvilleClient() + "', '"
                    + client.GetemailClient() + "', '"
                    + client.GetfaxClient() + "', '"
                    + client.GetmobileClient() + "');");
                test = true;
            }
            catch (SqlException e)
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
                connexion.execWrite("UPDATE Client SET " +
                    " nomClient = '" + client.nomClient + "'," +
                    " prenomClient = '" + client.prenomClient + "', " +
                    " adresseClient = '" + client.adresseClient + "', " +
                    " codePostalClient = '" + client.codePostalClient + "', " +
                    " villeClient = '" + client.villeClient + "', " +
                    " emailClient = '" + client.emailClient + "', " +
                    " faxClient = '" + client.faxClient + "', " +
                    " mobileClient = '" + client.mobileClient + "'" +
                    " WHERE idClient = '" + client.idClient + "' ;");
                test = true;
            }
            catch (SqlException e)
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

        public static Client RemplirInfoClient(String Nom)
        {
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("Select * FROM Client WHERE" +
                    $" nomClient = '{Nom}';");
                reader.Read();
                Client LeClient = new Client(
                reader.GetInt32(0),
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetString(4),
                reader.GetString(5),
                reader.GetString(6),
                reader.GetString(7),
                reader.GetString(8));
                reader.Close();
                return LeClient;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e);
                Client ClientError = new Client(
                    0,
                    "ERREUR",
                    "ERREUR",
                    "ERREUR",
                    "ERREUR",
                    "ERREUR",
                    "ERREUR",
                    "ERREUR",
                    "ERREUR");
                return ClientError;
            }
        }

        public static List<Client> RechercherClient(String nom)
        {
            List<Client> LesClients = new List<Client>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT * FROM Client " +
                    $"WHERE nomClient LIKE '%{nom}%'");
                while (reader.Read())
                {
                    Client LeClient = new Client(
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8));
                    LesClients.Add(LeClient);
                }
                reader.Close();
            }
            catch(SqlException e)
            {
                Console.WriteLine(e);
            }
            return LesClients;
        }
    }
}
