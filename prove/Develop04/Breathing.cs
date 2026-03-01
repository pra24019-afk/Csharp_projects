using System;

public class Breathing: Activity
{
    public Breathing(int seconds)
    {
        Console.WriteLine("Breathing slowly will help you to clear your mind and focus only on your breathing.");
        
        for (int i=0; i<(seconds/2); i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breath out...");
            Thread.Sleep(1000);
        }
    }
}
