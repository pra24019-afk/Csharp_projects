using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        float grade = float.Parse(Console.ReadLine());
        string letter = "";
        bool passed = false;

        if (grade >= 90)
        {
            letter = "A";
            passed = true;
        }else if (grade >= 80) {
            letter = "B";
            passed = true;
        }else if (grade >= 70)
        {
            letter = "C";
            passed = true;
        }else if (grade >= 60)
        {
            letter = "D";
        }else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (passed == true)
        {
            Console.Write("Well done you passed!");
        }
        else
        {
            Console.Write("You did not pass the class. Better luck next time.");
        }
    }
}
