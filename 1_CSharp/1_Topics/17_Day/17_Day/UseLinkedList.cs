using _17_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day
{
    public class UseLinkedList
    {
        public void Call()
        { 
            LinkedList<models.User> users = new LinkedList<models.User>();

            User u1 = new User("Ali", "Bilmem", "ali@mail.com", "12345");
            User u2 = new User("Veli", "Bil", "veli@mail.com", "12345");
            User u3 = new User("Zehra", "Bilirim", "zehra@mail.com", "12345");
            User u4 = new User("Ayşe", "Bilsin", "ayse@mail.com", "12345");

            users.AddFirst(u1);
            users.AddAfter(users.First, u2);
            u2.Name = "Hasan";
            users.AddAfter(users.First, u2);
            //users.AddBefore(users.Last, u2);
            //users.AddLast(u4);

            foreach (User item in users)
            {
                Console.WriteLine(item);
            }


        }
}
}
