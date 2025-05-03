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
            PersonService personService = new PersonService();
            Person p1 = new()
            {
                Id = ObjectId.GenerateNewId(),
                Name = "Ali",
                Surname = "Desidero",
                Email = "alibey@hulkmail.com",
                Age = 30,
                IsActive = true,
                Color = "Red"
            };
            int p1SAve = personService.AddPerson(p1);
            if (p1SAve == 1)
            {
                Console.WriteLine("Person added successfully.");
            }
            else
            {
                Console.WriteLine("Failed to add person.");
            }
        }
    }
}