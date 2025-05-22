using MongoDB_Urun_Katalog_Uygulaması.Models;
using MongoDB_Urun_Katalog_Uygulaması.Utils;
using MongoDB.Driver;



namespace MongoDB_Urun_Katalog_Uygulaması.Services
{
    public class Services_Urun
    {
        private readonly IMongoCollection<ModelsUrun> _urunCollection;

        public Services_Urun(IMongoDatabase database)
        {
            _urunCollection = database.GetCollection<ModelsUrun>("urun");
        }

        private readonly HataLog hataLog = new();

        //Ürün Ekleme
        public int AddUrun(ModelsUrun urun)
        {
            try
            {
                _urunCollection.InsertOne(urun);
                return 1;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return 0;
        }

        //Ürün Güncelleme
        public bool UpdateUrun(ModelsUrun urun)
        {
            try
            {
                var Filter = Builders<ModelsUrun>.Filter.Eq(item => item.Id, urun.Id);
                ReplaceOneResult replaceOneResult = _urunCollection.ReplaceOne(Filter, urun);
                return replaceOneResult.IsAcknowledged && replaceOneResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return false;
        }

        //Ürün Silme
        public void DeleteUrun(string Id)
        {
            try
            {
                var objectId = MongoDB.Bson.ObjectId.Parse(Id);
                _urunCollection.DeleteOne(x => x.Id == objectId);
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
        }

        //Ürün Getirme
        public ModelsUrun? GetUrun(ModelsUrun urun)
        {
            try
            {
                var filter = Builders<ModelsUrun>.Filter.Eq(x => x.Id, urun.Id);
                return _urunCollection.Find(filter).FirstOrDefault();
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return null;
        }

        //Ürün Listeleme
        public List<ModelsUrun> GetUruns()
        {
            try
            {
                var result = _urunCollection.Find(Builders<ModelsUrun>.Filter.Empty)
                .SortByDescending(x => x.EklenmeTarihi)
                .Skip(1)
                .Limit(10)
                .ToList();
                return result;
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return new List<ModelsUrun>();
        }

        //Ürün Adına Göre Arama
        public List<ModelsUrun> GetUrun(string ad, string Acıklama)
        {
            try
            {
                var filter = Builders<ModelsUrun>.Filter.And
                (
                    Builders<ModelsUrun>.Filter.Eq(x => x.Ad, ad),
                    Builders<ModelsUrun>.Filter.Regex(y => y.Aciklama, new MongoDB.Bson.BsonRegularExpression(Acıklama, "i"))
                );

                return _urunCollection.Find(filter).ToList();
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return new List<ModelsUrun>();
        }

        //Ürün Filtreleme
        public List<ModelsUrun> GetFilterUrun(decimal? minfiyat, decimal? maxfiyat, string kategori)
        {
            try
            {
                var filters = new List<FilterDefinition<ModelsUrun>>();

                if (!string.IsNullOrEmpty(kategori))
                {
                    filters.Add(Builders<ModelsUrun>.Filter.Eq("Kategori", kategori));
                }
                if (minfiyat.HasValue)
                {
                    filters.Add(Builders<ModelsUrun>.Filter.Gte(x => x.Fiyat, minfiyat.Value));
                }
                if (maxfiyat.HasValue)
                {
                    filters.Add(Builders<ModelsUrun>.Filter.Lte(x => x.Fiyat, maxfiyat.Value));
                }

                var filter = filters.Count > 0
                    ? Builders<ModelsUrun>.Filter.And(filters)
                    : Builders<ModelsUrun>.Filter.Empty;

                return _urunCollection.Find(filter).ToList();
            }
            catch (Exception ex)
            {
                hataLog.WriteToLog(ex.ToString());
            }
            return new List<ModelsUrun>();
        }
    }
}