using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Araç_Yönetim_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars cars = new Cars();
            while (true)
            {
                Console.WriteLine("Araç Yönetim Sistemi");
                Console.WriteLine("1. Araç Ekle");
                Console.WriteLine("2. Araç Listele");
                Console.WriteLine("3. Araç Sil");
                Console.WriteLine("4. Çıkış");
                Console.WriteLine("Seçiminizi yapınız: ");
                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        Console.WriteLine("Marka: ");
                        EnumMarka marka = (EnumMarka)Enum.Parse(typeof(EnumMarka), Console.ReadLine());
                        Console.WriteLine("Tip: ");
                        EnumType tip = (EnumType)Enum.Parse(typeof(EnumType), Console.ReadLine());
                        Console.WriteLine("Renk: ");
                        EnumColor renk = (EnumColor)Enum.Parse(typeof(EnumColor), Console.ReadLine());
                        Console.WriteLine("Yıl: ");
                        EnumYear yıl = (EnumYear)Enum.Parse(typeof(EnumYear), Console.ReadLine());
                        cars.AddCar(marka, tip, renk, yıl);
                        break;
                    case 2:
                        cars.DisplayCars();
                        break;
                    case 3:
                        Console.WriteLine("Silmek istediğiniz aracın indeksini giriniz: ");
                        int index = Convert.ToInt32(Console.ReadLine());
                        cars.RemoveCar(index);
                        break;
                    case 4:
                        Console.WriteLine("Çıkış Yapıldı");
                        return;
                    default:
                        Console.WriteLine("Hatalı Seçim Yaptınız");
                        break;
                }
            }
        }
    }
}
