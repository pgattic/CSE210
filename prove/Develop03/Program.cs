using System;

namespace Develop03 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Press Enter to hide more of the verse, type \"quit\" to quit.");
            Console.ReadLine();

            Scriptures scriptures = new Scriptures();

            int verseId = scriptures.getRandomIndex();
            
            Phrase verse = new Phrase(scriptures.getText(verseId), scriptures.getRef(verseId));
            Console.Clear();
            Console.WriteLine(verse.getModifiedPhrase());
            Console.ReadLine();
            while (verse.remainingWords() > 0) {
                verse.hideWords();
                Console.Clear();
                Console.WriteLine(verse.getModifiedPhrase());
                if (Console.ReadLine().ToLower().Equals("quit")) { break; }
            }
        }
    }
}

