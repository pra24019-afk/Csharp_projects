using System;

public class MathAssignment: Assignment
{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems): base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        string name = base.GetStudentName();
        return $"{name}: {_textbookSection}, {_problems}";
    }
}
