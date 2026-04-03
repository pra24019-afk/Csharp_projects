using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal!");
        Console.WriteLine("What is your name?");
        string _name = Console.ReadLine();
        Journal myJournal = new Journal(_name);

        int _menuChoice;
        bool running = true;
        while (running)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Write New Entry (10. Write new entry without optional entry topic)");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            _menuChoice = int.Parse(Console.ReadLine());

            if (_menuChoice == 1)
            {
                Console.WriteLine("New Entry:");
                Console.WriteLine("What is the date? (MMDDYYYY)");
                int _dateOfEntry = int.Parse(Console.ReadLine());

                Console.WriteLine("Entry Details:");
                Console.Write("Optional entry topic: ");
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
                string _entryDetails = Console.ReadLine();

                Entry entry = new Entry(_dateOfEntry, _entryDetails, _name);
                myJournal._entries.Add(entry);

                Console.WriteLine("Entry Added!");
                Console.WriteLine();

            }else if (_menuChoice == 10)
            {
                Console.WriteLine("New Entry:");
                Console.WriteLine("What is the date? (MMDDYYYY)");
                int _dateOfEntry = int.Parse(Console.ReadLine());

                Console.WriteLine("Entry Details:");
                string _entryDetails = Console.ReadLine();

                Entry entry = new Entry(_dateOfEntry, _entryDetails, _name);
                myJournal._entries.Add(entry);

            }else if (_menuChoice == 2)
            {
                myJournal.DisplayJournal();

            }else if (_menuChoice == 3)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }else if (_menuChoice == 4)
            {
                Console.WriteLine("What is the filename?");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }else if (_menuChoice == 5)
            {
                running = false;
                Console.WriteLine("Quitting...");
            }
            else {
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
            }
        }

    }
}
