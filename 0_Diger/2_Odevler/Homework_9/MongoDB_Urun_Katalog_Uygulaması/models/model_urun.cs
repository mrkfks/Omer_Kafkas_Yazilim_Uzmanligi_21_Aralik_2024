using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDB_Urun_Katalog_Uygulaması.Models
{
    public class Urun
    {
        public ObjectId Id { get; set; }

        [BsonElement("urun_adi")]
        public string? UrunAd { get; set; }

        [BsonElement("aciklama")]
        public string? Aciklama { get; set; }

        [BsonElement("fiyat")]
        public decimal Fiyat { get; set; }

        [BsonElement("stok_miktari")]
        public int StokMiktari { get; set; }

        [BsonElement("kategori_id")]
        public ObjectId KategoriId { get; set; }

        [BsonElement("eklenme_tarihi")]
        public DateTime EklenmeTarihi { get; set; }
    }
}
