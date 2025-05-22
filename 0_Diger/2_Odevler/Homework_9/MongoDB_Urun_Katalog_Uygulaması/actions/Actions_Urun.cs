using MongoDB_Urun_Katalog_Uygulaması.Services;
using MongoDB_Urun_Katalog_Uygulaması.Utils;
using MongoDB.Driver;

namespace MongoDB_Urun_Katalog_Uygulaması.Actions
{
    public class Actions_Urun
    {
        private readonly DBMongo dbMongo;
        private readonly IMongoDatabase database;
        private readonly Services_Urun services_Urun;

        public Actions_Urun()
        {
            dbMongo = new DBMongo();
            database = dbMongo._database;
            services_Urun = new Services_Urun(database);
        }
        public void ActionsAddUrun()
        {
            Console.WriteLine("Eklenecek Ürünün Girişini Yapınız:");
            Console.WriteLine("Ürün Adı:");
            string? urunAdi = Console.ReadLine();
            Console.WriteLine("Açıklama:");
            string? Aciklama = Console.ReadLine();
            Console.WriteLine("Fiyat:");
            string? fiyatInput = Console.ReadLine();
            decimal fiyat = 0;
            if (!string.IsNullOrEmpty(fiyatInput) && decimal.TryParse(fiyatInput, out decimal parsedFiyat))
            {
                fiyat = parsedFiyat;
            }
            else
            {
                Console.WriteLine("Geçersiz fiyat girdiniz. Varsayılan olarak 0 atanacak.");
            }
            Console.WriteLine("Stok Adedi:");
            string? stokAdediInput = Console.ReadLine();
            int stokAdedi = 0;
            if (!string.IsNullOrEmpty(stokAdediInput) && int.TryParse(stokAdediInput, out int parsedStokAdedi))
            {
                stokAdedi = parsedStokAdedi;
            }
            else
            {
                Console.WriteLine("Geçersiz stok adedi girdiniz. Varsayılan olarak 0 atanacak.");
            }
            Console.WriteLine("Kategori Adı:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(urunAdi) && !string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                var urun = new Models.ModelsUrun { Ad = urunAdi, Aciklama = Aciklama, Fiyat = fiyat, StokAdedi = stokAdedi, Kategori = kategori };
                services_Urun.AddUrun(urun);
            }
        }
        public void ActionsUpdateUrun()
        {
            Console.WriteLine("Güncellenecek Ürünün Girişini Yapınız:");
            Console.WriteLine("Ürün Adı:");
            string? urunAdi = Console.ReadLine();
            Console.WriteLine("Açıklama:");
            string? Aciklama = Console.ReadLine();
            Console.WriteLine("Fiyat:");
            string? fiyatInput = Console.ReadLine();
            decimal fiyat = 0;
            if (!string.IsNullOrEmpty(fiyatInput) && decimal.TryParse(fiyatInput, out decimal parsedFiyat))
            {
                fiyat = parsedFiyat;
            }
            else
            {
                Console.WriteLine("Geçersiz fiyat girdiniz. Varsayılan olarak 0 atanacak.");
            }
            Console.WriteLine("Stok Adedi:");
            string? stokAdediInput = Console.ReadLine();
            int stokAdedi = 0;
            if (!string.IsNullOrEmpty(stokAdediInput) && int.TryParse(stokAdediInput, out int parsedStokAdedi))
            {
                stokAdedi = parsedStokAdedi;
            }
            else
            {
                Console.WriteLine("Geçersiz stok adedi girdiniz. Varsayılan olarak 0 atanacak.");
            }
            Console.WriteLine("Kategori Adı:");
            string? kategoriAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(urunAdi) && !string.IsNullOrEmpty(kategoriAdi))
            {
                var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                var urun = new Models.ModelsUrun { Ad = urunAdi, Aciklama = Aciklama, Fiyat = fiyat, StokAdedi = stokAdedi, Kategori = kategori };
                services_Urun.UpdateUrun(urun);
            }
        }
        public void ActionsDeleteUrun()
        {
            Console.WriteLine("Silinecek Ürünün Girişini Yapınız:");
            Console.WriteLine("Ürün Adı:");
            string? urunAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(urunAdi))
            {
                // Kategori bilgisi zorunlu olduğu için kullanıcıdan alınmalı
                Console.WriteLine("Kategori Adı:");
                string? kategoriAdi = Console.ReadLine();
                if (!string.IsNullOrEmpty(kategoriAdi))
                {
                    var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                    // Eğer DeleteUrun ürün adı ile silme yapıyorsa:
                    services_Urun.DeleteUrun(urunAdi);
                }
                else
                {
                    Console.WriteLine("Kategori adı boş olamaz.");
                }
            }
        }
        public void ActionsGetUrun()
        {
            Console.WriteLine("Getirilecek Ürünün Girişini Yapınız:");
            Console.WriteLine("Ürün Adı:");
            string? urunAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(urunAdi))
            {
                Console.WriteLine("Kategori Adı:");
                string? kategoriAdi = Console.ReadLine();
                if (!string.IsNullOrEmpty(kategoriAdi))
                {
                    var kategori = new Models.ModelsKategori { KategoriAdi = kategoriAdi };
                    var urun = services_Urun.GetUrun(new Models.ModelsUrun { Ad = urunAdi, Kategori = kategori });
                    if (urun != null)
                    {
                        Console.WriteLine($"Ürün Bulundu: {urun.Ad}");
                    }
                    else
                    {
                        Console.WriteLine("Ürün Bulunamadı.");
                    }
                }
                else
                {
                    Console.WriteLine("Kategori adı boş olamaz.");
                }
            }
        }
        public void ActionListUrun()
        {
            Console.WriteLine("Ürünleri Listeleyin:");
            var urunler = services_Urun.GetUruns();
            if (urunler != null && urunler.Count > 0)
            {
                foreach (var urun in urunler)
                {
                    Console.WriteLine($"Ürün Adı: {urun.Ad}, Fiyat: {urun.Fiyat}, Stok Adedi: {urun.StokAdedi}");
                }
            }
            else
            {
                Console.WriteLine("Ürünler Bulunamadı.");
            }
        }
        public void ActionsSearchUrun()
        {
            Console.WriteLine("Aranacak Ürünün Girişini Yapınız:");
            Console.WriteLine("Ürün Adı:");
            string? urunAdi = Console.ReadLine();
            if (!string.IsNullOrEmpty(urunAdi))
            {
                var urun = services_Urun.GetUrun(new Models.ModelsUrun { Ad = urunAdi, Kategori = new Models.ModelsKategori { KategoriAdi = string.Empty } });
                if (urun != null)
                {
                    Console.WriteLine($"Ürün Bulundu: {urun.Ad}");
                }
                else
                {
                    Console.WriteLine("Ürün Bulunamadı.");
                }
            }
        }
        public void ActionsFilterUrun()
        {
            Console.WriteLine("Filtreleme için kriterleri giriniz:");
            Console.WriteLine("Minimum Fiyat:");
            string? minFiyatInput = Console.ReadLine();
            decimal? minFiyat = null;
            if (!string.IsNullOrEmpty(minFiyatInput) && decimal.TryParse(minFiyatInput, out decimal parsedMinFiyat))
            {
                minFiyat = parsedMinFiyat;
            }
            Console.WriteLine("Maksimum Fiyat:");
            string? maxFiyatInput = Console.ReadLine();
            decimal? maxFiyat = null;
            if (!string.IsNullOrEmpty(maxFiyatInput) && decimal.TryParse(maxFiyatInput, out decimal parsedMaxFiyat))
            {
                maxFiyat = parsedMaxFiyat;
            }
            Console.WriteLine("Kategori Adı:");
            string? kategoriAdi = Console.ReadLine();
            // kategoriAdi null ise boş string ata
            var urunler = services_Urun.GetFilterUrun(minFiyat, maxFiyat, kategoriAdi ?? string.Empty);
            if (urunler != null && urunler.Count > 0)
            {
                foreach (var urun in urunler)
                {
                    Console.WriteLine($"Ürün Adı: {urun.Ad}, Fiyat: {urun.Fiyat}, Stok Adedi: {urun.StokAdedi}");
                }
            }
            else
            {
                Console.WriteLine("Filtreleme sonucu ürün bulunamadı.");
            }
        }
    }
}