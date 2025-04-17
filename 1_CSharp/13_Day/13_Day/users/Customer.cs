using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{
    public class Customer : Person
    {
        public override bool Login(string username, string password)
        { 
            DBConnect("Customers");
            bool status = false;
            if (username.Equals("c") && password.Equals("c"))
            {
                status = true;
                nameSurname = "Cem";
            }
            else if (username.Equals("d") && password.Equals("d"))
            {
                status = true;
                nameSurname = "Deniz";
            }
            return status;
        }

        public void AddBasket(int pid)
        { 
            Console.WriteLine($"Add Basket Success: {pid}");
        }

    }
        
}
