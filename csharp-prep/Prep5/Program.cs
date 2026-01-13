using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please Enter your Favorite Number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static void PromptUserBirthYear(out int year)
    {
        Console.Write("Please Enter your Birth Year: ");
        year = int.Parse(Console.ReadLine());
    }

    static double SquareNumber(int num)
    {
        double newNum = Math.Pow(num,2);
        return newNum;
    }

    static void DisplayResult()
    {
        string name = PromptUserName();
        int num = PromptUserNumber();
        double square = SquareNumber(num);
        int year;
        PromptUserBirthYear(out year);
        Console.WriteLine($"{name}, the square of your favorite number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026-year} this year.");
    }


}
