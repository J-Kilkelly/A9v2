namespace KilkellyJA9v2;

class Program
{
    static void Main(string[] args)
    {
        UserMenu userInput = new UserMenu();
        userInput.getUserChoice();
        PhoneBookAction bookAction = new PhoneBookAction();
        bookAction.AddEntryToList(EntryDetail entry);
        //bookAction.WriteToFile();
    }
}
