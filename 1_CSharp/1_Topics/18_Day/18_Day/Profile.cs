using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Day
{
    public abstract class Profile
    {
        public abstract int userID();

        public int call(int i) 
        {
        return userID() * i;
        }
    }
}
