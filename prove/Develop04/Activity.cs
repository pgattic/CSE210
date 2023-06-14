using System;
using System.Threading;

namespace Develop04 {
    public abstract class Activity {

        private int _time;
        private string _startMsg;
        private string _type;
        private char[] _animationString = {
            '-',
            '\\',
            '|',
            '/',
        };

        public Activity(int time) {
            _time = time;
        }

        public char[] GetAnimationString () {
            return _animationString;
        }

        public int GetTime() {
            return _time; // seconds
        }

        public void SetStartMsg(string message) {
            _startMsg = message;
        }

        public void SetType(string type) {
            _type = type;
        }

        public void DisplayStartMsg() {
            Console.WriteLine(_startMsg);
        }

        public void DisplayEndMsg() {
            Console.WriteLine($"You have completed {_time} seconds of {_type} Activity!");
        }

        public void BeginPrep() {
            double timer = 5;
            Console.WriteLine($"You have chosen the {_type} Activity.");
            Console.WriteLine("Get ready...");
            while (timer > 0) {
                foreach (char s in _animationString) {
                    Console.Write(s);
                    Thread.Sleep(500);
                    Console.Write("\b");
                    timer -= 0.5;
                }
            }
            Console.Clear();
        }

        public abstract void Start();
    }
}
