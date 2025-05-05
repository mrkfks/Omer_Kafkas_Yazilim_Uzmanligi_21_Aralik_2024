using _20_Day.Models;
using MongoDB.Driver;

namespace _20_Day.Services;

public class PersonService
{
    private readonly IMongoCollection<Person> _personCollection;

    public PersonService()
    {
        DBMongo dbMongo = new DBMongo();
        _personCollection = dbMongo.GetMongoCollection<Person>("persons");
    }
    //Add Person
    public int AddPerson(Person person)
    {
        try
        {
            _personCollection.InsertOne(person);
            return 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error adding person: {ex.Message}");
        }
        return 0;
    }
    
    //Get All Persons
    public List<Person> GetAllPersons()
    {
        List<Person> list = _personCollection.Find(_=>true).ToList();
        return list;

    }
    //Delete Person
    public void Deleteperson(string ID)
    {
        _personCollection.DeleteOne(x  => x.PersonId == ID);
    }
    public long DeletePersonByEmail(string email)
    {
        DeleteResult deleteResult = _personCollection.DeleteMany(x => x.Email == email);
        if (deleteResult.DeletedCount > 0) 
        {
            return deleteResult.DeletedCount;
        }
        return 0;
    }
    //Update Person
    public bool UpdatePerson(Person person)
    {
        var filter = Builders<Person>.Filter.Eq(item => item.Id, person.Id);
        ReplaceOneResult replaceOneResult = _personCollection.ReplaceOne(filter, person);
        return replaceOneResult.ModifiedCount > 0;
    }
}

