using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Day
{
    internal class Customer
    {
        internal int age = 30;
        public void call()
        {
            Console.WriteLine("Thi Line CAll");
        }
        public void Params(string name, int age, string? email)
        {
            Console.WriteLine(name);
            int newage = age ?? 10;
            Console.WriteLine(newage);
            string newEmail = email ?? "mail@mail.com";
        }
    }
}
