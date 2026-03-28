using System;

public class ShortAnswerQuestion: Question
{
    private string _answer;
    public ShortAnswerQuestion(string prompt, string answer): base(prompt)
    {
        _answer = answer;
    }
}
