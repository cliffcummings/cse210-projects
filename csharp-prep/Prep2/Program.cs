using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter;
        string sign = "";
        int remainder = number % 10;
        // Console.WriteLine($"DEBUG: remainder is {remainder}");

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (remainder >= 7 && number < 90 && number > 59)
        {
            sign = "+";
        }
        else if (remainder <3 && number > 59)
        {
            sign = "-";
        }

        Console.WriteLine($"You grade is: {letter}{sign}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the course");
        }
        else
        {
            Console.WriteLine("Please re-take the course to receive a passing grade");
        }
    }
}