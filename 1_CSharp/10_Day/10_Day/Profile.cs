using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Day
{
    internal class Profile
    {
        //kurucu metotlar 
        //Bir sınıf kurulurken sınıf içine parametre göndermeye yarar. 

        //Kurallar
        //Sınıf adı ile aynı isme sahip olmalıdır.
        //void - return anahtar kelimesi alamazlar.
        //Yazılmadığında default kurucu metot çalışmış olur.
        //yazıldığında default kurucu metot çalışmaz. artık bizim yazdığımız geçerlidir.

        string name = "";
        string surname = "";

        public Profile() 
        {
        
        }

        public Profile(string name)
        {
            this.name = name;
        }

        public Profile(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void call()
        {
            if (!name.Equals(""))
            { 
                Console.WriteLine(name);
            }
            if (!surname.Equals(""))
            {
                Console.WriteLine(surname);
            }
        }


        public string ProfileName() 
        {
            return "Ali Bilmem";
        }
        
    }
}
