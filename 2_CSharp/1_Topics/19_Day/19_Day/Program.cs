using System;
using 19_Day;

namespace 19_Day
{
    class Program
{
    static void Main(string[] args)
    {
        Contact contact = new Contact(1, "John", "Doe", "john.doe@example.com", "1234567890", "123 Main St");
        ContactService contactService = new ContactService();
        int result = contactService.AddContact(contact);
        if (result > 0)
        {
            Console.WriteLine("Contact added successfully with ID: " + result);
        }
        else
        {
            Console.WriteLine("Failed to add contact.");
        }      
    }
}
}
