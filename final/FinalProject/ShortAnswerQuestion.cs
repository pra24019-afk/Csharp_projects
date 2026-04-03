using System;

public class ShortAnswerQuestion: Question
{
    private string _answer;
    public ShortAnswerQuestion(string prompt, string answer): base(prompt)
    {
        _answer = answer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToLower() == _answer.ToLower();
    }
}
