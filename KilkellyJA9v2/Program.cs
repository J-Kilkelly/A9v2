namespace KilkellyJA9v2;

class Program
{
    static void Main(string[] args)
    {
        UserMenu userInput = new UserMenu();
        userInput.getUserChoice(); //this works
        PhoneBookAction bookAction = new PhoneBookAction();
        bookAction.AddEntryToList(EntryDetail entry); //this doesn't work
        //bookAction.WriteToFile();
    }
}
