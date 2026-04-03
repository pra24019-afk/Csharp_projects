using System;

public class MultipleChoiceQuestion: Question
{
    private List<string> _choices;
    private string _correctAnswer;
    public MultipleChoiceQuestion(string prompt, List<string> choices, string answer): base(prompt)
    {
        _choices = choices;
        _correctAnswer = answer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToLower() == _correctAnswer.ToLower();
    }
    public override void Display()
    {
        Console.WriteLine(_prompt);
        foreach (string choice in _choices)
        {
            Console.WriteLine(choice);
        }
        Console.WriteLine();
    }
}
