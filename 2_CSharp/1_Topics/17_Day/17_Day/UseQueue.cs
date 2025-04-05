using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day
{
    public class UseQueue
    {
        public void Call()
        { 
            Queue<string> users = new Queue<string>();

            //Add item
            users.Enqueue("Ali");
            users.Enqueue("Veli");
            users.Enqueue("Zehra");
            users.Enqueue("Ahmet");
            users.Enqueue("Zeki");

            //first Remove item
            users.Dequeue();

            foreach (string item in users)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
