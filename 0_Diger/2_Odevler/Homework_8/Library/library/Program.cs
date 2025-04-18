using library;
using library.Models;
using library.services;
using library.utils;
using System.Data.SqlClient;
using library.utils.DB;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Yazar ID'sini girin: ");
            if (!int.TryParse(Console.ReadLine(), out int writersId))
            {
                Console.WriteLine("Geçersiz bir sayı girdiniz!");
                return;
            }

            Console.Write("Kitap başlığını girin: ");
            string title = Console.ReadLine();

            Console.Write("Yayın yılını girin: ");
            if (!int.TryParse(Console.ReadLine(), out int publicationYear))
            {
                Console.WriteLine("Geçersiz bir yıl girdiniz!");
                return;
            }

            Console.Write("ISBN numarasını girin: ");
            string isbn = Console.ReadLine();

            // Kitap nesnesi oluştur
            Book newBook = new Book
            {
                Writers_ID = writersId,
                Title = title,
                Publication_Year = publicationYear,
                ISBN = isbn
            };

            // Kitap ekleme servisini çağır
            services_books bookService = new services_books();
            int result = bookService.AddBook(newBook);

            Console.WriteLine($"Kitap ekleme sonucu: {result}");
        }
    }
}