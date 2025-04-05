using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Day.users
{
    public class Moderator : Person
    {
        public override bool Login(string username, string password)
        { 
            return true;
        }

        public void getStatus(int uid)
        {
            if (uid > 100)
            {
                Login("a", "a");
            }

            else
            {
                base.Login("b", "b");
            }

        }
    }
}
