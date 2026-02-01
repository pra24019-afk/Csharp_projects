using System;

public class Journal
{
    public string _name;
    public string AskName(){
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }
    public List<Entry> _entries = new List<Entry>();
    public void DisplayJournal()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Entry count: {_entries.Count}");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._dateOfEntry}");
            Console.WriteLine(entry._entryDetails);
            Console.WriteLine("--------------");
        }
    }
}
