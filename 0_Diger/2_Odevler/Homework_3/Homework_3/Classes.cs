using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Classes
    {
        public void Calculator(string sayi1, string sayi2)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("İlk sayıyı giriniz:");
            sayi1 = Console.ReadLine();
            int sayi1Int = Convert.ToInt32(sayi1);

            Console.WriteLine("İkinci sayıyı giriniz:");
            sayi2 = Console.ReadLine();
            int sayi2Int = Convert.ToInt32(sayi2);

            Console.WriteLine("Yapılacak Olan İşlem: Toplama (+), Çıkarma (-), Çarpma (*), Bölme (/)");

            string islem = Console.ReadLine();

            if (islem.Equals("+"))
            {
                Console.WriteLine("Toplama İşlemi Sonucu: " + (sayi1Int + sayi2Int));
            }
            else if (islem.Equals("-"))
            {
                Console.WriteLine("Çıkarma İşlemi Sonucu: " + (sayi1Int - sayi2Int));
            }
            else if (islem.Equals("*"))
            {
                Console.WriteLine("Çarpma İşlemi Sonucu: " + (sayi1Int * sayi2Int));
            }
            else if (islem.Equals("/"))
            {
                Console.WriteLine("Bölme İşlemi Sonucu: " + (sayi1Int / sayi2Int));
            }
            else
            {
                Console.WriteLine("Hatalı İşlem Girdiniz!");
            }

        }
        public void Rectangle(int length, int width)
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Uzunluk giriniz:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Genişlik giriniz");
            width = Convert.ToInt32(Console.ReadLine());

            int area = length * width;
            Console.WriteLine($"Dikdörtgenin Alanı: {area}");
            int perimeter = 2 * (length + width);
            Console.WriteLine($"Dikdörtgenin Çevresi: {perimeter}");
        }
        public void Square(int edge)
        {
            Console.WriteLine("Square");
            Console.WriteLine("Kenar uzunluğunu giriniz:");
            edge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Karenin Alanı: {edge * edge}");
            Console.WriteLine($"Karenin Çevresi: {4 * edge}");
        }
        public void Circle(int radius)
        {
            Console.WriteLine("Daire");
            Console.WriteLine("Yarıçapı giriniz:");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dairenin alanı: {radius * radius * Math.PI}");
            Console.WriteLine($"Dairenin çevresi: {2 * radius * Math.PI}");
        }
        public void Student(string name, int old, int average)
        {
            int[] notes = new int[3];

            Console.WriteLine("Öğrenci Kaydı:");
            Console.WriteLine("Öğrencinin Adını Giriniz:");
            name = Console.ReadLine();
            Console.WriteLine("Öğrencinin Yaşını Giriniz:");
            old = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Öğrencinin Notlarını Giriniz:");
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = Convert.ToInt32(Console.ReadLine());
            }
            average = (notes[0] + notes[1] + notes[2]) / 3;
            Console.WriteLine($"{name} isimli örenci {old} yaşındadır, Not ortalamsı {average}'dır.");
        }
        public void Factorial(int number)
        {
            Console.WriteLine("Faktöriyel");
            Console.WriteLine("faktöriyeli alınacak bir sayı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            Console.WriteLine($"{number} sayısının faktöriyeli: {result}");
        }
        public void Fibonacci(int number)
        {
            Console.WriteLine("Fibonacci dizisinde değeri istenen sayıyı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            int[] fn = new int[number + 1];

            for (int i = 0; i <= number; i++)
            {
                if (i == 0)
                {
                    fn[i] = 0;
                }
                else if (i == 1)
                {
                    fn[i] = 1;
                }
                else
                {
                    fn[i] = fn[i - 1] + fn[i - 2];
                }
                Console.WriteLine(fn[i]);
            }
        }
        public void Asal(int number)
        {
            Console.WriteLine("Asal Sayı Kontrolü");
            Console.WriteLine("Asal olup olmadığını kontrol etmek istediğiniz sayıyı giriniz:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 11 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 13 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 17 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else if (number % 19 == 0)
            {
                Console.WriteLine("Sayı Asal Değildir.");
            }
            else
            {
                Console.WriteLine("Sayı Asaldır.");
            }
        }
        public void Ebob(int x, int y)
        {
            while (x != 0 && y != 0)
            {
                if (x > y && x % y == 0)
                {
                    Console.WriteLine($"EBOB: {y}");
                }
                else if (y > x && y % x == 0)
                {
                    Console.WriteLine($"EBOB: {x}");
                }
                else
                {
                    Console.WriteLine("Bahse konu sayılar aralarında asaldır.");
                }
                break;

            }
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
