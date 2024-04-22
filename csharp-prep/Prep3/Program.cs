using System;
// Prep3 number guessing game.
// Author: Cliff Cummings
// Class: CSE 210
// Used nested do-while loops for the stretch exercises.
class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string magicStr = Console.ReadLine();
        // int magic = int.Parse(magicStr);

        Random randGen = new Random();
        int magic;

        string guessStr;
        int guess;
        int cnt;
        string response = "";

        do
        {
            // Reinitialize the cnt variable and the magic random number for each game.
            // This is the outter do-while loop.
            cnt = 0;
            magic = randGen.Next(1, 100);

            do
            {
                // The inner do-while loop keeps looping until the magic number is guessed
                Console.Write("What is your guess? ");
                guessStr = Console.ReadLine();
                guess = int.Parse(guessStr);
                cnt++;

                if (magic > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magic < guess)
                {
                    Console.WriteLine("Lower");
                }
                else 
                {
                    Console.WriteLine($"You guessed it! It took {cnt} guesses to find the number!");
                }
            } while (magic != guess);

            Console.Write("Would you like to play again? Input 'yes' to play again: ");  
            response = Console.ReadLine(); 
        } while (response == "yes");

        Console.WriteLine("\nGame over\n");
    }
}