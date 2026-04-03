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
    public void Start()
    {
        foreach (Question q in _deck.GetQuestions())
        {
            q.Display();
            string answer = Console.ReadLine();

            if (q.CheckAnswer(answer))
            {
                Console.WriteLine("Correct!");
                Console.WriteLine();
                _score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
                Console.WriteLine();
            }
        }
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine();
    }
}
