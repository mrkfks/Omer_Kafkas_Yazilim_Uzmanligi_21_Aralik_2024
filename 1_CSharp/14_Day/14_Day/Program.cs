using _14_Day.models;
using _14_Day.services;
using _14_Day.user;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main(string[] args)
    {
        UserService userService = new UserService();
        object iuserx = new UserService();
        IUser iUserService = new UserService();
        IProfile iProfile = new UserService();

        //userService.UserLogout(10);

        call(userService);
        call(iUserService);
        //call(İUserx);
        //call (iProfile);

        UserModel? userModel = userService.UserLogin("ali@mail.com", "12345");
        if (userModel != null)
        {
            Console.WriteLine("Giriş Başarılı");
        } else
        {
            Console.WriteLine("Bilgileriniz Hatalı!");
        } 
    }

        public static void call (IUser userService)
        {
        userService.UserLogin("","");
        }
    
}