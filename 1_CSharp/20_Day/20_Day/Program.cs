using System;
using _20_Day.Models;
using _20_Day.Services;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using _20_Day.Utils;
using System.Security.Cryptography.X509Certificates;

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

            //Delete Person
            personService.Deleteperson("68171a534f23ec73ceba4876");

            //Delete Person by Email
            long deleteCount = personService.DeletePersonByEmail("alibey@hulkmail.com");
            Console.WriteLine($"Deleted {deleteCount} persons with the email");

            //Update Person

            string Id = "68171a534f23ec73ceba4876";
            Person p2 = new()
            {
                Id = ObjectId.Parse(Id),
                PersonId = ObjectId.GenerateNewId().ToString(),
                Name = "Ali",
                Surname = "Bil",
                Email = "bilalibil@mail.com",
                Age = 25,
                IsActive = true,
                Color = "brown"
            };
            bool updateStatus = personService.UpdatePerson(p2);
            Console.WriteLine($"Update Status: {updateStatus}");

            // Get all persons
            List<Person> persons = personService.GetAllPersons();
            foreach (var person in persons)
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Surname: {person.Surname}, Age: {person.Age}");
            }

            Console.WriteLine("***************");
            UserService userService = new ();
            UserPage userPage = userService.GetAllUsersPage(10, 1);
            Console.WriteLine($"Total Count: {userPage.TotaalCount}");
            Console.WriteLine($"Total Page: {userPage.TotalPage}");
            foreach (var user in userPage.Users)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}");
            }
            Console.WriteLine("***************");

            // yaşı 30'dan büyük ve ip adresleri belirli bir aralıkta olan kullanıcıları listeleme
            List<User> users = userService.AgeIp(30, "249");

            foreach (var user in users)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}, IP Address: {user.ip_adress}");
            }
            Console.WriteLine("***************");

            //son bir ayda kaydedilen kullanıcıları listeleme
            List<User> userDate = userService.UserDateReport();
            foreach (var user in userDate)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}, Date: {user.Date}");
            }
            Console.WriteLine("***************");
            //Cinsiyete göre gruplama
            var genderStatus = userService.GroupByGender("Male"); // Example: Passing "Male" as the gender argument
            foreach (var group in genderStatus)
            {
                Console.WriteLine($"Gender: {group.Gender}, Count: {group.Count}");
            }

            Console.WriteLine("***************");

            //Ortalama Yaş hesaplama
            double AverageAge = userService.AverageAge();
            Console.WriteLine($"Average Age: {AverageAge}");

            Console.WriteLine("***************");

            //en yaşlı 5 kullanıcıyı listeleme

            List<User> top5OldestUsers = userService.GetTop5OldestUsers();
            foreach (var user in top5OldestUsers)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}");
            }

            Console.WriteLine("***************");

            //email null yada "" olanlarını listeleme
            List<User> usersWithNullEmail = userService.GetEmailNullOrEmpty();
            foreach (var user in usersWithNullEmail)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}");
            }
            Console.WriteLine("***************");
            //yaşı 30'dan büyük olan kullanıcıları listeleme
            List<User> getUsersAgeName = userService.GetUsersByAgeRange(30, 50);
            foreach (var user in getUsersAgeName)
            {
                Console.WriteLine($"ID: {user.UId}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.Email}, Age: {user.Age}");
            }
        }
    }
}