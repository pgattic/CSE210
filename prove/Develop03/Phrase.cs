using System;
using System.Collections.Generic;

namespace Develop03 {
    public class Phrase {
        List<Word> _phrase;
        List<int> _visibleIndices;
        string _reference;

        public Phrase(string reference, string text) {
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
            /* Returns a string with the verse reference followed by the ConditionalWord of each Word */
            string result = _reference + ":";
            foreach (Word word in _phrase) {
                result += " " + word.getConditionalWord();
            }
            return result;
        }

        public void hideWords(int maxRemoved = 1) {
            /* Sets hidden the amount of words specified, until they are all hidden. */
            for (int i = 0; i < maxRemoved && _visibleIndices.Count > 0; i++) {
                int indexIndex = new Random().Next(0, _visibleIndices.Count);
                int index = _visibleIndices[indexIndex];
                _phrase[index].setHidden();
                _visibleIndices.RemoveAt(indexIndex);
            }
       }

        public int remainingWords() {
            return _visibleIndices.Count;
        }
    }
}

