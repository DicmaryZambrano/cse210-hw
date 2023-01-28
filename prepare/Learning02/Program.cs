using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Game Developer";
        job1._company = "PlayStation";
        job1._startYear = 2002;
        job1._endYear = 2007;

        Job job2 = new Job();
        job2._jobTitle = "Concept Artist";
        job2._company = "Blizard Entretaiment";
        job2._startYear = 2020;
        job2._endYear = 2022;

        Resume myResume = new Resume();
        myResume._name = "Dicmary Zambrano";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}