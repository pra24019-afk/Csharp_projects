using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        Fraction fraction = new Fraction();
        Random random = new Random();
        for (int i=0; i<25; i++){
            int num = random.Next(0,100);
            int den = random.Next(1,100);
            fraction.SetTop(num);
            fraction.SetBottom(den);
            Console.WriteLine($"Fraction: {i}, string: {fraction.GetFractionString()}, Number: {fraction.GetDecimalValue()}");
        }
    }
}
