using System;
using System.Threading;
using System.Threading.Tasks;

namespace Develop04 {
    class Listing : Activity {
        bool _running = true;
        int _list = 0;
        private string[] _prompts = {"Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"};

        public Listing(int seconds): base(seconds) {
            base.SetStartMsg("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            base.SetType("Listing");
        }

        public Listing(): base(30) {
            base.SetStartMsg("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            base.SetType("Listing");
        }

        private Task TimerEnd() {
            Thread.Sleep(base.GetTime() * 1000);
            _running = false;
            return Task.CompletedTask;
        }

        private void UserInputThread() {
            while (_running) {
                Console.ReadLine();
                _list++;
            }
        }

        private void DisplayRandomPrompt() {
            Console.WriteLine(_prompts[new Random().Next(0, _prompts.Length)]);
        }

        public override async void Start() {
            Thread inputThread = new Thread(UserInputThread);

            DisplayRandomPrompt();

            inputThread.Start();

            await TimerEnd();
            Console.WriteLine();
            Console.WriteLine($"You Listed {_list} items!");
            Console.WriteLine("Press Enter to return to the menu.");
            inputThread.Join();
        }
    }
}

