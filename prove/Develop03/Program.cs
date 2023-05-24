using System;

namespace Develop03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Press Enter to hide more of the verse, type \"quit\" to quit.");
            if ("quit".Equals(Console.ReadLine().ToLower())) { Environment.Exit(0); }

            /* Initialize items */
            Scriptures scriptures = new Scriptures();
            int verseId = scriptures.getRandomIndex();
            Phrase verse = new Phrase(scriptures.getRef(verseId), scriptures.getText(verseId));

            /* "Display/hide" loop */
            while (verse.remainingWords() > 0) {
                Console.Clear();
                Console.WriteLine(verse.getModifiedPhrase());
                if ("quit".Equals(Console.ReadLine().ToLower())) { Environment.Exit(0); }
                verse.hideWords(4);
            }
            Console.Clear();
            Console.WriteLine(verse.getModifiedPhrase());
        }
    }
}

