using System;

public class Reflection: Activity
{
    private List<string> prompt = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> secondPrompt = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    
    public Reflection(int seconds)
    {
        Console.WriteLine("Reflection will help you to reflect on times of strength in your life.");
        Random random = new Random();
        Console.WriteLine(prompt[random.Next(0,3)]);
        Thread.Sleep(1000);
        for (int i=0; i<(seconds-1); i++)
        {
            Console.WriteLine(secondPrompt[random.Next(0,8)]);
            Thread.Sleep(1000);
        }
    }
    
}
