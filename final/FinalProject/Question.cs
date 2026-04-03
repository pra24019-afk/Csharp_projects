using System;

public class Question
{
    protected string _prompt;
    public Question(string prompt)
    {
        _prompt = prompt;
    }
    public virtual bool CheckAnswer(string userAnswer)
    {
        return false;
    }
    public virtual void Display()
    {
        Console.WriteLine(_prompt);
        Console.WriteLine();
    }

}
