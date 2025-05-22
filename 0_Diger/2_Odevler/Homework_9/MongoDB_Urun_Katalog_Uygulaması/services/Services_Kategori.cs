using MongoDB_Urun_Katalog_Uygulaması.Models;
using MongoDB_Urun_Katalog_Uygulaması.Utils;
using MongoDB.Driver;

namespace MongoDB_Urun_Katalog_Uygulaması.Services
{
    public class Services_Kategori
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<ModelsKategori> _kategoriCollection;
        private readonly HataLog hataLog = new();
        private string? kategori;

        public Services_Kategori(IMongoDatabase database, string? kategori = null)
        {
            _database = database;
            _kategoriCollection = _database.GetCollection<ModelsKategori>("Kategoriler");
            this.kategori = kategori;
        }

        //Kategori Ekleme
        public int AddKategori(ModelsKategori kategori)
        {
            try
            {
                _kategoriCollection.InsertOne(kategori);
                return 1;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return 0;
        }

        //Kategori Güncelleme
        public bool UpdateKategori(ModelsKategori kategori)
        {
            try
            {
                var filter = Builders<ModelsKategori>.Filter.Eq(item => item.Id, kategori.Id);
                ReplaceOneResult replaceOneResult = _kategoriCollection.ReplaceOne(filter, kategori);
                return replaceOneResult.IsAcknowledged && replaceOneResult.ModifiedCount > 0;

            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return false;
        }
        //Kategori Silme
        public int DeleteKategori(ModelsKategori kategori)
        {
            try
            {
                var urunCollection = _database.GetCollection<ModelsUrun>("Urunler");
                var filterUrun = Builders<ModelsUrun>.Filter.Eq("Kategori.Id", kategori.Id);
                long urunSayisi = urunCollection.CountDocuments(filterUrun);

                if (urunSayisi > 0) { return 0; }

                var filterKategori = Builders<ModelsKategori>.Filter.Eq(x => x.Id, kategori.Id);
                var result = _kategoriCollection.DeleteOne(filterKategori);
                return result.DeletedCount > 0 ? 1 : 0;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return 0;
        }

        //Kategori Getirme
        public ModelsKategori? GetKategori(ModelsKategori kategori)
        {
            try
            {
                var filter = Builders<ModelsKategori>.Filter.Eq(x => x.Id, kategori.Id);
                return _kategoriCollection.Find(filter).FirstOrDefault();
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return null;
        }

        //Kategori Listeleme
        public List<ModelsKategori> GetAllKategoris()
        {
            try
            {
                List<ModelsKategori> list = _kategoriCollection.Find(_ => true).ToList();
                return list;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return new List<ModelsKategori>();
        }
    }
}