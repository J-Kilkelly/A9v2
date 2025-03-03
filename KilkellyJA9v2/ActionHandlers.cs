using System.Security.Cryptography.X509Certificates;
using KilkellyJA9v2;

public enum ContactType //enum for contact type; this worked
{
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4
}

public struct EntryDetail //struct for entry detail
{
    public string LastName;
    public string FirstName;
    public string PhoneNumber;
    public ContactType ContactType;
    
    public EntryDetail(string lastName, string firstName, string phoneNumber, ContactType contactType)
    {
        LastName = lastName;
        FirstName = firstName;
        PhoneNumber = phoneNumber;
        ContactType = contactType;
    }
}

public class ActionHandlers
{
    public void InvalidInput() //handles invalid user input in response to the main user menu
    {
        Console.WriteLine("Input was not valid. Please try again.");
        Console.WriteLine();
        UserMenu menu = new UserMenu();
        menu.getUserChoice();
    }
    //string is used below to write menu of contact-type options to the console
    string contactTypeMenu = @"
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4";

    public string? entry;

    public EntryDetail GetUserInput() //this did work when called from Program.cs
    {
        Console.WriteLine("Enter Last Name: ");
        string? lastName = Console.ReadLine();

        Console.WriteLine("Enter First Name: ");
        string? firstName = Console.ReadLine();

        Console.WriteLine("Enter Phone Number Name: ");
        string? phoneNumber = Console.ReadLine();

        Console.WriteLine("Select contact type:");
        Console.WriteLine(contactTypeMenu);
        Console.WriteLine(); //line feed

        string? contactTypeInput = Console.ReadLine();
        EntryDetail entry = default(EntryDetail);
        
        if(Enum.TryParse(contactTypeInput, out ContactType contactTypeValue)) //tried to put user input entered as string into struct
        {
            Enum contactType = contactTypeValue;
            entry = new EntryDetail(lastName, firstName, phoneNumber, contactTypeValue);
            Console.WriteLine($"{entry.FirstName}");//this works properly so the input data is getting into the struct
        }
        else
        {
            Console.WriteLine("Selection for contact type was not valid. Contact type 'other' will be applied.");
            contactTypeValue = ContactType.Other;
            entry = new EntryDetail
            {
                LastName = lastName,
                FirstName = firstName,
                PhoneNumber = phoneNumber,
                ContactType = contactTypeValue
            };
        return entry;
        }
        
    }
    
}
