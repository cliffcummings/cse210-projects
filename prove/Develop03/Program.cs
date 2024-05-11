using System;
using System.IO;

//-------------------------------------------------------------------
// STRETCH CHALLENGE - Added to the Scripture class:
// Check the random word indexed by "number".
// If it is already hidden, loop until a random number does not 
// correspond to a hidden word. This guarantees that each scripture
// will hide 3 additional random words each time Enter is pressed. 
// This was easily accomplished using a 4-line while loop.
//-------------------------------------------------------------------
class Program
{
    static void Main(string[] args)
    {
        string fullString;
        string response = "";

        Scripture script = new Scripture("Proverbs 3:5-6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        while (response != "quit")
        {
            Console.Clear();

            fullString = script.GetDisplayText() + "\n";
            Console.WriteLine(fullString);

            // When the scrpiture is completely hidden, break out of the while loop to terminate
            if (script.IsCompletelyHidden())
            {
                Console.WriteLine("All words are now hidden - Memorization is complete\n");
                break;
            }

            script.HideRandomWords(3);

            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
        }
    }
}