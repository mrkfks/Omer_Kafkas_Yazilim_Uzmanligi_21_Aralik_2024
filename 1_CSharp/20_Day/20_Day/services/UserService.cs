using System.Numerics;
using _20_Day.Models;
using _20_Day.Services;
using _20_Day.Utils;
using MongoDB.Driver;

namespace _20_Day.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _userCollection;
        public UserService()
        {
            DBMongo dbMongo = new DBMongo();
            _userCollection = dbMongo.GetMongoCollection<User>("users");
        }

        //Sayfalama
        public UserPage GetAllUsersPage(int pageSize, int pageNumber)
        {
            var filter = Builders<User>.Filter.Empty;
            var totalCount = _userCollection.CountDocuments(filter);
            var totalPage = (int)Math.Ceiling((double)totalCount / pageSize);

            var users = _userCollection.Find(filter)
                .Skip((pageNumber - 1) * pageSize)
                .Limit(pageSize)
                .ToList();
            UserPage userPage = new()
            {
                TotaalCount = (int)totalCount,
                TotalPage = totalPage,
                Users = users
            };
            return userPage;
                
        }
    }
}