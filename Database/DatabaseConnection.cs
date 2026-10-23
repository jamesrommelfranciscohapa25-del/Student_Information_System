using System;
using MySql.Data.MySqlClient;

namespace Student_Information_System.Database
{
    public static class DatabaseConnection
    {

        private static readonly string connectionString =
            "server=127.0.0.1;" + 
            "port=3306;" +
            "database=stud_db;" + 
            "uid=root;" +
            "pwd=powerRangers;" + 
            "charset=utf8mb4;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static bool TestConnection(out string message)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();
                    message = "Connected to MySQL successfully!";
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                message = "MySQL Error " + ex.Number + ": " + ex.Message;
                return false;
            }
            catch (Exception ex)
            {
                message = "Error: " + ex.Message;
                return false;
            }
        }
    }
}
