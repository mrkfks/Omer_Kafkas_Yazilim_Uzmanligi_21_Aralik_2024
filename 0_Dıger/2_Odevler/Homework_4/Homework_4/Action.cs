using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Action
    {
        public void OrtalamaDizi(int[] Array)
        {
            int ArraySum = Array.Sum();
            Console.WriteLine($"Dizinin elemanlarının toplamı: {ArraySum}");
            double ArrayAvg = Array.Average();
            Console.WriteLine($"Dizinin elemanlarının ortalaması: {ArrayAvg}");
        }
        public void SayiDurum(int sayi)
        {
            if (sayi > 0) { Console.WriteLine("Sayı Pozitiftir."); }
            else if (sayi < 0) { Console.WriteLine("Sayi negatiftir."); }
            else { Console.WriteLine("Sayı Sıfırdır."); }
        }
        public void PointStatus(int point)
        {
            if (point <= 100 && point >= 90) { Console.WriteLine("Harf Notu: A"); }
            else if (point < 90 && point >= 80) { Console.WriteLine("Harf Notu: B"); }
            else if (point < 80 && point >= 70) { Console.WriteLine("Harf Notu: C"); }
            else if (point < 70 && point >= 60) { Console.WriteLine("Harf Notu: D"); }
            else if (point < 60 && point >= 0) { Console.WriteLine("Harf Notu: F"); }
            else { Console.WriteLine("Geçersiz Puan."); }
        }
        public void ForLoop(int basSay, int bitSay)
        {
            for (int i = basSay; i < (bitSay + 1); i++) { Console.WriteLine(i); }
        }
        public void Sum(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine($"Toplam: {toplam}");
        }
        public void Karesi(int sayi)
        {
            int karesi = sayi * sayi;
            Console.WriteLine($"Girilen sayının karesi: {karesi}");
        }

        public void Login(string name, int age);
        {
            Console.WriteLine( $"Merhaba {name}, {age} yaşındasınız." );
        }
        public void SiraliDizi(int[] array)
        {
            Array.Sort(array);
            Console.WriteLine("Dizi Küçükten Büyüğe Sıralandı.");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        } 
    }
}