using System;

// Create the Class for storing the contact details with data members of name, phone number, email, and notes 
public class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Notes { get; set; }
    // Function to return the contact details as a string
    public string ReturnString()
    {
        return $"Name: {Name}, Phone Number: {PhoneNumber}, Email: {Email}, Notes: {Notes}";
    }

}
