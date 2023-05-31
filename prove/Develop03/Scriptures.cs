using System;

namespace Develop03 {
    public class Scriptures {
        /* Collections of references and their verses, index-alike */
        string[] references = {
            "Helaman 5:12",
            "John 3:16"
        };
        string[] scriptures = {
            "And now, my sons, remember, remember that it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation; that when the devil shall send forth his mighty winds, yea, his shafts in the whirlwind, yea, when all his hail and his mighty storm shall beat upon you, it shall have no power over you to drag you down to the gulf of misery and endless wo, because of the rock upon which ye are built, which is a sure foundation, a foundation whereon if men build they cannot fall.",
            "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        };

        public int getRandomIndex() {
            return new Random().Next(0, references.Length);
        }

        public string getRef(int idx) {
            return references[idx];
        }

        public string getText(int idx) {
            return scriptures[idx].Trim();
        }
    }
}

