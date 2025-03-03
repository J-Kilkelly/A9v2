using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace KilkellyJA9v2;


public class PhoneBookAction
{
    private List<EntryDetail> bookEntries = new List<EntryDetail>(); //creates my list of type EntryDetail
    
    public void AddEntryToList(EntryDetail entry)
    {
        bookEntries.Add(entry);
        Console.WriteLine($"{entry.FirstName} {entry.LastName} has been added to the phonebook list.\n");
        Console.WriteLine($"entry count = {bookEntries.Count}"); //remove this!
    }

    private string filePath = @"C:\Users\jkilk\OneDrive\SPC\CSharp 1 2360\A9\KilkellyJA9v2\phonebook.txt";
    public void WriteToFile()
    {
        StreamWriter writer = new (new FileStream(filePath, FileMode.Append, FileAccess.Write));
        foreach (EntryDetail entry in bookEntries)
        {
            string formatedEntry = 
                ($"{entry.LastName, -14}{entry.FirstName, -14}{entry.PhoneNumber, -12}{entry.ContactType, -12}");
            writer.WriteLine(formatedEntry);
        }
        writer.Close();
    
    }
    
}