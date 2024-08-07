using ABCCarTraders.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCCarTraders.Healper
{
    internal class DatabaseHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CarDealershipDB"].ConnectionString;

        // Get Connection Method
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        // Executes a non-query SQL command (INSERT, UPDATE, DELETE)
        public static void ExecuteNonQuery(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Executes a SQL command that returns a SqlDataReader (SELECT)
        public static SqlDataReader ExecuteReader(string sql, SqlParameter[] parameters)
        {
            SqlConnection conn = Connection.GetConnection();
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }

        // Executes a SQL command that returns a single value (e.g., COUNT, SUM)
        public static object ExecuteScalar(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

        // Executes a SQL command that returns a DataTable (SELECT with multiple rows/columns)
        public static DataTable ExecuteDataTable(string sql, SqlParameter[] parameters)
        {
            using (SqlConnection conn = Connection.GetConnection())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // For Tracking user
        // Inside DatabaseHelper.cs
        public static string GetRoleForUser(string email)
        {
            using (var conn = Connection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT user_type FROM Users WHERE email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                var usertype = cmd.ExecuteScalar() as string; // Assume role is stored as a string
                return usertype;
            }
        }

        public static int GetUserId(string email)
        {
            using(var conn = Connection.GetConnection())
            {
                conn.Open();
                var cmd = new SqlCommand("SELECT user_id FROM Users WHERE email = @Email", conn);
                cmd.Parameters.AddWithValue("@Email", email);
                var userId = (int)cmd.ExecuteScalar(); // Assume user_id is an integer
                return userId;
            }
        }

    }
}
