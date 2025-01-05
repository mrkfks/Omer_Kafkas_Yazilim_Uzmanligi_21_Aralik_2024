using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5_Day
{
    public class Users
    {

        //methods - functions
        //fonksiyolar büyük harfle başlar ve sonraki kelimelerde büyük harfle başlar.
        //void
        //return
        //() - parantez içerisine parametreler yazılır.


        //void bir metot'dan geriye bir veri-nesne-değer dönüşü olmayacak ise 
        //bu method oluşturulurken void anahtar kelimesi kullanılır.



        public void UserNameWrite()
        {
            string name = "Mustafa Bilir";
            Console.WriteLine(name);
        }

        public void UserNameConcatSurname(string name, string surname)
        {
            string join = $"{name} {surname}";
            Console.WriteLine(join);
        }

        public void UserLogin(string email, string password)
        {
            if (email.Equals("monster@email.com") && password.Equals("12345"))
            {

                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");

            }
        }

        //return
        //fonksiyon tetiklendiğinde geri döneek veri-nesne-değer tipi belirtilir.

        public int Sum(int num1, int num2)
        {
            //return anahtar kelimesinden sonra kod yazılmaz
            int sm = num1 + num2;
            return sm;
        }
        
        public void CitiesPlaka (string[] cities, string[] plakas)
        {
            string[] arr = new string[cities.Length];
            for (int i = 0; i < cities.Length; i++)
            {
                string city = cities[i];
                string plaka = plakas[i];
                arr[i] = $"{plaka}-{city}";
            }
            return arr;
        }

        public int StringConvertSum (string stAge, string stNumber)
        {
            int age = Convert.ToInt32(stAge);
            int number = Convert.ToInt32(stNumber);
            int sum = age + number;
            Console.WriteLine(sum);
            return sum;
        }

        public void AreaCall(int x, int y)
        {
            Action action = new Action();
            int y2 = action.call(y);
            int end = x * y2;
            return end;
        }

        public void ComputerCall (string name, Action action)
        {
            if (action != null)
            {
                int end = action.call(10);
                string write = $"{name} - {end}";
                Console.WriteLine(write);
            }
            else
            {
                Console.WriteLine("Action is not null");
            }

            //Overload method
            //Aynı isimde farklı parametreler alan metotlar oluşturulabilir.

            public void call ()
            {
              Console.WriteLine ()  
            }
        }

    }
}

