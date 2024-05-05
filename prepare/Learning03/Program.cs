using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing constructor #1");

        Fraction f1 = new Fraction();       
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetFractionValue());

        Console.WriteLine("Testing constructor #2");

        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetFractionValue());

        Console.WriteLine("Testing constructor #3");

        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetFractionValue());

        Console.WriteLine("Testing the Learning Activity values");

        Fraction f4 = new Fraction();
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetFractionValue());

        Fraction f5 = new Fraction(5);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetFractionValue());

        Fraction f6 = new Fraction(3, 4);
        Console.WriteLine(f6.GetFractionString());
        Console.WriteLine(f6.GetFractionValue());

        Fraction f7 = new Fraction(1, 3);
        Console.WriteLine(f7.GetFractionString());
        Console.WriteLine(f7.GetFractionValue());
    }
}