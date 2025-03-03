
using System.Collections;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace KilkellyJA9v2;

public class UserMenu
{
    public void getUserChoice()
    {
        Console.WriteLine(@"
        Enter 1 to add a name
        Enter 2 to view the phonebook
        Enter 3 to search names
        Enter 4 to delete a name
        Enter 5 to exit the application");
        string? userSelection = Console.ReadLine();

        if (Enum.TryParse(userSelection, out Actions action))
        {
            switch (action)
            {
                case Actions.AddName:
                    ActionHandlers add = new ActionHandlers();
                    add.GetUserInput();
                    PhoneBookAction write = new PhoneBookAction();
                    write.WriteToFile();
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
        {   
            ActionHandlers invalid = new ActionHandlers();
            invalid.InvalidInput();
        }
    }

    public enum Actions
    {
        AddName = 1,
        ViewNames = 2,
        SearchNames = 3,
        DeleteName = 4,
        Exit = 5
    }
}