using Microsoft.Data.SqlClient;
using System;

namespace _19_Day
{
    public class DB
    {
        static string _connectionString = "Server=.;Database=contacts;Integrated Security=True;TrustServerCertificate=True;";
        SqlConnection _connection = new SqlConnection(_connectionString);

        public SqlConnection GetConnection()
        {
            try
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                    Console.WriteLine("Connection opened successfully.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                return null;
            }
            return _connection;
        }
    
    public void CloseConnection()
    {
       try
       {
        if(_connection.State == System.Data.ConnectionState.Open)
        {
            _connection.Close();
            Console.WriteLine("Connection closed successfully.");
        }
       }
       catch (SqlException ex)
       {
           Console.WriteLine("Error closing the database connection: " + ex.Message);
       }
    }
}
}