using System;

public class User
{
    private string _name;
    private int _totalScore;
    public User(string name)
    {
        _name = name;
    }
    public void AddScore(int score)
    {
        _totalScore += score;
    }
}
