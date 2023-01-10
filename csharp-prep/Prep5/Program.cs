using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayMessage()
        {
            Console.WriteLine("Hello world!");
        }
        DisplayMessage();

        static string PromptUser()
        {
            Console.WriteLine("Please enter your username: ");
            string userName = Console.ReadLine();
            return userName;
        }
        string userName = PromptUser();

        static void DisplayUsername(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        DisplayUsername(userName);

        static int PromptNumber()
        {
            Console.WriteLine("Please enter your number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            return number;
        }
        int number = PromptNumber();

        static void PrintNumbers(int number)
        {
            Console.WriteLine($"your favorite number is {number}");
        }
        PrintNumbers(number);

        static int GetSquare(int number, string userName)
        {
            int squaredNumber = number * number;
            return squaredNumber;
        }
        int square = GetSquare(number, userName);

        static void PrintSquare(string userName, int square, int number)
        {
            Console.WriteLine($"{userName}, The squeare of {number} is {square}");
        }
        PrintSquare(userName,square,number);
    }
}