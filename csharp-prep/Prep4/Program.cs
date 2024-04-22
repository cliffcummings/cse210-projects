//---------------------------------------
// Prep4 number lists & manipulations.
// Author: Cliff Cummings
// Class: CSE 210
// Used multiple built-in list methods.
//---------------------------------------
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        string text;
        int number = -1;
        List<int> numbers = new List<int>();
        int tmpBig = 0;
        int tmpSmall = 1000; // Stretch #1 - start with huge smallest possible number
        double sum = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            text = Console.ReadLine();
            number = int.Parse(text);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        foreach (int tmp in numbers)
        {
            // Console.WriteLine($"DEBUG: {tmp}");
            sum += tmp;
            if (tmp > tmpBig)
            {
                tmpBig = tmp;
            }
            // Stretch #1 - find smallest positive number
            if (tmp < tmpSmall && tmp > 0)
            {
                tmpSmall = tmp;
            }
        }

        double avg = sum / numbers.Count();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {tmpBig}");
        Console.WriteLine($"The smallest positive number is: {tmpSmall}"); // Stretch #1

        // Stretch #2 - Sort and print the numbers list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int tmp in numbers)
        {
            Console.WriteLine($"{tmp}");
        }
    }
}
