using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment        assign1 = new Assignment       ("Cliff", "CSE 210");
        MathAssignment    math1   = new MathAssignment   ("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment write1  = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(assign1.GetSummary());
        Console.WriteLine();
        Console.WriteLine(math1.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(write1.GetWritingInformation());
    }
}