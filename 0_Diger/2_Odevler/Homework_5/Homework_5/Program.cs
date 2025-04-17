using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        public void Main(string[] args)
        {
            //Soru1: (Nullable Types)
            //Bir int? de�i�ken tan�mlay�n ve bu de�i�kenin null olup olmad���n� kontrol eden bir kod yaz�n.
            //Cevap:

            int? nunableInt = null;
            if (nunableInt == null)
            {
                Console.WriteLine("nunableInt is null");
            }
            else
            {
                Console.WriteLine("nunableInt is not null");
            }

            //Soru2: (String Concat)
            //�ki string de�i�kenini birle�tiren bir metot yaz�n ve bu metodu kullanarak "Hello" ve "World" kelimelerini birle�tirin.
            //Cevap:

            string str1 = "Hello";
            string str2 = "World";
            string str3 = string.Concat(str1, str2);

            //Soru3: (String Equals)
            //�ki string de�i�keninin e�it olup olmad���n� kontrol eden bir kod yaz�n. B�y�k/k���k harf duyarl�l���n� g�z �n�nde bulundurun.
            //Cevap:

            string str4 = "Hello";
            string str5 = "hello";
            if (str4.Equals(str5, StringComparison.Ordinal))
            {
                Console.WriteLine("str4 and str5 are not equal");
            }
            else
            {
                Console.WriteLine("str4 and str5 are equal");
            }

            //Soru4: (String Contains)
            //Bir string i�inde belirli bir alt string'in olup olmad���n� kontrol eden bir metot yaz�n. �rne�in, "Hello World" i�inde "World" kelimesinin olup olmad���n� kontrol edin.
            //Cevap:

            string soru4 = "Hello World";
            if ( soru4.Contains("World"))
            {
                Console.WriteLine("Referans metin i�erisinde aranan deger bulunmaktadir");
            }
            else
            {
                Console.WriteLine("Referans metin i�erisinde aranan deger bulunmamaktadir");
            };


            //Soru5: (String Substring)
            //Bir string'in belirli bir indeksinden ba�layarak bir alt string elde eden bir metot yaz�n. �rne�in, "Hello World" string'inden "World" kelimesini ��kar�n.
            //Cevap:

            string soru5 = "Hello World";
            string altString = soru5.Substring(6, 5);
            Console.WriteLine(altString);

            //Soru6: (String Insert)
            //Bir string'in belirli bir indeksine ba�ka bir string ekleyen bir metot yaz�n. �rne�in, "Hello" string'ine 5. indeksten sonra " World" ekleyin.
            //Cevap:

            string soru6 = "Hello";
            string eklenecekString = "World";
            string yeniString = soru6.Insert(soru6.Length, eklenecekString);
            Console.WriteLine(yeniString);

            //Soru7: (String Remove)
            //Bir string'in belirli bir indeksinden ba�layarak belirli bir uzunluktaki k�sm�n� silen bir metot yaz�n. �rne�in, "Hello World" string'inden "World" kelimesini silin.
            //Cevap:

            string soru7 = "Hello World";
            string silinecekString = "World";
            int index = soru7.IndexOf(silinecekString);
            yeniString = soru7.Remove(index, silinecekString.Length);
            Console.WriteLine(yeniString);

            //Soru8: (String Split)
            //Bir string'i belirli bir karaktere g�re b�len bir metot yaz�n. �rne�in, "Hello,World" string'ini virg�l karakterine g�re b�l�n.
            //Cevap:

            string soru8 = "Hello,World";
            string[] parcalar = soru8.Split(',');
            foreach (string parca in parcalar)
            {
                Console.WriteLine(parca);
            }

            //Soru9: (String Replace)
            //Bir string i�inde belirli bir alt string'i ba�ka bir alt string ile de�i�tiren bir metot yaz�n. �rne�in, "Hello World" string'inde "World" kelimesini "C#" ile de�i�tirin.
            //Cevap:

            string soru9 = "Hello World";
            string degisecekString = "World";
            string yeniDeger = "C#";
            yeniString = soru9.Replace(degisecekString, yeniDeger);
            Console.WriteLine(yeniString);

            //Soru10: (String Trim)
            //Bir string'in ba��ndaki ve sonundaki bo�luklar� kald�ran bir metot yaz�n. �rne�in, " Hello World " string'inin ba��ndaki ve sonundaki bo�luklar� kald�r�n.
            //Cevap:

            

            //Soru11: (String IndexOf)
            //Bir string i�inde belirli bir karakterin veya alt string'in ilk ge�ti�i indeksi bulan bir metot yaz�n. �rne�in, "Hello World" string'inde "World" kelimesinin ba�lad��� indeksi bulun.
            //Cevap:



            //Soru12: (Struct)
            //Bir struct tan�mlay�n ve bu struct'� kullanarak bir nesne olu�turun. �rne�in, bir Point struct'� tan�mlay�n ve bu struct'� kullanarak bir nokta nesnesi olu�turun.
            //Cevap:

            //Soru13: (Enum)
            //Bir enum tan�mlay�n ve bu enum'� kullanarak bir de�i�ken olu�turun. �rne�in, bir DaysOfWeek enum'� tan�mlay�n ve bu enum'� kullanarak bir g�n de�i�keni olu�turup bir fonksiyonlarla birlikte kullan�n.
            //Cevap:


        }
    }
}
