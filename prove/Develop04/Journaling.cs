using System;

public class Journaling: Activity
{
    private List<string> prompt = new List<string>
    {
      "how the Lord has blessed you on this day.",
      "what stuck out to you as special today.",
      "how you could have done better today.",
      "how you have seen the hand of the Lord in your day."  
    };
    public Journaling(int seconds)
    {
        Console.WriteLine("Journaling will help you remember the good things that have happened to you.");
        Random random = new Random();
        Console.WriteLine($"If you wish, you may write about {prompt[random.Next(0,3)]}");
        Thread.Sleep(seconds);
    }
    
}
