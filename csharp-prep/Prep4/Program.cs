using System;
using System.Collections.Generic;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int nextInput;
        List<int> words = new List<int>();

        do {
            Console.Write("Enter a number: ");
            nextInput = int.Parse(Console.ReadLine());
            words.Add(nextInput);
        } while (nextInput != 0);

        Console.WriteLine("Done!");
        Console.WriteLine($"The sum is: {words.Sum()}");
        Console.WriteLine($"The average is: {words.Average()}");
        Console.WriteLine($"The largest number is: {words.Max()}");
    }
}
