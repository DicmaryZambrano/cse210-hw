using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Scripture
    {
        private Reference _reference;
        private List<Verse> _verses = new List<Verse>();

        public Scripture()
        {
            Reference reference = new Reference();
            _reference = reference;

            Verse verse = new Verse();
            _verses.Add(verse);
        }

        public Scripture(string name, string chapter, string verseStart, List<string> verses)
        {
            Reference reference = new Reference(name,chapter,verseStart);
            _reference = reference;

            foreach (string line in verses)
            {
                List<string> wordStrings = line.Split(" ").ToList<string>();
                string number = wordStrings[0];
                wordStrings.RemoveAt(0);

                List<Word> words = new List<Word>();

                foreach (string wordString in wordStrings)
                {
                    Word word = new Word(wordString);
                    words.Add(word);
                }
                
                Verse verse = new Verse(number,words);
                _verses.Add(verse);
            
            }
        }

        public Scripture(string name, string chapter, string verseStart,string verseEnd, List<string> verses)
        {
            Reference reference = new Reference(name,chapter,verseStart,verseEnd);
            _reference = reference;

            foreach (string line in verses)
            {
                List<string> wordStrings = line.Split(" ").ToList<string>();
                string number = wordStrings[0];
                wordStrings.RemoveAt(0);

                List<Word> words = new List<Word>();

                foreach (string wordString in wordStrings)
                {
                    Word word = new Word(wordString);
                    words.Add(word);
                }

                Verse verse = new Verse(number,words);
                _verses.Add(verse);
            
            }
        }

        public List<Verse> GetVerses()
        {
            return _verses;
        }

        public void DisplayScripture()
        {
            _reference.DisplayReference();
            Console.WriteLine();
            foreach (Verse verse in _verses)
            {
                Console.WriteLine();
                verse.DisplayVerse();
            }

        }
    }
}