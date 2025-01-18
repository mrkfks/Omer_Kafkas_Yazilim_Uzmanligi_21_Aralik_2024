using System;
using System.Collections.Generic;
using System.Linq;
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
        public void ForLoop(int basSay , int bitSay ) 
        {
            for (int i = basSay; i < (bitSay + 1); i++) { Console.WriteLine(i); }
        }

        
    }
}