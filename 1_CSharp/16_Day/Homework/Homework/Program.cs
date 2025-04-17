namespace Homework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Homework homework = new Homework();

            homework.Run();
        }
    }

    public class Homework
    {
        private List<string> products = new List<string>();

        public void Run()
        {
            // Ürün ekleme
            AddProduct("Ürün 1");
            AddProduct("Ürün 2");
            AddProduct("Ürün 3");

            // Ürünleri listele
            ListProducts();

            // İstenilen ürünün silinmesi
            Console.WriteLine("Silmek istediğiniz ürünün index değerini girin:");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                RemoveProduct(index);
            }
            else
            {
                Console.WriteLine("Geçersiz index değeri.");
            }

            // Ürünleri tekrar listele
            ListProducts();
        }

        public void AddProduct(string product)
        {
            products.Add(product);
            Console.WriteLine($"{product} eklendi.");
        }

        public void RemoveProduct(int index)
        {
            if (index >= 0 && index < products.Count)
            {
                Console.WriteLine($"{products[index]} silindi.");
                products.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Geçersiz index değeri.");
            }
        }

        public void ListProducts()
        {
            Console.WriteLine("Ürün Listesi:");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i}: {products[i]}");
            }
        }
    }
}
