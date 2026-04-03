using System;
using System.IO;

public class Journal
{
    private string _name;
    public Journal(string name)
    {
        _name = name;
    }
    public List<Entry> _entries = new List<Entry>();
    
    public void DisplayJournal()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Entry count: {_entries.Count}");
        Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry.GetDateOfEntry()}");
            Console.WriteLine($"Details:");
            Console.WriteLine(entry.GetEntryDetails());
            Console.WriteLine();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry e in _entries)
            {
                outputFile.WriteLine($"{e.GetDateOfEntry()}|{_name}|{e.GetEntryDetails()}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');

            int date = int.Parse(parts[0]);
            string name = parts[1];
            string details = parts[2];

            Entry newEntry = new Entry(date, details, name);
            _entries.Add(newEntry);
        }
        Console.WriteLine("Journal loaded successfully!");
    }
}
