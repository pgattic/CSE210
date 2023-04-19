using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade (percentage? ");
        float grade = int.Parse(Console.ReadLine());

        char letterGrade;
        char? letterMod = null;
        bool showMod = false;
        if (grade % 10 >= 7) {
            letterMod = '+';
        } else if (grade % 10 < 3) {
            letterMod = '-';
        };
        bool failing = false;

        double gradeDec = Math.Floor(grade/10);
        switch (gradeDec) {
            case 8:
                letterGrade = 'B';
                showMod = true;
                break;
            case 7:
                letterGrade = 'C';
                showMod = true;
                break;
            case 6:
                letterGrade = 'D';
                showMod = true;
                failing = true;
                break;
            case 5:
            case 4:
            case 3:
            case 2:
            case 1:
            case 0:
                letterGrade = 'F';
                failing = true;
                break;
            default:
                letterGrade = 'A';
                if (grade < 93) {
                    letterMod = '-';
                    showMod = true;
                }
                break;
        }
        if (letterMod == null || !showMod) {
            Console.WriteLine($"Your Letter grade is {letterGrade}.");
        } else {
            Console.WriteLine($"Your Letter grade is {letterGrade}{letterMod}.");
        }
        if (failing) {
            Console.WriteLine("That's actually a pretty low grade though. You'll get it though, keep trying!");
        } else {
            Console.WriteLine("Wow, you're doing great! Keep it up!");
        }
    }
}
