using System;

class Program
{
    static void Main(string[] args)
    {
        // instance of an actual object
        Book book1 = new Book("Harry Potter","JK Rowlning", 400);

        Book book2 = new Book("Monstand","Genshin", 100);

        Console.WriteLine($"{book1.title},{book1.author},{book1.pages}");
        
        Console.WriteLine($"{book2.title},{book2.author},{book2.pages}");

        Console.WriteLine(book1.HasHonors());
        Console.WriteLine(book2.HasHonors());

        Console.WriteLine($"Hello Doki World!");
    }
}