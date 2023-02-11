using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Memorizer
    {
        private Scripture _scripture;

        private bool _canHide;

        public Memorizer()
        {
            _scripture = new Scripture();
            _canHide = true;
        }

        public Memorizer(Scripture scripture)
        {
            _scripture = scripture;
            _canHide = true;
        }

        private bool WordsLeft(List<Word> words)
        {
            int hiddenWords = 0;

            foreach (Word word in words)
            {
                if (word.getHideState())
                {
                    hiddenWords += 1;
                }
            }

            if ( hiddenWords == words.Count())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool VersesLeft(List<Verse> verses)
        {
            int hiddenVerses = 0;

            foreach (Verse verse in verses)
            {
                if ((WordsLeft(verse.getWords())!= true))
                {
                    hiddenVerses += 1;
                }
            }

            if ( hiddenVerses == verses.Count())
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool GetCanHide()
        {
            return _canHide;
        }

        public void HideWords(int numberWords)
        {
            int counter = 0;

            List<Verse> verses = _scripture.GetVerses();
            Random rndVerse = new Random();
            int versIndex = rndVerse.Next(0,verses.Count());
            bool getVerseLoop = true;
            
            if(VersesLeft(verses))
            {
                while(getVerseLoop)
                {
                    if (WordsLeft(verses[versIndex].getWords())!= true)
                    {
                        versIndex = rndVerse.Next(0,verses.Count());
                    }
                    else
                    {
                        getVerseLoop = false;
                    }
                }
            }
            else
            {
                counter = numberWords;
                _canHide = false;
            }

            while (counter < numberWords)
            {
                WordPicker wordPicker = new WordPicker();
                string wordToHide = wordPicker.PickWords(verses[versIndex]);

                List<Word> words = verses[versIndex].getWords();

                if(WordsLeft(words))
                {               
                    foreach (Word word in words)
                    {
                        if (word.getWord() == wordToHide)
                        {
                            if (word.getHideState()!= true)
                            {
                                word.setAsHidden(true);
                                counter += 1;
                            }
                        }
                    }
                }
                else
                {
                    counter = numberWords;
                }
            }
        }
    }
}