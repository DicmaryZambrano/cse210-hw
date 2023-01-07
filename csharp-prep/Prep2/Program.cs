using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What are your points? ");

        string textValue = Console.ReadLine();

        int grade;
        grade = int.Parse(textValue);

        int secondDigit;
        secondDigit =  grade % 10;

        string gradeSign;
        gradeSign = "";

        string gradeLetter;
        gradeLetter = "";

        bool sucsses;
        sucsses = false;

        if (grade >= 90)
        {
            gradeLetter = "A";
            sucsses = true;
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
            sucsses = true;
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
            sucsses = true;
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }


        if (secondDigit >= 7)
        {
            gradeSign = "+";
        }
        else if (secondDigit < 3)
        {
            gradeSign = "-";
        }
        else
        {
            gradeSign = "";
        }        

        if (gradeLetter == "A" && gradeSign == "+")
        {
            gradeSign = "";
        }
        if (gradeLetter == "F")
        {
            gradeSign = "";
        }

        Console.WriteLine($"your final grade is {gradeLetter}{gradeSign}");

        if (sucsses)
        {
            Console.WriteLine("Congratulations you passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}