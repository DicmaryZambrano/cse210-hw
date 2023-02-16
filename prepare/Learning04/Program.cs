using System;
using Learning04;

class Program
{
    static void Main(string[] args)
    {
        MathAssigment mathAssignment = new MathAssigment("Samuel Bennett","Multiplication","Section 4.5","Problems 3-12");
        string mathSummary = mathAssignment.GetSummary();
        string homeworkList = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathSummary);
        Console.WriteLine(homeworkList);

        Console.WriteLine();

        WritingAssigment writingAssigment = new WritingAssigment("Samuel Bennertt", "History", "The History of Venezuela");
        string writingSummary = writingAssigment.GetSummary();
        string writingInfo = writingAssigment.GetWritingInfo();
        Console.WriteLine(writingSummary);
        Console.WriteLine(writingInfo);
    }
}