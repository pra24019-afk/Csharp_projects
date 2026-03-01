using System;

public class Listing: Activity
{
    private List<string> prompt = new List<string>
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };
    public Listing(int seconds)
    {
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Random random = new Random();
        Console.WriteLine(prompt[random.Next(0,4)]);
        Thread.Sleep(seconds);
    }
}
