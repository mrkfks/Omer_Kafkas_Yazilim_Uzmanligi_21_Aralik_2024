using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB_Urun_Katalog_Uygulaması.Models;
using MongoDB_Urun_Katalog_Uygulaması.ErrorLog;


namespace MongoDB_Urun_Katalog_Uygulamasi.Services
{
    public class KategoriService
    {
        private readonly IMongoCollection<Kategori> _kategoriCollection;

        public KategoriService(IMongoDatabase database)
        {
            _kategoriCollection = database.GetCollection<Kategori>("kategori");
        }

        public int AddKategori(Kategori kategori)
        {
            try
            {
                _kategoriCollection.InsertOne(kategori);
                return 1;
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = new ErrorLog();
                errorLog.WriteErrorLog(ex.Message);
                return 0;
            }
        }
        public bool UpdateKategori(Kategori kategori)
        {
            try
            {
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, kategori.Id);
                var update = Builders<Kategori>.Update.Set(k => k.KategoriAd, kategori.KategoriAd);
                var result = _kategoriCollection.UpdateOne(filter, update);
                return result.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = new ErrorLog();
                errorLog.WriteErrorLog(ex.Message);
                return false;
            }
        }

        public bool DeleteKategori(string Id)
        {
            try
            {
                ObjectId objectId = new ObjectId(Id);
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, objectId);
                _kategoriCollection.DeleteOne(filter);
                return true;
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = new ErrorLog();
                errorLog.WriteErrorLog(ex.Message);
                return false;
            }
        }
        public bool FindKategori(string Id)
        {
            try
            {
                ObjectId objectId = new ObjectId(Id);
                var filter = Builders<Kategori>.Filter.Eq(k => k.Id, objectId);
                var result = _kategoriCollection.Find(filter).FirstOrDefault();
                return result != null;
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = new ErrorLog();
                errorLog.WriteErrorLog(ex.Message);
                return false;
            }
        }
        public List<Kategori> GetAllKategoriler()
        {
            try
            {
                return _kategoriCollection.Find(new BsonDocument()).ToList();
            }
            catch (Exception ex)
            {
                ErrorLog errorLog = new ErrorLog();
                errorLog.WriteErrorLog(ex.Message);
                return new List<Kategori>();
            }
        }
    }
}