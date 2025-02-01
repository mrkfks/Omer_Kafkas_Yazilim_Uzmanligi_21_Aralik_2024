using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Days_11.models;
using System.Net.NetworkInformation;

namespace Days_11
{

    public class Program
    {
        static void Main(string[] args)
        {
            foreach (string item in args)
            {
                Console.WriteLine(item);
            }

            Program[] programs = new Program[10];
            bool[] bools = new bool[10];
            int[] numbers = new int[10];
            string[] customer = new string[10];
            string[] users = { "Ali", "Zehra", "Kemal", "Ayşe", "Mehmet" };

            Console.WriteLine(programs[0]);
            Console.WriteLine(bools[0]);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(customer[0]);
            Console.WriteLine(users[0]);

            Console.WriteLine("========================");
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
            Console.WriteLine("========================");
            foreach (string item in users)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("========================");
            Product product = new Product();

            string title = product.ProductSliderTitle();
            Console.WriteLine(title);

            ProductModel productModel = new ProductModel
            {
                Pid = null,
                Title = "Samsung",
                Price = 30000,
                Detail = "Samsung Detail",
                Status = null
            };
            productModel = product.Save(productModel);
            Console.WriteLine(productModel);

            ProductModel model1 = new ProductModel(null, "Bilgisayar", "Bilgisayar Detay", 30000, true);
            model1 = product.Save(model1);
            Console.WriteLine(model1);

            Console.WriteLine("==============================");
            ProductModel[] products = { productModel, model1 };
            foreach (ProductModel item in products)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==============================");
            product.GetStatus(EStatus.ADMIN);

            try
            {
                int a = 1;
                int b = 1;
                int i = a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bölme işlemi sırasında hata: {ex.Message}");
            }
        }
    }

}
