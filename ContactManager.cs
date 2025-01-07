using System;
// Create a class ContactManager to handle the contact list and perform different operations on the contact list 
public class ContactManager
{
    // List to store the contact details
    private List<Contact> contacts = new List<Contact>();
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
    // Function to edit the details of existing contact
    public void EditContacts(string name)
    {
        Contact user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Name == name)
            {
                user = contact;
            }
        }
        if (user != null)
        {
            Console.Write("Enter new phone number: ");
            user.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Contact edited successsfully!!");
        }
    }
    // Function to delete an existing contact from the contact list
    public void DeleteContacts(string name)
    {
        Contact user = null;
        foreach (Contact contact in contacts)
        {
            if (contact.Name == name)
            {
                user = contact;
            }
        }
        if (user != null)
        {
            contacts.Remove(user);
            Console.WriteLine("Contact deleted successsfully!!");
        }
    }

    // Function to search for a contact
    public void SearchContacts(string name)
    {
        int found = 0;
        Contact user = null;
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
}
