using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;
        while (running == true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new multiple choice question");
            Console.WriteLine("2. Add new true / false question");
            Console.WriteLine("3. Add new short answer question");
            Console.WriteLine("4. Examine existing questions");
            Console.WriteLine("5. Begin quiz session");
            Console.WriteLine("6. Quit");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                
            }else if (menuChoice == 2)
            {
                
            }else if (menuChoice == 3)
            {
                
            }else if (menuChoice == 4)
            {
                
            }else if (menuChoice == 5)
            {
                
            }else if (menuChoice == 6)
            {
                running = false;
                Console.WriteLine("Quitting...");
            }

            //add flashcard deck with new questions to the flashcard deck with the correct and incorrect answers.
        }
        
        
    }
}
