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
                    string result = Console.ReadLine();
                    if (result.Equals("q"))
                    {
                        break;
                    }
                    guess = int.Parse(result);
                }
                catch (Exception)
                {
                    Console.WriteLine("Input a number!");
                    continue;
                }
                
                if (guess == number)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Well done, you win!");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }

                if (guess < number)
                {
                    direction = "higher";
                } else
                {
                    direction = "lower";
                }

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try again! Guess " + direction + " this time, or input 'q' to quit.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hope to see you again soon!");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
