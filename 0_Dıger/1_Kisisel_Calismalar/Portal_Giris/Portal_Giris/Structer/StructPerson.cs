using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal_Giris
{
    public struct StructPerson
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }

        public StructPerson(string UserName, string Password, string Email, string Name, string Surname, string PhoneNumber)
        {
            this.UserName = UserName;
            this.Password = Password;
            this.Email = Email;
            this.Name = Name;
            this.Surname = Surname;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return $"UserName: {UserName}, Password: {Password}, Email: {Email}, Name: {Name}, Surname: {Surname}, PhoneNumber: {PhoneNumber}";
        }
    }

}
