using _12_Day.inheritance;
using _12_Day.users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Day
{
    public class Program
    {
        public static void Main (string[] args)
        {
            UserLogin userLogin = new UserLogin();
            UserLogin user = new UserLogin("http://sanalDb.com");
            UserLogin userx = new UserLogin("http://yerelDb.com");

            user.UserRegister();
            user.UserRemember();

            userx.UserRegister();
            userx.UserRemember();

            //////////////////////////////////////////
            Console.WriteLine("=============================");
            Base a = new A();
            B b = new B();
            C c = new C();

            // a => ?
            // a => A
            // a => Base
            // a => A + Base

            a.Call();
            b.Call();
            c.Call();

        }
    }
}
