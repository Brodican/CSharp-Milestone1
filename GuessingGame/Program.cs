using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string direction = "";
            Random rndm = new Random();
            int guess = 0;
            int number = 0;
            number = rndm.Next(1, 20);
            Console.WriteLine("Guess a number between 1 and 20!");

            while (true)
            {
                try
                {
                    guess = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a number!");
                    continue;
                }
                
                if (guess == number)
                    break;

                if (guess < number)
                {
                    direction = "higher";
                } else
                {
                    direction = "lower";
                }

                Console.WriteLine("Try again! Guess " + direction + " this time.");
            }

            Console.WriteLine("Well done, you win!");
        }
    }
}
