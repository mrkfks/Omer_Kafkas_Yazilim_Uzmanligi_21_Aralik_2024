using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Day
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            string name = "Ali";
            int age = 30;
            bool status = true;
            char c = 't';
            Console.WriteLine(name);

            Console.WriteLine("Kullanıcı Adınız?");
            string username = Console.ReadLine();

            Console.WriteLine("Şifreniz?");
            string password = Console.ReadLine();

            string usernamePassword = $"{username} - {password}";
            Console.WriteLine(usernamePassword);

            // Kullanıcı doğrulama
            if (username.Equals("ali01") && password.Equals("12345"))
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Bilgiler hatalı!");
            }

            // Gün kontrolü
            string day = "Mehmet";
            switch (day)
            {
                case "Pazartesi":
                case "Salı":
                case "Cumartesi":
                    Console.WriteLine($"Bu gün : {day}");
                    break;
                default:
                    Console.WriteLine("Hatalı Gün!");
                    break;
            }

            Console.WriteLine("=================================");

            // Diziler
            string[] users = { "Erkan", "Ahmet", "Faruk", "Serkan" };
            int[] numbers = { 10, 44, 55, 77, 22, 99, 33 };

            int index = -1;
            int size = users.Length;
            Console.WriteLine(size);
            if (index >= 0 && index < size)
            {
                Console.WriteLine(users[index]);
            }
        }
    }
}
