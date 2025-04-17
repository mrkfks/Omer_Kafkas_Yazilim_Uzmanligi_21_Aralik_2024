using Days_19;
using Days_19.Models;
using Days_19.services;

namespace Days_19;
    class Program
{
    static void Main(string[] args)
    {

        ContactService contactService = new ContactService();
        Contact contact = new Contact(0, "x", "y", "x@mail.com", "76543223", "İzmir");
        int result = contactService.AddContact(contact);
        Console.WriteLine("------------------");


        int resultDelete = contactService.DeleteContact(4);
        if (resultDelete > 0)
        {
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Failed to delete contact.");
        }
        Console.WriteLine("------------------");

        Console.WriteLine("------------------");



        List<Contact> contacts = contactService.GetAllContacts();
        if (contacts.Count == 0)
        {
            Console.WriteLine("No contacts found.");
        }
        else
        {
            foreach (var item in contacts)
            {
                Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
            }
        }
        Console.WriteLine("------------------");



        Contact singleContact = contactService.GetContactById(1);
        if (singleContact.Cid != null)
        {
            Console.WriteLine(singleContact.Cid + " " + singleContact.Name + " " + singleContact.Surname + " " + singleContact.Email + " " + singleContact.Phone + " " + singleContact.Address);
        }
        else
        {
            Console.WriteLine("No contact found with the given ID.");
        }
        Console.WriteLine("------------------");


        List<Contact> searchResults = contactService.SearchContact("a", 2);
        foreach (var item in searchResults)
        {
            Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
        }
        Console.WriteLine("------------------");

        List<Contact> contactFromView = contactService.GetContactsFromView();
        foreach (var item in contactFromView)
        {
            Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
        }
        Console.WriteLine("------------------");
        
        List<Contact> proContacts = contactService.GetProd(10);
        foreach (var item in proContacts)
        {
            Console.WriteLine(item.Cid + " " + item.Name + " " + item.Surname + " " + item.Email + " " + item.Phone + " " + item.Address);
        }
        Console.WriteLine("------------------");

    }

        

}