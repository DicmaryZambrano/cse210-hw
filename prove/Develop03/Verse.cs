using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Verse
    {
        private string _number;
        private List<Word> _words = new List<Word>();

        public Verse()
        {
            _number = "1";
            _words.Add(new Word("this",false));
            _words.Add(new Word("is",false));
            _words.Add(new Word("a",false));
            _words.Add(new Word("verse",false));
        }
        public Verse(string number, List<Word> words)
        {
            _number = number;
            foreach (Word word in words)
            {
                _words.Add(word);
            }
        }

        public List<Word> getWords()
        {
            return _words;
        }

        public void DisplayVerse()
        {
            List<string> wordStrings = new List<string>();
            foreach (Word word in _words)
            {
                string wordString = word.getWord();
                wordStrings.Add(wordString);
            }
            string verse = string.Join( " ", wordStrings);
            Console.WriteLine($"{_number}: {verse}");
        }
    }
}