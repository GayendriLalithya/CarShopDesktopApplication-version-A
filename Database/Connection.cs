using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace ABCCarTraders.Database
{
    //internal class Connection
    //{
    //    private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

    //    public static SqlConnection GetConnection()
    //    {
    //        SqlConnection connection = new SqlConnection(connectionString);
    //        connection.Open();
    //        return connection;
    //    }
    //}

    internal class Connection
    {
        private SqlConnection conn;

        public Connection()
        {
            // Initialize the connection with the DB using the connection Query
            conn = new SqlConnection("Data Source=HP-15S\\SQLEXPRESS;Initial Catalog=CarDealershipDB;Integrated Security=True");
        }

        // Open connection method
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        // Close connection method
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

        // Get Connection Method
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
