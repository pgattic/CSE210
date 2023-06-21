using System;
using System.Collections.Generic;

namespace Develop04 {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Namaste!");

            string choice;
            Activity activity = null;

            do {
                Console.Write("Gimme your selection\n 1: Breathing\n 2: Listing\n 3: Reflection\n Anything else: quit\n?: ");
                choice = Console.ReadLine();
                switch (choice) {
                    case "1":
                        Console.Write("How much time? ");
                        activity = new Breathing(int.Parse(Console.ReadLine()));
                        break;
                    case "2":
                        Console.Write("How much time? ");
                        activity = new Listing(int.Parse(Console.ReadLine()));
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("How much time? ");
                        activity = new Reflection(int.Parse(Console.ReadLine()));
                        Console.Clear();
                        break;
                }
                if (activity != null) {
                    Console.Clear();

                    activity.BeginPrep();
                    activity.Start();
                    Console.Clear();
                    activity = null;
                }
            } while (new List<string>(){"1", "2", "3"}.Contains(choice));
        }
    }
}
