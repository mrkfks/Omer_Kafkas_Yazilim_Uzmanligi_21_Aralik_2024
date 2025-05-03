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
    
}

