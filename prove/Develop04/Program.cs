using System;

class Program
{
    static void Main(string[] args)
    {   
        bool cont = true;
        while (cont == true)
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("Options");
            Console.WriteLine("Breathing:  Select 1");
            Console.WriteLine("Reflection: Select 2");
            Console.WriteLine("Listing:    Select 3");
            Console.WriteLine("Journaling: Select 4");
            Console.WriteLine("Quit:       Select 0");
            Console.Write("Choose a mindfulness activity: ");

            int option = int.Parse(Console.ReadLine());
            int time = 0;
            if (option != 0)
            {
                Activity activity = new Activity();
                time = int.Parse(Console.ReadLine());
            }

            if (option == 1)
            {

                Breathing breathing = new Breathing(time);

            }else if (option == 2)
            {
            
                Reflection reflections = new Reflection(time);

            }else if (option == 3)
            {

                Listing listing = new Listing(time);

            }else if (option == 4)
            {

                Journaling journaling = new Journaling(time);

            }else if (option == 0)
            {
                cont = false;
                Console.WriteLine("Quitting");
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
        
    }
}
