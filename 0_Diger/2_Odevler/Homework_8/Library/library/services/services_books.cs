using System.Data;
using Microsoft.Data.SqlClient;
using library.Models;
using library.services;
using library.utils.DB;
using System.Data.SqlTypes;

namespace library.services
{
    public class services_books
    {
        readonly DB _dB;
        public services_books()
        {
            _dB = new DB();
        }
        public int AddBook(Book book)
        {
            int result = 0;
            try
            {
                string query = "INSERT INTO books (Writers_ID, Title, Publication_Year, ISBN) VALUES(@Writers_ID, @Title, @Publication_Year, @ISBN); SELECT SCOPE_IDENTITY();";
                SqlCommand command = new SqlCommand(query, _dB.GetConnection());
                command.Parameters.AddWithValue("@Writers_ID", book.Writers_ID);
                command.Parameters.AddWithValue("@Title", book.Title);
                command.Parameters.AddWithValue("@Publication_Year", book.Publication_Year);
                command.Parameters.AddWithValue("@ISBN", book.ISBN);

                result = command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                _dB.CloseConnection();
            }
            return result;
        }
        
    }
        
}