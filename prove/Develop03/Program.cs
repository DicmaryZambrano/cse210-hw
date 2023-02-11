using System;
using Classes;

class Program
{
    static void Main(string[] args)
    {
        /*List<Scripture> scriptures = GetScriptureList("ScriptureList.csv");*/
        Scripture scripture = GetScripture("ScriptureList.csv");
        Memorizer memorizer = new Memorizer(scripture);
        bool menuLoop;
        do
        {
            Console.Clear();
            menuLoop = MainMenu(scripture,memorizer);
            Console.Clear();
        }
        while (menuLoop);
    }

    static bool MainMenu(Scripture scripture, Memorizer memorizer)
    {
        Console.WriteLine("--- Welcome to your Word Memorizer ---\n");
        Console.WriteLine("Today you will memorize\n");
        Console.WriteLine();
        scripture.DisplayScripture();
        Console.WriteLine();

        Console.WriteLine("Press Enter to hide words");
        Console.WriteLine("Enter quit to exit the program"); 

        string userChoice = Console.ReadLine();

        if (userChoice == "")
        {
            if(memorizer.GetCanHide())
            {
                memorizer.HideWords(3);
            }
            else
            {
                Console.WriteLine("Congratulations! you memorized the scripture");
                Console.ReadLine();
                return false;
            }
        }

        else if (userChoice == "quit")
        {
            Console.WriteLine("GoodBye");
            Console.ReadLine();
            return false;
        }

        return true;
    }

    static Scripture GetScripture(string filePath)
    {
        System.IO.StreamReader file = new System.IO.StreamReader(filePath);
        string separator = ",";
        string line;
        file.ReadLine();
        line = file.ReadLine();

        string[] row = line.Split(separator);
        string name = row[0];
        string chapter = (row[1]);
        string verseStart = (row[2]);
        string verseEnd = (row[3]);
        string filename = (row[4]);

        System.IO.StreamReader verseFile = new System.IO.StreamReader(filename);
        List<string> verses = System.IO.File.ReadAllLines(filename).ToList<string>();
        
        Scripture scripture = new Scripture(name, chapter, verseStart, verseEnd, verses);

        return scripture;
    }

    /*static List<Scripture> GetScriptureList(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();

        System.IO.StreamReader file = new System.IO.StreamReader(filePath);
        string lines;
        file.ReadLine();

        while ((lines = file.ReadLine()) != null)
        {
            List<string> linesArray = lines.Split(',').ToList();

            foreach (string column in linesArray) 
            {
                string name = column[0].ToString();
                string chapter = column[1].ToString();
                string verseStart = column[2].ToString();
                string verseEnd = column[3].ToString();
                string filename = column[4].ToString();

                System.IO.StreamReader verseFile = new System.IO.StreamReader(filename);
                List<string> verses = System.IO.File.ReadAllLines(filename).ToList<string>();
                Scripture scripture = new Scripture(name, chapter, verseStart, verseEnd, verses);

                scriptures.Add(scripture);
            }  
        }*/


        /*string[] lines = System.IO.File.ReadAllLines(filePath);
        foreach(string line in lines)
        {
            string[] columns = line.Split(',');
            foreach (string column in columns) 
            {
                string name = column[0].ToString();
                string chapter = column[1].ToString();
                string verseStart = column[2].ToString();
                string verseEnd = column[3].ToString();
                string filename = column[4].ToString();

                System.IO.StreamReader verseFile = new System.IO.StreamReader(filename);
                List<string> verses = System.IO.File.ReadAllLines(filename).ToList<string>();
                Scripture scripture = new Scripture(name, chapter, verseStart, verseEnd, verses);

                scriptures.Add(scripture);
            }
        }

        return scriptures;

    }*/

    /*static Scripture PickRandomScripture(List<Scripture> scriptures)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, scriptures.Count());

        Scripture scripture = scriptures[randomIndex];

        return scripture;
    }*/
        
}