using System;

public class TrueFalseQuestion: Question
{
    private bool _answer;
    public TrueFalseQuestion(string prompt, bool answer): base(prompt)
    {
        _answer = answer;
    }
}
