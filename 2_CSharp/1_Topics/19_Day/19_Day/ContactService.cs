using System.Data;
using Microsoft.Data.SqlClient;
using _19_Day;

namespace _19_Day
{
    public class ContactService
    {
        readonly DB _dB;

        public ContactService()
        {
            _dB = new DB();
        }

        public int AddContact(Contact contact)
        {
            int result = 0;
            try
            //insert query
            {
                string query = "INSERT INTO Contact (Name, Surname, Email, Phone, Address) VALUES (@Name, @Surname, @Email, @Phone, @Address)";
                SqlCommand command = new SqlCommand(query, _dB.GetConnection());
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Surname", contact.Surname);
                command.Parameters.AddWithValue("@Email", contact.Email);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Address", contact.Address);

                //result = Convrt.ToInt32(command.ExecuteScalar()); SCOPE IDENTITY() ile eklenen satırın ID'sini alırız
                result = Convert.ToInt32(command.ExecuteScalar()); // SCOPE IDENTITY() ile eklenen satırın ID'sini alırız;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                _dB.CloseConnection();
            }
            return result;
        }
    }
}