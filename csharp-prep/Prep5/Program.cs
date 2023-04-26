using System;

class Program {
    
    static void DisplayWelcome() {
        Console.WriteLine("Ayo wassup");
    }

    static string PromptUserName() {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber() {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int val) {
        return val * val;
    }

    static void DisplayResult(string name, int val) {
        Console.WriteLine($"{name}, the sqaure of your number is {val}");
    }

    static void Main(string[] args) {
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber())); // goteem
    }
}
