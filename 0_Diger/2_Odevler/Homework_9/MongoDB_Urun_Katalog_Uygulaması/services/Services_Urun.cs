using MongoDB_Urun_Katalog_Uygulaması.Models;
using MongoDB.Driver;

namespace MongoDB_Urun_Katalog_Uygulaması.Services
{
    public class Services_Urun
    {
        private readonly IMongoCollection<ModelsUrun> _urunCollection;

        public Services_Urun(IMongoDatabase database)
        {
            _urunCollection = database.GetCollection<ModelsUrun>("Ürünler");
        }
    }
}