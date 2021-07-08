using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Right";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            int retryCount = 0;
            int retryLimit = 2;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();

                    if (guessCount != retryLimit)
                    {
                        Console.WriteLine("You are wrong. \nKindly try again");
                        Console.ReadLine();
                        retryCount++;
                    }
                    guessCount++;
                }
               
                else
                {
                    outOfGuesses = true;
                }
            }
            
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.Write("You win!");
            }
            Console.ReadLine();
        }

    }
}
