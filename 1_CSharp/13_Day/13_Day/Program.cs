using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _13_Day.users;

namespace _13_Day
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Users user = new Users();
            Customer customer = new Customer();
            Admin admin = new Admin();

            Console.WriteLine($"user -> {user.GetHashCode()}");
            Console.WriteLine($"customer -> {customer.GetHashCode()}");
            Console.WriteLine($"admin -> {admin.GetHashCode()}");

           
        }

        public static void call(Person person, string username, string password)
        { 
        bool status = person.Login(username, password);
        Console.WriteLine($"Login Status: {status} - Name: {person.nameSurname}");
            if (person is Customer)
            {
                //person türünü Customer türüne dönüştür.
                Customer c = (Customer) person;
                c.AddBasket(100);
                Console.WriteLine($"c->{c.GetHashCode()}");
            }
        }
    }
}
