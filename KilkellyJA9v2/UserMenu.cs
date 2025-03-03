
using System.Collections;
using System.Dynamic;
using System.Runtime.CompilerServices;

namespace KilkellyJA9v2;


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
                    ActionHandlers holder2 = new ActionHandlers();
                    System.Action myHolder2 = holder2.PlaceHolder;
                    return myHolder2;
                    break;

                case Actions.SearchNames:
                    ActionHandlers holder3 = new ActionHandlers();
                    System.Action myHolder3 = holder3.PlaceHolder;
                    return myHolder3;
                    break;

                case Actions.DeleteName:
                    ActionHandlers holder4 = new ActionHandlers();
                    System.Action myHolder4 = holder4.PlaceHolder;
                    return myHolder4;
                    break;

                case Actions.Exit:
                    ActionHandlers holder5 = new ActionHandlers();
                    System.Action myHolder5 = holder5.PlaceHolder;
                    return myHolder5;
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