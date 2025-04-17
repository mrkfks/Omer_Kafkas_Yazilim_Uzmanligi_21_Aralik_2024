﻿using _17_Day.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day
{
    public class UseHashSet
    {
        public void Call() 
        {
            HashSet<string> cities = new HashSet<string>();

            //add item
            cities.Add("Antalya");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("İstanbul");
            cities.Add("İstanbul");
            cities.Add("İstanbul");
            cities.Add("İzmir");
            cities.Add("Adana");
            cities.Add("Samsun");
            


            foreach (string item in cities)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================");
            HashSet<Product> products = new HashSet<Product>();

            Product p1 = new Product("TV", "Tv Detail", 48524, 1);
            Product p2 = new Product("Tablet", "Tablet Detail", 575000, 2);
            Product p3 = new Product("iPad", "iPad Detail", 275227, 3);
            Product p4 = new Product("iPadx", "iPad Detail", 275227, 3);
            
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.WriteLine(p3.GetHashCode());
            Console.WriteLine(p4.GetHashCode());

            products.Add(p1);
            products.Add(p1);
            products.Add(p1);
            products.Add(p1);
            products.Add(p1);
            products.Add(p2);
            products.Add(p2);
            products.Add(p2);
            products.Add(p2);
            products.Add(p3);
            products.Add(p3);
            products.Add(p3);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------");
            User u1 = new User("Ali", "Bilmem", "ali@mail.com", "12345");
            User u2 = new User("Veli", "Bil", "veli@mail.com", "12345");
            User u3 = new User("Zehra", "Bilirim", "zehra@mail.com", "12345");
            User u4 = new User("Zehrax", "Bilirim", "zehra@mail.com", "12345");

            Console.WriteLine(u1.GetHashCode());
            Console.WriteLine(u2.GetHashCode());
            Console.WriteLine(u3.GetHashCode());
            Console.WriteLine(u4.GetHashCode());

            HashSet<User> users = new HashSet<User>();
            users.Add(u1);
            users.Add(u1);
            users.Add(u1);
            users.Add(u1);
            users.Add(u2);
            users.Add(u2);
            users.Add(u2);
            users.Add(u2);
            users.Add(u3);
            users.Add(u3);
            users.Add(u3);
            users.Add(u4);


            foreach (User item in users)
            {
                Console.WriteLine(item);
            }







        }
    }
}
