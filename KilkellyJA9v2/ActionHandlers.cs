using KilkellyJA9v2;

public class ActionHandlers
{
public void InvalidInput()
    {
        Console.WriteLine("Input was not valid. Please try again.");
        Console.WriteLine();
        UserMenu menu = new UserMenu();
        menu.getUserMenu();
    }
}
