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
    }
}
