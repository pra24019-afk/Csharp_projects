using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the study tool! What is your name? ");
        string _name = Console.ReadLine();
        User user = new User(_name);

        FlashCardDeck deck = new FlashCardDeck();
        bool running = true;
        while (running == true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add new multiple choice question");
            Console.WriteLine("2. Add new true / false question");
            Console.WriteLine("3. Add new short answer question");
            Console.WriteLine("4. Review existing questions");
            Console.WriteLine("5. Begin quiz session");
            Console.WriteLine("6. Look at total score");
            Console.WriteLine("7. Quit");
            int menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                Console.WriteLine("Enter multiple choice question");
                string prompt = Console.ReadLine();

                List<string> choices = new List<string>();
                
                Console.Write("How many choices? ");
                int numChoices = int.Parse(Console.ReadLine());

                for (int i=0; i<numChoices; i++)
                {
                    Console.Write($"Enter choice {i+1}: ");
                    choices.Add(Console.ReadLine());
                }

                Console.WriteLine("Enter the correct answer:");
                string answer = Console.ReadLine();

                MultipleChoiceQuestion q = new MultipleChoiceQuestion(prompt, choices, answer);
                deck.AddQuestion(q);

                Console.WriteLine("Question Added!");
                Console.WriteLine();

            }else if (menuChoice == 2)
            {
                Console.WriteLine("Enter true/false question:");
                string prompt = Console.ReadLine();

                Console.WriteLine("Enter answer (true / false):");
                bool answer = bool.Parse(Console.ReadLine());

                TrueFalseQuestion q = new TrueFalseQuestion(prompt, answer);
                deck.AddQuestion(q);

                Console.WriteLine("Question Added!");
                Console.WriteLine();

            }else if (menuChoice == 3)
            {
                Console.WriteLine("Enter short answer question:");
                string prompt = Console.ReadLine();

                Console.WriteLine("Enter the answer:");
                string answer = Console.ReadLine();

                ShortAnswerQuestion q = new ShortAnswerQuestion(prompt, answer);
                deck.AddQuestion(q);

                Console.WriteLine("Question Added!");
                Console.WriteLine();

            }else if (menuChoice == 4)
            {
                foreach (Question q in deck.GetQuestions())
                {
                    q.Display();
                    Console.WriteLine();
                }
            }else if (menuChoice == 5)
            {
                QuizSession quiz = new QuizSession(deck);
                user.AddScore(quiz.Start());

            }else if (menuChoice == 6)
            {
                Console.WriteLine($"{_name}'s total score from all quizzes is: {user.DisplayTotalScore()}");
                Console.WriteLine();

            }else if (menuChoice == 7)
            {
                running = false;
                Console.WriteLine("Quitting...");
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine();
            }

        }
    }
}
