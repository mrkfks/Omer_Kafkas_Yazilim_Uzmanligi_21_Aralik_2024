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
        //interfaceler nesne olarak üretilemezler
        //burada görevli method yazılamaz
        //bir sınıfa mutlaka implement edilmelidir.

        public bool UserRegister(UserModel userModel);
        public UserModel? UserLogin(string email, string password);
        public string UserName(int uid);
        public void UserReport(int uid);
        public UserModel? UserUpdate(UserModel userModel);
    }
}