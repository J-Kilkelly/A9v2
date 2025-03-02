
using System.Collections;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace KilkellyJA9v2;

public enum ContactType
{
    Personal = 1,
    Work = 2,
    School = 3,
    Other = 4
}

public struct entryDetail
{
    public string LastName;
    public string FirstName;
    public string PhoneNumber;
    public ContactType ContactType;
}

public class UserMenu
{
    public void getUserMenu()
    {
        Console.WriteLine(userMenu);
        Console.WriteLine();
    }

    private string userMenu = @"
Enter 1 to add a name
Enter 2 to view the phonebook
Enter 3 to search names
Enter 4 to delete a name
Enter 5 to exit the application";

    public enum Actions
    {
        AddName = 1,
        ViewNames = 2,
        SearchNames = 3,
        DeleteName = 4,
        Exit = 5
    }
    string? userSelection = Console.ReadLine();
    public Action GetUserAction()
    {
        //string? userSelection = Console.ReadLine();
        if (Enum.TryParse(userSelection, out Actions action))
        {
            switch (action)
            {
                case Actions.AddName:
                    
                    break;

                case Actions.ViewNames:

                    break;

                case Actions.SearchNames:

                    break;

                case Actions.DeleteName:

                    break;

                case Actions.Exit:

                    break;
            }
        }
        else
        {   ActionHandlers invalid = new ActionHandlers();
            System.Action invalidAction = invalid.InvalidInput;
            return invalidAction;
        }
    }
}