using System;
using System.Collections.Generic;

namespace Develop03 {
    public class Scriptures {
        string[] references = {
            "Helaman 5:12"
        };
        string[] scriptures = {
            "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall."
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

