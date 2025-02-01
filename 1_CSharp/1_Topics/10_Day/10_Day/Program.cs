using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Day
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Sını içindeki özellikleri kullanmak için nesne üretimi yapmak gerekmektedir.
            //SınıfAdı nesneAdı = new SınıfAdı();
            //Sınıf içerisindeki özelliklere (.) ile erişilir.
            Profile profile = new Profile("Erkan", "Bilirim");
            profile.call();

            DB db = new DB(Edb.SQLITE);
            db.connect();
            db.close();

            for (; ; )
            {
                Console.WriteLine("1. sayı giriniz: ");
                string stNum1 = Console.ReadLine();
                Console.WriteLine("2. sayı giriniz: ");
                string stNum2 = Console.ReadLine();

                try
                {
                    int num1 = Convert.ToInt32(stNum1);
                    int num2 = Convert.ToInt32(stNum2);
                    int sm = num1 + num2;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lütfen tam sayı ifadeleri giriniz! ");
                    Console.WriteLine("Lütfen tekrar deneyiniz!");
                }

                //try-catch

                try 
                {
                    //hata olma olasılığı olan kodlar
                    int a = 1;
                    int b = 0;
                    int i = a / b;  
                }
                catch (Exception ex)
                {
                    //hata olduğunda çalışacak kodlar
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Bölme işlemi için 0 dışında bir değer giriniz.");
                }
                Customer customer = new Customer();
                customer.ProfileImageCrop(100, 100);

                Console.WriteLine("This line call");

            }
        }
    }
}
