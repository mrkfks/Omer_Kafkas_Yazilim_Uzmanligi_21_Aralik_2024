using _16_Day.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Day
{
    public class UseArrayList
    {
        public void call()
        {
            // ArrayList
            // Tür Farkları olmaksızın
            // tüm değerleri dinamik olarak kullanan yapıdır.
            ArrayList list = new ArrayList();

            // Add
            list.Add("Ahmet");
            list.Add("Mehmet");
            list.Add("Ali");
            list.Add("Zehra");
            list.Add("Furkan");
            list.Add("Haktan");
            list.Add(100);
            list.Add(true);
            list.Add(10.6);

            int size = list.Count;

            Console.WriteLine("Size: " + size);

            // Remove
            // list.Remove("Ali");
            // list.RemoveAt(2); // indexe göre silme işlemi yapar.

            // Contains
            bool dataStatus = list.Contains("Zehra");
            Console.WriteLine("Data Status: " + dataStatus);

            for (int i = 0; i < list.Count; i++)
            {
                object item = list[i];
                if (item is string stItem)
                {
                    Console.WriteLine(stItem.Length);
                }
                Console.WriteLine(list[i]);
            }

            User u1 = new User("Ali", "Bilmem", "ali@mail.com", "12345");
            User u2 = new User("Veli", "Bil", "veli@mail.com", "12345");
            User u3 = new User("Zehra", "Bilirim", "zehra@mail.com", "12345");
            User u4 = new User("Ayşe", "Bilsin", "ayse@mail.com", "12345");

            ArrayList users = new ArrayList();
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            users.RemoveAt(1);

            foreach (User item in users)
            {
                Console.WriteLine(item);
            }
        }
    }
}
