using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _9_Day.models
{
    public struct Users
    {
        public struct User
        {
            public string firstName;
            public string lastName;
            public int age;

            public User(string firstName, string lastName, int age)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.age = age;
            }
        public string allData() 
        {
                return $"{firstName} - {lastName} - {age}";
        }
        public override string ToString()
            {
                return base.ToString();
            }
        }
}
