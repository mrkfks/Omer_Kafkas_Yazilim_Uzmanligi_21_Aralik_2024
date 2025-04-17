using _6_Day;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Day
{
    internal class AppMain
    {
        static void Main(string[] args)
        {
            // Action -> Sınıf
            // action -> nesne
            // new -> aynısının kopyası - bellek
            // Action(); -> kurucu method
            Action action = new Action();
            object action1 = new Action();
            string name = "34564564f45645";
            object surname = "Bilmem";

            // Fibonacci metodunu çağırma
            action.Fibonacci(10);

            string[] users = { "Kemal", "Ali" };
            object[] arr = { action, action1, name, 100 };
            for (int i = 0; i < arr.Length; i++)
            {
                object item = arr[i];
                Console.WriteLine(item);
                if (item is Action)
                {
                    Action itemAction = (Action)item;
                    // itemAction ile yapılacak işlemler
                }
            }

            // StringValid metodunu çağırma
            bool statu = action.StringValid("Ali01");
            Console.WriteLine(statu);
        }
    }

}
