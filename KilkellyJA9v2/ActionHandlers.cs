using System.Security.Cryptography.X509Certificates;
using KilkellyJA9v2;

public enum ContactType
{
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4
}

public struct EntryDetail
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

    string contactTypeMenu = @"
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4";

    public string? entry;

    public EntryDetail GetUserInput()
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
        
        if(Enum.TryParse(contactTypeInput, out ContactType contactTypeValue))
        {
            Enum contactType = contactTypeValue;
            entry = new EntryDetail(lastName, firstName, phoneNumber, contactTypeValue);
            Console.WriteLine($"{entry.FirstName}");
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
