using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDB_Urun_Katalog_Uygulaması.Models
{
    public class ModelsKategori
    {
        public ObjectId Id { get; set; }

        [BsonElement("categoryname")]
        [BsonRequired]
        [Required(ErrorMessage = "Kategori Alanı BOş Olamaz")]
        public required string KategoriAdi { get; set; }
    }
    
    public class KategoriIndexHelper
    {
        public static void CreateUniqueCategoryIndex(IMongoCollection<ModelsKategori> collection)
        {
            var indexKeys = Builders<ModelsKategori>.IndexKeys.Ascending(k => k.KategoriAdi);
            var indexOptions = new CreateIndexOptions { Unique = true };
            var indexModel = new CreateIndexModel<ModelsKategori>(indexKeys, indexOptions);

            collection.Indexes.CreateOne(indexModel);
            }
        }
    }
