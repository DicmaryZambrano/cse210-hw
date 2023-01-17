using System;

// the templace for the object we want to create
class Book
{
    public string title;
    public string author;
    public int pages;

    //Constructors, the constructor is a special method
    // thats going to be called when creating an object
    public Book(string aTitle, string aAuthor, int aPages)
    {
        title = aTitle;
        author = aAuthor;
        pages = aPages;
    }

    public bool HasHonors()
    {
        if (pages >= 200)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}