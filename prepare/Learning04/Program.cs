using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment compito = new Assignment("David Crayola", "Calculus");
        string summary = compito.GetSummary();

        MathAssignment math = new MathAssignment("David Crayola", "Integration", "Section 3", "P- 1,2,3,4");
        string homeworkList = math.GetHomeworkList();

        WritingAssignment yuck = new WritingAssignment("David Crayola", "Creative Writing", "Rhetoric");
        string writingInfo = yuck.GetWritingInformation();

        Console.WriteLine("Assignments:");
        Console.WriteLine(summary);
        Console.WriteLine(homeworkList);
        Console.WriteLine(writingInfo);
    }
}
