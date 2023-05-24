using System;
using System.Collections.Generic;

namespace Develop03 {
    public class Phrase {
        List<Word> _phrase;
        List<int> _visibleIndices;
        string _reference;

        public Phrase(string text, string reference) {
            /* Initialize property values */
            _reference = reference;
            _phrase = new List<Word>();
            _visibleIndices = new List<int>();

            /* separate words into Word objects */
            string[] words = text.Split(" ");
            for (int i = 0; i < words.Length; i++) {
                _phrase.Add(new Word(words[i]));
                _visibleIndices.Add(i);
            }
        }
        
        public string getModifiedPhrase() {
            string result = _reference + ":";
            foreach (Word word in _phrase) {
                result += " " + word.getConditionalWord();
            }
            return result;
        }

        public void hideWords() {
            int indexIndex = new Random().Next(0, _visibleIndices.Count);
            int index = _visibleIndices[indexIndex];
            _phrase[index].setHidden();
            _visibleIndices.RemoveAt(indexIndex);
        }

        public int remainingWords() {
            return _visibleIndices.Count;
        }
    }
}
