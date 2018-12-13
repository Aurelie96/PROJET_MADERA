using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Madera.Data
{
    public class ConnexionBDD
    {
        public static string dataSource = "localhost";
        public static string port = "3306";
        public static string catalog = "madera";
        public static string user = "root";
        public static string password = "root";

        public MySqlDataReader execRead(String requete)
        {
            string connexionString = $"server={dataSource};user={user};database={catalog};persistsecurityinfo=True;port={port};password={password};SslMode=none";
            MySqlConnection conn = new MySqlConnection(connexionString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(requete);
                command.Connection = conn;
                MySqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
        public void execWrite(String requete)
        {
            string connexionString = $"server={dataSource};user={user};database={catalog};persistsecurityinfo=True;port={port};password={password};SslMode=none";
            MySqlConnection conn = new MySqlConnection(connexionString);
            try
            {
                conn.Open();
                MySqlCommand command = new MySqlCommand(requete);
                command.Connection = conn;
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static string DataSource()
        {
            return dataSource;
        }
    }
}
