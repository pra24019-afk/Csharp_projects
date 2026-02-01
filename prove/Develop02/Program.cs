using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal._name = myJournal.AskName();

        Entry entry1 = new Entry();
        Entry entry2 = new Entry();
        Entry entry3 = new Entry();

        Console.WriteLine("Entry1");
        entry1._dateOfEntry = entry1.AskDate();
        entry1._entryDetails = entry1.AskDetails();
        Console.WriteLine();

        Console.WriteLine("Entry2");
        entry2._dateOfEntry = entry2.AskDate();
        entry2._entryDetails = entry2.AskDetails();
        Console.WriteLine();

        Console.WriteLine("Entry3");
        entry3._dateOfEntry = entry3.AskDate();
        entry3._entryDetails = entry3.AskDetails();
        Console.WriteLine();

        myJournal._entries.Add(entry1);
        myJournal._entries.Add(entry2);
        myJournal._entries.Add(entry3);
        myJournal.DisplayJournal();
    }
}
