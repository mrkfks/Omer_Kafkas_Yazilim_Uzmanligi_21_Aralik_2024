using MongoDB.Driver;

namespace _20_Day
{
    public class DBMongo
    {
        private readonly string connectionString = "mongodb://localhost:27017";
        private readonly string databaseName = "MongoProject";
        private readonly IMongoDatabase _database;

        public DBMongo()
        {
            var client = new MongoClient(connectionString);
            _database = client.GetDatabase(databaseName);
        }
        public IMongoCollection <T> GetMongoCollection<T> (string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}