using System;

namespace Learning03 {
    class Program {
        static void Main(string[] args) {
            Assignment test1 = new Assignment("Preston", "Calculus");
            Console.WriteLine(test1.GetSummary());

            MathAssignment test2 = new MathAssignment("Yeetus", "Algebra", "8.6", "1-15");
            Console.WriteLine(test2.GetSummary());
            Console.WriteLine(test2.GetHomeworkList());

            WritingAssignment test3 = new WritingAssignment("Jacob", "American History", "American Foundations");
            Console.WriteLine(test3.GetSummary());
            Console.WriteLine(test3.GetWritingInformation());
        }
    }
}

