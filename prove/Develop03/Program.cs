using System;

namespace Develop03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Press Enter to hide more of the verse, type \"quit\" to quit.");
            if ("quit".Equals(Console.ReadLine().ToLower())) { Environment.Exit(0); }

            Scriptures scriptures = new Scriptures();

            int verseId = scriptures.getRandomIndex();
            
            Phrase verse = new Phrase(scriptures.getText(verseId), scriptures.getRef(verseId));
            while (verse.remainingWords() > 0) {
                Console.Clear();
                Console.WriteLine(verse.getModifiedPhrase());
                if ("quit".Equals(Console.ReadLine().ToLower())) { break; }
                verse.hideWords();
            }
            Console.Clear();
            Console.WriteLine(verse.getModifiedPhrase());
        }
    }
}

