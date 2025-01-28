using System;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

//namespace Days_4;

class Program
{
    static void Main(String[] argas)
    {
        Console.WriteLine("Lütfen bir sayı giriniz!");

        //int number = Convert.ToInt32(Console.ReadLine());

        int number = 5;
        int end = number;
        if (end == 0)
        {
            Console.WriteLine($"end: 1");
        }
        else
        {
            for (int i = number - 1; i > 0; i--)
            {
                end *= i;
            }
            Console.WriteLine($"end: {end}");
        }

        Console.WriteLine("=====================================");
        string[] days = { "Pazar", "Pazartesi", "Salı", "Çarşamba", "Perşembe" };

        for (int i = 0; i < days.Length; i++)
        {
            string item = days[i];
            if (item.Equals("Salı"))
            {
                Console.WriteLine("Salı günü bulundu");
                break; // for loop işlemini tamamla.
            }
            Console.WriteLine($"item: {item}");
        }

        Console.WriteLine("=====================================");
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (j == 5)
                {
                    continue;
                }
                Console.WriteLine($"i: {i} j: {j}");
            }
        }

        Console.WriteLine("=====================================");
        string[] words = { "elma", "armut", "muz", "çilek" };
        string[] keys = { "armut", "çilek" };

        for (int i = 0; i < words.Length; i++)
        {
            string item = words[i];
            bool status = false;
            for (int j = 0; j < keys.Length; j++)
            {
                string key = keys[j];
                if (item.Equals(key))
                {
                    status = true;
                }
            }
            if (status == true)
            {
                continue;
            }
            Console.WriteLine(item);
        }

        Console.WriteLine("=====================================");

        foreach (string item in days)
        {
            if (item.Equals("Pazartesi"))
            {
                continue;
            }
            if (item.Equals("Çarşamba"))
            {
                break;
            }
            Console.WriteLine(item);
        }

        Console.WriteLine("=====================================");

        int a = 0;
        while (a < 10)
        {
            if (a == 5)
            {
                break;
            }
            Console.WriteLine($"while call -> a: {a}");
            a++;
        }

        Console.WriteLine("=====================================");

        int y = 0;
        do
        {
            if (y == 5)
            {
                y++;
                continue;
            }
            Console.WriteLine($"do while call -> y: {y}");
            y++;
        }
        while (y < 10);
        {
            Console.WriteLine("Thid line Call");
        }
    }
}