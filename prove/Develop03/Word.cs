using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Word
    {
        private string _word;
        private bool _hidden;

        public Word()
        {
            _word = "word";
            _hidden = false;
        }

        public Word(string word)
        {
            _word = word;
            _hidden = false;
        }

        public Word(string word, bool hidden)
        {
            _word = word;
            _hidden = hidden;
        }

        public string getWord()
        {
            if(_hidden)
            {
                string hiddenWord = new string('_', _word.Length);
                return hiddenWord;
            }
            else
            {
                return _word;
            }
            
        }
        public bool getHideState()
        {
            return _hidden;
        }

        public void setWord(string word)
        {
            _word = word;
        }

        public void setAsHidden(bool hidden)
        {
            _hidden = hidden;
        }
    }
}