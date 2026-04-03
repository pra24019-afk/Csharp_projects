using System;
public class FlashCardDeck
{
    private List<Question> _questions = new List<Question>();
    public void AddQuestion(Question q)
    {
        _questions.Add(q);
    }
    public List<Question> GetQuestions()
    {
        return _questions;
    }
}
