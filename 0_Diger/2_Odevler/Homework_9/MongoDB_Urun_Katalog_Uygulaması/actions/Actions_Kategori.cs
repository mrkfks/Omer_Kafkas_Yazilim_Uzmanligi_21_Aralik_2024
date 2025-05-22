using MongoDB_Urun_Katalog_Uygulaması.Services;
using MongoDB_Urun_Katalog_Uygulaması.Utils;
using MongoDB.Driver;


namespace MongoDB_Urun_Katalog_Uygulaması.Actions
{
    public class Actions_Kategori
    {
        private readonly DBMongo dbMongo;
        private readonly IMongoDatabase database;
        private readonly Services_Kategori services_Kategori;

        public Actions_Kategori()
        {
            dbMongo = new DBMongo();
            database = dbMongo._database;
            services_Kategori = new Services_Kategori(database);
        }

        public void ActionsAddKategori()
        {
            Console.WriteLine("Eklenecek Kategori Adını Girin:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                services_Kategori.AddKategori(kategori);
            }
        }
        public void ActionsUpdateKategori()
        {
            Console.WriteLine("Güncellenecek Kategori Adını Girin:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                services_Kategori.UpdateKategori(kategori);
            }
        }
        public void ActionsDeleteKategori()
        {
            Console.WriteLine("Silinecek Kategori Adını Girin:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                services_Kategori.DeleteKategori(kategori);
            }
        }
        public void ActionsGetKKategori()
        {
            Console.WriteLine("Getirilecek Kategori Adını Girin:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = services_Kategori.GetKategori(new Models.ModelsKategori { KategoriAdi = kategoriAdi });
                if (kategori != null)
                {
                    Console.WriteLine($"Kategori Bulundu: {kategori.KategoriAdi}");
                }
                else
                {
                    Console.WriteLine("Kategori Bulunamadı.");
                }
            }
        }
        public void ActionListKategori()
        {
            Console.WriteLine("Kategorileri Listeleyin:");
            var kategoriler = services_Kategori.GetAllKategoris();
            if (kategoriler != null && kategoriler.Count > 0)
            {
                foreach (var kategori in kategoriler)
                {
                    Console.WriteLine($"Kategori Adı: {kategori.KategoriAdi}");
                }
            }
            else
            {
                Console.WriteLine("Kategoriler Bulunamadı.");
            }
        }
    }
}