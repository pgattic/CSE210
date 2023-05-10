using System;

namespace Develop02 {
    public class Program {
        static int Choice() {
            int decision;
            while (true) {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("  0: Quit");
                Console.WriteLine("  1: New Entry");
                Console.WriteLine("  2: Display all entries");
                // Console.WriteLine("  3: Export journals as file");
                // Console.WriteLine("  4: Import journals from file");
                Console.Write    ("Your Choice: ");
                decision = Convert.ToInt32(Console.ReadLine());
                if (decision >= 0 && decision <= 2) {
                    Console.WriteLine();
                    return decision;
                }
                Console.WriteLine("Try again: invalid input!");
                Console.WriteLine();
            }
        }
        
        static void Main(string[] args) {
            int decision;
            Journal journal = new Journal();
            Prompts prompts = new Prompts();
            do {
                decision = Choice();
                switch (decision) {
                    case 1:
                        Entry entry = new Entry();

                        string prompt = prompts.GetRandomPrompt();
                        Console.Write(prompt + ' ');

                        string response = Console.ReadLine();

                        entry.Store(prompt, response, DateTime.Now.ToString());
                        journal.StoreEntry(entry);

                        Console.WriteLine();
                        break;
                    case 2:
                        foreach (Entry ent in journal.GetAllEntries()) {
                            Console.WriteLine(ent.GetAsString());
                        }
                        break;
                }
            } while (decision != 0);
            Console.WriteLine("Goodbye!");
        }
    }
}
