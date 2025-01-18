using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _8_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nesne Üretimi
            Customer customer = new Customer();
            customer..Call;

            Customer? Customer1 = null;
            //customer1 = new Customer();
            Console.WriteLine(customer1.age);
            //customer1.Call;

            //Direk Patlar
            Console.WriteLine("=================================");

            //nullables
            //bir değişkenin yada nesnenin değerinin null olabileceğini belirtir.
            int? number = null;
            Console.WriteLine(number);
            if (number == null)
            {
                Console.WriteLine("Lütfen Yaşınızı Giriniz:");
                number = 20;
            }

            string? name = null;
            Console.WriteLine(name);

            //? fonksiyon parametreleri
            customer.Params("Erkan", 20, "erkan@mail.com");
            customer.Params("Serkan", 15, null);


            //string class
            string data = new string(" ");
            string text = "Duo in congue nonumy ut quod amet clita dolores vero ";
            char[] chars = text.ToArray();
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }

            char[] words = { 'B', 'U', 'G', 'Ü', 'N' };
            string newWords = new string(words);
            Console.WriteLine(newWords);

            Console.WriteLine("=========================");
            int.size = text.Length;
            Console.WriteLine(size);

            Console.WriteLine("=================");
            //Concat
            string ad = "Serkan";
            string soyad = "Bilirim";
            string concat = String.Concat(ad, soyad);
            Console.WriteLine(concat);

            Console.WriteLine("==============================");
            string st1 = "this line 1";
            string st2 = "this line 2";
            int comcompare = string.Compare(st1, st2);

            Console.WriteLine("==============================");

            string username = "ali@mail.com";
            string password = "12345";

            if (username.Equals("ali@mail.com") && password.Equals("12345")
            {
                Console.WriteLine("Login Success");
            }
            else
            {
                Console.WriteLine("Login Fail");
            }

            Console.WriteLine("==============================");

            bool statusContains = text.Contains("diz");
            Console.WriteLine(statusContains);

            string[] kelimeler = { "diz", "lor", "kul" };
            bool status = false;
            foreach (string word in kelimeler)
            {
                status = text.Contains(word);
                if (status)
                {
                    break;
                }
            }
            if (status)
            {
                Console.WriteLine("Yorum Yayınlanamaz!");
            }
            else
            {
                Console.WriteLine("Yorum Yaınlanabilir!");
            }
            Console.WriteLine("==============================");

            string sub1 = text.Substring(10, 26);
            sub1 = text.Substring(10);
            sub1 = text.Substring(text.Length - 10, 2);
            Console.WriteLine(sub1);

            Console.WriteLine("==============================");

            string insertİndex = text.Insert(12, " Yazı");
            Console.WriteLine(insertİndex);

            Console.WriteLine("==============================");

            string removeIndex = text.Remove(12, 25);
            Console.WriteLine(removeIndex);

            Console.WriteLine("==============================");

            string newString = text.Replace("Dolor", "Muhtar");
            Console.WriteLine(newString);

            Console.WriteLine("==============================");
            string[] arr = text.Split(' ');
            foreach (string word in arr)
            { 
                Console.WriteLine(word); 
            }

            
            string[] arrCumle = text.Split(',');
            Console.WriteLine($"Kelime Sayısı: {arr.Length}");
            Console.WriteLine($"Kelime Sayısı: {arrCumle.Length-1}");
            string userData = "19-25-Ali Bilmem-ali@mail.com";
            string[] stArr = userData.Split("_");
            Console.WriteLine(stArr[0]);
            Console.WriteLine(stArr[1]);
            Console.WriteLine(stArr[2]);
            Console.WriteLine(stArr[3]);

            Console.WriteLine("==============================");
            string lowerCase = text.ToLower();
            Console.WriteLine(lowerCase);
            string upperCase = text.ToUpper();
            Console.WriteLine(upperCase);

            Console.WriteLine("==============================");
            string email = " ali@mail.com      ";
            email = email.Trim();
            Console.WriteLine(email);

            string userName = "       Zehra        ";   
            Console.WriteLine(userName.TrimStart());
            Console.WriteLine(userName.TrimEnd());

            Console.WriteLine("==============================");

            string title = "Fenerbahçe Şampiyon";
            title = title.PadRight(22, '*');
            Console.WriteLine(title);

            Console.WriteLine("==============================");

            int indexOf = text.IndexOf("dizgi");
            Console.WriteLine(indexOf);
        }
    }
}
