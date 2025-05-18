using MongoDB.Driver;


public class DBMongo
{
    private readonly static string connectionString = "mongodb://localhost:27017";
    private readonly static string databaseName = "UrunKatalogDB";
    private readonly IMongoDatabase _database;

    public DBMongo()
    {
        var client = new MongoClient(connectionString);
        _database = client.GetDatabase(databaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }
}