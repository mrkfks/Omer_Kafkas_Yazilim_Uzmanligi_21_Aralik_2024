using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{
    public class Person
    {
        public string nameSurname = "";
        public virtual bool Login(string username, string password)
        { 
            return false;
        }
    }
}
