using System;
using System.Collections.Generic;
using System.Text;

namespace Foundation1
{
    class Comment
    {
        private string _author;
        private string _text;

        public Comment(string author, string text)
        {
            _author = author;
            _text = text;
        }

        public void Display()
        {
            Console.WriteLine($"    {_author}: \n   {_text}");
        }
    }
}
