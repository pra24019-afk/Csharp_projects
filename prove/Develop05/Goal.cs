using System;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return 0;
    }

    public virtual string GetDetailsString()
    {
        string status = _isComplete ? "[x]" : "[ ]";
        return $"{status}, {_name}, {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name}, {_description}, {_points}";
    }
}
