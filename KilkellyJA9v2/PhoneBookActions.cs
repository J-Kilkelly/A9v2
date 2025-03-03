using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace KilkellyJA9v2;


public class PhoneBookAction
{
    private List<EntryDetail> bookEntries = new List<EntryDetail>(); //creates my list of type EntryDetail
    
    public void AddEntryToList(EntryDetail entry) //tried to make a method to write to the List<>; this does not work and I can't call it from Program.cs There is a problem with 'entry'.
    {
        bookEntries.Add(entry);
        Console.WriteLine($"{entry.FirstName} {entry.LastName} has been added to the phonebook list.\n");
        Console.WriteLine($"entry count = {bookEntries.Count}"); //remove this; test to see if there is data in my struct
    }

    //attempt to write to textfile. Does not work.
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