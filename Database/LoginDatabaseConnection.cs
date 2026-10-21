
using MySql.Data.MySqlClient;

namespace Student_Information_System.Database
{
    public static class LoginDatabaseConnection
    {
        private static readonly string connectionString =
            "server=127.0.0.1;" +
            "port=3307;" +
            "database=login_db;" +
            "uid=root;" +
            "pwd=Je197@du;" +
            "charset=utf8mb4;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
