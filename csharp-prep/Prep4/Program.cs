using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Please enter a series of numbers, type 0 to stop: ");
            string numberInput = Console.ReadLine();

            number = int.Parse(numberInput);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        int total = numbers.Count;
        Console.WriteLine($"total numbers: {total}");

        int sum = numbers.Sum();
        Console.WriteLine($"sum of the numbers: {sum}");

        float avarage = (float)sum / total;
        Console.WriteLine($"avarage of the numbers: {avarage}");

        int max = numbers.Max();
        Console.WriteLine($"biggest number of the numbers: {max}");

    }
}