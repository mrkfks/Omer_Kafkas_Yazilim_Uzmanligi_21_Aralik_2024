using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Day
{
    internal class Action
    {
        int age = 30;

        // Koleksiyon örnekleri
        private List<string> names = new List<string>();
        private Dictionary<string, int> productPrices = new Dictionary<string, int>();
        private Queue<string> tasks = new Queue<string>();

        // parametresiz
        // parametreli
        // return'lü
        // return'süz

        // public -> master seviyesi dahil her yerden görün
        // internal -> module seviyesinde görünme
        // private -> sadece mevcut class içinde görünme yeteneği

        // void -> fonksiyondan geri dönşün olmadığı durumda kullanılır.
        // return -> geriye dönecek yanıtın türünü ifade eder

        public void NoParams()
        {
            // fonksiyon tetiklenldiğinde çalışacak gövde
            string name = "Ali Bilmem";
            Console.WriteLine(name);
        }

        public void Params(string title, int price)
        {
            // string joinSt = title + " - " + price;
            price = price - ((price * 10) / 100);
            string join = $"{title} - {price}";
            Console.WriteLine(join);
        }

        public int sum(int num1, int num2)
        {
            int sm = num1 + num2;
            return sm;
        }

        public bool UserNamePasswordLogin(string username, string password)
        {
            bool status = false;
            if (username.Equals("kemal01") && password.Equals("12345"))
            {
                status = true;
            }
            return status;
        }

        // Yeni metot: Koleksiyona isim ekleme ve listeleme
        public void AddName(string name)
        {
            names.Add(name);
            Console.WriteLine($"İsim eklendi: {name}");
        }

        public void ListNames()
        {
            Console.WriteLine("İsimler listesi:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        // Yeni metot: Ürün ve fiyat ekleme ve listeleme
        public void AddProductPrice(string product, int price)
        {
            productPrices[product] = price;
            Console.WriteLine($"Ürün eklendi: {product} - {price}");
        }

        public void ListProductPrices()
        {
            Console.WriteLine("Ürün fiyat listesi:");
            foreach (var kvp in productPrices)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        // Yeni metot: Görev ekleme ve işleme
        public void AddTask(string task)
        {
            tasks.Enqueue(task);
            Console.WriteLine($"Görev eklendi: {task}");
        }

        public void ProcessTasks()
        {
            Console.WriteLine("Görevler işleniyor:");
            while (tasks.Count > 0)
            {
                string task = tasks.Dequeue();
                Console.WriteLine($"Görev işlendi: {task}");
            }
        }
    }
}