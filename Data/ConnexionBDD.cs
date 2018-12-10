using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madera.Data
{
    public class ConnexionBDD
    {
        public static string dataSource = "localhost";
        public static string catalog = "madera";
        public static string user = "root";
        public static string password = "root";

        private SqlConnection sqlConnection;
        private void connection()
        {
            sqlConnection = new SqlConnection("Data Source=" + dataSource + "; Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + user + "; Password=" + password);
            sqlConnection.Open();
        }
        public void deconnection()
        {
            sqlConnection.Close();
        }
        public SqlDataReader execRead(String requete)
        {
            this.connection();
            SqlCommand command = new SqlCommand(requete);
            command.Connection = sqlConnection;
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void execWrite(String requete)
        {
            this.connection();
            SqlCommand command = new SqlCommand(requete);
            command.Connection = sqlConnection;
            command.ExecuteNonQuery();
            deconnection();
        }
        public static string DataSource()
        {
            return dataSource;
        }
    }
}
