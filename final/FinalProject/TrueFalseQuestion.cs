using System;

public class TrueFalseQuestion: Question
{
    private bool _answer;
    public TrueFalseQuestion(string prompt, bool answer): base(prompt)
    {
        _answer = answer;
    }
    public override bool CheckAnswer(string userAnswer)
    {
        return userAnswer.ToLower() == _answer.ToString().ToLower();
    }
}
