using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Actions action = new Actions();

            // Soru1: (Nullable Types)
            int? nullableInt = null;
            if (nullableInt == null)
            {
                Console.WriteLine("nullableInt is null");
            }
            else
            {
                Console.WriteLine("nullableInt is not null");
            }

            // Soru2: (String Concat)
            string str1 = "Hello";
            string str2 = "World";
            string resultConcat = action.stringConcat(str1, str2);
            Console.WriteLine(resultConcat);

            // Soru3: (String Equals)
            string str4 = "Hello";
            string str5 = "hello";
            bool resultEquals = action.stringEquals(str4, str5);
            Console.WriteLine(resultEquals ? "word3 and word4 are equal" : "word3 and word4 are not equal");

            // Soru4: (String Contains)
            string text = "Hello World";
            string word5 = "World";
            bool resultContains = action.stringContains(text, word5);
            Console.WriteLine(resultContains ? "Referans metin içerisinde aranan deger bulunmaktadir" : "Referans metin içerisinde aranan deger bulunmamaktadir");

            // Soru5: (String Substring)
            string resultSubstring = action.stringSubstring("Hello World", 6, 5);
            Console.WriteLine(resultSubstring);

            // Soru6: (String Insert)
            string soru6 = "Hello";
            string eklenecekString = " World";
            string resultInsert = action.stringInsert(soru6, 5, eklenecekString);
            Console.WriteLine(resultInsert);

            // Soru7: (String Remove)
            string text3 = "Hello World";
            string deleteString = "World";
            string resultRemove = action.stringRemove(text3, deleteString);
            Console.WriteLine(resultRemove);

            // Soru8: (String Split)
            string soru8 = "Hello,World";
            char bracket = ',';
            string[] resultSplit = action.stringSplit(soru8, bracket);
            foreach (var word in resultSplit)
            {
                Console.WriteLine(word);
            }

            // Soru9: (String Replace)
            string soru9 = "Hello World";
            string degisecekString = "World";
            string yeniDeger = "C#";
            string resultReplace = action.stringReplace(soru9, degisecekString, yeniDeger);
            Console.WriteLine(resultReplace);

            // Soru10: (String Trim)
            string resultTrim = action.stringTrim(" Hello World ");
            Console.WriteLine(resultTrim);

            // Soru11: (String IndexOf)
            string Soru11 = "Hello World";
            string textSearch = "World";
            int resultIndexOf = action.stringIndexOf(Soru11, textSearch);
            Console.WriteLine(resultIndexOf);

            // Soru12: (Struct)
            Personel personel = new Personel("Ali", "Veli", 25, "Istanbul");
            personel.DisplayInfo();

            // Soru13: (Enum)
            DaysOfWeek today = DaysOfWeek.CUMARTESÝ;
            action.PrintDay(today);
        }
    }
}
