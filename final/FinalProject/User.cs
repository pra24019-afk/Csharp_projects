using System;

public class User
{
    private string _name;
    private int _totalScore;
    public User(string name)
    {
        _name = name;
        _totalScore = 0;
    }
    public void AddScore(int score)
    {
        _totalScore += score;
    }
    public int DisplayTotalScore()
    {
        return _totalScore;
    }
}
