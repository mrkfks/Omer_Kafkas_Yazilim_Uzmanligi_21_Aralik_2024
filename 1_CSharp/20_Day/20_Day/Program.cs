using System;
using _20_Day.Models;
using _20_Day.Services;
using MongoDB.Bson;
using MongoDB.Driver;

namespace _20_Day
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonService personService = new ();
            Console.WriteLine($"MongoDB Person Service {ObjectId.GenerateNewId().ToString()}");
            
            Person p1 = new()
            {
                PersonId = ObjectId.GenerateNewId().ToString(),
                Name = "Ali",
                Surname = "Bil",
                Email = "ali@mail.com",
                Age = 25,
                Color = "Red"
            };
            int p1SAve = personService.AddPerson(p1);
            Console.WriteLine($"Save Status: {p1SAve}");
            if (p1SAve == 1)
            {
                Console.WriteLine("Person added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add person.");
            }

            // Get all persons
            List<Person> persons = personService.GetAllPersons();
            foreach (var person in persons)
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
            }


        }
    }
}