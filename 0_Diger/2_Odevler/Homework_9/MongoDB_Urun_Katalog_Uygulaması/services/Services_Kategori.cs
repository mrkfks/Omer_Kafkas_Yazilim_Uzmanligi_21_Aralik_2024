using MongoDB_Urun_Katalog_Uygulaması.Models;
using MongoDB.Driver;

namespace MongoDB_Urun_Katalog_Uygulaması.Services
{
    public class Services_Kategori
    {
        private readonly IMongoCollection<ModelsKategori> _kategoriCollection;

        public Services_Kategori(IMongoDatabase database)
        {
            _kategoriCollection = database.GetCollection<ModelsKategori>("Kategoriler");
        }
    }

    //Kategori Ekleme

    //Kategori Güncelleme

    //Kategori Silme

    //Kategori Getirme

    //Kategori Listeleme
}