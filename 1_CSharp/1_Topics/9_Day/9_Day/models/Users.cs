using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Day.models
{
    public struct Users
    {
        public string name;
        public string surname;
        public int age;

        public string allData()
        {
            return $"Name: {name} Surname: {surname} Age: {age}";
        }
    }
}
