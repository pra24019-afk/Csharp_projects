using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNum = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1,100);
        
        bool guessed = false;
        while (guessed == false)
        {
            Console.Write("What is your guess? ");
            int num = int.Parse(Console.ReadLine());
            if (num == magicNum)
            {
                guessed = true;
                Console.WriteLine("You guessed it! Well done!");
            }else if (num > magicNum)
            {
                Console.WriteLine("Lower");
            }else if (num < magicNum)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}
