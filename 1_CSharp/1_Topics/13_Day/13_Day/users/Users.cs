using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{ 
    public class Users: Person
    {
        public override bool Login(string username, string password)
        {
            Console.WriteLine("user table select");
            bool status = false;
            if (username.Equals ("admin") && password.Equals ("123"))
            {
                status = true;
            }
            else if (username.Equals("user") && password.Equals("123"))
            {
                status = true;
            }
            return status;
        }
    }
}
