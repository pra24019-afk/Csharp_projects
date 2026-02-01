using System;

public class Entry
{
    public int _dateOfEntry;
    public string _entryDetails;
    public string _name;
   
    public string AskDetails()
    {
        Console.WriteLine("Entry details:");
        Random rand = new Random();
        int number = rand.Next(1, 5);
        if (number == 1) {
            Console.WriteLine("What was the best part of my day?");
        }else if (number == 2) {
            Console.WriteLine("What could I have done better today?");
        }else if (number == 3) {
            Console.WriteLine("What made you laugh today?");
        }else if (number == 4) {
            Console.WriteLine("How did you see the hand of the Lord today?");
        }else if (number == 5) {
            Console.WriteLine("What made you happy today?");
        }
        string details = Console.ReadLine();
        return details;
    }
    public int AskDate()
    {
        Console.Write("What is the date (MMDDYYYY)? ");
        int date = int.Parse(Console.ReadLine());
        return date;
    }
}
