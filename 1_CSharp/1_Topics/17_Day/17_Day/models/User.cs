using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day.models
{
    public class User
    {
        private string name;
        private string surname;
        private string email;
        private string password;

        public string Name { set { name = value; } get { return name; } }
        public string Surname { set { surname = value; } get { return surname; } }
        public string Email { set { email = value; } get { return email; } }
        public string Password { set { password = value; } get { return password; } }

        public User(string name, string surname, string email, string password)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.password = password;
        }

        public override string ToString()
        {
            return $"Name: {name}, Surname: {surname}, Email: {email}";
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   name == user.name &&
                   surname == user.surname &&
                   email == user.email &&
                   password == user.password;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, surname, email, password);
        }
    }

}

