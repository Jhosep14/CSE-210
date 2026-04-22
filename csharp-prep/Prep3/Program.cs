using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string response;

        do 
        {
            int magic_number = randomGenerator.Next(1, 11);
            int guess = -1000;
            int guessCount = 0;
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("You have to guess a magic number between 1 and 10.");
            while (guess != magic_number)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < magic_number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magic_number)
                {
                    Console.WriteLine("Lower");
                }
                guessCount++;
            }
            Console.WriteLine("You got it!");
            Console.WriteLine($"You guessed it in {guessCount} guesses.");
            Console.Write("Do you want to play again? (yes/no): ");
            response = Console.ReadLine();
        } while (response == "yes");
        Console.WriteLine("Thanks for playing!");
    }
}
