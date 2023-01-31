using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction(5);
        Fraction thirdFraction = new Fraction(3,4);
        Fraction fourtFraction = new Fraction(1,3);

        Console.WriteLine(firstFraction.GetBottom());
        Console.WriteLine(firstFraction.GetTop());
        Console.WriteLine(secondFraction.GetBottom());
        Console.WriteLine(secondFraction.GetTop());
        Console.WriteLine(thirdFraction.GetBottom());
        Console.WriteLine(thirdFraction.GetTop());
        */

        Fraction firstFraction = new Fraction();
        Fraction secondFraction = new Fraction(5);
        Fraction thirdFraction = new Fraction(3,4);
        Fraction fourtFraction = new Fraction(1,3);

        Console.WriteLine(firstFraction.GetFractionString());
        Console.WriteLine(firstFraction.GetDecimalValue());

        Console.WriteLine(secondFraction.GetFractionString());
        Console.WriteLine(secondFraction.GetDecimalValue());

        Console.WriteLine(thirdFraction.GetFractionString());
        Console.WriteLine(thirdFraction.GetDecimalValue());

        Console.WriteLine(fourtFraction.GetFractionString());
        Console.WriteLine(fourtFraction.GetDecimalValue());

    }
}

