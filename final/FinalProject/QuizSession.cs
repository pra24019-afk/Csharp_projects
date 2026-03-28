using System;

public class QuizSession
{
    private FlashCardDeck _deck;
    private int _score;
    public QuizSession(FlashCardDeck deck)
    {
        _deck = deck;
        _score = 0;
    }
}
