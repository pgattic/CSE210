using System;
using System.Collections.Generic;

namespace Develop04 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Namaste!");

            string choice;

            do {
                Console.Write("Gimme your selection\n 1: Breathing\n 2: Listing\n 3: Reflection\n Anything else: quit\n?: ");
                choice = Console.ReadLine();
                switch (choice) {
                    case "1":
                        Console.Write("How much time? ");
                        Breathing breathing = new Breathing(int.Parse(Console.ReadLine()));
                        Console.Clear();

                        breathing.BeginPrep();
                        breathing.Start();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("How much time? ");
                        Listing listing = new Listing(int.Parse(Console.ReadLine()));
                        Console.Clear();

                        listing.BeginPrep();
                        listing.Start();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("How much time? ");
                        Reflection reflection = new Reflection(int.Parse(Console.ReadLine()));
                        Console.Clear();

                        reflection.BeginPrep();
                        reflection.Start();
                        Console.Clear();
                        break;
                }
            } while (new List<string>(){"1", "2", "3"}.Contains(choice));
        }
    }
}
