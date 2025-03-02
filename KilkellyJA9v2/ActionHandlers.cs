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
        menu.getUserMenu();
    }

    string contactTypeMenu = @"
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4";

    public EntryDetail GetUserInput()
    {
        Console.WriteLine("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Phone Number Name: ");
        string phoneNumber = Console.ReadLine();

        Console.WriteLine("Select contact type:\n");
        Console.WriteLine(contactTypeMenu);
        Console.WriteLine(); //line feed
        string contactTypeInput = Console.ReadLine();
        if(Enum.TryParse(contactTypeInput, out ContactType contactTypeValue))
        {
            Enum contactType = contactTypeValue;
            EntryDetail entry = new EntryDetail(lastName, firstName, phoneNumber, contactTypeValue);
        }
        else
        {
            Console.WriteLine("Selection for contact type was not valid. Contact type 'other' will be applied.");
            contactTypeValue = ContactType.Other;
            return new EntryDetail
            {
                LastName = lastName,
                FirstName = firstName,
                PhoneNumber = phoneNumber,
                ContactType = contactTypeValue
            };
        }
    }
}
