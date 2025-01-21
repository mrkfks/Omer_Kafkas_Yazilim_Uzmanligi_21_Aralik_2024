using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using _9_Day.models;
using _9_Day.utils;

namespace _9_Day
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            string[] arr = { "TV", "İPhone", "Samsung Galaxy", "Tablet"};
            string[] images = { "tv.jpg", "iphone.jpg", "samsung.jpg", "tablet.jpg" };

            Product p1, p2;
            
            p1.pid = 100;
            p1.title = "TV";
            p1.detail = "TV Detail";
            p1.price = 1000;
            p1.status = true;

            p2.pid = 200;

            if (true)
            { p2.title = "İPhone"; }
            else
            { p2.title = "İphone X"; }
            p2.detail = "İPhone Detail";
            p2.price = 30000;
            p2.status = true;

            Product p3 = new Product(300, "Samsung", "Samsung Detail", 20000, true);

            Product[] products = { p1, p2, p3 };
            foreach (Product item in products) 
            {
                Console.WriteLine($"{item.pid} - {item.title} - {item.detail}");
            }

            //kullanıcı sayısı
            //5
            //herbir kullanıcı için adı, soyadı, yaşı istensin.
            //5. kullanıcı değeri tamamlandıktan sonra tüm kullanıcı verileri yazılsın.

            Console.WriteLine("Kullanıcı Sayısını Giriniz: ");
            string stNumber = Console.ReadLine();
            int userCount = Convert.ToInt32(stNumber);
            Console.WriteLine($"Kullanıcı Sayısı : {userCount}");

            Users[] users = new Users[userCount];
            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine($"{i + 1}. Kullanıcı Adı: ");
                string name = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Kullanıcı Soyadı: ");
                string surname = Console.ReadLine();
                Console.WriteLine($"{i + 1}. Kullanıcı Yaşı: ");
                string age = Console.ReadLine();
                
            }

            foreach (Users item in users)
            {
                Console.WriteLine($"{item.name} - {item.surname} - {item.age}");
            }

            Console.WriteLine("==============================================");

            int dayNumber = Profile.Days(eDay.CARSAMBA);
            Console.WriteLine($"Seçilen Gün : {dayNumber}");

        }
    }
}
