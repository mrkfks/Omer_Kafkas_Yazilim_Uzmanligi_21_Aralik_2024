using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{
        public class Admin : Person
        {
            public override bool Login(string username, string password)
            {
                Console.WriteLine("customer table select");
                bool status = false;
                if (username.Equals("customer") && password.Equals("123"))
                {
                    status = true;
                }
                return status;
            }
        }
}


