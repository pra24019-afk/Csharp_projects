using System;

public class MultipleChoiceQuestion: Question
{
    private List<string> _choices;
    private string _correctAnswer;
    public MultipleChoiceQuestion(string prompt, List<string> choices, string answer): base(prompt)
    {
        _choices = choices;
    }
}
