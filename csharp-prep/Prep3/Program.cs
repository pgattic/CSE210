using System;

namespace Prep3 {
    class Program {
        static void Main(string[] args) {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guesses = 0;

            Console.WriteLine($"Random number: {number}");
            int guess;
            do {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;

                if (guess != number) {
                    Console.WriteLine("Incorrect, sorry");
                }
            } while (guess != number);
            Console.WriteLine($"Correct! Number of guesses: {guesses}");
        }
    }
}
