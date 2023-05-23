using System;
using System.Collections.Generic;

namespace Develop03 {
    public class Scriptures {
        string[] references = {
            "1 Nephi 1:1"
        };
        string[] scriptures = {
            "And it came to pass..."
        };

        public Scriptures() {}

        public int getRandomIndex() {
            return new Random().Next(0, references.Length);
        }

        public string getRef(int idx) {
            return references[idx];
        }

        public string getText(int idx) {
            return scriptures[idx];
        }
    }
}

