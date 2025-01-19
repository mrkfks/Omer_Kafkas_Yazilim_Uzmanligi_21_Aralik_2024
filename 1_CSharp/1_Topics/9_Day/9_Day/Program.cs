using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _9_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] srr = { "TV", "İphone", "Samsung Galaxy", "Tablet" };
            string[] images = { "tv. jpg", "İphone.jpg", "samsung.jpg" };

            Product p1, p2;
            p1.title = "TV";
            p1.detail = "Tv Detail";
            p1.price = 100;
            p1.status = true;

            p2.title = "Telefon";
            p2.detail = "İphone Details";
            p2.price = 30000;
            p2.status = true;



            Product p3 = new Product(300, "samsung", "samsung detail", 20000, true);

            Product[] products = { p1, p2, p3 };
            foreach (Product item in products)
            {
                Console.WriteLine($"{item.pid} - {item.title} - {item.detail}");
            }

            Console.WriteLine("==============================");
            //5 tane kullanıcı olsun, herbir kullanıcı için ad, soyad, yaş istensin 5 kullanıcının verileri yazılsın.

            Console.WriteLine("Kullanıcı Sayısını Giriniz!");
            int userCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Kullanıcı Sayısı : {userCount}");

            User[] users = new User[userCount];
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine($"Kullanıcı {i + 1} Adı:");
                string firstName = Console.ReadLine();
                Console.WriteLine($"Kullanıcı {i + 1} Soyadı:");
                string lastName = Console.ReadLine();
                Console.WriteLine($"Kullanıcı {i + 1} Yaşı:");
                int age = Convert.ToInt32(Console.ReadLine());

                users[i] = new User(firstName, lastName, age);
            }

            Console.WriteLine("==============================");
            Console.WriteLine("Kullanıcı Bilgileri:");
            foreach (User user in users)
            {
                Console.WriteLine($"Ad: {user.firstName}, Soyad: {user.lastName}, Yaş: {user.age}");
                Console.WriteLine()
            }
        }
    }
