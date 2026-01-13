using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numArray = new List<int>();
        int newNum;
        float sum = 0;
        int large = 0;
        while (true)
        {
            Console.Write("Enter Number: ");
            newNum = int.Parse(Console.ReadLine());
            if (newNum == 0)
            {
                break;
            }
            else
            {
                numArray.Add(newNum);
            }
        }
        foreach (int num in numArray)
        {
            sum += num;
        }
        float average = sum/numArray.Count;
        foreach (int num in numArray)
        {
            if (num > large)
            {
                large = num;
            }
        }
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {large}");
    }
}
