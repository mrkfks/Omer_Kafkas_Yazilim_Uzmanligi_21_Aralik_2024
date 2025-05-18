using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Urun_Katalog_Uygulaması.Models
{
    public class Kategori
    {
        public ObjectId Id { get; set; }

        [BsonElement("kategori_adi")]
        public string? KategoriAd { get; set; }  
    }
}