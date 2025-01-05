using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //nesne üretimi
            Users users = new Users();
            // "." operatörü ile nesne üzerindeki metotlara ve özelliklere erişebiliriz.
            
            users.UserNameWrite();
            users.UserNameConcatSurname("Zehra", "Bilirim");
            users.UserNameConcatSurname("Ali", "Bilmem");

            users.UserLogin("monster@email.com", "12345");

         int sm = users.Sum(5, 10);
            Console.WriteLine(sm);


            //dizideki her bir elemanın başına şehir plakası ekle
            string[] cities = { "İstanbul", "Ankara", "Adana", "İzmir" };
            string[] plakas = { "34", "06", "01", "35" };
            cities = users.CitiesPlaka (cities, plakas);

            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }

            int stSum = users.StringConvertSum("25", "100");
            if (stSum > 50)             
            {
                Console.WriteLine("stSum > 50");
            }
            else
            {
                Console.WriteLine("stSum < 50");
            }

            Action action = new Action();
            users.ComputerCall("MacbookPro", action);
        }
    }
}
