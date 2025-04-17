using _14_Day.user;
using _14_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;

namespace _14_Day.services
{
    public class UserService : IUser, IProfile
    {
        public UserModel? UserLogin(string email, string password)
        {
            if (email.Equals("ali@mail.com") && password.Equals("12345"))
            {
                UserModel user = new UserModel
                {
                    uid = 100,
                    name = "Ali",
                    surname = "Bilmem",
                    email = "ali@mail.com",
                    password = "12345"
                };
                return user;
            }
            return null;
        }

        public bool UserLogout(int uid)
        {
            throw new NotImplementedException();
        }

        public string UserName(int uid)
        {
            throw new NotImplementedException();
        }

        public UserModel? UserPublicProfile(int uid)
        {
            throw new NotImplementedException();
        }

        public bool UserRegister(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public void UserReport(int uid)
        {
            throw new NotImplementedException();
        }

        public UserModel? UserUpdate(UserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
