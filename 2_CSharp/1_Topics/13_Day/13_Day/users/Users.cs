using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{ 
    public class Users: Person
    {
        public override bool Login(string username, string password)
        { 
            DBConnect("users");
            bool status = false;
            if (username.Equals("a") && password.Equals("a")) 
            { 
                status= true;
                nameSurname = "Ali";
            }
            else if (username.Equals("b") && password.Equals("b"))
            {
                status = true;
                nameSurname = "Betül";
            }
            return status;
        }
    }
}
