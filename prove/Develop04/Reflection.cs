using System;
using System.Threading;

namespace Develop04 {
    public class Reflection : Activity {

        private string[] _prompts = {"Think of a time when you stood up for someone else.", 
                                    "Think of a time when you did something really difficult.", 
                                    "Think of a time when you helped someone in need.", 
                                    "Think of a time when you did something truly selfless."};

        private string[] _questions = {"Why was this experience meaningful to you?", 
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"};


        public Reflection(int seconds) : base(seconds) {
            base.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            base.SetType("Reflection");
        }

        private void DisplayRandomPrompt() {
            Console.WriteLine(_prompts[new Random().Next(0, _prompts.Length)]);
        }

        private void DisplayRandomQuestion() {
            Console.WriteLine(_questions[new Random().Next(0, _questions.Length)]);
        }

        public override void Start() {
            DisplayRandomPrompt();

            double time = base.GetTime();
            Thread.Sleep(5000);

            while (time > 0) {
                foreach (char s in base.GetAnimationString()) {
                    if (time % 5 == 0) {
                        DisplayRandomQuestion();
                    }
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b");
                    time -= 0.5;
                }
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
