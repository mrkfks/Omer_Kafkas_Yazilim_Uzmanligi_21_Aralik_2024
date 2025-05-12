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
        // yaşı 30'dan büyük ve ip adresleri belirli bir aralıkta olan kullanıcıları listeleme
        public List <User> AgeIp (int minAge, string ip)
        {
            var filter = Builders<User>.Filter.Gt(u => u.Age, minAge) &
                         Builders<User>.Filter.Regex(u => u.ip_adress, new MongoDB.Bson.BsonRegularExpression("^" + ip + "\\."));
            var users = _userCollection.Find(filter).ToList();
            return users;
        }

        public List<User> UserDateReport()
            {
                var filter = Builders<User>.Filter.Gt(u => u.Date, DateTime.Now.AddDays(-30));
                var users = _userCollection.Find(filter)
                    .SortByDescending(u => u.Date)
                    .ToList();
                return users;
            }

            //Cinsiyete göre gruplama
            public List<GenderGroup> GroupByGender(string gender)
            {
                var genderStatus = _userCollection.Aggregate()
                    .Group
                    (
                        u => u.Gender, u => new GenderGroup
                        {
                            Gender = u.Key ?? "Unknown",
                            Count = u.Count()
                        })
                    .ToList();

                return genderStatus;
            }

            //yaş ortalamasını hesaplama
            public double AverageAge()
            {
                var average = _userCollection.Aggregate()
                    .Group
                    (
                        u => 1, u => new { AverageAge = u.Average(x => x.Age) }
                    )
                    .FirstOrDefault();

                return Math.Round(average.AverageAge, 2);
            }

            // en yaşlı 5 kullanıcıyı listeleme
            public List <User> GetTop5OldestUsers()
            {
                var result = _userCollection.Find(Builders<User>.Filter.Empty)
                    .SortByDescending(x => x.Age)
                    .Limit(5)
                    .Project(p => new User
                    {
                        Name = p.Name,
                        Surname = p.Surname,
                        Email = p.Email,
                        Age = p.Age
                    })
                    .ToList();
                return result;
            }

            //email null yada "" olanlarını listeleme
            public List<User> GetEmailNullOrEmpty()
            {
                var Filter = Builders<User>.Filter.Or(
                    Builders<User>.Filter.Eq(u => u.Email, null),
                    Builders<User>.Filter.Eq(u => u.Email, "")
                );
                var users = _userCollection.Find(Filter).ToList();
                return users;
            }
            // yaşları 20 ile 30 arasında olan kullanıcıları listeleme ve adlarını küçük harfle yazma
            public List<User> GetUsersByAgeRange(int minAge, int maxAge)
            {
                var filter = Builders<User>.Filter.And(
                    Builders<User>.Filter.Gte(u => u.Age, minAge),
                    Builders<User>.Filter.Lte(u => u.Age, maxAge)
                );
                var users = _userCollection.Find(filter).Project(u => new User
            {
                Name = u.Name!.ToLower(),
                Surname = u.Surname!.ToLower()
            }).ToList();
            return users;
            }
    }
}
