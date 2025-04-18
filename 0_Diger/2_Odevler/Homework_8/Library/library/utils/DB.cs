using Microsoft.Data.SqlClient;
using System.Data;

namespace Library.utils
{
    public class DB
    {
        static string _connectionString = "Server=.;Database=contacts;Integrated Security=True;TrustServerCertificate=True;";
        private SqlConnection _connection = new SqlConnection(_connectionString);

        public SqlConnection GetConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Connection Opened Successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return _connection;
        }

        public void CloseConnection()
        {
            try
            {
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                    Console.WriteLine("Connection Closed Successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}