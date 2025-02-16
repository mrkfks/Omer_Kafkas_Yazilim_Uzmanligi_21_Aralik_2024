using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day
{
    public class UseStack
    {
        public void Call()
        {
            Stack<string> users = new Stack<string>();
            //item Add
            users.Push("Ali");
            users.Push("Veli");
            users.Push("Zehra");
            users.Push("Ahmet");
            users.Push("Zeki");

            //item Remove - en son item değerini siler
            users.Pop();


            //Copy To - Boş diziyi doldurur.
            Console.WriteLine("========================");
            string[] arr = new string[users.Count];
            users.CopyTo(arr, 0);
            Console.WriteLine(arr[0]);
            Console.WriteLine("========================");


            foreach (string item in users)
            {
                Console.WriteLine(item);
            }

        }
    }
}
