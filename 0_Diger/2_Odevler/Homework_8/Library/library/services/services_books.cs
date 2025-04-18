using System.Data;
using Microsoft.Data.SqlClient;
using library.Models;

namespace library.services
{
    public class services_books
    {
        readonly DB _dB;
        public services_books()
        {
            _dB = new DB();
        }
    }
}