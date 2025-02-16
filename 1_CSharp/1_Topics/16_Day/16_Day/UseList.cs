using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Day.models
{
    public struct Product
    {
        public string title { get; set; }
        public string detail { get; set; }
        public int price { get; set; }
        public int status { get; set; }
    }

    public class UseList
    {
        public void Call()
        {
            // List
            // Belirli bir tür için çalışmasını istediğimiz bir collections
            // generic - farklı türlerin bir sınıfa aktarılarak o sınıf içindeki
            // methodların hangi tür için çalışması gerektiğine karar verir.

            List<string> ls = new List<string>();

            ls.Add("Ali");
            ls.Add("Kemal");
            ls.Add("Ayşe");
            ls.Add("Zehra");

            // to array
            string[] arr = ls.ToArray();

            for (; ; )
            {
                Console.WriteLine("Lütfen isim giriniz, kapat için X");
                string name = Console.ReadLine();
                if (name.Equals("X"))
                {
                    break;
                }
                ls.Add(name);
            }

            foreach (string item in ls)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("======================");
            List<Product> products = new List<Product>();

            Product p1 = new Product
            {
                title = "iPad",
                detail = "iPad Detail",
                price = 30000,
                status = 1 // true is represented as 1 in an int context
            };
            products.Add(p1);

            // runtime
            // ürün ekleme
            // istenen ürünün silinmesi
            // index değeri iste, bu indexin var olup olmadığını kıyasla.
            // eğer silinmek istenen index yoksa uyarı ver.

            Console.WriteLine("===============");
            // sil - for
            Console.WriteLine("Silme için 'X'");
            string deleteStatus = Console.ReadLine();
            if (deleteStatus.Equals("X"))
            {
                for (; ; )
                {
                    Console.WriteLine("Silmek istediğiniz sırayı giriniz");
                    string stIndex = Console.ReadLine();
                    try
                    {
                        int index = Convert.ToInt32(stIndex);
                        if (index > 0)
                        {
                            index = index - 1;
                            if (index < products.Count)
                            {
                                products.RemoveAt(index);
                                Console.WriteLine("Silme işlemi devam etsin mi?, 'D'");
                                string delete = Console.ReadLine();
                                if (!delete.Equals("D"))
                                {
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Silmek istediğiniz ürün bulunumadı!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Lüfen sadece pozitif değerler giriniz!");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lütfen sadece sayısal değer giriniz!");
                    }
                }
            }

            for (; ; )
            {
                Product p = new Product();
                Console.WriteLine("Title Giriniz");
                p.title = Console.ReadLine();

                Console.WriteLine("Detay Giriniz");
                p.detail = Console.ReadLine();

                Console.WriteLine("Fiyat Giriniz");
                p.price = Convert.ToInt32(Console.ReadLine());

                p.status = 1; // true is represented as 1 in an int context
                products.Add(p);

                Console.WriteLine("Durdurmak için X Giriniz");
                string status = Console.ReadLine();
                if (status.Equals("X"))
                {
                    break;
                }
            }

            Console.WriteLine("===============");
            // sil - for
            for (; ; )
            {
                Console.WriteLine("Silmek istediğiniz ürünün indexini giriniz, kapat için X");
                string input = Console.ReadLine();
                if (input.Equals("X"))
                {
                    break;
                }

                int index;
                if (int.TryParse(input, out index) && index >= 0 && index < products.Count)
                {
                    products.RemoveAt(index);
                    Console.WriteLine("Ürün silindi.");
                }
                else
                {
                    Console.WriteLine("Geçersiz index.");
                }
            }

            Console.WriteLine("===============");
            foreach (Product item in products)
            {
                Console.WriteLine(item.title);
            }
        }
    }
}
