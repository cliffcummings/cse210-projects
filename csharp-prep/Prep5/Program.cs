//---------------------------------------
// Prep5 - C# Functions.
// Author: Cliff Cummings
// Class: CSE 210
// Initial use of C# functions.
//---------------------------------------
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        // Console.WriteLine($"DEBUG: Name entered is {name}");
        int number = PromptUserNumber();
        // Console.WriteLine($"DEBUG: Number entered is {number}");
        int square = SquareNumber(number);
        // Console.WriteLine($"DEBUG: The number squared is {square}");
        DisplayResult(name, square);
    }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            // In the solution file, the above two lines are combined as:
            // int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int num)
        {
            int square = num * num;
            return square;
        }
        static void DisplayResult(string name, int num)
        {
            Console.WriteLine($"{name}, the square of your number is {num}");
        }
}