using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
// Create a class ContactManager to handle the contact list and perform different operations on the contact list 
public class ContactManager
{
    // List to store the contact details
    private List<Contact> contacts = new List<Contact>();
    // Function to find contact by name
    public Contact findContactByName(string name)
    {
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Name == name)
            {
                user = contact;
            }
        }
        return user;
    }
    // Function to find contact by email
    public Contact findContactByEmail(string email)
    {
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Email == email)
            {
                user = contact;
            }
        }
        return user;
    }
    // Function to find contact by phone number
    public Contact findContactByNumber(string phonenumber)
    {
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.PhoneNumber == phonenumber)
            {
                user = contact;
            }
        }
        return user;
    }

    // Function to add contacts to the contact list
    public void AddContacts(Contact contact)
    {
        contacts.Add(contact);
        Console.WriteLine("Contact Added Successfully!!");
    }
    // Function to view the contact list
    public void ViewContacts()
    {
        if (contacts.Count == 0)
        {
            Console.WriteLine("No Contacts found.");
        }
        else
        {
            Console.WriteLine("\n---- Contacts List ----");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.ReturnString());
            }
        }
    }
    // Function to edit the phone number of existing contact with name
    public void EditContactsByName(string name)
    {
        Contact? user = null;
        user = findContactByName(name);
        if (user != null)
        {
            Console.Write("Enter new phone number: ");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Contact edited successsfully!!");
        }
        else
        {
            Console.WriteLine("User with the entered name doesn't exist");
        }
    }
    // Function to edit the phone number of existing contact with number
    public void EditContactsByNumber(string phonenumber)
    {
        Contact? user = null;
        user = findContactByNumber(phonenumber);
        if (user != null)
        {
            Console.Write("Enter new phone number: ");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Contact edited successsfully!!");
        }
        else
        {
            Console.WriteLine("User with the entered number doesn't exist");
        }

    }
    // Function to edit the phone number of existing contact with email
    public void EditContactsByEmail(string email)
    {
        Contact? user = null;
        user = findContactByEmail(email);
        if (user != null)
        {
            Console.Write("Enter the new phone number: ");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Contact edited successsfully!!");
        }
        else
        {
            Console.WriteLine("User with the entered email doesn't exist");
        }

    }

    // Function to delete an existing contact from the contact list
    public void DeleteContacts(string name)
    {
        Contact? user = null;
        user = findContactByName(name);
        if (user != null)
        {
            contacts.Remove(user);
            Console.WriteLine("Contact deleted successsfully!!");
        }
    }
    // Function to search for a contact by their name
    public void SearchContactsByName(string name)
    {
        int found = 0;
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Name == name)
            {
                found = 1;
                user = contact;
                Console.WriteLine(user.ReturnString());
            }
        }
        if (found == 0)
        {
            Console.WriteLine("No contact with the search name exists!!");
        }
    }
    // Function to search for a contact by their phone number
    public void SearchContactsByNumber(string phonenumber)
    {
        int found = 0;
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.PhoneNumber == phonenumber)
            {
                found = 1;
                user = contact;
                Console.WriteLine(user.ReturnString());
            }
        }
        if (found == 0)
        {
            Console.WriteLine("No contact with the search number exists!!");
        }
    }
    // Function to search for a contact by their phone number
    public void SearchContactsByMail(string mail)
    {
        int found = 0;
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Email == mail)
            {
                found = 1;
                user = contact;
                Console.WriteLine(user.ReturnString());
            }
        }
        if (found == 0)
        {
            Console.WriteLine("No contact with the search email exists!!");
        }
    }
    // Function to search for a contact by the additional notes
    public void SearchContactsByNotes(string notes)
    {
        int found = 0;
        Contact? user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Notes == notes)
            {
                found = 1;
                user = contact;
                Console.WriteLine(user.ReturnString());
            }
        }
        if (found == 0)
        {
            Console.WriteLine("No contact with the search notes exists!!");
        }
    }
}
