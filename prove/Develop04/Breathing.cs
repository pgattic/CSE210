using System;
using System.Threading;

namespace Develop04 {
    public class Breathing : Activity {
        
        public Breathing(int seconds) : base(seconds) {
            base.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            base.SetType("Breathing");
        }

        public Breathing() : base(30) {
            base.SetStartMsg("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            base.SetType("Breathing");
        }

        public override void Start () {
            int timeLeft = base.GetTime();
            int cycle = 0;

            while (timeLeft > 0) {
                if (cycle % 2 == 0) {
                    Console.Write("Breathe in... ");
                } else {
                    Console.Write("Breathe out... ");
                }
                do {
                    Console.Write((timeLeft - 1) % 5 + 1);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                    timeLeft--;
                } while (timeLeft % 5 != 0);
                Console.WriteLine();
                cycle++;
            }
            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
        }
    }
}
