using _14_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Day.user
{
    public interface IUser
    {
       bool UserRegister(UserModel userModel);
       UserModel UserLogin(string email, string password);
    }


}
