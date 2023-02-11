using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class WordPicker
    {
        public WordPicker()
        {
        }

        public string PickWords(Verse verse)
        {
            List<Word> words = verse.getWords();
            Random rndWord = new Random();
            int wordIndex = rndWord.Next(0,words.Count());

            string word = words[wordIndex].getWord();

            return word;
        }
    }
}