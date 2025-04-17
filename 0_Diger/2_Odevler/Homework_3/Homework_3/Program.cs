using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Classes classes = new Classes();

            //1.Soru: Bir Hesap Makinesi sınıfı oluşturun.Bu sınıfta Topla, Çıkar, Çarp ve Böl fonksiyonları olsun.
            //Bu fonksiyonları kullanarak iki sayının toplamını, farkını, çarpımını ve bölümünü hesaplayın.
            //Cevap:

            classes.Calculator("", "");


            //2.Soru: Bir Dikdörtgen sınıfı oluşturun. Bu sınıfta Uzunluk ve Genişlik özellikleri ile Alan ve Çevre fonksiyonları olsun.
            //Bu fonksiyonları kullanarak bir dikdörtgenin alanını ve çevresini hesaplayın.
            //Cevap:

            classes.Rectangle(0, 0);


            //3.Soru: Bir Kare sınıfı oluşturun. Bu sınıfta Kenar özelliği le Alan ve Çevre fonksiyonları olsun.
            //Bu fonksiyonları kullanarak bir karenin alanını ve çevresini hesaplayın.
            //Cevap:

             classes.Square(0);

            //4.Soru: Bir Daire sınıfı oluşturun. Bu sınıfta Yarıçap özelliği ile Alan ve Çevre fonksiyonları olsun.
            //Bu fonksiyonları kullanarak bir dairenin alanını ve çevresini hesaplayın.
            //Cevap:

            classes.Circle(0);

            //5.Soru: Bir Öğrenci sınıfı oluşturun. Bu sınıfta isim, yas ve notlar özellikleri ile Not Ekle ve Ortalama Hesapla fonksiyonları olsun.
            //Bu fonksiyonları kullanarak bir öğrencinin notlarını ekleyin ve not ortalamasını hesaplayın.
            //Cevap:

            classes.Student(" ", 0, 0);


            //6.Soru: Bir Faktöriyel fonksiyonu yazın.
            //Bu fonksiyon, verilen bir sayının faktöriyelini hesaplasın.
            //Cevap:

            classes.Factorial(0);

            //7.Soru: Bir Fibonacci fonksiyonu yazın. Bu fonksiyon, verilen bir sayının Fibonacci dizsindeki değerin hesaplasın. (Fibonacci formülünü araştırınız.) 
            //Cevap:

            classes.Fibonacci(0);

            //8.Soru: Bir Asal mı fonksiyonu yazın.Bu fonksiyon, verilen bir sayının asal olup olmadığını kontrol etsin. (Asal sayı formülünü araştırınız.)
            //Cevap:

            classes.Asal(0);

            //9.Soru: Bir En Büyük Ortak Bölen fonksiyonu yazın.Bu fonksiyon, verilen iki sayının en büyük ortak bölenini hesaplasın.
            //Cevap:

            Console.WriteLine("İlk sayıyı girini: ");
            int ilkSayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayıyı giriniz: ");
            int ikinciSayi = Convert.ToInt32(Console.ReadLine());
            classes.Ebob (ilkSayi, ikinciSayi);

            //10.Soru: Bir Küçükten Büyüğe Sırala fonksiyonu yazın. Bu fonksiyon, verilen bir dizi sayıyı küçükten büyüğe sıralasın.
            //Cevap:

            Console.WriteLine("Dizi eleman sayısını giriniz: ");
            int elemanSayisi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[elemanSayisi];
            for (int i = 0; i < elemanSayisi; i++)
            {
                Console.WriteLine($"{i + 1}. elemanı giriniz: ");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            classes.SiraliDizi(dizi);

        }
    }
}
