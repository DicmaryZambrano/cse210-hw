using System;

class Program
{
    static void Main(string[] args)
    {
        string loop = "yes";
        int lives = 10;

        Console.WriteLine("whats number range will you use? ");
        string rangeInput = Console.ReadLine();
        int range = int.Parse(rangeInput);

        Random rnd = new Random();
        int magicNumber = rnd.Next(range);

        while (loop == "yes")
        {
            Console.WriteLine("whats your guess? ");
            string guessInput = Console.ReadLine();
            int guessNumber = int.Parse(guessInput);

            if (lives != 0)
            {
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                    lives = lives - 1;
                    Console.WriteLine($"You have {lives} lives left");
                }

                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                    lives = lives - 1;
                    Console.WriteLine($"You have {lives} lives left");
                }

                else
                {
                    Console.WriteLine("You guessed the magic number!");
                    Console.WriteLine($"You won with {lives} lives left");

                    Console.WriteLine("Do you want to play again? (yes/no)");
                    string playAgain = Console.ReadLine();
                    loop = playAgain;
                }    
            }

            else
            {
                Console.WriteLine("You ran out of lives! better luck next time");
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine();
                loop = playAgain;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}