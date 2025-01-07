using System;
public class Menu
{
    public ContactManager contactManager = new ContactManager();
    // Menu to display choices and interact with the user 
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nWelcome to Contact Manager!!");
            Console.WriteLine("1. View Contacts");
            Console.WriteLine("2. Add New Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Search Contact");
            Console.WriteLine("6. Exit");
            Console.Write("\nEnter your choice of operation: ");
            string userChoice = Console.ReadLine();
            // Switch case to handle user choice and perform operations on the contact list   
            switch (userChoice)
            {
                case "1":
                    contactManager.ViewContacts();
                    break;
                case "2":
                    AddContact();
                    break;
                case "3":
                    EditContact();
                    break;
                case "4":
                    DeleteContact();
                    break;
                case "5":
                    SearchContact();
                    break;
                case "6":
                    Console.WriteLine("Exiting the system!! Bye!!");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
    private void AddContact()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter email: ");
        string email = Console.ReadLine();
        Console.Write("Enter additional notes: ");
        string notes = Console.ReadLine();
        var newUser = new Contact
        {
            Name = name,
            PhoneNumber = phoneNumber,
            Email = email,
            Notes = notes
        };
        contactManager.AddContacts(newUser);
    }
    private void EditContact()
    {
        Console.Write("Enter the name of the contact to edit: ");
        string name = Console.ReadLine();
        contactManager.EditContacts(name);
    }
    private void DeleteContact()
    {
        Console.Write("Enter the name of the contact to delete: ");
        string name = Console.ReadLine();
        contactManager.DeleteContacts(name);
    }
    private void SearchContact()
    {
        Console.Write("Enter the name of the contact to search: ");
        string name = Console.ReadLine();
        contactManager.SearchContacts(name);
    }
}