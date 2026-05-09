using System;

class GuessMyNumberGame
{
    static void Main()
    {
        Random random = new Random();
        bool playAgain = true;

        while (playAgain)
        {
            int magicNumber = random.Next(1, 101);
            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("\n--- Guess My Number ---");
            Console.WriteLine("The computer has chosen a magic number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guess(es).");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();
            playAgain = (response == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}