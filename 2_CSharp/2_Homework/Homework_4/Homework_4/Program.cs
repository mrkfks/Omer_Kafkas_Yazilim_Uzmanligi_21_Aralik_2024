using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Action action = new Action();
            //Soru1: (Array) Bir dizi oluşturun ve bu dizideki elemanların ortalamasını hesaplayan bir program yazın.
            //cevap:

            Console.WriteLine("Ortalaması alınacak dizini boyutunu giriniz:");
            int ArrayLenght = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[ArrayLenght];
            for (int i = 0; i < ArrayLenght; i++)
            {
                Console.WriteLine("Dizinin " + (i + 1) + ". elemanını giriniz:");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            action.OrtalamaDizi(Array);


            //Soru2: (If) Kullanıcıdan bir sayı alın ve bu sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.
            //cevap:

            Console.WriteLine("Değerlendirilecek sayıyı giriniz:");
            int sayiInt = Convert.ToInt32(Console.ReadLine());
            Action sayiAction = new Action();
            action.SayiDurum(sayiInt);


            //Soru3: (Else - If) Kullanıcıdan bir not değeri alın ve bu değere göre "Geçti", "Kaldı" veya "Bütünlemeye Kaldı" gibi mesajlar veren bir program yazın.
            //cevap:

            Console.WriteLine("Değerlendirilmesini istediğiniz not değerini giriniz:");
            int pointInt = Convert.ToInt32(Console.ReadLine());
            Action pointAction = new Action();
            action.PointStatus(pointInt);


            //Soru4: (For) 1'den 100'e kadar olan sayıları ekrana yazdıran bir program yazın.
            //cevap:

            Action forLoopStatus = new Action();
            action.ForLoop(1, 100);

            //Soru5: (Foreach) Bir string dizisi oluşturun ve bu dizideki her bir kelimeyi ekrana yazdıran bir program yazın.
            //cevap:

            string[] kelimeler = { "Merhaba", "Dünya", "C#", "Programlama" };
            foreach (string kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }

            //Soru6: (Nesne Üretimi) Bir "Araba" sınıfı oluşturun ve bu sınıftan birkaç nesne üretip içerisindeki bir metottan geriye dönen string ifadeyi ekrana yazdıran bir program yazın.
            //cevap:

            Console.WriteLine("Bilgi verilecek araç sayısını giriniz:");
            int aracSayisi = Convert.ToInt32(Console.ReadLine());
            Car[] araclar = new Car[aracSayisi];
            for (int i = 0; i < aracSayisi; i++)
            {
                Console.WriteLine($"{i + 1}. arabanın markasını giriniz:");
                string marka = Console.ReadLine();
                Console.WriteLine($"{i + 1}. arabanın modelini giriniz:");
                string model = Console.ReadLine();
                Console.WriteLine($"{i + 1}. arabanın yılını giriniz:");
                int yil = Convert.ToInt32(Console.ReadLine());

                araclar[i] = new Car(marka, model, yil);
            }

            Console.WriteLine("Girilen araç bilgileri:");
            foreach (var araba in araclar)
            {
                Console.WriteLine(araba.BilgiVer());
            }

            //Soru7: (Fonksiyonlar) İki sayıyı toplayan bir fonksiyon yazın ve bu fonksiyonu kullanarak kullanıcıdan alınan iki sayının toplamını ekrana yazdıran bir program yazın.
            //cevap:

            Console.WriteLine("Toplamak istediğiniz ilk sayıyı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Toplamak istediğiniz ilk sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            action.Sum(sayi1, sayi2);

            //Soru8: (Tür Dönüşümü) Kullanıcıdan bir string olarak alınan sayıyı integer türüne dönüştürüp karesini hesaplayan bir program yazın.
            //cevap:

            Console.WriteLine("Karesi alınacak sayıyı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            action.Karesi(sayi);

            //Soru9: (Console.ReadLine) Kullanıcıdan adını ve yaşını alıp ekrana "Merhaba [Ad], [Yaş] yaşındasınız." şeklinde yazdıran bir program yazın.
            //cevap:

            Console.WriteLine("Adınız: ");
            string name = Console.ReadLine();
            Console.WriteLine("Yaşınız: ");
            int age = Convert.ToInt32 (Console.ReadLine());
            action.Login(name, age);

            //Soru10: (Kombinasyon)  Bir dizi oluşturun, bu dizideki elemanları sıralayın ve sıralanmış diziyi ekrana yazdıran bir program yazın.
            //cevap:

            Console.WriteLine("Dizinin üye sayısını giriniz:");
            int uyeSayi = Convert.ToInt32(Console.ReadLine());
            int [] ArrayList = new int[uyeSayi];
            for (int i = 0; i < uyeSayi; i++)
            {
                Console.WriteLine($"Dizinin {i + 1}. elemanını giriniz.")
                    dizi[i] = Convert.ToInt32(Console.ReadLine());
            };
            action.SiraliDizi(ArrayList);

        }
    }
}
